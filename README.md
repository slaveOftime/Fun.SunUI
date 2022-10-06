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
dotnet new --install Fun.SunUI.Templates::0.0.1
```

## Supported UIStack

    Require dotnet6 or above

- MAUI
- Modern.Forms
- WinForms
- WPF

In coming support:

- Avanolia
- Fable Html
- Uno
- WinUI3


## Documents

### Build logic
### Render logic
### Dependency injection
### Adaptive
