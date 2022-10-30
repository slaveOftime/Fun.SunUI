// hot-reload
[<AutoOpen>]
module AvaloniaApp.MainWindow

open FSharp.Data.Adaptive
open Avalonia.Media
open Avalonia.Layout
open Avalonia.Controls


let private count = cval 0


let mainWindow =
    Window'() {
        Title "AvaloniaApp"
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
