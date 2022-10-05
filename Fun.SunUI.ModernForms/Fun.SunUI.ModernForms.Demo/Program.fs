module Program

open System
open Modern.Forms
open FSharp.Data.Adaptive
open Fun.SunUI
open Fun.SunUI.ModernForms
open Microsoft.Extensions.DependencyInjection


type SimpleService() =

    member val Counter = cval 0 with get, set


let demoCounter (top: int) =
    UI.inject (fun ctx ->
        let counter = ctx.ServiceProvider.GetService<SimpleService>().Counter
        Button'() {
            Left 10
            Top top
            Click(fun _ -> transact (fun _ -> counter.Value <- counter.Value + 2))
            Text "Increase"
        }
    )


let demoAnimation =
    UI.inject (fun ctx ->
        let height = cval 100
        let mutable count = 0.

        let timer = new Timers.Timer(100)
        timer.Elapsed.Add(fun e ->
            transact (fun _ ->
                height.Value <- int (100. * (1. + Math.Sin(float count)))
                count <- count + 0.1
            )
        )
        timer.Start()

        ctx.AddDispose timer

        Button'() {
            Width height
            Text "ani..."
        }
    )


let count = cval 0

let mainForm =
    Form'() {
        Text "Demo"
        Style(fun s -> s.BackgroundColor <- SkiaSharp.SKColor(byte 0, byte 0, byte 0))
        TitleBar(fun t -> t.Style.BackgroundColor <- SkiaSharp.SKColor(byte 0, byte 0, byte 0))
        StaticControls [
            FlowLayoutPanel'() {
                Top 40
                Left 10
                Height 300
                Width 300
                Controls(
                    alist {
                        let! c = count
                        {
                            RenderMode = RenderMode.CreateOnce
                            CreateOrUpdate =
                                fun (sp, ctx) ->
                                    match ctx with
                                    | ValueNone ->
                                        let tb = new TextBox()
                                        tb.Placeholder <- "asdasd asd "
                                        tb.TextChanged.Add(fun e -> ())
                                        new ElementBuildContext<TextBox>(tb, sp, RenderMode.CreateOnce) :> IElementContext
                                    | ValueSome x -> x
                        }
                        CheckBox'() {
                            Checked true
                            CheckedChanged(fun _ -> ())
                        }
                        TextBox'() {
                            Text "test asd ad"
                            KeyPress(fun _ -> ())
                            TextChanged(fun _ -> ())
                            Style(fun s -> s.ForegroundColor <- SkiaSharp.SKColor(byte 10, byte 150, byte 110))
                        }
                        if c > 4 then Label'() { Text $"count = {c}" }
                        if c % 2 = 0 then
                            Label'() {
                                RenderMode(RenderMode.Key "%asda")
                                Text $"count  2 = {c}"
                            }
                        Button'() {
                            RenderMode(RenderMode.Key "button-increase")
                            Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                            Text "Increase"
                            Style'(fun s -> adaptive {
                                let! c = count
                                s.ForegroundColor <-
                                    if c > 2 && c <= 6 then SkiaSharp.SKColor(byte 190, byte 150, byte 110)
                                    else if c > 6 then SkiaSharp.SKColor(byte 10, byte 150, byte 0)
                                    else SkiaSharp.SKColor(byte 10, byte 15, byte 210)
                            }
                            )
                        }
                    }
                )
            }
            FlowLayoutPanel'() {
                Top 400
                Left 10
                Height 300
                Width 300
                StaticControls [
                    Label'() { Text(count |> AVal.map (sprintf "count = %d")) }
                    Button'() {
                        Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                        Text "Increase"
                    }
                    UI.adaptive () {
                        let! c = count
                        Label'() { Text "asdas" }
                    }
                    UI.inject (fun ctx ->
                        let counter = ctx.ServiceProvider.GetService<SimpleService>().Counter
                        Label'() { Text(counter |> AVal.map (sprintf "d = %d")) }
                    )
                    demoCounter 120
                    demoAnimation
                ]
            }
        ]
    }


let services = new ServiceCollection()
services.AddScoped<SimpleService>() |> ignore
let sp = services.BuildServiceProvider()

let nativeForm = mainForm.CreateOrUpdate(sp, ValueNone).NativeElement |> unbox<Form>

Application.Run(nativeForm)
