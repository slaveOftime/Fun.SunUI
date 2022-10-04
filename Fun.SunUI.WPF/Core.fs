namespace Fun.SunUI.WPF

open System.Windows
open Fun.SunUI


type WPF =
    class
    end


type WPFElementBuilder<'Element when 'Element :> FrameworkElement>() =
    inherit ElementBuilder<WPF, 'Element>()
