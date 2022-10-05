#r "nuget: Fun.Build, 0.1.8"

open Fun.Build
open System.IO


let inline (</>) x y = Path.Combine(x, y)


let modernFormsProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.ModernForms" </> "Fun.SunUI.ModernForms" </> "Fun.SunUI.ModernForms.fsproj"
let winFormsProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.WinForms" </> "Fun.SunUI.WinForms" </> "Fun.SunUI.WinForms.fsproj"
let wpfProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.WPF" </> "Fun.SunUI.WPF" </> "Fun.SunUI.WPF.fsproj"
let mauiProj = __SOURCE_DIRECTORY__ </> "Fun.SunUI.MAUI" </> "Fun.SunUI.MAUI" </> "Fun.SunUI.MAUI.fsproj"


pipeline "GenerateInternalBindings" {
    workingDir (__SOURCE_DIRECTORY__ </> "Fun.SunUI.Generator")
    stage "Check Envs" { run "dotnet build" }
    stage "Generate" { run $"dotnet run -- generate {modernFormsProj} -u ModernForms --forDefault" }
    stage "Generate" { run $"dotnet run -- generate {winFormsProj} -u WinForms --forDefault" }
    stage "Generate" { run $"dotnet run -- generate {wpfProj} -u WPF --forDefault" }
    stage "Generate" { run $"dotnet run -- generate {mauiProj} -u MAUI --forDefault" }
    runIfOnlySpecified
}


pipeline "Demo" {
    stage "Check Envs" { run "dotnet build" }
    stage "Publish Demo App" {
        workingDir (__SOURCE_DIRECTORY__ </> "Fun.Modern.Forms.Demo")
        run "dotnet publish -c Release -r win-x64"
    }
    runIfOnlySpecified
}
