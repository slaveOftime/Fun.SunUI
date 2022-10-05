open Microsoft.UI.Xaml.Controls
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.SunUI\Fun.SunUI.WinUI\Fun.SunUI.WinUI"
let namesp = "Fun.SunUI.WinUI"
let assemblyName = "Microsoft.WinUI"


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    BuilderName = "WinUIControlBuilder"
    UIStackName = "WinUI"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun _ -> false
    ExcludeBaseTypes = []
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"


let panelCtx = {
    GeneratorContext.RootType = typeof<Panel>
    BuilderName = "WinUIPanelBuilder"
    UIStackName = "WinUI"
    ChildrenPropName = "Children"
    IsChildrenProp = fun prop -> prop.PropertyType.IsAssignableTo typeof<UIElementCollection> && prop.Name = "Children"
    ExcludeBaseTypes = []
}

Generator.createCodeFile panelCtx dir namesp assemblyName "Panels.Generated"
