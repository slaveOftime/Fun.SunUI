module Fun.SunUI.Html.Demo

open FSharp.Data.Adaptive
open Browser.Types
open Browser.Dom
open Fun.SunUI
open Fun.SunUI.Html


let count = cval 0

let app =
    div () {
        staticChildren [
            p () { innerText (count |> AVal.map (sprintf "count = %d")) }
            div () {
                staticChildren [
                    button () {
                        innerText "Increase"
                        onclick (fun _ -> count.Publish((+) 1))
                    }
                ]
            }
        ]
    }

document.querySelector("#app").appendChild (app.Build<HTMLDivElement>(null)) |> ignore
