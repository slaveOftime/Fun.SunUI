namespace rec Fun.SunUI.TerminalGUI.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.TerminalGUI.DslInternals
open Fun.SunUI
open Fun.SunUI.TerminalGUI


type ViewBuilder<'Element when 'Element :> Terminal.Gui.View>() =
    inherit TerminalGUIViewBuilder<'Element>()

    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Key) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("HotKeySpecifier")>] member inline this.HotKeySpecifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Rune) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HotKeySpecifier), (fun ctx x -> ctx.Element.HotKeySpecifier <- x), x)
    [<CustomOperation("HotKeySpecifier")>] member inline this.HotKeySpecifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HotKeySpecifier), (fun ctx x -> ctx.Element.HotKeySpecifier <- x), x)
    [<CustomOperation("Shortcut")>] member inline this.Shortcut ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Key) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Shortcut), (fun ctx x -> ctx.Element.Shortcut <- x), x)
    [<CustomOperation("Shortcut")>] member inline this.Shortcut ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Shortcut), (fun ctx x -> ctx.Element.Shortcut <- x), x)
    [<CustomOperation("ShortcutTagEx")>] member inline this.ShortcutTagEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ShortcutTag), x)
    [<CustomOperation("ShortcutTagEx'")>] member inline this.ShortcutTagEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ShortcutTag), x)
    [<CustomOperation("ShortcutTag")>] member inline this.ShortcutTag ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ShortcutTag), x)
    [<CustomOperation("ShortcutTag'")>] member inline this.ShortcutTag' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ShortcutTag), x)
    [<CustomOperation("ShortcutAction")>] member inline this.ShortcutAction ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Action) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShortcutAction), (fun ctx x -> ctx.Element.ShortcutAction <- x), x)
    [<CustomOperation("ShortcutAction")>] member inline this.ShortcutAction ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShortcutAction), (fun ctx x -> ctx.Element.ShortcutAction <- x), x)
    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)
    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)

    [<CustomOperation("Subviews")>]
    member inline this.Subviews ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> seq) =
        this.MakeChildrenBuilder<'Element, Terminal.Gui.View>(
            builder,
            (fun x -> x.Element.Subviews.Clear()),
            (fun x (ls: Terminal.Gui.View[]) -> for i in ls do x.Element.Subviews.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Subviews")>]
    member inline this.Subviews ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> alist) =
        this.MakeChildrenBuilder<'Element, Terminal.Gui.View>(
            builder,
            (fun x -> x.Element.Subviews.Clear()),
            (fun x (ls: Terminal.Gui.View[]) -> for i in ls do x.Element.Subviews.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticSubviews")>]
    member inline this.StaticSubviews ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Terminal.Gui.View>(
            builder,
            (fun x -> x.Element.Subviews.Clear()),
            (fun x (ls: Terminal.Gui.View[]) -> for i in ls do x.Element.Subviews.Add(i) |> ignore),
            items
        )
                        

    [<CustomOperation("TabIndexes")>]
    member inline this.TabIndexes ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> seq) =
        this.MakeChildrenBuilder<'Element, Terminal.Gui.View>(
            builder,
            (fun x -> x.Element.TabIndexes.Clear()),
            (fun x (ls: Terminal.Gui.View[]) -> for i in ls do x.Element.TabIndexes.Add(i) |> ignore),
            items
        )

    [<CustomOperation("TabIndexes")>]
    member inline this.TabIndexes ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> alist) =
        this.MakeChildrenBuilder<'Element, Terminal.Gui.View>(
            builder,
            (fun x -> x.Element.TabIndexes.Clear()),
            (fun x (ls: Terminal.Gui.View[]) -> for i in ls do x.Element.TabIndexes.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticTabIndexes")>]
    member inline this.StaticTabIndexes ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<TerminalGUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Terminal.Gui.View>(
            builder,
            (fun x -> x.Element.TabIndexes.Clear()),
            (fun x (ls: Terminal.Gui.View[]) -> for i in ls do x.Element.TabIndexes.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("TabStop")>] member inline this.TabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStop), (fun ctx x -> ctx.Element.TabStop <- x), x)
    [<CustomOperation("TabStop")>] member inline this.TabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStop), (fun ctx x -> ctx.Element.TabStop <- x), x)
    [<CustomOperation("CanFocus")>] member inline this.CanFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanFocus), (fun ctx x -> ctx.Element.CanFocus <- x), x)
    [<CustomOperation("CanFocus")>] member inline this.CanFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanFocus), (fun ctx x -> ctx.Element.CanFocus <- x), x)
    [<CustomOperation("Id")>] member inline this.Id ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Id), (fun ctx x -> ctx.Element.Id <- x), x)
    [<CustomOperation("Id")>] member inline this.Id ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Id), (fun ctx x -> ctx.Element.Id <- x), x)
    [<CustomOperation("WantMousePositionReports")>] member inline this.WantMousePositionReports ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WantMousePositionReports), (fun ctx x -> ctx.Element.WantMousePositionReports <- x), x)
    [<CustomOperation("WantMousePositionReports")>] member inline this.WantMousePositionReports ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WantMousePositionReports), (fun ctx x -> ctx.Element.WantMousePositionReports <- x), x)
    [<CustomOperation("WantContinuousButtonPressed")>] member inline this.WantContinuousButtonPressed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WantContinuousButtonPressed), (fun ctx x -> ctx.Element.WantContinuousButtonPressed <- x), x)
    [<CustomOperation("WantContinuousButtonPressed")>] member inline this.WantContinuousButtonPressed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WantContinuousButtonPressed), (fun ctx x -> ctx.Element.WantContinuousButtonPressed <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("LayoutStyle")>] member inline this.LayoutStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.LayoutStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutStyle), (fun ctx x -> ctx.Element.LayoutStyle <- x), x)
    [<CustomOperation("LayoutStyle")>] member inline this.LayoutStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutStyle), (fun ctx x -> ctx.Element.LayoutStyle <- x), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Bounds), (fun ctx x -> ctx.Element.Bounds <- x), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Bounds), (fun ctx x -> ctx.Element.Bounds <- x), x)
    [<CustomOperation("X")>] member inline this.X ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Pos) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.X), (fun ctx x -> ctx.Element.X <- x), x)
    [<CustomOperation("X")>] member inline this.X ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.X), (fun ctx x -> ctx.Element.X <- x), x)
    [<CustomOperation("Y")>] member inline this.Y ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Pos) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Y), (fun ctx x -> ctx.Element.Y <- x), x)
    [<CustomOperation("Y")>] member inline this.Y ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Y), (fun ctx x -> ctx.Element.Y <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Dim) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Dim) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("ForceValidatePosDim")>] member inline this.ForceValidatePosDim ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ForceValidatePosDim), (fun ctx x -> ctx.Element.ForceValidatePosDim <- x), x)
    [<CustomOperation("ForceValidatePosDim")>] member inline this.ForceValidatePosDim ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ForceValidatePosDim), (fun ctx x -> ctx.Element.ForceValidatePosDim <- x), x)
    [<CustomOperation("TextFormatter")>] member inline this.TextFormatter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TextFormatter) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextFormatter), (fun ctx x -> ctx.Element.TextFormatter <- x), x)
    [<CustomOperation("TextFormatter")>] member inline this.TextFormatter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextFormatter), (fun ctx x -> ctx.Element.TextFormatter <- x), x)
    [<CustomOperation("SuperViewEx")>] member inline this.SuperViewEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SuperView), x)
    [<CustomOperation("SuperViewEx'")>] member inline this.SuperViewEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SuperView), x)
    [<CustomOperation("SuperView")>] member inline this.SuperView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SuperView), x)
    [<CustomOperation("SuperView'")>] member inline this.SuperView' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SuperView), x)
    [<CustomOperation("FocusedEx")>] member inline this.FocusedEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Focused), x)
    [<CustomOperation("FocusedEx'")>] member inline this.FocusedEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Focused), x)
    [<CustomOperation("Focused")>] member inline this.Focused ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Focused), x)
    [<CustomOperation("Focused'")>] member inline this.Focused' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Focused), x)
    [<CustomOperation("MostFocusedEx")>] member inline this.MostFocusedEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MostFocused), x)
    [<CustomOperation("MostFocusedEx'")>] member inline this.MostFocusedEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MostFocused), x)
    [<CustomOperation("MostFocused")>] member inline this.MostFocused ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.MostFocused), x)
    [<CustomOperation("MostFocused'")>] member inline this.MostFocused' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.MostFocused), x)
    [<CustomOperation("ColorScheme")>] member inline this.ColorScheme ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.ColorScheme) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorScheme), (fun ctx x -> ctx.Element.ColorScheme <- x), x)
    [<CustomOperation("ColorScheme")>] member inline this.ColorScheme ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColorScheme), (fun ctx x -> ctx.Element.ColorScheme <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("AutoSize")>] member inline this.AutoSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSize), (fun ctx x -> ctx.Element.AutoSize <- x), x)
    [<CustomOperation("AutoSize")>] member inline this.AutoSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSize), (fun ctx x -> ctx.Element.AutoSize <- x), x)
    [<CustomOperation("PreserveTrailingSpaces")>] member inline this.PreserveTrailingSpaces ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreserveTrailingSpaces), (fun ctx x -> ctx.Element.PreserveTrailingSpaces <- x), x)
    [<CustomOperation("PreserveTrailingSpaces")>] member inline this.PreserveTrailingSpaces ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreserveTrailingSpaces), (fun ctx x -> ctx.Element.PreserveTrailingSpaces <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.VerticalTextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("TextDirection")>] member inline this.TextDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TextDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDirection), (fun ctx x -> ctx.Element.TextDirection <- x), x)
    [<CustomOperation("TextDirection")>] member inline this.TextDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDirection), (fun ctx x -> ctx.Element.TextDirection <- x), x)
    [<CustomOperation("IsInitialized")>] member inline this.IsInitialized ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInitialized), (fun ctx x -> ctx.Element.IsInitialized <- x), x)
    [<CustomOperation("IsInitialized")>] member inline this.IsInitialized ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInitialized), (fun ctx x -> ctx.Element.IsInitialized <- x), x)
    [<CustomOperation("Enabled")>] member inline this.Enabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Enabled), (fun ctx x -> ctx.Element.Enabled <- x), x)
    [<CustomOperation("Enabled")>] member inline this.Enabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Enabled), (fun ctx x -> ctx.Element.Enabled <- x), x)
    [<CustomOperation("ClearOnVisibleFalse")>] member inline this.ClearOnVisibleFalse ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClearOnVisibleFalse), (fun ctx x -> ctx.Element.ClearOnVisibleFalse <- x), x)
    [<CustomOperation("ClearOnVisibleFalse")>] member inline this.ClearOnVisibleFalse ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClearOnVisibleFalse), (fun ctx x -> ctx.Element.ClearOnVisibleFalse <- x), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Border) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)

    [<CustomOperation("Added")>] member inline this.Added ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Added), (fun ctx -> ctx.Element.remove_Added), "Added", fn)
    [<CustomOperation("Removed")>] member inline this.Removed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Removed), (fun ctx -> ctx.Element.remove_Removed), "Removed", fn)
    [<CustomOperation("Enter")>] member inline this.Enter ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Enter), (fun ctx -> ctx.Element.remove_Enter), "Enter", fn)
    [<CustomOperation("Leave")>] member inline this.Leave ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Leave), (fun ctx -> ctx.Element.remove_Leave), "Leave", fn)
    [<CustomOperation("MouseEnter")>] member inline this.MouseEnter ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MouseEnter), (fun ctx -> ctx.Element.remove_MouseEnter), "MouseEnter", fn)
    [<CustomOperation("MouseLeave")>] member inline this.MouseLeave ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MouseLeave), (fun ctx -> ctx.Element.remove_MouseLeave), "MouseLeave", fn)
    [<CustomOperation("MouseClick")>] member inline this.MouseClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MouseClick), (fun ctx -> ctx.Element.remove_MouseClick), "MouseClick", fn)
    [<CustomOperation("CanFocusChanged")>] member inline this.CanFocusChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_CanFocusChanged), (fun ctx -> ctx.Element.remove_CanFocusChanged), "CanFocusChanged", fn)
    [<CustomOperation("EnabledChanged")>] member inline this.EnabledChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_EnabledChanged), (fun ctx -> ctx.Element.remove_EnabledChanged), "EnabledChanged", fn)
    [<CustomOperation("VisibleChanged")>] member inline this.VisibleChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_VisibleChanged), (fun ctx -> ctx.Element.remove_VisibleChanged), "VisibleChanged", fn)
    [<CustomOperation("HotKeyChanged")>] member inline this.HotKeyChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_HotKeyChanged), (fun ctx -> ctx.Element.remove_HotKeyChanged), "HotKeyChanged", fn)
    [<CustomOperation("DrawContent")>] member inline this.DrawContent ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_DrawContent), (fun ctx -> ctx.Element.remove_DrawContent), "DrawContent", fn)
    [<CustomOperation("DrawContentComplete")>] member inline this.DrawContentComplete ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_DrawContentComplete), (fun ctx -> ctx.Element.remove_DrawContentComplete), "DrawContentComplete", fn)
    [<CustomOperation("KeyPress")>] member inline this.KeyPress ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_KeyPress), (fun ctx -> ctx.Element.remove_KeyPress), "KeyPress", fn)
    [<CustomOperation("KeyDown")>] member inline this.KeyDown ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_KeyDown), (fun ctx -> ctx.Element.remove_KeyDown), "KeyDown", fn)
    [<CustomOperation("KeyUp")>] member inline this.KeyUp ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_KeyUp), (fun ctx -> ctx.Element.remove_KeyUp), "KeyUp", fn)
    [<CustomOperation("LayoutStarted")>] member inline this.LayoutStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_LayoutStarted), (fun ctx -> ctx.Element.remove_LayoutStarted), "LayoutStarted", fn)
    [<CustomOperation("LayoutComplete")>] member inline this.LayoutComplete ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_LayoutComplete), (fun ctx -> ctx.Element.remove_LayoutComplete), "LayoutComplete", fn)
    [<CustomOperation("Initialized")>] member inline this.Initialized ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Initialized), "Initialized", fn)
                

type ToplevelBuilder<'Element when 'Element :> Terminal.Gui.Toplevel>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Running")>] member inline this.Running ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Running), (fun ctx x -> ctx.Element.Running <- x), x)
    [<CustomOperation("Running")>] member inline this.Running ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Running), (fun ctx x -> ctx.Element.Running <- x), x)
    [<CustomOperation("Modal")>] member inline this.Modal ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Modal), (fun ctx x -> ctx.Element.Modal <- x), x)
    [<CustomOperation("Modal")>] member inline this.Modal ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Modal), (fun ctx x -> ctx.Element.Modal <- x), x)

    [<CustomOperation("MenuBar")>]
    member inline this.MenuBar ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.MenuBar <- x), creator)

    [<CustomOperation("MenuBar")>]
    member inline this.MenuBar ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.MenuBar <- x), creator)
                        

    [<CustomOperation("StatusBar")>]
    member inline this.StatusBar ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.StatusBar <- x), creator)

    [<CustomOperation("StatusBar")>]
    member inline this.StatusBar ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.StatusBar <- x), creator)
                        
    [<CustomOperation("IsMdiContainer")>] member inline this.IsMdiContainer ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsMdiContainer), (fun ctx x -> ctx.Element.IsMdiContainer <- x), x)
    [<CustomOperation("IsMdiContainer")>] member inline this.IsMdiContainer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsMdiContainer), (fun ctx x -> ctx.Element.IsMdiContainer <- x), x)

    [<CustomOperation("Loaded")>] member inline this.Loaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Loaded), (fun ctx -> ctx.Element.remove_Loaded), "Loaded", fn)
    [<CustomOperation("Ready")>] member inline this.Ready ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Ready), (fun ctx -> ctx.Element.remove_Ready), "Ready", fn)
    [<CustomOperation("Unloaded")>] member inline this.Unloaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Unloaded), (fun ctx -> ctx.Element.remove_Unloaded), "Unloaded", fn)
    [<CustomOperation("Activate")>] member inline this.Activate ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Activate), (fun ctx -> ctx.Element.remove_Activate), "Activate", fn)
    [<CustomOperation("Deactivate")>] member inline this.Deactivate ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Deactivate), (fun ctx -> ctx.Element.remove_Deactivate), "Deactivate", fn)
    [<CustomOperation("ChildClosed")>] member inline this.ChildClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_ChildClosed), (fun ctx -> ctx.Element.remove_ChildClosed), "ChildClosed", fn)
    [<CustomOperation("AllChildClosed")>] member inline this.AllChildClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_AllChildClosed), (fun ctx -> ctx.Element.remove_AllChildClosed), "AllChildClosed", fn)
    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Closing), (fun ctx -> ctx.Element.remove_Closing), "Closing", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Closed), (fun ctx -> ctx.Element.remove_Closed), "Closed", fn)
    [<CustomOperation("ChildLoaded")>] member inline this.ChildLoaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_ChildLoaded), (fun ctx -> ctx.Element.remove_ChildLoaded), "ChildLoaded", fn)
    [<CustomOperation("ChildUnloaded")>] member inline this.ChildUnloaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_ChildUnloaded), (fun ctx -> ctx.Element.remove_ChildUnloaded), "ChildUnloaded", fn)
    [<CustomOperation("Resized")>] member inline this.Resized ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Resized), (fun ctx -> ctx.Element.remove_Resized), "Resized", fn)
    [<CustomOperation("AlternateForwardKeyChanged")>] member inline this.AlternateForwardKeyChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_AlternateForwardKeyChanged), (fun ctx -> ctx.Element.remove_AlternateForwardKeyChanged), "AlternateForwardKeyChanged", fn)
    [<CustomOperation("AlternateBackwardKeyChanged")>] member inline this.AlternateBackwardKeyChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_AlternateBackwardKeyChanged), (fun ctx -> ctx.Element.remove_AlternateBackwardKeyChanged), "AlternateBackwardKeyChanged", fn)
    [<CustomOperation("QuitKeyChanged")>] member inline this.QuitKeyChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_QuitKeyChanged), (fun ctx -> ctx.Element.remove_QuitKeyChanged), "QuitKeyChanged", fn)
                

type WindowBuilder<'Element when 'Element :> Terminal.Gui.Window>() =
    inherit ToplevelBuilder<'Element>()

    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Border) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)

    [<CustomOperation("TitleChanging")>] member inline this.TitleChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_TitleChanging), (fun ctx -> ctx.Element.remove_TitleChanging), "TitleChanging", fn)
    [<CustomOperation("TitleChanged")>] member inline this.TitleChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_TitleChanged), (fun ctx -> ctx.Element.remove_TitleChanged), "TitleChanged", fn)
                

type DialogBuilder<'Element when 'Element :> Terminal.Gui.Dialog>() =
    inherit WindowBuilder<'Element>()

    [<CustomOperation("ButtonAlignment")>] member inline this.ButtonAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Dialog.ButtonAlignments) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ButtonAlignment), (fun ctx x -> ctx.Element.ButtonAlignment <- x), x)
    [<CustomOperation("ButtonAlignment")>] member inline this.ButtonAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ButtonAlignment), (fun ctx x -> ctx.Element.ButtonAlignment <- x), x)

                

type FileDialogBuilder<'Element when 'Element :> Terminal.Gui.FileDialog>() =
    inherit DialogBuilder<'Element>()

    [<CustomOperation("Prompt")>] member inline this.Prompt ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Prompt), (fun ctx x -> ctx.Element.Prompt <- x), x)
    [<CustomOperation("Prompt")>] member inline this.Prompt ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Prompt), (fun ctx x -> ctx.Element.Prompt <- x), x)
    [<CustomOperation("NameDirLabel")>] member inline this.NameDirLabel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NameDirLabel), (fun ctx x -> ctx.Element.NameDirLabel <- x), x)
    [<CustomOperation("NameDirLabel")>] member inline this.NameDirLabel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NameDirLabel), (fun ctx x -> ctx.Element.NameDirLabel <- x), x)
    [<CustomOperation("NameFieldLabel")>] member inline this.NameFieldLabel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NameFieldLabel), (fun ctx x -> ctx.Element.NameFieldLabel <- x), x)
    [<CustomOperation("NameFieldLabel")>] member inline this.NameFieldLabel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NameFieldLabel), (fun ctx x -> ctx.Element.NameFieldLabel <- x), x)
    [<CustomOperation("Message")>] member inline this.Message ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Message), (fun ctx x -> ctx.Element.Message <- x), x)
    [<CustomOperation("Message")>] member inline this.Message ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Message), (fun ctx x -> ctx.Element.Message <- x), x)
    [<CustomOperation("CanCreateDirectories")>] member inline this.CanCreateDirectories ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanCreateDirectories), (fun ctx x -> ctx.Element.CanCreateDirectories <- x), x)
    [<CustomOperation("CanCreateDirectories")>] member inline this.CanCreateDirectories ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanCreateDirectories), (fun ctx x -> ctx.Element.CanCreateDirectories <- x), x)
    [<CustomOperation("IsExtensionHidden")>] member inline this.IsExtensionHidden ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExtensionHidden), (fun ctx x -> ctx.Element.IsExtensionHidden <- x), x)
    [<CustomOperation("IsExtensionHidden")>] member inline this.IsExtensionHidden ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExtensionHidden), (fun ctx x -> ctx.Element.IsExtensionHidden <- x), x)
    [<CustomOperation("DirectoryPath")>] member inline this.DirectoryPath ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DirectoryPath), (fun ctx x -> ctx.Element.DirectoryPath <- x), x)
    [<CustomOperation("DirectoryPath")>] member inline this.DirectoryPath ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DirectoryPath), (fun ctx x -> ctx.Element.DirectoryPath <- x), x)
    [<CustomOperation("AllowedFileTypes")>] member inline this.AllowedFileTypes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String[]) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowedFileTypes), (fun ctx x -> ctx.Element.AllowedFileTypes <- x), x)
    [<CustomOperation("AllowedFileTypes")>] member inline this.AllowedFileTypes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowedFileTypes), (fun ctx x -> ctx.Element.AllowedFileTypes <- x), x)
    [<CustomOperation("AllowsOtherFileTypes")>] member inline this.AllowsOtherFileTypes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsOtherFileTypes), (fun ctx x -> ctx.Element.AllowsOtherFileTypes <- x), x)
    [<CustomOperation("AllowsOtherFileTypes")>] member inline this.AllowsOtherFileTypes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsOtherFileTypes), (fun ctx x -> ctx.Element.AllowsOtherFileTypes <- x), x)
    [<CustomOperation("FilePath")>] member inline this.FilePath ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FilePath), (fun ctx x -> ctx.Element.FilePath <- x), x)
    [<CustomOperation("FilePath")>] member inline this.FilePath ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FilePath), (fun ctx x -> ctx.Element.FilePath <- x), x)

                

type SaveDialogBuilder<'Element when 'Element :> Terminal.Gui.SaveDialog>() =
    inherit FileDialogBuilder<'Element>()

    [<CustomOperation("FileNameEx")>] member inline this.FileNameEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FileName), x)
    [<CustomOperation("FileNameEx'")>] member inline this.FileNameEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FileName), x)
    [<CustomOperation("FileName")>] member inline this.FileName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FileName), x)
    [<CustomOperation("FileName'")>] member inline this.FileName' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FileName), x)

                

type OpenDialogBuilder<'Element when 'Element :> Terminal.Gui.OpenDialog>() =
    inherit FileDialogBuilder<'Element>()

    [<CustomOperation("CanChooseFiles")>] member inline this.CanChooseFiles ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanChooseFiles), (fun ctx x -> ctx.Element.CanChooseFiles <- x), x)
    [<CustomOperation("CanChooseFiles")>] member inline this.CanChooseFiles ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanChooseFiles), (fun ctx x -> ctx.Element.CanChooseFiles <- x), x)
    [<CustomOperation("CanChooseDirectories")>] member inline this.CanChooseDirectories ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanChooseDirectories), (fun ctx x -> ctx.Element.CanChooseDirectories <- x), x)
    [<CustomOperation("CanChooseDirectories")>] member inline this.CanChooseDirectories ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanChooseDirectories), (fun ctx x -> ctx.Element.CanChooseDirectories <- x), x)
    [<CustomOperation("AllowsMultipleSelection")>] member inline this.AllowsMultipleSelection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsMultipleSelection), (fun ctx x -> ctx.Element.AllowsMultipleSelection <- x), x)
    [<CustomOperation("AllowsMultipleSelection")>] member inline this.AllowsMultipleSelection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsMultipleSelection), (fun ctx x -> ctx.Element.AllowsMultipleSelection <- x), x)
    [<CustomOperation("FilePathsEx")>] member inline this.FilePathsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FilePaths), x)
    [<CustomOperation("FilePathsEx'")>] member inline this.FilePathsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FilePaths), x)
    [<CustomOperation("FilePaths")>] member inline this.FilePaths ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FilePaths), x)
    [<CustomOperation("FilePaths'")>] member inline this.FilePaths' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FilePaths), x)

                

type WizardBuilder<'Element when 'Element :> Terminal.Gui.Wizard>() =
    inherit DialogBuilder<'Element>()

    [<CustomOperation("BackButtonEx")>] member inline this.BackButtonEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BackButton), x)
    [<CustomOperation("BackButtonEx'")>] member inline this.BackButtonEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BackButton), x)
    [<CustomOperation("BackButton")>] member inline this.BackButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.BackButton), x)
    [<CustomOperation("BackButton'")>] member inline this.BackButton' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.BackButton), x)
    [<CustomOperation("NextFinishButtonEx")>] member inline this.NextFinishButtonEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NextFinishButton), x)
    [<CustomOperation("NextFinishButtonEx'")>] member inline this.NextFinishButtonEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NextFinishButton), x)
    [<CustomOperation("NextFinishButton")>] member inline this.NextFinishButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.NextFinishButton), x)
    [<CustomOperation("NextFinishButton'")>] member inline this.NextFinishButton' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.NextFinishButton), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

    [<CustomOperation("CurrentStep")>]
    member inline this.CurrentStep ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentStep <- x), creator)

    [<CustomOperation("CurrentStep")>]
    member inline this.CurrentStep ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentStep <- x), creator)
                        
    [<CustomOperation("Modal")>] member inline this.Modal ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Modal), (fun ctx x -> ctx.Element.Modal <- x), x)
    [<CustomOperation("Modal")>] member inline this.Modal ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Modal), (fun ctx x -> ctx.Element.Modal <- x), x)

    [<CustomOperation("MovingBack")>] member inline this.MovingBack ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MovingBack), (fun ctx -> ctx.Element.remove_MovingBack), "MovingBack", fn)
    [<CustomOperation("MovingNext")>] member inline this.MovingNext ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MovingNext), (fun ctx -> ctx.Element.remove_MovingNext), "MovingNext", fn)
    [<CustomOperation("Finished")>] member inline this.Finished ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Finished), (fun ctx -> ctx.Element.remove_Finished), "Finished", fn)
    [<CustomOperation("Cancelled")>] member inline this.Cancelled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Cancelled), (fun ctx -> ctx.Element.remove_Cancelled), "Cancelled", fn)
    [<CustomOperation("StepChanging")>] member inline this.StepChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_StepChanging), (fun ctx -> ctx.Element.remove_StepChanging), "StepChanging", fn)
    [<CustomOperation("StepChanged")>] member inline this.StepChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_StepChanged), (fun ctx -> ctx.Element.remove_StepChanged), "StepChanged", fn)
                

type TextFieldBuilder<'Element when 'Element :> Terminal.Gui.TextField>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Used")>] member inline this.Used ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Used), (fun ctx x -> ctx.Element.Used <- x), x)
    [<CustomOperation("Used")>] member inline this.Used ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Used), (fun ctx x -> ctx.Element.Used <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("AutocompleteEx")>] member inline this.AutocompleteEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("AutocompleteEx'")>] member inline this.AutocompleteEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("Autocomplete")>] member inline this.Autocomplete ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("Autocomplete'")>] member inline this.Autocomplete' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Secret")>] member inline this.Secret ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Secret), (fun ctx x -> ctx.Element.Secret <- x), x)
    [<CustomOperation("Secret")>] member inline this.Secret ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Secret), (fun ctx x -> ctx.Element.Secret <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("ContextMenuEx")>] member inline this.ContextMenuEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ContextMenuEx'")>] member inline this.ContextMenuEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ContextMenu")>] member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ContextMenu'")>] member inline this.ContextMenu' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("CanFocus")>] member inline this.CanFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanFocus), (fun ctx x -> ctx.Element.CanFocus <- x), x)
    [<CustomOperation("CanFocus")>] member inline this.CanFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanFocus), (fun ctx x -> ctx.Element.CanFocus <- x), x)
    [<CustomOperation("SelectedStart")>] member inline this.SelectedStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedStart), (fun ctx x -> ctx.Element.SelectedStart <- x), x)
    [<CustomOperation("SelectedStart")>] member inline this.SelectedStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedStart), (fun ctx x -> ctx.Element.SelectedStart <- x), x)
    [<CustomOperation("SelectedTextEx")>] member inline this.SelectedTextEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("SelectedTextEx'")>] member inline this.SelectedTextEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("SelectedText'")>] member inline this.SelectedText' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.CursorVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)

    [<CustomOperation("TextChanging")>] member inline this.TextChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_TextChanging), (fun ctx -> ctx.Element.remove_TextChanging), "TextChanging", fn)
    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_TextChanged), (fun ctx -> ctx.Element.remove_TextChanged), "TextChanged", fn)
                

type DateFieldBuilder<'Element when 'Element :> Terminal.Gui.DateField>() =
    inherit TextFieldBuilder<'Element>()

    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("IsShortFormat")>] member inline this.IsShortFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsShortFormat), (fun ctx x -> ctx.Element.IsShortFormat <- x), x)
    [<CustomOperation("IsShortFormat")>] member inline this.IsShortFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsShortFormat), (fun ctx x -> ctx.Element.IsShortFormat <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)

    [<CustomOperation("DateChanged")>] member inline this.DateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_DateChanged), (fun ctx -> ctx.Element.remove_DateChanged), "DateChanged", fn)
                

type TimeFieldBuilder<'Element when 'Element :> Terminal.Gui.TimeField>() =
    inherit TextFieldBuilder<'Element>()

    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)
    [<CustomOperation("IsShortFormat")>] member inline this.IsShortFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsShortFormat), (fun ctx x -> ctx.Element.IsShortFormat <- x), x)
    [<CustomOperation("IsShortFormat")>] member inline this.IsShortFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsShortFormat), (fun ctx x -> ctx.Element.IsShortFormat <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)

    [<CustomOperation("TimeChanged")>] member inline this.TimeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_TimeChanged), (fun ctx -> ctx.Element.remove_TimeChanged), "TimeChanged", fn)
                

type ButtonBuilder<'Element when 'Element :> Terminal.Gui.Button>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("IsDefault")>] member inline this.IsDefault ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefault), (fun ctx x -> ctx.Element.IsDefault <- x), x)
    [<CustomOperation("IsDefault")>] member inline this.IsDefault ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefault), (fun ctx x -> ctx.Element.IsDefault <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Key) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)

    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Clicked), (fun ctx -> ctx.Element.remove_Clicked), "Clicked", fn)
                

type CheckBoxBuilder<'Element when 'Element :> Terminal.Gui.CheckBox>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)

    [<CustomOperation("Toggled")>] member inline this.Toggled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Toggled), (fun ctx -> ctx.Element.remove_Toggled), "Toggled", fn)
                

type ColorPickerBuilder<'Element when 'Element :> Terminal.Gui.ColorPicker>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("SelectedColor")>] member inline this.SelectedColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedColor), (fun ctx x -> ctx.Element.SelectedColor <- x), x)
    [<CustomOperation("SelectedColor")>] member inline this.SelectedColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedColor), (fun ctx x -> ctx.Element.SelectedColor <- x), x)

    [<CustomOperation("ColorChanged")>] member inline this.ColorChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_ColorChanged), (fun ctx -> ctx.Element.remove_ColorChanged), "ColorChanged", fn)
                

type ComboBoxBuilder<'Element when 'Element :> Terminal.Gui.ComboBox>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.IListDataSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("ColorScheme")>] member inline this.ColorScheme ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.ColorScheme) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorScheme), (fun ctx x -> ctx.Element.ColorScheme <- x), x)
    [<CustomOperation("ColorScheme")>] member inline this.ColorScheme ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColorScheme), (fun ctx x -> ctx.Element.ColorScheme <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("HideDropdownListOnClick")>] member inline this.HideDropdownListOnClick ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HideDropdownListOnClick), (fun ctx x -> ctx.Element.HideDropdownListOnClick <- x), x)
    [<CustomOperation("HideDropdownListOnClick")>] member inline this.HideDropdownListOnClick ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HideDropdownListOnClick), (fun ctx x -> ctx.Element.HideDropdownListOnClick <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

    [<CustomOperation("SelectedItemChanged")>] member inline this.SelectedItemChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_SelectedItemChanged), (fun ctx -> ctx.Element.remove_SelectedItemChanged), "SelectedItemChanged", fn)
    [<CustomOperation("Expanded")>] member inline this.Expanded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Expanded), (fun ctx -> ctx.Element.remove_Expanded), "Expanded", fn)
    [<CustomOperation("Collapsed")>] member inline this.Collapsed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Collapsed), (fun ctx -> ctx.Element.remove_Collapsed), "Collapsed", fn)
    [<CustomOperation("OpenSelectedItem")>] member inline this.OpenSelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_OpenSelectedItem), (fun ctx -> ctx.Element.remove_OpenSelectedItem), "OpenSelectedItem", fn)
                

type FrameViewBuilder<'Element when 'Element :> Terminal.Gui.FrameView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Border) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)

                

type GraphViewBuilder<'Element when 'Element :> Terminal.Gui.GraphView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("AxisX")>] member inline this.AxisX ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Graphs.HorizontalAxis) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AxisX), (fun ctx x -> ctx.Element.AxisX <- x), x)
    [<CustomOperation("AxisX")>] member inline this.AxisX ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AxisX), (fun ctx x -> ctx.Element.AxisX <- x), x)
    [<CustomOperation("AxisY")>] member inline this.AxisY ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Graphs.VerticalAxis) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AxisY), (fun ctx x -> ctx.Element.AxisY <- x), x)
    [<CustomOperation("AxisY")>] member inline this.AxisY ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AxisY), (fun ctx x -> ctx.Element.AxisY <- x), x)
    [<CustomOperation("SeriesEx")>] member inline this.SeriesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Series), x)
    [<CustomOperation("SeriesEx'")>] member inline this.SeriesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Series), x)
    [<CustomOperation("Series")>] member inline this.Series ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Series), x)
    [<CustomOperation("Series'")>] member inline this.Series' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Series), x)
    [<CustomOperation("AnnotationsEx")>] member inline this.AnnotationsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Annotations), x)
    [<CustomOperation("AnnotationsEx'")>] member inline this.AnnotationsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Annotations), x)
    [<CustomOperation("Annotations")>] member inline this.Annotations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Annotations), x)
    [<CustomOperation("Annotations'")>] member inline this.Annotations' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Annotations), x)
    [<CustomOperation("MarginLeft")>] member inline this.MarginLeft ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.UInt32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MarginLeft), (fun ctx x -> ctx.Element.MarginLeft <- x), x)
    [<CustomOperation("MarginLeft")>] member inline this.MarginLeft ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MarginLeft), (fun ctx x -> ctx.Element.MarginLeft <- x), x)
    [<CustomOperation("MarginBottom")>] member inline this.MarginBottom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.UInt32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MarginBottom), (fun ctx x -> ctx.Element.MarginBottom <- x), x)
    [<CustomOperation("MarginBottom")>] member inline this.MarginBottom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MarginBottom), (fun ctx x -> ctx.Element.MarginBottom <- x), x)
    [<CustomOperation("ScrollOffset")>] member inline this.ScrollOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.PointF) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOffset), (fun ctx x -> ctx.Element.ScrollOffset <- x), x)
    [<CustomOperation("ScrollOffset")>] member inline this.ScrollOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOffset), (fun ctx x -> ctx.Element.ScrollOffset <- x), x)
    [<CustomOperation("CellSize")>] member inline this.CellSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.PointF) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CellSize), (fun ctx x -> ctx.Element.CellSize <- x), x)
    [<CustomOperation("CellSize")>] member inline this.CellSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CellSize), (fun ctx x -> ctx.Element.CellSize <- x), x)
    [<CustomOperation("GraphColor")>] member inline this.GraphColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<Terminal.Gui.Attribute>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GraphColor), (fun ctx x -> ctx.Element.GraphColor <- x), x)
    [<CustomOperation("GraphColor")>] member inline this.GraphColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GraphColor), (fun ctx x -> ctx.Element.GraphColor <- x), x)

                

type HexViewBuilder<'Element when 'Element :> Terminal.Gui.HexView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.IO.Stream) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("DisplayStart")>] member inline this.DisplayStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int64) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayStart), (fun ctx x -> ctx.Element.DisplayStart <- x), x)
    [<CustomOperation("DisplayStart")>] member inline this.DisplayStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayStart), (fun ctx x -> ctx.Element.DisplayStart <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("AllowEdits")>] member inline this.AllowEdits ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowEdits), (fun ctx x -> ctx.Element.AllowEdits <- x), x)
    [<CustomOperation("AllowEdits")>] member inline this.AllowEdits ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowEdits), (fun ctx x -> ctx.Element.AllowEdits <- x), x)
    [<CustomOperation("EditsEx")>] member inline this.EditsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Edits), x)
    [<CustomOperation("EditsEx'")>] member inline this.EditsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Edits), x)
    [<CustomOperation("Edits")>] member inline this.Edits ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Edits), x)
    [<CustomOperation("Edits'")>] member inline this.Edits' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Edits), x)
    [<CustomOperation("CursorPositionEx")>] member inline this.CursorPositionEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CursorPosition), x)
    [<CustomOperation("CursorPositionEx'")>] member inline this.CursorPositionEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CursorPosition), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.CursorPosition), x)
    [<CustomOperation("CursorPosition'")>] member inline this.CursorPosition' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.CursorPosition), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.CursorVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)

    [<CustomOperation("Edited")>] member inline this.Edited ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Edited), (fun ctx -> ctx.Element.remove_Edited), "Edited", fn)
    [<CustomOperation("PositionChanged")>] member inline this.PositionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_PositionChanged), (fun ctx -> ctx.Element.remove_PositionChanged), "PositionChanged", fn)
                

type LabelBuilder<'Element when 'Element :> Terminal.Gui.Label>() =
    inherit ViewBuilder<'Element>()


    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_Clicked), (fun ctx -> ctx.Element.remove_Clicked), "Clicked", fn)
                

type LineViewBuilder<'Element when 'Element :> Terminal.Gui.LineView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("StartingAnchor")>] member inline this.StartingAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Rune>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StartingAnchor), (fun ctx x -> ctx.Element.StartingAnchor <- x), x)
    [<CustomOperation("StartingAnchor")>] member inline this.StartingAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StartingAnchor), (fun ctx x -> ctx.Element.StartingAnchor <- x), x)
    [<CustomOperation("EndingAnchor")>] member inline this.EndingAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Rune>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EndingAnchor), (fun ctx x -> ctx.Element.EndingAnchor <- x), x)
    [<CustomOperation("EndingAnchor")>] member inline this.EndingAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EndingAnchor), (fun ctx x -> ctx.Element.EndingAnchor <- x), x)
    [<CustomOperation("LineRune")>] member inline this.LineRune ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Rune) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineRune), (fun ctx x -> ctx.Element.LineRune <- x), x)
    [<CustomOperation("LineRune")>] member inline this.LineRune ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineRune), (fun ctx x -> ctx.Element.LineRune <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Graphs.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type ListViewBuilder<'Element when 'Element :> Terminal.Gui.ListView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.IListDataSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("AllowsMarking")>] member inline this.AllowsMarking ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsMarking), (fun ctx x -> ctx.Element.AllowsMarking <- x), x)
    [<CustomOperation("AllowsMarking")>] member inline this.AllowsMarking ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsMarking), (fun ctx x -> ctx.Element.AllowsMarking <- x), x)
    [<CustomOperation("AllowsMultipleSelection")>] member inline this.AllowsMultipleSelection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsMultipleSelection), (fun ctx x -> ctx.Element.AllowsMultipleSelection <- x), x)
    [<CustomOperation("AllowsMultipleSelection")>] member inline this.AllowsMultipleSelection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsMultipleSelection), (fun ctx x -> ctx.Element.AllowsMultipleSelection <- x), x)
    [<CustomOperation("TopItem")>] member inline this.TopItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TopItem), (fun ctx x -> ctx.Element.TopItem <- x), x)
    [<CustomOperation("TopItem")>] member inline this.TopItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TopItem), (fun ctx x -> ctx.Element.TopItem <- x), x)
    [<CustomOperation("LeftItem")>] member inline this.LeftItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LeftItem), (fun ctx x -> ctx.Element.LeftItem <- x), x)
    [<CustomOperation("LeftItem")>] member inline this.LeftItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LeftItem), (fun ctx x -> ctx.Element.LeftItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)

    [<CustomOperation("SelectedItemChanged")>] member inline this.SelectedItemChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_SelectedItemChanged), (fun ctx -> ctx.Element.remove_SelectedItemChanged), "SelectedItemChanged", fn)
    [<CustomOperation("OpenSelectedItem")>] member inline this.OpenSelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_OpenSelectedItem), (fun ctx -> ctx.Element.remove_OpenSelectedItem), "OpenSelectedItem", fn)
    [<CustomOperation("RowRender")>] member inline this.RowRender ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_RowRender), (fun ctx -> ctx.Element.remove_RowRender), "RowRender", fn)
                

type MenuBarBuilder<'Element when 'Element :> Terminal.Gui.MenuBar>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Menus")>] member inline this.Menus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.MenuBarItem[]) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Menus), (fun ctx x -> ctx.Element.Menus <- x), x)
    [<CustomOperation("Menus")>] member inline this.Menus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Menus), (fun ctx x -> ctx.Element.Menus <- x), x)
    [<CustomOperation("UseKeysUpDownAsKeysLeftRight")>] member inline this.UseKeysUpDownAsKeysLeftRight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseKeysUpDownAsKeysLeftRight), (fun ctx x -> ctx.Element.UseKeysUpDownAsKeysLeftRight <- x), x)
    [<CustomOperation("UseKeysUpDownAsKeysLeftRight")>] member inline this.UseKeysUpDownAsKeysLeftRight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseKeysUpDownAsKeysLeftRight), (fun ctx x -> ctx.Element.UseKeysUpDownAsKeysLeftRight <- x), x)
    [<CustomOperation("UseSubMenusSingleFrame")>] member inline this.UseSubMenusSingleFrame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseSubMenusSingleFrame), (fun ctx x -> ctx.Element.UseSubMenusSingleFrame <- x), x)
    [<CustomOperation("UseSubMenusSingleFrame")>] member inline this.UseSubMenusSingleFrame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseSubMenusSingleFrame), (fun ctx x -> ctx.Element.UseSubMenusSingleFrame <- x), x)
    [<CustomOperation("LastFocusedEx")>] member inline this.LastFocusedEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LastFocused), x)
    [<CustomOperation("LastFocusedEx'")>] member inline this.LastFocusedEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LastFocused), x)
    [<CustomOperation("LastFocused")>] member inline this.LastFocused ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.LastFocused), x)
    [<CustomOperation("LastFocused'")>] member inline this.LastFocused' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.LastFocused), x)

    [<CustomOperation("MenuOpening")>] member inline this.MenuOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MenuOpening), (fun ctx -> ctx.Element.remove_MenuOpening), "MenuOpening", fn)
    [<CustomOperation("MenuOpened")>] member inline this.MenuOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MenuOpened), (fun ctx -> ctx.Element.remove_MenuOpened), "MenuOpened", fn)
    [<CustomOperation("MenuClosing")>] member inline this.MenuClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MenuClosing), (fun ctx -> ctx.Element.remove_MenuClosing), "MenuClosing", fn)
    [<CustomOperation("MenuAllClosed")>] member inline this.MenuAllClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_MenuAllClosed), (fun ctx -> ctx.Element.remove_MenuAllClosed), "MenuAllClosed", fn)
                

type PanelViewBuilder<'Element when 'Element :> Terminal.Gui.PanelView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("UsePanelFrame")>] member inline this.UsePanelFrame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UsePanelFrame), (fun ctx x -> ctx.Element.UsePanelFrame <- x), x)
    [<CustomOperation("UsePanelFrame")>] member inline this.UsePanelFrame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UsePanelFrame), (fun ctx x -> ctx.Element.UsePanelFrame <- x), x)

    [<CustomOperation("Child")>]
    member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)

    [<CustomOperation("Child")>]
    member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
                        
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Border) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)
    [<CustomOperation("Border")>] member inline this.Border ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Border), (fun ctx x -> ctx.Element.Border <- x), x)

                

type ProgressBarBuilder<'Element when 'Element :> Terminal.Gui.ProgressBar>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Fraction")>] member inline this.Fraction ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Fraction), (fun ctx x -> ctx.Element.Fraction <- x), x)
    [<CustomOperation("Fraction")>] member inline this.Fraction ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Fraction), (fun ctx x -> ctx.Element.Fraction <- x), x)
    [<CustomOperation("ProgressBarStyle")>] member inline this.ProgressBarStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.ProgressBarStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ProgressBarStyle), (fun ctx x -> ctx.Element.ProgressBarStyle <- x), x)
    [<CustomOperation("ProgressBarStyle")>] member inline this.ProgressBarStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ProgressBarStyle), (fun ctx x -> ctx.Element.ProgressBarStyle <- x), x)
    [<CustomOperation("ProgressBarFormat")>] member inline this.ProgressBarFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.ProgressBarFormat) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ProgressBarFormat), (fun ctx x -> ctx.Element.ProgressBarFormat <- x), x)
    [<CustomOperation("ProgressBarFormat")>] member inline this.ProgressBarFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ProgressBarFormat), (fun ctx x -> ctx.Element.ProgressBarFormat <- x), x)
    [<CustomOperation("SegmentCharacter")>] member inline this.SegmentCharacter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Rune) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SegmentCharacter), (fun ctx x -> ctx.Element.SegmentCharacter <- x), x)
    [<CustomOperation("SegmentCharacter")>] member inline this.SegmentCharacter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SegmentCharacter), (fun ctx x -> ctx.Element.SegmentCharacter <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("BidirectionalMarquee")>] member inline this.BidirectionalMarquee ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BidirectionalMarquee), (fun ctx x -> ctx.Element.BidirectionalMarquee <- x), x)
    [<CustomOperation("BidirectionalMarquee")>] member inline this.BidirectionalMarquee ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BidirectionalMarquee), (fun ctx x -> ctx.Element.BidirectionalMarquee <- x), x)

                

type RadioGroupBuilder<'Element when 'Element :> Terminal.Gui.RadioGroup>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.DisplayModeLayout) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("HorizontalSpace")>] member inline this.HorizontalSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSpace), (fun ctx x -> ctx.Element.HorizontalSpace <- x), x)
    [<CustomOperation("HorizontalSpace")>] member inline this.HorizontalSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSpace), (fun ctx x -> ctx.Element.HorizontalSpace <- x), x)
    [<CustomOperation("RadioLabels")>] member inline this.RadioLabels ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring[]) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RadioLabels), (fun ctx x -> ctx.Element.RadioLabels <- x), x)
    [<CustomOperation("RadioLabels")>] member inline this.RadioLabels ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RadioLabels), (fun ctx x -> ctx.Element.RadioLabels <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)

    [<CustomOperation("SelectedItemChanged")>] member inline this.SelectedItemChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_SelectedItemChanged), (fun ctx -> ctx.Element.remove_SelectedItemChanged), "SelectedItemChanged", fn)
                

type ScrollBarViewBuilder<'Element when 'Element :> Terminal.Gui.ScrollBarView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("IsVertical")>] member inline this.IsVertical ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVertical), (fun ctx x -> ctx.Element.IsVertical <- x), x)
    [<CustomOperation("IsVertical")>] member inline this.IsVertical ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVertical), (fun ctx x -> ctx.Element.IsVertical <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("HostEx")>] member inline this.HostEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Host), x)
    [<CustomOperation("HostEx'")>] member inline this.HostEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Host), x)
    [<CustomOperation("Host")>] member inline this.Host ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Host), x)
    [<CustomOperation("Host'")>] member inline this.Host' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Host), x)

    [<CustomOperation("OtherScrollBarView")>]
    member inline this.OtherScrollBarView ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.OtherScrollBarView <- x), creator)

    [<CustomOperation("OtherScrollBarView")>]
    member inline this.OtherScrollBarView ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.OtherScrollBarView <- x), creator)
                        
    [<CustomOperation("ShowScrollIndicator")>] member inline this.ShowScrollIndicator ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowScrollIndicator), (fun ctx x -> ctx.Element.ShowScrollIndicator <- x), x)
    [<CustomOperation("ShowScrollIndicator")>] member inline this.ShowScrollIndicator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowScrollIndicator), (fun ctx x -> ctx.Element.ShowScrollIndicator <- x), x)
    [<CustomOperation("KeepContentAlwaysInViewport")>] member inline this.KeepContentAlwaysInViewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeepContentAlwaysInViewport), (fun ctx x -> ctx.Element.KeepContentAlwaysInViewport <- x), x)
    [<CustomOperation("KeepContentAlwaysInViewport")>] member inline this.KeepContentAlwaysInViewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeepContentAlwaysInViewport), (fun ctx x -> ctx.Element.KeepContentAlwaysInViewport <- x), x)
    [<CustomOperation("AutoHideScrollBars")>] member inline this.AutoHideScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoHideScrollBars), (fun ctx x -> ctx.Element.AutoHideScrollBars <- x), x)
    [<CustomOperation("AutoHideScrollBars")>] member inline this.AutoHideScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoHideScrollBars), (fun ctx x -> ctx.Element.AutoHideScrollBars <- x), x)

    [<CustomOperation("ChangedPosition")>] member inline this.ChangedPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_ChangedPosition), (fun ctx -> ctx.Element.remove_ChangedPosition), "ChangedPosition", fn)
                

type ScrollViewBuilder<'Element when 'Element :> Terminal.Gui.ScrollView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("ContentSize")>] member inline this.ContentSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentSize), (fun ctx x -> ctx.Element.ContentSize <- x), x)
    [<CustomOperation("ContentSize")>] member inline this.ContentSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentSize), (fun ctx x -> ctx.Element.ContentSize <- x), x)
    [<CustomOperation("ContentOffset")>] member inline this.ContentOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentOffset), (fun ctx x -> ctx.Element.ContentOffset <- x), x)
    [<CustomOperation("ContentOffset")>] member inline this.ContentOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentOffset), (fun ctx x -> ctx.Element.ContentOffset <- x), x)
    [<CustomOperation("AutoHideScrollBars")>] member inline this.AutoHideScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoHideScrollBars), (fun ctx x -> ctx.Element.AutoHideScrollBars <- x), x)
    [<CustomOperation("AutoHideScrollBars")>] member inline this.AutoHideScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoHideScrollBars), (fun ctx x -> ctx.Element.AutoHideScrollBars <- x), x)
    [<CustomOperation("KeepContentAlwaysInViewport")>] member inline this.KeepContentAlwaysInViewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeepContentAlwaysInViewport), (fun ctx x -> ctx.Element.KeepContentAlwaysInViewport <- x), x)
    [<CustomOperation("KeepContentAlwaysInViewport")>] member inline this.KeepContentAlwaysInViewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeepContentAlwaysInViewport), (fun ctx x -> ctx.Element.KeepContentAlwaysInViewport <- x), x)
    [<CustomOperation("ShowHorizontalScrollIndicator")>] member inline this.ShowHorizontalScrollIndicator ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowHorizontalScrollIndicator), (fun ctx x -> ctx.Element.ShowHorizontalScrollIndicator <- x), x)
    [<CustomOperation("ShowHorizontalScrollIndicator")>] member inline this.ShowHorizontalScrollIndicator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowHorizontalScrollIndicator), (fun ctx x -> ctx.Element.ShowHorizontalScrollIndicator <- x), x)
    [<CustomOperation("ShowVerticalScrollIndicator")>] member inline this.ShowVerticalScrollIndicator ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowVerticalScrollIndicator), (fun ctx x -> ctx.Element.ShowVerticalScrollIndicator <- x), x)
    [<CustomOperation("ShowVerticalScrollIndicator")>] member inline this.ShowVerticalScrollIndicator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowVerticalScrollIndicator), (fun ctx x -> ctx.Element.ShowVerticalScrollIndicator <- x), x)

                

type StatusBarBuilder<'Element when 'Element :> Terminal.Gui.StatusBar>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.StatusItem[]) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)

                

type TableViewBuilder<'Element when 'Element :> Terminal.Gui.TableView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Table")>] member inline this.Table ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Data.DataTable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Table), (fun ctx x -> ctx.Element.Table <- x), x)
    [<CustomOperation("Table")>] member inline this.Table ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Table), (fun ctx x -> ctx.Element.Table <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TableView.TableStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("FullRowSelect")>] member inline this.FullRowSelect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FullRowSelect), (fun ctx x -> ctx.Element.FullRowSelect <- x), x)
    [<CustomOperation("FullRowSelect")>] member inline this.FullRowSelect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FullRowSelect), (fun ctx x -> ctx.Element.FullRowSelect <- x), x)
    [<CustomOperation("MultiSelect")>] member inline this.MultiSelect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MultiSelect), (fun ctx x -> ctx.Element.MultiSelect <- x), x)
    [<CustomOperation("MultiSelect")>] member inline this.MultiSelect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MultiSelect), (fun ctx x -> ctx.Element.MultiSelect <- x), x)
    [<CustomOperation("MultiSelectedRegionsEx")>] member inline this.MultiSelectedRegionsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MultiSelectedRegions), x)
    [<CustomOperation("MultiSelectedRegionsEx'")>] member inline this.MultiSelectedRegionsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MultiSelectedRegions), x)
    [<CustomOperation("MultiSelectedRegions")>] member inline this.MultiSelectedRegions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.MultiSelectedRegions), x)
    [<CustomOperation("MultiSelectedRegions'")>] member inline this.MultiSelectedRegions' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.MultiSelectedRegions), x)
    [<CustomOperation("ColumnOffset")>] member inline this.ColumnOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnOffset), (fun ctx x -> ctx.Element.ColumnOffset <- x), x)
    [<CustomOperation("ColumnOffset")>] member inline this.ColumnOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnOffset), (fun ctx x -> ctx.Element.ColumnOffset <- x), x)
    [<CustomOperation("RowOffset")>] member inline this.RowOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowOffset), (fun ctx x -> ctx.Element.RowOffset <- x), x)
    [<CustomOperation("RowOffset")>] member inline this.RowOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowOffset), (fun ctx x -> ctx.Element.RowOffset <- x), x)
    [<CustomOperation("SelectedColumn")>] member inline this.SelectedColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedColumn), (fun ctx x -> ctx.Element.SelectedColumn <- x), x)
    [<CustomOperation("SelectedColumn")>] member inline this.SelectedColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedColumn), (fun ctx x -> ctx.Element.SelectedColumn <- x), x)
    [<CustomOperation("SelectedRow")>] member inline this.SelectedRow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedRow), (fun ctx x -> ctx.Element.SelectedRow <- x), x)
    [<CustomOperation("SelectedRow")>] member inline this.SelectedRow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedRow), (fun ctx x -> ctx.Element.SelectedRow <- x), x)
    [<CustomOperation("MaxCellWidth")>] member inline this.MaxCellWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxCellWidth), (fun ctx x -> ctx.Element.MaxCellWidth <- x), x)
    [<CustomOperation("MaxCellWidth")>] member inline this.MaxCellWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxCellWidth), (fun ctx x -> ctx.Element.MaxCellWidth <- x), x)
    [<CustomOperation("NullSymbol")>] member inline this.NullSymbol ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NullSymbol), (fun ctx x -> ctx.Element.NullSymbol <- x), x)
    [<CustomOperation("NullSymbol")>] member inline this.NullSymbol ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NullSymbol), (fun ctx x -> ctx.Element.NullSymbol <- x), x)
    [<CustomOperation("SeparatorSymbol")>] member inline this.SeparatorSymbol ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Char) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorSymbol), (fun ctx x -> ctx.Element.SeparatorSymbol <- x), x)
    [<CustomOperation("SeparatorSymbol")>] member inline this.SeparatorSymbol ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorSymbol), (fun ctx x -> ctx.Element.SeparatorSymbol <- x), x)
    [<CustomOperation("CellActivationKey")>] member inline this.CellActivationKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Key) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CellActivationKey), (fun ctx x -> ctx.Element.CellActivationKey <- x), x)
    [<CustomOperation("CellActivationKey")>] member inline this.CellActivationKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CellActivationKey), (fun ctx x -> ctx.Element.CellActivationKey <- x), x)

    [<CustomOperation("SelectedCellChanged")>] member inline this.SelectedCellChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_SelectedCellChanged), (fun ctx -> ctx.Element.remove_SelectedCellChanged), "SelectedCellChanged", fn)
    [<CustomOperation("CellActivated")>] member inline this.CellActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_CellActivated), (fun ctx -> ctx.Element.remove_CellActivated), "CellActivated", fn)
                

type TabViewBuilder<'Element when 'Element :> Terminal.Gui.TabView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("TabsEx")>] member inline this.TabsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("TabsEx'")>] member inline this.TabsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("Tabs")>] member inline this.Tabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("Tabs'")>] member inline this.Tabs' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("TabScrollOffset")>] member inline this.TabScrollOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabScrollOffset), (fun ctx x -> ctx.Element.TabScrollOffset <- x), x)
    [<CustomOperation("TabScrollOffset")>] member inline this.TabScrollOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabScrollOffset), (fun ctx x -> ctx.Element.TabScrollOffset <- x), x)
    [<CustomOperation("MaxTabTextWidth")>] member inline this.MaxTabTextWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.UInt32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxTabTextWidth), (fun ctx x -> ctx.Element.MaxTabTextWidth <- x), x)
    [<CustomOperation("MaxTabTextWidth")>] member inline this.MaxTabTextWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxTabTextWidth), (fun ctx x -> ctx.Element.MaxTabTextWidth <- x), x)
    [<CustomOperation("SelectedTab")>] member inline this.SelectedTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TabView.Tab) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTab), (fun ctx x -> ctx.Element.SelectedTab <- x), x)
    [<CustomOperation("SelectedTab")>] member inline this.SelectedTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTab), (fun ctx x -> ctx.Element.SelectedTab <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TabView.TabStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)

    [<CustomOperation("SelectedTabChanged")>] member inline this.SelectedTabChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabChanged), "SelectedTabChanged", fn)
                

type TextValidateFieldBuilder<'Element when 'Element :> Terminal.Gui.TextValidateField>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Provider")>] member inline this.Provider ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.TextValidateProviders.ITextValidateProvider) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Provider), (fun ctx x -> ctx.Element.Provider <- x), x)
    [<CustomOperation("Provider")>] member inline this.Provider ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Provider), (fun ctx x -> ctx.Element.Provider <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

                

type TextViewBuilder<'Element when 'Element :> Terminal.Gui.TextView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("AutocompleteEx")>] member inline this.AutocompleteEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("AutocompleteEx'")>] member inline this.AutocompleteEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("Autocomplete")>] member inline this.Autocomplete ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("Autocomplete'")>] member inline this.Autocomplete' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Autocomplete), x)
    [<CustomOperation("Used")>] member inline this.Used ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Used), (fun ctx x -> ctx.Element.Used <- x), x)
    [<CustomOperation("Used")>] member inline this.Used ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Used), (fun ctx x -> ctx.Element.Used <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: NStack.ustring) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("TopRow")>] member inline this.TopRow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TopRow), (fun ctx x -> ctx.Element.TopRow <- x), x)
    [<CustomOperation("TopRow")>] member inline this.TopRow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TopRow), (fun ctx x -> ctx.Element.TopRow <- x), x)
    [<CustomOperation("LeftColumn")>] member inline this.LeftColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LeftColumn), (fun ctx x -> ctx.Element.LeftColumn <- x), x)
    [<CustomOperation("LeftColumn")>] member inline this.LeftColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LeftColumn), (fun ctx x -> ctx.Element.LeftColumn <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("SelectionStartColumn")>] member inline this.SelectionStartColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStartColumn), (fun ctx x -> ctx.Element.SelectionStartColumn <- x), x)
    [<CustomOperation("SelectionStartColumn")>] member inline this.SelectionStartColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStartColumn), (fun ctx x -> ctx.Element.SelectionStartColumn <- x), x)
    [<CustomOperation("SelectionStartRow")>] member inline this.SelectionStartRow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStartRow), (fun ctx x -> ctx.Element.SelectionStartRow <- x), x)
    [<CustomOperation("SelectionStartRow")>] member inline this.SelectionStartRow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStartRow), (fun ctx x -> ctx.Element.SelectionStartRow <- x), x)
    [<CustomOperation("SelectedTextEx")>] member inline this.SelectedTextEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("SelectedTextEx'")>] member inline this.SelectedTextEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("SelectedText'")>] member inline this.SelectedText' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedText), x)
    [<CustomOperation("Selecting")>] member inline this.Selecting ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Selecting), (fun ctx x -> ctx.Element.Selecting <- x), x)
    [<CustomOperation("Selecting")>] member inline this.Selecting ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Selecting), (fun ctx x -> ctx.Element.Selecting <- x), x)
    [<CustomOperation("WordWrap")>] member inline this.WordWrap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WordWrap), (fun ctx x -> ctx.Element.WordWrap <- x), x)
    [<CustomOperation("WordWrap")>] member inline this.WordWrap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WordWrap), (fun ctx x -> ctx.Element.WordWrap <- x), x)
    [<CustomOperation("BottomOffset")>] member inline this.BottomOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BottomOffset), (fun ctx x -> ctx.Element.BottomOffset <- x), x)
    [<CustomOperation("BottomOffset")>] member inline this.BottomOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BottomOffset), (fun ctx x -> ctx.Element.BottomOffset <- x), x)
    [<CustomOperation("RightOffset")>] member inline this.RightOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RightOffset), (fun ctx x -> ctx.Element.RightOffset <- x), x)
    [<CustomOperation("RightOffset")>] member inline this.RightOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RightOffset), (fun ctx x -> ctx.Element.RightOffset <- x), x)
    [<CustomOperation("AllowsReturn")>] member inline this.AllowsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsReturn), (fun ctx x -> ctx.Element.AllowsReturn <- x), x)
    [<CustomOperation("AllowsReturn")>] member inline this.AllowsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsReturn), (fun ctx x -> ctx.Element.AllowsReturn <- x), x)
    [<CustomOperation("AllowsTab")>] member inline this.AllowsTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsTab), (fun ctx x -> ctx.Element.AllowsTab <- x), x)
    [<CustomOperation("AllowsTab")>] member inline this.AllowsTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsTab), (fun ctx x -> ctx.Element.AllowsTab <- x), x)
    [<CustomOperation("TabWidth")>] member inline this.TabWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabWidth), (fun ctx x -> ctx.Element.TabWidth <- x), x)
    [<CustomOperation("TabWidth")>] member inline this.TabWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabWidth), (fun ctx x -> ctx.Element.TabWidth <- x), x)
    [<CustomOperation("Multiline")>] member inline this.Multiline ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Multiline), (fun ctx x -> ctx.Element.Multiline <- x), x)
    [<CustomOperation("Multiline")>] member inline this.Multiline ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Multiline), (fun ctx x -> ctx.Element.Multiline <- x), x)
    [<CustomOperation("ContextMenuEx")>] member inline this.ContextMenuEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ContextMenuEx'")>] member inline this.ContextMenuEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ContextMenu")>] member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ContextMenu'")>] member inline this.ContextMenu' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ContextMenu), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.CursorVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)
    [<CustomOperation("CanFocus")>] member inline this.CanFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanFocus), (fun ctx x -> ctx.Element.CanFocus <- x), x)
    [<CustomOperation("CanFocus")>] member inline this.CanFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanFocus), (fun ctx x -> ctx.Element.CanFocus <- x), x)

    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_TextChanged), (fun ctx -> ctx.Element.remove_TextChanged), "TextChanged", fn)
    [<CustomOperation("UnwrappedCursorPosition")>] member inline this.UnwrappedCursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_UnwrappedCursorPosition), (fun ctx -> ctx.Element.remove_UnwrappedCursorPosition), "UnwrappedCursorPosition", fn)
                

type TreeViewBuilder<'Element, 'T when 'T : not struct and 'T : equality and 'Element :> Terminal.Gui.TreeView<'T>>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("TreeBuilder")>] member inline this.TreeBuilder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Trees.ITreeBuilder<'T>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TreeBuilder), (fun ctx x -> ctx.Element.TreeBuilder <- x), x)
    [<CustomOperation("TreeBuilder")>] member inline this.TreeBuilder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TreeBuilder), (fun ctx x -> ctx.Element.TreeBuilder <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Trees.TreeStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("MultiSelect")>] member inline this.MultiSelect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MultiSelect), (fun ctx x -> ctx.Element.MultiSelect <- x), x)
    [<CustomOperation("MultiSelect")>] member inline this.MultiSelect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MultiSelect), (fun ctx x -> ctx.Element.MultiSelect <- x), x)
    [<CustomOperation("AllowLetterBasedNavigation")>] member inline this.AllowLetterBasedNavigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowLetterBasedNavigation), (fun ctx x -> ctx.Element.AllowLetterBasedNavigation <- x), x)
    [<CustomOperation("AllowLetterBasedNavigation")>] member inline this.AllowLetterBasedNavigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowLetterBasedNavigation), (fun ctx x -> ctx.Element.AllowLetterBasedNavigation <- x), x)
    [<CustomOperation("SelectedObject")>] member inline this.SelectedObject ([<InlineIfLambda>] builder: BuildElement<'Element>, x: 'T) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedObject), (fun ctx x -> ctx.Element.SelectedObject <- x), x)
    [<CustomOperation("SelectedObject")>] member inline this.SelectedObject ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedObject), (fun ctx x -> ctx.Element.SelectedObject <- x), x)
    [<CustomOperation("ObjectActivationKey")>] member inline this.ObjectActivationKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Key) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ObjectActivationKey), (fun ctx x -> ctx.Element.ObjectActivationKey <- x), x)
    [<CustomOperation("ObjectActivationKey")>] member inline this.ObjectActivationKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ObjectActivationKey), (fun ctx x -> ctx.Element.ObjectActivationKey <- x), x)
    [<CustomOperation("ObjectActivationButton")>] member inline this.ObjectActivationButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<Terminal.Gui.MouseFlags>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ObjectActivationButton), (fun ctx x -> ctx.Element.ObjectActivationButton <- x), x)
    [<CustomOperation("ObjectActivationButton")>] member inline this.ObjectActivationButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ObjectActivationButton), (fun ctx x -> ctx.Element.ObjectActivationButton <- x), x)
    [<CustomOperation("ColorGetter")>] member inline this.ColorGetter ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorGetter), (fun ctx x -> ctx.Element.ColorGetter <- x), (System.Func<'T, Terminal.Gui.ColorScheme>fn))
    [<CustomOperation("ObjectsEx")>] member inline this.ObjectsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Objects), x)
    [<CustomOperation("ObjectsEx'")>] member inline this.ObjectsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Objects), x)
    [<CustomOperation("Objects")>] member inline this.Objects ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Objects), x)
    [<CustomOperation("Objects'")>] member inline this.Objects' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Objects), x)
    [<CustomOperation("ScrollOffsetVertical")>] member inline this.ScrollOffsetVertical ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOffsetVertical), (fun ctx x -> ctx.Element.ScrollOffsetVertical <- x), x)
    [<CustomOperation("ScrollOffsetVertical")>] member inline this.ScrollOffsetVertical ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOffsetVertical), (fun ctx x -> ctx.Element.ScrollOffsetVertical <- x), x)
    [<CustomOperation("ScrollOffsetHorizontal")>] member inline this.ScrollOffsetHorizontal ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOffsetHorizontal), (fun ctx x -> ctx.Element.ScrollOffsetHorizontal <- x), x)
    [<CustomOperation("ScrollOffsetHorizontal")>] member inline this.ScrollOffsetHorizontal ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOffsetHorizontal), (fun ctx x -> ctx.Element.ScrollOffsetHorizontal <- x), x)
    [<CustomOperation("AspectGetter")>] member inline this.AspectGetter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.Trees.AspectGetterDelegate<'T>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AspectGetter), (fun ctx x -> ctx.Element.AspectGetter <- x), x)
    [<CustomOperation("AspectGetter")>] member inline this.AspectGetter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AspectGetter), (fun ctx x -> ctx.Element.AspectGetter <- x), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Terminal.Gui.CursorVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)
    [<CustomOperation("DesiredCursorVisibility")>] member inline this.DesiredCursorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCursorVisibility), (fun ctx x -> ctx.Element.DesiredCursorVisibility <- x), x)

    [<CustomOperation("ObjectActivated")>] member inline this.ObjectActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeActionPropertyBuilder(builder, (fun ctx -> ctx.Element.add_ObjectActivated), (fun ctx -> ctx.Element.remove_ObjectActivated), "ObjectActivated", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type TreeViewBuilder2<'Element when 'Element :> Terminal.Gui.TreeView>() =
    inherit TreeViewBuilder<'Element, Terminal.Gui.Trees.ITreeNode>()


                
            

// =======================================================================================================================

namespace Fun.SunUI.TerminalGUI

[<AutoOpen>]
module TerminalGUIViewBuilderDslCE_TerminalGui =
  
    open Fun.SunUI
    open Fun.SunUI.TerminalGUI.DslInternals

    type View' () = 
        inherit ViewBuilder<Terminal.Gui.View>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.View>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.View()), this.GetRenderMode())

    type Toplevel' () = 
        inherit ToplevelBuilder<Terminal.Gui.Toplevel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.Toplevel>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.Toplevel()), this.GetRenderMode())

    type Window' () = 
        inherit WindowBuilder<Terminal.Gui.Window>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.Window>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.Window()), this.GetRenderMode())

    type Dialog' () = 
        inherit DialogBuilder<Terminal.Gui.Dialog>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.Dialog>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.Dialog()), this.GetRenderMode())

    type FileDialog' () = 
        inherit FileDialogBuilder<Terminal.Gui.FileDialog>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.FileDialog>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.FileDialog()), this.GetRenderMode())

    type SaveDialog' () = 
        inherit SaveDialogBuilder<Terminal.Gui.SaveDialog>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.SaveDialog>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.SaveDialog()), this.GetRenderMode())

    type OpenDialog' () = 
        inherit OpenDialogBuilder<Terminal.Gui.OpenDialog>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.OpenDialog>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.OpenDialog()), this.GetRenderMode())

    type Wizard' () = 
        inherit WizardBuilder<Terminal.Gui.Wizard>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.Wizard>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.Wizard()), this.GetRenderMode())

    type TextField' () = 
        inherit TextFieldBuilder<Terminal.Gui.TextField>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TextField>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TextField()), this.GetRenderMode())

    type DateField' () = 
        inherit DateFieldBuilder<Terminal.Gui.DateField>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.DateField>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.DateField()), this.GetRenderMode())

    type TimeField' () = 
        inherit TimeFieldBuilder<Terminal.Gui.TimeField>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TimeField>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TimeField()), this.GetRenderMode())

    type Button' () = 
        inherit ButtonBuilder<Terminal.Gui.Button>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.Button>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.Button()), this.GetRenderMode())

    type CheckBox' () = 
        inherit CheckBoxBuilder<Terminal.Gui.CheckBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.CheckBox>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.CheckBox()), this.GetRenderMode())

    type ColorPicker' () = 
        inherit ColorPickerBuilder<Terminal.Gui.ColorPicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.ColorPicker>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.ColorPicker()), this.GetRenderMode())

    type ComboBox' () = 
        inherit ComboBoxBuilder<Terminal.Gui.ComboBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.ComboBox>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.ComboBox()), this.GetRenderMode())

    type FrameView' () = 
        inherit FrameViewBuilder<Terminal.Gui.FrameView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.FrameView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.FrameView()), this.GetRenderMode())

    type GraphView' () = 
        inherit GraphViewBuilder<Terminal.Gui.GraphView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.GraphView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.GraphView()), this.GetRenderMode())

    type HexView' () = 
        inherit HexViewBuilder<Terminal.Gui.HexView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.HexView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.HexView()), this.GetRenderMode())

    type Label' () = 
        inherit LabelBuilder<Terminal.Gui.Label>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.Label>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.Label()), this.GetRenderMode())

    type LineView' () = 
        inherit LineViewBuilder<Terminal.Gui.LineView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.LineView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.LineView()), this.GetRenderMode())

    type ListView' () = 
        inherit ListViewBuilder<Terminal.Gui.ListView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.ListView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.ListView()), this.GetRenderMode())

    type MenuBar' () = 
        inherit MenuBarBuilder<Terminal.Gui.MenuBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.MenuBar>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.MenuBar()), this.GetRenderMode())

    type PanelView' () = 
        inherit PanelViewBuilder<Terminal.Gui.PanelView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.PanelView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.PanelView()), this.GetRenderMode())

    type ProgressBar' () = 
        inherit ProgressBarBuilder<Terminal.Gui.ProgressBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.ProgressBar>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.ProgressBar()), this.GetRenderMode())

    type RadioGroup' () = 
        inherit RadioGroupBuilder<Terminal.Gui.RadioGroup>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.RadioGroup>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.RadioGroup()), this.GetRenderMode())

    type ScrollBarView' () = 
        inherit ScrollBarViewBuilder<Terminal.Gui.ScrollBarView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.ScrollBarView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.ScrollBarView()), this.GetRenderMode())

    type ScrollView' () = 
        inherit ScrollViewBuilder<Terminal.Gui.ScrollView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.ScrollView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.ScrollView()), this.GetRenderMode())

    type StatusBar' () = 
        inherit StatusBarBuilder<Terminal.Gui.StatusBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.StatusBar>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.StatusBar()), this.GetRenderMode())

    type TableView' () = 
        inherit TableViewBuilder<Terminal.Gui.TableView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TableView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TableView()), this.GetRenderMode())

    type TabView' () = 
        inherit TabViewBuilder<Terminal.Gui.TabView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TabView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TabView()), this.GetRenderMode())

    type TextValidateField' () = 
        inherit TextValidateFieldBuilder<Terminal.Gui.TextValidateField>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TextValidateField>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TextValidateField()), this.GetRenderMode())

    type TextView' () = 
        inherit TextViewBuilder<Terminal.Gui.TextView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TextView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TextView()), this.GetRenderMode())

    type TreeView'<'T when 'T : not struct and 'T : equality> () = 
        inherit TreeViewBuilder<Terminal.Gui.TreeView<'T>, 'T>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TreeView<'T>>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TreeView<'T>()), this.GetRenderMode())

    type TreeView' () = 
        inherit TreeViewBuilder2<Terminal.Gui.TreeView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Terminal.Gui.TreeView>) = this.MakeElementCreator(builder, (fun _ -> new Terminal.Gui.TreeView()), this.GetRenderMode())

            