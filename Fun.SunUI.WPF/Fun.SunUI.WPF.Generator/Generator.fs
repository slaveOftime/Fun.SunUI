module Fun.SunUI.WPF.Generator

open System.Windows
open System.Windows.Controls
open Fun.SunUI.Generator
open Utils


let namesp = "Fun.SunUI.WPF"
let assemblyName = "PresentationFramework"


let makeElementCtx () = {
    GeneratorContext.RootType = typeof<FrameworkElement>
    ChildType = typeof<FrameworkElement>
    BuilderName = "WPFElementBuilder"
    UIStackName = "WPF"
    IsChildrenProp =
        fun prop ->
            prop.PropertyType.IsAssignableTo typeof<UIElementCollection>
            || (prop.DeclaringType.IsAssignableTo typeof<ContentControl> && prop.Name = "Content")
    IsYieldProp = fun prop -> prop.Name = "Content"
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun evt -> evt.Name = "MessageHook"
}


let generateDefault dir = Generator.createCodeFile (makeElementCtx ()) dir namesp assemblyName "Elements.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeElementCtx ()) codesDir namesp assemblyName namesp
