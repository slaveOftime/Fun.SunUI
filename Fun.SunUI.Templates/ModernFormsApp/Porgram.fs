open Microsoft.Extensions.DependencyInjection
open Modern.Forms
open Fun.SunUI


let services = new ServiceCollection()
let sp = services.BuildServiceProvider()

Application.Run(
//-:cnd:noEmit
#if DEBUG
    let mutable dispatcher = fun (fn: unit -> unit) -> fn ()
    let form = UI.hotreload("ModernFormsApp.Entry.mainForm", (fun () -> Entry.mainForm), (), dispatcher).Build<Form>(sp)
    dispatcher <- fun fn -> Modern.WindowKit.Threading.Dispatcher.UIThread.InvokeAsync(fn) |> ignore
    form
#else
    mainForm.Build(sp)
#endif
//+:cnd:noEmit
)
