namespace Fun.SunUI

open System
open FSharp.Data.Adaptive


type ElementBuildContext<'Element>(nativeElement: 'Element, sp: IServiceProvider, key: obj) as this =
    member val Properties = System.Collections.Generic.Dictionary<string, obj>()
    member val ChildContexts = ResizeArray<IElementContext>()

    member _.Element = nativeElement

    interface IElementContext with
        member val Key = key with get, set
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


type ElementBuilder<'UIStack, 'Element>() =
    let mutable key: obj = null


    member inline _.Yield(_: unit) = BuildElement<'T>(fun _ i -> i)


    /// Set key to the element builder.
    /// When the parent rerender, it will check the key, if it is changed then it will try to recreate new element and throw old element state and dispose related stuff.
    /// This is used when the parent control will rerender and its children order or number will change when it rerender.
    [<CustomOperation("Key")>]
    member _.Key(builder: BuildElement<'Element>, x: obj) =
        key <- x
        builder

    /// This will return the native element reference.
    [<CustomOperation("Ref")>]
    member inline this.Ref([<InlineIfLambda>] builder: BuildElement<'Element>, setRef: 'Element -> unit) =
        BuildElement<'Element>(fun ctx index ->
            let index = builder.Invoke(ctx, index)
            setRef ctx.Element
            index + 1
        )


    /// Helper method to get current key
    member _.GetKey() = key


    /// Helper method to build an ElementCreator
    member inline _.MakeElementCreator
        (
            [<InlineIfLambda>] builder: BuildElement<'Element>,
            [<InlineIfLambda>] fn: unit -> 'Element,
            ?key: obj
        ) : ElementCreator<'UIStack> =
        {
            Key = Option.toObj key
            CreateOrUpdate =
                fun (sp, ctx) ->
                    let newCtx =
                        match ctx with
                        | ValueNone -> new ElementBuildContext<'Element>(fn (), sp, Option.toObj key)
                        | ValueSome ctx -> unbox ctx
                    builder.Invoke(newCtx, 0) |> ignore
                    (newCtx :> IElementContext).Key <- key
                    newCtx
        }


    /// Helper method to build a delegate for a event property
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


    member inline _.MakeEqualityPropertyBuilder<'Element, 'Property when 'Property: equality>
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


    /// Helper method to build a delegate to set or update native elements.
    /// This is a simple implmentation. Or magic virtual dom or diff algorithm.
    /// 1. Parent is static or will only render once, then this delegate will only call onetime.
    /// 2. Parent is dynamic or will render multiple times, then it will try to use the Key to identify old state and try to reuse it. Otherwise it will create a fresh new child.
    member _.MakeChildrenBuilder<'Element, 'ChildElement>
        (
            builder: BuildElement<'Element>,
            getNativeChildrenLength: ElementBuildContext<'Element> -> int,
            clearNativeChildren: ElementBuildContext<'Element> -> unit,
            addNativeChildren: ElementBuildContext<'Element> -> 'ChildElement[] -> unit,
            childrenCreators: ElementCreator<'UIStack> seq
        ) =
        BuildElement<'Element>(fun ctx index ->
            let sp = (ctx :> IElementContext).ServiceProvider
            let index = builder.Invoke(ctx, index)
            let childrenLength = Seq.length childrenCreators
            let nativeChildrenLength = getNativeChildrenLength ctx

            if childrenLength = 0 && nativeChildrenLength > 0 then
                for child in ctx.ChildContexts do
                    child.Dispose()
                ctx.ChildContexts.Clear()
                clearNativeChildren ctx

            else if childrenLength > 0 then

                if nativeChildrenLength = 0 then
                    let newNativeElements = Array.create childrenLength Unchecked.defaultof<'ChildElement>

                    let mutable i = 0
                    ctx.ChildContexts.Clear()
                    while i < childrenLength do
                        let childCreator = Seq.item i childrenCreators
                        let newChildContext = childCreator.CreateOrUpdate(sp, ValueNone)
                        ctx.ChildContexts.Add(newChildContext)
                        newNativeElements[i] <- newChildContext.NativeElement :?> 'ChildElement
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
                        newNativeChildren[i] <- newChildContext.NativeElement :?> 'ChildElement
                        i <- i + 1

                    for item in ctx.ChildContexts do
                        if Seq.exists ((=) item) newChildrenContexts |> not then item.Dispose()

                    ctx.ChildContexts.Clear()
                    ctx.ChildContexts.AddRange newChildrenContexts
                    clearNativeChildren ctx
                    addNativeChildren ctx newNativeChildren

            index + 1
        )
