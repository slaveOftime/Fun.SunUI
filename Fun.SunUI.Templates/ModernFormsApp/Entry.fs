// hot-reload
module ModernFormsApp.Entry

open System
open FSharp.Data.Adaptive
open SkiaSharp
open Modern.Forms
open Fun.SunUI


let private count = cval 0

let mainForm =
    Form'() {
        TitleBar(fun title -> title.Text <- "Fun.SunUI.ModernForms")
        Size(Drawing.Size(500, 200))
        Controls [
            FlowLayoutPanel'() {
                Dock DockStyle.Fill
                Controls [
                    Label'() {
                        Text(count |> AVal.map (sprintf "count2 = %d"))
                        Style'(fun s -> adaptive {
                            let! c = count
                            if c % 2 = 0 then
                                s.ForegroundColor <- SKColors.Green
                            else
                                s.ForegroundColor <- SKColors.HotPink
                        })
                    }
                    Button'() {
                        Click(fun _ -> count.Publish((+) 1))
                        Text "Increase"
                    }
                ]
            }
        ]
    }
