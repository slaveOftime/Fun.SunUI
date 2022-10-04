open System.Windows.Controls
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.Modern.Forms\Fun.SunUI.WPF"
let namesp = "Fun.SunUI.WPF"
let assemblyName = "PresentationFramework"


let controlCtx = {
    GeneratorContext.RootType = typeof<ContentControl>
    BuilderName = "WPFContentControlBuilder"
    UIStackName = "WPF"
    ChildrenPropName = "Content"
    IsChildrenProp = fun prop -> prop.Name = "Content"
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"


let panelCtx = {
    GeneratorContext.RootType = typeof<Panel>
    BuilderName = "WPFPanelBuilder"
    UIStackName = "WPF"
    ChildrenPropName = "Children"
    IsChildrenProp = fun prop -> prop.PropertyType = typeof<UIElementCollection> && prop.Name = "Children"
}

Generator.createCodeFile panelCtx dir namesp assemblyName "Panels.Generated"
