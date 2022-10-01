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
            Click(fun _ -> transact (fun s _ -> counter.Value <- counter.Value + 2))
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


[<EntryPoint; STAThread>]
let main (args: string[]) =
    let count = cval 0

    let mainForm =
        Form'() {
            Controls [
                UI.adaptive () {
                    let! c = count
                    FlowLayoutPanel'() {
                        Top 40
                        Left 10
                        Height 300
                        Width 300
                        Controls [
                            {
                                Key = null
                                CreateOrUpdate =
                                    fun (sp, ctx) ->
                                        match ctx with
                                        | ValueNone ->
                                            let tb = new TextBox()
                                            tb.Placeholder <- "asdasd asd "
                                            tb.TextChanged.Add(fun e -> ())
                                            new ElementBuildContext<TextBox>(tb, sp, null) :> IElementContext
                                        | ValueSome x -> x
                            }
                            CheckBox'() {
                                Checked true
                                CheckedChanged(fun s e -> ())
                            }
                            TextBox'() {
                                Text "test asd ad"
                                TextChanged(fun s e ->

                                    ()
                                )
                            }
                            if c > 4 then Label'() { Text $"count = {c}" }
                            if c % 2 = 0 then
                                Label'() {
                                    Key "%asda"
                                    Text $"count  2 = {c}"
                                }
                            Button'() {
                                Key "button-increase"
                                Click(fun _ -> transact (fun s _ -> count.Value <- count.Value + 1))
                                Text "Increase"
                            }
                        ]
                    }
                }
                FlowLayoutPanel'() {
                    Top 400
                    Left 10
                    Height 300
                    Width 300
                    Controls [
                        Label'() { Text(count |> AVal.map (sprintf "count = %d")) }
                        Button'() {
                            Click(fun _ -> transact (fun s _ -> count.Value <- count.Value + 1))
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

    //let form1 = new Form()

    //let tb = new TextBox()
    //tb.Top <- 40
    //tb.Placeholder <- "asdasd asd "
    //tb.TextChanged.Add(fun e ->
    //    ()
    //)

    //form1.Controls.Add tb

    Application.Run(nativeForm)

    0
