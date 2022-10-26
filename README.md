# Fun.SunUI 🌞

    This is an experimenting project. 💀⚡

The concept is to take the advantage of fsharp CE (Computation Expression) to build declarative UI layout without shadow DOM concept and complex diff algorithm. 

It is just a bunch of function or delegate to transform native control. To set its property or add child control. It is similar like you write WinForm or WPF application without designer or xaml, instead, you just use C# to write it. Here I use fsharp CE to make it simpler.


```fsharp
Window'() {
    Title "Demo"
    Grid'() {
        Children [
            TextBlock'() {
                Text "Hi"
            }
            Button'() {
                Text "Increase me"
                Click (fun _ -> ())
            }
        ]
    }
}
```


## Get started 🚀

You can install below dotnet template to get started:

```bash
dotnet new --install Fun.SunUI.Templates::0.0.*
```

## Supported UIStack

- MAUI
- Modern.Forms
- WinForms
- WPF
- Avalonia
- Terminal.Gui

In coming support:

- Fable Html
- WinUI3


## Documents

### Basic logic

When you write

```fsharp
TextBlock'() {
    Text "123"
}
```

It will become a record value like below:

```fsharp
{
    ElementCreator.RenderMode = RenderMode.CreateOnce
    CreateOrUpdate =
        fun (sp, ctx) ->
            let newCtx =
                match ctx with
                | ValueNone -> new ElementBuildContext(TextBlock(), sp, RenderMode.CreateOnce)
                | ValueSome ctx -> unbox ctx

            // BuildElement(fun ctx index ->
            //     ctx.NativeElement.Text <- "123"
            //     index + 1
            // ).Invoke(newCtx, 0)

            // Because inline, it will become
            let index = 0
            newCtx.NativeElement.Text <- "123"
            let index = index + 1

            // Of course it depends on the real use case, but the idea is the same.
            // Just some utils to set native properties directly.
            // The context is just for manage some resources, like IDispose obj, so we can dispose it when necessary.
            // Especially for event which we may need to remove previous handler when we register new handler.
            // Also for some adaptive data, we will also need to clear up the subcription.

            (newCtx :> IElementContext).RenderMode <- key
            newCtx
}
```

So, it will create a struct, one field is for how to render this, another field is a function for creating or updating the native element.

There are some more cases to cover, some property is an event, a Func or Action, or just a property with only getter. But all the CustomOperation is to help you get or set that native element's properties directly.

If there are some properties, or stuff which is special you want to handle by your self you can use **With** to access the native element directly:

```fsharp
Grid'() {
    With (fun ele ->
        ele.RowDefinitions.Add(RowDefinition(Height = GridLength.Auto))
    )
}
```

It is also very easy to extend the building DSL:

```fsharp
type Grid' with

    [<CustomOperation("Rows")>]
    member inline this.Rows([<InlineIfLambda>] builder: BuildElement<Grid>, rows: RowDefinition seq) = 
        this.With(builder, fun comp -> comp.RowDefinitions.Clear(); rows |> Seq.iter comp.RowDefinitions.Add)

Grid'() {
    // Use it like below
    Rows [ RowDefinition(Height = GridLength.Auto) ]
}
```

### Render logic

Render is controlled by render mode, it is a union case:

```fsharp
[<RequireQualifiedAccess; Struct>]
type RenderMode =
    /// Try to create if no old state, and rerender if the state is existing. This is default behavior.
    | CreateOnce
    /// Try to create if no old state, and do not rerender.
    | CreateOnceNoRerender
    /// Try to create if no old state with the same key, recreate if key changed. Rerender with old state.
    | Key of obj
    /// Always create new native element.
    | AlwaysRecreate
```

The parent element will cache the child element's context/state, and according to the child element's render mode, it will try to call the **CreateOrUpdate** function accordingly. And this will finally set the property of the related native element.

### Dependency injection

Fun.SunUI is just a light wrapper util to build UI layout, so eventualy, you will have to use it some where. For example in WPF:

First, you will create your UI layout with Fun.SunUI

```fsharp
let window =
    Windows'() {
        Title "Demo"
    }
```

Then, you will use it

```fsharp
let services = ServiceCollection()
let sp = services.BuildServiceProvider()

let nativeWindow = window.Build<Window>(sp) // use it here
Application() |> ignore
Application.Current.MainWindow <- nativeWindow

nativeWindow.Show()
Application.Current.Run nativeWindow
```

When you build it, it is required to pass a IServiceProvider in which is the baisc of DependencyInjection in dotnet ecosystem.

To consume a service is easy:

```fsharp
let myComp =
    UI.inject (fun ctx -> // wrap with this
        let someService = ctx.ServiceProvider.GetService<ISomeService>() // consume here

        // Return an ElementCreator
        Button'() {
            Content' "demo"
            Click (fun _ -> someService.DoSomething())
        }
    )

let window =
    Windows'() {
        Title "Demo"
        myComp // use it here
    }
```

### Adaptive

This is used for state management, it is a very great library. For more information, please check its [docs](https://github.com/fsprojects/FSharp.Data.Adaptive).

For most of properties with get and set, the generated DSL will support adaptive, for example:

```fsharp
let count = cval 1

Button'() {
    Content' (count |> AVal.map (sprintf "count = %d")) // when count is changed, the Content property of the Button will be reset. 
    Click(fun _ -> count.Publish((+) 1))
}
```

Another example is for element which contains multiple child elements:

```fsharp
let count = cval 1

Grid'() {
    Children (alist { // You can yield child elements according to the data you depends on.
        let! c = count
        if c > 0 then
            Button'() {
                Content' "123"
            }
        Button'() {
            Content' "Increase"
            Click(fun _ -> count.Publish((+) 1))
        }
    })
}
```


## Development and contribution

You will need **dotnet 6 SDK** to build this whole solution. There are some pipelines which is in build.fsx and it contains some pipelines for some tasks like generate internal DSL binding and nuget packages.

Contrition is quit simple, just raise a PR.
