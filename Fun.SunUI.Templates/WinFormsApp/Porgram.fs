open System
open System.Windows.Forms
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI
open WinFormsApp


let start () =
    let services = new ServiceCollection()
    let sp = services.BuildServiceProvider()

    let nativeMainForm =
//-:cnd:noEmit
#if DEBUG
        let mutable dispatcher = fun (fn: unit -> unit) -> fn ()
        let form = UI.hotreload("WinFormsApp.MainForm.mainForm", (fun () -> mainForm), (), dispatcher).Build<Form>(sp)
        dispatcher <- fun fn -> form.BeginInvoke fn |> ignore
        form
#else
        mainForm.Build<Form>(sp)
#endif
//+:cnd:noEmit

    Application.Run(nativeMainForm)


[<EntryPoint; STAThread>]
let main (_: string[]) =

    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    Application.SetHighDpiMode(HighDpiMode.SystemAware) |> ignore

    /// Do not inline start here to avoid bootstrapping issue
    start ()

    0
