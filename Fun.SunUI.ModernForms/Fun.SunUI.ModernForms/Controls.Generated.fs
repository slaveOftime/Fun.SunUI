namespace rec Fun.SunUI.ModernForms.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.ModernForms.DslInternals
open Fun.SunUI
open Fun.SunUI.ModernForms


type ControlBuilder<'Element when 'Element :> Modern.Forms.Control>() =
    inherit ModernFormsControlBuilder<'Element>()

    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Rectangle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Bounds), (fun ctx x -> ctx.Element.Bounds <- x), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Bounds), (fun ctx x -> ctx.Element.Bounds <- x), x)
    [<CustomOperation("Capture")>] member inline this.Capture ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Capture), (fun ctx x -> ctx.Element.Capture <- x), x)
    [<CustomOperation("Capture")>] member inline this.Capture ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Capture), (fun ctx x -> ctx.Element.Capture <- x), x)
    [<CustomOperation("ClientRectangleEx")>] member inline this.ClientRectangleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ClientRectangle), x)
    [<CustomOperation("ClientRectangleEx'")>] member inline this.ClientRectangleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ClientRectangle), x)
    [<CustomOperation("ClientRectangle")>] member inline this.ClientRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ClientRectangle), x)
    [<CustomOperation("ClientRectangle'")>] member inline this.ClientRectangle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ClientRectangle), x)
    [<CustomOperation("ClientSizeEx")>] member inline this.ClientSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("ClientSizeEx'")>] member inline this.ClientSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("ClientSize")>] member inline this.ClientSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("ClientSize'")>] member inline this.ClientSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ClientSize), x)

    [<CustomOperation("ContextMenu")>]
    member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ContextMenu <- x), creator)

    [<CustomOperation("ContextMenu")>]
    member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ContextMenu <- x), creator)
                        

    [<CustomOperation("Controls")>]
    member inline this.Controls ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<ModernForms> seq) =
        this.MakeChildrenBuilder<'Element, Modern.Forms.Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x (ls: Modern.Forms.Control[]) -> x.Element.Controls.AddRange(ls)),
            items
        )

    [<CustomOperation("Controls")>]
    member inline this.Controls ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<ModernForms> alist) =
        this.MakeChildrenBuilder<'Element, Modern.Forms.Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x (ls: Modern.Forms.Control[]) -> x.Element.Controls.AddRange(ls)),
            items
        )

    [<CustomOperation("StaticControls")>]
    member inline this.StaticControls ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<ModernForms> seq) =
        this.MakeStaticChildrenBuilder<'Element, Modern.Forms.Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x (ls: Modern.Forms.Control[]) -> x.Element.Controls.AddRange(ls)),
            items
        )
                        
    [<CustomOperation("CurrentStyleEx")>] member inline this.CurrentStyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentStyle), x)
    [<CustomOperation("CurrentStyleEx'")>] member inline this.CurrentStyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentStyle), x)
    [<CustomOperation("CurrentStyle")>] member inline this.CurrentStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.CurrentStyle), x)
    [<CustomOperation("CurrentStyle'")>] member inline this.CurrentStyle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.CurrentStyle), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Cursor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("DisplayRectangleEx")>] member inline this.DisplayRectangleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DisplayRectangle), x)
    [<CustomOperation("DisplayRectangleEx'")>] member inline this.DisplayRectangleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DisplayRectangle), x)
    [<CustomOperation("DisplayRectangle")>] member inline this.DisplayRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.DisplayRectangle), x)
    [<CustomOperation("DisplayRectangle'")>] member inline this.DisplayRectangle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.DisplayRectangle), x)
    [<CustomOperation("Enabled")>] member inline this.Enabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Enabled), (fun ctx x -> ctx.Element.Enabled <- x), x)
    [<CustomOperation("Enabled")>] member inline this.Enabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Enabled), (fun ctx x -> ctx.Element.Enabled <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Left")>] member inline this.Left ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), x)
    [<CustomOperation("Left")>] member inline this.Left ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), x)
    [<CustomOperation("Location")>] member inline this.Location ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Location), (fun ctx x -> ctx.Element.Location <- x), x)
    [<CustomOperation("Location")>] member inline this.Location ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Location), (fun ctx x -> ctx.Element.Location <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("PaddedClientRectangleEx")>] member inline this.PaddedClientRectangleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("PaddedClientRectangleEx'")>] member inline this.PaddedClientRectangleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("PaddedClientRectangle")>] member inline this.PaddedClientRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("PaddedClientRectangle'")>] member inline this.PaddedClientRectangle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PaddedClientRectangle), x)

    [<CustomOperation("Parent")>]
    member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Parent <- x), creator)

    [<CustomOperation("Parent")>]
    member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Parent <- x), creator)
                        
    [<CustomOperation("ScaledBoundsEx")>] member inline this.ScaledBoundsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ScaledBounds), x)
    [<CustomOperation("ScaledBoundsEx'")>] member inline this.ScaledBoundsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ScaledBounds), x)
    [<CustomOperation("ScaledBounds")>] member inline this.ScaledBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ScaledBounds), x)
    [<CustomOperation("ScaledBounds'")>] member inline this.ScaledBounds' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ScaledBounds), x)
    [<CustomOperation("ScaledSizeEx")>] member inline this.ScaledSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ScaledSize), x)
    [<CustomOperation("ScaledSizeEx'")>] member inline this.ScaledSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ScaledSize), x)
    [<CustomOperation("ScaledSize")>] member inline this.ScaledSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ScaledSize), x)
    [<CustomOperation("ScaledSize'")>] member inline this.ScaledSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ScaledSize), x)
    [<CustomOperation("ScaleFactorEx")>] member inline this.ScaleFactorEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ScaleFactor), x)
    [<CustomOperation("ScaleFactorEx'")>] member inline this.ScaleFactorEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ScaleFactor), x)
    [<CustomOperation("ScaleFactor")>] member inline this.ScaleFactor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ScaleFactor), x)
    [<CustomOperation("ScaleFactor'")>] member inline this.ScaleFactor' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ScaleFactor), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleHoverEx")>] member inline this.StyleHoverEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("StyleHoverEx'")>] member inline this.StyleHoverEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("StyleHover")>] member inline this.StyleHover ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("StyleHover'")>] member inline this.StyleHover' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("TabStop")>] member inline this.TabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStop), (fun ctx x -> ctx.Element.TabStop <- x), x)
    [<CustomOperation("TabStop")>] member inline this.TabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStop), (fun ctx x -> ctx.Element.TabStop <- x), x)
    [<CustomOperation("Tag")>] member inline this.Tag ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Tag), (fun ctx x -> ctx.Element.Tag <- x), x)
    [<CustomOperation("Tag")>] member inline this.Tag ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Tag), (fun ctx x -> ctx.Element.Tag <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Top")>] member inline this.Top ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), x)
    [<CustomOperation("Top")>] member inline this.Top ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Anchor")>] member inline this.Anchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.AnchorStyles) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Anchor), (fun ctx x -> ctx.Element.Anchor <- x), x)
    [<CustomOperation("Anchor")>] member inline this.Anchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Anchor), (fun ctx x -> ctx.Element.Anchor <- x), x)
    [<CustomOperation("AutoSize")>] member inline this.AutoSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSize), (fun ctx x -> ctx.Element.AutoSize <- x), x)
    [<CustomOperation("AutoSize")>] member inline this.AutoSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSize), (fun ctx x -> ctx.Element.AutoSize <- x), x)
    [<CustomOperation("Dock")>] member inline this.Dock ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.DockStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Dock), (fun ctx x -> ctx.Element.Dock <- x), x)
    [<CustomOperation("Dock")>] member inline this.Dock ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Dock), (fun ctx x -> ctx.Element.Dock <- x), x)
    [<CustomOperation("LayoutEngineEx")>] member inline this.LayoutEngineEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngineEx'")>] member inline this.LayoutEngineEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngine")>] member inline this.LayoutEngine ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngine'")>] member inline this.LayoutEngine' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Padding) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("MaximumSize")>] member inline this.MaximumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumSize), (fun ctx x -> ctx.Element.MaximumSize <- x), x)
    [<CustomOperation("MaximumSize")>] member inline this.MaximumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumSize), (fun ctx x -> ctx.Element.MaximumSize <- x), x)
    [<CustomOperation("MinimumSize")>] member inline this.MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumSize), (fun ctx x -> ctx.Element.MinimumSize <- x), x)
    [<CustomOperation("MinimumSize")>] member inline this.MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumSize), (fun ctx x -> ctx.Element.MinimumSize <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Padding) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("PreferredSizeEx")>] member inline this.PreferredSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PreferredSize), x)
    [<CustomOperation("PreferredSizeEx'")>] member inline this.PreferredSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PreferredSize), x)
    [<CustomOperation("PreferredSize")>] member inline this.PreferredSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PreferredSize), x)
    [<CustomOperation("PreferredSize'")>] member inline this.PreferredSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PreferredSize), x)

    [<CustomOperation("AutoSizeChanged")>] member inline this.AutoSizeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSizeChanged), "AutoSizeChanged", fn)
    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
    [<CustomOperation("ContextMenuChanged")>] member inline this.ContextMenuChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuChanged), "ContextMenuChanged", fn)
    [<CustomOperation("ControlAdded")>] member inline this.ControlAdded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ControlAdded), "ControlAdded", fn)
    [<CustomOperation("ControlRemoved")>] member inline this.ControlRemoved ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ControlRemoved), "ControlRemoved", fn)
    [<CustomOperation("CursorChanged")>] member inline this.CursorChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorChanged), "CursorChanged", fn)
    [<CustomOperation("DockChanged")>] member inline this.DockChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DockChanged), "DockChanged", fn)
    [<CustomOperation("DoubleClick")>] member inline this.DoubleClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DoubleClick), "DoubleClick", fn)
    [<CustomOperation("EnabledChanged")>] member inline this.EnabledChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.EnabledChanged), "EnabledChanged", fn)
    [<CustomOperation("GotFocus")>] member inline this.GotFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.GotFocus), "GotFocus", fn)
    [<CustomOperation("Invalidated")>] member inline this.Invalidated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Invalidated), "Invalidated", fn)
    [<CustomOperation("KeyDown")>] member inline this.KeyDown ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyDown), "KeyDown", fn)
    [<CustomOperation("KeyPress")>] member inline this.KeyPress ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyPress), "KeyPress", fn)
    [<CustomOperation("KeyUp")>] member inline this.KeyUp ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyUp), "KeyUp", fn)
    [<CustomOperation("Layout")>] member inline this.Layout ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Layout), "Layout", fn)
    [<CustomOperation("LocationChanged")>] member inline this.LocationChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LocationChanged), "LocationChanged", fn)
    [<CustomOperation("MarginChanged")>] member inline this.MarginChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MarginChanged), "MarginChanged", fn)
    [<CustomOperation("MouseDown")>] member inline this.MouseDown ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseDown), "MouseDown", fn)
    [<CustomOperation("MouseEnter")>] member inline this.MouseEnter ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseEnter), "MouseEnter", fn)
    [<CustomOperation("MouseLeave")>] member inline this.MouseLeave ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseLeave), "MouseLeave", fn)
    [<CustomOperation("MouseMove")>] member inline this.MouseMove ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseMove), "MouseMove", fn)
    [<CustomOperation("MouseUp")>] member inline this.MouseUp ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseUp), "MouseUp", fn)
    [<CustomOperation("MouseWheel")>] member inline this.MouseWheel ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseWheel), "MouseWheel", fn)
    [<CustomOperation("PaddingChanged")>] member inline this.PaddingChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaddingChanged), "PaddingChanged", fn)
    [<CustomOperation("ParentChanged")>] member inline this.ParentChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ParentChanged), "ParentChanged", fn)
    [<CustomOperation("Resize")>] member inline this.Resize ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Resize), "Resize", fn)
    [<CustomOperation("SizeChanged")>] member inline this.SizeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeChanged), "SizeChanged", fn)
    [<CustomOperation("TabIndexChanged")>] member inline this.TabIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndexChanged), "TabIndexChanged", fn)
    [<CustomOperation("TabStopChanged")>] member inline this.TabStopChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStopChanged), "TabStopChanged", fn)
    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
    [<CustomOperation("VisibleChanged")>] member inline this.VisibleChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.VisibleChanged), "VisibleChanged", fn)
                

type MenuBaseBuilder<'Element when 'Element :> Modern.Forms.MenuBase>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("SelectedItemEx")>] member inline this.SelectedItemEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItem), x)
    [<CustomOperation("SelectedItemEx'")>] member inline this.SelectedItemEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItem), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedItem), x)
    [<CustomOperation("SelectedItem'")>] member inline this.SelectedItem' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedItem), x)

                

type MenuDropDownBuilder<'Element when 'Element :> Modern.Forms.MenuDropDown>() =
    inherit MenuBaseBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)

                

type ContextMenuBuilder<'Element when 'Element :> Modern.Forms.ContextMenu>() =
    inherit MenuDropDownBuilder<'Element>()


                

type MenuBuilder<'Element when 'Element :> Modern.Forms.Menu>() =
    inherit MenuBaseBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

                

type ToolBarBuilder<'Element when 'Element :> Modern.Forms.ToolBar>() =
    inherit MenuBaseBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

                

type ScrollableControlBuilder<'Element when 'Element :> Modern.Forms.ScrollableControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AutoScroll")>] member inline this.AutoScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScroll), (fun ctx x -> ctx.Element.AutoScroll <- x), x)
    [<CustomOperation("AutoScroll")>] member inline this.AutoScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScroll), (fun ctx x -> ctx.Element.AutoScroll <- x), x)
    [<CustomOperation("HorizontalScrollPropertiesEx")>] member inline this.HorizontalScrollPropertiesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.HorizontalScrollProperties), x)
    [<CustomOperation("HorizontalScrollPropertiesEx'")>] member inline this.HorizontalScrollPropertiesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.HorizontalScrollProperties), x)
    [<CustomOperation("HorizontalScrollProperties")>] member inline this.HorizontalScrollProperties ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.HorizontalScrollProperties), x)
    [<CustomOperation("HorizontalScrollProperties'")>] member inline this.HorizontalScrollProperties' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.HorizontalScrollProperties), x)
    [<CustomOperation("VerticalScrollPropertiesEx")>] member inline this.VerticalScrollPropertiesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.VerticalScrollProperties), x)
    [<CustomOperation("VerticalScrollPropertiesEx'")>] member inline this.VerticalScrollPropertiesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.VerticalScrollProperties), x)
    [<CustomOperation("VerticalScrollProperties")>] member inline this.VerticalScrollProperties ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.VerticalScrollProperties), x)
    [<CustomOperation("VerticalScrollProperties'")>] member inline this.VerticalScrollProperties' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.VerticalScrollProperties), x)

    [<CustomOperation("Scroll")>] member inline this.Scroll ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scroll), "Scroll", fn)
                

type PanelBuilder<'Element when 'Element :> Modern.Forms.Panel>() =
    inherit ScrollableControlBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

                

type FlowLayoutPanelBuilder<'Element when 'Element :> Modern.Forms.FlowLayoutPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("LayoutEngineEx")>] member inline this.LayoutEngineEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngineEx'")>] member inline this.LayoutEngineEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngine")>] member inline this.LayoutEngine ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngine'")>] member inline this.LayoutEngine' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.FlowDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("WrapContents")>] member inline this.WrapContents ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WrapContents), (fun ctx x -> ctx.Element.WrapContents <- x), x)
    [<CustomOperation("WrapContents")>] member inline this.WrapContents ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WrapContents), (fun ctx x -> ctx.Element.WrapContents <- x), x)

                

type TableLayoutPanelBuilder<'Element when 'Element :> Modern.Forms.TableLayoutPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("LayoutEngineEx")>] member inline this.LayoutEngineEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngineEx'")>] member inline this.LayoutEngineEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngine")>] member inline this.LayoutEngine ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutEngine'")>] member inline this.LayoutEngine' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.LayoutEngine), x)
    [<CustomOperation("LayoutSettings")>] member inline this.LayoutSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TableLayoutSettings) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutSettings), (fun ctx x -> ctx.Element.LayoutSettings <- x), x)
    [<CustomOperation("LayoutSettings")>] member inline this.LayoutSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutSettings), (fun ctx x -> ctx.Element.LayoutSettings <- x), x)

    [<CustomOperation("Controls")>]
    member inline this.Controls ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<ModernForms> seq) =
        this.MakeChildrenBuilder<'Element, Modern.Forms.Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x (ls: Modern.Forms.Control[]) -> x.Element.Controls.AddRange(ls)),
            items
        )

    [<CustomOperation("Controls")>]
    member inline this.Controls ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<ModernForms> alist) =
        this.MakeChildrenBuilder<'Element, Modern.Forms.Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x (ls: Modern.Forms.Control[]) -> x.Element.Controls.AddRange(ls)),
            items
        )

    [<CustomOperation("StaticControls")>]
    member inline this.StaticControls ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<ModernForms> seq) =
        this.MakeStaticChildrenBuilder<'Element, Modern.Forms.Control>(
            builder,
            (fun x -> x.Element.Controls.Clear()),
            (fun x (ls: Modern.Forms.Control[]) -> x.Element.Controls.AddRange(ls)),
            items
        )
                        
    [<CustomOperation("ColumnCount")>] member inline this.ColumnCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnCount), (fun ctx x -> ctx.Element.ColumnCount <- x), x)
    [<CustomOperation("ColumnCount")>] member inline this.ColumnCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnCount), (fun ctx x -> ctx.Element.ColumnCount <- x), x)
    [<CustomOperation("GrowStyle")>] member inline this.GrowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TableLayoutPanelGrowStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GrowStyle), (fun ctx x -> ctx.Element.GrowStyle <- x), x)
    [<CustomOperation("GrowStyle")>] member inline this.GrowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GrowStyle), (fun ctx x -> ctx.Element.GrowStyle <- x), x)
    [<CustomOperation("RowCount")>] member inline this.RowCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowCount), (fun ctx x -> ctx.Element.RowCount <- x), x)
    [<CustomOperation("RowCount")>] member inline this.RowCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowCount), (fun ctx x -> ctx.Element.RowCount <- x), x)
    [<CustomOperation("RowStylesEx")>] member inline this.RowStylesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RowStyles), x)
    [<CustomOperation("RowStylesEx'")>] member inline this.RowStylesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RowStyles), x)
    [<CustomOperation("RowStyles")>] member inline this.RowStyles ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.RowStyles), x)
    [<CustomOperation("RowStyles'")>] member inline this.RowStyles' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.RowStyles), x)
    [<CustomOperation("ColumnStylesEx")>] member inline this.ColumnStylesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ColumnStyles), x)
    [<CustomOperation("ColumnStylesEx'")>] member inline this.ColumnStylesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ColumnStyles), x)
    [<CustomOperation("ColumnStyles")>] member inline this.ColumnStyles ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ColumnStyles), x)
    [<CustomOperation("ColumnStyles'")>] member inline this.ColumnStyles' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ColumnStyles), x)

                

type TabPageBuilder<'Element when 'Element :> Modern.Forms.TabPage>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

                

type ScrollBarBuilder<'Element when 'Element :> Modern.Forms.ScrollBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

    [<CustomOperation("Scroll")>] member inline this.Scroll ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scroll), "Scroll", fn)
    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                

type HorizontalScrollBarBuilder<'Element when 'Element :> Modern.Forms.HorizontalScrollBar>() =
    inherit ScrollBarBuilder<'Element>()


                

type VerticalScrollBarBuilder<'Element when 'Element :> Modern.Forms.VerticalScrollBar>() =
    inherit ScrollBarBuilder<'Element>()


                

type ScrollControlBuilder<'Element when 'Element :> Modern.Forms.ScrollControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("PaddedClientRectangleEx")>] member inline this.PaddedClientRectangleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("PaddedClientRectangleEx'")>] member inline this.PaddedClientRectangleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("PaddedClientRectangle")>] member inline this.PaddedClientRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("PaddedClientRectangle'")>] member inline this.PaddedClientRectangle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PaddedClientRectangle), x)
    [<CustomOperation("ScrollBars")>] member inline this.ScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ScrollBars) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollBars), (fun ctx x -> ctx.Element.ScrollBars <- x), x)
    [<CustomOperation("ScrollBars")>] member inline this.ScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollBars), (fun ctx x -> ctx.Element.ScrollBars <- x), x)
    [<CustomOperation("VerticalScrollBarEx")>] member inline this.VerticalScrollBarEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.VerticalScrollBar), x)
    [<CustomOperation("VerticalScrollBarEx'")>] member inline this.VerticalScrollBarEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.VerticalScrollBar), x)
    [<CustomOperation("VerticalScrollBar")>] member inline this.VerticalScrollBar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.VerticalScrollBar), x)
    [<CustomOperation("VerticalScrollBar'")>] member inline this.VerticalScrollBar' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.VerticalScrollBar), x)

                

type TextBoxBuilder<'Element when 'Element :> Modern.Forms.TextBox>() =
    inherit ScrollControlBuilder<'Element>()

    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MultiLine")>] member inline this.MultiLine ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MultiLine), (fun ctx x -> ctx.Element.MultiLine <- x), x)
    [<CustomOperation("MultiLine")>] member inline this.MultiLine ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MultiLine), (fun ctx x -> ctx.Element.MultiLine <- x), x)
    [<CustomOperation("PasswordCharacter")>] member inline this.PasswordCharacter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Char>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordCharacter), (fun ctx x -> ctx.Element.PasswordCharacter <- x), x)
    [<CustomOperation("PasswordCharacter")>] member inline this.PasswordCharacter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordCharacter), (fun ctx x -> ctx.Element.PasswordCharacter <- x), x)
    [<CustomOperation("Placeholder")>] member inline this.Placeholder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placeholder), (fun ctx x -> ctx.Element.Placeholder <- x), x)
    [<CustomOperation("Placeholder")>] member inline this.Placeholder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placeholder), (fun ctx x -> ctx.Element.Placeholder <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("ReadOnly")>] member inline this.ReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReadOnly), (fun ctx x -> ctx.Element.ReadOnly <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

                

type ButtonBuilder<'Element when 'Element :> Modern.Forms.Button>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.DialogResult) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleHoverEx")>] member inline this.StyleHoverEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("StyleHoverEx'")>] member inline this.StyleHoverEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("StyleHover")>] member inline this.StyleHover ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("StyleHover'")>] member inline this.StyleHover' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.StyleHover), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ContentAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)

                

type CheckBoxBuilder<'Element when 'Element :> Modern.Forms.CheckBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("CheckState")>] member inline this.CheckState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.CheckState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckState), (fun ctx x -> ctx.Element.CheckState <- x), x)
    [<CustomOperation("CheckState")>] member inline this.CheckState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CheckState), (fun ctx x -> ctx.Element.CheckState <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("ThreeState")>] member inline this.ThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ThreeState), (fun ctx x -> ctx.Element.ThreeState <- x), x)
    [<CustomOperation("ThreeState")>] member inline this.ThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ThreeState), (fun ctx x -> ctx.Element.ThreeState <- x), x)

    [<CustomOperation("CheckedChanged")>] member inline this.CheckedChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckedChanged), "CheckedChanged", fn)
    [<CustomOperation("CheckStateChanged")>] member inline this.CheckStateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckStateChanged), "CheckStateChanged", fn)
                

type ComboBoxBuilder<'Element when 'Element :> Modern.Forms.ComboBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("DroppedDown")>] member inline this.DroppedDown ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DroppedDown), (fun ctx x -> ctx.Element.DroppedDown <- x), x)
    [<CustomOperation("DroppedDown")>] member inline this.DroppedDown ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DroppedDown), (fun ctx x -> ctx.Element.DroppedDown <- x), x)
    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

    [<CustomOperation("DropDownClosed")>] member inline this.DropDownClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownClosed), "DropDownClosed", fn)
    [<CustomOperation("DropDownOpened")>] member inline this.DropDownOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownOpened), "DropDownOpened", fn)
    [<CustomOperation("SelectedIndexChanged")>] member inline this.SelectedIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndexChanged), "SelectedIndexChanged", fn)
                

type FormTitleBarBuilder<'Element when 'Element :> Modern.Forms.FormTitleBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AllowMaximize")>] member inline this.AllowMaximize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMaximize), (fun ctx x -> ctx.Element.AllowMaximize <- x), x)
    [<CustomOperation("AllowMaximize")>] member inline this.AllowMaximize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMaximize), (fun ctx x -> ctx.Element.AllowMaximize <- x), x)
    [<CustomOperation("AllowMinimize")>] member inline this.AllowMinimize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMinimize), (fun ctx x -> ctx.Element.AllowMinimize <- x), x)
    [<CustomOperation("AllowMinimize")>] member inline this.AllowMinimize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMinimize), (fun ctx x -> ctx.Element.AllowMinimize <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKBitmap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("ShowImage")>] member inline this.ShowImage ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowImage), (fun ctx x -> ctx.Element.ShowImage <- x), x)
    [<CustomOperation("ShowImage")>] member inline this.ShowImage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowImage), (fun ctx x -> ctx.Element.ShowImage <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

                

type LabelBuilder<'Element when 'Element :> Modern.Forms.Label>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AutoEllipsis")>] member inline this.AutoEllipsis ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoEllipsis), (fun ctx x -> ctx.Element.AutoEllipsis <- x), x)
    [<CustomOperation("AutoEllipsis")>] member inline this.AutoEllipsis ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoEllipsis), (fun ctx x -> ctx.Element.AutoEllipsis <- x), x)
    [<CustomOperation("Multiline")>] member inline this.Multiline ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Multiline), (fun ctx x -> ctx.Element.Multiline <- x), x)
    [<CustomOperation("Multiline")>] member inline this.Multiline ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Multiline), (fun ctx x -> ctx.Element.Multiline <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ContentAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)

                

type ListBoxBuilder<'Element when 'Element :> Modern.Forms.ListBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("FirstVisibleIndex")>] member inline this.FirstVisibleIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstVisibleIndex), (fun ctx x -> ctx.Element.FirstVisibleIndex <- x), x)
    [<CustomOperation("FirstVisibleIndex")>] member inline this.FirstVisibleIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstVisibleIndex), (fun ctx x -> ctx.Element.FirstVisibleIndex <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("ScrollbarAlwaysVisible")>] member inline this.ScrollbarAlwaysVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollbarAlwaysVisible), (fun ctx x -> ctx.Element.ScrollbarAlwaysVisible <- x), x)
    [<CustomOperation("ScrollbarAlwaysVisible")>] member inline this.ScrollbarAlwaysVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollbarAlwaysVisible), (fun ctx x -> ctx.Element.ScrollbarAlwaysVisible <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItemsEx")>] member inline this.SelectedItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItemsEx'")>] member inline this.SelectedItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems'")>] member inline this.SelectedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("ShowHover")>] member inline this.ShowHover ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowHover), (fun ctx x -> ctx.Element.ShowHover <- x), x)
    [<CustomOperation("ShowHover")>] member inline this.ShowHover ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowHover), (fun ctx x -> ctx.Element.ShowHover <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

    [<CustomOperation("SelectedIndexChanged")>] member inline this.SelectedIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndexChanged), "SelectedIndexChanged", fn)
                

type ListViewBuilder<'Element when 'Element :> Modern.Forms.ListView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ListViewItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

    [<CustomOperation("ItemDoubleClicked")>] member inline this.ItemDoubleClicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemDoubleClicked), "ItemDoubleClicked", fn)
                

type NavigationPaneBuilder<'Element when 'Element :> Modern.Forms.NavigationPane>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.NavigationPaneItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)

    [<CustomOperation("SelectedItemChanged")>] member inline this.SelectedItemChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItemChanged), "SelectedItemChanged", fn)
                

type PictureBoxBuilder<'Element when 'Element :> Modern.Forms.PictureBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKBitmap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("ImageLocation")>] member inline this.ImageLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ImageLocation), (fun ctx x -> ctx.Element.ImageLocation <- x), x)
    [<CustomOperation("ImageLocation")>] member inline this.ImageLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ImageLocation), (fun ctx x -> ctx.Element.ImageLocation <- x), x)
    [<CustomOperation("SizeMode")>] member inline this.SizeMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.PictureBoxSizeMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeMode), (fun ctx x -> ctx.Element.SizeMode <- x), x)
    [<CustomOperation("SizeMode")>] member inline this.SizeMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SizeMode), (fun ctx x -> ctx.Element.SizeMode <- x), x)

    [<CustomOperation("SizeModeChanged")>] member inline this.SizeModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeModeChanged), "SizeModeChanged", fn)
                

type ProgressBarBuilder<'Element when 'Element :> Modern.Forms.ProgressBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Step")>] member inline this.Step ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Step), (fun ctx x -> ctx.Element.Step <- x), x)
    [<CustomOperation("Step")>] member inline this.Step ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Step), (fun ctx x -> ctx.Element.Step <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

                

type RadioButtonBuilder<'Element when 'Element :> Modern.Forms.RadioButton>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

    [<CustomOperation("CheckedChanged")>] member inline this.CheckedChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckedChanged), "CheckedChanged", fn)
                

type RibbonBuilder<'Element when 'Element :> Modern.Forms.Ribbon>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("SelectedTabPage")>] member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.RibbonTabPage) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPage), (fun ctx x -> ctx.Element.SelectedTabPage <- x), x)
    [<CustomOperation("SelectedTabPage")>] member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPage), (fun ctx x -> ctx.Element.SelectedTabPage <- x), x)
    [<CustomOperation("SelectedTabPageIndex")>] member inline this.SelectedTabPageIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPageIndex), (fun ctx x -> ctx.Element.SelectedTabPageIndex <- x), x)
    [<CustomOperation("SelectedTabPageIndex")>] member inline this.SelectedTabPageIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPageIndex), (fun ctx x -> ctx.Element.SelectedTabPageIndex <- x), x)
    [<CustomOperation("ShowTabs")>] member inline this.ShowTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowTabs), (fun ctx x -> ctx.Element.ShowTabs <- x), x)
    [<CustomOperation("ShowTabs")>] member inline this.ShowTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowTabs), (fun ctx x -> ctx.Element.ShowTabs <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("TabPagesEx")>] member inline this.TabPagesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("TabPagesEx'")>] member inline this.TabPagesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("TabPages")>] member inline this.TabPages ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("TabPages'")>] member inline this.TabPages' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.TabPages), x)

    [<CustomOperation("SelectedTabPageIndexChanged")>] member inline this.SelectedTabPageIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPageIndexChanged), "SelectedTabPageIndexChanged", fn)
                

type SplitContainerBuilder<'Element when 'Element :> Modern.Forms.SplitContainer>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Panel1Ex")>] member inline this.Panel1Ex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Panel1), x)
    [<CustomOperation("Panel1Ex'")>] member inline this.Panel1Ex' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Panel1), x)
    [<CustomOperation("Panel1")>] member inline this.Panel1 ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Panel1), x)
    [<CustomOperation("Panel1'")>] member inline this.Panel1' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Panel1), x)
    [<CustomOperation("Panel1MinimumSize")>] member inline this.Panel1MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Panel1MinimumSize), (fun ctx x -> ctx.Element.Panel1MinimumSize <- x), x)
    [<CustomOperation("Panel1MinimumSize")>] member inline this.Panel1MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Panel1MinimumSize), (fun ctx x -> ctx.Element.Panel1MinimumSize <- x), x)
    [<CustomOperation("Panel2Ex")>] member inline this.Panel2Ex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Panel2), x)
    [<CustomOperation("Panel2Ex'")>] member inline this.Panel2Ex' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Panel2), x)
    [<CustomOperation("Panel2")>] member inline this.Panel2 ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Panel2), x)
    [<CustomOperation("Panel2'")>] member inline this.Panel2' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Panel2), x)
    [<CustomOperation("Panel2MinimumSize")>] member inline this.Panel2MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Panel2MinimumSize), (fun ctx x -> ctx.Element.Panel2MinimumSize <- x), x)
    [<CustomOperation("Panel2MinimumSize")>] member inline this.Panel2MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Panel2MinimumSize), (fun ctx x -> ctx.Element.Panel2MinimumSize <- x), x)
    [<CustomOperation("SplitterColor")>] member inline this.SplitterColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKColor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterColor), (fun ctx x -> ctx.Element.SplitterColor <- x), x)
    [<CustomOperation("SplitterColor")>] member inline this.SplitterColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterColor), (fun ctx x -> ctx.Element.SplitterColor <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)

                

type SplitterBuilder<'Element when 'Element :> Modern.Forms.Splitter>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)

    [<CustomOperation("Drag")>] member inline this.Drag ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Drag), "Drag", fn)
                

type StatusBarBuilder<'Element when 'Element :> Modern.Forms.StatusBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)

                

type TabControlBuilder<'Element when 'Element :> Modern.Forms.TabControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("TabPagesEx")>] member inline this.TabPagesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("TabPagesEx'")>] member inline this.TabPagesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("TabPages")>] member inline this.TabPages ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("TabPages'")>] member inline this.TabPages' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.TabPages), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)

    [<CustomOperation("SelectedTabPage")>]
    member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.SelectedTabPage <- x), creator)

    [<CustomOperation("SelectedTabPage")>]
    member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.SelectedTabPage <- x), creator)
                        

    [<CustomOperation("SelectedIndexChanged")>] member inline this.SelectedIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndexChanged), "SelectedIndexChanged", fn)
                

type TabStripBuilder<'Element when 'Element :> Modern.Forms.TabStrip>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedTab")>] member inline this.SelectedTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TabStripItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTab), (fun ctx x -> ctx.Element.SelectedTab <- x), x)
    [<CustomOperation("SelectedTab")>] member inline this.SelectedTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTab), (fun ctx x -> ctx.Element.SelectedTab <- x), x)
    [<CustomOperation("TabsEx")>] member inline this.TabsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("TabsEx'")>] member inline this.TabsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("Tabs")>] member inline this.Tabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Tabs), x)
    [<CustomOperation("Tabs'")>] member inline this.Tabs' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Tabs), x)

    [<CustomOperation("SelectedTabChanged")>] member inline this.SelectedTabChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabChanged), "SelectedTabChanged", fn)
                

type TreeViewBuilder<'Element when 'Element :> Modern.Forms.TreeView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("DrawMode")>] member inline this.DrawMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TreeViewDrawMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DrawMode), (fun ctx x -> ctx.Element.DrawMode <- x), x)
    [<CustomOperation("DrawMode")>] member inline this.DrawMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DrawMode), (fun ctx x -> ctx.Element.DrawMode <- x), x)
    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TreeViewItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("ShowDropdownGlyph")>] member inline this.ShowDropdownGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowDropdownGlyph), (fun ctx x -> ctx.Element.ShowDropdownGlyph <- x), x)
    [<CustomOperation("ShowDropdownGlyph")>] member inline this.ShowDropdownGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowDropdownGlyph), (fun ctx x -> ctx.Element.ShowDropdownGlyph <- x), x)
    [<CustomOperation("ShowItemImages")>] member inline this.ShowItemImages ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowItemImages), (fun ctx x -> ctx.Element.ShowItemImages <- x), x)
    [<CustomOperation("ShowItemImages")>] member inline this.ShowItemImages ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowItemImages), (fun ctx x -> ctx.Element.ShowItemImages <- x), x)
    [<CustomOperation("StyleEx")>] member inline this.StyleEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("StyleEx'")>] member inline this.StyleEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Style), x)
    [<CustomOperation("VirtualMode")>] member inline this.VirtualMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualMode), (fun ctx x -> ctx.Element.VirtualMode <- x), x)
    [<CustomOperation("VirtualMode")>] member inline this.VirtualMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualMode), (fun ctx x -> ctx.Element.VirtualMode <- x), x)

    [<CustomOperation("BeforeExpand")>] member inline this.BeforeExpand ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BeforeExpand), "BeforeExpand", fn)
    [<CustomOperation("DrawNode")>] member inline this.DrawNode ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DrawNode), "DrawNode", fn)
    [<CustomOperation("ItemSelected")>] member inline this.ItemSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemSelected), "ItemSelected", fn)
                
            

// =======================================================================================================================

namespace Fun.SunUI.ModernForms

[<AutoOpen>]
module ModernFormsControlBuilderDslCE_ModernForms =
  
    open Fun.SunUI
    open Fun.SunUI.ModernForms.DslInternals

    type Control' () = 
        inherit ControlBuilder<Modern.Forms.Control>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Control>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Control()), this.GetRenderMode())

    type MenuDropDown' () = 
        inherit MenuDropDownBuilder<Modern.Forms.MenuDropDown>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.MenuDropDown>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.MenuDropDown()), this.GetRenderMode())

    type ContextMenu' () = 
        inherit ContextMenuBuilder<Modern.Forms.ContextMenu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ContextMenu>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ContextMenu()), this.GetRenderMode())

    type Menu' () = 
        inherit MenuBuilder<Modern.Forms.Menu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Menu>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Menu()), this.GetRenderMode())

    type ToolBar' () = 
        inherit ToolBarBuilder<Modern.Forms.ToolBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ToolBar>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ToolBar()), this.GetRenderMode())

    type ScrollableControl' () = 
        inherit ScrollableControlBuilder<Modern.Forms.ScrollableControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ScrollableControl>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ScrollableControl()), this.GetRenderMode())

    type Panel' () = 
        inherit PanelBuilder<Modern.Forms.Panel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Panel>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Panel()), this.GetRenderMode())

    type FlowLayoutPanel' () = 
        inherit FlowLayoutPanelBuilder<Modern.Forms.FlowLayoutPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.FlowLayoutPanel>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.FlowLayoutPanel()), this.GetRenderMode())

    type TableLayoutPanel' () = 
        inherit TableLayoutPanelBuilder<Modern.Forms.TableLayoutPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.TableLayoutPanel>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.TableLayoutPanel()), this.GetRenderMode())

    type TabPage' () = 
        inherit TabPageBuilder<Modern.Forms.TabPage>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.TabPage>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.TabPage()), this.GetRenderMode())

    type HorizontalScrollBar' () = 
        inherit HorizontalScrollBarBuilder<Modern.Forms.HorizontalScrollBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.HorizontalScrollBar>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.HorizontalScrollBar()), this.GetRenderMode())

    type VerticalScrollBar' () = 
        inherit VerticalScrollBarBuilder<Modern.Forms.VerticalScrollBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.VerticalScrollBar>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.VerticalScrollBar()), this.GetRenderMode())

    type ScrollControl' () = 
        inherit ScrollControlBuilder<Modern.Forms.ScrollControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ScrollControl>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ScrollControl()), this.GetRenderMode())

    type TextBox' () = 
        inherit TextBoxBuilder<Modern.Forms.TextBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.TextBox>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.TextBox()), this.GetRenderMode())

    type Button' () = 
        inherit ButtonBuilder<Modern.Forms.Button>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Button>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Button()), this.GetRenderMode())

    type CheckBox' () = 
        inherit CheckBoxBuilder<Modern.Forms.CheckBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.CheckBox>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.CheckBox()), this.GetRenderMode())

    type ComboBox' () = 
        inherit ComboBoxBuilder<Modern.Forms.ComboBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ComboBox>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ComboBox()), this.GetRenderMode())

    type FormTitleBar' () = 
        inherit FormTitleBarBuilder<Modern.Forms.FormTitleBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.FormTitleBar>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.FormTitleBar()), this.GetRenderMode())

    type Label' () = 
        inherit LabelBuilder<Modern.Forms.Label>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Label>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Label()), this.GetRenderMode())

    type ListBox' () = 
        inherit ListBoxBuilder<Modern.Forms.ListBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ListBox>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ListBox()), this.GetRenderMode())

    type ListView' () = 
        inherit ListViewBuilder<Modern.Forms.ListView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ListView>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ListView()), this.GetRenderMode())

    type NavigationPane' () = 
        inherit NavigationPaneBuilder<Modern.Forms.NavigationPane>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.NavigationPane>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.NavigationPane()), this.GetRenderMode())

    type PictureBox' () = 
        inherit PictureBoxBuilder<Modern.Forms.PictureBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.PictureBox>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.PictureBox()), this.GetRenderMode())

    type ProgressBar' () = 
        inherit ProgressBarBuilder<Modern.Forms.ProgressBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.ProgressBar>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.ProgressBar()), this.GetRenderMode())

    type RadioButton' () = 
        inherit RadioButtonBuilder<Modern.Forms.RadioButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.RadioButton>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.RadioButton()), this.GetRenderMode())

    type Ribbon' () = 
        inherit RibbonBuilder<Modern.Forms.Ribbon>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Ribbon>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Ribbon()), this.GetRenderMode())

    type SplitContainer' () = 
        inherit SplitContainerBuilder<Modern.Forms.SplitContainer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.SplitContainer>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.SplitContainer()), this.GetRenderMode())

    type Splitter' () = 
        inherit SplitterBuilder<Modern.Forms.Splitter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Splitter>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Splitter()), this.GetRenderMode())

    type StatusBar' () = 
        inherit StatusBarBuilder<Modern.Forms.StatusBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.StatusBar>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.StatusBar()), this.GetRenderMode())

    type TabControl' () = 
        inherit TabControlBuilder<Modern.Forms.TabControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.TabControl>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.TabControl()), this.GetRenderMode())

    type TabStrip' () = 
        inherit TabStripBuilder<Modern.Forms.TabStrip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.TabStrip>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.TabStrip()), this.GetRenderMode())

    type TreeView' () = 
        inherit TreeViewBuilder<Modern.Forms.TreeView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.TreeView>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.TreeView()), this.GetRenderMode())

            