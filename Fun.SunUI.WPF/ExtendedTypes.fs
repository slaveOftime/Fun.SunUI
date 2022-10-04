namespace Fun.SunUI.WPF

open System.Windows
open System.Windows.Controls
open FSharp.Data.Adaptive
open Fun.SunUI


type WPFPanelBuilder<'Element when 'Element :> Panel>() =
    inherit DslInternals.FrameworkElementBuilder<'Element>()

    [<CustomOperation("Children")>]
    member inline this.Children([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WPF> seq) =
        this.MakeChildrenBuilder<'Element, UIElement>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x ls ->
                for i in ls do
                    x.Element.Children.Add i |> ignore
            ),
            controls
        )


    [<CustomOperation("Children")>]
    member inline this.Children([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WPF> alist) =
        this.MakeChildrenBuilder<'Element, UIElement>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x ls ->
                for i in ls do
                    x.Element.Children.Add i |> ignore
            ),
            controls
        )


    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WPF> seq) =
        this.MakeStaticChildrenBuilder<'Element, UIElement>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x ls ->
                for i in ls do
                    x.Element.Children.Add i |> ignore
            ),
            controls
        )


type WPFContentControlBuilder<'Element when 'Element :> ContentControl>() =
    inherit DslInternals.FrameworkElementBuilder<'Element>()

    [<CustomOperation("Content")>]
    member inline this.Content([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content([<InlineIfLambda>] builder: BuildElement<'Element>, content: string) =
        this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), content)

    [<CustomOperation("Content")>]
    member inline this.Content([<InlineIfLambda>] builder: BuildElement<'Element>, content: string aval) =
        this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), AVal.map box content)
