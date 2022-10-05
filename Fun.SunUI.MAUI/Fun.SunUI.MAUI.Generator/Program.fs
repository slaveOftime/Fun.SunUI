open Microsoft.Maui.Controls
open Fun.SunUI.Generator
open Utils


let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.SunUI\Fun.SunUI.MAUI\Fun.SunUI.MAUI"
let namesp = "Fun.SunUI.MAUI"
let assemblyName = "Microsoft.Maui.Controls"


let controlCtx = {
    GeneratorContext.RootType = typeof<Element>
    ChildType = typeof<Element>
    BuilderName = "MAUIElementBuilder"
    UIStackName = "MAUI"
    IsChildrenProp = fun _ -> false
    // https://github.com/dotnet/fsharp/issues/14020
    ExcludeBaseTypes = [ typeof<NavigationPage>; typeof<FlyoutPage>; typeof<TabbedPage> ]
    ExcludeProp = fun _ -> false
}

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"
