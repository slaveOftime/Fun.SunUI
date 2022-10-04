open System.Windows.Forms
open Fun.SunUI.Generator
open Utils


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    BuilderName = "WinFormsControlBuilder"
    UIStackName = "WinForms"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun prop -> prop.PropertyType = typeof<Control.ControlCollection> && prop.Name = "Controls"
    ExcludeBaseTypes = []
}

let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.Modern.Forms\Fun.SunUI.WinForms"
let namesp = "Fun.SunUI.WinForms"
let assemblyName = "System.Windows.Forms"

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"
