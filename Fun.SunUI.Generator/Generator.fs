module Fun.SunUI.Generator.Generator

open System
open System.IO
open System.Reflection
open System.Collections.Generic
open Utils


let private generate (ctx: GeneratorContext) (targetNamespace: string) (opens: string) (tys: Type seq) =
    let metaInfos = tys |> TypeInfo.create ctx.RootType (MetaInfo.getMetaInfo ctx >> fun x -> Namespace x.ty.Namespace, x)

    let trimNamespace (ns: string) =
        metaInfos.rootNamespaces
        |> Seq.pick (fun x ->
            if ns.StartsWith x then
                if ns.Length = x.Length then Some "" else ns.Substring(x.Length + 1) |> Some
            else
                None
        )

    let trimWithTargetNamespace (ns: string) =
        if ns.StartsWith targetNamespace && ns.Length > targetNamespace.Length then
            ns.Substring(targetNamespace.Length + 1)
        else
            ns

    let builderNames = Dictionary<string, Dictionary<string, int>>()

    let makeBuilderName (ty: Type) =
        let info = ty.GetTypeInfo()

        let shortName = getTypeShortName ty
        let uniqueName = $"{shortName}-{info.GenericTypeArguments.Length + info.GenericTypeParameters.Length}"
        let builderName = $"{shortName}Builder"
        let key = $"{ty.Namespace}-{shortName}"

        if builderNames.ContainsKey key then
            if builderNames.[key].ContainsKey uniqueName then
                ()
            else
                let count = builderNames.[key].Count
                builderNames.[key].Add(uniqueName, count + 1)
            if builderNames.[key].[uniqueName] = 1 then
                builderName
            else
                $"{builderName}{builderNames.[key].[uniqueName]}"
        else
            builderNames.Add(key, Dictionary([ KeyValuePair(uniqueName, 1) ]))
            builderName


    let internalCode =
        metaInfos.metas
        |> Seq.map (fun (Namespace ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let builderName = makeBuilderName meta.ty
                    let builderGenericConstraint = $"{elementGeneric} :> {getTypeName meta.ty}"
                    let builderGenericsWithContraints =
                        elementGeneric :: (getTypeNames meta.generics)
                        |> createGenerics
                        |> appendStr (createConstraint meta.generics |> appendConstraint builderGenericConstraint)
                        |> closeGenerics

                    let inheirit' =
                        if meta.ty = ctx.RootType then
                            $"inherit {ctx.BuilderName}<'Element>()"
                        else
                            let baseTy, generics = meta.inheritInfo
                            let builderGenerics =
                                [
                                    if meta.ty.IsSealed then
                                        getTypeName meta.ty
                                    else
                                        elementGeneric
                                        yield! getTypeNames generics
                                ]
                                |> createGenerics
                                |> closeGenerics
                            $"inherit {baseTy.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{makeBuilderName meta.ty.BaseType}{builderGenerics}()"

                    $"""
type {builderName}{if meta.ty.IsSealed then "" else builderGenericsWithContraints}() =
    {inheirit'}

{meta.props}
                """
                )
                |> String.concat "\n"

            $"""namespace rec {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}
{opens}
{code}
            """
        )
        |> String.concat "\n"

    let dslCode =
        metaInfos.metas
        |> Seq.groupBy fst
        |> Seq.map (fun (Namespace ns, group) ->
            let metas = group |> Seq.map snd |> Seq.concat
            let code =
                metas
                |> Seq.filter (fun x -> not x.ty.IsAbstract && x.ty.GetConstructors() |> Seq.exists (fun ct -> ct.GetParameters().Length = 0))
                |> Seq.map (fun meta ->
                    let originalGenerics = meta.generics |> getTypeNames |> createGenerics |> closeGenerics
                    let originalTypeWithGenerics = $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{originalGenerics}"
                    let builderName = makeBuilderName meta.ty
                    let builderGenerics = originalTypeWithGenerics :: (getTypeNames meta.generics) |> createGenerics |> closeGenerics

                    let typeName = meta.ty |> getTypeShortName

                    let genericStr =
                        meta.generics |> getTypeNames |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics


                    $"""    type {typeName}'{genericStr} () = 
        inherit {builderName}{if meta.ty.IsSealed then "" else builderGenerics}()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<{getTypeName meta.ty}>) = this.MakeElementCreator(builder, (fun _ -> new {getTypeName meta.ty}()), this.GetKey())
"""
                )
                |> String.concat "\n"

            $"""namespace {targetNamespace}{ns |> trimNamespace |> addStrIfNotEmpty "."}

[<AutoOpen>]
module {ctx.BuilderName}DslCE{(trimWithTargetNamespace ns).Replace(".", "") |> addStrIfNotEmpty "_"} =
  
    open Fun.SunUI
    open {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{code}
            """
        )
        |> String.concat "\n"

    {| internalCode = internalCode; dslCode = dslCode |}


let createCodeFile ctx (codesDir: string) (targetNamespace: string) (sourceAssemblyName: string) (fileName: string) =
    printfn $"Generating code for {targetNamespace}: {sourceAssemblyName}"

    let formatedName = targetNamespace.Replace("-", "_")

    try
        let opens =
            $"""open {targetNamespace}.{Utils.internalSegment}
open Fun.SunUI
open Fun.SunUI.{ctx.UIStackName}
"""

        let types = Assembly.Load(sourceAssemblyName).GetTypes()
        let path = codesDir </> fileName + ".fs"

        if Directory.Exists codesDir |> not then
            Directory.CreateDirectory codesDir |> ignore

        let codes = generate ctx formatedName opens types

        let code =
            $"""{codes.internalCode}

// =======================================================================================================================

{codes.dslCode}"""

        File.WriteAllText(path, code)


        printfn $"Generated code for {formatedName}: {path}"

    with ex ->
        printfn "Generate code failed %s" ex.Message
