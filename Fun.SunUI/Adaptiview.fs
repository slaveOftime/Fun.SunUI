namespace Fun.SunUI

open System
open FSharp.Data.Adaptive


type ElementAdaptiveContext<'UIStack>(eleStore: ElementCreator<'UIStack> aval, sp: IServiceProvider, renderMode) =
    let mutable ctx = ValueNone

    let eleStoreSub =
        eleStore.AddCallback(fun creator ->
            // Maybe need to recreate if key changed
            // But for this we will need to access parent element
            ctx <- ValueSome(creator.CreateOrUpdate(sp, ctx))
        )

    member _.Update() = ctx <- ValueSome((AVal.force eleStore).CreateOrUpdate(sp, ctx))

    interface IElementContext with
        member val RenderMode = renderMode with get, set
        member _.NativeElement = ctx.Value.NativeElement
        member _.ServiceProvider = sp
        member _.Dispose() = eleStoreSub.Dispose()


/// Used to help return AdaptiviewBuilder return one element without use return keyword
[<Struct>]
type AdaptiveSingleElement<'UIStack> = AdaptiveSingleElement of ElementCreator<'UIStack> aval


type AdaptiviewBuilder<'UIStack>(?renderMode) =
    inherit AValBuilder()


    member inline _.Yield(x: ElementCreator<'UIStack>) = AVal.constant x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<'UIStack> aval) = AdaptiveSingleElement(fn ())

    member inline _.Combine(AdaptiveSingleElement elementCreator, builder: aval<_>) =
        AdaptiveSingleElement(
            adaptive {
                let! _ = builder
                return! elementCreator
            }
        )


    member _.Run(AdaptiveSingleElement store) = {
        ElementCreator.RenderMode = defaultArg renderMode RenderMode.CreateOnce
        CreateOrUpdate =
            fun (sp, ctx) ->
                match ctx with
                | ValueNone -> new ElementAdaptiveContext<'UIStack>(store, sp, defaultArg renderMode RenderMode.CreateOnce)
                | ValueSome ctx ->
                    let newCtx = unbox<ElementAdaptiveContext<'UIStack>> ctx
                    newCtx.Update()
                    newCtx
    }


[<AutoOpen>]
module Adaptiview =

    type UI with

        static member inline adaptive() = AdaptiviewBuilder<'UIStack>()
        static member inline adaptive(renderMode) = AdaptiviewBuilder<'UIStack>(renderMode)
