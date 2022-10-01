open Modern.Forms
open Fun.SunUI.Generator
open Utils


let ctx = {
    GeneratorContext.RootType = typeof<Control>
    UIStackName = "ModernForms"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun prop -> prop.PropertyType = typeof<Control.ControlCollection> && prop.Name = "Controls"
}

let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.Modern.Forms\Fun.SunUI.ModernForms"
let namesp = "Fun.SunUI.ModernForms"
let assemblyName = "Modern.Forms"

Generator.createCodeFile ctx dir namesp assemblyName
