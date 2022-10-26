module Fun.SunUI.Avalonia.Generator

open Avalonia
open Avalonia.Controls
open Fun.SunUI.Generator
open Utils


let namesp = "Avalonia"
let assemblyName = "Avalonia.Controls"
//let assemblyNames = [ "Avalonia.Base"; "Avalonia.Animation"; "Avalonia.Styling"; "Avalonia.Visuals"; "Avalonia.Layout"; "Avalonia.Interactivity"; "Avalonia.Input"; "Avalonia.Controls" ]

let makeElementCtx () = {
    GeneratorContext.RootType = typeof<AvaloniaObject>
    ChildType = typeof<IControl>
    BuilderName = "AvaloniaElementBuilder"
    UIStackName = "Avalonia"
    IsChildrenProp =
        fun prop ->
            prop.PropertyType.IsAssignableTo typeof<Controls>
            || prop.PropertyType.IsAssignableTo typeof<IControl>
            || (prop.DeclaringType.IsAssignableTo typeof<Avalonia.Controls.ContentControl> && prop.Name = "Content")
    IsYieldProp = fun prop -> prop.Name = "Content" || prop.Name = "Child"
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun _ -> false
}


let generateDefault dir = Generator.createCodeFile (makeElementCtx ()) dir namesp assemblyName "Elements.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeElementCtx ()) codesDir namesp assemblyName namesp
