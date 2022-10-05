module Fun.SunUI.MAUI.Demo.Main

open FSharp.Data.Adaptive
open Microsoft.Maui
open Microsoft.Maui.Controls
open Fun.SunUI
open Fun.SunUI.MAUI


let Create (sp) =
    let count = cval 0

    let shell =
        Shell'() {
            Items [
                ShellContent'() {
                    Title "Page 1"
                    ContentPage'() {
                        ScrollView'() {
                            VerticalStackLayout'() {
                                Spacing 25
                                Padding(Thickness(30, 0))
                                VerticalOptions LayoutOptions.Center
                                Children [
                                    Image'() {
                                        With(fun this -> SemanticProperties.SetDescription(this, "Cute dot net bot waving hi to you!"))
                                        Source(FileImageSource'() { File "dotnet_bot.png" })
                                        HeightRequest 200.
                                        HorizontalOptions LayoutOptions.Center
                                    }
                                    Label'() {
                                        With(fun this -> SemanticProperties.SetHeadingLevel(this, SemanticHeadingLevel.Level1))
                                        Text(count |> AVal.map (sprintf "Count = %d"))
                                        FontSize 32
                                        HorizontalOptions LayoutOptions.Center
                                    }
                                    Label'() {
                                        With(fun this ->
                                            SemanticProperties.SetDescription(this, "Welcome to dot net Multi platform App UI")
                                            SemanticProperties.SetHeadingLevel(this, SemanticHeadingLevel.Level2)
                                        )
                                        Text "Welcome to .NET Multi-platform App UI"
                                        FontSize 18
                                        HorizontalOptions LayoutOptions.Center
                                    }
                                    Button'() {
                                        With(fun this -> SemanticProperties.SetHint(this, "Counts the number of times you click"))
                                        Text "Click Me"
                                        Clicked(fun _ -> count.Publish((+) 1))
                                        HorizontalOptions LayoutOptions.Center
                                    }
                                ]
                            }
                        }
                    }
                }
            ]
        }

    shell.Build<Shell>(sp)
