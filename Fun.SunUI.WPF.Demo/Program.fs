open System
open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI.WPF


[<EntryPoint; STAThread>]
let main (_: string[]) =
    let count = cval 0

    let window =
        Window'() {
            Title "Demo"
            Content(
                Grid'() {
                    RowDefinitions(fun row ->
                        row.Add(RowDefinition(Height = GridLength(1., GridUnitType.Star)))
                        row.Add(RowDefinition(Height = GridLength 40.))
                        row.Add(RowDefinition(Height = GridLength(1., GridUnitType.Star)))
                        row.Add(RowDefinition(Height = GridLength.Auto))
                    )
                    StaticChildren [
                        Button'() {
                            Ref(fun this -> Grid.SetRow(this, 3))
                            Content "Increase"
                        }
                    ]
                }
            )
        }

    let services = ServiceCollection()
    let sp = services.BuildServiceProvider()

    let nativeWindow = window.CreateOrUpdate(sp, ValueNone).NativeElement :?> Window
    Application() |> ignore
    Application.Current.MainWindow <- nativeWindow

    nativeWindow.Show()
    Application.Current.Run nativeWindow
