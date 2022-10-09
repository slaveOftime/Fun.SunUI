module Fun.SunUI.ModernForms.Generator

open Modern.Forms
open Fun.SunUI.Generator
open Fun.SunUI.Generator.TypeInfo


let namesp = "Fun.SunUI.ModernForms"
let assemblyName = "Modern.Forms"


let makeControlCtx () =
    { GeneratorContext.Create<Control>() with
        ChildType = typeof<Control>
        BuilderName = "ModernFormsControlBuilder"
        UIStackName = "ModernForms"
    }


let makeWindowBaseCtx () =
    { GeneratorContext.Create<WindowBase>() with
        ChildType = typeof<Control>
        BuilderName = "ModernFormsWindowBaseBuilder"
        UIStackName = "ModernForms"
    }


let generateDefault dir =
    Generator.createCodeFile (makeControlCtx ()) dir namesp assemblyName "Controls.Generated"
    Generator.createCodeFile (makeWindowBaseCtx ()) dir namesp assemblyName "Windows.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeControlCtx ()) codesDir namesp assemblyName namesp
