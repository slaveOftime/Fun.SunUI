// hot-reload
[<AutoOpen>]
module WPFApp.MainWindow

open System
open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Fun.SunUI


let private count = cval 0

let mainWindow =
    Window'() {
        Title "Fun.SunUI.WPF 123"
        Width 300
        Height 400
        Grid'() {
            Rows [
                RowDefinition(Height = GridLength(1., GridUnitType.Star))
                RowDefinition(Height = GridLength.Auto)
            ]
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
                    Click(fun _ -> count.Publish((+) 2))
                }
            ]
        }
    }
