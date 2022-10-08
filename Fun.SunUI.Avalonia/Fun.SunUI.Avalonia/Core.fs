namespace Fun.SunUI.Avalonia

open Fun.SunUI


type Avalonia =
    class
    end


type AvaloniaElementBuilder<'Element>() =
    inherit ElementBuilder<Avalonia, 'Element>()
