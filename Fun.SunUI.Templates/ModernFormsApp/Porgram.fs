open System
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Modern.Forms
open SkiaSharp
open Fun.SunUI
open Fun.SunUI.ModernForms


let count = cval 0

let mainForm =
    Form'() {
        TitleBar(fun title -> title.Text <- "Fun.SunUI.ModernForms")
        Size(Drawing.Size(500, 200))
        Controls [
            FlowLayoutPanel'() {
                Dock DockStyle.Fill
                Controls [
                    Label'() {
                        Text(count |> AVal.map (sprintf "count = %d"))
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


let services = new ServiceCollection()
let sp = services.BuildServiceProvider()

Application.Run(mainForm.Build(sp))
