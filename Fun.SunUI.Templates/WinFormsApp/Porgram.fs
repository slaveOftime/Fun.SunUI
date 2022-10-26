open System
open System.Drawing
open System.Windows.Forms
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI


let start () =
    let count = cval 0

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
                            })
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
    let nativeMainForm = mainForm.CreateOrUpdate(sp, ValueNone).NativeElement :?> Form
    Application.Run(nativeMainForm)


[<EntryPoint; STAThread>]
let main (_: string[]) =

    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    Application.SetHighDpiMode(HighDpiMode.SystemAware) |> ignore

    /// Do not inline start here to avoid bootstrapping issue
    start ()

    0
