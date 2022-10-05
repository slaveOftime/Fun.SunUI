open Modern.Forms
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.SunUI\Fun.SunUI.ModernForms\Fun.SunUI.ModernForms"
let namesp = "Fun.SunUI.ModernForms"
let assemblyName = "Modern.Forms"


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    BuilderName = "ModernFormsControlBuilder"
    UIStackName = "ModernForms"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun prop -> prop.PropertyType.IsAssignableTo typeof<Control.ControlCollection> && prop.Name = "Controls"
    ExcludeBaseTypes = []
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"


let windowBaseCtx = {
    GeneratorContext.RootType = typeof<WindowBase>
    BuilderName = "ModernFormsWindowBaseBuilder"
    UIStackName = "ModernForms"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun prop -> prop.PropertyType.IsAssignableTo typeof<Control.ControlCollection> && prop.Name = "Controls"
    ExcludeBaseTypes = []
}

Generator.createCodeFile windowBaseCtx dir namesp assemblyName "Windows.Generated"
