namespace Fun.SunUI

open System
open FSharp.Data.Adaptive
open Fun.SunUI.Internal


type ElementBuildContext<'Element>(nativeElement: 'Element, sp: IServiceProvider, key) as this =
    /// Used to reserve property related thing like event handler for later to clean up.
    member val PropertyResources = System.Collections.Generic.Dictionary<string, obj>()

    member val ChildContexts = ResizeArray<IElementContext>()

    member _.Element = nativeElement

    interface IElementContext with
        member val RenderMode = key with get, set
        member _.NativeElement = box nativeElement
        member _.ServiceProvider = sp

        member _.Dispose() =
            match tryUnbox<IDisposable> nativeElement with
            | Some x -> x.Dispose()
            | _ -> ()

            for KeyValue (_, property) in this.PropertyResources do
                match tryUnbox<IDisposable> property with
                | Some x -> x.Dispose()
                | _ -> ()


type BuildElement<'Element> = delegate of ctx: ElementBuildContext<'Element> * index: int -> int


type ElementBuilder<'UIStack, 'Element>() =
    let mutable renderMode: RenderMode = RenderMode.CreateOnce


    member inline _.Yield(_: unit) = BuildElement<'T>(fun _ i -> i)

    member inline _.Delay([<InlineIfLambda>] fn: unit -> BuildElement<'Element>) = BuildElement<'Element>(fun ctx i -> fn().Invoke(ctx, i))

    member _.For(builder: BuildElement<'Element>, fn: unit -> BuildElement<'Element>) = BuildElement<'Element>(fun ctx i -> fn().Invoke(ctx, i))


    /// Set key to the element builder.
    /// When the parent rerender, it will check the key, if it is changed then it will try to recreate new element and throw old element state and dispose related stuff.
    /// This is used when the parent control will rerender and its children order or number will change when it rerender.
    [<CustomOperation("RenderMode")>]
    member _.RenderMode(builder: BuildElement<'Element>, x) =
        renderMode <- x
        builder


    /// Helper method to get current key
    member _.GetRenderMode() = renderMode


    /// With this we can get some property, and if it is a mutable object then can change it accordingly
    member inline this.MakeGetOnlyBuilder<'T>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getFn: 'Element -> 'T,
            setFn: 'T -> unit
        ) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            setFn (getFn ctx.Element)
            index + 1
        )

    /// With this we can get some property, and if it is a mutable object then can change it adaptively
    member inline this.MakeGetOnlyAdaptiveBuilder<'T>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getFn: 'Element -> 'T,
            getStore: 'T -> aval<unit>
        ) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let propertyName = "getter-" + string index

            if ctx.PropertyResources.ContainsKey propertyName then
                (ctx.PropertyResources[propertyName] :?> IDisposable).Dispose()

            ctx.PropertyResources[ propertyName ] <- (getStore (getFn ctx.Element)).AddCallback ignore

            index + 1
        )


    /// This will return the native element reference.
    [<CustomOperation("With")>]
    member inline this.With([<InlineIfLambda>] builder: BuildElement<'Element>, set) = this.MakeGetOnlyBuilder(builder, (fun x -> x), set)

    /// This will return the native element reference.
    [<CustomOperation("With'")>]
    member inline this.With'([<InlineIfLambda>] builder: BuildElement<'Element>, set) =
        this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x), set)


    /// Helper method to build an ElementCreator
    member inline _.MakeElementCreator
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] fn: unit -> 'Element,
            ?key
        ) : ElementCreator<'UIStack> =
        let key = defaultArg key RenderMode.CreateOnce
        {
            RenderMode = key
            CreateOrUpdate =
                fun (sp, ctx) ->
                    let newCtx =
                        match ctx with
                        | ValueNone -> new ElementBuildContext<'Element>(fn (), sp, key)
                        | ValueSome ctx -> unbox ctx
                    builder.Invoke(newCtx, 0) |> ignore
                    (newCtx :> IElementContext).RenderMode <- key
                    newCtx
        }


    member inline _.MakeEventPropertyBuilder<'Element, 'Handler, 'Args when 'Handler :> Delegate>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getEvent: ElementBuildContext<'Element> -> IEvent<'Handler, 'Args>,
            propertyName: string,
            [<InlineIfLambda>] fn: 'Element * 'Args -> unit
        ) =
        BuildElement<'Element>(fun ctx index ->
            let event = getEvent ctx
            let index = builder.Invoke(ctx, index)
            let propertyName = propertyName + "-" + string index

            if ctx.PropertyResources.ContainsKey propertyName then
                (ctx.PropertyResources[propertyName] :?> IDisposable).Dispose()

            ctx.PropertyResources[ propertyName ] <- event.Subscribe(fun e -> fn (ctx.Element, e))

            index + 1
        )


    member inline _.MakeEqualityPropertyBuilder<'Element, 'Property when 'Property: equality>
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] getProperty: ElementBuildContext<'Element> -> 'Property,
            [<InlineIfLambda>] setProperty: ElementBuildContext<'Element> -> 'Property -> unit,
            value: 'Property
        ) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let propertyName = "equal-prop-" + string index
            // Set the value if it is first time to set or not equal
            if not (ctx.PropertyResources.ContainsKey propertyName) || getProperty ctx <> value then
                setProperty ctx value
            ctx.PropertyResources[ propertyName ] <- 0
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
            let isPropAdded = ctx.PropertyResources.ContainsKey propertyName
            if isPropAdded then
                match ctx.PropertyResources[propertyName] with
                | :? IDisposable as x -> x.Dispose()
                | _ -> ()

            ctx.PropertyResources[ propertyName ] <- value.AddCallback(fun x -> if not isPropAdded || getProperty ctx <> x then setProperty ctx x)

            index + 1
        )


    /// Helper method to build a delegate to set or update native child elements.
    /// This is a simple implmentation. Or magic virtual dom or diff algorithm.
    /// 1. If the child elements shape (order, type, length etc.) will not change, you can use MakeStaticChildrenBuilder.
    /// 2. It is better to use RenderMode.Key to each element. Other RenderMode will be treated as RenderMode.AlwaysRecreate.
    member _.MakeChildrenBuilder<'Element, 'ChildElement>
        (
            builder: BuildElement<'Element>,
            clearNativeChildren: ElementBuildContext<'Element> -> unit,
            addNativeChildren: ElementBuildContext<'Element> -> 'ChildElement[] -> unit,
            childrenCreators: ElementCreator<'UIStack> seq
        ) =
        BuildElement<'Element>(fun ctx index ->
            let sp = (ctx :> IElementContext).ServiceProvider
            let index = builder.Invoke(ctx, index)
            let childrenLength = Seq.length childrenCreators
            let oldCholdrenLength = ctx.ChildContexts.Count

            if childrenLength = 0 && oldCholdrenLength > 0 then
                for child in ctx.ChildContexts do
                    child.Dispose()
                ctx.ChildContexts.Clear()
                clearNativeChildren ctx

            else if childrenLength > 0 then

                if oldCholdrenLength = 0 then
                    let newNativeElements = Array.create childrenLength Unchecked.defaultof<'ChildElement>

                    let mutable i = 0
                    ctx.ChildContexts.Clear()
                    while i < childrenLength do
                        let childCreator = Seq.item i childrenCreators
                        let newChildContext = childCreator.CreateOrUpdate(sp, ValueNone)
                        ctx.ChildContexts.Add(newChildContext)
                        newNativeElements[i] <- saferCast newChildContext.NativeElement
                        i <- i + 1

                    clearNativeChildren ctx
                    addNativeChildren ctx newNativeElements

                else
                    let newChildrenContexts = Array.create childrenLength Unchecked.defaultof<IElementContext>
                    let newNativeChildren = Array.create childrenLength Unchecked.defaultof<'ChildElement>

                    let mutable i = 0
                    while i < childrenLength do
                        let childCreator = Seq.item i childrenCreators

                        let newChildContext =
                            match childCreator.RenderMode with
                            | RenderMode.CreateOnce
                            | RenderMode.CreateOnceNoRerender
                            //let oldChild = ctx.ChildContexts |> Seq.tryItem i
                            //match oldChild with
                            //| None -> childCreator.CreateOrUpdate(sp, ValueNone)
                            //| Some ctx -> childCreator.CreateOrUpdate(sp, ValueSome ctx)
                            | RenderMode.AlwaysRecreate -> childCreator.CreateOrUpdate(sp, ValueNone)
                            | RenderMode.Key _ ->
                                let oldChild = ctx.ChildContexts |> Seq.tryFind (fun x -> x.RenderMode = childCreator.RenderMode)
                                match oldChild with
                                | Some ctx when childCreator.RenderMode = ctx.RenderMode -> childCreator.CreateOrUpdate(sp, ValueSome ctx)
                                | _ -> childCreator.CreateOrUpdate(sp, ValueNone)

                        newChildrenContexts[i] <- newChildContext
                        newNativeChildren[i] <- saferCast newChildContext.NativeElement
                        i <- i + 1

                    for item in ctx.ChildContexts do
                        if Seq.exists ((=) item) newChildrenContexts |> not then item.Dispose()

                    ctx.ChildContexts.Clear()
                    ctx.ChildContexts.AddRange newChildrenContexts
                    clearNativeChildren ctx
                    addNativeChildren ctx newNativeChildren

            index + 1
        )


    member this.MakeChildrenBuilder<'Element, 'ChildElement>
        (
            builder: BuildElement<'Element>,
            clearNativeChildren: ElementBuildContext<'Element> -> unit,
            addNativeChildren: ElementBuildContext<'Element> -> 'ChildElement[] -> unit,
            childrenCreators: ElementCreator<'UIStack> alist
        ) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let propertyName = "adaptive-children-" + string index

            if ctx.PropertyResources.ContainsKey propertyName then
                (ctx.PropertyResources[propertyName] :?> IDisposable).Dispose()

            ctx.PropertyResources[ propertyName ] <-
                childrenCreators.AddCallback(fun _ _ ->
                    // TODO: take the advatage of the alist to update more efficiently
                    let items = childrenCreators.Content |> AVal.force
                    this.MakeChildrenBuilder(builder, clearNativeChildren, addNativeChildren, items).Invoke(ctx, index) |> ignore
                )

            index + 1
        )


    /// Assume the children list will not change, so we can safetly reuse its old state
    member _.MakeStaticChildrenBuilder<'Element, 'ChildElement>
        (
            builder: BuildElement<'Element>,
            clearNativeChildren: ElementBuildContext<'Element> -> unit,
            addNativeChildren: ElementBuildContext<'Element> -> 'ChildElement[] -> unit,
            childrenCreators: ElementCreator<'UIStack> seq
        ) =
        BuildElement<'Element>(fun ctx index ->
            let sp = (ctx :> IElementContext).ServiceProvider
            let index = builder.Invoke(ctx, index)
            let childrenLength = Seq.length childrenCreators

            if ctx.ChildContexts.Count = 0 then
                let newNativeElements = Array.create childrenLength Unchecked.defaultof<'ChildElement>

                let mutable i = 0
                while i < childrenLength do
                    let childCreator = Seq.item i childrenCreators
                    let newChildContext = childCreator.CreateOrUpdate(sp, ValueNone)
                    ctx.ChildContexts.Add(newChildContext)
                    newNativeElements[i] <- saferCast newChildContext.NativeElement
                    i <- i + 1

                clearNativeChildren ctx
                addNativeChildren ctx newNativeElements

            else
                let newChildrenContexts = Array.create childrenLength Unchecked.defaultof<IElementContext>

                let mutable i = 0
                while i < childrenLength do
                    let oldCtx = Seq.item i ctx.ChildContexts
                    let childCreator = Seq.item i childrenCreators

                    newChildrenContexts[i] <-
                        match childCreator.RenderMode with
                        | RenderMode.CreateOnce -> childCreator.CreateOrUpdate(sp, ValueSome oldCtx)
                        | RenderMode.CreateOnceNoRerender -> oldCtx
                        | RenderMode.AlwaysRecreate -> childCreator.CreateOrUpdate(sp, ValueNone)
                        | RenderMode.Key _ when childCreator.RenderMode <> oldCtx.RenderMode -> childCreator.CreateOrUpdate(sp, ValueNone)
                        | RenderMode.Key _ -> childCreator.CreateOrUpdate(sp, ValueSome oldCtx)

                    i <- i + 1

                for item in ctx.ChildContexts do
                    if Seq.exists ((=) item) newChildrenContexts |> not then item.Dispose()

                ctx.ChildContexts.Clear()
                ctx.ChildContexts.AddRange newChildrenContexts

            index + 1
        )


    member _.MakeSingleChildBuilder<'Element, 'ChildElement>
        (
            builder: BuildElement<'Element>,
            setChild: ElementBuildContext<'Element> -> 'ChildElement -> unit,
            childCreator: ElementCreator<'UIStack>
        ) =
        BuildElement(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let sp = (ctx :> IElementContext).ServiceProvider

            if ctx.ChildContexts.Count = 0 then
                ctx.ChildContexts.Add(childCreator.CreateOrUpdate(sp, ValueNone))
            else
                let oldCtx = ctx.ChildContexts[0]
                ctx.ChildContexts[ 0 ] <-
                    match childCreator.RenderMode with
                    | RenderMode.CreateOnce -> childCreator.CreateOrUpdate(sp, ValueSome oldCtx)
                    | RenderMode.CreateOnceNoRerender -> oldCtx
                    | RenderMode.AlwaysRecreate -> childCreator.CreateOrUpdate(sp, ValueNone)
                    | RenderMode.Key _ when childCreator.RenderMode <> oldCtx.RenderMode -> childCreator.CreateOrUpdate(sp, ValueNone)
                    | RenderMode.Key _ -> childCreator.CreateOrUpdate(sp, ValueSome oldCtx)

            setChild ctx (saferCast ctx.ChildContexts[0].NativeElement)

            index + 1
        )

    member this.MakeAdaptiveSingleChildBuilder<'Element, 'ChildElement>
        (
            builder: BuildElement<'Element>,
            setChild: ElementBuildContext<'Element> -> 'ChildElement -> unit,
            creator: aval<ElementCreator<'UIStack>>
        ) =
        BuildElement(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            let propertyName = "adaptive-child-" + string index

            if ctx.PropertyResources.ContainsKey propertyName then
                (ctx.PropertyResources[propertyName] :?> IDisposable).Dispose()

            ctx.PropertyResources[ propertyName ] <-
                creator.AddCallback(fun x -> this.MakeSingleChildBuilder(builder, setChild, x).Invoke(ctx, 0) |> ignore)

            index + 1
        )
