module Program

open System
open Modern.Forms
open FSharp.Data.Adaptive
open Fun.Modern.Forms.Elements


[<EntryPoint; STAThread>]
let main (args: string[]) =
    let count = cval 0

    let mainForm =
        form () {
            Controls [
                label () {
                    Left 10
                    Top 40
                    Text(count |> AVal.map (sprintf "count = %d"))
                }
                button () {
                    Left 10
                    Top 80
                    Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                    Text "Increase"
                }
            ]
        }

    let nativeForm = mainForm.CreateOrUpdate(ValueNone).NativeElement |> unbox<Form>

    use form2 = new Form()

    let controls: Control[] = [| new Button(Left = 10, Top = 40, Text = "Click Me!") |]
    form2.Controls.AddRange(controls)

    Application.Run(nativeForm)

    0
