open System
open FSharp.Data.Adaptive
open Avalonia
open Avalonia.Media
open Avalonia.Layout
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Themes.Fluent
open Avalonia.Controls
open Fun.SunUI.Avalonia.Controls


let count = cval 0


let mainWindow =
    Window'() {
        Title "Fun.SunUI.Avalonia.Demo"
        Width 400
        Height 500
        TransparencyBackgroundFallback(SolidColorBrush(Colors.HotPink, 0.2))
        Background Brushes.Transparent
        Grid'() {
            RowDefinitions "Auto,*,Auto"
            StaticChildren [
                Border'() {
                    Height 20
                    Background(
                        adaptive {
                            let! c = count
                            if c % 2 = 0 then return Brushes.Green :> IBrush else return Brushes.Transparent
                        }
                    )
                }
                StackPanel'() {
                    GridRow 1
                    VerticalAlignment VerticalAlignment.Center
                    HorizontalAlignment HorizontalAlignment.Center
                    StaticChildren [ TextBlock'() { Text(count |> AVal.map (sprintf "count = %d")) } ]
                }
                Button'() {
                    GridRow 2
                    Content' "Increase"
                    Height 60
                    HorizontalAlignment HorizontalAlignment.Stretch
                    HorizontalContentAlignment HorizontalAlignment.Center
                    VerticalContentAlignment VerticalAlignment.Center
                    Background Brushes.HotPink
                    Click(fun _ -> transact (fun () -> count.Value <- count.Value + 1))
                }
            ]
        }
    }


type App() =
    inherit Application()

    override app.Initialize() = app.Styles.Add(FluentTheme(baseUri = null, Mode = FluentThemeMode.Dark))

    override app.OnFrameworkInitializationCompleted() =
        match app.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
            let window = mainWindow.Build<Window>(null)
            desktop.MainWindow <- window
        | _ -> ()

        base.OnFrameworkInitializationCompleted()


[<EntryPoint; STAThread>]
let main (args: string[]) = AppBuilder.Configure<App>().UsePlatformDetect().StartWithClassicDesktopLifetime(args)
