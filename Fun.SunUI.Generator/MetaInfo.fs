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

    let contextArg =
        let generic = if ty.IsSealed then getTypeName ty else "'Element"
        if useInline then
            $"[<InlineIfLambda>] builder: BuildElement<{generic}>"
        else
            $"builder: BuildElement<{generic}>"


    let rawProps = ty.GetProperties()
    let filteredProps =
        rawProps
        |> Seq.filter (fun (prop: PropertyInfo) ->
            prop.DeclaringType = ty
            && prop.SetMethod <> null
            && prop.SetMethod.IsPublic
            && prop.GetIndexParameters().Length = 0
            && not (prop.GetAccessors(true).[0].IsStatic)
            && prop.GetCustomAttributes false |> isObsoleted |> not
        )

    let props =
        filteredProps
        |> Seq.map (fun prop ->
            let name = prop.Name
            let name = if fsharpKeywords |> List.contains name then $"{name}'" else name

            let createAdaptiveProps () =
                $"    {customOperation name} {memberStart}{name} ({contextArg}, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.{prop.Name}), (fun ctx x -> ctx.Element.{prop.Name} <- x), x)"

            if prop.PropertyType.IsGenericType then
                if prop.PropertyType.Name.StartsWith "System.EventHandler" then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.{prop.Name}), {prop.Name}, fn)"
                    ]
                elif
                    prop.PropertyType.Namespace = "System"
                    && (prop.PropertyType.Name.StartsWith "Func`" || prop.PropertyType.Name.StartsWith "Action`")
                then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.{prop.Name}), (fun ctx x -> ctx.Element.{prop.Name} <- x), ({getTypeName prop.PropertyType}fn))"
                    ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {propTypeName}) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.{prop.Name}), (fun ctx x -> ctx.Element.{prop.Name} <- x), x)"
                        createAdaptiveProps ()
                    ]

            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {propTypeName}) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.{prop.Name}), (fun ctx x -> ctx.Element.{prop.Name} <- x), x)"
                    createAdaptiveProps ()
                ]
        )
        |> Seq.concat


    let evts =
        ty.GetEvents()
        |> Seq.filter (fun x -> x.DeclaringType = ty && x.EventHandlerType.FullName.StartsWith "System.EventHandler")
        |> Seq.map (fun evt ->
            let name = if fsharpKeywords |> List.contains evt.Name then $"{evt.Name}'" else evt.Name
            $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.{evt.Name}), \"{evt.Name}\", fn)"
        )

    {|
        ty = ty
        generics = generics
        inheritInfo = inheritInfo
        props = [ yield! props; ""; yield! evts ] |> String.concat "\n"
        hasChildren = true
    |}
