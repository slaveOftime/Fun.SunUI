open System
open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI
open Fun.SunUI.WPF
open Fun.SunUI.WPF.Controls


[<EntryPoint; STAThread>]
let main (_: string[]) =
    let count = cval 0

    let window =
        UI.adaptive () {
            Window'() {
                Title "Demo"
                Grid'() {
                    RowDefinitionsEx(fun row _ isFirstTime ->
                        if isFirstTime then
                            row.Add(RowDefinition(Height = GridLength 40.))
                            row.Add(RowDefinition(Height = GridLength(1., GridUnitType.Star)))
                            row.Add(RowDefinition(Height = GridLength.Auto))
                    )
                    StaticChildren [
                        Border'() {
                            Background(
                                adaptive {
                                    let! c = count
                                    if c > 3 then
                                        return System.Windows.Media.Brushes.Green :> Media.Brush
                                    else
                                        return System.Windows.Media.Brushes.Transparent
                                }
                            )
                        }
                        UI.native (fun _ ->
                            let rect = Border()
                            rect.Height <- 100
                            rect.Width <- 100
                            rect.Background <- System.Windows.Media.Brushes.Blue
                            rect
                        )
                        StackPanel'() {
                            GridRow 1
                            GridRow (cval 1)
                            GridCol 1
                            GridCol (cval 1)
                            VerticalAlignment VerticalAlignment.Center
                            HorizontalAlignment HorizontalAlignment.Center
                            StaticChildren [ TextBlock'() { Text(count |> AVal.map (sprintf "count = %d")) } ]
                        }
                        Button'() {
                            GridRow 2
                            Content' "Increase"
                            Height 60
                            Click(fun _ -> transact (fun () -> count.Value <- count.Value + 1))
                        }
                    ]
                }
            }
        }

    let services = ServiceCollection()
    let sp = services.BuildServiceProvider()

    let nativeWindow = window.CreateOrUpdate(sp, ValueNone).NativeElement :?> Window
    Application() |> ignore
    Application.Current.MainWindow <- nativeWindow

    nativeWindow.Show()
    Application.Current.Run nativeWindow
