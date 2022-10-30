// hot-reload
[<AutoOpen>]
module WinFormsApp.MainForm

open System.Drawing
open System.Windows.Forms
open FSharp.Data.Adaptive
open Fun.SunUI


let private count = cval 0

let mainForm =
    Form'() {
        Text "Fun.SunUI.WinForms"
        AutoScaleDimensions(System.Drawing.SizeF(14F, 31F))
        AutoScaleMode System.Windows.Forms.AutoScaleMode.Font
        ClientSize(System.Drawing.Size(300, 400))
        StaticControls [
            FlowLayoutPanel'() {
                Dock DockStyle.Fill
                Controls [
                    Label'() {
                        AutoSize true
                        Text(count |> AVal.map (sprintf "Count = %d"))
                        With'(fun this -> adaptive {
                            let! c = count
                            if c % 2 = 0 then
                                this.ForeColor <- Color.Green
                            else
                                this.ForeColor <- Color.HotPink
                        }
                        )
                    }
                    Button'() {
                        AutoSize true
                        Text "Incease"
                        Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                    }
                ]
            }
        ]
    }
