module Program

open System
open System.Windows.Forms
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI.WinForms


[<EntryPoint; STAThread>]
let main (args: string[]) =
    let count = cval 0

    let mainForm =
        Form'() {
            Controls [
                FlowLayoutPanel'() {
                    Controls [
                        Label'() { Text(count |> AVal.map (sprintf "Count = %d")) }
                        Button'() {
                            Click(fun _ _ -> transact (fun _ -> count.Value <- count.Value + 1))
                            Text "Incease"
                        }
                    ]
                }
            ]
        }

    let services = new ServiceCollection()
    let sp = services.BuildServiceProvider()
    let nativeMainForm = mainForm.CreateOrUpdate(sp, ValueNone).NativeElement :?> Form

    Application.Run(nativeMainForm)

    0
