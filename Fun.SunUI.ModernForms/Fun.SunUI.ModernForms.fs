namespace rec Fun.SunUI.ModernForms.DslInternals
open Fun.SunUI
open Fun.SunUI.ModernForms
open Fun.SunUI.ModernForms.DslInternals

type MenuBaseBuilder<'Element when 'Element :> Modern.Forms.MenuBase>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("IsActivated")>] member inline this.IsActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsActivated), (fun ctx x -> ctx.Element.IsActivated <- x), x)
    [<CustomOperation("IsActivated")>] member inline this.IsActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsActivated), (fun ctx x -> ctx.Element.IsActivated <- x), x)

    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.MenuItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
                

type MenuDropDownBuilder<'Element when 'Element :> Modern.Forms.MenuDropDown>() =
    inherit MenuBaseBuilder<'Element>()
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
    [<CustomOperation("Visible")>] member inline this.Visible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visible), (fun ctx x -> ctx.Element.Visible <- x), x)
                

type ContextMenuBuilder<'Element when 'Element :> Modern.Forms.ContextMenu>() =
    inherit MenuDropDownBuilder<'Element>()

                

type MenuBuilder<'Element when 'Element :> Modern.Forms.Menu>() =
    inherit MenuBaseBuilder<'Element>()

                

type ToolBarBuilder<'Element when 'Element :> Modern.Forms.ToolBar>() =
    inherit MenuBaseBuilder<'Element>()

                

type ScrollableControlBuilder<'Element when 'Element :> Modern.Forms.ScrollableControl>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("AutoScroll")>] member inline this.AutoScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScroll), (fun ctx x -> ctx.Element.AutoScroll <- x), x)
    [<CustomOperation("AutoScroll")>] member inline this.AutoScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScroll), (fun ctx x -> ctx.Element.AutoScroll <- x), x)
                

type PanelBuilder<'Element when 'Element :> Modern.Forms.Panel>() =
    inherit ScrollableControlBuilder<'Element>()

                

type FlowLayoutPanelBuilder<'Element when 'Element :> Modern.Forms.FlowLayoutPanel>() =
    inherit PanelBuilder<'Element>()
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.FlowDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("WrapContents")>] member inline this.WrapContents ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WrapContents), (fun ctx x -> ctx.Element.WrapContents <- x), x)
    [<CustomOperation("WrapContents")>] member inline this.WrapContents ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WrapContents), (fun ctx x -> ctx.Element.WrapContents <- x), x)
                

type TableLayoutPanelBuilder<'Element when 'Element :> Modern.Forms.TableLayoutPanel>() =
    inherit PanelBuilder<'Element>()
    [<CustomOperation("LayoutSettings")>] member inline this.LayoutSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TableLayoutSettings) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutSettings), (fun ctx x -> ctx.Element.LayoutSettings <- x), x)
    [<CustomOperation("LayoutSettings")>] member inline this.LayoutSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutSettings), (fun ctx x -> ctx.Element.LayoutSettings <- x), x)
    [<CustomOperation("ColumnCount")>] member inline this.ColumnCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnCount), (fun ctx x -> ctx.Element.ColumnCount <- x), x)
    [<CustomOperation("ColumnCount")>] member inline this.ColumnCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnCount), (fun ctx x -> ctx.Element.ColumnCount <- x), x)
    [<CustomOperation("GrowStyle")>] member inline this.GrowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TableLayoutPanelGrowStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GrowStyle), (fun ctx x -> ctx.Element.GrowStyle <- x), x)
    [<CustomOperation("GrowStyle")>] member inline this.GrowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GrowStyle), (fun ctx x -> ctx.Element.GrowStyle <- x), x)
    [<CustomOperation("RowCount")>] member inline this.RowCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowCount), (fun ctx x -> ctx.Element.RowCount <- x), x)
    [<CustomOperation("RowCount")>] member inline this.RowCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowCount), (fun ctx x -> ctx.Element.RowCount <- x), x)
                

type TabPageBuilder<'Element when 'Element :> Modern.Forms.TabPage>() =
    inherit PanelBuilder<'Element>()
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
                

type ScrollBarBuilder<'Element when 'Element :> Modern.Forms.ScrollBar>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
                

type HorizontalScrollBarBuilder<'Element when 'Element :> Modern.Forms.HorizontalScrollBar>() =
    inherit ScrollBarBuilder<'Element>()

                

type VerticalScrollBarBuilder<'Element when 'Element :> Modern.Forms.VerticalScrollBar>() =
    inherit ScrollBarBuilder<'Element>()

                

type ScrollControlBuilder<'Element when 'Element :> Modern.Forms.ScrollControl>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("ScrollBars")>] member inline this.ScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ScrollBars) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollBars), (fun ctx x -> ctx.Element.ScrollBars <- x), x)
    [<CustomOperation("ScrollBars")>] member inline this.ScrollBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollBars), (fun ctx x -> ctx.Element.ScrollBars <- x), x)
                

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
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
                

type ButtonBuilder<'Element when 'Element :> Modern.Forms.Button>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.DialogResult) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ContentAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)
                

type CheckBoxBuilder<'Element when 'Element :> Modern.Forms.CheckBox>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("CheckState")>] member inline this.CheckState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.CheckState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckState), (fun ctx x -> ctx.Element.CheckState <- x), x)
    [<CustomOperation("CheckState")>] member inline this.CheckState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CheckState), (fun ctx x -> ctx.Element.CheckState <- x), x)
    [<CustomOperation("ThreeState")>] member inline this.ThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ThreeState), (fun ctx x -> ctx.Element.ThreeState <- x), x)
    [<CustomOperation("ThreeState")>] member inline this.ThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ThreeState), (fun ctx x -> ctx.Element.ThreeState <- x), x)
                

type ComboBoxBuilder<'Element when 'Element :> Modern.Forms.ComboBox>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("DroppedDown")>] member inline this.DroppedDown ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DroppedDown), (fun ctx x -> ctx.Element.DroppedDown <- x), x)
    [<CustomOperation("DroppedDown")>] member inline this.DroppedDown ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DroppedDown), (fun ctx x -> ctx.Element.DroppedDown <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
                

type FormTitleBarBuilder<'Element when 'Element :> Modern.Forms.FormTitleBar>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("AllowMaximize")>] member inline this.AllowMaximize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMaximize), (fun ctx x -> ctx.Element.AllowMaximize <- x), x)
    [<CustomOperation("AllowMaximize")>] member inline this.AllowMaximize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMaximize), (fun ctx x -> ctx.Element.AllowMaximize <- x), x)
    [<CustomOperation("AllowMinimize")>] member inline this.AllowMinimize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMinimize), (fun ctx x -> ctx.Element.AllowMinimize <- x), x)
    [<CustomOperation("AllowMinimize")>] member inline this.AllowMinimize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMinimize), (fun ctx x -> ctx.Element.AllowMinimize <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKBitmap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("ShowImage")>] member inline this.ShowImage ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowImage), (fun ctx x -> ctx.Element.ShowImage <- x), x)
    [<CustomOperation("ShowImage")>] member inline this.ShowImage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowImage), (fun ctx x -> ctx.Element.ShowImage <- x), x)
                

type LabelBuilder<'Element when 'Element :> Modern.Forms.Label>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("AutoEllipsis")>] member inline this.AutoEllipsis ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoEllipsis), (fun ctx x -> ctx.Element.AutoEllipsis <- x), x)
    [<CustomOperation("AutoEllipsis")>] member inline this.AutoEllipsis ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoEllipsis), (fun ctx x -> ctx.Element.AutoEllipsis <- x), x)
    [<CustomOperation("Multiline")>] member inline this.Multiline ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Multiline), (fun ctx x -> ctx.Element.Multiline <- x), x)
    [<CustomOperation("Multiline")>] member inline this.Multiline ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Multiline), (fun ctx x -> ctx.Element.Multiline <- x), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ContentAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)
    [<CustomOperation("TextAlign")>] member inline this.TextAlign ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlign), (fun ctx x -> ctx.Element.TextAlign <- x), x)
                

type ListBoxBuilder<'Element when 'Element :> Modern.Forms.ListBox>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("FirstVisibleIndex")>] member inline this.FirstVisibleIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstVisibleIndex), (fun ctx x -> ctx.Element.FirstVisibleIndex <- x), x)
    [<CustomOperation("FirstVisibleIndex")>] member inline this.FirstVisibleIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstVisibleIndex), (fun ctx x -> ctx.Element.FirstVisibleIndex <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ScrollbarAlwaysVisible")>] member inline this.ScrollbarAlwaysVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollbarAlwaysVisible), (fun ctx x -> ctx.Element.ScrollbarAlwaysVisible <- x), x)
    [<CustomOperation("ScrollbarAlwaysVisible")>] member inline this.ScrollbarAlwaysVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollbarAlwaysVisible), (fun ctx x -> ctx.Element.ScrollbarAlwaysVisible <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("ShowHover")>] member inline this.ShowHover ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowHover), (fun ctx x -> ctx.Element.ShowHover <- x), x)
    [<CustomOperation("ShowHover")>] member inline this.ShowHover ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowHover), (fun ctx x -> ctx.Element.ShowHover <- x), x)
                

type ListViewBuilder<'Element when 'Element :> Modern.Forms.ListView>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.ListViewItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
                

type NavigationPaneBuilder<'Element when 'Element :> Modern.Forms.NavigationPane>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.NavigationPaneItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
                

type PictureBoxBuilder<'Element when 'Element :> Modern.Forms.PictureBox>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKBitmap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("ImageLocation")>] member inline this.ImageLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ImageLocation), (fun ctx x -> ctx.Element.ImageLocation <- x), x)
    [<CustomOperation("ImageLocation")>] member inline this.ImageLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ImageLocation), (fun ctx x -> ctx.Element.ImageLocation <- x), x)
    [<CustomOperation("IsErrored")>] member inline this.IsErrored ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsErrored), (fun ctx x -> ctx.Element.IsErrored <- x), x)
    [<CustomOperation("IsErrored")>] member inline this.IsErrored ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsErrored), (fun ctx x -> ctx.Element.IsErrored <- x), x)
    [<CustomOperation("SizeMode")>] member inline this.SizeMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.PictureBoxSizeMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeMode), (fun ctx x -> ctx.Element.SizeMode <- x), x)
    [<CustomOperation("SizeMode")>] member inline this.SizeMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SizeMode), (fun ctx x -> ctx.Element.SizeMode <- x), x)
                

type ProgressBarBuilder<'Element when 'Element :> Modern.Forms.ProgressBar>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Step")>] member inline this.Step ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Step), (fun ctx x -> ctx.Element.Step <- x), x)
    [<CustomOperation("Step")>] member inline this.Step ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Step), (fun ctx x -> ctx.Element.Step <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
                

type RadioButtonBuilder<'Element when 'Element :> Modern.Forms.RadioButton>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("AutoCheck")>] member inline this.AutoCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoCheck), (fun ctx x -> ctx.Element.AutoCheck <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), (fun ctx x -> ctx.Element.Checked <- x), x)
                

type RibbonBuilder<'Element when 'Element :> Modern.Forms.Ribbon>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("SelectedTabPage")>] member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.RibbonTabPage) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPage), (fun ctx x -> ctx.Element.SelectedTabPage <- x), x)
    [<CustomOperation("SelectedTabPage")>] member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPage), (fun ctx x -> ctx.Element.SelectedTabPage <- x), x)
    [<CustomOperation("SelectedTabPageIndex")>] member inline this.SelectedTabPageIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPageIndex), (fun ctx x -> ctx.Element.SelectedTabPageIndex <- x), x)
    [<CustomOperation("SelectedTabPageIndex")>] member inline this.SelectedTabPageIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPageIndex), (fun ctx x -> ctx.Element.SelectedTabPageIndex <- x), x)
    [<CustomOperation("ShowTabs")>] member inline this.ShowTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowTabs), (fun ctx x -> ctx.Element.ShowTabs <- x), x)
    [<CustomOperation("ShowTabs")>] member inline this.ShowTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowTabs), (fun ctx x -> ctx.Element.ShowTabs <- x), x)
                

type SplitContainerBuilder<'Element when 'Element :> Modern.Forms.SplitContainer>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Panel1MinimumSize")>] member inline this.Panel1MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Panel1MinimumSize), (fun ctx x -> ctx.Element.Panel1MinimumSize <- x), x)
    [<CustomOperation("Panel1MinimumSize")>] member inline this.Panel1MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Panel1MinimumSize), (fun ctx x -> ctx.Element.Panel1MinimumSize <- x), x)
    [<CustomOperation("Panel2MinimumSize")>] member inline this.Panel2MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Panel2MinimumSize), (fun ctx x -> ctx.Element.Panel2MinimumSize <- x), x)
    [<CustomOperation("Panel2MinimumSize")>] member inline this.Panel2MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Panel2MinimumSize), (fun ctx x -> ctx.Element.Panel2MinimumSize <- x), x)
    [<CustomOperation("SplitterColor")>] member inline this.SplitterColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKColor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterColor), (fun ctx x -> ctx.Element.SplitterColor <- x), x)
    [<CustomOperation("SplitterColor")>] member inline this.SplitterColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterColor), (fun ctx x -> ctx.Element.SplitterColor <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)
                

type SplitterBuilder<'Element when 'Element :> Modern.Forms.Splitter>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)
    [<CustomOperation("SplitterWidth")>] member inline this.SplitterWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SplitterWidth), (fun ctx x -> ctx.Element.SplitterWidth <- x), x)
                

type StatusBarBuilder<'Element when 'Element :> Modern.Forms.StatusBar>() =
    inherit ElementBuilder<ModernForms, 'Element>()

                

type TabControlBuilder<'Element when 'Element :> Modern.Forms.TabControl>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedTabPage")>] member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TabPage) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPage), (fun ctx x -> ctx.Element.SelectedTabPage <- x), x)
    [<CustomOperation("SelectedTabPage")>] member inline this.SelectedTabPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTabPage), (fun ctx x -> ctx.Element.SelectedTabPage <- x), x)
                

type TabStripBuilder<'Element when 'Element :> Modern.Forms.TabStrip>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedTab")>] member inline this.SelectedTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TabStripItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTab), (fun ctx x -> ctx.Element.SelectedTab <- x), x)
    [<CustomOperation("SelectedTab")>] member inline this.SelectedTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTab), (fun ctx x -> ctx.Element.SelectedTab <- x), x)
                

type TreeViewBuilder<'Element when 'Element :> Modern.Forms.TreeView>() =
    inherit ElementBuilder<ModernForms, 'Element>()
    [<CustomOperation("DrawMode")>] member inline this.DrawMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TreeViewDrawMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DrawMode), (fun ctx x -> ctx.Element.DrawMode <- x), x)
    [<CustomOperation("DrawMode")>] member inline this.DrawMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DrawMode), (fun ctx x -> ctx.Element.DrawMode <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.TreeViewItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("ShowDropdownGlyph")>] member inline this.ShowDropdownGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowDropdownGlyph), (fun ctx x -> ctx.Element.ShowDropdownGlyph <- x), x)
    [<CustomOperation("ShowDropdownGlyph")>] member inline this.ShowDropdownGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowDropdownGlyph), (fun ctx x -> ctx.Element.ShowDropdownGlyph <- x), x)
    [<CustomOperation("ShowItemImages")>] member inline this.ShowItemImages ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowItemImages), (fun ctx x -> ctx.Element.ShowItemImages <- x), x)
    [<CustomOperation("ShowItemImages")>] member inline this.ShowItemImages ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowItemImages), (fun ctx x -> ctx.Element.ShowItemImages <- x), x)
    [<CustomOperation("VirtualMode")>] member inline this.VirtualMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualMode), (fun ctx x -> ctx.Element.VirtualMode <- x), x)
    [<CustomOperation("VirtualMode")>] member inline this.VirtualMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualMode), (fun ctx x -> ctx.Element.VirtualMode <- x), x)
                
            
// =======================================================================================================================
namespace Fun.SunUI.ModernForms
[<AutoOpen>]
module DslCE =
  
    open Fun.SunUI
    open Fun.SunUI.ModernForms
    open Fun.SunUI.ModernForms.DslInternals
    type MenuBase' () = inherit MenuBaseBuilder<Modern.Forms.MenuBase>()
    type MenuDropDown' () = inherit MenuDropDownBuilder<Modern.Forms.MenuDropDown>()
    type ContextMenu' () = inherit ContextMenuBuilder<Modern.Forms.ContextMenu>()
    type Menu' () = inherit MenuBuilder<Modern.Forms.Menu>()
    type ToolBar' () = inherit ToolBarBuilder<Modern.Forms.ToolBar>()
    type ScrollableControl' () = inherit ScrollableControlBuilder<Modern.Forms.ScrollableControl>()
    type Panel' () = inherit PanelBuilder<Modern.Forms.Panel>()
    type FlowLayoutPanel' () = inherit FlowLayoutPanelBuilder<Modern.Forms.FlowLayoutPanel>()
    type TableLayoutPanel' () = inherit TableLayoutPanelBuilder<Modern.Forms.TableLayoutPanel>()
    type TabPage' () = inherit TabPageBuilder<Modern.Forms.TabPage>()
    type ScrollBar' () = inherit ScrollBarBuilder<Modern.Forms.ScrollBar>()
    type HorizontalScrollBar' () = inherit HorizontalScrollBarBuilder<Modern.Forms.HorizontalScrollBar>()
    type VerticalScrollBar' () = inherit VerticalScrollBarBuilder<Modern.Forms.VerticalScrollBar>()
    type ScrollControl' () = inherit ScrollControlBuilder<Modern.Forms.ScrollControl>()
    type TextBox' () = inherit TextBoxBuilder<Modern.Forms.TextBox>()
    type Button' () = inherit ButtonBuilder<Modern.Forms.Button>()
    type CheckBox' () = inherit CheckBoxBuilder<Modern.Forms.CheckBox>()
    type ComboBox' () = inherit ComboBoxBuilder<Modern.Forms.ComboBox>()
    type FormTitleBar' () = inherit FormTitleBarBuilder<Modern.Forms.FormTitleBar>()
    type Label' () = inherit LabelBuilder<Modern.Forms.Label>()
    type ListBox' () = inherit ListBoxBuilder<Modern.Forms.ListBox>()
    type ListView' () = inherit ListViewBuilder<Modern.Forms.ListView>()
    type NavigationPane' () = inherit NavigationPaneBuilder<Modern.Forms.NavigationPane>()
    type PictureBox' () = inherit PictureBoxBuilder<Modern.Forms.PictureBox>()
    type ProgressBar' () = inherit ProgressBarBuilder<Modern.Forms.ProgressBar>()
    type RadioButton' () = inherit RadioButtonBuilder<Modern.Forms.RadioButton>()
    type Ribbon' () = inherit RibbonBuilder<Modern.Forms.Ribbon>()
    type SplitContainer' () = inherit SplitContainerBuilder<Modern.Forms.SplitContainer>()
    type Splitter' () = inherit SplitterBuilder<Modern.Forms.Splitter>()
    type StatusBar' () = inherit StatusBarBuilder<Modern.Forms.StatusBar>()
    type TabControl' () = inherit TabControlBuilder<Modern.Forms.TabControl>()
    type TabStrip' () = inherit TabStripBuilder<Modern.Forms.TabStrip>()
    type TreeView' () = inherit TreeViewBuilder<Modern.Forms.TreeView>()
            