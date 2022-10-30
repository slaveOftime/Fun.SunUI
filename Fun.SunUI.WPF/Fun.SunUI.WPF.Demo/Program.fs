open System
open System.Windows
open Microsoft.Extensions.DependencyInjection
open Fun.SunUI


[<EntryPoint; STAThread>]
let main (_: string[]) =

    let services = ServiceCollection()
    let sp = services.BuildServiceProvider()

    let nativeWindow =
#if DEBUG
        let dispatcher (fn: unit -> unit) = if Application.Current <> null then Application.Current.Dispatcher.Invoke fn
        UI
            .hotreload("Fun.SunUI.WPF.Demo.Entry.window", (fun () -> Fun.SunUI.WPF.Demo.Entry.window), (), dispatcher)
            .Build<Window>(sp)
#else
        window.Build<Window>(sp)
#endif

    Application() |> ignore
    Application.Current.MainWindow <- nativeWindow

    nativeWindow.Show()
    Application.Current.Run nativeWindow
