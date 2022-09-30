module Fun.Modern.Forms.Builder

open System
open FSharp.Data.Adaptive
open Modern.Forms


type ElementBuilderBase<'T>() =
    let mutable key: obj = null


    member inline _.Yield(_: unit) = ElementBuilder<'T>(fun _ i -> i)


    [<CustomOperation("Key")>]
    member this.Key(builder: ElementBuilder<Form>, x: obj) = key <- x



    member _.GetKey() = key


    member inline _.MakeElementCreator<'Element>
        (
            [<InlineIfLambda>] builder: ElementBuilder<'Element>,
            [<InlineIfLambda>] fn: unit -> 'Element,
            ?key: obj
        ) =
        {
            ElementCreator.Key = Option.toObj key
            CreateOrUpdate =
                fun (sp, ctx) ->
                    let newCtx =
                        match ctx with
                        | ValueNone -> new ElementContext<'Element>(fn (), sp)
                        | ValueSome ctx -> unbox ctx
                    builder.Invoke(newCtx, 0) |> ignore
                    newCtx
        }


    member inline _.MakeEventPropertyBuilder<'Element, 'EventArg>
        (
            [<InlineIfLambda>] builder: ElementBuilder<'Element>,
            [<InlineIfLambda>] getEvent: ElementContext<'Element> -> IEvent<System.EventHandler<'EventArg>, 'EventArg>,
            propertyName: string,
            [<InlineIfLambda>] fn: 'EventArg -> unit
        ) =
        ElementBuilder<'Element>(fun ctx index ->
            let event = getEvent ctx
            let index = builder.Invoke(ctx, index)
            let propertyName = propertyName + "-" + string index

            if ctx.Properties.ContainsKey propertyName then
                event.RemoveHandler(unbox ctx.Properties[propertyName])

            let handler = EventHandler<'EventArg>(fun _ e -> fn e)
            ctx.Properties[ propertyName ] <- handler
            event.AddHandler handler

            index + 1
        )


    member inline _.MakeCompareablePropertyBuilder<'Element, 'Property when 'Property: equality>
        (
            [<InlineIfLambda>] builder: ElementBuilder<'Element>,
            [<InlineIfLambda>] getProperty: ElementContext<'Element> -> 'Property,
            [<InlineIfLambda>] setProperty: ElementContext<'Element> -> 'Property -> unit,
            value: 'Property
        ) =
        ElementBuilder<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            if getProperty ctx <> value then setProperty ctx value
            index + 1
        )


    member inline _.MakeAdaptivePropertyBuilder<'Element, 'Property when 'Property: equality>
        (
            [<InlineIfLambda>] builder: ElementBuilder<'Element>,
            [<InlineIfLambda>] getProperty: ElementContext<'Element> -> 'Property,
            [<InlineIfLambda>] setProperty: ElementContext<'Element> -> 'Property -> unit,
            value: 'Property aval
        ) =
        ElementBuilder<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let propertyName = "store-prop-" + string index

            if ctx.Properties.ContainsKey propertyName then
                match ctx.Properties[propertyName] with
                | :? IDisposable as x -> x.Dispose()
                | _ -> ()

            ctx.Properties[ propertyName ] <- value.AddCallback(fun x -> if getProperty ctx <> x then setProperty ctx x)

            index + 1
        )


    member _.MakeChildrenBuilder<'Element>
        (
            builder: ElementBuilder<'Element>,
            getNativeElements: ElementContext<'Element> -> Control.ControlCollection,
            children: ElementCreator seq
        ) =
        ElementBuilder<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let childrenLength = Seq.length children
            let nativeElements = getNativeElements ctx
            let sp = (ctx :> IElementContext).ServiceProvider

            if childrenLength = 0 && nativeElements.Count > 0 then
                for child in ctx.ChildrenContexts do
                    child.Dispose()
                ctx.ChildrenContexts.Clear()
                nativeElements.Clear()

            else if childrenLength > 0 then

                if nativeElements.Count = 0 then
                    let newNativeElements = Array.create childrenLength Unchecked.defaultof<Control>

                    let mutable i = 0
                    ctx.ChildrenContexts.Clear()
                    while i < childrenLength do
                        let elementCreator = Seq.item i children
                        let newElementContext = elementCreator.CreateOrUpdate(sp, ValueNone)
                        ctx.ChildrenContexts.Add(newElementContext)
                        newNativeElements[i] <- newElementContext.NativeElement :?> Control
                        i <- i + 1

                    nativeElements.Clear()
                    nativeElements.AddRange newNativeElements

                else
                    let newElementContexts = Array.create childrenLength Unchecked.defaultof<IElementContext>
                    let newNativeElements = Array.create childrenLength Unchecked.defaultof<Control>

                    let mutable i = 0
                    while i < childrenLength do
                        let elementCreator = Seq.item i children

                        let newElementContext =
                            if elementCreator.Key = null then
                                let oldChild = ctx.ChildrenContexts |> Seq.tryItem i
                                match oldChild with
                                | Some ctx when ctx.Key = null -> elementCreator.CreateOrUpdate(sp, ValueSome ctx)
                                | _ -> elementCreator.CreateOrUpdate(sp, ValueNone)
                            else
                                let oldChild = ctx.ChildrenContexts |> Seq.tryFind (fun x -> x.Key = elementCreator.Key)
                                match oldChild with
                                | Some ctx when elementCreator.Key = ctx.Key -> elementCreator.CreateOrUpdate(sp, ValueSome ctx)
                                | _ -> elementCreator.CreateOrUpdate(sp, ValueNone)
                        newElementContexts[i] <- newElementContext
                        newNativeElements[i] <- newElementContext.NativeElement :?> Control
                        i <- i + 1

                    for item in ctx.ChildrenContexts do
                        if Seq.exists ((=) item) newElementContexts |> not then item.Dispose()

                    ctx.ChildrenContexts.Clear()
                    ctx.ChildrenContexts.AddRange newElementContexts
                    nativeElements.Clear()
                    nativeElements.AddRange newNativeElements

            index + 1
        )
