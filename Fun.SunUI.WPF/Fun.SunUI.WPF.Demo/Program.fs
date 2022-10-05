open System
open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI.WPF
open Fun.SunUI.WPF.Controls


[<EntryPoint; STAThread>]
let main (_: string[]) =
    let count = cval 0

    let window =
        Window'() {
            Title "Demo"
            Grid'() {
                RowDefinitions(fun row ->
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
                    StackPanel'() {
                        With(fun this -> Grid.SetRow(this, 1))
                        VerticalAlignment VerticalAlignment.Center
                        HorizontalAlignment HorizontalAlignment.Center
                        StaticChildren [ TextBlock'() { Text(count |> AVal.map (sprintf "count = %d")) } ]
                    }
                    Button'() {
                        With(fun this -> Grid.SetRow(this, 3))
                        Content' "Increase"
                        Height 60
                        Click(fun _ -> transact (fun () -> count.Value <- count.Value + 1))
                    }
                ]
            }
        }

    let services = ServiceCollection()
    let sp = services.BuildServiceProvider()

    let nativeWindow = window.CreateOrUpdate(sp, ValueNone).NativeElement :?> Window
    Application() |> ignore
    Application.Current.MainWindow <- nativeWindow

    nativeWindow.Show()
    Application.Current.Run nativeWindow
