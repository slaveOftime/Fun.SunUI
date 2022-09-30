namespace Fun.Modern.Forms

open System
open FSharp.Data.Adaptive
open Modern.Forms


type ElementBuildContext<'Element>(nativeElement: 'Element, sp: IServiceProvider, ?key: obj) as this =
    member val Properties = System.Collections.Generic.Dictionary<string, obj>()
    member val ChildContexts = ResizeArray<IElementContext>()

    member _.Element = nativeElement

    interface IElementContext with
        member _.Key = Option.toObj key
        member _.NativeElement = box nativeElement
        member _.ServiceProvider = sp

        member _.Dispose() =
            match tryUnbox<IDisposable> nativeElement with
            | Some x -> x.Dispose()
            | _ -> ()

            for KeyValue (_, property) in this.Properties do
                match tryUnbox<IDisposable> property with
                | Some x -> x.Dispose()
                | _ -> ()


type BuildElement<'Element> = delegate of ctx: ElementBuildContext<'Element> * index: int -> int


type ElementBuilder<'Element>() =
    let mutable key: obj = null


    member inline _.Yield(_: unit) = BuildElement<'T>(fun _ i -> i)


    [<CustomOperation("Key")>]
    member _.Key(builder: BuildElement<'Element>, x: obj) =
        key <- x
        builder

    [<CustomOperation("Ref")>]
    member inline this.Ref([<InlineIfLambda>] builder: BuildElement<'Element>, setRef: 'Element -> unit) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            setRef ctx.Element
            index + 1
        )


    member _.GetKey() = key


    member inline _.MakeElementCreator<'Element>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] fn: unit -> 'Element,
            ?key: obj
        ) =
        {
            ElementCreator.Key = Option.toObj key
            CreateOrUpdate =
                fun (sp, ctx) ->
                    let newCtx =
                        match ctx with
                        | ValueNone -> new ElementBuildContext<'Element>(fn (), sp, Option.toObj key)
                        | ValueSome ctx -> unbox ctx
                    builder.Invoke(newCtx, 0) |> ignore
                    newCtx
        }


    member inline _.MakeEventPropertyBuilder<'Element, 'EventArg>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getEvent: ElementBuildContext<'Element> -> IEvent<System.EventHandler<'EventArg>, 'EventArg>,
            propertyName: string,
            [<InlineIfLambda>] fn: 'EventArg -> unit
        ) =
        BuildElement<'Element>(fun ctx index ->
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
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getProperty: ElementBuildContext<'Element> -> 'Property,
            [<InlineIfLambda>] setProperty: ElementBuildContext<'Element> -> 'Property -> unit,
            value: 'Property
        ) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            if getProperty ctx <> value then setProperty ctx value
            index + 1
        )


    member inline _.MakeAdaptivePropertyBuilder<'Element, 'Property when 'Property: equality>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getProperty: ElementBuildContext<'Element> -> 'Property,
            [<InlineIfLambda>] setProperty: ElementBuildContext<'Element> -> 'Property -> unit,
            value: 'Property aval
        ) =
        BuildElement<'Element>(fun ctx index ->
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
            builder: BuildElement<'Element>,
            getNativeChildren: ElementBuildContext<'Element> -> Control.ControlCollection,
            childrenCreators: ElementCreator seq
        ) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let childrenLength = Seq.length childrenCreators
            let nativeChildren = getNativeChildren ctx
            let sp = (ctx :> IElementContext).ServiceProvider

            if childrenLength = 0 && nativeChildren.Count > 0 then
                for child in ctx.ChildContexts do
                    child.Dispose()
                ctx.ChildContexts.Clear()
                nativeChildren.Clear()

            else if childrenLength > 0 then

                if nativeChildren.Count = 0 then
                    let newNativeElements = Array.create childrenLength Unchecked.defaultof<Control>

                    let mutable i = 0
                    ctx.ChildContexts.Clear()
                    while i < childrenLength do
                        let childCreator = Seq.item i childrenCreators
                        let newChildContext = childCreator.CreateOrUpdate(sp, ValueNone)
                        ctx.ChildContexts.Add(newChildContext)
                        newNativeElements[i] <- newChildContext.NativeElement :?> Control
                        i <- i + 1

                    nativeChildren.Clear()
                    nativeChildren.AddRange newNativeElements

                else
                    let newChildrenContexts = Array.create childrenLength Unchecked.defaultof<IElementContext>
                    let newNativeChildren = Array.create childrenLength Unchecked.defaultof<Control>

                    let mutable i = 0
                    while i < childrenLength do
                        let childCreator = Seq.item i childrenCreators

                        let newChildContext =
                            if childCreator.Key = null then
                                let oldChild = ctx.ChildContexts |> Seq.tryItem i
                                match oldChild with
                                | Some ctx when ctx.Key = null -> childCreator.CreateOrUpdate(sp, ValueSome ctx)
                                | _ -> childCreator.CreateOrUpdate(sp, ValueNone)
                            else
                                let oldChild = ctx.ChildContexts |> Seq.tryFind (fun x -> x.Key = childCreator.Key)
                                match oldChild with
                                | Some ctx when childCreator.Key = ctx.Key -> childCreator.CreateOrUpdate(sp, ValueSome ctx)
                                | _ -> childCreator.CreateOrUpdate(sp, ValueNone)
                        newChildrenContexts[i] <- newChildContext
                        newNativeChildren[i] <- newChildContext.NativeElement :?> Control
                        i <- i + 1

                    for item in ctx.ChildContexts do
                        if Seq.exists ((=) item) newChildrenContexts |> not then item.Dispose()

                    ctx.ChildContexts.Clear()
                    ctx.ChildContexts.AddRange newChildrenContexts
                    nativeChildren.Clear()
                    nativeChildren.AddRange newNativeChildren

            index + 1
        )
