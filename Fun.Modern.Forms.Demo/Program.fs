module Program

open System
open Modern.Forms
open FSharp.Data.Adaptive
open Fun.Modern.Forms
open Fun.Modern.Forms.Elements
open Microsoft.Extensions.DependencyInjection


type SimpleService() =

    member val Counter = cval 0 with get, set


let demoCounter (top: int) =
    ui.inject (fun ctx ->
        let counter = ctx.ServiceProvider.GetService<SimpleService>().Counter
        button () {
            Left 10
            Top top
            Click(fun _ -> transact (fun _ -> counter.Value <- counter.Value + 2))
            Text "Increase"
        }
    )


let demoAnimation =
    ui.inject (fun ctx ->
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

        button () {
            Width height
            Text "ani..."
        }
    )


[<EntryPoint; STAThread>]
let main (args: string[]) =
    let count = cval 0

    let mainForm =
        form () {
            Controls [
                adaptiview () {
                    let! c = count
                    return
                        flowLayoutPanel () {
                            Top 40
                            Left 10
                            Height 300
                            Width 300
                            Controls [
                                if c > 4 then label () { Text $"count = {c}" }
                                if c % 2 = 0 then
                                    label () {
                                        Key "%asda"
                                        Text $"count  2 = {c}"
                                    }
                                button () {
                                    Key "button-increase"
                                    Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                                    Text "Increase"
                                }
                            ]
                        }
                }
                flowLayoutPanel () {
                    Top 400
                    Left 10
                    Height 300
                    Width 300
                    Controls [
                        label () { Text(count |> AVal.map (sprintf "count = %d")) }
                        button () {
                            Click(fun _ -> transact (fun _ -> count.Value <- count.Value + 1))
                            Text "Increase"
                        }
                        ui.inject (fun ctx ->
                            let counter = ctx.ServiceProvider.GetService<SimpleService>().Counter
                            label () { Text(counter |> AVal.map (sprintf "d = %d")) }
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

    0
