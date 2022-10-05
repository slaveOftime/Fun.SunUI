namespace Fun.SunUI.ModernForms

open Fun.SunUI


type ModernForms =
    class
    end


type ModernFormsControlBuilder<'Element>() =
    inherit ElementBuilder<ModernForms, 'Element>()


type ModernFormsWindowBaseBuilder<'Element>() =
    inherit ElementBuilder<ModernForms, 'Element>()
