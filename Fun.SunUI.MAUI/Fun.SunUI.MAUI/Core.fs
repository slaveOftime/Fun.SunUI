namespace Microsoft.Maui.Controls

open Fun.SunUI


type MAUI =
    class
    end


type MAUIElementBuilder<'Element>() =
    inherit ElementBuilder<MAUI, 'Element>()
