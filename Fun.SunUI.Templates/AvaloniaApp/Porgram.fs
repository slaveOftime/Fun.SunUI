open System
open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Themes.Fluent
open Avalonia.Controls
open Fun.SunUI
open AvaloniaApp


type App() =
    inherit Application()

    override app.Initialize() = app.Styles.Add(FluentTheme(baseUri = null, Mode = FluentThemeMode.Dark))

    override app.OnFrameworkInitializationCompleted() =
        match app.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
            let window =
//-:cnd:noEmit
#if DEBUG
                let mutable dispatcher = fun (fn: unit -> unit) -> fn ()
                let window = UI.hotreload("AvaloniaApp.MainWindow.mainWindow", (fun () -> mainWindow), (), dispatcher).Build<Window>(null)
                dispatcher <- fun fn -> Avalonia.Threading.Dispatcher.UIThread.InvokeAsync(fn) |> ignore
                window
#else
                mainWindow.Build<Window>(null)
#endif
//+:cnd:noEmit

            desktop.MainWindow <- window
        | _ -> ()

        base.OnFrameworkInitializationCompleted()


[<EntryPoint; STAThread>]
let main (args: string[]) = AppBuilder.Configure<App>().UsePlatformDetect().StartWithClassicDesktopLifetime(args)
