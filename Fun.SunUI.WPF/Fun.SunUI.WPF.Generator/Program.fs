open System.Windows
open System.Windows.Controls
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.SunUI\Fun.SunUI.WPF\Fun.SunUI.WPF"
let namesp = "Fun.SunUI.WPF"
let assemblyName = "PresentationFramework"


let elementCtx = {
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

Generator.createCodeFile elementCtx dir namesp assemblyName "Elements.Generated"
