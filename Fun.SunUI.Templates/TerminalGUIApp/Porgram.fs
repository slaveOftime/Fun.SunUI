open FSharp.Data.Adaptive
open Terminal.Gui
open NStack
open Fun.SunUI
open Fun.SunUI.TerminalGUI


let count = cval 0

let top =
    Toplevel'() {
        StaticChildren [
            Window'() {
                Title "Fun.SunUI.TerminalGUI.Demo"
                StaticChildren [
                    Label'() {
                        X 2
                        Y 2
                        Text(count |> AVal.map (sprintf "count = %d" >> ustring.Make))
                    }
                    Button'() {
                        X 2
                        Y 3
                        Text "Increase"
                        Clicked(fun _ -> count.Publish((+) 1))
                    }
                ]
            }
        ]
    }


Application.Init()
Application.Begin(top.Build(null)) |> ignore
Application.Run()
Application.Shutdown()
