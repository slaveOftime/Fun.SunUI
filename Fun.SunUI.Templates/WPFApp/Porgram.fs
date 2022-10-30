// hot-reload
module WPFApp.Program

open System
open System.Windows
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI
open WPFApp


[<EntryPoint; STAThread>]
let main (_: string[]) =

    let services = ServiceCollection()
    let sp = services.BuildServiceProvider()

    let nativeWindow =
//-:cnd:noEmit
#if DEBUG
        let dispatcher (fn: unit -> unit) = if Application.Current <> null then Application.Current.Dispatcher.Invoke fn
        UI.hotreload("WPFApp.MainWindow.mainWindow", (fun () -> mainWindow), (), dispatcher).Build<Window>(sp)
#else
        window.Build<Window>(sp)
#endif
//+:cnd:noEmit

    Application() |> ignore
    Application.Current.Run nativeWindow
