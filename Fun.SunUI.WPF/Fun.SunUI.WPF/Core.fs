namespace Fun.SunUI.WPF

open Fun.SunUI


type WPF =
    class
    end


type WPFElementBuilder<'Element>() =
    inherit ElementBuilder<WPF, 'Element>()
