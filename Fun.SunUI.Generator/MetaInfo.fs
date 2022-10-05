module Fun.SunUI.Generator.MetaInfo

open System
open System.Reflection
open Utils


let getMetaInfo (ctx: GeneratorContext) (ty: Type) =
    let useInline = true

    let getTypeMeta (ty: Type) =
        if ty.Name.Contains "`" then
            let generics =
                if ty.GenericTypeArguments.Length = 0 then
                    ty.GetTypeInfo().GenericTypeParameters
                else
                    ty.GenericTypeArguments
                |> Seq.toList
            ty, generics
        else
            ty, []

    let baseTy, baseGenerics = getTypeMeta ty.BaseType

    let inheritInfo = baseTy, baseGenerics

    let generics =
        let ty, generics = getTypeMeta ty
        List.append baseGenerics generics
        |> List.distinctBy (fun x -> x.Name)
        |> List.filter (fun x -> (getTypeName x).StartsWith "'")

    let customOperation name = $"[<CustomOperation(\"{name}\")>]"

    let memberStart = if useInline then "member inline this." else "member this."

    let genericElementName = if ty.IsSealed then getTypeName ty else "'Element"
    let contextArg =
        if useInline then
            $"[<InlineIfLambda>] builder: BuildElement<{genericElementName}>"
        else
            $"builder: BuildElement<{genericElementName}>"


    let filteredProps =
        ty.GetProperties()
        |> Seq.filter (fun (prop: PropertyInfo) ->
            not (ctx.ExcludeProp prop)
            && prop.DeclaringType = ty
            && ((prop.SetMethod <> null && prop.SetMethod.IsPublic)
                || (not prop.PropertyType.IsPrimitive
                    && not prop.PropertyType.IsEnum
                    && prop.PropertyType <> typeof<Decimal>
                    && prop.PropertyType <> typeof<DateTime>
                    && prop.PropertyType <> typeof<DateTimeOffset>
                    && prop.PropertyType <> typeof<Guid>
                    && prop.PropertyType <> typeof<TimeSpan>))
            && prop.GetIndexParameters().Length = 0
            && not (prop.GetAccessors(true).[0].IsStatic)
            && prop.GetCustomAttributes false |> isObsoleted |> not
        )

    let props =
        filteredProps
        |> Seq.map (fun prop ->
            let name = prop.Name
            let name = if fsharpKeywords |> List.contains name then $"{name}'" else name

            let createSimpleProps (name: string) = [
                $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {getTypeName prop.PropertyType}) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.{safeName prop.Name}), (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), x)"
                $"    {customOperation name} {memberStart}{name} ({contextArg}, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.{safeName prop.Name}), (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), x)"
            ]

            if prop.SetMethod = null || not prop.SetMethod.IsPublic then
                let isIListChild (item: Type) = item.Name.StartsWith "IList`1" && item.GenericTypeArguments[ 0 ].IsAssignableTo ctx.ChildType

                let hasIListChild = prop.PropertyType.GetInterfaces() |> Seq.exists isIListChild

                let isReadOnly =
                    prop.PropertyType.Name.StartsWith "ReadOnly"
                    || prop.PropertyType.GetInterfaces() |> Seq.exists (fun x -> x.Name.Contains("ReadOnly"))

                if
                    not isReadOnly
                    && prop.PropertyType.IsAssignableTo typeof<System.Collections.IEnumerable>
                    && (ctx.IsChildrenProp prop
                        || isIListChild prop.PropertyType
                        || hasIListChild
                        || (prop.PropertyType.GenericTypeArguments.Length = 1
                            && prop.PropertyType.GenericTypeArguments[ 0 ].IsAssignableTo ctx.ChildType))
                then
                    let childTypeName =
                        try
                            getTypeName (
                                if hasIListChild then
                                    prop.PropertyType.GetInterfaces() |> Seq.find isIListChild |> (fun x -> x.GenericTypeArguments[0])
                                else
                                    prop.PropertyType.GenericTypeArguments[0]
                            )
                        with _ ->
                            getTypeName ctx.ChildType

                    if
                        (prop.PropertyType.GetMember("AddRange").Length > 0 && prop.PropertyType.GetMember("Clear").Length > 0)
                        || (prop.PropertyType.GetInterfaces()
                            |> Seq.exists (fun x -> x.GetMember("AddRange").Length > 0 && x.GetMember("Clear").Length > 0))
                    then
                        [
                            $"""
    {customOperation name}
    {memberStart}{name} ({contextArg}, items: ElementCreator<{ctx.UIStackName}> seq) =
        this.MakeChildrenBuilder<{elementGeneric}, {childTypeName}>(
            builder,
            (fun x -> x.Element.{safeName prop.Name}.Clear()),
            (fun x (ls: {childTypeName}[]) -> x.Element.{safeName prop.Name}.AddRange(ls)),
            items
        )

    {customOperation name}
    {memberStart}{name} ({contextArg}, items: ElementCreator<{ctx.UIStackName}> alist) =
        this.MakeChildrenBuilder<{elementGeneric}, {childTypeName}>(
            builder,
            (fun x -> x.Element.{safeName prop.Name}.Clear()),
            (fun x (ls: {childTypeName}[]) -> x.Element.{safeName prop.Name}.AddRange(ls)),
            items
        )

    {customOperation ("Static" + name)}
    {memberStart}Static{name} ({contextArg}, items: ElementCreator<{ctx.UIStackName}> seq) =
        this.MakeStaticChildrenBuilder<{elementGeneric}, {childTypeName}>(
            builder,
            (fun x -> x.Element.{safeName prop.Name}.Clear()),
            (fun x (ls: {childTypeName}[]) -> x.Element.{safeName prop.Name}.AddRange(ls)),
            items
        )
                        """
                        ]
                    else if
                        (prop.PropertyType.GetMember("Add").Length > 0 && prop.PropertyType.GetMember("Clear").Length > 0)
                        || (prop.PropertyType.GetInterfaces()
                            |> Seq.exists (fun x -> x.GetMember("Add").Length > 0 && x.GetMember("Clear").Length > 0))
                    then
                        [
                            $"""
    {customOperation name}
    {memberStart}{name} ({contextArg}, items: ElementCreator<{ctx.UIStackName}> seq) =
        this.MakeChildrenBuilder<{elementGeneric}, {childTypeName}>(
            builder,
            (fun x -> x.Element.{safeName prop.Name}.Clear()),
            (fun x (ls: {childTypeName}[]) -> for i in ls do x.Element.{safeName prop.Name}.Add(i) |> ignore),
            items
        )

    {customOperation name}
    {memberStart}{name} ({contextArg}, items: ElementCreator<{ctx.UIStackName}> alist) =
        this.MakeChildrenBuilder<{elementGeneric}, {childTypeName}>(
            builder,
            (fun x -> x.Element.{safeName prop.Name}.Clear()),
            (fun x (ls: {childTypeName}[]) -> for i in ls do x.Element.{safeName prop.Name}.Add(i) |> ignore),
            items
        )

    {customOperation ("Static" + name)}
    {memberStart}Static{name} ({contextArg}, items: ElementCreator<{ctx.UIStackName}> seq) =
        this.MakeStaticChildrenBuilder<{elementGeneric}, {childTypeName}>(
            builder,
            (fun x -> x.Element.{safeName prop.Name}.Clear()),
            (fun x (ls: {childTypeName}[]) -> for i in ls do x.Element.{safeName prop.Name}.Add(i) |> ignore),
            items
        )
                        """
                        ]
                    else
                        []
                else
                    [
                        $"""    {customOperation name} {memberStart}{name} ({contextArg}, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.{safeName prop.Name}), x)"""
                        $"""    {customOperation (name + "'")} {memberStart}{name}' ({contextArg}, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.{safeName prop.Name}), x)"""
                    ]
            else if ctx.IsChildrenProp prop || prop.PropertyType.IsAssignableTo ctx.ChildType then
                [
                    if ctx.IsYieldProp prop then
                        $"""

    member inline _.Yield(creator: ElementCreator<{ctx.UIStackName}>) = creator
    
    member inline this.Combine(creator: ElementCreator<{ctx.UIStackName}>, [<InlineIfLambda>] builder: BuildElement<{genericElementName}>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<{genericElementName}>, [<InlineIfLambda>] fn: unit -> ElementCreator<{ctx.UIStackName}>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), fn ())
    
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<{ctx.UIStackName}>) =
        this.MakeSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), fn ())

    
    member inline _.Yield(creator: ElementCreator<{ctx.UIStackName}> aval) = creator
    
    member inline this.Combine(creator: ElementCreator<{ctx.UIStackName}> aval, [<InlineIfLambda>] builder: BuildElement<{genericElementName}>) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<{genericElementName}>, [<InlineIfLambda>] fn: unit -> ElementCreator<{ctx.UIStackName}> aval) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), fn ())
                        
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<{ctx.UIStackName}> aval) =
        this.MakeAdaptiveSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), fn ())

                        """

                    $"""
    {customOperation name}
    {memberStart}{name} ({contextArg}, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), creator)

    {customOperation name}
    {memberStart}{name} ({contextArg}, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), creator)
                        """
                    if prop.PropertyType = typeof<obj> then yield! createSimpleProps (name + "'")
                ]
            else if prop.PropertyType.IsGenericType then
                if
                    prop.PropertyType.Namespace = "System"
                    && (prop.PropertyType.Name.StartsWith "Func`" || prop.PropertyType.Name.StartsWith "Action`")
                then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.{safeName prop.Name}), (fun ctx x -> ctx.Element.{safeName prop.Name} <- x), ({getTypeName prop.PropertyType}fn))"
                    ]
                else
                    createSimpleProps name

            else
                createSimpleProps name
        )
        |> Seq.concat


    let evts =
        ty.GetEvents()
        |> Seq.filter (fun x -> x.DeclaringType = ty)
        |> Seq.map (fun evt ->
            let name = if fsharpKeywords |> List.contains evt.Name then $"{evt.Name}'" else evt.Name
            $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.{safeName evt.Name}), \"{evt.Name}\", fn)"
        )

    {|
        ty = ty
        generics = generics
        inheritInfo = inheritInfo
        props = [ yield! props; ""; yield! evts ] |> String.concat "\n"
        hasChildren = true
    |}
