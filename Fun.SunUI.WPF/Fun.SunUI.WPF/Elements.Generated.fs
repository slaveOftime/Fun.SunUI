namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type FrameworkElementBuilder<'Element when 'Element :> System.Windows.FrameworkElement>() =
    inherit WPFElementBuilder<'Element>()

    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("OverridesDefaultStyle")>] member inline this.OverridesDefaultStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OverridesDefaultStyle), (fun ctx x -> ctx.Element.OverridesDefaultStyle <- x), x)
    [<CustomOperation("OverridesDefaultStyle")>] member inline this.OverridesDefaultStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OverridesDefaultStyle), (fun ctx x -> ctx.Element.OverridesDefaultStyle <- x), x)
    [<CustomOperation("UseLayoutRounding")>] member inline this.UseLayoutRounding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseLayoutRounding), (fun ctx x -> ctx.Element.UseLayoutRounding <- x), x)
    [<CustomOperation("UseLayoutRounding")>] member inline this.UseLayoutRounding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseLayoutRounding), (fun ctx x -> ctx.Element.UseLayoutRounding <- x), x)
    [<CustomOperation("Triggers")>] member inline this.Triggers ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Triggers), x)
    [<CustomOperation("Triggers'")>] member inline this.Triggers' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Triggers), x)
    [<CustomOperation("TemplatedParent")>] member inline this.TemplatedParent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplatedParent), x)
    [<CustomOperation("TemplatedParent'")>] member inline this.TemplatedParent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplatedParent), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.ResourceDictionary) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("DataContext")>] member inline this.DataContext ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DataContext), (fun ctx x -> ctx.Element.DataContext <- x), x)
    [<CustomOperation("DataContext")>] member inline this.DataContext ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DataContext), (fun ctx x -> ctx.Element.DataContext <- x), x)
    [<CustomOperation("BindingGroup")>] member inline this.BindingGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Data.BindingGroup) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BindingGroup), (fun ctx x -> ctx.Element.BindingGroup <- x), x)
    [<CustomOperation("BindingGroup")>] member inline this.BindingGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BindingGroup), (fun ctx x -> ctx.Element.BindingGroup <- x), x)
    [<CustomOperation("Language")>] member inline this.Language ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Markup.XmlLanguage) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Language), (fun ctx x -> ctx.Element.Language <- x), x)
    [<CustomOperation("Language")>] member inline this.Language ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Language), (fun ctx x -> ctx.Element.Language <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("Tag")>] member inline this.Tag ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Tag), (fun ctx x -> ctx.Element.Tag <- x), x)
    [<CustomOperation("Tag")>] member inline this.Tag ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Tag), (fun ctx x -> ctx.Element.Tag <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.InputScope) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("LayoutTransform")>] member inline this.LayoutTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Transform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutTransform), (fun ctx x -> ctx.Element.LayoutTransform <- x), x)
    [<CustomOperation("LayoutTransform")>] member inline this.LayoutTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutTransform), (fun ctx x -> ctx.Element.LayoutTransform <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("MinWidth")>] member inline this.MinWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinWidth), (fun ctx x -> ctx.Element.MinWidth <- x), x)
    [<CustomOperation("MinWidth")>] member inline this.MinWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinWidth), (fun ctx x -> ctx.Element.MinWidth <- x), x)
    [<CustomOperation("MaxWidth")>] member inline this.MaxWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxWidth), (fun ctx x -> ctx.Element.MaxWidth <- x), x)
    [<CustomOperation("MaxWidth")>] member inline this.MaxWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxWidth), (fun ctx x -> ctx.Element.MaxWidth <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("MinHeight")>] member inline this.MinHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinHeight), (fun ctx x -> ctx.Element.MinHeight <- x), x)
    [<CustomOperation("MinHeight")>] member inline this.MinHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinHeight), (fun ctx x -> ctx.Element.MinHeight <- x), x)
    [<CustomOperation("MaxHeight")>] member inline this.MaxHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHeight), (fun ctx x -> ctx.Element.MaxHeight <- x), x)
    [<CustomOperation("MaxHeight")>] member inline this.MaxHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHeight), (fun ctx x -> ctx.Element.MaxHeight <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FlowDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("HorizontalAlignment")>] member inline this.HorizontalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalAlignment), (fun ctx x -> ctx.Element.HorizontalAlignment <- x), x)
    [<CustomOperation("HorizontalAlignment")>] member inline this.HorizontalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalAlignment), (fun ctx x -> ctx.Element.HorizontalAlignment <- x), x)
    [<CustomOperation("VerticalAlignment")>] member inline this.VerticalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalAlignment), (fun ctx x -> ctx.Element.VerticalAlignment <- x), x)
    [<CustomOperation("VerticalAlignment")>] member inline this.VerticalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalAlignment), (fun ctx x -> ctx.Element.VerticalAlignment <- x), x)
    [<CustomOperation("FocusVisualStyle")>] member inline this.FocusVisualStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FocusVisualStyle), (fun ctx x -> ctx.Element.FocusVisualStyle <- x), x)
    [<CustomOperation("FocusVisualStyle")>] member inline this.FocusVisualStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FocusVisualStyle), (fun ctx x -> ctx.Element.FocusVisualStyle <- x), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.Cursor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("ForceCursor")>] member inline this.ForceCursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ForceCursor), (fun ctx x -> ctx.Element.ForceCursor <- x), x)
    [<CustomOperation("ForceCursor")>] member inline this.ForceCursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ForceCursor), (fun ctx x -> ctx.Element.ForceCursor <- x), x)
    [<CustomOperation("ToolTip")>] member inline this.ToolTip ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ToolTip), (fun ctx x -> ctx.Element.ToolTip <- x), x)
    [<CustomOperation("ToolTip")>] member inline this.ToolTip ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ToolTip), (fun ctx x -> ctx.Element.ToolTip <- x), x)
    [<CustomOperation("ContextMenu")>] member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ContextMenu) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenu), (fun ctx x -> ctx.Element.ContextMenu <- x), x)
    [<CustomOperation("ContextMenu")>] member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenu), (fun ctx x -> ctx.Element.ContextMenu <- x), x)
    [<CustomOperation("Parent")>] member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Parent), x)
    [<CustomOperation("Parent'")>] member inline this.Parent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Parent), x)

    [<CustomOperation("TargetUpdated")>] member inline this.TargetUpdated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TargetUpdated), "TargetUpdated", fn)
    [<CustomOperation("SourceUpdated")>] member inline this.SourceUpdated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SourceUpdated), "SourceUpdated", fn)
    [<CustomOperation("DataContextChanged")>] member inline this.DataContextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DataContextChanged), "DataContextChanged", fn)
    [<CustomOperation("RequestBringIntoView")>] member inline this.RequestBringIntoView ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RequestBringIntoView), "RequestBringIntoView", fn)
    [<CustomOperation("SizeChanged")>] member inline this.SizeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeChanged), "SizeChanged", fn)
    [<CustomOperation("Initialized")>] member inline this.Initialized ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Initialized), "Initialized", fn)
    [<CustomOperation("Loaded")>] member inline this.Loaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Loaded), "Loaded", fn)
    [<CustomOperation("Unloaded")>] member inline this.Unloaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unloaded), "Unloaded", fn)
    [<CustomOperation("ToolTipOpening")>] member inline this.ToolTipOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ToolTipOpening), "ToolTipOpening", fn)
    [<CustomOperation("ToolTipClosing")>] member inline this.ToolTipClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ToolTipClosing), "ToolTipClosing", fn)
    [<CustomOperation("ContextMenuOpening")>] member inline this.ContextMenuOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuOpening), "ContextMenuOpening", fn)
    [<CustomOperation("ContextMenuClosing")>] member inline this.ContextMenuClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuClosing), "ContextMenuClosing", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type PageBuilder<'Element when 'Element :> System.Windows.Controls.Page>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("WindowTitle")>] member inline this.WindowTitle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowTitle), (fun ctx x -> ctx.Element.WindowTitle <- x), x)
    [<CustomOperation("WindowTitle")>] member inline this.WindowTitle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowTitle), (fun ctx x -> ctx.Element.WindowTitle <- x), x)
    [<CustomOperation("WindowHeight")>] member inline this.WindowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowHeight), (fun ctx x -> ctx.Element.WindowHeight <- x), x)
    [<CustomOperation("WindowHeight")>] member inline this.WindowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowHeight), (fun ctx x -> ctx.Element.WindowHeight <- x), x)
    [<CustomOperation("WindowWidth")>] member inline this.WindowWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowWidth), (fun ctx x -> ctx.Element.WindowWidth <- x), x)
    [<CustomOperation("WindowWidth")>] member inline this.WindowWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowWidth), (fun ctx x -> ctx.Element.WindowWidth <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("ShowsNavigationUI")>] member inline this.ShowsNavigationUI ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsNavigationUI), (fun ctx x -> ctx.Element.ShowsNavigationUI <- x), x)
    [<CustomOperation("ShowsNavigationUI")>] member inline this.ShowsNavigationUI ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsNavigationUI), (fun ctx x -> ctx.Element.ShowsNavigationUI <- x), x)
    [<CustomOperation("KeepAlive")>] member inline this.KeepAlive ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeepAlive), (fun ctx x -> ctx.Element.KeepAlive <- x), x)
    [<CustomOperation("KeepAlive")>] member inline this.KeepAlive ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeepAlive), (fun ctx x -> ctx.Element.KeepAlive <- x), x)
    [<CustomOperation("NavigationService")>] member inline this.NavigationService ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NavigationService), x)
    [<CustomOperation("NavigationService'")>] member inline this.NavigationService' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NavigationService), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Navigation
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type PageFunctionBaseBuilder<'Element when 'Element :> System.Windows.Navigation.PageFunctionBase>() =
    inherit Controls.PageBuilder<'Element>()

    [<CustomOperation("RemoveFromJournal")>] member inline this.RemoveFromJournal ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RemoveFromJournal), (fun ctx x -> ctx.Element.RemoveFromJournal <- x), x)
    [<CustomOperation("RemoveFromJournal")>] member inline this.RemoveFromJournal ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RemoveFromJournal), (fun ctx x -> ctx.Element.RemoveFromJournal <- x), x)

                

type PageFunctionBuilder<'Element, 'T when 'Element :> System.Windows.Navigation.PageFunction<'T>>() =
    inherit Navigation.PageFunctionBaseBuilder<'Element>()


    [<CustomOperation("Return'")>] member inline this.Return' ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Return), "Return", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ControlBuilder<'Element when 'Element :> System.Windows.Controls.Control>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontStretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("IsTabStop")>] member inline this.IsTabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTabStop), (fun ctx x -> ctx.Element.IsTabStop <- x), x)
    [<CustomOperation("IsTabStop")>] member inline this.IsTabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTabStop), (fun ctx x -> ctx.Element.IsTabStop <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)

    [<CustomOperation("PreviewMouseDoubleClick")>] member inline this.PreviewMouseDoubleClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PreviewMouseDoubleClick), "PreviewMouseDoubleClick", fn)
    [<CustomOperation("MouseDoubleClick")>] member inline this.MouseDoubleClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MouseDoubleClick), "MouseDoubleClick", fn)
                

type ItemsControlBuilder<'Element when 'Element :> System.Windows.Controls.ItemsControl>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("DisplayMemberPath")>] member inline this.DisplayMemberPath ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMemberPath), (fun ctx x -> ctx.Element.DisplayMemberPath <- x), x)
    [<CustomOperation("DisplayMemberPath")>] member inline this.DisplayMemberPath ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMemberPath), (fun ctx x -> ctx.Element.DisplayMemberPath <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplateSelector")>] member inline this.ItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplateSelector), (fun ctx x -> ctx.Element.ItemTemplateSelector <- x), x)
    [<CustomOperation("ItemTemplateSelector")>] member inline this.ItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplateSelector), (fun ctx x -> ctx.Element.ItemTemplateSelector <- x), x)
    [<CustomOperation("ItemStringFormat")>] member inline this.ItemStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemStringFormat), (fun ctx x -> ctx.Element.ItemStringFormat <- x), x)
    [<CustomOperation("ItemStringFormat")>] member inline this.ItemStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemStringFormat), (fun ctx x -> ctx.Element.ItemStringFormat <- x), x)
    [<CustomOperation("ItemBindingGroup")>] member inline this.ItemBindingGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Data.BindingGroup) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemBindingGroup), (fun ctx x -> ctx.Element.ItemBindingGroup <- x), x)
    [<CustomOperation("ItemBindingGroup")>] member inline this.ItemBindingGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemBindingGroup), (fun ctx x -> ctx.Element.ItemBindingGroup <- x), x)
    [<CustomOperation("ItemContainerStyle")>] member inline this.ItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyle), (fun ctx x -> ctx.Element.ItemContainerStyle <- x), x)
    [<CustomOperation("ItemContainerStyle")>] member inline this.ItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyle), (fun ctx x -> ctx.Element.ItemContainerStyle <- x), x)
    [<CustomOperation("ItemContainerStyleSelector")>] member inline this.ItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.StyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyleSelector), (fun ctx x -> ctx.Element.ItemContainerStyleSelector <- x), x)
    [<CustomOperation("ItemContainerStyleSelector")>] member inline this.ItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyleSelector), (fun ctx x -> ctx.Element.ItemContainerStyleSelector <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ItemsPanelTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("GroupStyle")>] member inline this.GroupStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GroupStyle), x)
    [<CustomOperation("GroupStyle'")>] member inline this.GroupStyle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GroupStyle), x)
    [<CustomOperation("GroupStyleSelector")>] member inline this.GroupStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.GroupStyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupStyleSelector), (fun ctx x -> ctx.Element.GroupStyleSelector <- x), x)
    [<CustomOperation("GroupStyleSelector")>] member inline this.GroupStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupStyleSelector), (fun ctx x -> ctx.Element.GroupStyleSelector <- x), x)
    [<CustomOperation("AlternationCount")>] member inline this.AlternationCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlternationCount), (fun ctx x -> ctx.Element.AlternationCount <- x), x)
    [<CustomOperation("AlternationCount")>] member inline this.AlternationCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlternationCount), (fun ctx x -> ctx.Element.AlternationCount <- x), x)
    [<CustomOperation("IsTextSearchEnabled")>] member inline this.IsTextSearchEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchEnabled), (fun ctx x -> ctx.Element.IsTextSearchEnabled <- x), x)
    [<CustomOperation("IsTextSearchEnabled")>] member inline this.IsTextSearchEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchEnabled), (fun ctx x -> ctx.Element.IsTextSearchEnabled <- x), x)
    [<CustomOperation("IsTextSearchCaseSensitive")>] member inline this.IsTextSearchCaseSensitive ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchCaseSensitive), (fun ctx x -> ctx.Element.IsTextSearchCaseSensitive <- x), x)
    [<CustomOperation("IsTextSearchCaseSensitive")>] member inline this.IsTextSearchCaseSensitive ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchCaseSensitive), (fun ctx x -> ctx.Element.IsTextSearchCaseSensitive <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type SelectorBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.Selector>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("IsSynchronizedWithCurrentItem")>] member inline this.IsSynchronizedWithCurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Boolean>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSynchronizedWithCurrentItem), (fun ctx x -> ctx.Element.IsSynchronizedWithCurrentItem <- x), x)
    [<CustomOperation("IsSynchronizedWithCurrentItem")>] member inline this.IsSynchronizedWithCurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSynchronizedWithCurrentItem), (fun ctx x -> ctx.Element.IsSynchronizedWithCurrentItem <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedValue")>] member inline this.SelectedValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValue), (fun ctx x -> ctx.Element.SelectedValue <- x), x)
    [<CustomOperation("SelectedValue")>] member inline this.SelectedValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValue), (fun ctx x -> ctx.Element.SelectedValue <- x), x)
    [<CustomOperation("SelectedValuePath")>] member inline this.SelectedValuePath ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValuePath), (fun ctx x -> ctx.Element.SelectedValuePath <- x), x)
    [<CustomOperation("SelectedValuePath")>] member inline this.SelectedValuePath ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValuePath), (fun ctx x -> ctx.Element.SelectedValuePath <- x), x)

    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type MultiSelectorBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.MultiSelector>() =
    inherit Controls.Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems'")>] member inline this.SelectedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItems), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DataGridBuilder<'Element when 'Element :> System.Windows.Controls.DataGrid>() =
    inherit Controls.Primitives.MultiSelectorBuilder<'Element>()

    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Columns), x)
    [<CustomOperation("Columns'")>] member inline this.Columns' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Columns), x)
    [<CustomOperation("CanUserResizeColumns")>] member inline this.CanUserResizeColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserResizeColumns), (fun ctx x -> ctx.Element.CanUserResizeColumns <- x), x)
    [<CustomOperation("CanUserResizeColumns")>] member inline this.CanUserResizeColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserResizeColumns), (fun ctx x -> ctx.Element.CanUserResizeColumns <- x), x)
    [<CustomOperation("ColumnWidth")>] member inline this.ColumnWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridLength) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnWidth), (fun ctx x -> ctx.Element.ColumnWidth <- x), x)
    [<CustomOperation("ColumnWidth")>] member inline this.ColumnWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnWidth), (fun ctx x -> ctx.Element.ColumnWidth <- x), x)
    [<CustomOperation("MinColumnWidth")>] member inline this.MinColumnWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinColumnWidth), (fun ctx x -> ctx.Element.MinColumnWidth <- x), x)
    [<CustomOperation("MinColumnWidth")>] member inline this.MinColumnWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinColumnWidth), (fun ctx x -> ctx.Element.MinColumnWidth <- x), x)
    [<CustomOperation("MaxColumnWidth")>] member inline this.MaxColumnWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxColumnWidth), (fun ctx x -> ctx.Element.MaxColumnWidth <- x), x)
    [<CustomOperation("MaxColumnWidth")>] member inline this.MaxColumnWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxColumnWidth), (fun ctx x -> ctx.Element.MaxColumnWidth <- x), x)
    [<CustomOperation("GridLinesVisibility")>] member inline this.GridLinesVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridGridLinesVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GridLinesVisibility), (fun ctx x -> ctx.Element.GridLinesVisibility <- x), x)
    [<CustomOperation("GridLinesVisibility")>] member inline this.GridLinesVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GridLinesVisibility), (fun ctx x -> ctx.Element.GridLinesVisibility <- x), x)
    [<CustomOperation("HorizontalGridLinesBrush")>] member inline this.HorizontalGridLinesBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalGridLinesBrush), (fun ctx x -> ctx.Element.HorizontalGridLinesBrush <- x), x)
    [<CustomOperation("HorizontalGridLinesBrush")>] member inline this.HorizontalGridLinesBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalGridLinesBrush), (fun ctx x -> ctx.Element.HorizontalGridLinesBrush <- x), x)
    [<CustomOperation("VerticalGridLinesBrush")>] member inline this.VerticalGridLinesBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalGridLinesBrush), (fun ctx x -> ctx.Element.VerticalGridLinesBrush <- x), x)
    [<CustomOperation("VerticalGridLinesBrush")>] member inline this.VerticalGridLinesBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalGridLinesBrush), (fun ctx x -> ctx.Element.VerticalGridLinesBrush <- x), x)
    [<CustomOperation("RowStyle")>] member inline this.RowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowStyle), (fun ctx x -> ctx.Element.RowStyle <- x), x)
    [<CustomOperation("RowStyle")>] member inline this.RowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowStyle), (fun ctx x -> ctx.Element.RowStyle <- x), x)
    [<CustomOperation("RowValidationErrorTemplate")>] member inline this.RowValidationErrorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowValidationErrorTemplate), (fun ctx x -> ctx.Element.RowValidationErrorTemplate <- x), x)
    [<CustomOperation("RowValidationErrorTemplate")>] member inline this.RowValidationErrorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowValidationErrorTemplate), (fun ctx x -> ctx.Element.RowValidationErrorTemplate <- x), x)
    [<CustomOperation("RowValidationRules")>] member inline this.RowValidationRules ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RowValidationRules), x)
    [<CustomOperation("RowValidationRules'")>] member inline this.RowValidationRules' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RowValidationRules), x)
    [<CustomOperation("RowStyleSelector")>] member inline this.RowStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.StyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowStyleSelector), (fun ctx x -> ctx.Element.RowStyleSelector <- x), x)
    [<CustomOperation("RowStyleSelector")>] member inline this.RowStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowStyleSelector), (fun ctx x -> ctx.Element.RowStyleSelector <- x), x)
    [<CustomOperation("RowBackground")>] member inline this.RowBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowBackground), (fun ctx x -> ctx.Element.RowBackground <- x), x)
    [<CustomOperation("RowBackground")>] member inline this.RowBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowBackground), (fun ctx x -> ctx.Element.RowBackground <- x), x)
    [<CustomOperation("AlternatingRowBackground")>] member inline this.AlternatingRowBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlternatingRowBackground), (fun ctx x -> ctx.Element.AlternatingRowBackground <- x), x)
    [<CustomOperation("AlternatingRowBackground")>] member inline this.AlternatingRowBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlternatingRowBackground), (fun ctx x -> ctx.Element.AlternatingRowBackground <- x), x)
    [<CustomOperation("RowHeight")>] member inline this.RowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeight), (fun ctx x -> ctx.Element.RowHeight <- x), x)
    [<CustomOperation("RowHeight")>] member inline this.RowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeight), (fun ctx x -> ctx.Element.RowHeight <- x), x)
    [<CustomOperation("MinRowHeight")>] member inline this.MinRowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinRowHeight), (fun ctx x -> ctx.Element.MinRowHeight <- x), x)
    [<CustomOperation("MinRowHeight")>] member inline this.MinRowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinRowHeight), (fun ctx x -> ctx.Element.MinRowHeight <- x), x)
    [<CustomOperation("RowHeaderWidth")>] member inline this.RowHeaderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderWidth), (fun ctx x -> ctx.Element.RowHeaderWidth <- x), x)
    [<CustomOperation("RowHeaderWidth")>] member inline this.RowHeaderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderWidth), (fun ctx x -> ctx.Element.RowHeaderWidth <- x), x)
    [<CustomOperation("ColumnHeaderHeight")>] member inline this.ColumnHeaderHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderHeight), (fun ctx x -> ctx.Element.ColumnHeaderHeight <- x), x)
    [<CustomOperation("ColumnHeaderHeight")>] member inline this.ColumnHeaderHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderHeight), (fun ctx x -> ctx.Element.ColumnHeaderHeight <- x), x)
    [<CustomOperation("HeadersVisibility")>] member inline this.HeadersVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridHeadersVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeadersVisibility), (fun ctx x -> ctx.Element.HeadersVisibility <- x), x)
    [<CustomOperation("HeadersVisibility")>] member inline this.HeadersVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeadersVisibility), (fun ctx x -> ctx.Element.HeadersVisibility <- x), x)
    [<CustomOperation("CellStyle")>] member inline this.CellStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CellStyle), (fun ctx x -> ctx.Element.CellStyle <- x), x)
    [<CustomOperation("CellStyle")>] member inline this.CellStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CellStyle), (fun ctx x -> ctx.Element.CellStyle <- x), x)
    [<CustomOperation("ColumnHeaderStyle")>] member inline this.ColumnHeaderStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderStyle), (fun ctx x -> ctx.Element.ColumnHeaderStyle <- x), x)
    [<CustomOperation("ColumnHeaderStyle")>] member inline this.ColumnHeaderStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderStyle), (fun ctx x -> ctx.Element.ColumnHeaderStyle <- x), x)
    [<CustomOperation("RowHeaderStyle")>] member inline this.RowHeaderStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderStyle), (fun ctx x -> ctx.Element.RowHeaderStyle <- x), x)
    [<CustomOperation("RowHeaderStyle")>] member inline this.RowHeaderStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderStyle), (fun ctx x -> ctx.Element.RowHeaderStyle <- x), x)
    [<CustomOperation("RowHeaderTemplate")>] member inline this.RowHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderTemplate), (fun ctx x -> ctx.Element.RowHeaderTemplate <- x), x)
    [<CustomOperation("RowHeaderTemplate")>] member inline this.RowHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderTemplate), (fun ctx x -> ctx.Element.RowHeaderTemplate <- x), x)
    [<CustomOperation("RowHeaderTemplateSelector")>] member inline this.RowHeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderTemplateSelector), (fun ctx x -> ctx.Element.RowHeaderTemplateSelector <- x), x)
    [<CustomOperation("RowHeaderTemplateSelector")>] member inline this.RowHeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeaderTemplateSelector), (fun ctx x -> ctx.Element.RowHeaderTemplateSelector <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("CurrentItem")>] member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItem), (fun ctx x -> ctx.Element.CurrentItem <- x), x)
    [<CustomOperation("CurrentItem")>] member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItem), (fun ctx x -> ctx.Element.CurrentItem <- x), x)
    [<CustomOperation("CurrentColumn")>] member inline this.CurrentColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridColumn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentColumn), (fun ctx x -> ctx.Element.CurrentColumn <- x), x)
    [<CustomOperation("CurrentColumn")>] member inline this.CurrentColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentColumn), (fun ctx x -> ctx.Element.CurrentColumn <- x), x)
    [<CustomOperation("CurrentCell")>] member inline this.CurrentCell ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridCellInfo) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentCell), (fun ctx x -> ctx.Element.CurrentCell <- x), x)
    [<CustomOperation("CurrentCell")>] member inline this.CurrentCell ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentCell), (fun ctx x -> ctx.Element.CurrentCell <- x), x)
    [<CustomOperation("CanUserAddRows")>] member inline this.CanUserAddRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserAddRows), (fun ctx x -> ctx.Element.CanUserAddRows <- x), x)
    [<CustomOperation("CanUserAddRows")>] member inline this.CanUserAddRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserAddRows), (fun ctx x -> ctx.Element.CanUserAddRows <- x), x)
    [<CustomOperation("CanUserDeleteRows")>] member inline this.CanUserDeleteRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserDeleteRows), (fun ctx x -> ctx.Element.CanUserDeleteRows <- x), x)
    [<CustomOperation("CanUserDeleteRows")>] member inline this.CanUserDeleteRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserDeleteRows), (fun ctx x -> ctx.Element.CanUserDeleteRows <- x), x)
    [<CustomOperation("RowDetailsVisibilityMode")>] member inline this.RowDetailsVisibilityMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridRowDetailsVisibilityMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsVisibilityMode), (fun ctx x -> ctx.Element.RowDetailsVisibilityMode <- x), x)
    [<CustomOperation("RowDetailsVisibilityMode")>] member inline this.RowDetailsVisibilityMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsVisibilityMode), (fun ctx x -> ctx.Element.RowDetailsVisibilityMode <- x), x)
    [<CustomOperation("AreRowDetailsFrozen")>] member inline this.AreRowDetailsFrozen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AreRowDetailsFrozen), (fun ctx x -> ctx.Element.AreRowDetailsFrozen <- x), x)
    [<CustomOperation("AreRowDetailsFrozen")>] member inline this.AreRowDetailsFrozen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AreRowDetailsFrozen), (fun ctx x -> ctx.Element.AreRowDetailsFrozen <- x), x)
    [<CustomOperation("RowDetailsTemplate")>] member inline this.RowDetailsTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsTemplate), (fun ctx x -> ctx.Element.RowDetailsTemplate <- x), x)
    [<CustomOperation("RowDetailsTemplate")>] member inline this.RowDetailsTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsTemplate), (fun ctx x -> ctx.Element.RowDetailsTemplate <- x), x)
    [<CustomOperation("RowDetailsTemplateSelector")>] member inline this.RowDetailsTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsTemplateSelector), (fun ctx x -> ctx.Element.RowDetailsTemplateSelector <- x), x)
    [<CustomOperation("RowDetailsTemplateSelector")>] member inline this.RowDetailsTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsTemplateSelector), (fun ctx x -> ctx.Element.RowDetailsTemplateSelector <- x), x)
    [<CustomOperation("CanUserResizeRows")>] member inline this.CanUserResizeRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserResizeRows), (fun ctx x -> ctx.Element.CanUserResizeRows <- x), x)
    [<CustomOperation("CanUserResizeRows")>] member inline this.CanUserResizeRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserResizeRows), (fun ctx x -> ctx.Element.CanUserResizeRows <- x), x)
    [<CustomOperation("NewItemMargin")>] member inline this.NewItemMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NewItemMargin), x)
    [<CustomOperation("NewItemMargin'")>] member inline this.NewItemMargin' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NewItemMargin), x)
    [<CustomOperation("SelectedCells")>] member inline this.SelectedCells ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedCells), x)
    [<CustomOperation("SelectedCells'")>] member inline this.SelectedCells' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedCells), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionUnit")>] member inline this.SelectionUnit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridSelectionUnit) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionUnit), (fun ctx x -> ctx.Element.SelectionUnit <- x), x)
    [<CustomOperation("SelectionUnit")>] member inline this.SelectionUnit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionUnit), (fun ctx x -> ctx.Element.SelectionUnit <- x), x)
    [<CustomOperation("CanUserSortColumns")>] member inline this.CanUserSortColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserSortColumns), (fun ctx x -> ctx.Element.CanUserSortColumns <- x), x)
    [<CustomOperation("CanUserSortColumns")>] member inline this.CanUserSortColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserSortColumns), (fun ctx x -> ctx.Element.CanUserSortColumns <- x), x)
    [<CustomOperation("AutoGenerateColumns")>] member inline this.AutoGenerateColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoGenerateColumns), (fun ctx x -> ctx.Element.AutoGenerateColumns <- x), x)
    [<CustomOperation("AutoGenerateColumns")>] member inline this.AutoGenerateColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoGenerateColumns), (fun ctx x -> ctx.Element.AutoGenerateColumns <- x), x)
    [<CustomOperation("FrozenColumnCount")>] member inline this.FrozenColumnCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FrozenColumnCount), (fun ctx x -> ctx.Element.FrozenColumnCount <- x), x)
    [<CustomOperation("FrozenColumnCount")>] member inline this.FrozenColumnCount ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FrozenColumnCount), (fun ctx x -> ctx.Element.FrozenColumnCount <- x), x)
    [<CustomOperation("EnableRowVirtualization")>] member inline this.EnableRowVirtualization ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EnableRowVirtualization), (fun ctx x -> ctx.Element.EnableRowVirtualization <- x), x)
    [<CustomOperation("EnableRowVirtualization")>] member inline this.EnableRowVirtualization ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EnableRowVirtualization), (fun ctx x -> ctx.Element.EnableRowVirtualization <- x), x)
    [<CustomOperation("EnableColumnVirtualization")>] member inline this.EnableColumnVirtualization ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EnableColumnVirtualization), (fun ctx x -> ctx.Element.EnableColumnVirtualization <- x), x)
    [<CustomOperation("EnableColumnVirtualization")>] member inline this.EnableColumnVirtualization ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EnableColumnVirtualization), (fun ctx x -> ctx.Element.EnableColumnVirtualization <- x), x)
    [<CustomOperation("CanUserReorderColumns")>] member inline this.CanUserReorderColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserReorderColumns), (fun ctx x -> ctx.Element.CanUserReorderColumns <- x), x)
    [<CustomOperation("CanUserReorderColumns")>] member inline this.CanUserReorderColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanUserReorderColumns), (fun ctx x -> ctx.Element.CanUserReorderColumns <- x), x)
    [<CustomOperation("DragIndicatorStyle")>] member inline this.DragIndicatorStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragIndicatorStyle), (fun ctx x -> ctx.Element.DragIndicatorStyle <- x), x)
    [<CustomOperation("DragIndicatorStyle")>] member inline this.DragIndicatorStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragIndicatorStyle), (fun ctx x -> ctx.Element.DragIndicatorStyle <- x), x)
    [<CustomOperation("DropLocationIndicatorStyle")>] member inline this.DropLocationIndicatorStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DropLocationIndicatorStyle), (fun ctx x -> ctx.Element.DropLocationIndicatorStyle <- x), x)
    [<CustomOperation("DropLocationIndicatorStyle")>] member inline this.DropLocationIndicatorStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DropLocationIndicatorStyle), (fun ctx x -> ctx.Element.DropLocationIndicatorStyle <- x), x)
    [<CustomOperation("ClipboardCopyMode")>] member inline this.ClipboardCopyMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataGridClipboardCopyMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClipboardCopyMode), (fun ctx x -> ctx.Element.ClipboardCopyMode <- x), x)
    [<CustomOperation("ClipboardCopyMode")>] member inline this.ClipboardCopyMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClipboardCopyMode), (fun ctx x -> ctx.Element.ClipboardCopyMode <- x), x)

    [<CustomOperation("ColumnDisplayIndexChanged")>] member inline this.ColumnDisplayIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDisplayIndexChanged), "ColumnDisplayIndexChanged", fn)
    [<CustomOperation("LoadingRow")>] member inline this.LoadingRow ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LoadingRow), "LoadingRow", fn)
    [<CustomOperation("UnloadingRow")>] member inline this.UnloadingRow ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.UnloadingRow), "UnloadingRow", fn)
    [<CustomOperation("RowEditEnding")>] member inline this.RowEditEnding ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RowEditEnding), "RowEditEnding", fn)
    [<CustomOperation("CellEditEnding")>] member inline this.CellEditEnding ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CellEditEnding), "CellEditEnding", fn)
    [<CustomOperation("CurrentCellChanged")>] member inline this.CurrentCellChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentCellChanged), "CurrentCellChanged", fn)
    [<CustomOperation("BeginningEdit")>] member inline this.BeginningEdit ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BeginningEdit), "BeginningEdit", fn)
    [<CustomOperation("PreparingCellForEdit")>] member inline this.PreparingCellForEdit ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PreparingCellForEdit), "PreparingCellForEdit", fn)
    [<CustomOperation("AddingNewItem")>] member inline this.AddingNewItem ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AddingNewItem), "AddingNewItem", fn)
    [<CustomOperation("InitializingNewItem")>] member inline this.InitializingNewItem ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.InitializingNewItem), "InitializingNewItem", fn)
    [<CustomOperation("LoadingRowDetails")>] member inline this.LoadingRowDetails ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LoadingRowDetails), "LoadingRowDetails", fn)
    [<CustomOperation("UnloadingRowDetails")>] member inline this.UnloadingRowDetails ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.UnloadingRowDetails), "UnloadingRowDetails", fn)
    [<CustomOperation("RowDetailsVisibilityChanged")>] member inline this.RowDetailsVisibilityChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDetailsVisibilityChanged), "RowDetailsVisibilityChanged", fn)
    [<CustomOperation("SelectedCellsChanged")>] member inline this.SelectedCellsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedCellsChanged), "SelectedCellsChanged", fn)
    [<CustomOperation("Sorting")>] member inline this.Sorting ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Sorting), "Sorting", fn)
    [<CustomOperation("AutoGeneratedColumns")>] member inline this.AutoGeneratedColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoGeneratedColumns), "AutoGeneratedColumns", fn)
    [<CustomOperation("AutoGeneratingColumn")>] member inline this.AutoGeneratingColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoGeneratingColumn), "AutoGeneratingColumn", fn)
    [<CustomOperation("ColumnReordering")>] member inline this.ColumnReordering ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnReordering), "ColumnReordering", fn)
    [<CustomOperation("ColumnHeaderDragStarted")>] member inline this.ColumnHeaderDragStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderDragStarted), "ColumnHeaderDragStarted", fn)
    [<CustomOperation("ColumnHeaderDragDelta")>] member inline this.ColumnHeaderDragDelta ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderDragDelta), "ColumnHeaderDragDelta", fn)
    [<CustomOperation("ColumnHeaderDragCompleted")>] member inline this.ColumnHeaderDragCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderDragCompleted), "ColumnHeaderDragCompleted", fn)
    [<CustomOperation("ColumnReordered")>] member inline this.ColumnReordered ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnReordered), "ColumnReordered", fn)
    [<CustomOperation("CopyingRowClipboardContent")>] member inline this.CopyingRowClipboardContent ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CopyingRowClipboardContent), "CopyingRowClipboardContent", fn)
                

type ListBoxBuilder<'Element when 'Element :> System.Windows.Controls.ListBox>() =
    inherit Controls.Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems'")>] member inline this.SelectedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItems), x)

                

type ListViewBuilder<'Element when 'Element :> System.Windows.Controls.ListView>() =
    inherit Controls.ListBoxBuilder<'Element>()

    [<CustomOperation("View")>] member inline this.View ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ViewBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.View), (fun ctx x -> ctx.Element.View <- x), x)
    [<CustomOperation("View")>] member inline this.View ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.View), (fun ctx x -> ctx.Element.View <- x), x)

                

type ComboBoxBuilder<'Element when 'Element :> System.Windows.Controls.ComboBox>() =
    inherit Controls.Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("ShouldPreserveUserEnteredPrefix")>] member inline this.ShouldPreserveUserEnteredPrefix ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldPreserveUserEnteredPrefix), (fun ctx x -> ctx.Element.ShouldPreserveUserEnteredPrefix <- x), x)
    [<CustomOperation("ShouldPreserveUserEnteredPrefix")>] member inline this.ShouldPreserveUserEnteredPrefix ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldPreserveUserEnteredPrefix), (fun ctx x -> ctx.Element.ShouldPreserveUserEnteredPrefix <- x), x)
    [<CustomOperation("IsEditable")>] member inline this.IsEditable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEditable), (fun ctx x -> ctx.Element.IsEditable <- x), x)
    [<CustomOperation("IsEditable")>] member inline this.IsEditable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEditable), (fun ctx x -> ctx.Element.IsEditable <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("SelectionBoxItem")>] member inline this.SelectionBoxItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectionBoxItem), x)
    [<CustomOperation("SelectionBoxItem'")>] member inline this.SelectionBoxItem' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectionBoxItem), x)
    [<CustomOperation("SelectionBoxItemTemplate")>] member inline this.SelectionBoxItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectionBoxItemTemplate), x)
    [<CustomOperation("SelectionBoxItemTemplate'")>] member inline this.SelectionBoxItemTemplate' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectionBoxItemTemplate), x)
    [<CustomOperation("SelectionBoxItemStringFormat")>] member inline this.SelectionBoxItemStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectionBoxItemStringFormat), x)
    [<CustomOperation("SelectionBoxItemStringFormat'")>] member inline this.SelectionBoxItemStringFormat' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectionBoxItemStringFormat), x)
    [<CustomOperation("StaysOpenOnEdit")>] member inline this.StaysOpenOnEdit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpenOnEdit), (fun ctx x -> ctx.Element.StaysOpenOnEdit <- x), x)
    [<CustomOperation("StaysOpenOnEdit")>] member inline this.StaysOpenOnEdit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpenOnEdit), (fun ctx x -> ctx.Element.StaysOpenOnEdit <- x), x)

    [<CustomOperation("DropDownOpened")>] member inline this.DropDownOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownOpened), "DropDownOpened", fn)
    [<CustomOperation("DropDownClosed")>] member inline this.DropDownClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownClosed), "DropDownClosed", fn)
                

type TabControlBuilder<'Element when 'Element :> System.Windows.Controls.TabControl>() =
    inherit Controls.Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("TabStripPlacement")>] member inline this.TabStripPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Dock) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripPlacement), (fun ctx x -> ctx.Element.TabStripPlacement <- x), x)
    [<CustomOperation("TabStripPlacement")>] member inline this.TabStripPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripPlacement), (fun ctx x -> ctx.Element.TabStripPlacement <- x), x)
    [<CustomOperation("SelectedContent")>] member inline this.SelectedContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedContent), x)
    [<CustomOperation("SelectedContent'")>] member inline this.SelectedContent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedContent), x)
    [<CustomOperation("SelectedContentTemplate")>] member inline this.SelectedContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedContentTemplate), x)
    [<CustomOperation("SelectedContentTemplate'")>] member inline this.SelectedContentTemplate' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedContentTemplate), x)
    [<CustomOperation("SelectedContentTemplateSelector")>] member inline this.SelectedContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedContentTemplateSelector), x)
    [<CustomOperation("SelectedContentTemplateSelector'")>] member inline this.SelectedContentTemplateSelector' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedContentTemplateSelector), x)
    [<CustomOperation("SelectedContentStringFormat")>] member inline this.SelectedContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedContentStringFormat), x)
    [<CustomOperation("SelectedContentStringFormat'")>] member inline this.SelectedContentStringFormat' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedContentStringFormat), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentStringFormat")>] member inline this.ContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentStringFormat), (fun ctx x -> ctx.Element.ContentStringFormat <- x), x)
    [<CustomOperation("ContentStringFormat")>] member inline this.ContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentStringFormat), (fun ctx x -> ctx.Element.ContentStringFormat <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type MenuBaseBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.MenuBase>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("ItemContainerTemplateSelector")>] member inline this.ItemContainerTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ItemContainerTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTemplateSelector), (fun ctx x -> ctx.Element.ItemContainerTemplateSelector <- x), x)
    [<CustomOperation("ItemContainerTemplateSelector")>] member inline this.ItemContainerTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTemplateSelector), (fun ctx x -> ctx.Element.ItemContainerTemplateSelector <- x), x)
    [<CustomOperation("UsesItemContainerTemplate")>] member inline this.UsesItemContainerTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UsesItemContainerTemplate), (fun ctx x -> ctx.Element.UsesItemContainerTemplate <- x), x)
    [<CustomOperation("UsesItemContainerTemplate")>] member inline this.UsesItemContainerTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UsesItemContainerTemplate), (fun ctx x -> ctx.Element.UsesItemContainerTemplate <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ContextMenuBuilder<'Element when 'Element :> System.Windows.Controls.ContextMenu>() =
    inherit Controls.Primitives.MenuBaseBuilder<'Element>()

    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementRectangle")>] member inline this.PlacementRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRectangle), (fun ctx x -> ctx.Element.PlacementRectangle <- x), x)
    [<CustomOperation("PlacementRectangle")>] member inline this.PlacementRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRectangle), (fun ctx x -> ctx.Element.PlacementRectangle <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.PlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("HasDropShadow")>] member inline this.HasDropShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasDropShadow), (fun ctx x -> ctx.Element.HasDropShadow <- x), x)
    [<CustomOperation("HasDropShadow")>] member inline this.HasDropShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasDropShadow), (fun ctx x -> ctx.Element.HasDropShadow <- x), x)
    [<CustomOperation("CustomPopupPlacementCallback")>] member inline this.CustomPopupPlacementCallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.CustomPopupPlacementCallback) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CustomPopupPlacementCallback), (fun ctx x -> ctx.Element.CustomPopupPlacementCallback <- x), x)
    [<CustomOperation("CustomPopupPlacementCallback")>] member inline this.CustomPopupPlacementCallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CustomPopupPlacementCallback), (fun ctx x -> ctx.Element.CustomPopupPlacementCallback <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)

    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
                

type MenuBuilder<'Element when 'Element :> System.Windows.Controls.Menu>() =
    inherit Controls.Primitives.MenuBaseBuilder<'Element>()

    [<CustomOperation("IsMainMenu")>] member inline this.IsMainMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsMainMenu), (fun ctx x -> ctx.Element.IsMainMenu <- x), x)
    [<CustomOperation("IsMainMenu")>] member inline this.IsMainMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsMainMenu), (fun ctx x -> ctx.Element.IsMainMenu <- x), x)

                

type HeaderedItemsControlBuilder<'Element when 'Element :> System.Windows.Controls.HeaderedItemsControl>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("HeaderStringFormat")>] member inline this.HeaderStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderStringFormat), (fun ctx x -> ctx.Element.HeaderStringFormat <- x), x)
    [<CustomOperation("HeaderStringFormat")>] member inline this.HeaderStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderStringFormat), (fun ctx x -> ctx.Element.HeaderStringFormat <- x), x)

                

type MenuItemBuilder<'Element when 'Element :> System.Windows.Controls.MenuItem>() =
    inherit Controls.HeaderedItemsControlBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandTarget")>] member inline this.CommandTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.IInputElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandTarget), (fun ctx x -> ctx.Element.CommandTarget <- x), x)
    [<CustomOperation("CommandTarget")>] member inline this.CommandTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandTarget), (fun ctx x -> ctx.Element.CommandTarget <- x), x)
    [<CustomOperation("IsSubmenuOpen")>] member inline this.IsSubmenuOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSubmenuOpen), (fun ctx x -> ctx.Element.IsSubmenuOpen <- x), x)
    [<CustomOperation("IsSubmenuOpen")>] member inline this.IsSubmenuOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSubmenuOpen), (fun ctx x -> ctx.Element.IsSubmenuOpen <- x), x)
    [<CustomOperation("IsCheckable")>] member inline this.IsCheckable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCheckable), (fun ctx x -> ctx.Element.IsCheckable <- x), x)
    [<CustomOperation("IsCheckable")>] member inline this.IsCheckable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCheckable), (fun ctx x -> ctx.Element.IsCheckable <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("StaysOpenOnClick")>] member inline this.StaysOpenOnClick ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpenOnClick), (fun ctx x -> ctx.Element.StaysOpenOnClick <- x), x)
    [<CustomOperation("StaysOpenOnClick")>] member inline this.StaysOpenOnClick ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpenOnClick), (fun ctx x -> ctx.Element.StaysOpenOnClick <- x), x)
    [<CustomOperation("InputGestureText")>] member inline this.InputGestureText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputGestureText), (fun ctx x -> ctx.Element.InputGestureText <- x), x)
    [<CustomOperation("InputGestureText")>] member inline this.InputGestureText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputGestureText), (fun ctx x -> ctx.Element.InputGestureText <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("ItemContainerTemplateSelector")>] member inline this.ItemContainerTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ItemContainerTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTemplateSelector), (fun ctx x -> ctx.Element.ItemContainerTemplateSelector <- x), x)
    [<CustomOperation("ItemContainerTemplateSelector")>] member inline this.ItemContainerTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTemplateSelector), (fun ctx x -> ctx.Element.ItemContainerTemplateSelector <- x), x)
    [<CustomOperation("UsesItemContainerTemplate")>] member inline this.UsesItemContainerTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UsesItemContainerTemplate), (fun ctx x -> ctx.Element.UsesItemContainerTemplate <- x), x)
    [<CustomOperation("UsesItemContainerTemplate")>] member inline this.UsesItemContainerTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UsesItemContainerTemplate), (fun ctx x -> ctx.Element.UsesItemContainerTemplate <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), "Checked", fn)
    [<CustomOperation("Unchecked")>] member inline this.Unchecked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unchecked), "Unchecked", fn)
    [<CustomOperation("SubmenuOpened")>] member inline this.SubmenuOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SubmenuOpened), "SubmenuOpened", fn)
    [<CustomOperation("SubmenuClosed")>] member inline this.SubmenuClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SubmenuClosed), "SubmenuClosed", fn)
                

type ToolBarBuilder<'Element when 'Element :> System.Windows.Controls.ToolBar>() =
    inherit Controls.HeaderedItemsControlBuilder<'Element>()

    [<CustomOperation("Band")>] member inline this.Band ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Band), (fun ctx x -> ctx.Element.Band <- x), x)
    [<CustomOperation("Band")>] member inline this.Band ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Band), (fun ctx x -> ctx.Element.Band <- x), x)
    [<CustomOperation("BandIndex")>] member inline this.BandIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BandIndex), (fun ctx x -> ctx.Element.BandIndex <- x), x)
    [<CustomOperation("BandIndex")>] member inline this.BandIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BandIndex), (fun ctx x -> ctx.Element.BandIndex <- x), x)
    [<CustomOperation("IsOverflowOpen")>] member inline this.IsOverflowOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOverflowOpen), (fun ctx x -> ctx.Element.IsOverflowOpen <- x), x)
    [<CustomOperation("IsOverflowOpen")>] member inline this.IsOverflowOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOverflowOpen), (fun ctx x -> ctx.Element.IsOverflowOpen <- x), x)

                

type TreeViewItemBuilder<'Element when 'Element :> System.Windows.Controls.TreeViewItem>() =
    inherit Controls.HeaderedItemsControlBuilder<'Element>()

    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

    [<CustomOperation("Expanded")>] member inline this.Expanded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Expanded), "Expanded", fn)
    [<CustomOperation("Collapsed")>] member inline this.Collapsed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Collapsed), "Collapsed", fn)
    [<CustomOperation("Selected")>] member inline this.Selected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Selected), "Selected", fn)
    [<CustomOperation("Unselected")>] member inline this.Unselected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unselected), "Unselected", fn)
                

type TreeViewBuilder<'Element when 'Element :> System.Windows.Controls.TreeView>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItem), x)
    [<CustomOperation("SelectedItem'")>] member inline this.SelectedItem' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItem), x)
    [<CustomOperation("SelectedValue")>] member inline this.SelectedValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedValue), x)
    [<CustomOperation("SelectedValue'")>] member inline this.SelectedValue' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedValue), x)
    [<CustomOperation("SelectedValuePath")>] member inline this.SelectedValuePath ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValuePath), (fun ctx x -> ctx.Element.SelectedValuePath <- x), x)
    [<CustomOperation("SelectedValuePath")>] member inline this.SelectedValuePath ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValuePath), (fun ctx x -> ctx.Element.SelectedValuePath <- x), x)

    [<CustomOperation("SelectedItemChanged")>] member inline this.SelectedItemChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItemChanged), "SelectedItemChanged", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DataGridCellsPresenterBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DataGridCellsPresenter>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("Item")>] member inline this.Item ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Item), x)
    [<CustomOperation("Item'")>] member inline this.Item' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Item), x)

                

type DataGridColumnHeadersPresenterBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>() =
    inherit Controls.ItemsControlBuilder<'Element>()


                

type StatusBarBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.StatusBar>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("ItemContainerTemplateSelector")>] member inline this.ItemContainerTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ItemContainerTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTemplateSelector), (fun ctx x -> ctx.Element.ItemContainerTemplateSelector <- x), x)
    [<CustomOperation("ItemContainerTemplateSelector")>] member inline this.ItemContainerTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTemplateSelector), (fun ctx x -> ctx.Element.ItemContainerTemplateSelector <- x), x)
    [<CustomOperation("UsesItemContainerTemplate")>] member inline this.UsesItemContainerTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UsesItemContainerTemplate), (fun ctx x -> ctx.Element.UsesItemContainerTemplate <- x), x)
    [<CustomOperation("UsesItemContainerTemplate")>] member inline this.UsesItemContainerTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UsesItemContainerTemplate), (fun ctx x -> ctx.Element.UsesItemContainerTemplate <- x), x)

                

type TextBoxBaseBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.TextBoxBase>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnlyCaretVisible")>] member inline this.IsReadOnlyCaretVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnlyCaretVisible), (fun ctx x -> ctx.Element.IsReadOnlyCaretVisible <- x), x)
    [<CustomOperation("IsReadOnlyCaretVisible")>] member inline this.IsReadOnlyCaretVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnlyCaretVisible), (fun ctx x -> ctx.Element.IsReadOnlyCaretVisible <- x), x)
    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("AcceptsTab")>] member inline this.AcceptsTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsTab), (fun ctx x -> ctx.Element.AcceptsTab <- x), x)
    [<CustomOperation("AcceptsTab")>] member inline this.AcceptsTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsTab), (fun ctx x -> ctx.Element.AcceptsTab <- x), x)
    [<CustomOperation("SpellCheck")>] member inline this.SpellCheck ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SpellCheck), x)
    [<CustomOperation("SpellCheck'")>] member inline this.SpellCheck' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SpellCheck), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("IsUndoEnabled")>] member inline this.IsUndoEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsUndoEnabled), (fun ctx x -> ctx.Element.IsUndoEnabled <- x), x)
    [<CustomOperation("IsUndoEnabled")>] member inline this.IsUndoEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsUndoEnabled), (fun ctx x -> ctx.Element.IsUndoEnabled <- x), x)
    [<CustomOperation("UndoLimit")>] member inline this.UndoLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UndoLimit), (fun ctx x -> ctx.Element.UndoLimit <- x), x)
    [<CustomOperation("UndoLimit")>] member inline this.UndoLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UndoLimit), (fun ctx x -> ctx.Element.UndoLimit <- x), x)
    [<CustomOperation("AutoWordSelection")>] member inline this.AutoWordSelection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoWordSelection), (fun ctx x -> ctx.Element.AutoWordSelection <- x), x)
    [<CustomOperation("AutoWordSelection")>] member inline this.AutoWordSelection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoWordSelection), (fun ctx x -> ctx.Element.AutoWordSelection <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionTextBrush")>] member inline this.SelectionTextBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionTextBrush), (fun ctx x -> ctx.Element.SelectionTextBrush <- x), x)
    [<CustomOperation("SelectionTextBrush")>] member inline this.SelectionTextBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionTextBrush), (fun ctx x -> ctx.Element.SelectionTextBrush <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)

    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type TextBoxBuilder<'Element when 'Element :> System.Windows.Controls.TextBox>() =
    inherit Controls.Primitives.TextBoxBaseBuilder<'Element>()

    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("MinLines")>] member inline this.MinLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinLines), (fun ctx x -> ctx.Element.MinLines <- x), x)
    [<CustomOperation("MinLines")>] member inline this.MinLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinLines), (fun ctx x -> ctx.Element.MinLines <- x), x)
    [<CustomOperation("MaxLines")>] member inline this.MaxLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLines), (fun ctx x -> ctx.Element.MaxLines <- x), x)
    [<CustomOperation("MaxLines")>] member inline this.MaxLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLines), (fun ctx x -> ctx.Element.MaxLines <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("CharacterCasing")>] member inline this.CharacterCasing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.CharacterCasing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterCasing), (fun ctx x -> ctx.Element.CharacterCasing <- x), x)
    [<CustomOperation("CharacterCasing")>] member inline this.CharacterCasing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterCasing), (fun ctx x -> ctx.Element.CharacterCasing <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedText), (fun ctx x -> ctx.Element.SelectedText <- x), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedText), (fun ctx x -> ctx.Element.SelectedText <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("CaretIndex")>] member inline this.CaretIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretIndex), (fun ctx x -> ctx.Element.CaretIndex <- x), x)
    [<CustomOperation("CaretIndex")>] member inline this.CaretIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretIndex), (fun ctx x -> ctx.Element.CaretIndex <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextDecorationCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("Typography")>] member inline this.Typography ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Typography), x)
    [<CustomOperation("Typography'")>] member inline this.Typography' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Typography), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DatePickerTextBoxBuilder() =
    inherit Controls.TextBoxBuilder<System.Windows.Controls.Primitives.DatePickerTextBox>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type RichTextBoxBuilder<'Element when 'Element :> System.Windows.Controls.RichTextBox>() =
    inherit Controls.Primitives.TextBoxBaseBuilder<'Element>()

    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Documents.FlowDocument) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("IsDocumentEnabled")>] member inline this.IsDocumentEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDocumentEnabled), (fun ctx x -> ctx.Element.IsDocumentEnabled <- x), x)
    [<CustomOperation("IsDocumentEnabled")>] member inline this.IsDocumentEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDocumentEnabled), (fun ctx x -> ctx.Element.IsDocumentEnabled <- x), x)
    [<CustomOperation("Selection")>] member inline this.Selection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("Selection'")>] member inline this.Selection' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("CaretPosition")>] member inline this.CaretPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Documents.TextPointer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretPosition), (fun ctx x -> ctx.Element.CaretPosition <- x), x)
    [<CustomOperation("CaretPosition")>] member inline this.CaretPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretPosition), (fun ctx x -> ctx.Element.CaretPosition <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DocumentViewerBaseBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DocumentViewerBase>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Documents.IDocumentPaginatorSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("PageViews")>] member inline this.PageViews ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PageViews), x)
    [<CustomOperation("PageViews'")>] member inline this.PageViews' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PageViews), x)

    [<CustomOperation("PageViewsChanged")>] member inline this.PageViewsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PageViewsChanged), "PageViewsChanged", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DocumentViewerBuilder<'Element when 'Element :> System.Windows.Controls.DocumentViewer>() =
    inherit Controls.Primitives.DocumentViewerBaseBuilder<'Element>()

    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("ShowPageBorders")>] member inline this.ShowPageBorders ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowPageBorders), (fun ctx x -> ctx.Element.ShowPageBorders <- x), x)
    [<CustomOperation("ShowPageBorders")>] member inline this.ShowPageBorders ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowPageBorders), (fun ctx x -> ctx.Element.ShowPageBorders <- x), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("MaxPagesAcross")>] member inline this.MaxPagesAcross ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxPagesAcross), (fun ctx x -> ctx.Element.MaxPagesAcross <- x), x)
    [<CustomOperation("MaxPagesAcross")>] member inline this.MaxPagesAcross ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxPagesAcross), (fun ctx x -> ctx.Element.MaxPagesAcross <- x), x)
    [<CustomOperation("VerticalPageSpacing")>] member inline this.VerticalPageSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalPageSpacing), (fun ctx x -> ctx.Element.VerticalPageSpacing <- x), x)
    [<CustomOperation("VerticalPageSpacing")>] member inline this.VerticalPageSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalPageSpacing), (fun ctx x -> ctx.Element.VerticalPageSpacing <- x), x)
    [<CustomOperation("HorizontalPageSpacing")>] member inline this.HorizontalPageSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalPageSpacing), (fun ctx x -> ctx.Element.HorizontalPageSpacing <- x), x)
    [<CustomOperation("HorizontalPageSpacing")>] member inline this.HorizontalPageSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalPageSpacing), (fun ctx x -> ctx.Element.HorizontalPageSpacing <- x), x)

                

type FlowDocumentPageViewerBuilder<'Element when 'Element :> System.Windows.Controls.FlowDocumentPageViewer>() =
    inherit Controls.Primitives.DocumentViewerBaseBuilder<'Element>()

    [<CustomOperation("Selection")>] member inline this.Selection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("Selection'")>] member inline this.Selection' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("MaxZoom")>] member inline this.MaxZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoom), (fun ctx x -> ctx.Element.MaxZoom <- x), x)
    [<CustomOperation("MaxZoom")>] member inline this.MaxZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoom), (fun ctx x -> ctx.Element.MaxZoom <- x), x)
    [<CustomOperation("MinZoom")>] member inline this.MinZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoom), (fun ctx x -> ctx.Element.MinZoom <- x), x)
    [<CustomOperation("MinZoom")>] member inline this.MinZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoom), (fun ctx x -> ctx.Element.MinZoom <- x), x)
    [<CustomOperation("ZoomIncrement")>] member inline this.ZoomIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomIncrement), (fun ctx x -> ctx.Element.ZoomIncrement <- x), x)
    [<CustomOperation("ZoomIncrement")>] member inline this.ZoomIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomIncrement), (fun ctx x -> ctx.Element.ZoomIncrement <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ThumbBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.Thumb>() =
    inherit Controls.ControlBuilder<'Element>()


    [<CustomOperation("DragStarted")>] member inline this.DragStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStarted), "DragStarted", fn)
    [<CustomOperation("DragDelta")>] member inline this.DragDelta ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragDelta), "DragDelta", fn)
    [<CustomOperation("DragCompleted")>] member inline this.DragCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragCompleted), "DragCompleted", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type GridSplitterBuilder<'Element when 'Element :> System.Windows.Controls.GridSplitter>() =
    inherit Controls.Primitives.ThumbBuilder<'Element>()

    [<CustomOperation("ResizeDirection")>] member inline this.ResizeDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.GridResizeDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeDirection), (fun ctx x -> ctx.Element.ResizeDirection <- x), x)
    [<CustomOperation("ResizeDirection")>] member inline this.ResizeDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeDirection), (fun ctx x -> ctx.Element.ResizeDirection <- x), x)
    [<CustomOperation("ResizeBehavior")>] member inline this.ResizeBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.GridResizeBehavior) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeBehavior), (fun ctx x -> ctx.Element.ResizeBehavior <- x), x)
    [<CustomOperation("ResizeBehavior")>] member inline this.ResizeBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeBehavior), (fun ctx x -> ctx.Element.ResizeBehavior <- x), x)
    [<CustomOperation("ShowsPreview")>] member inline this.ShowsPreview ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsPreview), (fun ctx x -> ctx.Element.ShowsPreview <- x), x)
    [<CustomOperation("ShowsPreview")>] member inline this.ShowsPreview ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsPreview), (fun ctx x -> ctx.Element.ShowsPreview <- x), x)
    [<CustomOperation("PreviewStyle")>] member inline this.PreviewStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreviewStyle), (fun ctx x -> ctx.Element.PreviewStyle <- x), x)
    [<CustomOperation("PreviewStyle")>] member inline this.PreviewStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreviewStyle), (fun ctx x -> ctx.Element.PreviewStyle <- x), x)
    [<CustomOperation("KeyboardIncrement")>] member inline this.KeyboardIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardIncrement), (fun ctx x -> ctx.Element.KeyboardIncrement <- x), x)
    [<CustomOperation("KeyboardIncrement")>] member inline this.KeyboardIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardIncrement), (fun ctx x -> ctx.Element.KeyboardIncrement <- x), x)
    [<CustomOperation("DragIncrement")>] member inline this.DragIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragIncrement), (fun ctx x -> ctx.Element.DragIncrement <- x), x)
    [<CustomOperation("DragIncrement")>] member inline this.DragIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragIncrement), (fun ctx x -> ctx.Element.DragIncrement <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type RangeBaseBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.RangeBase>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)

    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ProgressBarBuilder<'Element when 'Element :> System.Windows.Controls.ProgressBar>() =
    inherit Controls.Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type SliderBuilder<'Element when 'Element :> System.Windows.Controls.Slider>() =
    inherit Controls.Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Delay), (fun ctx x -> ctx.Element.Delay <- x), x)
    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Delay), (fun ctx x -> ctx.Element.Delay <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)
    [<CustomOperation("AutoToolTipPlacement")>] member inline this.AutoToolTipPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.AutoToolTipPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoToolTipPlacement), (fun ctx x -> ctx.Element.AutoToolTipPlacement <- x), x)
    [<CustomOperation("AutoToolTipPlacement")>] member inline this.AutoToolTipPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoToolTipPlacement), (fun ctx x -> ctx.Element.AutoToolTipPlacement <- x), x)
    [<CustomOperation("AutoToolTipPrecision")>] member inline this.AutoToolTipPrecision ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoToolTipPrecision), (fun ctx x -> ctx.Element.AutoToolTipPrecision <- x), x)
    [<CustomOperation("AutoToolTipPrecision")>] member inline this.AutoToolTipPrecision ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoToolTipPrecision), (fun ctx x -> ctx.Element.AutoToolTipPrecision <- x), x)
    [<CustomOperation("IsSnapToTickEnabled")>] member inline this.IsSnapToTickEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSnapToTickEnabled), (fun ctx x -> ctx.Element.IsSnapToTickEnabled <- x), x)
    [<CustomOperation("IsSnapToTickEnabled")>] member inline this.IsSnapToTickEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSnapToTickEnabled), (fun ctx x -> ctx.Element.IsSnapToTickEnabled <- x), x)
    [<CustomOperation("TickPlacement")>] member inline this.TickPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.TickPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickPlacement), (fun ctx x -> ctx.Element.TickPlacement <- x), x)
    [<CustomOperation("TickPlacement")>] member inline this.TickPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickPlacement), (fun ctx x -> ctx.Element.TickPlacement <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.DoubleCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("IsSelectionRangeEnabled")>] member inline this.IsSelectionRangeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelectionRangeEnabled), (fun ctx x -> ctx.Element.IsSelectionRangeEnabled <- x), x)
    [<CustomOperation("IsSelectionRangeEnabled")>] member inline this.IsSelectionRangeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelectionRangeEnabled), (fun ctx x -> ctx.Element.IsSelectionRangeEnabled <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("IsMoveToPointEnabled")>] member inline this.IsMoveToPointEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsMoveToPointEnabled), (fun ctx x -> ctx.Element.IsMoveToPointEnabled <- x), x)
    [<CustomOperation("IsMoveToPointEnabled")>] member inline this.IsMoveToPointEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsMoveToPointEnabled), (fun ctx x -> ctx.Element.IsMoveToPointEnabled <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ScrollBarBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.ScrollBar>() =
    inherit Controls.Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("Track")>] member inline this.Track ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Track), x)
    [<CustomOperation("Track'")>] member inline this.Track' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Track), x)

    [<CustomOperation("Scroll")>] member inline this.Scroll ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scroll), "Scroll", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type StickyNoteControlBuilder() =
    inherit Controls.ControlBuilder<System.Windows.Controls.StickyNoteControl>()

    [<CustomOperation("Author")>] member inline this.Author ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Author), x)
    [<CustomOperation("Author'")>] member inline this.Author' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Author), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("CaptionFontFamily")>] member inline this.CaptionFontFamily ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Windows.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontFamily), (fun ctx x -> ctx.Element.CaptionFontFamily <- x), x)
    [<CustomOperation("CaptionFontFamily")>] member inline this.CaptionFontFamily ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontFamily), (fun ctx x -> ctx.Element.CaptionFontFamily <- x), x)
    [<CustomOperation("CaptionFontSize")>] member inline this.CaptionFontSize ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontSize), (fun ctx x -> ctx.Element.CaptionFontSize <- x), x)
    [<CustomOperation("CaptionFontSize")>] member inline this.CaptionFontSize ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontSize), (fun ctx x -> ctx.Element.CaptionFontSize <- x), x)
    [<CustomOperation("CaptionFontStretch")>] member inline this.CaptionFontStretch ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Windows.FontStretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontStretch), (fun ctx x -> ctx.Element.CaptionFontStretch <- x), x)
    [<CustomOperation("CaptionFontStretch")>] member inline this.CaptionFontStretch ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontStretch), (fun ctx x -> ctx.Element.CaptionFontStretch <- x), x)
    [<CustomOperation("CaptionFontStyle")>] member inline this.CaptionFontStyle ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Windows.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontStyle), (fun ctx x -> ctx.Element.CaptionFontStyle <- x), x)
    [<CustomOperation("CaptionFontStyle")>] member inline this.CaptionFontStyle ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontStyle), (fun ctx x -> ctx.Element.CaptionFontStyle <- x), x)
    [<CustomOperation("CaptionFontWeight")>] member inline this.CaptionFontWeight ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Windows.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontWeight), (fun ctx x -> ctx.Element.CaptionFontWeight <- x), x)
    [<CustomOperation("CaptionFontWeight")>] member inline this.CaptionFontWeight ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaptionFontWeight), (fun ctx x -> ctx.Element.CaptionFontWeight <- x), x)
    [<CustomOperation("PenWidth")>] member inline this.PenWidth ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PenWidth), (fun ctx x -> ctx.Element.PenWidth <- x), x)
    [<CustomOperation("PenWidth")>] member inline this.PenWidth ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PenWidth), (fun ctx x -> ctx.Element.PenWidth <- x), x)
    [<CustomOperation("AnchorInfo")>] member inline this.AnchorInfo ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AnchorInfo), x)
    [<CustomOperation("AnchorInfo'")>] member inline this.AnchorInfo' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StickyNoteControl>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AnchorInfo), x)

                

type CalendarBuilder<'Element when 'Element :> System.Windows.Controls.Calendar>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("BlackoutDates")>] member inline this.BlackoutDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDates'")>] member inline this.BlackoutDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("CalendarButtonStyle")>] member inline this.CalendarButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarButtonStyle), (fun ctx x -> ctx.Element.CalendarButtonStyle <- x), x)
    [<CustomOperation("CalendarButtonStyle")>] member inline this.CalendarButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarButtonStyle), (fun ctx x -> ctx.Element.CalendarButtonStyle <- x), x)
    [<CustomOperation("CalendarDayButtonStyle")>] member inline this.CalendarDayButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarDayButtonStyle), (fun ctx x -> ctx.Element.CalendarDayButtonStyle <- x), x)
    [<CustomOperation("CalendarDayButtonStyle")>] member inline this.CalendarDayButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarDayButtonStyle), (fun ctx x -> ctx.Element.CalendarDayButtonStyle <- x), x)
    [<CustomOperation("CalendarItemStyle")>] member inline this.CalendarItemStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemStyle), (fun ctx x -> ctx.Element.CalendarItemStyle <- x), x)
    [<CustomOperation("CalendarItemStyle")>] member inline this.CalendarItemStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemStyle), (fun ctx x -> ctx.Element.CalendarItemStyle <- x), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.CalendarMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DayOfWeek) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDates")>] member inline this.SelectedDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectedDates'")>] member inline this.SelectedDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.CalendarSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)

    [<CustomOperation("SelectedDatesChanged")>] member inline this.SelectedDatesChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDatesChanged), "SelectedDatesChanged", fn)
    [<CustomOperation("DisplayDateChanged")>] member inline this.DisplayDateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateChanged), "DisplayDateChanged", fn)
    [<CustomOperation("DisplayModeChanged")>] member inline this.DisplayModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayModeChanged), "DisplayModeChanged", fn)
    [<CustomOperation("SelectionModeChanged")>] member inline this.SelectionModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionModeChanged), "SelectionModeChanged", fn)
                

type DataGridRowBuilder<'Element when 'Element :> System.Windows.Controls.DataGridRow>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Item")>] member inline this.Item ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Item), (fun ctx x -> ctx.Element.Item <- x), x)
    [<CustomOperation("Item")>] member inline this.Item ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Item), (fun ctx x -> ctx.Element.Item <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ItemsPanelTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderStyle")>] member inline this.HeaderStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderStyle), (fun ctx x -> ctx.Element.HeaderStyle <- x), x)
    [<CustomOperation("HeaderStyle")>] member inline this.HeaderStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderStyle), (fun ctx x -> ctx.Element.HeaderStyle <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("ValidationErrorTemplate")>] member inline this.ValidationErrorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ValidationErrorTemplate), (fun ctx x -> ctx.Element.ValidationErrorTemplate <- x), x)
    [<CustomOperation("ValidationErrorTemplate")>] member inline this.ValidationErrorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ValidationErrorTemplate), (fun ctx x -> ctx.Element.ValidationErrorTemplate <- x), x)
    [<CustomOperation("DetailsTemplate")>] member inline this.DetailsTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DetailsTemplate), (fun ctx x -> ctx.Element.DetailsTemplate <- x), x)
    [<CustomOperation("DetailsTemplate")>] member inline this.DetailsTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DetailsTemplate), (fun ctx x -> ctx.Element.DetailsTemplate <- x), x)
    [<CustomOperation("DetailsTemplateSelector")>] member inline this.DetailsTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DetailsTemplateSelector), (fun ctx x -> ctx.Element.DetailsTemplateSelector <- x), x)
    [<CustomOperation("DetailsTemplateSelector")>] member inline this.DetailsTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DetailsTemplateSelector), (fun ctx x -> ctx.Element.DetailsTemplateSelector <- x), x)
    [<CustomOperation("DetailsVisibility")>] member inline this.DetailsVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Visibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DetailsVisibility), (fun ctx x -> ctx.Element.DetailsVisibility <- x), x)
    [<CustomOperation("DetailsVisibility")>] member inline this.DetailsVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DetailsVisibility), (fun ctx x -> ctx.Element.DetailsVisibility <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

    [<CustomOperation("Selected")>] member inline this.Selected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Selected), "Selected", fn)
    [<CustomOperation("Unselected")>] member inline this.Unselected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unselected), "Unselected", fn)
                

type DatePickerBuilder<'Element when 'Element :> System.Windows.Controls.DatePicker>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("BlackoutDates")>] member inline this.BlackoutDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDates'")>] member inline this.BlackoutDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("CalendarStyle")>] member inline this.CalendarStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarStyle), (fun ctx x -> ctx.Element.CalendarStyle <- x), x)
    [<CustomOperation("CalendarStyle")>] member inline this.CalendarStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarStyle), (fun ctx x -> ctx.Element.CalendarStyle <- x), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DayOfWeek) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDateFormat")>] member inline this.SelectedDateFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DatePickerFormat) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateFormat), (fun ctx x -> ctx.Element.SelectedDateFormat <- x), x)
    [<CustomOperation("SelectedDateFormat")>] member inline this.SelectedDateFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateFormat), (fun ctx x -> ctx.Element.SelectedDateFormat <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

    [<CustomOperation("CalendarClosed")>] member inline this.CalendarClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarClosed), "CalendarClosed", fn)
    [<CustomOperation("CalendarOpened")>] member inline this.CalendarOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarOpened), "CalendarOpened", fn)
    [<CustomOperation("DateValidationError")>] member inline this.DateValidationError ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DateValidationError), "DateValidationError", fn)
    [<CustomOperation("SelectedDateChanged")>] member inline this.SelectedDateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateChanged), "SelectedDateChanged", fn)
                

type FlowDocumentReaderBuilder<'Element when 'Element :> System.Windows.Controls.FlowDocumentReader>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("ViewingMode")>] member inline this.ViewingMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.FlowDocumentReaderViewingMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewingMode), (fun ctx x -> ctx.Element.ViewingMode <- x), x)
    [<CustomOperation("ViewingMode")>] member inline this.ViewingMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ViewingMode), (fun ctx x -> ctx.Element.ViewingMode <- x), x)
    [<CustomOperation("Selection")>] member inline this.Selection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("Selection'")>] member inline this.Selection' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("IsPageViewEnabled")>] member inline this.IsPageViewEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPageViewEnabled), (fun ctx x -> ctx.Element.IsPageViewEnabled <- x), x)
    [<CustomOperation("IsPageViewEnabled")>] member inline this.IsPageViewEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPageViewEnabled), (fun ctx x -> ctx.Element.IsPageViewEnabled <- x), x)
    [<CustomOperation("IsTwoPageViewEnabled")>] member inline this.IsTwoPageViewEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTwoPageViewEnabled), (fun ctx x -> ctx.Element.IsTwoPageViewEnabled <- x), x)
    [<CustomOperation("IsTwoPageViewEnabled")>] member inline this.IsTwoPageViewEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTwoPageViewEnabled), (fun ctx x -> ctx.Element.IsTwoPageViewEnabled <- x), x)
    [<CustomOperation("IsScrollViewEnabled")>] member inline this.IsScrollViewEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrollViewEnabled), (fun ctx x -> ctx.Element.IsScrollViewEnabled <- x), x)
    [<CustomOperation("IsScrollViewEnabled")>] member inline this.IsScrollViewEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrollViewEnabled), (fun ctx x -> ctx.Element.IsScrollViewEnabled <- x), x)
    [<CustomOperation("IsFindEnabled")>] member inline this.IsFindEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsFindEnabled), (fun ctx x -> ctx.Element.IsFindEnabled <- x), x)
    [<CustomOperation("IsFindEnabled")>] member inline this.IsFindEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsFindEnabled), (fun ctx x -> ctx.Element.IsFindEnabled <- x), x)
    [<CustomOperation("IsPrintEnabled")>] member inline this.IsPrintEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPrintEnabled), (fun ctx x -> ctx.Element.IsPrintEnabled <- x), x)
    [<CustomOperation("IsPrintEnabled")>] member inline this.IsPrintEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPrintEnabled), (fun ctx x -> ctx.Element.IsPrintEnabled <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Documents.FlowDocument) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("MaxZoom")>] member inline this.MaxZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoom), (fun ctx x -> ctx.Element.MaxZoom <- x), x)
    [<CustomOperation("MaxZoom")>] member inline this.MaxZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoom), (fun ctx x -> ctx.Element.MaxZoom <- x), x)
    [<CustomOperation("MinZoom")>] member inline this.MinZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoom), (fun ctx x -> ctx.Element.MinZoom <- x), x)
    [<CustomOperation("MinZoom")>] member inline this.MinZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoom), (fun ctx x -> ctx.Element.MinZoom <- x), x)
    [<CustomOperation("ZoomIncrement")>] member inline this.ZoomIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomIncrement), (fun ctx x -> ctx.Element.ZoomIncrement <- x), x)
    [<CustomOperation("ZoomIncrement")>] member inline this.ZoomIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomIncrement), (fun ctx x -> ctx.Element.ZoomIncrement <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)

                

type FlowDocumentScrollViewerBuilder<'Element when 'Element :> System.Windows.Controls.FlowDocumentScrollViewer>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Documents.FlowDocument) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Document), (fun ctx x -> ctx.Element.Document <- x), x)
    [<CustomOperation("Selection")>] member inline this.Selection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("Selection'")>] member inline this.Selection' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Selection), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("Zoom")>] member inline this.Zoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Zoom), (fun ctx x -> ctx.Element.Zoom <- x), x)
    [<CustomOperation("MaxZoom")>] member inline this.MaxZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoom), (fun ctx x -> ctx.Element.MaxZoom <- x), x)
    [<CustomOperation("MaxZoom")>] member inline this.MaxZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoom), (fun ctx x -> ctx.Element.MaxZoom <- x), x)
    [<CustomOperation("MinZoom")>] member inline this.MinZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoom), (fun ctx x -> ctx.Element.MinZoom <- x), x)
    [<CustomOperation("MinZoom")>] member inline this.MinZoom ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoom), (fun ctx x -> ctx.Element.MinZoom <- x), x)
    [<CustomOperation("ZoomIncrement")>] member inline this.ZoomIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomIncrement), (fun ctx x -> ctx.Element.ZoomIncrement <- x), x)
    [<CustomOperation("ZoomIncrement")>] member inline this.ZoomIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomIncrement), (fun ctx x -> ctx.Element.ZoomIncrement <- x), x)
    [<CustomOperation("IsSelectionEnabled")>] member inline this.IsSelectionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelectionEnabled), (fun ctx x -> ctx.Element.IsSelectionEnabled <- x), x)
    [<CustomOperation("IsSelectionEnabled")>] member inline this.IsSelectionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelectionEnabled), (fun ctx x -> ctx.Element.IsSelectionEnabled <- x), x)
    [<CustomOperation("IsToolBarVisible")>] member inline this.IsToolBarVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsToolBarVisible), (fun ctx x -> ctx.Element.IsToolBarVisible <- x), x)
    [<CustomOperation("IsToolBarVisible")>] member inline this.IsToolBarVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsToolBarVisible), (fun ctx x -> ctx.Element.IsToolBarVisible <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)

                

type PasswordBoxBuilder() =
    inherit Controls.ControlBuilder<System.Windows.Controls.PasswordBox>()

    [<CustomOperation("Password")>] member inline this.Password ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Password), (fun ctx x -> ctx.Element.Password <- x), x)
    [<CustomOperation("Password")>] member inline this.Password ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Password), (fun ctx x -> ctx.Element.Password <- x), x)
    [<CustomOperation("SecurePassword")>] member inline this.SecurePassword ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SecurePassword), x)
    [<CustomOperation("SecurePassword'")>] member inline this.SecurePassword' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SecurePassword), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Char) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionTextBrush")>] member inline this.SelectionTextBrush ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionTextBrush), (fun ctx x -> ctx.Element.SelectionTextBrush <- x), x)
    [<CustomOperation("SelectionTextBrush")>] member inline this.SelectionTextBrush ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionTextBrush), (fun ctx x -> ctx.Element.SelectionTextBrush <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("SelectionOpacity")>] member inline this.SelectionOpacity ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionOpacity), (fun ctx x -> ctx.Element.SelectionOpacity <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)
    [<CustomOperation("IsInactiveSelectionHighlightEnabled")>] member inline this.IsInactiveSelectionHighlightEnabled ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInactiveSelectionHighlightEnabled), (fun ctx x -> ctx.Element.IsInactiveSelectionHighlightEnabled <- x), x)

    [<CustomOperation("PasswordChanged")>] member inline this.PasswordChanged ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChanged), "PasswordChanged", fn)
                

type SeparatorBuilder<'Element when 'Element :> System.Windows.Controls.Separator>() =
    inherit Controls.ControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type CalendarItemBuilder() =
    inherit Controls.ControlBuilder<System.Windows.Controls.Primitives.CalendarItem>()


                

type ResizeGripBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.ResizeGrip>() =
    inherit Controls.ControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals.Interop
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type HwndHostBuilder<'Element when 'Element :> System.Windows.Interop.HwndHost>() =
    inherit FrameworkElementBuilder<'Element>()


    //[<CustomOperation("MessageHook")>] member inline this.MessageHook ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MessageHook), "MessageHook", fn)
    [<CustomOperation("DpiChanged")>] member inline this.DpiChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DpiChanged), "DpiChanged", fn)
                

type ActiveXHostBuilder<'Element when 'Element :> System.Windows.Interop.ActiveXHost>() =
    inherit Interop.HwndHostBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type WebBrowserBuilder() =
    inherit Interop.ActiveXHostBuilder<System.Windows.Controls.WebBrowser>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("ObjectForScripting")>] member inline this.ObjectForScripting ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ObjectForScripting), (fun ctx x -> ctx.Element.ObjectForScripting <- x), x)
    [<CustomOperation("ObjectForScripting")>] member inline this.ObjectForScripting ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ObjectForScripting), (fun ctx x -> ctx.Element.ObjectForScripting <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Document), x)
    [<CustomOperation("Document'")>] member inline this.Document' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Document), x)

    [<CustomOperation("Navigating")>] member inline this.Navigating ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigating), "Navigating", fn)
    [<CustomOperation("Navigated")>] member inline this.Navigated ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigated), "Navigated", fn)
    [<CustomOperation("LoadCompleted")>] member inline this.LoadCompleted ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LoadCompleted), "LoadCompleted", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Shapes
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ShapeBuilder<'Element when 'Element :> System.Windows.Shapes.Shape>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("RenderedGeometry")>] member inline this.RenderedGeometry ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("RenderedGeometry'")>] member inline this.RenderedGeometry' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("GeometryTransform")>] member inline this.GeometryTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GeometryTransform), x)
    [<CustomOperation("GeometryTransform'")>] member inline this.GeometryTransform' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GeometryTransform), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Stroke")>] member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stroke), (fun ctx x -> ctx.Element.Stroke <- x), x)
    [<CustomOperation("Stroke")>] member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stroke), (fun ctx x -> ctx.Element.Stroke <- x), x)
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeStartLineCap")>] member inline this.StrokeStartLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeStartLineCap), (fun ctx x -> ctx.Element.StrokeStartLineCap <- x), x)
    [<CustomOperation("StrokeStartLineCap")>] member inline this.StrokeStartLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeStartLineCap), (fun ctx x -> ctx.Element.StrokeStartLineCap <- x), x)
    [<CustomOperation("StrokeEndLineCap")>] member inline this.StrokeEndLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeEndLineCap), (fun ctx x -> ctx.Element.StrokeEndLineCap <- x), x)
    [<CustomOperation("StrokeEndLineCap")>] member inline this.StrokeEndLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeEndLineCap), (fun ctx x -> ctx.Element.StrokeEndLineCap <- x), x)
    [<CustomOperation("StrokeDashCap")>] member inline this.StrokeDashCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashCap), (fun ctx x -> ctx.Element.StrokeDashCap <- x), x)
    [<CustomOperation("StrokeDashCap")>] member inline this.StrokeDashCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashCap), (fun ctx x -> ctx.Element.StrokeDashCap <- x), x)
    [<CustomOperation("StrokeLineJoin")>] member inline this.StrokeLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.PenLineJoin) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineJoin), (fun ctx x -> ctx.Element.StrokeLineJoin <- x), x)
    [<CustomOperation("StrokeLineJoin")>] member inline this.StrokeLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineJoin), (fun ctx x -> ctx.Element.StrokeLineJoin <- x), x)
    [<CustomOperation("StrokeMiterLimit")>] member inline this.StrokeMiterLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeMiterLimit), (fun ctx x -> ctx.Element.StrokeMiterLimit <- x), x)
    [<CustomOperation("StrokeMiterLimit")>] member inline this.StrokeMiterLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeMiterLimit), (fun ctx x -> ctx.Element.StrokeMiterLimit <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.DoubleCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)

                

type EllipseBuilder() =
    inherit Shapes.ShapeBuilder<System.Windows.Shapes.Ellipse>()

    [<CustomOperation("RenderedGeometry")>] member inline this.RenderedGeometry ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Ellipse>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("RenderedGeometry'")>] member inline this.RenderedGeometry' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Ellipse>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("GeometryTransform")>] member inline this.GeometryTransform ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Ellipse>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GeometryTransform), x)
    [<CustomOperation("GeometryTransform'")>] member inline this.GeometryTransform' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Ellipse>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GeometryTransform), x)

                

type LineBuilder() =
    inherit Shapes.ShapeBuilder<System.Windows.Shapes.Line>()

    [<CustomOperation("X1")>] member inline this.X1 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.X1), (fun ctx x -> ctx.Element.X1 <- x), x)
    [<CustomOperation("X1")>] member inline this.X1 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.X1), (fun ctx x -> ctx.Element.X1 <- x), x)
    [<CustomOperation("Y1")>] member inline this.Y1 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Y1), (fun ctx x -> ctx.Element.Y1 <- x), x)
    [<CustomOperation("Y1")>] member inline this.Y1 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Y1), (fun ctx x -> ctx.Element.Y1 <- x), x)
    [<CustomOperation("X2")>] member inline this.X2 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.X2), (fun ctx x -> ctx.Element.X2 <- x), x)
    [<CustomOperation("X2")>] member inline this.X2 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.X2), (fun ctx x -> ctx.Element.X2 <- x), x)
    [<CustomOperation("Y2")>] member inline this.Y2 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Y2), (fun ctx x -> ctx.Element.Y2 <- x), x)
    [<CustomOperation("Y2")>] member inline this.Y2 ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Y2), (fun ctx x -> ctx.Element.Y2 <- x), x)

                

type PathBuilder() =
    inherit Shapes.ShapeBuilder<System.Windows.Shapes.Path>()

    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Path>, x: System.Windows.Media.Geometry) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)
    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Path>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)

                

type PolygonBuilder() =
    inherit Shapes.ShapeBuilder<System.Windows.Shapes.Polygon>()

    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polygon>, x: System.Windows.Media.PointCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polygon>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polygon>, x: System.Windows.Media.FillRule) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polygon>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)

                

type PolylineBuilder() =
    inherit Shapes.ShapeBuilder<System.Windows.Shapes.Polyline>()

    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polyline>, x: System.Windows.Media.PointCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polyline>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polyline>, x: System.Windows.Media.FillRule) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polyline>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)

                

type RectangleBuilder() =
    inherit Shapes.ShapeBuilder<System.Windows.Shapes.Rectangle>()

    [<CustomOperation("RadiusX")>] member inline this.RadiusX ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusX), (fun ctx x -> ctx.Element.RadiusX <- x), x)
    [<CustomOperation("RadiusX")>] member inline this.RadiusX ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusX), (fun ctx x -> ctx.Element.RadiusX <- x), x)
    [<CustomOperation("RadiusY")>] member inline this.RadiusY ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusY), (fun ctx x -> ctx.Element.RadiusY <- x), x)
    [<CustomOperation("RadiusY")>] member inline this.RadiusY ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusY), (fun ctx x -> ctx.Element.RadiusY <- x), x)
    [<CustomOperation("RenderedGeometry")>] member inline this.RenderedGeometry ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("RenderedGeometry'")>] member inline this.RenderedGeometry' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("GeometryTransform")>] member inline this.GeometryTransform ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GeometryTransform), x)
    [<CustomOperation("GeometryTransform'")>] member inline this.GeometryTransform' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GeometryTransform), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DecoratorBuilder<'Element when 'Element :> System.Windows.Controls.Decorator>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Documents
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type AdornerDecoratorBuilder<'Element when 'Element :> System.Windows.Documents.AdornerDecorator>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("AdornerLayer")>] member inline this.AdornerLayer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AdornerLayer), x)
    [<CustomOperation("AdornerLayer'")>] member inline this.AdornerLayer' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AdornerLayer), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type BorderBuilder<'Element when 'Element :> System.Windows.Controls.Border>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)

                

type InkPresenterBuilder<'Element when 'Element :> System.Windows.Controls.InkPresenter>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("Strokes")>] member inline this.Strokes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Ink.StrokeCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Strokes), (fun ctx x -> ctx.Element.Strokes <- x), x)
    [<CustomOperation("Strokes")>] member inline this.Strokes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Strokes), (fun ctx x -> ctx.Element.Strokes <- x), x)

                

type ViewboxBuilder<'Element when 'Element :> System.Windows.Controls.Viewbox>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.StretchDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type BulletDecoratorBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.BulletDecorator>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Bullet")>] member inline this.Bullet ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Bullet), (fun ctx x -> ctx.Element.Bullet <- x), x)
    [<CustomOperation("Bullet")>] member inline this.Bullet ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Bullet), (fun ctx x -> ctx.Element.Bullet <- x), x)

                

type GridViewRowPresenterBaseBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.GridViewRowPresenterBase>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.GridViewColumnCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Columns), (fun ctx x -> ctx.Element.Columns <- x), x)
    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Columns), (fun ctx x -> ctx.Element.Columns <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type GridViewHeaderRowPresenterBuilder<'Element when 'Element :> System.Windows.Controls.GridViewHeaderRowPresenter>() =
    inherit Controls.Primitives.GridViewRowPresenterBaseBuilder<'Element>()

    [<CustomOperation("ColumnHeaderContainerStyle")>] member inline this.ColumnHeaderContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderContainerStyle), (fun ctx x -> ctx.Element.ColumnHeaderContainerStyle <- x), x)
    [<CustomOperation("ColumnHeaderContainerStyle")>] member inline this.ColumnHeaderContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderContainerStyle), (fun ctx x -> ctx.Element.ColumnHeaderContainerStyle <- x), x)
    [<CustomOperation("ColumnHeaderTemplate")>] member inline this.ColumnHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderTemplate), (fun ctx x -> ctx.Element.ColumnHeaderTemplate <- x), x)
    [<CustomOperation("ColumnHeaderTemplate")>] member inline this.ColumnHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderTemplate), (fun ctx x -> ctx.Element.ColumnHeaderTemplate <- x), x)
    [<CustomOperation("ColumnHeaderTemplateSelector")>] member inline this.ColumnHeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderTemplateSelector), (fun ctx x -> ctx.Element.ColumnHeaderTemplateSelector <- x), x)
    [<CustomOperation("ColumnHeaderTemplateSelector")>] member inline this.ColumnHeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderTemplateSelector), (fun ctx x -> ctx.Element.ColumnHeaderTemplateSelector <- x), x)
    [<CustomOperation("ColumnHeaderStringFormat")>] member inline this.ColumnHeaderStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderStringFormat), (fun ctx x -> ctx.Element.ColumnHeaderStringFormat <- x), x)
    [<CustomOperation("ColumnHeaderStringFormat")>] member inline this.ColumnHeaderStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderStringFormat), (fun ctx x -> ctx.Element.ColumnHeaderStringFormat <- x), x)
    [<CustomOperation("AllowsColumnReorder")>] member inline this.AllowsColumnReorder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsColumnReorder), (fun ctx x -> ctx.Element.AllowsColumnReorder <- x), x)
    [<CustomOperation("AllowsColumnReorder")>] member inline this.AllowsColumnReorder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsColumnReorder), (fun ctx x -> ctx.Element.AllowsColumnReorder <- x), x)
    [<CustomOperation("ColumnHeaderContextMenu")>] member inline this.ColumnHeaderContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ContextMenu) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderContextMenu), (fun ctx x -> ctx.Element.ColumnHeaderContextMenu <- x), x)
    [<CustomOperation("ColumnHeaderContextMenu")>] member inline this.ColumnHeaderContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderContextMenu), (fun ctx x -> ctx.Element.ColumnHeaderContextMenu <- x), x)
    [<CustomOperation("ColumnHeaderToolTip")>] member inline this.ColumnHeaderToolTip ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderToolTip), (fun ctx x -> ctx.Element.ColumnHeaderToolTip <- x), x)
    [<CustomOperation("ColumnHeaderToolTip")>] member inline this.ColumnHeaderToolTip ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnHeaderToolTip), (fun ctx x -> ctx.Element.ColumnHeaderToolTip <- x), x)

                

type GridViewRowPresenterBuilder<'Element when 'Element :> System.Windows.Controls.GridViewRowPresenter>() =
    inherit Controls.Primitives.GridViewRowPresenterBaseBuilder<'Element>()

    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)

                

type ContentPresenterBuilder<'Element when 'Element :> System.Windows.Controls.ContentPresenter>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("RecognizesAccessKey")>] member inline this.RecognizesAccessKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RecognizesAccessKey), (fun ctx x -> ctx.Element.RecognizesAccessKey <- x), x)
    [<CustomOperation("RecognizesAccessKey")>] member inline this.RecognizesAccessKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RecognizesAccessKey), (fun ctx x -> ctx.Element.RecognizesAccessKey <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentStringFormat")>] member inline this.ContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentStringFormat), (fun ctx x -> ctx.Element.ContentStringFormat <- x), x)
    [<CustomOperation("ContentStringFormat")>] member inline this.ContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentStringFormat), (fun ctx x -> ctx.Element.ContentStringFormat <- x), x)
    [<CustomOperation("ContentSource")>] member inline this.ContentSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentSource), (fun ctx x -> ctx.Element.ContentSource <- x), x)
    [<CustomOperation("ContentSource")>] member inline this.ContentSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentSource), (fun ctx x -> ctx.Element.ContentSource <- x), x)

                

type ScrollContentPresenterBuilder() =
    inherit Controls.ContentPresenterBuilder<System.Windows.Controls.ScrollContentPresenter>()

    [<CustomOperation("AdornerLayer")>] member inline this.AdornerLayer ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AdornerLayer), x)
    [<CustomOperation("AdornerLayer'")>] member inline this.AdornerLayer' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AdornerLayer), x)
    [<CustomOperation("CanContentScroll")>] member inline this.CanContentScroll ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanContentScroll), (fun ctx x -> ctx.Element.CanContentScroll <- x), x)
    [<CustomOperation("CanContentScroll")>] member inline this.CanContentScroll ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanContentScroll), (fun ctx x -> ctx.Element.CanContentScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x: System.Windows.Controls.ScrollViewer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DataGridDetailsPresenterBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DataGridDetailsPresenter>() =
    inherit Controls.ContentPresenterBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals.Documents
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type AdornerBuilder<'Element when 'Element :> System.Windows.Documents.Adorner>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("AdornedElement")>] member inline this.AdornedElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AdornedElement), x)
    [<CustomOperation("AdornedElement'")>] member inline this.AdornedElement' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AdornedElement), x)
    [<CustomOperation("IsClipEnabled")>] member inline this.IsClipEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClipEnabled), (fun ctx x -> ctx.Element.IsClipEnabled <- x), x)
    [<CustomOperation("IsClipEnabled")>] member inline this.IsClipEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClipEnabled), (fun ctx x -> ctx.Element.IsClipEnabled <- x), x)

                

type AdornerLayerBuilder<'Element when 'Element :> System.Windows.Documents.AdornerLayer>() =
    inherit FrameworkElementBuilder<'Element>()


                

type DocumentReferenceBuilder() =
    inherit FrameworkElementBuilder<System.Windows.Documents.DocumentReference>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.DocumentReference>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.DocumentReference>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)

                

type FixedPageBuilder() =
    inherit FrameworkElementBuilder<System.Windows.Documents.FixedPage>()

    [<CustomOperation("Children")>] member inline this.Children ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Children), x)
    [<CustomOperation("Children'")>] member inline this.Children' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Children), x)
    [<CustomOperation("PrintTicket")>] member inline this.PrintTicket ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PrintTicket), (fun ctx x -> ctx.Element.PrintTicket <- x), x)
    [<CustomOperation("PrintTicket")>] member inline this.PrintTicket ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PrintTicket), (fun ctx x -> ctx.Element.PrintTicket <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("ContentBox")>] member inline this.ContentBox ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x: System.Windows.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentBox), (fun ctx x -> ctx.Element.ContentBox <- x), x)
    [<CustomOperation("ContentBox")>] member inline this.ContentBox ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentBox), (fun ctx x -> ctx.Element.ContentBox <- x), x)
    [<CustomOperation("BleedBox")>] member inline this.BleedBox ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x: System.Windows.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BleedBox), (fun ctx x -> ctx.Element.BleedBox <- x), x)
    [<CustomOperation("BleedBox")>] member inline this.BleedBox ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BleedBox), (fun ctx x -> ctx.Element.BleedBox <- x), x)

                

type GlyphsBuilder() =
    inherit FrameworkElementBuilder<System.Windows.Documents.Glyphs>()

    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Indices")>] member inline this.Indices ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Indices), (fun ctx x -> ctx.Element.Indices <- x), x)
    [<CustomOperation("Indices")>] member inline this.Indices ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Indices), (fun ctx x -> ctx.Element.Indices <- x), x)
    [<CustomOperation("UnicodeString")>] member inline this.UnicodeString ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UnicodeString), (fun ctx x -> ctx.Element.UnicodeString <- x), x)
    [<CustomOperation("UnicodeString")>] member inline this.UnicodeString ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UnicodeString), (fun ctx x -> ctx.Element.UnicodeString <- x), x)
    [<CustomOperation("CaretStops")>] member inline this.CaretStops ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretStops), (fun ctx x -> ctx.Element.CaretStops <- x), x)
    [<CustomOperation("CaretStops")>] member inline this.CaretStops ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretStops), (fun ctx x -> ctx.Element.CaretStops <- x), x)
    [<CustomOperation("FontRenderingEmSize")>] member inline this.FontRenderingEmSize ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontRenderingEmSize), (fun ctx x -> ctx.Element.FontRenderingEmSize <- x), x)
    [<CustomOperation("FontRenderingEmSize")>] member inline this.FontRenderingEmSize ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontRenderingEmSize), (fun ctx x -> ctx.Element.FontRenderingEmSize <- x), x)
    [<CustomOperation("OriginX")>] member inline this.OriginX ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OriginX), (fun ctx x -> ctx.Element.OriginX <- x), x)
    [<CustomOperation("OriginX")>] member inline this.OriginX ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OriginX), (fun ctx x -> ctx.Element.OriginX <- x), x)
    [<CustomOperation("OriginY")>] member inline this.OriginY ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OriginY), (fun ctx x -> ctx.Element.OriginY <- x), x)
    [<CustomOperation("OriginY")>] member inline this.OriginY ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OriginY), (fun ctx x -> ctx.Element.OriginY <- x), x)
    [<CustomOperation("FontUri")>] member inline this.FontUri ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontUri), (fun ctx x -> ctx.Element.FontUri <- x), x)
    [<CustomOperation("FontUri")>] member inline this.FontUri ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontUri), (fun ctx x -> ctx.Element.FontUri <- x), x)
    [<CustomOperation("StyleSimulations")>] member inline this.StyleSimulations ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Windows.Media.StyleSimulations) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StyleSimulations), (fun ctx x -> ctx.Element.StyleSimulations <- x), x)
    [<CustomOperation("StyleSimulations")>] member inline this.StyleSimulations ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StyleSimulations), (fun ctx x -> ctx.Element.StyleSimulations <- x), x)
    [<CustomOperation("IsSideways")>] member inline this.IsSideways ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSideways), (fun ctx x -> ctx.Element.IsSideways <- x), x)
    [<CustomOperation("IsSideways")>] member inline this.IsSideways ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSideways), (fun ctx x -> ctx.Element.IsSideways <- x), x)
    [<CustomOperation("BidiLevel")>] member inline this.BidiLevel ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BidiLevel), (fun ctx x -> ctx.Element.BidiLevel <- x), x)
    [<CustomOperation("BidiLevel")>] member inline this.BidiLevel ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BidiLevel), (fun ctx x -> ctx.Element.BidiLevel <- x), x)
    [<CustomOperation("DeviceFontName")>] member inline this.DeviceFontName ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DeviceFontName), (fun ctx x -> ctx.Element.DeviceFontName <- x), x)
    [<CustomOperation("DeviceFontName")>] member inline this.DeviceFontName ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DeviceFontName), (fun ctx x -> ctx.Element.DeviceFontName <- x), x)

                

type PageContentBuilder() =
    inherit FrameworkElementBuilder<System.Windows.Documents.PageContent>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("LinkTargets")>] member inline this.LinkTargets ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LinkTargets), x)
    [<CustomOperation("LinkTargets'")>] member inline this.LinkTargets' ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LinkTargets), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, x: System.Windows.Documents.FixedPage) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)

    [<CustomOperation("GetPageRootCompleted")>] member inline this.GetPageRootCompleted ([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.GetPageRootCompleted), "GetPageRootCompleted", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type AccessTextBuilder<'Element when 'Element :> System.Windows.Controls.AccessText>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontStretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextDecorationCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextEffects")>] member inline this.TextEffects ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.TextEffectCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextEffects), (fun ctx x -> ctx.Element.TextEffects <- x), x)
    [<CustomOperation("TextEffects")>] member inline this.TextEffects ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextEffects), (fun ctx x -> ctx.Element.TextEffects <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineStackingStrategy")>] member inline this.LineStackingStrategy ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.LineStackingStrategy) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineStackingStrategy), (fun ctx x -> ctx.Element.LineStackingStrategy <- x), x)
    [<CustomOperation("LineStackingStrategy")>] member inline this.LineStackingStrategy ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineStackingStrategy), (fun ctx x -> ctx.Element.LineStackingStrategy <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextTrimming")>] member inline this.TextTrimming ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextTrimming) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTrimming), (fun ctx x -> ctx.Element.TextTrimming <- x), x)
    [<CustomOperation("TextTrimming")>] member inline this.TextTrimming ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTrimming), (fun ctx x -> ctx.Element.TextTrimming <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("BaselineOffset")>] member inline this.BaselineOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BaselineOffset), (fun ctx x -> ctx.Element.BaselineOffset <- x), x)
    [<CustomOperation("BaselineOffset")>] member inline this.BaselineOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BaselineOffset), (fun ctx x -> ctx.Element.BaselineOffset <- x), x)

                

type AdornedElementPlaceholderBuilder<'Element when 'Element :> System.Windows.Controls.AdornedElementPlaceholder>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("AdornedElement")>] member inline this.AdornedElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AdornedElement), x)
    [<CustomOperation("AdornedElement'")>] member inline this.AdornedElement' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AdornedElement), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)

                

type ImageBuilder<'Element when 'Element :> System.Windows.Controls.Image>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.ImageSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.StretchDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)

    [<CustomOperation("ImageFailed")>] member inline this.ImageFailed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ImageFailed), "ImageFailed", fn)
    [<CustomOperation("DpiChanged")>] member inline this.DpiChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DpiChanged), "DpiChanged", fn)
                

type InkCanvasBuilder<'Element when 'Element :> System.Windows.Controls.InkCanvas>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Strokes")>] member inline this.Strokes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Ink.StrokeCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Strokes), (fun ctx x -> ctx.Element.Strokes <- x), x)
    [<CustomOperation("Strokes")>] member inline this.Strokes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Strokes), (fun ctx x -> ctx.Element.Strokes <- x), x)
    [<CustomOperation("Children")>] member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Children), x)
    [<CustomOperation("Children'")>] member inline this.Children' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Children), x)
    [<CustomOperation("DefaultDrawingAttributes")>] member inline this.DefaultDrawingAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Ink.DrawingAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultDrawingAttributes), (fun ctx x -> ctx.Element.DefaultDrawingAttributes <- x), x)
    [<CustomOperation("DefaultDrawingAttributes")>] member inline this.DefaultDrawingAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultDrawingAttributes), (fun ctx x -> ctx.Element.DefaultDrawingAttributes <- x), x)
    [<CustomOperation("EraserShape")>] member inline this.EraserShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Ink.StylusShape) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EraserShape), (fun ctx x -> ctx.Element.EraserShape <- x), x)
    [<CustomOperation("EraserShape")>] member inline this.EraserShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EraserShape), (fun ctx x -> ctx.Element.EraserShape <- x), x)
    [<CustomOperation("EditingMode")>] member inline this.EditingMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.InkCanvasEditingMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EditingMode), (fun ctx x -> ctx.Element.EditingMode <- x), x)
    [<CustomOperation("EditingMode")>] member inline this.EditingMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EditingMode), (fun ctx x -> ctx.Element.EditingMode <- x), x)
    [<CustomOperation("EditingModeInverted")>] member inline this.EditingModeInverted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.InkCanvasEditingMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EditingModeInverted), (fun ctx x -> ctx.Element.EditingModeInverted <- x), x)
    [<CustomOperation("EditingModeInverted")>] member inline this.EditingModeInverted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EditingModeInverted), (fun ctx x -> ctx.Element.EditingModeInverted <- x), x)
    [<CustomOperation("UseCustomCursor")>] member inline this.UseCustomCursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseCustomCursor), (fun ctx x -> ctx.Element.UseCustomCursor <- x), x)
    [<CustomOperation("UseCustomCursor")>] member inline this.UseCustomCursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseCustomCursor), (fun ctx x -> ctx.Element.UseCustomCursor <- x), x)
    [<CustomOperation("MoveEnabled")>] member inline this.MoveEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MoveEnabled), (fun ctx x -> ctx.Element.MoveEnabled <- x), x)
    [<CustomOperation("MoveEnabled")>] member inline this.MoveEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MoveEnabled), (fun ctx x -> ctx.Element.MoveEnabled <- x), x)
    [<CustomOperation("ResizeEnabled")>] member inline this.ResizeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeEnabled), (fun ctx x -> ctx.Element.ResizeEnabled <- x), x)
    [<CustomOperation("ResizeEnabled")>] member inline this.ResizeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeEnabled), (fun ctx x -> ctx.Element.ResizeEnabled <- x), x)
    [<CustomOperation("DefaultStylusPointDescription")>] member inline this.DefaultStylusPointDescription ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.StylusPointDescription) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultStylusPointDescription), (fun ctx x -> ctx.Element.DefaultStylusPointDescription <- x), x)
    [<CustomOperation("DefaultStylusPointDescription")>] member inline this.DefaultStylusPointDescription ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultStylusPointDescription), (fun ctx x -> ctx.Element.DefaultStylusPointDescription <- x), x)
    [<CustomOperation("PreferredPasteFormats")>] member inline this.PreferredPasteFormats ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IEnumerable<System.Windows.Controls.InkCanvasClipboardFormat>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreferredPasteFormats), (fun ctx x -> ctx.Element.PreferredPasteFormats <- x), x)
    [<CustomOperation("PreferredPasteFormats")>] member inline this.PreferredPasteFormats ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreferredPasteFormats), (fun ctx x -> ctx.Element.PreferredPasteFormats <- x), x)

    [<CustomOperation("StrokeCollected")>] member inline this.StrokeCollected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeCollected), "StrokeCollected", fn)
    [<CustomOperation("Gesture")>] member inline this.Gesture ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Gesture), "Gesture", fn)
    [<CustomOperation("StrokesReplaced")>] member inline this.StrokesReplaced ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokesReplaced), "StrokesReplaced", fn)
    [<CustomOperation("DefaultDrawingAttributesReplaced")>] member inline this.DefaultDrawingAttributesReplaced ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultDrawingAttributesReplaced), "DefaultDrawingAttributesReplaced", fn)
    [<CustomOperation("ActiveEditingModeChanged")>] member inline this.ActiveEditingModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ActiveEditingModeChanged), "ActiveEditingModeChanged", fn)
    [<CustomOperation("EditingModeChanged")>] member inline this.EditingModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.EditingModeChanged), "EditingModeChanged", fn)
    [<CustomOperation("EditingModeInvertedChanged")>] member inline this.EditingModeInvertedChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.EditingModeInvertedChanged), "EditingModeInvertedChanged", fn)
    [<CustomOperation("SelectionMoving")>] member inline this.SelectionMoving ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMoving), "SelectionMoving", fn)
    [<CustomOperation("SelectionMoved")>] member inline this.SelectionMoved ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMoved), "SelectionMoved", fn)
    [<CustomOperation("StrokeErasing")>] member inline this.StrokeErasing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeErasing), "StrokeErasing", fn)
    [<CustomOperation("StrokeErased")>] member inline this.StrokeErased ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeErased), "StrokeErased", fn)
    [<CustomOperation("SelectionResizing")>] member inline this.SelectionResizing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionResizing), "SelectionResizing", fn)
    [<CustomOperation("SelectionResized")>] member inline this.SelectionResized ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionResized), "SelectionResized", fn)
    [<CustomOperation("SelectionChanging")>] member inline this.SelectionChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanging), "SelectionChanging", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type ItemsPresenterBuilder<'Element when 'Element :> System.Windows.Controls.ItemsPresenter>() =
    inherit FrameworkElementBuilder<'Element>()


                

type MediaElementBuilder<'Element when 'Element :> System.Windows.Controls.MediaElement>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Clock")>] member inline this.Clock ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.MediaClock) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Clock), (fun ctx x -> ctx.Element.Clock <- x), x)
    [<CustomOperation("Clock")>] member inline this.Clock ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Clock), (fun ctx x -> ctx.Element.Clock <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.StretchDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("Volume")>] member inline this.Volume ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Volume), (fun ctx x -> ctx.Element.Volume <- x), x)
    [<CustomOperation("Volume")>] member inline this.Volume ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Volume), (fun ctx x -> ctx.Element.Volume <- x), x)
    [<CustomOperation("Balance")>] member inline this.Balance ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Balance), (fun ctx x -> ctx.Element.Balance <- x), x)
    [<CustomOperation("Balance")>] member inline this.Balance ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Balance), (fun ctx x -> ctx.Element.Balance <- x), x)
    [<CustomOperation("IsMuted")>] member inline this.IsMuted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsMuted), (fun ctx x -> ctx.Element.IsMuted <- x), x)
    [<CustomOperation("IsMuted")>] member inline this.IsMuted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsMuted), (fun ctx x -> ctx.Element.IsMuted <- x), x)
    [<CustomOperation("ScrubbingEnabled")>] member inline this.ScrubbingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrubbingEnabled), (fun ctx x -> ctx.Element.ScrubbingEnabled <- x), x)
    [<CustomOperation("ScrubbingEnabled")>] member inline this.ScrubbingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrubbingEnabled), (fun ctx x -> ctx.Element.ScrubbingEnabled <- x), x)
    [<CustomOperation("UnloadedBehavior")>] member inline this.UnloadedBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.MediaState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UnloadedBehavior), (fun ctx x -> ctx.Element.UnloadedBehavior <- x), x)
    [<CustomOperation("UnloadedBehavior")>] member inline this.UnloadedBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UnloadedBehavior), (fun ctx x -> ctx.Element.UnloadedBehavior <- x), x)
    [<CustomOperation("LoadedBehavior")>] member inline this.LoadedBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.MediaState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LoadedBehavior), (fun ctx x -> ctx.Element.LoadedBehavior <- x), x)
    [<CustomOperation("LoadedBehavior")>] member inline this.LoadedBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LoadedBehavior), (fun ctx x -> ctx.Element.LoadedBehavior <- x), x)
    [<CustomOperation("NaturalDuration")>] member inline this.NaturalDuration ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NaturalDuration), x)
    [<CustomOperation("NaturalDuration'")>] member inline this.NaturalDuration' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NaturalDuration), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("SpeedRatio")>] member inline this.SpeedRatio ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SpeedRatio), (fun ctx x -> ctx.Element.SpeedRatio <- x), x)
    [<CustomOperation("SpeedRatio")>] member inline this.SpeedRatio ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SpeedRatio), (fun ctx x -> ctx.Element.SpeedRatio <- x), x)

    [<CustomOperation("MediaFailed")>] member inline this.MediaFailed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MediaFailed), "MediaFailed", fn)
    [<CustomOperation("MediaOpened")>] member inline this.MediaOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MediaOpened), "MediaOpened", fn)
    [<CustomOperation("BufferingStarted")>] member inline this.BufferingStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BufferingStarted), "BufferingStarted", fn)
    [<CustomOperation("BufferingEnded")>] member inline this.BufferingEnded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BufferingEnded), "BufferingEnded", fn)
    [<CustomOperation("ScriptCommand")>] member inline this.ScriptCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ScriptCommand), "ScriptCommand", fn)
    [<CustomOperation("MediaEnded")>] member inline this.MediaEnded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MediaEnded), "MediaEnded", fn)
                

type TextBlockBuilder<'Element when 'Element :> System.Windows.Controls.TextBlock>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Inlines")>] member inline this.Inlines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Inlines), x)
    [<CustomOperation("Inlines'")>] member inline this.Inlines' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Inlines), x)
    [<CustomOperation("ContentStart")>] member inline this.ContentStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ContentStart), x)
    [<CustomOperation("ContentStart'")>] member inline this.ContentStart' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ContentStart), x)
    [<CustomOperation("ContentEnd")>] member inline this.ContentEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ContentEnd), x)
    [<CustomOperation("ContentEnd'")>] member inline this.ContentEnd' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ContentEnd), x)
    [<CustomOperation("Typography")>] member inline this.Typography ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Typography), x)
    [<CustomOperation("Typography'")>] member inline this.Typography' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Typography), x)
    [<CustomOperation("BaselineOffset")>] member inline this.BaselineOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BaselineOffset), (fun ctx x -> ctx.Element.BaselineOffset <- x), x)
    [<CustomOperation("BaselineOffset")>] member inline this.BaselineOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BaselineOffset), (fun ctx x -> ctx.Element.BaselineOffset <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.FontStretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextDecorationCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextEffects")>] member inline this.TextEffects ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.TextEffectCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextEffects), (fun ctx x -> ctx.Element.TextEffects <- x), x)
    [<CustomOperation("TextEffects")>] member inline this.TextEffects ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextEffects), (fun ctx x -> ctx.Element.TextEffects <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineStackingStrategy")>] member inline this.LineStackingStrategy ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.LineStackingStrategy) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineStackingStrategy), (fun ctx x -> ctx.Element.LineStackingStrategy <- x), x)
    [<CustomOperation("LineStackingStrategy")>] member inline this.LineStackingStrategy ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineStackingStrategy), (fun ctx x -> ctx.Element.LineStackingStrategy <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextTrimming")>] member inline this.TextTrimming ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextTrimming) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTrimming), (fun ctx x -> ctx.Element.TextTrimming <- x), x)
    [<CustomOperation("TextTrimming")>] member inline this.TextTrimming ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTrimming), (fun ctx x -> ctx.Element.TextTrimming <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("IsHyphenationEnabled")>] member inline this.IsHyphenationEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHyphenationEnabled), (fun ctx x -> ctx.Element.IsHyphenationEnabled <- x), x)
    [<CustomOperation("IsHyphenationEnabled")>] member inline this.IsHyphenationEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHyphenationEnabled), (fun ctx x -> ctx.Element.IsHyphenationEnabled <- x), x)

                

type ToolBarTrayBuilder<'Element when 'Element :> System.Windows.Controls.ToolBarTray>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("IsLocked")>] member inline this.IsLocked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsLocked), (fun ctx x -> ctx.Element.IsLocked <- x), x)
    [<CustomOperation("IsLocked")>] member inline this.IsLocked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsLocked), (fun ctx x -> ctx.Element.IsLocked <- x), x)
    [<CustomOperation("ToolBars")>] member inline this.ToolBars ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ToolBars), x)
    [<CustomOperation("ToolBars'")>] member inline this.ToolBars' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ToolBars), x)

                

type Viewport3DBuilder<'Element when 'Element :> System.Windows.Controls.Viewport3D>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Camera")>] member inline this.Camera ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Media3D.Camera) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Camera), (fun ctx x -> ctx.Element.Camera <- x), x)
    [<CustomOperation("Camera")>] member inline this.Camera ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Camera), (fun ctx x -> ctx.Element.Camera <- x), x)
    [<CustomOperation("Children")>] member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Children), x)
    [<CustomOperation("Children'")>] member inline this.Children' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Children), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Controls.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DocumentPageViewBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DocumentPageView>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("DocumentPaginator")>] member inline this.DocumentPaginator ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Documents.DocumentPaginator) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DocumentPaginator), (fun ctx x -> ctx.Element.DocumentPaginator <- x), x)
    [<CustomOperation("DocumentPaginator")>] member inline this.DocumentPaginator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DocumentPaginator), (fun ctx x -> ctx.Element.DocumentPaginator <- x), x)
    [<CustomOperation("DocumentPage")>] member inline this.DocumentPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DocumentPage), x)
    [<CustomOperation("DocumentPage'")>] member inline this.DocumentPage' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DocumentPage), x)
    [<CustomOperation("PageNumber")>] member inline this.PageNumber ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PageNumber), (fun ctx x -> ctx.Element.PageNumber <- x), x)
    [<CustomOperation("PageNumber")>] member inline this.PageNumber ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PageNumber), (fun ctx x -> ctx.Element.PageNumber <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.StretchDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)

    [<CustomOperation("PageConnected")>] member inline this.PageConnected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PageConnected), "PageConnected", fn)
    [<CustomOperation("PageDisconnected")>] member inline this.PageDisconnected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PageDisconnected), "PageDisconnected", fn)
                

type PopupBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.Popup>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("Child")>] member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Child), (fun ctx x -> ctx.Element.Child <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.PlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("CustomPopupPlacementCallback")>] member inline this.CustomPopupPlacementCallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.CustomPopupPlacementCallback) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CustomPopupPlacementCallback), (fun ctx x -> ctx.Element.CustomPopupPlacementCallback <- x), x)
    [<CustomOperation("CustomPopupPlacementCallback")>] member inline this.CustomPopupPlacementCallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CustomPopupPlacementCallback), (fun ctx x -> ctx.Element.CustomPopupPlacementCallback <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementRectangle")>] member inline this.PlacementRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRectangle), (fun ctx x -> ctx.Element.PlacementRectangle <- x), x)
    [<CustomOperation("PlacementRectangle")>] member inline this.PlacementRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRectangle), (fun ctx x -> ctx.Element.PlacementRectangle <- x), x)
    [<CustomOperation("PopupAnimation")>] member inline this.PopupAnimation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.PopupAnimation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PopupAnimation), (fun ctx x -> ctx.Element.PopupAnimation <- x), x)
    [<CustomOperation("PopupAnimation")>] member inline this.PopupAnimation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PopupAnimation), (fun ctx x -> ctx.Element.PopupAnimation <- x), x)
    [<CustomOperation("AllowsTransparency")>] member inline this.AllowsTransparency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsTransparency), (fun ctx x -> ctx.Element.AllowsTransparency <- x), x)
    [<CustomOperation("AllowsTransparency")>] member inline this.AllowsTransparency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsTransparency), (fun ctx x -> ctx.Element.AllowsTransparency <- x), x)

    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
                

type TickBarBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.TickBar>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("IsSelectionRangeEnabled")>] member inline this.IsSelectionRangeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelectionRangeEnabled), (fun ctx x -> ctx.Element.IsSelectionRangeEnabled <- x), x)
    [<CustomOperation("IsSelectionRangeEnabled")>] member inline this.IsSelectionRangeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelectionRangeEnabled), (fun ctx x -> ctx.Element.IsSelectionRangeEnabled <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.DoubleCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.TickBarPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("ReservedSpace")>] member inline this.ReservedSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReservedSpace), (fun ctx x -> ctx.Element.ReservedSpace <- x), x)
    [<CustomOperation("ReservedSpace")>] member inline this.ReservedSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReservedSpace), (fun ctx x -> ctx.Element.ReservedSpace <- x), x)

                

type TrackBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.Track>() =
    inherit FrameworkElementBuilder<'Element>()

    [<CustomOperation("DecreaseRepeatButton")>] member inline this.DecreaseRepeatButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.RepeatButton) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DecreaseRepeatButton), (fun ctx x -> ctx.Element.DecreaseRepeatButton <- x), x)
    [<CustomOperation("DecreaseRepeatButton")>] member inline this.DecreaseRepeatButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DecreaseRepeatButton), (fun ctx x -> ctx.Element.DecreaseRepeatButton <- x), x)
    [<CustomOperation("Thumb")>] member inline this.Thumb ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.Thumb) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Thumb), (fun ctx x -> ctx.Element.Thumb <- x), x)
    [<CustomOperation("Thumb")>] member inline this.Thumb ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Thumb), (fun ctx x -> ctx.Element.Thumb <- x), x)
    [<CustomOperation("IncreaseRepeatButton")>] member inline this.IncreaseRepeatButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.RepeatButton) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IncreaseRepeatButton), (fun ctx x -> ctx.Element.IncreaseRepeatButton <- x), x)
    [<CustomOperation("IncreaseRepeatButton")>] member inline this.IncreaseRepeatButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IncreaseRepeatButton), (fun ctx x -> ctx.Element.IncreaseRepeatButton <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)

                
            

// =======================================================================================================================

namespace Fun.SunUI.WPF

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindows =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals

    type FrameworkElement' () = 
        inherit FrameworkElementBuilder<System.Windows.FrameworkElement>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.FrameworkElement>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.FrameworkElement()), this.GetKey())

            
namespace Fun.SunUI.WPF.Controls

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindowsControls =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Controls

    type Page' () = 
        inherit PageBuilder<System.Windows.Controls.Page>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Page>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Page()), this.GetKey())

    type Control' () = 
        inherit ControlBuilder<System.Windows.Controls.Control>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Control>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Control()), this.GetKey())

    type ItemsControl' () = 
        inherit ItemsControlBuilder<System.Windows.Controls.ItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ItemsControl()), this.GetKey())

    type DataGrid' () = 
        inherit DataGridBuilder<System.Windows.Controls.DataGrid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DataGrid>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DataGrid()), this.GetKey())

    type ListBox' () = 
        inherit ListBoxBuilder<System.Windows.Controls.ListBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ListBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ListBox()), this.GetKey())

    type ListView' () = 
        inherit ListViewBuilder<System.Windows.Controls.ListView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ListView>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ListView()), this.GetKey())

    type ComboBox' () = 
        inherit ComboBoxBuilder<System.Windows.Controls.ComboBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ComboBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ComboBox()), this.GetKey())

    type TabControl' () = 
        inherit TabControlBuilder<System.Windows.Controls.TabControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.TabControl>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.TabControl()), this.GetKey())

    type ContextMenu' () = 
        inherit ContextMenuBuilder<System.Windows.Controls.ContextMenu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ContextMenu>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ContextMenu()), this.GetKey())

    type Menu' () = 
        inherit MenuBuilder<System.Windows.Controls.Menu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Menu>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Menu()), this.GetKey())

    type HeaderedItemsControl' () = 
        inherit HeaderedItemsControlBuilder<System.Windows.Controls.HeaderedItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.HeaderedItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.HeaderedItemsControl()), this.GetKey())

    type MenuItem' () = 
        inherit MenuItemBuilder<System.Windows.Controls.MenuItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.MenuItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.MenuItem()), this.GetKey())

    type ToolBar' () = 
        inherit ToolBarBuilder<System.Windows.Controls.ToolBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ToolBar>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ToolBar()), this.GetKey())

    type TreeViewItem' () = 
        inherit TreeViewItemBuilder<System.Windows.Controls.TreeViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.TreeViewItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.TreeViewItem()), this.GetKey())

    type TreeView' () = 
        inherit TreeViewBuilder<System.Windows.Controls.TreeView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.TreeView>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.TreeView()), this.GetKey())

    type TextBox' () = 
        inherit TextBoxBuilder<System.Windows.Controls.TextBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.TextBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.TextBox()), this.GetKey())

    type RichTextBox' () = 
        inherit RichTextBoxBuilder<System.Windows.Controls.RichTextBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.RichTextBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.RichTextBox()), this.GetKey())

    type DocumentViewer' () = 
        inherit DocumentViewerBuilder<System.Windows.Controls.DocumentViewer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DocumentViewer>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DocumentViewer()), this.GetKey())

    type FlowDocumentPageViewer' () = 
        inherit FlowDocumentPageViewerBuilder<System.Windows.Controls.FlowDocumentPageViewer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.FlowDocumentPageViewer>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.FlowDocumentPageViewer()), this.GetKey())

    type GridSplitter' () = 
        inherit GridSplitterBuilder<System.Windows.Controls.GridSplitter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.GridSplitter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.GridSplitter()), this.GetKey())

    type ProgressBar' () = 
        inherit ProgressBarBuilder<System.Windows.Controls.ProgressBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ProgressBar>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ProgressBar()), this.GetKey())

    type Slider' () = 
        inherit SliderBuilder<System.Windows.Controls.Slider>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Slider>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Slider()), this.GetKey())

    type Calendar' () = 
        inherit CalendarBuilder<System.Windows.Controls.Calendar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Calendar>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Calendar()), this.GetKey())

    type DataGridRow' () = 
        inherit DataGridRowBuilder<System.Windows.Controls.DataGridRow>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DataGridRow>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DataGridRow()), this.GetKey())

    type DatePicker' () = 
        inherit DatePickerBuilder<System.Windows.Controls.DatePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DatePicker>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DatePicker()), this.GetKey())

    type FlowDocumentReader' () = 
        inherit FlowDocumentReaderBuilder<System.Windows.Controls.FlowDocumentReader>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.FlowDocumentReader>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.FlowDocumentReader()), this.GetKey())

    type FlowDocumentScrollViewer' () = 
        inherit FlowDocumentScrollViewerBuilder<System.Windows.Controls.FlowDocumentScrollViewer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.FlowDocumentScrollViewer>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.FlowDocumentScrollViewer()), this.GetKey())

    type PasswordBox' () = 
        inherit PasswordBoxBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.PasswordBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.PasswordBox()), this.GetKey())

    type Separator' () = 
        inherit SeparatorBuilder<System.Windows.Controls.Separator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Separator>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Separator()), this.GetKey())

    type WebBrowser' () = 
        inherit WebBrowserBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WebBrowser>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.WebBrowser()), this.GetKey())

    type Decorator' () = 
        inherit DecoratorBuilder<System.Windows.Controls.Decorator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Decorator>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Decorator()), this.GetKey())

    type Border' () = 
        inherit BorderBuilder<System.Windows.Controls.Border>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Border>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Border()), this.GetKey())

    type InkPresenter' () = 
        inherit InkPresenterBuilder<System.Windows.Controls.InkPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.InkPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.InkPresenter()), this.GetKey())

    type Viewbox' () = 
        inherit ViewboxBuilder<System.Windows.Controls.Viewbox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Viewbox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Viewbox()), this.GetKey())

    type GridViewHeaderRowPresenter' () = 
        inherit GridViewHeaderRowPresenterBuilder<System.Windows.Controls.GridViewHeaderRowPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.GridViewHeaderRowPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.GridViewHeaderRowPresenter()), this.GetKey())

    type GridViewRowPresenter' () = 
        inherit GridViewRowPresenterBuilder<System.Windows.Controls.GridViewRowPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.GridViewRowPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.GridViewRowPresenter()), this.GetKey())

    type ContentPresenter' () = 
        inherit ContentPresenterBuilder<System.Windows.Controls.ContentPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ContentPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ContentPresenter()), this.GetKey())

    type ScrollContentPresenter' () = 
        inherit ScrollContentPresenterBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollContentPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ScrollContentPresenter()), this.GetKey())

    type AccessText' () = 
        inherit AccessTextBuilder<System.Windows.Controls.AccessText>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.AccessText>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.AccessText()), this.GetKey())

    type AdornedElementPlaceholder' () = 
        inherit AdornedElementPlaceholderBuilder<System.Windows.Controls.AdornedElementPlaceholder>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.AdornedElementPlaceholder>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.AdornedElementPlaceholder()), this.GetKey())

    type Image' () = 
        inherit ImageBuilder<System.Windows.Controls.Image>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Image>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Image()), this.GetKey())

    type InkCanvas' () = 
        inherit InkCanvasBuilder<System.Windows.Controls.InkCanvas>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.InkCanvas>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.InkCanvas()), this.GetKey())

    type ItemsPresenter' () = 
        inherit ItemsPresenterBuilder<System.Windows.Controls.ItemsPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ItemsPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ItemsPresenter()), this.GetKey())

    type MediaElement' () = 
        inherit MediaElementBuilder<System.Windows.Controls.MediaElement>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.MediaElement>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.MediaElement()), this.GetKey())

    type TextBlock' () = 
        inherit TextBlockBuilder<System.Windows.Controls.TextBlock>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.TextBlock>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.TextBlock()), this.GetKey())

    type ToolBarTray' () = 
        inherit ToolBarTrayBuilder<System.Windows.Controls.ToolBarTray>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ToolBarTray>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ToolBarTray()), this.GetKey())

    type Viewport3D' () = 
        inherit Viewport3DBuilder<System.Windows.Controls.Viewport3D>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Viewport3D>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Viewport3D()), this.GetKey())

            
namespace Fun.SunUI.WPF.Navigation

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindowsNavigation =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Navigation

    type PageFunction'<'T> () = 
        inherit PageFunctionBuilder<System.Windows.Navigation.PageFunction<'T>, 'T>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Navigation.PageFunction<'T>>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Navigation.PageFunction<'T>()), this.GetKey())

            
namespace Fun.SunUI.WPF.Controls.Primitives

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindowsControlsPrimitives =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Controls.Primitives

    type DataGridCellsPresenter' () = 
        inherit DataGridCellsPresenterBuilder<System.Windows.Controls.Primitives.DataGridCellsPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DataGridCellsPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DataGridCellsPresenter()), this.GetKey())

    type DataGridColumnHeadersPresenter' () = 
        inherit DataGridColumnHeadersPresenterBuilder<System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter()), this.GetKey())

    type StatusBar' () = 
        inherit StatusBarBuilder<System.Windows.Controls.Primitives.StatusBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.StatusBar>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.StatusBar()), this.GetKey())

    type DatePickerTextBox' () = 
        inherit DatePickerTextBoxBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DatePickerTextBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DatePickerTextBox()), this.GetKey())

    type Thumb' () = 
        inherit ThumbBuilder<System.Windows.Controls.Primitives.Thumb>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.Thumb>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.Thumb()), this.GetKey())

    type ScrollBar' () = 
        inherit ScrollBarBuilder<System.Windows.Controls.Primitives.ScrollBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.ScrollBar>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.ScrollBar()), this.GetKey())

    type CalendarItem' () = 
        inherit CalendarItemBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.CalendarItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.CalendarItem()), this.GetKey())

    type ResizeGrip' () = 
        inherit ResizeGripBuilder<System.Windows.Controls.Primitives.ResizeGrip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.ResizeGrip>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.ResizeGrip()), this.GetKey())

    type BulletDecorator' () = 
        inherit BulletDecoratorBuilder<System.Windows.Controls.Primitives.BulletDecorator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.BulletDecorator>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.BulletDecorator()), this.GetKey())

    type DataGridDetailsPresenter' () = 
        inherit DataGridDetailsPresenterBuilder<System.Windows.Controls.Primitives.DataGridDetailsPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DataGridDetailsPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DataGridDetailsPresenter()), this.GetKey())

    type DocumentPageView' () = 
        inherit DocumentPageViewBuilder<System.Windows.Controls.Primitives.DocumentPageView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DocumentPageView>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DocumentPageView()), this.GetKey())

    type Popup' () = 
        inherit PopupBuilder<System.Windows.Controls.Primitives.Popup>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.Popup>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.Popup()), this.GetKey())

    type TickBar' () = 
        inherit TickBarBuilder<System.Windows.Controls.Primitives.TickBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.TickBar>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.TickBar()), this.GetKey())

    type Track' () = 
        inherit TrackBuilder<System.Windows.Controls.Primitives.Track>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.Track>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.Track()), this.GetKey())

            
namespace Fun.SunUI.WPF.Interop

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindowsInterop =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Interop


            
namespace Fun.SunUI.WPF.Shapes

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindowsShapes =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Shapes

    type Ellipse' () = 
        inherit EllipseBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Ellipse>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Shapes.Ellipse()), this.GetKey())

    type Line' () = 
        inherit LineBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Line>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Shapes.Line()), this.GetKey())

    type Path' () = 
        inherit PathBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Path>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Shapes.Path()), this.GetKey())

    type Polygon' () = 
        inherit PolygonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polygon>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Shapes.Polygon()), this.GetKey())

    type Polyline' () = 
        inherit PolylineBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Polyline>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Shapes.Polyline()), this.GetKey())

    type Rectangle' () = 
        inherit RectangleBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Shapes.Rectangle>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Shapes.Rectangle()), this.GetKey())

            
namespace Fun.SunUI.WPF.Documents

[<AutoOpen>]
module WPFElementBuilderDslCE_SystemWindowsDocuments =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Documents

    type AdornerDecorator' () = 
        inherit AdornerDecoratorBuilder<System.Windows.Documents.AdornerDecorator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.AdornerDecorator>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Documents.AdornerDecorator()), this.GetKey())

    type DocumentReference' () = 
        inherit DocumentReferenceBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.DocumentReference>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Documents.DocumentReference()), this.GetKey())

    type FixedPage' () = 
        inherit FixedPageBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.FixedPage>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Documents.FixedPage()), this.GetKey())

    type Glyphs' () = 
        inherit GlyphsBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.Glyphs>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Documents.Glyphs()), this.GetKey())

    type PageContent' () = 
        inherit PageContentBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Documents.PageContent>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Documents.PageContent()), this.GetKey())

            