namespace Fun.SunUI

open System


type ElementInjectContext = {
    ServiceProvider: IServiceProvider
    AddDispose: IDisposable -> unit
}


type ElementInjectviewContext<'UIStack>(creatorFn: ElementInjectContext -> ElementCreator<'UIStack>, sp: IServiceProvider, renderMode) =
    let disposes = ResizeArray<IDisposable>()

    let creator =
        creatorFn
            {
                ServiceProvider = sp
                AddDispose = fun d -> disposes.Add(d)
            }

    let mutable ctx = creator.CreateOrUpdate(sp, ValueNone)

    member _.Update() = ctx <- creator.CreateOrUpdate(sp, ValueSome ctx)

    interface IElementContext with
        member val RenderMode = renderMode with get, set

        member _.NativeElement = ctx.NativeElement
        member _.ServiceProvider = sp

        member _.Dispose() =
            for item in disposes do
                item.Dispose()
            ctx.Dispose()


[<AutoOpen>]
module Injectview =

    type UI with

        static member inline inject([<InlineIfLambda>] fn: ElementInjectContext -> ElementCreator<'UIStack>, ?key) : ElementCreator<'UIStack> = {
            RenderMode = defaultArg key RenderMode.CreateOnce
            CreateOrUpdate =
                fun (sp, ctx) ->
                    match ctx with
                    | ValueNone -> new ElementInjectviewContext<'UIStack>(fn, sp, defaultArg key RenderMode.CreateOnce)
                    | ValueSome ctx ->
                        let newCtx = unbox<ElementInjectviewContext<'UIStack>> ctx
                        newCtx.Update()
                        newCtx
        }

        static member inline inject(key: RenderMode, [<InlineIfLambda>] fn: ElementInjectContext -> ElementCreator<'UIStack>) = UI.inject (fn, key)
