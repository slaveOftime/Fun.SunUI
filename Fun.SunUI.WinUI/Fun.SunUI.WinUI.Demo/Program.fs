open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls


type App() =
    inherit Application()

    do Application.Start(fun x -> ())


    override _.OnLaunched(args) =
        let mainWindow = Window()

        let button = Button()
        button.Content <- "Click Me"
        button.Click.Add(fun _ -> button.Content <- "Clicked")

        let stack = StackPanel()
        stack.Children.Add button

        mainWindow.Content <- stack
        mainWindow.Activate()


App() |> ignore

