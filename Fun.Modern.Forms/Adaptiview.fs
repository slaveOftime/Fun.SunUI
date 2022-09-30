namespace Fun.Modern.Forms

open System
open FSharp.Data.Adaptive


type ElementAdaptiveContext(eleStore: ElementCreator aval, sp: IServiceProvider, key: obj) =
    let mutable k = null
    let mutable ctx = ValueNone

    let eleStoreSub =
        eleStore.AddCallback(fun creator ->
            k <- creator.Key
            ctx <- ValueSome(creator.CreateOrUpdate(sp, ctx))
        )

    interface IElementContext with
        member _.Key = k
        member _.NativeElement = ctx.Value.NativeElement
        member _.ServiceProvider = sp
        member _.Dispose() = eleStoreSub.Dispose()


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
