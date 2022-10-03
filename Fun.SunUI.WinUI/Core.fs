namespace Fun.SunUI.WinUI

open FSharp.Data.Adaptive
open Microsoft.UI.Xaml.Controls
open Fun.SunUI


type WinUI =
    class
    end


type WinUIPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Panel>() =
    inherit ElementBuilder<WinUI, 'Element>()

    [<CustomOperation("Children")>]
    member inline this.Children([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinUI> seq) =
        this.MakeChildrenBuilder<'Element, Panel>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x ls ->
                for i in ls do
                    x.Element.Children.Add i
            ),
            controls
        )


    [<CustomOperation("Children")>]
    member inline this.Children([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinUI> alist) =
        this.MakeChildrenBuilder<'Element, Panel>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x ls ->
                for i in ls do
                    x.Element.Children.Add i
            ),
            controls
        )


    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Panel>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x ls ->
                for i in ls do
                    x.Element.Children.Add i
            ),
            controls
        )


type WinUIControlBuilder<'Element when 'Element :> Control>() =
    inherit ElementBuilder<WinUI, 'Element>()
