[<AutoOpen>]
module Fun.Modern.Forms.Dsl


type ui =

    static member inline inject([<InlineIfLambda>] fn: InjectviewContext -> ElementCreator, ?key: obj) = {
        ElementCreator.Key = Option.toObj key
        CreateOrUpdate =
            fun (sp, ctx) ->
                let newCtx =
                    match ctx with
                    | ValueNone -> new ElementInjectviewContext(fn, sp)
                    | ValueSome ctx -> unbox ctx
                newCtx.Update()
    }
