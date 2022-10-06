module Fun.SunUI.Cli.Program

open System.ComponentModel
open Spectre.Console.Cli
open System.IO
open Spectre.Console


type UIStack =
    | ModernForms = 0
    | WinForms = 1
    | WPF = 2
    | MAUI = 3


type CodeGenSettings() =
    inherit CommandSettings()

    [<Description("Project you want to add bindings")>]
    [<CommandArgument(0, "[PROJECT]")>]
    member val Project = "" with get, set

    [<Description("Output directory of generated codes")>]
    [<CommandOption("-o|--outDir")>]
    member val OutDir = "Fun.SunUI.Bindings" with get, set

    [<Description("UIStack")>]
    [<CommandOption("-u|--uiStack")>]
    member val UIStack = UIStack.ModernForms with get, set

    [<Description("Generate for default")>]
    [<CommandOption("--forDefault")>]
    member val ForDefault = false with get, set

    [<Description(".NET SDK version")>]
    [<CommandOption("--sdk")>]
    member val Sdk = "" with get, set

    [<Description("Fun.SunUI.Generator version")>]
    [<CommandOption("--generator-version")>]
    member val GeneratorVersion = "0.0.1" with get, set


type GenerateCommand() =
    inherit Command<CodeGenSettings>()

    override _.Execute(_, settings) =
        let path =
            if Path.IsPathRooted settings.Project && File.Exists settings.Project then
                Some settings.Project

            elif Path.IsPathRooted settings.Project && Directory.Exists settings.Project then
                Directory.GetFiles settings.Project |> Seq.tryFind (fun f -> f.EndsWith ".fsproj")

            elif
                Path.IsPathRooted settings.Project |> not
                && File.Exists(Path.Combine(Directory.GetCurrentDirectory(), settings.Project))
            then
                Path.Combine(Directory.GetCurrentDirectory(), settings.Project) |> Some

            elif
                Path.IsPathRooted settings.Project |> not
                && Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), settings.Project))
            then
                Path.Combine(Directory.GetCurrentDirectory(), settings.Project)
                |> Directory.GetFiles
                |> Seq.tryFind (fun f -> f.EndsWith ".fsproj")

            else
                None

        match path with
        | None ->
            AnsiConsole.MarkupLine "[red] project is required[/]"
            -1
        | Some path ->
            CodeGen.Generate.startGenerate settings.ForDefault (string settings.UIStack) path settings.OutDir settings.Sdk settings.GeneratorVersion
            0


[<EntryPoint>]
let main (args: string[]) =
    AnsiConsole.Write(FigletText("Fun.Blazor.Cli", Color = Color.CadetBlue))

    let application = CommandApp()

    application.Configure(fun config ->
        config
            .AddCommand<GenerateCommand>("generate")
            .WithDescription("Generate DSL for Fun.SunUI")
            .WithExample([| "generate" |])
        |> ignore
    )

    application.Run args
