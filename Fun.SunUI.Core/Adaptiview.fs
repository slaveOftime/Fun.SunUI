namespace Fun.SunUI

open System
open FSharp.Data.Adaptive


type ElementAdaptiveContext(eleStore: ElementCreator aval, sp: IServiceProvider, key: obj) =
    let mutable ctx = ValueNone

    let eleStoreSub =
        eleStore.AddCallback(fun creator ->
            // Maybe need to recreate if key changed
            // But for this we will need to access parent element
            ctx <- ValueSome(creator.CreateOrUpdate(sp, ctx))
        )

    interface IElementContext with
        member val Key = key with get, set
        member _.NativeElement = ctx.Value.NativeElement
        member _.ServiceProvider = sp
        member _.Dispose() = eleStoreSub.Dispose()


/// Used to help return AdaptiviewBuilder return one element without use return keyword
[<Struct>]
type AdaptiveSingleElement = AdaptiveSingleElement of ElementCreator aval


type AdaptiviewBuilder(?key: obj) =
    inherit AValBuilder()


    member inline _.Yield(x: ElementCreator) = AVal.constant x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> ElementCreator aval) = AdaptiveSingleElement(fn ())

    member inline _.Combine(AdaptiveSingleElement elementCreator, builder: aval<_>) =
        AdaptiveSingleElement(
            adaptive {
                let! _ = builder
                return! elementCreator
            }
        )


    member this.Run(AdaptiveSingleElement store) = {
        ElementCreator.Key = Option.toObj key
        CreateOrUpdate =
            fun (sp, ctx) ->
                let newCtx =
                    match ctx with
                    | ValueNone -> new ElementAdaptiveContext(store, sp, defaultArg key null)
                    | ValueSome ctx -> unbox ctx
                newCtx
    }


[<AutoOpen>]
module Adaptiview =

    type UI with

        static member inline adaptive() = AdaptiviewBuilder()
        static member inline adaptive(key) = AdaptiviewBuilder(key)
