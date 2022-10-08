module Fun.SunUI.TerminalGUI.Generator

open Terminal.Gui
open Fun.SunUI.Generator
open Utils


let namesp = "Fun.SunUI.TerminalGUI"
let assemblyName = "Terminal.GUI"


let makeViewCtx () = {
    GeneratorContext.RootType = typeof<View>
    ChildType = typeof<View>
    BuilderName = "TerminalGUIViewBuilder"
    UIStackName = "TerminalGUI"
    IsChildrenProp = fun _ -> false
    IsYieldProp = fun _ -> false
    ExcludeBaseTypes = []
    ExcludeProp = fun _ -> false
    ExcludeEvent = fun _ -> false
}


let generateDefault dir = Generator.createCodeFile (makeViewCtx ()) dir namesp assemblyName "Views.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeViewCtx ()) codesDir namesp assemblyName namesp
