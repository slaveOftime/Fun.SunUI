namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ContentControlBuilder<'Element when 'Element :> System.Windows.Controls.ContentControl>() =
    inherit WPFContentControlBuilder<'Element>()

    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentStringFormat")>] member inline this.ContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentStringFormat), (fun ctx x -> ctx.Element.ContentStringFormat <- x), x)
    [<CustomOperation("ContentStringFormat")>] member inline this.ContentStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentStringFormat), (fun ctx x -> ctx.Element.ContentStringFormat <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ButtonBaseBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.ButtonBase>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandTarget")>] member inline this.CommandTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.IInputElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandTarget), (fun ctx x -> ctx.Element.CommandTarget <- x), x)
    [<CustomOperation("CommandTarget")>] member inline this.CommandTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandTarget), (fun ctx x -> ctx.Element.CommandTarget <- x), x)
    [<CustomOperation("ClickMode")>] member inline this.ClickMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ClickMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClickMode), (fun ctx x -> ctx.Element.ClickMode <- x), x)
    [<CustomOperation("ClickMode")>] member inline this.ClickMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClickMode), (fun ctx x -> ctx.Element.ClickMode <- x), x)

                

type ToggleButtonBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.ToggleButton>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Boolean>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsThreeState")>] member inline this.IsThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsThreeState), (fun ctx x -> ctx.Element.IsThreeState <- x), x)
    [<CustomOperation("IsThreeState")>] member inline this.IsThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsThreeState), (fun ctx x -> ctx.Element.IsThreeState <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type CheckBoxBuilder<'Element when 'Element :> System.Windows.Controls.CheckBox>() =
    inherit Primitives.ToggleButtonBuilder<'Element>()


                

type RadioButtonBuilder<'Element when 'Element :> System.Windows.Controls.RadioButton>() =
    inherit Primitives.ToggleButtonBuilder<'Element>()

    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)

                

type ButtonBuilder<'Element when 'Element :> System.Windows.Controls.Button>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("IsDefault")>] member inline this.IsDefault ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefault), (fun ctx x -> ctx.Element.IsDefault <- x), x)
    [<CustomOperation("IsDefault")>] member inline this.IsDefault ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefault), (fun ctx x -> ctx.Element.IsDefault <- x), x)
    [<CustomOperation("IsCancel")>] member inline this.IsCancel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCancel), (fun ctx x -> ctx.Element.IsCancel <- x), x)
    [<CustomOperation("IsCancel")>] member inline this.IsCancel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCancel), (fun ctx x -> ctx.Element.IsCancel <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type CalendarButtonBuilder() =
    inherit ButtonBuilder<System.Windows.Controls.Primitives.CalendarButton>()


                

type CalendarDayButtonBuilder() =
    inherit ButtonBuilder<System.Windows.Controls.Primitives.CalendarDayButton>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type GridViewColumnHeaderBuilder<'Element when 'Element :> System.Windows.Controls.GridViewColumnHeader>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("Column")>] member inline this.Column ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Column), x)
    [<CustomOperation("Column'")>] member inline this.Column' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Column), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DataGridColumnHeaderBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DataGridColumnHeader>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("Column")>] member inline this.Column ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Column), x)
    [<CustomOperation("Column'")>] member inline this.Column' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Column), x)
    [<CustomOperation("SeparatorBrush")>] member inline this.SeparatorBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorBrush), (fun ctx x -> ctx.Element.SeparatorBrush <- x), x)
    [<CustomOperation("SeparatorBrush")>] member inline this.SeparatorBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorBrush), (fun ctx x -> ctx.Element.SeparatorBrush <- x), x)
    [<CustomOperation("SeparatorVisibility")>] member inline this.SeparatorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Visibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorVisibility), (fun ctx x -> ctx.Element.SeparatorVisibility <- x), x)
    [<CustomOperation("SeparatorVisibility")>] member inline this.SeparatorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorVisibility), (fun ctx x -> ctx.Element.SeparatorVisibility <- x), x)
    [<CustomOperation("SortDirection")>] member inline this.SortDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SortDirection), x)
    [<CustomOperation("SortDirection'")>] member inline this.SortDirection' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SortDirection), x)

                

type DataGridRowHeaderBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DataGridRowHeader>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("SeparatorBrush")>] member inline this.SeparatorBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorBrush), (fun ctx x -> ctx.Element.SeparatorBrush <- x), x)
    [<CustomOperation("SeparatorBrush")>] member inline this.SeparatorBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorBrush), (fun ctx x -> ctx.Element.SeparatorBrush <- x), x)
    [<CustomOperation("SeparatorVisibility")>] member inline this.SeparatorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Visibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorVisibility), (fun ctx x -> ctx.Element.SeparatorVisibility <- x), x)
    [<CustomOperation("SeparatorVisibility")>] member inline this.SeparatorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorVisibility), (fun ctx x -> ctx.Element.SeparatorVisibility <- x), x)

                

type RepeatButtonBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.RepeatButton>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Delay), (fun ctx x -> ctx.Element.Delay <- x), x)
    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Delay), (fun ctx x -> ctx.Element.Delay <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type WindowBuilder<'Element when 'Element :> System.Windows.Window>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("TaskbarItemInfo")>] member inline this.TaskbarItemInfo ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Shell.TaskbarItemInfo) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TaskbarItemInfo), (fun ctx x -> ctx.Element.TaskbarItemInfo <- x), x)
    [<CustomOperation("TaskbarItemInfo")>] member inline this.TaskbarItemInfo ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TaskbarItemInfo), (fun ctx x -> ctx.Element.TaskbarItemInfo <- x), x)
    [<CustomOperation("AllowsTransparency")>] member inline this.AllowsTransparency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsTransparency), (fun ctx x -> ctx.Element.AllowsTransparency <- x), x)
    [<CustomOperation("AllowsTransparency")>] member inline this.AllowsTransparency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowsTransparency), (fun ctx x -> ctx.Element.AllowsTransparency <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.ImageSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("SizeToContent")>] member inline this.SizeToContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.SizeToContent) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeToContent), (fun ctx x -> ctx.Element.SizeToContent <- x), x)
    [<CustomOperation("SizeToContent")>] member inline this.SizeToContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SizeToContent), (fun ctx x -> ctx.Element.SizeToContent <- x), x)
    [<CustomOperation("Top")>] member inline this.Top ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), x)
    [<CustomOperation("Top")>] member inline this.Top ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Top), (fun ctx x -> ctx.Element.Top <- x), x)
    [<CustomOperation("Left")>] member inline this.Left ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), x)
    [<CustomOperation("Left")>] member inline this.Left ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Left), (fun ctx x -> ctx.Element.Left <- x), x)
    [<CustomOperation("RestoreBounds")>] member inline this.RestoreBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RestoreBounds), x)
    [<CustomOperation("RestoreBounds'")>] member inline this.RestoreBounds' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RestoreBounds), x)
    [<CustomOperation("WindowStartupLocation")>] member inline this.WindowStartupLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.WindowStartupLocation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowStartupLocation), (fun ctx x -> ctx.Element.WindowStartupLocation <- x), x)
    [<CustomOperation("WindowStartupLocation")>] member inline this.WindowStartupLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowStartupLocation), (fun ctx x -> ctx.Element.WindowStartupLocation <- x), x)
    [<CustomOperation("ShowInTaskbar")>] member inline this.ShowInTaskbar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowInTaskbar), (fun ctx x -> ctx.Element.ShowInTaskbar <- x), x)
    [<CustomOperation("ShowInTaskbar")>] member inline this.ShowInTaskbar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowInTaskbar), (fun ctx x -> ctx.Element.ShowInTaskbar <- x), x)
    [<CustomOperation("Owner")>] member inline this.Owner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Window) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Owner), (fun ctx x -> ctx.Element.Owner <- x), x)
    [<CustomOperation("Owner")>] member inline this.Owner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Owner), (fun ctx x -> ctx.Element.Owner <- x), x)
    [<CustomOperation("OwnedWindows")>] member inline this.OwnedWindows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.OwnedWindows), x)
    [<CustomOperation("OwnedWindows'")>] member inline this.OwnedWindows' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.OwnedWindows), x)
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Boolean>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("WindowStyle")>] member inline this.WindowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.WindowStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowStyle), (fun ctx x -> ctx.Element.WindowStyle <- x), x)
    [<CustomOperation("WindowStyle")>] member inline this.WindowStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowStyle), (fun ctx x -> ctx.Element.WindowStyle <- x), x)
    [<CustomOperation("WindowState")>] member inline this.WindowState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.WindowState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowState), (fun ctx x -> ctx.Element.WindowState <- x), x)
    [<CustomOperation("WindowState")>] member inline this.WindowState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowState), (fun ctx x -> ctx.Element.WindowState <- x), x)
    [<CustomOperation("ResizeMode")>] member inline this.ResizeMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.ResizeMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeMode), (fun ctx x -> ctx.Element.ResizeMode <- x), x)
    [<CustomOperation("ResizeMode")>] member inline this.ResizeMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeMode), (fun ctx x -> ctx.Element.ResizeMode <- x), x)
    [<CustomOperation("Topmost")>] member inline this.Topmost ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Topmost), (fun ctx x -> ctx.Element.Topmost <- x), x)
    [<CustomOperation("Topmost")>] member inline this.Topmost ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Topmost), (fun ctx x -> ctx.Element.Topmost <- x), x)
    [<CustomOperation("ShowActivated")>] member inline this.ShowActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowActivated), (fun ctx x -> ctx.Element.ShowActivated <- x), x)
    [<CustomOperation("ShowActivated")>] member inline this.ShowActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowActivated), (fun ctx x -> ctx.Element.ShowActivated <- x), x)

    [<CustomOperation("SourceInitialized")>] member inline this.SourceInitialized ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SourceInitialized), "SourceInitialized", fn)
    [<CustomOperation("Activated")>] member inline this.Activated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Activated), "Activated", fn)
    [<CustomOperation("Deactivated")>] member inline this.Deactivated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Deactivated), "Deactivated", fn)
    [<CustomOperation("StateChanged")>] member inline this.StateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StateChanged), "StateChanged", fn)
    [<CustomOperation("LocationChanged")>] member inline this.LocationChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LocationChanged), "LocationChanged", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("ContentRendered")>] member inline this.ContentRendered ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentRendered), "ContentRendered", fn)
                
            
namespace rec Fun.SunUI.WPF.DslInternals.Navigation
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type NavigationWindowBuilder<'Element when 'Element :> System.Windows.Navigation.NavigationWindow>() =
    inherit WindowBuilder<'Element>()

    [<CustomOperation("SandboxExternalContent")>] member inline this.SandboxExternalContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SandboxExternalContent), (fun ctx x -> ctx.Element.SandboxExternalContent <- x), x)
    [<CustomOperation("SandboxExternalContent")>] member inline this.SandboxExternalContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SandboxExternalContent), (fun ctx x -> ctx.Element.SandboxExternalContent <- x), x)
    [<CustomOperation("NavigationService")>] member inline this.NavigationService ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NavigationService), x)
    [<CustomOperation("NavigationService'")>] member inline this.NavigationService' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NavigationService), x)
    [<CustomOperation("BackStack")>] member inline this.BackStack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BackStack), x)
    [<CustomOperation("BackStack'")>] member inline this.BackStack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BackStack), x)
    [<CustomOperation("ForwardStack")>] member inline this.ForwardStack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ForwardStack), x)
    [<CustomOperation("ForwardStack'")>] member inline this.ForwardStack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ForwardStack), x)
    [<CustomOperation("ShowsNavigationUI")>] member inline this.ShowsNavigationUI ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsNavigationUI), (fun ctx x -> ctx.Element.ShowsNavigationUI <- x), x)
    [<CustomOperation("ShowsNavigationUI")>] member inline this.ShowsNavigationUI ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsNavigationUI), (fun ctx x -> ctx.Element.ShowsNavigationUI <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("CurrentSource")>] member inline this.CurrentSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentSource), x)
    [<CustomOperation("CurrentSource'")>] member inline this.CurrentSource' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentSource), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ListBoxItemBuilder<'Element when 'Element :> System.Windows.Controls.ListBoxItem>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                

type ComboBoxItemBuilder<'Element when 'Element :> System.Windows.Controls.ComboBoxItem>() =
    inherit ListBoxItemBuilder<'Element>()


                

type ListViewItemBuilder<'Element when 'Element :> System.Windows.Controls.ListViewItem>() =
    inherit ListBoxItemBuilder<'Element>()


                

type HeaderedContentControlBuilder<'Element when 'Element :> System.Windows.Controls.HeaderedContentControl>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("HeaderStringFormat")>] member inline this.HeaderStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderStringFormat), (fun ctx x -> ctx.Element.HeaderStringFormat <- x), x)
    [<CustomOperation("HeaderStringFormat")>] member inline this.HeaderStringFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderStringFormat), (fun ctx x -> ctx.Element.HeaderStringFormat <- x), x)

                

type ExpanderBuilder<'Element when 'Element :> System.Windows.Controls.Expander>() =
    inherit HeaderedContentControlBuilder<'Element>()

    [<CustomOperation("ExpandDirection")>] member inline this.ExpandDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ExpandDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandDirection), (fun ctx x -> ctx.Element.ExpandDirection <- x), x)
    [<CustomOperation("ExpandDirection")>] member inline this.ExpandDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandDirection), (fun ctx x -> ctx.Element.ExpandDirection <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)

                

type GroupBoxBuilder<'Element when 'Element :> System.Windows.Controls.GroupBox>() =
    inherit HeaderedContentControlBuilder<'Element>()


                

type TabItemBuilder<'Element when 'Element :> System.Windows.Controls.TabItem>() =
    inherit HeaderedContentControlBuilder<'Element>()

    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                

type DataGridCellBuilder<'Element when 'Element :> System.Windows.Controls.DataGridCell>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Column")>] member inline this.Column ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Column), x)
    [<CustomOperation("Column'")>] member inline this.Column' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Column), x)
    [<CustomOperation("IsEditing")>] member inline this.IsEditing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEditing), (fun ctx x -> ctx.Element.IsEditing <- x), x)
    [<CustomOperation("IsEditing")>] member inline this.IsEditing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEditing), (fun ctx x -> ctx.Element.IsEditing <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                

type FrameBuilder<'Element when 'Element :> System.Windows.Controls.Frame>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("NavigationUIVisibility")>] member inline this.NavigationUIVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Navigation.NavigationUIVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigationUIVisibility), (fun ctx x -> ctx.Element.NavigationUIVisibility <- x), x)
    [<CustomOperation("NavigationUIVisibility")>] member inline this.NavigationUIVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NavigationUIVisibility), (fun ctx x -> ctx.Element.NavigationUIVisibility <- x), x)
    [<CustomOperation("SandboxExternalContent")>] member inline this.SandboxExternalContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SandboxExternalContent), (fun ctx x -> ctx.Element.SandboxExternalContent <- x), x)
    [<CustomOperation("SandboxExternalContent")>] member inline this.SandboxExternalContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SandboxExternalContent), (fun ctx x -> ctx.Element.SandboxExternalContent <- x), x)
    [<CustomOperation("JournalOwnership")>] member inline this.JournalOwnership ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Navigation.JournalOwnership) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.JournalOwnership), (fun ctx x -> ctx.Element.JournalOwnership <- x), x)
    [<CustomOperation("JournalOwnership")>] member inline this.JournalOwnership ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.JournalOwnership), (fun ctx x -> ctx.Element.JournalOwnership <- x), x)
    [<CustomOperation("NavigationService")>] member inline this.NavigationService ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NavigationService), x)
    [<CustomOperation("NavigationService'")>] member inline this.NavigationService' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NavigationService), x)
    [<CustomOperation("CurrentSource")>] member inline this.CurrentSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentSource), x)
    [<CustomOperation("CurrentSource'")>] member inline this.CurrentSource' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentSource), x)
    [<CustomOperation("BackStack")>] member inline this.BackStack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BackStack), x)
    [<CustomOperation("BackStack'")>] member inline this.BackStack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BackStack), x)
    [<CustomOperation("ForwardStack")>] member inline this.ForwardStack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ForwardStack), x)
    [<CustomOperation("ForwardStack'")>] member inline this.ForwardStack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ForwardStack), x)

    [<CustomOperation("ContentRendered")>] member inline this.ContentRendered ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentRendered), "ContentRendered", fn)
                

type GroupItemBuilder<'Element when 'Element :> System.Windows.Controls.GroupItem>() =
    inherit ContentControlBuilder<'Element>()


                

type LabelBuilder<'Element when 'Element :> System.Windows.Controls.Label>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Target")>] member inline this.Target ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Target), (fun ctx x -> ctx.Element.Target <- x), x)
    [<CustomOperation("Target")>] member inline this.Target ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Target), (fun ctx x -> ctx.Element.Target <- x), x)

                

type ScrollViewerBuilder<'Element when 'Element :> System.Windows.Controls.ScrollViewer>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("CanContentScroll")>] member inline this.CanContentScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanContentScroll), (fun ctx x -> ctx.Element.CanContentScroll <- x), x)
    [<CustomOperation("CanContentScroll")>] member inline this.CanContentScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanContentScroll), (fun ctx x -> ctx.Element.CanContentScroll <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("IsDeferredScrollingEnabled")>] member inline this.IsDeferredScrollingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDeferredScrollingEnabled), (fun ctx x -> ctx.Element.IsDeferredScrollingEnabled <- x), x)
    [<CustomOperation("IsDeferredScrollingEnabled")>] member inline this.IsDeferredScrollingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDeferredScrollingEnabled), (fun ctx x -> ctx.Element.IsDeferredScrollingEnabled <- x), x)
    [<CustomOperation("PanningMode")>] member inline this.PanningMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.PanningMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanningMode), (fun ctx x -> ctx.Element.PanningMode <- x), x)
    [<CustomOperation("PanningMode")>] member inline this.PanningMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanningMode), (fun ctx x -> ctx.Element.PanningMode <- x), x)
    [<CustomOperation("PanningDeceleration")>] member inline this.PanningDeceleration ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanningDeceleration), (fun ctx x -> ctx.Element.PanningDeceleration <- x), x)
    [<CustomOperation("PanningDeceleration")>] member inline this.PanningDeceleration ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanningDeceleration), (fun ctx x -> ctx.Element.PanningDeceleration <- x), x)
    [<CustomOperation("PanningRatio")>] member inline this.PanningRatio ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanningRatio), (fun ctx x -> ctx.Element.PanningRatio <- x), x)
    [<CustomOperation("PanningRatio")>] member inline this.PanningRatio ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanningRatio), (fun ctx x -> ctx.Element.PanningRatio <- x), x)

                

type ToolTipBuilder<'Element when 'Element :> System.Windows.Controls.ToolTip>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("HasDropShadow")>] member inline this.HasDropShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasDropShadow), (fun ctx x -> ctx.Element.HasDropShadow <- x), x)
    [<CustomOperation("HasDropShadow")>] member inline this.HasDropShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasDropShadow), (fun ctx x -> ctx.Element.HasDropShadow <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementRectangle")>] member inline this.PlacementRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRectangle), (fun ctx x -> ctx.Element.PlacementRectangle <- x), x)
    [<CustomOperation("PlacementRectangle")>] member inline this.PlacementRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRectangle), (fun ctx x -> ctx.Element.PlacementRectangle <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.PlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("CustomPopupPlacementCallback")>] member inline this.CustomPopupPlacementCallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Primitives.CustomPopupPlacementCallback) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CustomPopupPlacementCallback), (fun ctx x -> ctx.Element.CustomPopupPlacementCallback <- x), x)
    [<CustomOperation("CustomPopupPlacementCallback")>] member inline this.CustomPopupPlacementCallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CustomPopupPlacementCallback), (fun ctx x -> ctx.Element.CustomPopupPlacementCallback <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("ShowsToolTipOnKeyboardFocus")>] member inline this.ShowsToolTipOnKeyboardFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Boolean>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsToolTipOnKeyboardFocus), (fun ctx x -> ctx.Element.ShowsToolTipOnKeyboardFocus <- x), x)
    [<CustomOperation("ShowsToolTipOnKeyboardFocus")>] member inline this.ShowsToolTipOnKeyboardFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsToolTipOnKeyboardFocus), (fun ctx x -> ctx.Element.ShowsToolTipOnKeyboardFocus <- x), x)

                

type UserControlBuilder<'Element when 'Element :> System.Windows.Controls.UserControl>() =
    inherit ContentControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type StatusBarItemBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.StatusBarItem>() =
    inherit ContentControlBuilder<'Element>()


                
            

// =======================================================================================================================

namespace Fun.SunUI.WPF

[<AutoOpen>]
module WPFContentControlBuilderDslCE_SystemWindowsControls =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals

    type ContentControl' () = 
        inherit ContentControlBuilder<System.Windows.Controls.ContentControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ContentControl>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ContentControl()), this.GetKey())

    type CheckBox' () = 
        inherit CheckBoxBuilder<System.Windows.Controls.CheckBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.CheckBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.CheckBox()), this.GetKey())

    type RadioButton' () = 
        inherit RadioButtonBuilder<System.Windows.Controls.RadioButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.RadioButton>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.RadioButton()), this.GetKey())

    type Button' () = 
        inherit ButtonBuilder<System.Windows.Controls.Button>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Button>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Button()), this.GetKey())

    type GridViewColumnHeader' () = 
        inherit GridViewColumnHeaderBuilder<System.Windows.Controls.GridViewColumnHeader>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.GridViewColumnHeader>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.GridViewColumnHeader()), this.GetKey())

    type ListBoxItem' () = 
        inherit ListBoxItemBuilder<System.Windows.Controls.ListBoxItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ListBoxItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ListBoxItem()), this.GetKey())

    type ComboBoxItem' () = 
        inherit ComboBoxItemBuilder<System.Windows.Controls.ComboBoxItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ComboBoxItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ComboBoxItem()), this.GetKey())

    type ListViewItem' () = 
        inherit ListViewItemBuilder<System.Windows.Controls.ListViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ListViewItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ListViewItem()), this.GetKey())

    type HeaderedContentControl' () = 
        inherit HeaderedContentControlBuilder<System.Windows.Controls.HeaderedContentControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.HeaderedContentControl>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.HeaderedContentControl()), this.GetKey())

    type Expander' () = 
        inherit ExpanderBuilder<System.Windows.Controls.Expander>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Expander>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Expander()), this.GetKey())

    type GroupBox' () = 
        inherit GroupBoxBuilder<System.Windows.Controls.GroupBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.GroupBox>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.GroupBox()), this.GetKey())

    type TabItem' () = 
        inherit TabItemBuilder<System.Windows.Controls.TabItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.TabItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.TabItem()), this.GetKey())

    type DataGridCell' () = 
        inherit DataGridCellBuilder<System.Windows.Controls.DataGridCell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DataGridCell>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DataGridCell()), this.GetKey())

    type Frame' () = 
        inherit FrameBuilder<System.Windows.Controls.Frame>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Frame>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Frame()), this.GetKey())

    type GroupItem' () = 
        inherit GroupItemBuilder<System.Windows.Controls.GroupItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.GroupItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.GroupItem()), this.GetKey())

    type Label' () = 
        inherit LabelBuilder<System.Windows.Controls.Label>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Label>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Label()), this.GetKey())

    type ScrollViewer' () = 
        inherit ScrollViewerBuilder<System.Windows.Controls.ScrollViewer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ScrollViewer>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ScrollViewer()), this.GetKey())

    type ToolTip' () = 
        inherit ToolTipBuilder<System.Windows.Controls.ToolTip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.ToolTip>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.ToolTip()), this.GetKey())

    type UserControl' () = 
        inherit UserControlBuilder<System.Windows.Controls.UserControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.UserControl>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.UserControl()), this.GetKey())

            
namespace Fun.SunUI.WPF.Primitives

[<AutoOpen>]
module WPFContentControlBuilderDslCE_SystemWindowsControlsPrimitives =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Primitives

    type ToggleButton' () = 
        inherit ToggleButtonBuilder<System.Windows.Controls.Primitives.ToggleButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.ToggleButton>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.ToggleButton()), this.GetKey())

    type CalendarButton' () = 
        inherit CalendarButtonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.CalendarButton>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.CalendarButton()), this.GetKey())

    type CalendarDayButton' () = 
        inherit CalendarDayButtonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.CalendarDayButton>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.CalendarDayButton()), this.GetKey())

    type DataGridColumnHeader' () = 
        inherit DataGridColumnHeaderBuilder<System.Windows.Controls.Primitives.DataGridColumnHeader>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DataGridColumnHeader>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DataGridColumnHeader()), this.GetKey())

    type DataGridRowHeader' () = 
        inherit DataGridRowHeaderBuilder<System.Windows.Controls.Primitives.DataGridRowHeader>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DataGridRowHeader>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DataGridRowHeader()), this.GetKey())

    type RepeatButton' () = 
        inherit RepeatButtonBuilder<System.Windows.Controls.Primitives.RepeatButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.RepeatButton>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.RepeatButton()), this.GetKey())

    type StatusBarItem' () = 
        inherit StatusBarItemBuilder<System.Windows.Controls.Primitives.StatusBarItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.StatusBarItem>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.StatusBarItem()), this.GetKey())

            
namespace Fun.SunUI.WPF

[<AutoOpen>]
module WPFContentControlBuilderDslCE_SystemWindows =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals

    type Window' () = 
        inherit WindowBuilder<System.Windows.Window>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Window>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Window()), this.GetKey())

            
namespace Fun.SunUI.WPF.Navigation

[<AutoOpen>]
module WPFContentControlBuilderDslCE_SystemWindowsNavigation =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Navigation

    type NavigationWindow' () = 
        inherit NavigationWindowBuilder<System.Windows.Navigation.NavigationWindow>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Navigation.NavigationWindow>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Navigation.NavigationWindow()), this.GetKey())

            