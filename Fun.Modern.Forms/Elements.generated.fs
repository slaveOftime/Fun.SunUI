[<AutoOpen>]
module Fun.Modern.Forms.Elements

open Modern.Forms
open Fun.Modern.Forms


type FormBuilder() =
    inherit ElementBuilderBase<Form>()


    member inline this.Run([<InlineIfLambda>] builder: ElementBuilder<Form>) = this.MakeElementCreator(builder, (fun _ -> new Form()), this.GetKey())


    [<CustomOperation("Closing")>]
    member inline this.Closing([<InlineIfLambda>] builder: ElementBuilder<Form>, [<InlineIfLambda>] fn) =
        this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), nameof this.Closing, fn)

    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: ElementBuilder<Form>, controls: ElementCreator seq) =
        this.MakeChildrenBuilder(builder, (fun x -> x.Element.Controls), controls)


type ControlBuilder<'Element when 'Element :> Control>() =

    inherit ElementBuilderBase<'Element>()


    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: ElementBuilder<'Element>, controls: ElementCreator seq) =
        this.MakeChildrenBuilder(builder, (fun x -> x.Element.Controls), controls)


    [<CustomOperation("Click")>]
    member inline this.Click([<InlineIfLambda>] builder: ElementBuilder<'Element>, [<InlineIfLambda>] fn) =
        this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), nameof this.Click, fn)


    [<CustomOperation("Text")>]
    member inline this.Text([<InlineIfLambda>] builder: ElementBuilder<'Element>, text) =
        this.MakeCompareablePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), text)

    [<CustomOperation("Text")>]
    member inline this.Text([<InlineIfLambda>] builder: ElementBuilder<'Element>, text) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), text)


    [<CustomOperation("Left")>]
    member inline this.Left([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeCompareablePropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), value)

    [<CustomOperation("Left")>]
    member inline this.Left([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), value)


    [<CustomOperation("Top")>]
    member inline this.Top([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeCompareablePropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), value)

    [<CustomOperation("Top")>]
    member inline this.Top([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), value)


    [<CustomOperation("Height")>]
    member inline this.Height([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeCompareablePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), value)

    [<CustomOperation("Height")>]
    member inline this.Height([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), value)


    [<CustomOperation("Width")>]
    member inline this.Width([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeCompareablePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), value)

    [<CustomOperation("Width")>]
    member inline this.Width([<InlineIfLambda>] builder: ElementBuilder<'Element>, value) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), value)



type FlowLayoutPanelBuilder() =
    inherit ControlBuilder<FlowLayoutPanel>()

    member inline this.Run([<InlineIfLambda>] builder: ElementBuilder<FlowLayoutPanel>) =
        this.MakeElementCreator(builder, (fun _ -> new FlowLayoutPanel()), this.GetKey())


type ButtonBuilder() =

    inherit ControlBuilder<Button>()

    member inline this.Run([<InlineIfLambda>] builder: ElementBuilder<Button>) =
        this.MakeElementCreator(builder, (fun _ -> new Button()), this.GetKey())



type LabelBuilder() =

    inherit ControlBuilder<Label>()

    member inline this.Run([<InlineIfLambda>] builder: ElementBuilder<Label>) =
        this.MakeElementCreator(builder, (fun _ -> new Label()), this.GetKey())




let inline form () = FormBuilder()
let inline button () = ButtonBuilder()
let inline label () = LabelBuilder()
let inline flowLayoutPanel () = FlowLayoutPanelBuilder()
