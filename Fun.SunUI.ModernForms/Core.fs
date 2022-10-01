namespace Fun.SunUI.ModernForms

open Modern.Forms
open Fun.SunUI


type ModernForms =
    class
    end


type ModernFormsControlBuilder<'Element when 'Element :> Control>() =
    inherit ElementBuilder<ModernForms, 'Element>()

    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<ModernForms> seq) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x -> x.Element.Controls.Count),
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )


type ModernFormsWindowBaseBuilder<'Element when 'Element :> WindowBase>() =
    inherit ElementBuilder<ModernForms, 'Element>()

    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<ModernForms> seq) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x -> x.Element.Controls.Count),
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )
