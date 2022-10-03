namespace Fun.SunUI.ModernForms

open FSharp.Data.Adaptive
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
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )


    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<ModernForms> alist) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )


    [<CustomOperation("StaticControls")>]
    member inline this.StaticControls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<ModernForms> seq) =
        this.MakeStaticChildrenBuilder<'Element, Control>(
            builder,
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
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )


    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<ModernForms> alist) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )


    [<CustomOperation("StaticControls")>]
    member inline this.StaticControls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<ModernForms> seq) =
        this.MakeStaticChildrenBuilder<'Element, Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )
