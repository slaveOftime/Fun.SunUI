#r "nuget: Fun.Build, 0.1.8"

open Fun.Build
open System.IO


let inline (</>) x y = Path.Combine(x, y)


let generatorExe = __SOURCE_DIRECTORY__ </> "Fun.SunUI.Cli" </> "bin" </> "Debug" </> "net6.0" </> "publish" </> "Fun.SunUI.Cli.exe"

let modernFormsProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.ModernForms" </> "Fun.SunUI.ModernForms" </> "Fun.SunUI.ModernForms.fsproj"
let winFormsProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.WinForms" </> "Fun.SunUI.WinForms" </> "Fun.SunUI.WinForms.fsproj"
let wpfProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.WPF" </> "Fun.SunUI.WPF" </> "Fun.SunUI.WPF.fsproj"
let mauiProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.MAUI" </> "Fun.SunUI.MAUI" </> "Fun.SunUI.MAUI.fsproj"


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
    runIfOnlySpecified
}


pipeline "Publish" {
    stage "Check Env" {
        run "dotnet workload restore"
        run "dotnet restore"
    }
    stage "Build packages" {
        run "dotnet pack -c Release Fun.SunUI/Fun.SunUI.fsproj -o ."
        run "dotnet pack -c Release Fun.SunUI.Generator/Fun.SunUI.Generator.fsproj -o ."
        run "dotnet pack -c Release Fun.SunUI.Cli/Fun.SunUI.Cli.fsproj -o ."

        run "dotnet pack -c Release Fun.SunUI.MAUI/Fun.SunUI.MAUI/Fun.SunUI.MAUI.fsproj -o ."
        run "dotnet pack -c Release Fun.SunUI.MAUI/Fun.SunUI.MAUI.Generator/Fun.SunUI.MAUI.Generator.fsproj -o ."

        run "dotnet pack -c Release Fun.SunUI.ModernForms/Fun.SunUI.ModernForms/Fun.SunUI.ModernForms.fsproj -o ."
        run "dotnet pack -c Release Fun.SunUI.ModernForms/Fun.SunUI.ModernForms.Generator/Fun.SunUI.ModernForms.Generator.fsproj -o ."

        run "dotnet pack -c Release Fun.SunUI.WinForms/Fun.SunUI.WinForms/Fun.SunUI.WinForms.fsproj -o ."
        run "dotnet pack -c Release Fun.SunUI.WinForms/Fun.SunUI.WinForms.Generator/Fun.SunUI.WinForms.Generator.fsproj -o ."

        run "dotnet pack -c Release Fun.SunUI.WPF/Fun.SunUI.WPF/Fun.SunUI.WPF.fsproj -o ."
        run "dotnet pack -c Release Fun.SunUI.WPF/Fun.SunUI.WPF.Generator/Fun.SunUI.WPF.Generator.fsproj -o ."
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
