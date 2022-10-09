module Fun.SunUI.Html.Generator

open Browser.Types
open Fun.SunUI.Generator
open Fun.SunUI.Generator.TypeInfo


let namesp = "Fun.SunUI.Html"
let assemblyName = "Browser.Dom"


let makeElementCtx () =
    { GeneratorContext.Create<HTMLElement>() with
        ChildType = typeof<HTMLElement>
        BuilderName = "HtmlCoreBuilder"
        UIStackName = "Html"
    }


let generateDefault dir = Generator.createCodeFile (makeElementCtx ()) dir namesp assemblyName "Elements.Generated"


let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeElementCtx ()) codesDir namesp assemblyName namesp
