module Program

open System
open System.Windows.Forms
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI.WinForms


let start () =
    let count = cval 0

    let mainForm =
        Form'() {
            Text "Demo"
            AutoScaleDimensions(System.Drawing.SizeF(14F, 31F))
            AutoScaleMode System.Windows.Forms.AutoScaleMode.Font
            ClientSize(System.Drawing.Size(800, 450))
            StaticControls [
                FlowLayoutPanel'() {
                    Dock DockStyle.Fill
                    Controls [
                        Label'() { Text(count |> AVal.map (sprintf "Count = %d")) }
                        Button'() {
                            Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                            Height 100
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


[<EntryPoint; STAThread>]
let main (_: string[]) =

    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    Application.SetHighDpiMode(HighDpiMode.SystemAware) |> ignore

    start ()

    0
