namespace Fun.SunUI.Html

open FSharp.Data.Adaptive
open Fun.SunUI
open Browser.Types

type Html =
    class
    end


type HtmlCoreBuilder<'Element when 'Element :> HTMLElement>() =
    inherit ElementBuilder<Html, 'Element>()

    [<CustomOperation("children")>]
    member inline this.children([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<Html> seq) =
        this.MakeChildrenBuilder<'Element, Node>(
            builder,
            (fun x -> x.Element.innerHTML <- ""),
            (fun x (ls: Node[]) ->
                for item in ls do
                    x.Element.appendChild item |> ignore
            ),
            items
        )

    [<CustomOperation("children")>]
    member inline this.children([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<Html> alist) =
        this.MakeChildrenBuilder<'Element, Node>(
            builder,
            (fun x -> x.Element.innerHTML <- ""),
            (fun x (ls: Node[]) ->
                for item in ls do
                    x.Element.appendChild item |> ignore
            ),
            items
        )

    [<CustomOperation("staticChildren")>]
    member inline this.staticChildren([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<Html> seq) =
        this.MakeStaticChildrenBuilder<'Element, Node>(
            builder,
            (fun x -> x.Element.innerHTML <- ""),
            (fun x (ls: Node[]) ->
                for item in ls do
                    x.Element.appendChild item |> ignore
            ),
            items
        )
