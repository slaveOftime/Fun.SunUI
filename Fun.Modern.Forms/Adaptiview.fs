namespace Fun.Modern.Forms

open System
open FSharp.Data.Adaptive


type ElementAdaptiveContext(eleStore: ElementCreator aval, sp: IServiceProvider, key: obj) =
    let mutable k = null
    let mutable ctx = ValueNone

    let eleSub =
        eleStore.AddCallback(fun creator ->
            k <- creator.Key
            ctx <- ValueSome(creator.CreateOrUpdate(sp, ctx))
        )

    member _.Context = ctx.Value

    interface IElementContext with
        member _.Key
            with get () = k
            and set x = k <- x

        member _.NativeElement = ctx.Value.NativeElement

        member _.ServiceProvider = sp

        member _.Dispose() = eleSub.Dispose()


type AdaptiviewBuilder(?key: obj) =
    inherit AValBuilder()

    member this.Run(store: ElementCreator aval) = {
        ElementCreator.Key = Option.toObj key
        CreateOrUpdate =
            fun (sp, ctx) ->
                let newCtx =
                    match ctx with
                    | ValueNone -> new ElementAdaptiveContext(store, sp, defaultArg key null)
                    | ValueSome ctx -> unbox ctx
                newCtx
    }


type adaptiview = AdaptiviewBuilder
