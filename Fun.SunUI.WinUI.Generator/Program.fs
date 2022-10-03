﻿open Microsoft.UI.Xaml.Controls
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.Modern.Forms\Fun.SunUI.WinUI"
let namesp = "Fun.SunUI.WinUI"
let assemblyName = "Microsoft.WinUI"


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    BuilderName = "WinUIControlBuilder"
    UIStackName = "WinUI"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun _ -> false
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"


let panelCtx = {
    GeneratorContext.RootType = typeof<Panel>
    BuilderName = "WinUIPanelBuilder"
    UIStackName = "WinUI"
    ChildrenPropName = "Children"
    IsChildrenProp = fun prop -> prop.PropertyType = typeof<UIElementCollection> && prop.Name = "Children"
}

Generator.createCodeFile panelCtx dir namesp assemblyName "Panels.Generated"