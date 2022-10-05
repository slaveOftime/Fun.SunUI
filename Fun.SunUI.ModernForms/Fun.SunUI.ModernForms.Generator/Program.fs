open Modern.Forms
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.SunUI\Fun.SunUI.ModernForms\Fun.SunUI.ModernForms"
let namesp = "Fun.SunUI.ModernForms"
let assemblyName = "Modern.Forms"


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    ChildType = typeof<Control>
    BuilderName = "ModernFormsControlBuilder"
    UIStackName = "ModernForms"
    IsChildrenProp = fun _ -> false
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"


let windowBaseCtx = {
    GeneratorContext.RootType = typeof<WindowBase>
    ChildType = typeof<Control>
    BuilderName = "ModernFormsWindowBaseBuilder"
    UIStackName = "ModernForms"
    IsChildrenProp = fun _ -> false
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
}

Generator.createCodeFile windowBaseCtx dir namesp assemblyName "Windows.Generated"
