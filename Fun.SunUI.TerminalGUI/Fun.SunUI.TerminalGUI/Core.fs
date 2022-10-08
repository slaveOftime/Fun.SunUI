namespace Fun.SunUI.TerminalGUI

open FSharp.Data.Adaptive
open Terminal.Gui
open Fun.SunUI


type TerminalGUI =
    class
    end


type TerminalGUIViewBuilder<'Element when 'Element :> View>() =
    inherit ElementBuilder<TerminalGUI, 'Element>()

    [<CustomOperation("Children")>]
    member inline this.Children([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> seq) =
        this.MakeChildrenBuilder<'Element, View>(builder, (fun x -> x.Element.RemoveAll()), (fun x (ls: View[]) -> x.Element.Add(ls)), items)

    [<CustomOperation("Children")>]
    member inline this.Children([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> alist) =
        this.MakeChildrenBuilder<'Element, View>(builder, (fun x -> x.Element.RemoveAll()), (fun x (ls: View[]) -> x.Element.Add(ls)), items)

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, View>(builder, (fun x -> x.Element.RemoveAll()), (fun x (ls: View[]) -> x.Element.Add(ls)), items)
