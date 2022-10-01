[<AutoOpen>]
module Fun.SunUI.ModernForms.Elements

open Modern.Forms
open Fun.SunUI
open Fun.SunUI.ModernForms


type FormBuilder() =
    inherit ElementBuilder<ModernForms, Form>()


    member inline this.Run([<InlineIfLambda>] builder: BuildElement<Form>) = this.MakeElementCreator(builder, (fun _ -> new Form()), this.GetKey())


    [<CustomOperation("Closing")>]
    member inline this.Closing([<InlineIfLambda>] builder: BuildElement<Form>, [<InlineIfLambda>] fn) =
        this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), nameof this.Closing, fn)

    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<Form>, controls: ElementCreator<ModernForms> seq) =
        this.MakeChildrenBuilder<Form, Control>(
            builder,
            (fun x -> x.Element.Controls.Count),
            (fun x -> x.Element.Controls.Clear()),
            (fun x ls -> x.Element.Controls.AddRange(ls)),
            controls
        )


type ControlBuilder<'Element when 'Element :> Control>() =

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

    [<CustomOperation("Click")>]
    member inline this.Click([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn) =
        this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), nameof this.Click, fn)


    [<CustomOperation("Text")>]
    member inline this.Text([<InlineIfLambda>] builder: BuildElement<'Element>, text) =
        this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), text)

    [<CustomOperation("Text")>]
    member inline this.Text([<InlineIfLambda>] builder: BuildElement<'Element>, text) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), text)


    [<CustomOperation("Left")>]
    member inline this.Left([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), value)

    [<CustomOperation("Left")>]
    member inline this.Left([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), value)


    [<CustomOperation("Top")>]
    member inline this.Top([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), value)

    [<CustomOperation("Top")>]
    member inline this.Top([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), value)


    [<CustomOperation("Height")>]
    member inline this.Height([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), value)

    [<CustomOperation("Height")>]
    member inline this.Height([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), value)


    [<CustomOperation("Width")>]
    member inline this.Width([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), value)

    [<CustomOperation("Width")>]
    member inline this.Width([<InlineIfLambda>] builder: BuildElement<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), value)



type FlowLayoutPanelBuilder() =
    inherit ControlBuilder<FlowLayoutPanel>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<FlowLayoutPanel>) =
        this.MakeElementCreator(builder, (fun _ -> new FlowLayoutPanel()), this.GetKey())


type ButtonBuilder() =

    inherit ControlBuilder<Button>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<Button>) =
        this.MakeElementCreator(builder, (fun _ -> new Button()), this.GetKey())



type LabelBuilder() =

    inherit ControlBuilder<Label>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<Label>) = this.MakeElementCreator(builder, (fun _ -> new Label()), this.GetKey())




let inline form () = FormBuilder()
let inline button () = ButtonBuilder()
let inline label () = LabelBuilder()
let inline flowLayoutPanel () = FlowLayoutPanelBuilder()
