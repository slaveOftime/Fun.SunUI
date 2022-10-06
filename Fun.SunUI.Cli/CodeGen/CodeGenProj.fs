namespace Fun.SunUI.Cli.CodeGen

open System
open System.IO
open System.Text
open System.Reflection
open System.Threading.Tasks
open Spectre.Console
open CliWrap


type PackageMeta = {
    Package: string
    Version: string
    SourceAssemblyName: string
    TargetNamespace: string
}


module CodeGenProject =

    let private (</>) x y = Path.Combine(x, y)

    let private outputPipe = PipeTarget.ToDelegate(fun (str: string) -> task { AnsiConsole.Write str } :> Task)

    let private errorPipe = PipeTarget.ToDelegate(fun (str: string) -> task { AnsiConsole.Write str } :> Task)

    type Command with

        member this.Run() =
            this.WithStandardOutputPipe(outputPipe).WithStandardErrorPipe(errorPipe).ExecuteAsync().GetAwaiter().GetResult()
            |> ignore


    let createAndRun
        forDefault
        (uiStackName: string)
        (projectFile: string)
        codesDirName
        (sdk: string option)
        generatorVersion
        (packages: PackageMeta seq)
        =
        let codeGenFolder = Path.GetTempPath() </> "FunSunUI-Cli-" + Guid.NewGuid().ToString()

        AnsiConsole.MarkupLine $"[green]Create temp project: {codeGenFolder}[/]"

        Directory.CreateDirectory codeGenFolder |> ignore

        match sdk with
        | None -> ()
        | Some x ->
            File.WriteAllText(
                codeGenFolder </> "global.json",
                $"""
{{
  "sdk": {{
    "version": "{x}"
  }}
}}
            """
            )

        let sdkMajorVersion =
            match sdk with
            | None -> "6"
            | Some x -> x.Split(".")[0]

        let stack =
            match uiStackName with
            | "MAUI" ->
                $"""
		<UseMaui>true</UseMaui>
		<TargetFramework>net{sdkMajorVersion}.0</TargetFramework>
                """
            | "WinForms" ->
                $"""
        <UseWindowsForms>true</UseWindowsForms>
	    <TargetFramework>net{sdkMajorVersion}.0-windows</TargetFramework>
                """
            | "WPF" ->
                $"""
		<UseWPF>true</UseWPF>
		<TargetFramework>net{sdkMajorVersion}.0-windows</TargetFramework>
                """
            | _ ->
                $"""
        <TargetFramework>net{sdkMajorVersion}.0</TargetFramework>
                """

        File.WriteAllText(
            codeGenFolder </> "Temp.fsproj",
            $"""
<Project Sdk="Microsoft.NET.Sdk">

	<PropertyGroup>
		{stack}
		<OutputType>Exe</OutputType>
	</PropertyGroup>

	<ItemGroup>
		<Compile Include="Program.fs" />
	</ItemGroup>

</Project>

        """
        )

        File.WriteAllText(codeGenFolder </> "Program.fs", "")

        AnsiConsole.WriteLine()
        AnsiConsole.MarkupLine "[green]Add Fun.SunUI.Generator[/]"

#if DEBUG
        let generatorProject =
            __SOURCE_DIRECTORY__
            </> ".."
            </> ".."
            </> $"Fun.SunUI.{uiStackName}"
            </> $"Fun.SunUI.{uiStackName}.Generator"
            </> $"Fun.SunUI.{uiStackName}.Generator.fsproj"
        Cli.Wrap("dotnet").WithArguments($"add reference {generatorProject}").WithWorkingDirectory(codeGenFolder).Run()
#else
        let version =
            if String.IsNullOrEmpty generatorVersion then ""
            elif generatorVersion = "prerelease" then "--prerelease"
            else $"--version {generatorVersion}"
        Cli.Wrap("dotnet").WithArguments($"add package Fun.SunUI.Generator {version}").WithWorkingDirectory(codeGenFolder).Run()
#endif


        let codesDir = Path.GetDirectoryName projectFile </> codesDirName
        let bootstrapCode = StringBuilder()

        if forDefault then
            bootstrapCode.AppendLine $"Fun.SunUI.{uiStackName}.Generator.generateDefault \"{Path.GetDirectoryName projectFile}\""
            |> ignore
        else
            for package in packages do
                AnsiConsole.WriteLine()
                AnsiConsole.MarkupLine $"[green]Add package {package.Package}[/]"
                Cli
                    .Wrap("dotnet")
                    .WithArguments($"add package {package.Package} --version {package.Version}")
                    .WithWorkingDirectory(codeGenFolder)
                    .Run()

                bootstrapCode.AppendLine
                    $"Fun.SunUI.{uiStackName}.Generator.generateCodeFile @\"{codesDir}\" \"{package.TargetNamespace}\" \"{package.SourceAssemblyName}\""
                |> ignore

        AnsiConsole.WriteLine()
        AnsiConsole.MarkupLine $"[green]Add bootstrap codes[/]"
        File.WriteAllText(codeGenFolder </> "Program.fs", bootstrapCode.ToString())

        AnsiConsole.WriteLine()
        AnsiConsole.MarkupLine $"[green]Start generating code[/]"
        Cli.Wrap("dotnet").WithArguments($"run").WithWorkingDirectory(codeGenFolder).Run()

        AnsiConsole.MarkupLine $"[green]Clean temp project[/]"

        try
            Directory.Delete(codeGenFolder, true)
        with _ ->
            ()
