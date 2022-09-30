[<AutoOpen>]
module Fun.Modern.Forms.Dsl

open System


type ui =

    static member inline inject([<InlineIfLambda>] fn: InjectElementContext -> ElementCreator, ?key: obj) = {
        ElementCreator.Key = Option.toObj key
        CreateOrUpdate =
            fun (sp, ctx) ->
                let newCtx =
                    match ctx with
                    | ValueNone -> new ElementWrapperContext(fn, sp)
                    | ValueSome ctx -> unbox ctx
                newCtx.Update()
    }
