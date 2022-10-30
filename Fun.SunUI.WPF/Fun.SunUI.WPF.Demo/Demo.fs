// hot-reload
module Fun.SunUI.WPF.Demo.Entry

open System
open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Fun.SunUI


let private count = cval 0


let window =
    Window'() {
        Title "Demo"
        Grid'() {
            Rows [
                RowDefinition(Height = GridLength 40.)
                RowDefinition(Height = GridLength(1., GridUnitType.Star))
                RowDefinition(Height = GridLength.Auto)
            ]
            StaticChildren [
                Border'() {
                    Background(
                        adaptive {
                            let! c = count
                            if c > 3 then
                                return System.Windows.Media.Brushes.Pink :> Media.Brush
                            else
                                return System.Windows.Media.Brushes.Transparent
                        }
                    )
                }
                UI.native (
                    RenderMode.AlwaysRecreate,
                    fun _ ->
                        let rect = Border()
                        rect.Height <- 10
                        rect.Width <- 100
                        rect.Background <- System.Windows.Media.Brushes.Pink
                        rect
                )
                StackPanel'() {
                    GridRow 1
                    GridRow(cval 1)
                    GridCol 1
                    GridCol(cval 1)
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
