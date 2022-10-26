module Fun.SunUI.WPF.Generator

open System.Windows
open System.Windows.Controls
open Fun.SunUI.Generator
open Utils


let namesp = "System.Windows"
let assemblyName = "PresentationFramework"


let makeElementCtx () = {
    GeneratorContext.RootType = typeof<UIElement>
    ChildType = typeof<UIElement>
    BuilderName = "WPFElementBuilder"
    UIStackName = "WPF"
    IsChildrenProp =
        fun prop ->
            prop.PropertyType.IsAssignableTo typeof<UIElementCollection>
            || (prop.DeclaringType.IsAssignableTo typeof<ContentControl> && prop.Name = "Content")
    IsYieldProp = fun prop -> prop.Name = "Content" || prop.Name = "Child"
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun evt -> evt.Name = "MessageHook"
}


let generateDefault dir = Generator.createCodeFile (makeElementCtx ()) dir namesp assemblyName "Elements.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeElementCtx ()) codesDir namesp assemblyName namesp
