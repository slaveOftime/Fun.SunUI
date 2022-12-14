#r "nuget: Fun.Build, 0.2.3"

open System.IO
open Fun.Build


let inline (</>) x y = Path.Combine(x, y)

let dotnetPack (proj: string) = $"dotnet pack -c Release {proj} -o ."


let generatorExe = __SOURCE_DIRECTORY__ </> "Fun.SunUI.Cli" </> "bin" </> "Debug" </> "net6.0" </> "publish" </> "Fun.SunUI.Cli.exe"

let modernFormsProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.ModernForms" </> "Fun.SunUI.ModernForms" </> "Fun.SunUI.ModernForms.fsproj"
let winFormsProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.WinForms" </> "Fun.SunUI.WinForms" </> "Fun.SunUI.WinForms.fsproj"
let wpfProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.WPF" </> "Fun.SunUI.WPF" </> "Fun.SunUI.WPF.fsproj"
let mauiProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.MAUI" </> "Fun.SunUI.MAUI" </> "Fun.SunUI.MAUI.fsproj"
let avaloniaProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.Avalonia" </> "Fun.SunUI.Avalonia" </> "Fun.SunUI.Avalonia.fsproj"
let terminalGUIProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.TerminalGUI" </> "Fun.SunUI.TerminalGUI" </> "Fun.SunUI.TerminalGUI.fsproj"


pipeline "GenerateInternalBindings" {
    workingDir (__SOURCE_DIRECTORY__ </> "Fun.SunUI.Cli")
    stage "Check Envs" {
        run "dotnet --version"
        run $"dotnet publish"
    }
    stage "Generate" { run $"{generatorExe} generate {modernFormsProj} -u ModernForms --forDefault" }
    stage "Generate" { run $"{generatorExe} generate {winFormsProj} -u WinForms --forDefault" }
    stage "Generate" { run $"{generatorExe} generate {wpfProj} -u WPF --forDefault" }
    stage "Generate" { run $"{generatorExe} generate {mauiProj} -u MAUI --forDefault --sdk 6.0.401" }
    stage "Generate" { run $"{generatorExe} generate {avaloniaProj} -u Avalonia --forDefault" }
    stage "Generate" { run $"{generatorExe} generate {terminalGUIProj} -u TerminalGUI --forDefault" }
    runIfOnlySpecified
}


pipeline "Publish" {
    stage "Check Env" { run "dotnet workload restore" }
    stage "Build packages" {
        //run (dotnetPack "Fun.SunUI/Fun.SunUI.fsproj")
        //run (dotnetPack "Fun.SunUI.Generator/Fun.SunUI.Generator.fsproj")
        //run (dotnetPack "Fun.SunUI.Cli/Fun.SunUI.Cli.fsproj")

        //run (dotnetPack "Fun.SunUI.MAUI/Fun.SunUI.MAUI/Fun.SunUI.MAUI.fsproj")
        //run (dotnetPack "Fun.SunUI.MAUI/Fun.SunUI.MAUI.Generator/Fun.SunUI.MAUI.Generator.fsproj")

        //run (dotnetPack "Fun.SunUI.ModernForms/Fun.SunUI.ModernForms/Fun.SunUI.ModernForms.fsproj")
        //run (dotnetPack "Fun.SunUI.ModernForms/Fun.SunUI.ModernForms.Generator/Fun.SunUI.ModernForms.Generator.fsproj")

        //run (dotnetPack "Fun.SunUI.WinForms/Fun.SunUI.WinForms/Fun.SunUI.WinForms.fsproj")
        //run (dotnetPack "Fun.SunUI.WinForms/Fun.SunUI.WinForms.Generator/Fun.SunUI.WinForms.Generator.fsproj")

        //run (dotnetPack "Fun.SunUI.WPF/Fun.SunUI.WPF/Fun.SunUI.WPF.fsproj")
        //run (dotnetPack "Fun.SunUI.WPF/Fun.SunUI.WPF.Generator/Fun.SunUI.WPF.Generator.fsproj")

        //run (dotnetPack "Fun.SunUI.Avalonia/Fun.SunUI.Avalonia/Fun.SunUI.Avalonia.fsproj")
        //run (dotnetPack "Fun.SunUI.Avalonia/Fun.SunUI.Avalonia.Generator/Fun.SunUI.Avalonia.Generator.fsproj")

        //run (dotnetPack "Fun.SunUI.TerminalGUI/Fun.SunUI.TerminalGUI/Fun.SunUI.TerminalGUI.fsproj")
        //run (dotnetPack "Fun.SunUI.TerminalGUI/Fun.SunUI.TerminalGUI.Generator/Fun.SunUI.TerminalGUI.Generator.fsproj")

        run (dotnetPack "Fun.SunUI.HotReload/Fun.SunUI.HotReload.fsproj")

        run (dotnetPack "Fun.SunUI.Templates/Fun.SunUI.Templates.fsproj")
    }
    stage "Publish packages to nuget" {
        whenAll {
            branch "master"
            whenAny {
                envVar "NUGET_API_KEY"
                cmdArg "NUGET_API_KEY"
            }
        }
        run (fun ctx ->
            let key = ctx.GetCmdArgOrEnvVar "NUGET_API_KEY"
            cmd $"""dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json --skip-duplicate -k {key}"""
        )
    }
    runIfOnlySpecified
}
