module Fun.SunUI.MAUI.Generator

open Microsoft.Maui.Controls
open Fun.SunUI.Generator
open Fun.SunUI.Generator.TypeInfo


let namesp = "Fun.SunUI.MAUI"
let assemblyName = "Microsoft.Maui.Controls"


let makeControlCtx () =
    { GeneratorContext.Create<Element>() with
        ChildType = typeof<Microsoft.Maui.IElement>
        BuilderName = "MAUIElementBuilder"
        UIStackName = "MAUI"
        IsChildrenProp = fun prop -> prop.DeclaringType.IsAssignableTo typeof<ShellContent> && prop.Name = "Content"
        IsYieldProp = fun prop -> prop.Name = "Content"
        // https://github.com/dotnet/fsharp/issues/14020
        ExcludeBaseTypes = [ typeof<NavigationPage>; typeof<FlyoutPage>; typeof<TabbedPage> ]
        ExcludeProp = fun prop -> prop.Name = "LogicalChildren"
    }


let generateDefault dir = Generator.createCodeFile (makeControlCtx ()) dir namesp assemblyName "Controls.Generated"

let generateCodeFile codesDir namesp assemblyName = Generator.createCodeFile (makeControlCtx ()) codesDir namesp assemblyName namesp
