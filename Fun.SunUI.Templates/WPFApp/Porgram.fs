open System
open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI
open Fun.SunUI.WPF
open Fun.SunUI.WPF.Controls


let count = cval 0

let window =
    Window'() {
        Title "Fun.SunUI.WPF"
        Width 300
        Height 400
        Grid'() {
            RowDefinitions(fun row ->
                row.Add(RowDefinition(Height = GridLength(1., GridUnitType.Star)))
                row.Add(RowDefinition(Height = GridLength.Auto))
            )
            StaticChildren [
                StackPanel'() {
                    VerticalAlignment VerticalAlignment.Center
                    HorizontalAlignment HorizontalAlignment.Center
                    StaticChildren [
                        TextBlock'() {
                            Text(count |> AVal.map (sprintf "count = %d"))
                            Foreground(
                                adaptive {
                                    let! c = count
                                    if c % 2 = 0 then
                                        return Media.SolidColorBrush Media.Colors.Green :> Media.Brush
                                    else
                                        return Media.SolidColorBrush Media.Colors.HotPink
                                }
                            )
                        }
                    ]
                }
                Button'() {
                    GridRow 1
                    Content' "Increase"
                    Height 60
                    Click(fun _ -> count.Publish((+) 1))
                }
            ]
        }
    }


[<EntryPoint; STAThread>]
let main (_: string[]) =

    let services = ServiceCollection()
    let sp = services.BuildServiceProvider()
    let nativeWindow = window.Build<Window>(sp)
    
    Application() |> ignore
    Application.Current.Run nativeWindow
