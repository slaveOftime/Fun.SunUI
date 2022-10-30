// hot-reload
module MAUIApp.Entry

open FSharp.Data.Adaptive
open Microsoft.Maui
open Microsoft.Maui.Controls
open Fun.SunUI


let private count = cval 0

let private homePage =
    ContentPage'() {
        ScrollView'() {
            VerticalStackLayout'() {
                Spacing 25
                Padding(Thickness(30, 0))
                VerticalOptions LayoutOptions.Center
                Children [
                    Image'() {
                        Source(FileImageSource'() { File "dotnet_bot.png" })
                        HeightRequest 200.
                        HorizontalOptions LayoutOptions.Center
                        SematicDescription "Cute dot net bot waving hi to you!"
                    }
                    Label'() {
                        Text(count |> AVal.map (sprintf "Count = %d"))
                        FontSize 32
                        HorizontalOptions LayoutOptions.Center
                        SematicHeadingLevel SemanticHeadingLevel.Level1
                    }
                    Label'() {
                        Text "Welcome to .NET Multi-platform App UI"
                        FontSize 18
                        HorizontalOptions LayoutOptions.Center
                        SematicDescription "Welcome to dot net Multi platform App UI"
                        SematicHeadingLevel SemanticHeadingLevel.Level2
                    }
                    Button'() {
                        Text "Click Me"
                        Clicked(fun _ -> count.Publish((+) 1))
                        HorizontalOptions LayoutOptions.Center
                        SematicHint "Counts the number of times you click"
                    }
                ]
            }
        }
    }


let Create sp =
//-:cnd:noEmit
#if DEBUG
    let dispatcher (fn: unit -> unit) =
        if Application.Current <> null then
            Application.Current.Dispatcher.Dispatch fn |> ignore
    UI.hotreload("MAUIApp.Entry.homePage", (fun () -> homePage), (), dispatcher).Build<ContentPage>(sp)
#else
    homePage.Build<ContentPage>(sp)
#endif
//+:cnd:noEmit
