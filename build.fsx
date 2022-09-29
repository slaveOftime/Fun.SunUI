#r "nuget: Fun.Build, 0.1.8"

open Fun.Build
open System.IO


let inline (</>) x y = Path.Combine(x, y)


pipeline "Demo" {
    stage "Check Envs" { run "dotnet build" }
    stage "Publish Demo App" {
        workingDir (__SOURCE_DIRECTORY__ </> "Fun.Modern.Forms.Demo")
        run "dotnet publish -c Release -r win-x64"
    }
    runIfOnlySpecified
}
