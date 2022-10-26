module Program

open System
open System.Windows.Forms
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI


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
                        Label'() {
                            AutoSize true
                            Text(count |> AVal.map (sprintf "Count = %d"))
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

    let services = new ServiceCollection()
    let sp = services.BuildServiceProvider()
    let nativeMainForm = mainForm.Build<Form>(sp)
    Application.Run(nativeMainForm)


[<EntryPoint; STAThread>]
let main (_: string[]) =

    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    Application.SetHighDpiMode(HighDpiMode.SystemAware) |> ignore

    /// Do not inline start here to avoid bootstrapping issue
    start ()

    0
