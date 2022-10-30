#nowarn "0020"

namespace Fun.SunUI.HotReload

open System
open System.Collections.Generic
open System.Collections.Concurrent
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.SignalR.Client
open MessagePack
open Fun.SunUI


type private CssChanges = { Name: string; Css: string }

type private HubBundle = {
    Hub: HubConnection
    CodeObserver: aval<(string * FSharp.Compiler.PortaCode.CodeModel.DFile)[]>
    CssObserver: aval<CssChanges>
}


module private Cache =

    let mutable lastRenderFns = ConcurrentDictionary<string, obj>()

    let private hubLocker = obj ()

    let mutable private hubConnections = Dictionary<string, HubBundle>()


    let private makeHubBundle (host: string) =
        let hub = HubConnectionBuilder().WithUrl($"{host}/hot-reload-hub").Build()
        let codeStore = cval<(string * FSharp.Compiler.PortaCode.CodeModel.DFile)[]> ([||])
        let cssStore = cval<CssChanges> ({ Name = ""; Css = "" })

        task {
            printfn "Starting hot-reload hub: %s" host
            hub.On(
                "CodeChanged",
                fun (code: byte[]) ->
                    let sw = System.Diagnostics.Stopwatch.StartNew()
                    printfn "Received raw code changes: %s. Length: %d" host code.Length
                    try
                        let result = FSharp.Compiler.PortaCode.CodeModel.CodeChangesPack.FromBytes code
                        printfn "Code changes deserialized in %d ms: %s" sw.ElapsedMilliseconds host
                        codeStore.Publish result.Changes
                    with ex ->
                        printfn "Process code changes failed: %s" ex.Message
            )
            hub.On<string, string>(
                "CssChanged",
                fun name code ->
                    printfn "Received css %s changes: %s" name host
                    cssStore.Publish { Name = name; Css = code }
                    printfn "css %s changes applied: %s" name host
            )
            do! hub.StartAsync()
            printfn "Started hot-reload hub: %s" host
        }

        {
            Hub = hub
            CodeObserver = codeStore
            CssObserver = cssStore
        }


    let getHubBundle (host: string) =
        let makeNew () =
            let bundle = makeHubBundle host
            hubConnections.[host] <- bundle
            bundle

        lock
            hubLocker
            (fun () ->
                match hubConnections.TryGetValue host with
                | true, bundle ->
                    if
                        bundle.Hub.State = HubConnectionState.Connected
                        || bundle.Hub.State = HubConnectionState.Connecting
                        || bundle.Hub.State = HubConnectionState.Reconnecting
                    then
                        bundle
                    else
                        bundle.Hub.DisposeAsync() |> ignore
                        makeNew ()
                | _ -> makeNew ()
            )


type HotreloadContext<'UIStack, 'T>
    (
        host: string,
        entryName: string,
        renderFn: 'T -> ElementCreator<'UIStack>,
        renderFnArg: 'T,
        dispatcher: (unit -> unit) -> unit,
        sp: IServiceProvider
    ) =

    let mutable renderFnArg = renderFnArg
    let mutable elementCreator = renderFn renderFnArg
    let mutable elementContext = elementCreator.CreateOrUpdate(sp, ValueNone)

    let setRender (creatorFn: 'T -> ElementCreator<'UIStack>) =
        elementCreator <- creatorFn (renderFnArg)
        dispatcher (fun () -> elementContext <- elementCreator.CreateOrUpdate(sp, ValueSome elementContext))

    let hubBundle = Cache.getHubBundle host
    let disposes = [
        hubBundle.CodeObserver.AddInstantCallback(fun code ->
            Utils.reload<'UIStack, 'T>
                entryName
                code
                (fun x ->
                    Cache.lastRenderFns.AddOrUpdate(entryName, (fun _ -> box x), (fun _ _ -> box x))
                    setRender x
                )
        )
    ]


    do
        match Cache.lastRenderFns.TryGetValue entryName with
        | true, x -> setRender (unbox x)
        | _ -> ()


    member _.Rerender() = elementContext <- elementCreator.CreateOrUpdate(sp, ValueSome elementContext)

    member _.RenderFnArg
        with get () = renderFnArg
        and set x = renderFnArg <- x

    interface IElementContext with
        member val RenderMode = RenderMode.CreateOnce with get, set

        member _.NativeElement = elementContext.NativeElement
        member _.ServiceProvider = sp

        member _.Dispose() =
            for d in disposes do
                d.Dispose()


    static member CreateElementCreator<'UIStack, 'T>
        (
            host,
            entryName,
            renderFn: 'T -> ElementCreator<_>,
            renderFnArg: 'T,
            dispatcher: (unit -> unit) -> unit
        ) : ElementCreator<'UIStack> =
        {
            RenderMode = RenderMode.CreateOnce
            CreateOrUpdate =
                fun (sp, ctx) ->
                    match ctx with
                    | ValueNone -> new HotreloadContext<'UIStack, 'T>(host, entryName, renderFn, renderFnArg, dispatcher, sp)
                    | ValueSome ctx ->
                        let newCtx = unbox<HotreloadContext<'UIStack, 'T>> ctx
                        newCtx.RenderFnArg <- renderFnArg
                        newCtx.Rerender()
                        newCtx
        }
