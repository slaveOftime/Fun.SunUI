module Fun.SunUI.TerminalGUI.Generator

open Terminal.Gui
open Fun.SunUI.Generator
open Fun.SunUI.Generator.TypeInfo


let namesp = "Fun.SunUI.TerminalGUI"
let assemblyName = "Terminal.GUI"


let makeViewCtx () =
    { GeneratorContext.Create<View>() with
        ChildType = typeof<View>
        BuilderName = "TerminalGUIViewBuilder"
        UIStackName = "TerminalGUI"
    }


let generateDefault dir = Generator.createCodeFile (makeViewCtx ()) dir namesp assemblyName "Views.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeViewCtx ()) codesDir namesp assemblyName namesp
