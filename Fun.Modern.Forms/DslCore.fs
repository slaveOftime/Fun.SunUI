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

    static member inline inject(key: obj, [<InlineIfLambda>] fn: InjectviewContext -> ElementCreator) = ui.inject (fn, key)


    static member inline adaptive() = AdaptiviewBuilder()
    static member inline adaptive(key) = AdaptiviewBuilder(key)
