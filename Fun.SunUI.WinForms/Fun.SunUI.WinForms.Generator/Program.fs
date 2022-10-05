open System.Windows.Forms
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.SunUI\Fun.SunUI.WinForms\Fun.SunUI.WinForms"
let namesp = "Fun.SunUI.WinForms"
let assemblyName = "System.Windows.Forms"


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    ChildType = typeof<Control>
    BuilderName = "WinFormsControlBuilder"
    UIStackName = "WinForms"
    IsChildrenProp = fun prop -> prop.PropertyType.IsAssignableTo typeof<Control.ControlCollection> && prop.Name = "Controls"
    IsYieldProp = fun prop -> false
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun _ -> false
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"
