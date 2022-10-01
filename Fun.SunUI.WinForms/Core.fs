namespace Fun.SunUI.WinForms

open System.Windows.Forms
open Fun.SunUI


type WinForms =
    class
    end


type WinFormsControlBuilder<'Element when 'Element :> Control>() =
    inherit ElementBuilder<WinForms, 'Element>()

    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinForms> seq) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x -> x.Element.Controls.Count),
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )
