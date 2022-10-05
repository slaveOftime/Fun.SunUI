module Fun.SunUI.WinForms.Generator

open System.Windows.Forms
open Fun.SunUI.Generator
open Utils


let namesp = "Fun.SunUI.WinForms"
let assemblyName = "System.Windows.Forms"


let makeControlCtx () = {
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


let generateDefault dir = Generator.createCodeFile (makeControlCtx ()) dir namesp assemblyName "Controls.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeControlCtx ()) codesDir namesp assemblyName namesp
