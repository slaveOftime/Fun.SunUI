open Terminal.Gui
open Fun.SunUI


Application.Init()

Application.Begin(
//-:cnd:noEmit
#if DEBUG
    let dispatcher (fn: unit -> unit) = fn()
    UI.hotreload("TerminalGUIApp.Entry.top", (fun () -> TerminalGUIApp.Entry.top), (), dispatcher).Build(null)
#else
    top.Build(null))
#endif
//+:cnd:noEmit
)
|> ignore

Application.Run()
Application.Shutdown()
