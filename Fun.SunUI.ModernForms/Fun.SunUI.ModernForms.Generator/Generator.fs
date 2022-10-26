module Fun.SunUI.ModernForms.Generator

open Modern.Forms
open Fun.SunUI.Generator
open Utils


let namesp = "Modern.Forms"
let assemblyName = "Modern.Forms"


let makeControlCtx () = {
    GeneratorContext.RootType = typeof<Control>
    ChildType = typeof<Control>
    BuilderName = "ModernFormsControlBuilder"
    UIStackName = "ModernForms"
    IsChildrenProp = fun _ -> false
    IsYieldProp = fun _ -> false
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun _ -> false
}


let makeWindowBaseCtx () = {
    GeneratorContext.RootType = typeof<WindowBase>
    ChildType = typeof<Control>
    BuilderName = "ModernFormsWindowBaseBuilder"
    UIStackName = "ModernForms"
    IsChildrenProp = fun _ -> false
    IsYieldProp = fun _ -> false
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun _ -> false
}


let generateDefault dir =
    Generator.createCodeFile (makeControlCtx ()) dir namesp assemblyName "Controls.Generated"
    Generator.createCodeFile (makeWindowBaseCtx ()) dir namesp assemblyName "Windows.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeControlCtx ()) codesDir namesp assemblyName namesp
