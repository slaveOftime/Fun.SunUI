namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ControlBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Control>() =
    inherit WinUIControlBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.BackgroundSizing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("DefaultStyleResourceUri")>] member inline this.DefaultStyleResourceUri ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultStyleResourceUri), (fun ctx x -> ctx.Element.DefaultStyleResourceUri <- x), x)
    [<CustomOperation("DefaultStyleResourceUri")>] member inline this.DefaultStyleResourceUri ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultStyleResourceUri), (fun ctx x -> ctx.Element.DefaultStyleResourceUri <- x), x)
    [<CustomOperation("ElementSoundMode")>] member inline this.ElementSoundMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.ElementSoundMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ElementSoundMode), (fun ctx x -> ctx.Element.ElementSoundMode <- x), x)
    [<CustomOperation("ElementSoundMode")>] member inline this.ElementSoundMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ElementSoundMode), (fun ctx x -> ctx.Element.ElementSoundMode <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontStretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontStretch")>] member inline this.FontStretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStretch), (fun ctx x -> ctx.Element.FontStretch <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsFocusEngaged")>] member inline this.IsFocusEngaged ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsFocusEngaged), (fun ctx x -> ctx.Element.IsFocusEngaged <- x), x)
    [<CustomOperation("IsFocusEngaged")>] member inline this.IsFocusEngaged ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsFocusEngaged), (fun ctx x -> ctx.Element.IsFocusEngaged <- x), x)
    [<CustomOperation("IsFocusEngagementEnabled")>] member inline this.IsFocusEngagementEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsFocusEngagementEnabled), (fun ctx x -> ctx.Element.IsFocusEngagementEnabled <- x), x)
    [<CustomOperation("IsFocusEngagementEnabled")>] member inline this.IsFocusEngagementEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsFocusEngagementEnabled), (fun ctx x -> ctx.Element.IsFocusEngagementEnabled <- x), x)
    [<CustomOperation("IsTextScaleFactorEnabled")>] member inline this.IsTextScaleFactorEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextScaleFactorEnabled), (fun ctx x -> ctx.Element.IsTextScaleFactorEnabled <- x), x)
    [<CustomOperation("IsTextScaleFactorEnabled")>] member inline this.IsTextScaleFactorEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextScaleFactorEnabled), (fun ctx x -> ctx.Element.IsTextScaleFactorEnabled <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("RequiresPointer")>] member inline this.RequiresPointer ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.RequiresPointer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RequiresPointer), (fun ctx x -> ctx.Element.RequiresPointer <- x), x)
    [<CustomOperation("RequiresPointer")>] member inline this.RequiresPointer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RequiresPointer), (fun ctx x -> ctx.Element.RequiresPointer <- x), x)
    [<CustomOperation("TabNavigation")>] member inline this.TabNavigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Input.KeyboardNavigationMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabNavigation), (fun ctx x -> ctx.Element.TabNavigation <- x), x)
    [<CustomOperation("TabNavigation")>] member inline this.TabNavigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabNavigation), (fun ctx x -> ctx.Element.TabNavigation <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)

    [<CustomOperation("FocusDisengaged")>] member inline this.FocusDisengaged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.FocusDisengaged), "FocusDisengaged", fn)
    [<CustomOperation("FocusEngaged")>] member inline this.FocusEngaged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.FocusEngaged), "FocusEngaged", fn)
    [<CustomOperation("IsEnabledChanged")>] member inline this.IsEnabledChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabledChanged), "IsEnabledChanged", fn)
                

type ContentControlBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ContentControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplateRoot")>] member inline this.ContentTemplateRoot ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ContentTemplateRoot), x)
    [<CustomOperation("ContentTemplateRoot'")>] member inline this.ContentTemplateRoot' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ContentTemplateRoot), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentTemplateSelector")>] member inline this.ContentTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplateSelector), (fun ctx x -> ctx.Element.ContentTemplateSelector <- x), x)
    [<CustomOperation("ContentTransitions")>] member inline this.ContentTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Animation.TransitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTransitions), (fun ctx x -> ctx.Element.ContentTransitions <- x), x)
    [<CustomOperation("ContentTransitions")>] member inline this.ContentTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTransitions), (fun ctx x -> ctx.Element.ContentTransitions <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ButtonBaseBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.ButtonBase>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("ClickMode")>] member inline this.ClickMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ClickMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClickMode), (fun ctx x -> ctx.Element.ClickMode <- x), x)
    [<CustomOperation("ClickMode")>] member inline this.ClickMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClickMode), (fun ctx x -> ctx.Element.ClickMode <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Button>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("Flyout")>] member inline this.Flyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Flyout), (fun ctx x -> ctx.Element.Flyout <- x), x)
    [<CustomOperation("Flyout")>] member inline this.Flyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Flyout), (fun ctx x -> ctx.Element.Flyout <- x), x)

                

type AppBarButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.AppBarButton>() =
    inherit ButtonBuilder<'Element>()

    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)
    [<CustomOperation("KeyboardAcceleratorTextOverride")>] member inline this.KeyboardAcceleratorTextOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardAcceleratorTextOverride), (fun ctx x -> ctx.Element.KeyboardAcceleratorTextOverride <- x), x)
    [<CustomOperation("KeyboardAcceleratorTextOverride")>] member inline this.KeyboardAcceleratorTextOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardAcceleratorTextOverride), (fun ctx x -> ctx.Element.KeyboardAcceleratorTextOverride <- x), x)
    [<CustomOperation("Label")>] member inline this.Label ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Label), (fun ctx x -> ctx.Element.Label <- x), x)
    [<CustomOperation("Label")>] member inline this.Label ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Label), (fun ctx x -> ctx.Element.Label <- x), x)
    [<CustomOperation("LabelPosition")>] member inline this.LabelPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CommandBarLabelPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LabelPosition), (fun ctx x -> ctx.Element.LabelPosition <- x), x)
    [<CustomOperation("LabelPosition")>] member inline this.LabelPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LabelPosition), (fun ctx x -> ctx.Element.LabelPosition <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type DropDownButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.DropDownButton>() =
    inherit ButtonBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ToggleButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Boolean>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsThreeState")>] member inline this.IsThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsThreeState), (fun ctx x -> ctx.Element.IsThreeState <- x), x)
    [<CustomOperation("IsThreeState")>] member inline this.IsThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsThreeState), (fun ctx x -> ctx.Element.IsThreeState <- x), x)

    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), "Checked", fn)
    [<CustomOperation("Indeterminate")>] member inline this.Indeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Indeterminate), "Indeterminate", fn)
    [<CustomOperation("Unchecked")>] member inline this.Unchecked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unchecked), "Unchecked", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type AppBarToggleButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.AppBarToggleButton>() =
    inherit Primitives.ToggleButtonBuilder<'Element>()

    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)
    [<CustomOperation("KeyboardAcceleratorTextOverride")>] member inline this.KeyboardAcceleratorTextOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardAcceleratorTextOverride), (fun ctx x -> ctx.Element.KeyboardAcceleratorTextOverride <- x), x)
    [<CustomOperation("KeyboardAcceleratorTextOverride")>] member inline this.KeyboardAcceleratorTextOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardAcceleratorTextOverride), (fun ctx x -> ctx.Element.KeyboardAcceleratorTextOverride <- x), x)
    [<CustomOperation("Label")>] member inline this.Label ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Label), (fun ctx x -> ctx.Element.Label <- x), x)
    [<CustomOperation("Label")>] member inline this.Label ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Label), (fun ctx x -> ctx.Element.Label <- x), x)
    [<CustomOperation("LabelPosition")>] member inline this.LabelPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CommandBarLabelPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LabelPosition), (fun ctx x -> ctx.Element.LabelPosition <- x), x)
    [<CustomOperation("LabelPosition")>] member inline this.LabelPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LabelPosition), (fun ctx x -> ctx.Element.LabelPosition <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type CheckBoxBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.CheckBox>() =
    inherit Primitives.ToggleButtonBuilder<'Element>()


                

type RadioButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RadioButton>() =
    inherit Primitives.ToggleButtonBuilder<'Element>()

    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)

                

type HyperlinkButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.HyperlinkButton>() =
    inherit Primitives.ButtonBaseBuilder<'Element>()

    [<CustomOperation("NavigateUri")>] member inline this.NavigateUri ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigateUri), (fun ctx x -> ctx.Element.NavigateUri <- x), x)
    [<CustomOperation("NavigateUri")>] member inline this.NavigateUri ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NavigateUri), (fun ctx x -> ctx.Element.NavigateUri <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type RepeatButtonBuilder() =
    inherit Primitives.ButtonBaseBuilder<Microsoft.UI.Xaml.Controls.Primitives.RepeatButton>()

    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.RepeatButton>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Delay), (fun ctx x -> ctx.Element.Delay <- x), x)
    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.RepeatButton>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Delay), (fun ctx x -> ctx.Element.Delay <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.RepeatButton>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.RepeatButton>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)

                

type SelectorItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.SelectorItem>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ListViewItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListViewItem>() =
    inherit Primitives.SelectorItemBuilder<'Element>()

    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type TabViewItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TabViewItem>() =
    inherit ListViewItemBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IconSource")>] member inline this.IconSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IconSource), (fun ctx x -> ctx.Element.IconSource <- x), x)
    [<CustomOperation("IconSource")>] member inline this.IconSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IconSource), (fun ctx x -> ctx.Element.IconSource <- x), x)
    [<CustomOperation("IsClosable")>] member inline this.IsClosable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClosable), (fun ctx x -> ctx.Element.IsClosable <- x), x)
    [<CustomOperation("IsClosable")>] member inline this.IsClosable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClosable), (fun ctx x -> ctx.Element.IsClosable <- x), x)
    [<CustomOperation("TabViewTemplateSettings")>] member inline this.TabViewTemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TabViewTemplateSettings), x)
    [<CustomOperation("TabViewTemplateSettings'")>] member inline this.TabViewTemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TabViewTemplateSettings), x)

    [<CustomOperation("CloseRequested")>] member inline this.CloseRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseRequested), "CloseRequested", fn)
                

type TreeViewItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TreeViewItem>() =
    inherit ListViewItemBuilder<'Element>()

    [<CustomOperation("CollapsedGlyph")>] member inline this.CollapsedGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CollapsedGlyph), (fun ctx x -> ctx.Element.CollapsedGlyph <- x), x)
    [<CustomOperation("CollapsedGlyph")>] member inline this.CollapsedGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CollapsedGlyph), (fun ctx x -> ctx.Element.CollapsedGlyph <- x), x)
    [<CustomOperation("ExpandedGlyph")>] member inline this.ExpandedGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandedGlyph), (fun ctx x -> ctx.Element.ExpandedGlyph <- x), x)
    [<CustomOperation("ExpandedGlyph")>] member inline this.ExpandedGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandedGlyph), (fun ctx x -> ctx.Element.ExpandedGlyph <- x), x)
    [<CustomOperation("GlyphBrush")>] member inline this.GlyphBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GlyphBrush), (fun ctx x -> ctx.Element.GlyphBrush <- x), x)
    [<CustomOperation("GlyphBrush")>] member inline this.GlyphBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GlyphBrush), (fun ctx x -> ctx.Element.GlyphBrush <- x), x)
    [<CustomOperation("GlyphOpacity")>] member inline this.GlyphOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GlyphOpacity), (fun ctx x -> ctx.Element.GlyphOpacity <- x), x)
    [<CustomOperation("GlyphOpacity")>] member inline this.GlyphOpacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GlyphOpacity), (fun ctx x -> ctx.Element.GlyphOpacity <- x), x)
    [<CustomOperation("GlyphSize")>] member inline this.GlyphSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GlyphSize), (fun ctx x -> ctx.Element.GlyphSize <- x), x)
    [<CustomOperation("GlyphSize")>] member inline this.GlyphSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GlyphSize), (fun ctx x -> ctx.Element.GlyphSize <- x), x)
    [<CustomOperation("HasUnrealizedChildren")>] member inline this.HasUnrealizedChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnrealizedChildren), (fun ctx x -> ctx.Element.HasUnrealizedChildren <- x), x)
    [<CustomOperation("HasUnrealizedChildren")>] member inline this.HasUnrealizedChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnrealizedChildren), (fun ctx x -> ctx.Element.HasUnrealizedChildren <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("TreeViewItemTemplateSettings")>] member inline this.TreeViewItemTemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TreeViewItemTemplateSettings), x)
    [<CustomOperation("TreeViewItemTemplateSettings'")>] member inline this.TreeViewItemTemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TreeViewItemTemplateSettings), x)

                

type ComboBoxItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ComboBoxItem>() =
    inherit Primitives.SelectorItemBuilder<'Element>()


                

type FlipViewItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.FlipViewItem>() =
    inherit Primitives.SelectorItemBuilder<'Element>()


                

type GridViewItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.GridViewItem>() =
    inherit Primitives.SelectorItemBuilder<'Element>()

    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type ListBoxItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListBoxItem>() =
    inherit Primitives.SelectorItemBuilder<'Element>()


                

type AppBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.AppBar>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("ClosedDisplayMode")>] member inline this.ClosedDisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.AppBarClosedDisplayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClosedDisplayMode), (fun ctx x -> ctx.Element.ClosedDisplayMode <- x), x)
    [<CustomOperation("ClosedDisplayMode")>] member inline this.ClosedDisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClosedDisplayMode), (fun ctx x -> ctx.Element.ClosedDisplayMode <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsSticky")>] member inline this.IsSticky ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSticky), (fun ctx x -> ctx.Element.IsSticky <- x), x)
    [<CustomOperation("IsSticky")>] member inline this.IsSticky ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSticky), (fun ctx x -> ctx.Element.IsSticky <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
    [<CustomOperation("Opening")>] member inline this.Opening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opening), "Opening", fn)
                

type CommandBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.CommandBar>() =
    inherit AppBarBuilder<'Element>()

    [<CustomOperation("CommandBarOverflowPresenterStyle")>] member inline this.CommandBarOverflowPresenterStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandBarOverflowPresenterStyle), (fun ctx x -> ctx.Element.CommandBarOverflowPresenterStyle <- x), x)
    [<CustomOperation("CommandBarOverflowPresenterStyle")>] member inline this.CommandBarOverflowPresenterStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandBarOverflowPresenterStyle), (fun ctx x -> ctx.Element.CommandBarOverflowPresenterStyle <- x), x)
    [<CustomOperation("CommandBarTemplateSettings")>] member inline this.CommandBarTemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CommandBarTemplateSettings), x)
    [<CustomOperation("CommandBarTemplateSettings'")>] member inline this.CommandBarTemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CommandBarTemplateSettings), x)
    [<CustomOperation("DefaultLabelPosition")>] member inline this.DefaultLabelPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CommandBarDefaultLabelPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultLabelPosition), (fun ctx x -> ctx.Element.DefaultLabelPosition <- x), x)
    [<CustomOperation("DefaultLabelPosition")>] member inline this.DefaultLabelPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultLabelPosition), (fun ctx x -> ctx.Element.DefaultLabelPosition <- x), x)
    [<CustomOperation("IsDynamicOverflowEnabled")>] member inline this.IsDynamicOverflowEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDynamicOverflowEnabled), (fun ctx x -> ctx.Element.IsDynamicOverflowEnabled <- x), x)
    [<CustomOperation("IsDynamicOverflowEnabled")>] member inline this.IsDynamicOverflowEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDynamicOverflowEnabled), (fun ctx x -> ctx.Element.IsDynamicOverflowEnabled <- x), x)
    [<CustomOperation("OverflowButtonVisibility")>] member inline this.OverflowButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CommandBarOverflowButtonVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OverflowButtonVisibility), (fun ctx x -> ctx.Element.OverflowButtonVisibility <- x), x)
    [<CustomOperation("OverflowButtonVisibility")>] member inline this.OverflowButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OverflowButtonVisibility), (fun ctx x -> ctx.Element.OverflowButtonVisibility <- x), x)
    [<CustomOperation("PrimaryCommands")>] member inline this.PrimaryCommands ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PrimaryCommands), x)
    [<CustomOperation("PrimaryCommands'")>] member inline this.PrimaryCommands' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PrimaryCommands), x)
    [<CustomOperation("SecondaryCommands")>] member inline this.SecondaryCommands ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SecondaryCommands), x)
    [<CustomOperation("SecondaryCommands'")>] member inline this.SecondaryCommands' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SecondaryCommands), x)

    [<CustomOperation("DynamicOverflowItemsChanging")>] member inline this.DynamicOverflowItemsChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowItemsChanging), "DynamicOverflowItemsChanging", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type CommandBarFlyoutCommandBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBar>() =
    inherit CommandBarBuilder<'Element>()

    [<CustomOperation("FlyoutTemplateSettings")>] member inline this.FlyoutTemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FlyoutTemplateSettings), x)
    [<CustomOperation("FlyoutTemplateSettings'")>] member inline this.FlyoutTemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FlyoutTemplateSettings), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ListViewBaseHeaderItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListViewBaseHeaderItem>() =
    inherit ContentControlBuilder<'Element>()


                

type GridViewHeaderItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.GridViewHeaderItem>() =
    inherit ListViewBaseHeaderItemBuilder<'Element>()


                

type ListViewHeaderItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListViewHeaderItem>() =
    inherit ListViewBaseHeaderItemBuilder<'Element>()


                

type NavigationViewItemBaseBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.NavigationViewItemBase>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                

type NavigationViewItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.NavigationViewItem>() =
    inherit NavigationViewItemBaseBuilder<'Element>()

    [<CustomOperation("HasUnrealizedChildren")>] member inline this.HasUnrealizedChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnrealizedChildren), (fun ctx x -> ctx.Element.HasUnrealizedChildren <- x), x)
    [<CustomOperation("HasUnrealizedChildren")>] member inline this.HasUnrealizedChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnrealizedChildren), (fun ctx x -> ctx.Element.HasUnrealizedChildren <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("IsChildSelected")>] member inline this.IsChildSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChildSelected), (fun ctx x -> ctx.Element.IsChildSelected <- x), x)
    [<CustomOperation("IsChildSelected")>] member inline this.IsChildSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChildSelected), (fun ctx x -> ctx.Element.IsChildSelected <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("MenuItems")>] member inline this.MenuItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MenuItems), x)
    [<CustomOperation("MenuItems'")>] member inline this.MenuItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MenuItems), x)
    [<CustomOperation("MenuItemsSource")>] member inline this.MenuItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemsSource), (fun ctx x -> ctx.Element.MenuItemsSource <- x), x)
    [<CustomOperation("MenuItemsSource")>] member inline this.MenuItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemsSource), (fun ctx x -> ctx.Element.MenuItemsSource <- x), x)
    [<CustomOperation("SelectsOnInvoked")>] member inline this.SelectsOnInvoked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectsOnInvoked), (fun ctx x -> ctx.Element.SelectsOnInvoked <- x), x)
    [<CustomOperation("SelectsOnInvoked")>] member inline this.SelectsOnInvoked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectsOnInvoked), (fun ctx x -> ctx.Element.SelectsOnInvoked <- x), x)

                

type NavigationViewItemHeaderBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.NavigationViewItemHeader>() =
    inherit NavigationViewItemBaseBuilder<'Element>()


                

type NavigationViewItemSeparatorBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.NavigationViewItemSeparator>() =
    inherit NavigationViewItemBaseBuilder<'Element>()


                

type SplitButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.SplitButton>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("Flyout")>] member inline this.Flyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Flyout), (fun ctx x -> ctx.Element.Flyout <- x), x)
    [<CustomOperation("Flyout")>] member inline this.Flyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Flyout), (fun ctx x -> ctx.Element.Flyout <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
                

type ToggleSplitButtonBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ToggleSplitButton>() =
    inherit SplitButtonBuilder<'Element>()

    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)

    [<CustomOperation("IsCheckedChanged")>] member inline this.IsCheckedChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCheckedChanged), "IsCheckedChanged", fn)
                

type AppBarElementContainerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.AppBarElementContainer>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)

                

type BreadcrumbBarItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.BreadcrumbBarItem>() =
    inherit ContentControlBuilder<'Element>()


                

type ContentDialogBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ContentDialog>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("CloseButtonCommand")>] member inline this.CloseButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommand), (fun ctx x -> ctx.Element.CloseButtonCommand <- x), x)
    [<CustomOperation("CloseButtonCommand")>] member inline this.CloseButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommand), (fun ctx x -> ctx.Element.CloseButtonCommand <- x), x)
    [<CustomOperation("CloseButtonCommandParameter")>] member inline this.CloseButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommandParameter), (fun ctx x -> ctx.Element.CloseButtonCommandParameter <- x), x)
    [<CustomOperation("CloseButtonCommandParameter")>] member inline this.CloseButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommandParameter), (fun ctx x -> ctx.Element.CloseButtonCommandParameter <- x), x)
    [<CustomOperation("CloseButtonStyle")>] member inline this.CloseButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonStyle), (fun ctx x -> ctx.Element.CloseButtonStyle <- x), x)
    [<CustomOperation("CloseButtonStyle")>] member inline this.CloseButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonStyle), (fun ctx x -> ctx.Element.CloseButtonStyle <- x), x)
    [<CustomOperation("CloseButtonText")>] member inline this.CloseButtonText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonText), (fun ctx x -> ctx.Element.CloseButtonText <- x), x)
    [<CustomOperation("CloseButtonText")>] member inline this.CloseButtonText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonText), (fun ctx x -> ctx.Element.CloseButtonText <- x), x)
    [<CustomOperation("DefaultButton")>] member inline this.DefaultButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ContentDialogButton) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultButton), (fun ctx x -> ctx.Element.DefaultButton <- x), x)
    [<CustomOperation("DefaultButton")>] member inline this.DefaultButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultButton), (fun ctx x -> ctx.Element.DefaultButton <- x), x)
    [<CustomOperation("FullSizeDesired")>] member inline this.FullSizeDesired ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FullSizeDesired), (fun ctx x -> ctx.Element.FullSizeDesired <- x), x)
    [<CustomOperation("FullSizeDesired")>] member inline this.FullSizeDesired ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FullSizeDesired), (fun ctx x -> ctx.Element.FullSizeDesired <- x), x)
    [<CustomOperation("IsPrimaryButtonEnabled")>] member inline this.IsPrimaryButtonEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPrimaryButtonEnabled), (fun ctx x -> ctx.Element.IsPrimaryButtonEnabled <- x), x)
    [<CustomOperation("IsPrimaryButtonEnabled")>] member inline this.IsPrimaryButtonEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPrimaryButtonEnabled), (fun ctx x -> ctx.Element.IsPrimaryButtonEnabled <- x), x)
    [<CustomOperation("IsSecondaryButtonEnabled")>] member inline this.IsSecondaryButtonEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSecondaryButtonEnabled), (fun ctx x -> ctx.Element.IsSecondaryButtonEnabled <- x), x)
    [<CustomOperation("IsSecondaryButtonEnabled")>] member inline this.IsSecondaryButtonEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSecondaryButtonEnabled), (fun ctx x -> ctx.Element.IsSecondaryButtonEnabled <- x), x)
    [<CustomOperation("PrimaryButtonCommand")>] member inline this.PrimaryButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonCommand), (fun ctx x -> ctx.Element.PrimaryButtonCommand <- x), x)
    [<CustomOperation("PrimaryButtonCommand")>] member inline this.PrimaryButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonCommand), (fun ctx x -> ctx.Element.PrimaryButtonCommand <- x), x)
    [<CustomOperation("PrimaryButtonCommandParameter")>] member inline this.PrimaryButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonCommandParameter), (fun ctx x -> ctx.Element.PrimaryButtonCommandParameter <- x), x)
    [<CustomOperation("PrimaryButtonCommandParameter")>] member inline this.PrimaryButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonCommandParameter), (fun ctx x -> ctx.Element.PrimaryButtonCommandParameter <- x), x)
    [<CustomOperation("PrimaryButtonStyle")>] member inline this.PrimaryButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonStyle), (fun ctx x -> ctx.Element.PrimaryButtonStyle <- x), x)
    [<CustomOperation("PrimaryButtonStyle")>] member inline this.PrimaryButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonStyle), (fun ctx x -> ctx.Element.PrimaryButtonStyle <- x), x)
    [<CustomOperation("PrimaryButtonText")>] member inline this.PrimaryButtonText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonText), (fun ctx x -> ctx.Element.PrimaryButtonText <- x), x)
    [<CustomOperation("PrimaryButtonText")>] member inline this.PrimaryButtonText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonText), (fun ctx x -> ctx.Element.PrimaryButtonText <- x), x)
    [<CustomOperation("SecondaryButtonCommand")>] member inline this.SecondaryButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonCommand), (fun ctx x -> ctx.Element.SecondaryButtonCommand <- x), x)
    [<CustomOperation("SecondaryButtonCommand")>] member inline this.SecondaryButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonCommand), (fun ctx x -> ctx.Element.SecondaryButtonCommand <- x), x)
    [<CustomOperation("SecondaryButtonCommandParameter")>] member inline this.SecondaryButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonCommandParameter), (fun ctx x -> ctx.Element.SecondaryButtonCommandParameter <- x), x)
    [<CustomOperation("SecondaryButtonCommandParameter")>] member inline this.SecondaryButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonCommandParameter), (fun ctx x -> ctx.Element.SecondaryButtonCommandParameter <- x), x)
    [<CustomOperation("SecondaryButtonStyle")>] member inline this.SecondaryButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonStyle), (fun ctx x -> ctx.Element.SecondaryButtonStyle <- x), x)
    [<CustomOperation("SecondaryButtonStyle")>] member inline this.SecondaryButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonStyle), (fun ctx x -> ctx.Element.SecondaryButtonStyle <- x), x)
    [<CustomOperation("SecondaryButtonText")>] member inline this.SecondaryButtonText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonText), (fun ctx x -> ctx.Element.SecondaryButtonText <- x), x)
    [<CustomOperation("SecondaryButtonText")>] member inline this.SecondaryButtonText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonText), (fun ctx x -> ctx.Element.SecondaryButtonText <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("TitleTemplate")>] member inline this.TitleTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TitleTemplate), (fun ctx x -> ctx.Element.TitleTemplate <- x), x)
    [<CustomOperation("TitleTemplate")>] member inline this.TitleTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TitleTemplate), (fun ctx x -> ctx.Element.TitleTemplate <- x), x)

    [<CustomOperation("CloseButtonClick")>] member inline this.CloseButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonClick), "CloseButtonClick", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
    [<CustomOperation("PrimaryButtonClick")>] member inline this.PrimaryButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PrimaryButtonClick), "PrimaryButtonClick", fn)
    [<CustomOperation("SecondaryButtonClick")>] member inline this.SecondaryButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SecondaryButtonClick), "SecondaryButtonClick", fn)
                

type ExpanderBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Expander>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("ExpandDirection")>] member inline this.ExpandDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ExpandDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandDirection), (fun ctx x -> ctx.Element.ExpandDirection <- x), x)
    [<CustomOperation("ExpandDirection")>] member inline this.ExpandDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandDirection), (fun ctx x -> ctx.Element.ExpandDirection <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("HeaderTemplateSelector")>] member inline this.HeaderTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplateSelector), (fun ctx x -> ctx.Element.HeaderTemplateSelector <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

    [<CustomOperation("Collapsed")>] member inline this.Collapsed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Collapsed), "Collapsed", fn)
    [<CustomOperation("Expanding")>] member inline this.Expanding ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Expanding), "Expanding", fn)
                

type FlyoutPresenterBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.FlyoutPresenter>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)
    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)

                

type FrameBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Frame>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("BackStack")>] member inline this.BackStack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BackStack), x)
    [<CustomOperation("BackStack'")>] member inline this.BackStack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BackStack), x)
    [<CustomOperation("CacheSize")>] member inline this.CacheSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CacheSize), (fun ctx x -> ctx.Element.CacheSize <- x), x)
    [<CustomOperation("CacheSize")>] member inline this.CacheSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CacheSize), (fun ctx x -> ctx.Element.CacheSize <- x), x)
    [<CustomOperation("CurrentSourcePageType")>] member inline this.CurrentSourcePageType ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentSourcePageType), x)
    [<CustomOperation("CurrentSourcePageType'")>] member inline this.CurrentSourcePageType' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentSourcePageType), x)
    [<CustomOperation("ForwardStack")>] member inline this.ForwardStack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ForwardStack), x)
    [<CustomOperation("ForwardStack'")>] member inline this.ForwardStack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ForwardStack), x)
    [<CustomOperation("IsNavigationStackEnabled")>] member inline this.IsNavigationStackEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsNavigationStackEnabled), (fun ctx x -> ctx.Element.IsNavigationStackEnabled <- x), x)
    [<CustomOperation("IsNavigationStackEnabled")>] member inline this.IsNavigationStackEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsNavigationStackEnabled), (fun ctx x -> ctx.Element.IsNavigationStackEnabled <- x), x)
    [<CustomOperation("SourcePageType")>] member inline this.SourcePageType ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Type) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SourcePageType), (fun ctx x -> ctx.Element.SourcePageType <- x), x)
    [<CustomOperation("SourcePageType")>] member inline this.SourcePageType ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SourcePageType), (fun ctx x -> ctx.Element.SourcePageType <- x), x)

    [<CustomOperation("Navigated")>] member inline this.Navigated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigated), "Navigated", fn)
    [<CustomOperation("Navigating")>] member inline this.Navigating ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigating), "Navigating", fn)
    [<CustomOperation("NavigationFailed")>] member inline this.NavigationFailed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigationFailed), "NavigationFailed", fn)
    [<CustomOperation("NavigationStopped")>] member inline this.NavigationStopped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigationStopped), "NavigationStopped", fn)
                

type GroupItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.GroupItem>() =
    inherit ContentControlBuilder<'Element>()


                

type NavigationViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.NavigationView>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("AlwaysShowHeader")>] member inline this.AlwaysShowHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlwaysShowHeader), (fun ctx x -> ctx.Element.AlwaysShowHeader <- x), x)
    [<CustomOperation("AlwaysShowHeader")>] member inline this.AlwaysShowHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlwaysShowHeader), (fun ctx x -> ctx.Element.AlwaysShowHeader <- x), x)
    [<CustomOperation("AutoSuggestBox")>] member inline this.AutoSuggestBox ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.AutoSuggestBox) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSuggestBox), (fun ctx x -> ctx.Element.AutoSuggestBox <- x), x)
    [<CustomOperation("AutoSuggestBox")>] member inline this.AutoSuggestBox ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSuggestBox), (fun ctx x -> ctx.Element.AutoSuggestBox <- x), x)
    [<CustomOperation("CompactModeThresholdWidth")>] member inline this.CompactModeThresholdWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CompactModeThresholdWidth), (fun ctx x -> ctx.Element.CompactModeThresholdWidth <- x), x)
    [<CustomOperation("CompactModeThresholdWidth")>] member inline this.CompactModeThresholdWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CompactModeThresholdWidth), (fun ctx x -> ctx.Element.CompactModeThresholdWidth <- x), x)
    [<CustomOperation("CompactPaneLength")>] member inline this.CompactPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CompactPaneLength), (fun ctx x -> ctx.Element.CompactPaneLength <- x), x)
    [<CustomOperation("CompactPaneLength")>] member inline this.CompactPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CompactPaneLength), (fun ctx x -> ctx.Element.CompactPaneLength <- x), x)
    [<CustomOperation("ContentOverlay")>] member inline this.ContentOverlay ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentOverlay), (fun ctx x -> ctx.Element.ContentOverlay <- x), x)
    [<CustomOperation("ContentOverlay")>] member inline this.ContentOverlay ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentOverlay), (fun ctx x -> ctx.Element.ContentOverlay <- x), x)
    [<CustomOperation("ExpandedModeThresholdWidth")>] member inline this.ExpandedModeThresholdWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandedModeThresholdWidth), (fun ctx x -> ctx.Element.ExpandedModeThresholdWidth <- x), x)
    [<CustomOperation("ExpandedModeThresholdWidth")>] member inline this.ExpandedModeThresholdWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandedModeThresholdWidth), (fun ctx x -> ctx.Element.ExpandedModeThresholdWidth <- x), x)
    [<CustomOperation("FooterMenuItems")>] member inline this.FooterMenuItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FooterMenuItems), x)
    [<CustomOperation("FooterMenuItems'")>] member inline this.FooterMenuItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FooterMenuItems), x)
    [<CustomOperation("FooterMenuItemsSource")>] member inline this.FooterMenuItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FooterMenuItemsSource), (fun ctx x -> ctx.Element.FooterMenuItemsSource <- x), x)
    [<CustomOperation("FooterMenuItemsSource")>] member inline this.FooterMenuItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FooterMenuItemsSource), (fun ctx x -> ctx.Element.FooterMenuItemsSource <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsBackButtonVisible")>] member inline this.IsBackButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsBackButtonVisible), (fun ctx x -> ctx.Element.IsBackButtonVisible <- x), x)
    [<CustomOperation("IsBackButtonVisible")>] member inline this.IsBackButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsBackButtonVisible), (fun ctx x -> ctx.Element.IsBackButtonVisible <- x), x)
    [<CustomOperation("IsBackEnabled")>] member inline this.IsBackEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsBackEnabled), (fun ctx x -> ctx.Element.IsBackEnabled <- x), x)
    [<CustomOperation("IsBackEnabled")>] member inline this.IsBackEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsBackEnabled), (fun ctx x -> ctx.Element.IsBackEnabled <- x), x)
    [<CustomOperation("IsPaneOpen")>] member inline this.IsPaneOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneOpen), (fun ctx x -> ctx.Element.IsPaneOpen <- x), x)
    [<CustomOperation("IsPaneOpen")>] member inline this.IsPaneOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneOpen), (fun ctx x -> ctx.Element.IsPaneOpen <- x), x)
    [<CustomOperation("IsPaneToggleButtonVisible")>] member inline this.IsPaneToggleButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneToggleButtonVisible), (fun ctx x -> ctx.Element.IsPaneToggleButtonVisible <- x), x)
    [<CustomOperation("IsPaneToggleButtonVisible")>] member inline this.IsPaneToggleButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneToggleButtonVisible), (fun ctx x -> ctx.Element.IsPaneToggleButtonVisible <- x), x)
    [<CustomOperation("IsPaneVisible")>] member inline this.IsPaneVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneVisible), (fun ctx x -> ctx.Element.IsPaneVisible <- x), x)
    [<CustomOperation("IsPaneVisible")>] member inline this.IsPaneVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneVisible), (fun ctx x -> ctx.Element.IsPaneVisible <- x), x)
    [<CustomOperation("IsSettingsVisible")>] member inline this.IsSettingsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSettingsVisible), (fun ctx x -> ctx.Element.IsSettingsVisible <- x), x)
    [<CustomOperation("IsSettingsVisible")>] member inline this.IsSettingsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSettingsVisible), (fun ctx x -> ctx.Element.IsSettingsVisible <- x), x)
    [<CustomOperation("IsTitleBarAutoPaddingEnabled")>] member inline this.IsTitleBarAutoPaddingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTitleBarAutoPaddingEnabled), (fun ctx x -> ctx.Element.IsTitleBarAutoPaddingEnabled <- x), x)
    [<CustomOperation("IsTitleBarAutoPaddingEnabled")>] member inline this.IsTitleBarAutoPaddingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTitleBarAutoPaddingEnabled), (fun ctx x -> ctx.Element.IsTitleBarAutoPaddingEnabled <- x), x)
    [<CustomOperation("MenuItemContainerStyle")>] member inline this.MenuItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemContainerStyle), (fun ctx x -> ctx.Element.MenuItemContainerStyle <- x), x)
    [<CustomOperation("MenuItemContainerStyle")>] member inline this.MenuItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemContainerStyle), (fun ctx x -> ctx.Element.MenuItemContainerStyle <- x), x)
    [<CustomOperation("MenuItemContainerStyleSelector")>] member inline this.MenuItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.StyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemContainerStyleSelector), (fun ctx x -> ctx.Element.MenuItemContainerStyleSelector <- x), x)
    [<CustomOperation("MenuItemContainerStyleSelector")>] member inline this.MenuItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemContainerStyleSelector), (fun ctx x -> ctx.Element.MenuItemContainerStyleSelector <- x), x)
    [<CustomOperation("MenuItemTemplate")>] member inline this.MenuItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemTemplate), (fun ctx x -> ctx.Element.MenuItemTemplate <- x), x)
    [<CustomOperation("MenuItemTemplate")>] member inline this.MenuItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemTemplate), (fun ctx x -> ctx.Element.MenuItemTemplate <- x), x)
    [<CustomOperation("MenuItemTemplateSelector")>] member inline this.MenuItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemTemplateSelector), (fun ctx x -> ctx.Element.MenuItemTemplateSelector <- x), x)
    [<CustomOperation("MenuItemTemplateSelector")>] member inline this.MenuItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemTemplateSelector), (fun ctx x -> ctx.Element.MenuItemTemplateSelector <- x), x)
    [<CustomOperation("MenuItems")>] member inline this.MenuItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MenuItems), x)
    [<CustomOperation("MenuItems'")>] member inline this.MenuItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MenuItems), x)
    [<CustomOperation("MenuItemsSource")>] member inline this.MenuItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemsSource), (fun ctx x -> ctx.Element.MenuItemsSource <- x), x)
    [<CustomOperation("MenuItemsSource")>] member inline this.MenuItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemsSource), (fun ctx x -> ctx.Element.MenuItemsSource <- x), x)
    [<CustomOperation("OpenPaneLength")>] member inline this.OpenPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OpenPaneLength), (fun ctx x -> ctx.Element.OpenPaneLength <- x), x)
    [<CustomOperation("OpenPaneLength")>] member inline this.OpenPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OpenPaneLength), (fun ctx x -> ctx.Element.OpenPaneLength <- x), x)
    [<CustomOperation("OverflowLabelMode")>] member inline this.OverflowLabelMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OverflowLabelMode), (fun ctx x -> ctx.Element.OverflowLabelMode <- x), x)
    [<CustomOperation("OverflowLabelMode")>] member inline this.OverflowLabelMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OverflowLabelMode), (fun ctx x -> ctx.Element.OverflowLabelMode <- x), x)
    [<CustomOperation("PaneCustomContent")>] member inline this.PaneCustomContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneCustomContent), (fun ctx x -> ctx.Element.PaneCustomContent <- x), x)
    [<CustomOperation("PaneCustomContent")>] member inline this.PaneCustomContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneCustomContent), (fun ctx x -> ctx.Element.PaneCustomContent <- x), x)
    [<CustomOperation("PaneDisplayMode")>] member inline this.PaneDisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneDisplayMode), (fun ctx x -> ctx.Element.PaneDisplayMode <- x), x)
    [<CustomOperation("PaneDisplayMode")>] member inline this.PaneDisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneDisplayMode), (fun ctx x -> ctx.Element.PaneDisplayMode <- x), x)
    [<CustomOperation("PaneFooter")>] member inline this.PaneFooter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneFooter), (fun ctx x -> ctx.Element.PaneFooter <- x), x)
    [<CustomOperation("PaneFooter")>] member inline this.PaneFooter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneFooter), (fun ctx x -> ctx.Element.PaneFooter <- x), x)
    [<CustomOperation("PaneHeader")>] member inline this.PaneHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneHeader), (fun ctx x -> ctx.Element.PaneHeader <- x), x)
    [<CustomOperation("PaneHeader")>] member inline this.PaneHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneHeader), (fun ctx x -> ctx.Element.PaneHeader <- x), x)
    [<CustomOperation("PaneTitle")>] member inline this.PaneTitle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneTitle), (fun ctx x -> ctx.Element.PaneTitle <- x), x)
    [<CustomOperation("PaneTitle")>] member inline this.PaneTitle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneTitle), (fun ctx x -> ctx.Element.PaneTitle <- x), x)
    [<CustomOperation("PaneToggleButtonStyle")>] member inline this.PaneToggleButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneToggleButtonStyle), (fun ctx x -> ctx.Element.PaneToggleButtonStyle <- x), x)
    [<CustomOperation("PaneToggleButtonStyle")>] member inline this.PaneToggleButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneToggleButtonStyle), (fun ctx x -> ctx.Element.PaneToggleButtonStyle <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectionFollowsFocus")>] member inline this.SelectionFollowsFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFollowsFocus), (fun ctx x -> ctx.Element.SelectionFollowsFocus <- x), x)
    [<CustomOperation("SelectionFollowsFocus")>] member inline this.SelectionFollowsFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFollowsFocus), (fun ctx x -> ctx.Element.SelectionFollowsFocus <- x), x)
    [<CustomOperation("SettingsItem")>] member inline this.SettingsItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SettingsItem), x)
    [<CustomOperation("SettingsItem'")>] member inline this.SettingsItem' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SettingsItem), x)
    [<CustomOperation("ShoulderNavigationEnabled")>] member inline this.ShoulderNavigationEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShoulderNavigationEnabled), (fun ctx x -> ctx.Element.ShoulderNavigationEnabled <- x), x)
    [<CustomOperation("ShoulderNavigationEnabled")>] member inline this.ShoulderNavigationEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShoulderNavigationEnabled), (fun ctx x -> ctx.Element.ShoulderNavigationEnabled <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

    [<CustomOperation("DisplayModeChanged")>] member inline this.DisplayModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayModeChanged), "DisplayModeChanged", fn)
    [<CustomOperation("ItemInvoked")>] member inline this.ItemInvoked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemInvoked), "ItemInvoked", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
    [<CustomOperation("BackRequested")>] member inline this.BackRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BackRequested), "BackRequested", fn)
    [<CustomOperation("Collapsed")>] member inline this.Collapsed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Collapsed), "Collapsed", fn)
    [<CustomOperation("Expanding")>] member inline this.Expanding ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Expanding), "Expanding", fn)
    [<CustomOperation("PaneClosed")>] member inline this.PaneClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneClosed), "PaneClosed", fn)
    [<CustomOperation("PaneClosing")>] member inline this.PaneClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneClosing), "PaneClosing", fn)
    [<CustomOperation("PaneOpened")>] member inline this.PaneOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneOpened), "PaneOpened", fn)
    [<CustomOperation("PaneOpening")>] member inline this.PaneOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneOpening), "PaneOpening", fn)
                

type PickerFlyoutPresenterBuilder() =
    inherit ContentControlBuilder<Microsoft.UI.Xaml.Controls.PickerFlyoutPresenter>()


                

type PivotItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.PivotItem>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)

                

type RefreshContainerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RefreshContainer>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("PullDirection")>] member inline this.PullDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.RefreshPullDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PullDirection), (fun ctx x -> ctx.Element.PullDirection <- x), x)
    [<CustomOperation("PullDirection")>] member inline this.PullDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PullDirection), (fun ctx x -> ctx.Element.PullDirection <- x), x)
    [<CustomOperation("Visualizer")>] member inline this.Visualizer ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.RefreshVisualizer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visualizer), (fun ctx x -> ctx.Element.Visualizer <- x), x)
    [<CustomOperation("Visualizer")>] member inline this.Visualizer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visualizer), (fun ctx x -> ctx.Element.Visualizer <- x), x)

    [<CustomOperation("RefreshRequested")>] member inline this.RefreshRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshRequested), "RefreshRequested", fn)
                

type ScrollViewerBuilder() =
    inherit ContentControlBuilder<Microsoft.UI.Xaml.Controls.ScrollViewer>()

    [<CustomOperation("BringIntoViewOnFocusChange")>] member inline this.BringIntoViewOnFocusChange ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BringIntoViewOnFocusChange), (fun ctx x -> ctx.Element.BringIntoViewOnFocusChange <- x), x)
    [<CustomOperation("BringIntoViewOnFocusChange")>] member inline this.BringIntoViewOnFocusChange ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BringIntoViewOnFocusChange), (fun ctx x -> ctx.Element.BringIntoViewOnFocusChange <- x), x)
    [<CustomOperation("CanContentRenderOutsideBounds")>] member inline this.CanContentRenderOutsideBounds ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanContentRenderOutsideBounds), (fun ctx x -> ctx.Element.CanContentRenderOutsideBounds <- x), x)
    [<CustomOperation("CanContentRenderOutsideBounds")>] member inline this.CanContentRenderOutsideBounds ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanContentRenderOutsideBounds), (fun ctx x -> ctx.Element.CanContentRenderOutsideBounds <- x), x)
    [<CustomOperation("CurrentAnchor")>] member inline this.CurrentAnchor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentAnchor), x)
    [<CustomOperation("CurrentAnchor'")>] member inline this.CurrentAnchor' ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentAnchor), x)
    [<CustomOperation("HorizontalAnchorRatio")>] member inline this.HorizontalAnchorRatio ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalAnchorRatio), (fun ctx x -> ctx.Element.HorizontalAnchorRatio <- x), x)
    [<CustomOperation("HorizontalAnchorRatio")>] member inline this.HorizontalAnchorRatio ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalAnchorRatio), (fun ctx x -> ctx.Element.HorizontalAnchorRatio <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollMode")>] member inline this.HorizontalScrollMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.ScrollMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollMode), (fun ctx x -> ctx.Element.HorizontalScrollMode <- x), x)
    [<CustomOperation("HorizontalScrollMode")>] member inline this.HorizontalScrollMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollMode), (fun ctx x -> ctx.Element.HorizontalScrollMode <- x), x)
    [<CustomOperation("HorizontalSnapPointsAlignment")>] member inline this.HorizontalSnapPointsAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsAlignment), (fun ctx x -> ctx.Element.HorizontalSnapPointsAlignment <- x), x)
    [<CustomOperation("HorizontalSnapPointsAlignment")>] member inline this.HorizontalSnapPointsAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsAlignment), (fun ctx x -> ctx.Element.HorizontalSnapPointsAlignment <- x), x)
    [<CustomOperation("HorizontalSnapPointsType")>] member inline this.HorizontalSnapPointsType ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.SnapPointsType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsType), (fun ctx x -> ctx.Element.HorizontalSnapPointsType <- x), x)
    [<CustomOperation("HorizontalSnapPointsType")>] member inline this.HorizontalSnapPointsType ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsType), (fun ctx x -> ctx.Element.HorizontalSnapPointsType <- x), x)
    [<CustomOperation("IsDeferredScrollingEnabled")>] member inline this.IsDeferredScrollingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDeferredScrollingEnabled), (fun ctx x -> ctx.Element.IsDeferredScrollingEnabled <- x), x)
    [<CustomOperation("IsDeferredScrollingEnabled")>] member inline this.IsDeferredScrollingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDeferredScrollingEnabled), (fun ctx x -> ctx.Element.IsDeferredScrollingEnabled <- x), x)
    [<CustomOperation("IsHorizontalRailEnabled")>] member inline this.IsHorizontalRailEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHorizontalRailEnabled), (fun ctx x -> ctx.Element.IsHorizontalRailEnabled <- x), x)
    [<CustomOperation("IsHorizontalRailEnabled")>] member inline this.IsHorizontalRailEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHorizontalRailEnabled), (fun ctx x -> ctx.Element.IsHorizontalRailEnabled <- x), x)
    [<CustomOperation("IsHorizontalScrollChainingEnabled")>] member inline this.IsHorizontalScrollChainingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHorizontalScrollChainingEnabled), (fun ctx x -> ctx.Element.IsHorizontalScrollChainingEnabled <- x), x)
    [<CustomOperation("IsHorizontalScrollChainingEnabled")>] member inline this.IsHorizontalScrollChainingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHorizontalScrollChainingEnabled), (fun ctx x -> ctx.Element.IsHorizontalScrollChainingEnabled <- x), x)
    [<CustomOperation("IsScrollInertiaEnabled")>] member inline this.IsScrollInertiaEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrollInertiaEnabled), (fun ctx x -> ctx.Element.IsScrollInertiaEnabled <- x), x)
    [<CustomOperation("IsScrollInertiaEnabled")>] member inline this.IsScrollInertiaEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrollInertiaEnabled), (fun ctx x -> ctx.Element.IsScrollInertiaEnabled <- x), x)
    [<CustomOperation("IsVerticalRailEnabled")>] member inline this.IsVerticalRailEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVerticalRailEnabled), (fun ctx x -> ctx.Element.IsVerticalRailEnabled <- x), x)
    [<CustomOperation("IsVerticalRailEnabled")>] member inline this.IsVerticalRailEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVerticalRailEnabled), (fun ctx x -> ctx.Element.IsVerticalRailEnabled <- x), x)
    [<CustomOperation("IsVerticalScrollChainingEnabled")>] member inline this.IsVerticalScrollChainingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVerticalScrollChainingEnabled), (fun ctx x -> ctx.Element.IsVerticalScrollChainingEnabled <- x), x)
    [<CustomOperation("IsVerticalScrollChainingEnabled")>] member inline this.IsVerticalScrollChainingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVerticalScrollChainingEnabled), (fun ctx x -> ctx.Element.IsVerticalScrollChainingEnabled <- x), x)
    [<CustomOperation("IsZoomChainingEnabled")>] member inline this.IsZoomChainingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomChainingEnabled), (fun ctx x -> ctx.Element.IsZoomChainingEnabled <- x), x)
    [<CustomOperation("IsZoomChainingEnabled")>] member inline this.IsZoomChainingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomChainingEnabled), (fun ctx x -> ctx.Element.IsZoomChainingEnabled <- x), x)
    [<CustomOperation("IsZoomInertiaEnabled")>] member inline this.IsZoomInertiaEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomInertiaEnabled), (fun ctx x -> ctx.Element.IsZoomInertiaEnabled <- x), x)
    [<CustomOperation("IsZoomInertiaEnabled")>] member inline this.IsZoomInertiaEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomInertiaEnabled), (fun ctx x -> ctx.Element.IsZoomInertiaEnabled <- x), x)
    [<CustomOperation("LeftHeader")>] member inline this.LeftHeader ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LeftHeader), (fun ctx x -> ctx.Element.LeftHeader <- x), x)
    [<CustomOperation("LeftHeader")>] member inline this.LeftHeader ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LeftHeader), (fun ctx x -> ctx.Element.LeftHeader <- x), x)
    [<CustomOperation("MaxZoomFactor")>] member inline this.MaxZoomFactor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoomFactor), (fun ctx x -> ctx.Element.MaxZoomFactor <- x), x)
    [<CustomOperation("MaxZoomFactor")>] member inline this.MaxZoomFactor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxZoomFactor), (fun ctx x -> ctx.Element.MaxZoomFactor <- x), x)
    [<CustomOperation("MinZoomFactor")>] member inline this.MinZoomFactor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoomFactor), (fun ctx x -> ctx.Element.MinZoomFactor <- x), x)
    [<CustomOperation("MinZoomFactor")>] member inline this.MinZoomFactor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinZoomFactor), (fun ctx x -> ctx.Element.MinZoomFactor <- x), x)
    [<CustomOperation("ReduceViewportForCoreInputViewOcclusions")>] member inline this.ReduceViewportForCoreInputViewOcclusions ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReduceViewportForCoreInputViewOcclusions), (fun ctx x -> ctx.Element.ReduceViewportForCoreInputViewOcclusions <- x), x)
    [<CustomOperation("ReduceViewportForCoreInputViewOcclusions")>] member inline this.ReduceViewportForCoreInputViewOcclusions ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReduceViewportForCoreInputViewOcclusions), (fun ctx x -> ctx.Element.ReduceViewportForCoreInputViewOcclusions <- x), x)
    [<CustomOperation("TopHeader")>] member inline this.TopHeader ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TopHeader), (fun ctx x -> ctx.Element.TopHeader <- x), x)
    [<CustomOperation("TopHeader")>] member inline this.TopHeader ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TopHeader), (fun ctx x -> ctx.Element.TopHeader <- x), x)
    [<CustomOperation("TopLeftHeader")>] member inline this.TopLeftHeader ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TopLeftHeader), (fun ctx x -> ctx.Element.TopLeftHeader <- x), x)
    [<CustomOperation("TopLeftHeader")>] member inline this.TopLeftHeader ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TopLeftHeader), (fun ctx x -> ctx.Element.TopLeftHeader <- x), x)
    [<CustomOperation("VerticalAnchorRatio")>] member inline this.VerticalAnchorRatio ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalAnchorRatio), (fun ctx x -> ctx.Element.VerticalAnchorRatio <- x), x)
    [<CustomOperation("VerticalAnchorRatio")>] member inline this.VerticalAnchorRatio ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalAnchorRatio), (fun ctx x -> ctx.Element.VerticalAnchorRatio <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollMode")>] member inline this.VerticalScrollMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.ScrollMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollMode), (fun ctx x -> ctx.Element.VerticalScrollMode <- x), x)
    [<CustomOperation("VerticalScrollMode")>] member inline this.VerticalScrollMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollMode), (fun ctx x -> ctx.Element.VerticalScrollMode <- x), x)
    [<CustomOperation("VerticalSnapPointsAlignment")>] member inline this.VerticalSnapPointsAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsAlignment), (fun ctx x -> ctx.Element.VerticalSnapPointsAlignment <- x), x)
    [<CustomOperation("VerticalSnapPointsAlignment")>] member inline this.VerticalSnapPointsAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsAlignment), (fun ctx x -> ctx.Element.VerticalSnapPointsAlignment <- x), x)
    [<CustomOperation("VerticalSnapPointsType")>] member inline this.VerticalSnapPointsType ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.SnapPointsType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsType), (fun ctx x -> ctx.Element.VerticalSnapPointsType <- x), x)
    [<CustomOperation("VerticalSnapPointsType")>] member inline this.VerticalSnapPointsType ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsType), (fun ctx x -> ctx.Element.VerticalSnapPointsType <- x), x)
    [<CustomOperation("ZoomMode")>] member inline this.ZoomMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.ZoomMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomMode), (fun ctx x -> ctx.Element.ZoomMode <- x), x)
    [<CustomOperation("ZoomMode")>] member inline this.ZoomMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomMode), (fun ctx x -> ctx.Element.ZoomMode <- x), x)
    [<CustomOperation("ZoomSnapPoints")>] member inline this.ZoomSnapPoints ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ZoomSnapPoints), x)
    [<CustomOperation("ZoomSnapPoints'")>] member inline this.ZoomSnapPoints' ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ZoomSnapPoints), x)
    [<CustomOperation("ZoomSnapPointsType")>] member inline this.ZoomSnapPointsType ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x: Microsoft.UI.Xaml.Controls.SnapPointsType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomSnapPointsType), (fun ctx x -> ctx.Element.ZoomSnapPointsType <- x), x)
    [<CustomOperation("ZoomSnapPointsType")>] member inline this.ZoomSnapPointsType ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomSnapPointsType), (fun ctx x -> ctx.Element.ZoomSnapPointsType <- x), x)

    [<CustomOperation("AnchorRequested")>] member inline this.AnchorRequested ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AnchorRequested), "AnchorRequested", fn)
    [<CustomOperation("DirectManipulationCompleted")>] member inline this.DirectManipulationCompleted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DirectManipulationCompleted), "DirectManipulationCompleted", fn)
    [<CustomOperation("DirectManipulationStarted")>] member inline this.DirectManipulationStarted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DirectManipulationStarted), "DirectManipulationStarted", fn)
    [<CustomOperation("ViewChanged")>] member inline this.ViewChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewChanged), "ViewChanged", fn)
    [<CustomOperation("ViewChanging")>] member inline this.ViewChanging ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewChanging), "ViewChanging", fn)
                

type SwipeControlBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.SwipeControl>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("BottomItems")>] member inline this.BottomItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SwipeItems) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BottomItems), (fun ctx x -> ctx.Element.BottomItems <- x), x)
    [<CustomOperation("BottomItems")>] member inline this.BottomItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BottomItems), (fun ctx x -> ctx.Element.BottomItems <- x), x)
    [<CustomOperation("LeftItems")>] member inline this.LeftItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SwipeItems) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LeftItems), (fun ctx x -> ctx.Element.LeftItems <- x), x)
    [<CustomOperation("LeftItems")>] member inline this.LeftItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LeftItems), (fun ctx x -> ctx.Element.LeftItems <- x), x)
    [<CustomOperation("RightItems")>] member inline this.RightItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SwipeItems) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RightItems), (fun ctx x -> ctx.Element.RightItems <- x), x)
    [<CustomOperation("RightItems")>] member inline this.RightItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RightItems), (fun ctx x -> ctx.Element.RightItems <- x), x)
    [<CustomOperation("TopItems")>] member inline this.TopItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SwipeItems) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TopItems), (fun ctx x -> ctx.Element.TopItems <- x), x)
    [<CustomOperation("TopItems")>] member inline this.TopItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TopItems), (fun ctx x -> ctx.Element.TopItems <- x), x)

                

type TeachingTipBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TeachingTip>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("ActionButtonCommand")>] member inline this.ActionButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonCommand), (fun ctx x -> ctx.Element.ActionButtonCommand <- x), x)
    [<CustomOperation("ActionButtonCommand")>] member inline this.ActionButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonCommand), (fun ctx x -> ctx.Element.ActionButtonCommand <- x), x)
    [<CustomOperation("ActionButtonCommandParameter")>] member inline this.ActionButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonCommandParameter), (fun ctx x -> ctx.Element.ActionButtonCommandParameter <- x), x)
    [<CustomOperation("ActionButtonCommandParameter")>] member inline this.ActionButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonCommandParameter), (fun ctx x -> ctx.Element.ActionButtonCommandParameter <- x), x)
    [<CustomOperation("ActionButtonContent")>] member inline this.ActionButtonContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonContent), (fun ctx x -> ctx.Element.ActionButtonContent <- x), x)
    [<CustomOperation("ActionButtonContent")>] member inline this.ActionButtonContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonContent), (fun ctx x -> ctx.Element.ActionButtonContent <- x), x)
    [<CustomOperation("ActionButtonStyle")>] member inline this.ActionButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonStyle), (fun ctx x -> ctx.Element.ActionButtonStyle <- x), x)
    [<CustomOperation("ActionButtonStyle")>] member inline this.ActionButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonStyle), (fun ctx x -> ctx.Element.ActionButtonStyle <- x), x)
    [<CustomOperation("CloseButtonCommand")>] member inline this.CloseButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommand), (fun ctx x -> ctx.Element.CloseButtonCommand <- x), x)
    [<CustomOperation("CloseButtonCommand")>] member inline this.CloseButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommand), (fun ctx x -> ctx.Element.CloseButtonCommand <- x), x)
    [<CustomOperation("CloseButtonCommandParameter")>] member inline this.CloseButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommandParameter), (fun ctx x -> ctx.Element.CloseButtonCommandParameter <- x), x)
    [<CustomOperation("CloseButtonCommandParameter")>] member inline this.CloseButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommandParameter), (fun ctx x -> ctx.Element.CloseButtonCommandParameter <- x), x)
    [<CustomOperation("CloseButtonContent")>] member inline this.CloseButtonContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonContent), (fun ctx x -> ctx.Element.CloseButtonContent <- x), x)
    [<CustomOperation("CloseButtonContent")>] member inline this.CloseButtonContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonContent), (fun ctx x -> ctx.Element.CloseButtonContent <- x), x)
    [<CustomOperation("CloseButtonStyle")>] member inline this.CloseButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonStyle), (fun ctx x -> ctx.Element.CloseButtonStyle <- x), x)
    [<CustomOperation("CloseButtonStyle")>] member inline this.CloseButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonStyle), (fun ctx x -> ctx.Element.CloseButtonStyle <- x), x)
    [<CustomOperation("HeroContent")>] member inline this.HeroContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeroContent), (fun ctx x -> ctx.Element.HeroContent <- x), x)
    [<CustomOperation("HeroContent")>] member inline this.HeroContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeroContent), (fun ctx x -> ctx.Element.HeroContent <- x), x)
    [<CustomOperation("HeroContentPlacement")>] member inline this.HeroContentPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TeachingTipHeroContentPlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeroContentPlacement), (fun ctx x -> ctx.Element.HeroContentPlacement <- x), x)
    [<CustomOperation("HeroContentPlacement")>] member inline this.HeroContentPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeroContentPlacement), (fun ctx x -> ctx.Element.HeroContentPlacement <- x), x)
    [<CustomOperation("IconSource")>] member inline this.IconSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IconSource), (fun ctx x -> ctx.Element.IconSource <- x), x)
    [<CustomOperation("IconSource")>] member inline this.IconSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IconSource), (fun ctx x -> ctx.Element.IconSource <- x), x)
    [<CustomOperation("IsLightDismissEnabled")>] member inline this.IsLightDismissEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsLightDismissEnabled), (fun ctx x -> ctx.Element.IsLightDismissEnabled <- x), x)
    [<CustomOperation("IsLightDismissEnabled")>] member inline this.IsLightDismissEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsLightDismissEnabled), (fun ctx x -> ctx.Element.IsLightDismissEnabled <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("PlacementMargin")>] member inline this.PlacementMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementMargin), (fun ctx x -> ctx.Element.PlacementMargin <- x), x)
    [<CustomOperation("PlacementMargin")>] member inline this.PlacementMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementMargin), (fun ctx x -> ctx.Element.PlacementMargin <- x), x)
    [<CustomOperation("PreferredPlacement")>] member inline this.PreferredPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TeachingTipPlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreferredPlacement), (fun ctx x -> ctx.Element.PreferredPlacement <- x), x)
    [<CustomOperation("PreferredPlacement")>] member inline this.PreferredPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreferredPlacement), (fun ctx x -> ctx.Element.PreferredPlacement <- x), x)
    [<CustomOperation("ShouldConstrainToRootBounds")>] member inline this.ShouldConstrainToRootBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldConstrainToRootBounds), (fun ctx x -> ctx.Element.ShouldConstrainToRootBounds <- x), x)
    [<CustomOperation("ShouldConstrainToRootBounds")>] member inline this.ShouldConstrainToRootBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldConstrainToRootBounds), (fun ctx x -> ctx.Element.ShouldConstrainToRootBounds <- x), x)
    [<CustomOperation("Subtitle")>] member inline this.Subtitle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Subtitle), (fun ctx x -> ctx.Element.Subtitle <- x), x)
    [<CustomOperation("Subtitle")>] member inline this.Subtitle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Subtitle), (fun ctx x -> ctx.Element.Subtitle <- x), x)
    [<CustomOperation("TailVisibility")>] member inline this.TailVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TeachingTipTailVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TailVisibility), (fun ctx x -> ctx.Element.TailVisibility <- x), x)
    [<CustomOperation("TailVisibility")>] member inline this.TailVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TailVisibility), (fun ctx x -> ctx.Element.TailVisibility <- x), x)
    [<CustomOperation("Target")>] member inline this.Target ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.FrameworkElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Target), (fun ctx x -> ctx.Element.Target <- x), x)
    [<CustomOperation("Target")>] member inline this.Target ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Target), (fun ctx x -> ctx.Element.Target <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

    [<CustomOperation("ActionButtonClick")>] member inline this.ActionButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButtonClick), "ActionButtonClick", fn)
    [<CustomOperation("CloseButtonClick")>] member inline this.CloseButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonClick), "CloseButtonClick", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
                

type ToolTipBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ToolTip>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.PlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("PlacementRect")>] member inline this.PlacementRect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<Windows.Foundation.Rect>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRect), (fun ctx x -> ctx.Element.PlacementRect <- x), x)
    [<CustomOperation("PlacementRect")>] member inline this.PlacementRect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRect), (fun ctx x -> ctx.Element.PlacementRect <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("PlacementTarget")>] member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementTarget), (fun ctx x -> ctx.Element.PlacementTarget <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)

    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type LoopingSelectorItemBuilder() =
    inherit ContentControlBuilder<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorItem>()


                

type NavigationViewItemPresenterBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.NavigationViewItemPresenter>() =
    inherit ContentControlBuilder<'Element>()

    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type PivotHeaderItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderItem>() =
    inherit ContentControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ItemsControlBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ItemsControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("DisplayMemberPath")>] member inline this.DisplayMemberPath ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMemberPath), (fun ctx x -> ctx.Element.DisplayMemberPath <- x), x)
    [<CustomOperation("DisplayMemberPath")>] member inline this.DisplayMemberPath ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMemberPath), (fun ctx x -> ctx.Element.DisplayMemberPath <- x), x)
    [<CustomOperation("GroupStyle")>] member inline this.GroupStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GroupStyle), x)
    [<CustomOperation("GroupStyle'")>] member inline this.GroupStyle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GroupStyle), x)
    [<CustomOperation("GroupStyleSelector")>] member inline this.GroupStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.GroupStyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupStyleSelector), (fun ctx x -> ctx.Element.GroupStyleSelector <- x), x)
    [<CustomOperation("GroupStyleSelector")>] member inline this.GroupStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupStyleSelector), (fun ctx x -> ctx.Element.GroupStyleSelector <- x), x)
    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerStyle")>] member inline this.ItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyle), (fun ctx x -> ctx.Element.ItemContainerStyle <- x), x)
    [<CustomOperation("ItemContainerStyle")>] member inline this.ItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyle), (fun ctx x -> ctx.Element.ItemContainerStyle <- x), x)
    [<CustomOperation("ItemContainerStyleSelector")>] member inline this.ItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.StyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyleSelector), (fun ctx x -> ctx.Element.ItemContainerStyleSelector <- x), x)
    [<CustomOperation("ItemContainerStyleSelector")>] member inline this.ItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyleSelector), (fun ctx x -> ctx.Element.ItemContainerStyleSelector <- x), x)
    [<CustomOperation("ItemContainerTransitions")>] member inline this.ItemContainerTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Animation.TransitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTransitions), (fun ctx x -> ctx.Element.ItemContainerTransitions <- x), x)
    [<CustomOperation("ItemContainerTransitions")>] member inline this.ItemContainerTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTransitions), (fun ctx x -> ctx.Element.ItemContainerTransitions <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplateSelector")>] member inline this.ItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplateSelector), (fun ctx x -> ctx.Element.ItemTemplateSelector <- x), x)
    [<CustomOperation("ItemTemplateSelector")>] member inline this.ItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplateSelector), (fun ctx x -> ctx.Element.ItemTemplateSelector <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ItemsPanelTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemsPanelRoot")>] member inline this.ItemsPanelRoot ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemsPanelRoot), x)
    [<CustomOperation("ItemsPanelRoot'")>] member inline this.ItemsPanelRoot' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemsPanelRoot), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type SelectorBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.Selector>() =
    inherit ItemsControlBuilder<'Element>()

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
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ListViewBaseBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListViewBase>() =
    inherit Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("CanDragItems")>] member inline this.CanDragItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanDragItems), (fun ctx x -> ctx.Element.CanDragItems <- x), x)
    [<CustomOperation("CanDragItems")>] member inline this.CanDragItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanDragItems), (fun ctx x -> ctx.Element.CanDragItems <- x), x)
    [<CustomOperation("CanReorderItems")>] member inline this.CanReorderItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderItems), (fun ctx x -> ctx.Element.CanReorderItems <- x), x)
    [<CustomOperation("CanReorderItems")>] member inline this.CanReorderItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderItems), (fun ctx x -> ctx.Element.CanReorderItems <- x), x)
    [<CustomOperation("DataFetchSize")>] member inline this.DataFetchSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DataFetchSize), (fun ctx x -> ctx.Element.DataFetchSize <- x), x)
    [<CustomOperation("DataFetchSize")>] member inline this.DataFetchSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DataFetchSize), (fun ctx x -> ctx.Element.DataFetchSize <- x), x)
    [<CustomOperation("Footer")>] member inline this.Footer ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Footer), (fun ctx x -> ctx.Element.Footer <- x), x)
    [<CustomOperation("Footer")>] member inline this.Footer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Footer), (fun ctx x -> ctx.Element.Footer <- x), x)
    [<CustomOperation("FooterTemplate")>] member inline this.FooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTemplate), (fun ctx x -> ctx.Element.FooterTemplate <- x), x)
    [<CustomOperation("FooterTemplate")>] member inline this.FooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTemplate), (fun ctx x -> ctx.Element.FooterTemplate <- x), x)
    [<CustomOperation("FooterTransitions")>] member inline this.FooterTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Animation.TransitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTransitions), (fun ctx x -> ctx.Element.FooterTransitions <- x), x)
    [<CustomOperation("FooterTransitions")>] member inline this.FooterTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTransitions), (fun ctx x -> ctx.Element.FooterTransitions <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTransitions")>] member inline this.HeaderTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Animation.TransitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTransitions), (fun ctx x -> ctx.Element.HeaderTransitions <- x), x)
    [<CustomOperation("HeaderTransitions")>] member inline this.HeaderTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTransitions), (fun ctx x -> ctx.Element.HeaderTransitions <- x), x)
    [<CustomOperation("IncrementalLoadingThreshold")>] member inline this.IncrementalLoadingThreshold ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IncrementalLoadingThreshold), (fun ctx x -> ctx.Element.IncrementalLoadingThreshold <- x), x)
    [<CustomOperation("IncrementalLoadingThreshold")>] member inline this.IncrementalLoadingThreshold ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IncrementalLoadingThreshold), (fun ctx x -> ctx.Element.IncrementalLoadingThreshold <- x), x)
    [<CustomOperation("IncrementalLoadingTrigger")>] member inline this.IncrementalLoadingTrigger ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IncrementalLoadingTrigger) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IncrementalLoadingTrigger), (fun ctx x -> ctx.Element.IncrementalLoadingTrigger <- x), x)
    [<CustomOperation("IncrementalLoadingTrigger")>] member inline this.IncrementalLoadingTrigger ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IncrementalLoadingTrigger), (fun ctx x -> ctx.Element.IncrementalLoadingTrigger <- x), x)
    [<CustomOperation("IsActiveView")>] member inline this.IsActiveView ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsActiveView), (fun ctx x -> ctx.Element.IsActiveView <- x), x)
    [<CustomOperation("IsActiveView")>] member inline this.IsActiveView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsActiveView), (fun ctx x -> ctx.Element.IsActiveView <- x), x)
    [<CustomOperation("IsItemClickEnabled")>] member inline this.IsItemClickEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsItemClickEnabled), (fun ctx x -> ctx.Element.IsItemClickEnabled <- x), x)
    [<CustomOperation("IsItemClickEnabled")>] member inline this.IsItemClickEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsItemClickEnabled), (fun ctx x -> ctx.Element.IsItemClickEnabled <- x), x)
    [<CustomOperation("IsMultiSelectCheckBoxEnabled")>] member inline this.IsMultiSelectCheckBoxEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsMultiSelectCheckBoxEnabled), (fun ctx x -> ctx.Element.IsMultiSelectCheckBoxEnabled <- x), x)
    [<CustomOperation("IsMultiSelectCheckBoxEnabled")>] member inline this.IsMultiSelectCheckBoxEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsMultiSelectCheckBoxEnabled), (fun ctx x -> ctx.Element.IsMultiSelectCheckBoxEnabled <- x), x)
    [<CustomOperation("IsSwipeEnabled")>] member inline this.IsSwipeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSwipeEnabled), (fun ctx x -> ctx.Element.IsSwipeEnabled <- x), x)
    [<CustomOperation("IsSwipeEnabled")>] member inline this.IsSwipeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSwipeEnabled), (fun ctx x -> ctx.Element.IsSwipeEnabled <- x), x)
    [<CustomOperation("IsZoomedInView")>] member inline this.IsZoomedInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomedInView), (fun ctx x -> ctx.Element.IsZoomedInView <- x), x)
    [<CustomOperation("IsZoomedInView")>] member inline this.IsZoomedInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomedInView), (fun ctx x -> ctx.Element.IsZoomedInView <- x), x)
    [<CustomOperation("ReorderMode")>] member inline this.ReorderMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ListViewReorderMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReorderMode), (fun ctx x -> ctx.Element.ReorderMode <- x), x)
    [<CustomOperation("ReorderMode")>] member inline this.ReorderMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReorderMode), (fun ctx x -> ctx.Element.ReorderMode <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems'")>] member inline this.SelectedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedRanges")>] member inline this.SelectedRanges ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedRanges), x)
    [<CustomOperation("SelectedRanges'")>] member inline this.SelectedRanges' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedRanges), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ListViewSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SemanticZoomOwner")>] member inline this.SemanticZoomOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SemanticZoom) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SemanticZoomOwner), (fun ctx x -> ctx.Element.SemanticZoomOwner <- x), x)
    [<CustomOperation("SemanticZoomOwner")>] member inline this.SemanticZoomOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SemanticZoomOwner), (fun ctx x -> ctx.Element.SemanticZoomOwner <- x), x)
    [<CustomOperation("ShowsScrollingPlaceholders")>] member inline this.ShowsScrollingPlaceholders ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsScrollingPlaceholders), (fun ctx x -> ctx.Element.ShowsScrollingPlaceholders <- x), x)
    [<CustomOperation("ShowsScrollingPlaceholders")>] member inline this.ShowsScrollingPlaceholders ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsScrollingPlaceholders), (fun ctx x -> ctx.Element.ShowsScrollingPlaceholders <- x), x)
    [<CustomOperation("SingleSelectionFollowsFocus")>] member inline this.SingleSelectionFollowsFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SingleSelectionFollowsFocus), (fun ctx x -> ctx.Element.SingleSelectionFollowsFocus <- x), x)
    [<CustomOperation("SingleSelectionFollowsFocus")>] member inline this.SingleSelectionFollowsFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SingleSelectionFollowsFocus), (fun ctx x -> ctx.Element.SingleSelectionFollowsFocus <- x), x)

    [<CustomOperation("ChoosingGroupHeaderContainer")>] member inline this.ChoosingGroupHeaderContainer ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ChoosingGroupHeaderContainer), "ChoosingGroupHeaderContainer", fn)
    [<CustomOperation("ChoosingItemContainer")>] member inline this.ChoosingItemContainer ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ChoosingItemContainer), "ChoosingItemContainer", fn)
    [<CustomOperation("ContainerContentChanging")>] member inline this.ContainerContentChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContainerContentChanging), "ContainerContentChanging", fn)
    [<CustomOperation("DragItemsCompleted")>] member inline this.DragItemsCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragItemsCompleted), "DragItemsCompleted", fn)
    [<CustomOperation("DragItemsStarting")>] member inline this.DragItemsStarting ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragItemsStarting), "DragItemsStarting", fn)
    [<CustomOperation("ItemClick")>] member inline this.ItemClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemClick), "ItemClick", fn)
                

type ListViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListView>() =
    inherit ListViewBaseBuilder<'Element>()


                

type TreeViewListBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TreeViewList>() =
    inherit ListViewBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type TabViewListViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.TabViewListView>() =
    inherit ListViewBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type GridViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.GridView>() =
    inherit ListViewBaseBuilder<'Element>()


                

type ComboBoxBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ComboBox>() =
    inherit Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsEditable")>] member inline this.IsEditable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEditable), (fun ctx x -> ctx.Element.IsEditable <- x), x)
    [<CustomOperation("IsEditable")>] member inline this.IsEditable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEditable), (fun ctx x -> ctx.Element.IsEditable <- x), x)
    [<CustomOperation("IsTextSearchEnabled")>] member inline this.IsTextSearchEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchEnabled), (fun ctx x -> ctx.Element.IsTextSearchEnabled <- x), x)
    [<CustomOperation("IsTextSearchEnabled")>] member inline this.IsTextSearchEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchEnabled), (fun ctx x -> ctx.Element.IsTextSearchEnabled <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("PlaceholderForeground")>] member inline this.PlaceholderForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderForeground), (fun ctx x -> ctx.Element.PlaceholderForeground <- x), x)
    [<CustomOperation("PlaceholderForeground")>] member inline this.PlaceholderForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderForeground), (fun ctx x -> ctx.Element.PlaceholderForeground <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("SelectionBoxItem")>] member inline this.SelectionBoxItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectionBoxItem), x)
    [<CustomOperation("SelectionBoxItem'")>] member inline this.SelectionBoxItem' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectionBoxItem), x)
    [<CustomOperation("SelectionBoxItemTemplate")>] member inline this.SelectionBoxItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectionBoxItemTemplate), x)
    [<CustomOperation("SelectionBoxItemTemplate'")>] member inline this.SelectionBoxItemTemplate' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectionBoxItemTemplate), x)
    [<CustomOperation("SelectionChangedTrigger")>] member inline this.SelectionChangedTrigger ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChangedTrigger), (fun ctx x -> ctx.Element.SelectionChangedTrigger <- x), x)
    [<CustomOperation("SelectionChangedTrigger")>] member inline this.SelectionChangedTrigger ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChangedTrigger), (fun ctx x -> ctx.Element.SelectionChangedTrigger <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextBoxStyle")>] member inline this.TextBoxStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextBoxStyle), (fun ctx x -> ctx.Element.TextBoxStyle <- x), x)
    [<CustomOperation("TextBoxStyle")>] member inline this.TextBoxStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextBoxStyle), (fun ctx x -> ctx.Element.TextBoxStyle <- x), x)

    [<CustomOperation("DropDownClosed")>] member inline this.DropDownClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownClosed), "DropDownClosed", fn)
    [<CustomOperation("DropDownOpened")>] member inline this.DropDownOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownOpened), "DropDownOpened", fn)
    [<CustomOperation("TextSubmitted")>] member inline this.TextSubmitted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextSubmitted), "TextSubmitted", fn)
                

type FlipViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.FlipView>() =
    inherit Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("UseTouchAnimationsForAllNavigation")>] member inline this.UseTouchAnimationsForAllNavigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseTouchAnimationsForAllNavigation), (fun ctx x -> ctx.Element.UseTouchAnimationsForAllNavigation <- x), x)
    [<CustomOperation("UseTouchAnimationsForAllNavigation")>] member inline this.UseTouchAnimationsForAllNavigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseTouchAnimationsForAllNavigation), (fun ctx x -> ctx.Element.UseTouchAnimationsForAllNavigation <- x), x)

                

type ListBoxBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ListBox>() =
    inherit Primitives.SelectorBuilder<'Element>()

    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems'")>] member inline this.SelectedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SingleSelectionFollowsFocus")>] member inline this.SingleSelectionFollowsFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SingleSelectionFollowsFocus), (fun ctx x -> ctx.Element.SingleSelectionFollowsFocus <- x), x)
    [<CustomOperation("SingleSelectionFollowsFocus")>] member inline this.SingleSelectionFollowsFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SingleSelectionFollowsFocus), (fun ctx x -> ctx.Element.SingleSelectionFollowsFocus <- x), x)

                

type AutoSuggestBoxBuilder() =
    inherit ItemsControlBuilder<Microsoft.UI.Xaml.Controls.AutoSuggestBox>()

    [<CustomOperation("AutoMaximizeSuggestionArea")>] member inline this.AutoMaximizeSuggestionArea ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoMaximizeSuggestionArea), (fun ctx x -> ctx.Element.AutoMaximizeSuggestionArea <- x), x)
    [<CustomOperation("AutoMaximizeSuggestionArea")>] member inline this.AutoMaximizeSuggestionArea ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoMaximizeSuggestionArea), (fun ctx x -> ctx.Element.AutoMaximizeSuggestionArea <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("IsSuggestionListOpen")>] member inline this.IsSuggestionListOpen ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSuggestionListOpen), (fun ctx x -> ctx.Element.IsSuggestionListOpen <- x), x)
    [<CustomOperation("IsSuggestionListOpen")>] member inline this.IsSuggestionListOpen ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSuggestionListOpen), (fun ctx x -> ctx.Element.IsSuggestionListOpen <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("MaxSuggestionListHeight")>] member inline this.MaxSuggestionListHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxSuggestionListHeight), (fun ctx x -> ctx.Element.MaxSuggestionListHeight <- x), x)
    [<CustomOperation("MaxSuggestionListHeight")>] member inline this.MaxSuggestionListHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxSuggestionListHeight), (fun ctx x -> ctx.Element.MaxSuggestionListHeight <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("QueryIcon")>] member inline this.QueryIcon ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.QueryIcon), (fun ctx x -> ctx.Element.QueryIcon <- x), x)
    [<CustomOperation("QueryIcon")>] member inline this.QueryIcon ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.QueryIcon), (fun ctx x -> ctx.Element.QueryIcon <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextBoxStyle")>] member inline this.TextBoxStyle ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextBoxStyle), (fun ctx x -> ctx.Element.TextBoxStyle <- x), x)
    [<CustomOperation("TextBoxStyle")>] member inline this.TextBoxStyle ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextBoxStyle), (fun ctx x -> ctx.Element.TextBoxStyle <- x), x)
    [<CustomOperation("TextMemberPath")>] member inline this.TextMemberPath ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextMemberPath), (fun ctx x -> ctx.Element.TextMemberPath <- x), x)
    [<CustomOperation("TextMemberPath")>] member inline this.TextMemberPath ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextMemberPath), (fun ctx x -> ctx.Element.TextMemberPath <- x), x)
    [<CustomOperation("UpdateTextOnSelect")>] member inline this.UpdateTextOnSelect ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UpdateTextOnSelect), (fun ctx x -> ctx.Element.UpdateTextOnSelect <- x), x)
    [<CustomOperation("UpdateTextOnSelect")>] member inline this.UpdateTextOnSelect ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UpdateTextOnSelect), (fun ctx x -> ctx.Element.UpdateTextOnSelect <- x), x)

    [<CustomOperation("QuerySubmitted")>] member inline this.QuerySubmitted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.QuerySubmitted), "QuerySubmitted", fn)
    [<CustomOperation("SuggestionChosen")>] member inline this.SuggestionChosen ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SuggestionChosen), "SuggestionChosen", fn)
    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
                

type CommandBarOverflowPresenterBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.CommandBarOverflowPresenter>() =
    inherit ItemsControlBuilder<'Element>()


                

type MenuFlyoutPresenterBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter>() =
    inherit ItemsControlBuilder<'Element>()

    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)
    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type PivotBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Pivot>() =
    inherit ItemsControlBuilder<'Element>()

    [<CustomOperation("HeaderFocusVisualPlacement")>] member inline this.HeaderFocusVisualPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.PivotHeaderFocusVisualPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderFocusVisualPlacement), (fun ctx x -> ctx.Element.HeaderFocusVisualPlacement <- x), x)
    [<CustomOperation("HeaderFocusVisualPlacement")>] member inline this.HeaderFocusVisualPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderFocusVisualPlacement), (fun ctx x -> ctx.Element.HeaderFocusVisualPlacement <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsHeaderItemsCarouselEnabled")>] member inline this.IsHeaderItemsCarouselEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHeaderItemsCarouselEnabled), (fun ctx x -> ctx.Element.IsHeaderItemsCarouselEnabled <- x), x)
    [<CustomOperation("IsHeaderItemsCarouselEnabled")>] member inline this.IsHeaderItemsCarouselEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHeaderItemsCarouselEnabled), (fun ctx x -> ctx.Element.IsHeaderItemsCarouselEnabled <- x), x)
    [<CustomOperation("IsLocked")>] member inline this.IsLocked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsLocked), (fun ctx x -> ctx.Element.IsLocked <- x), x)
    [<CustomOperation("IsLocked")>] member inline this.IsLocked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsLocked), (fun ctx x -> ctx.Element.IsLocked <- x), x)
    [<CustomOperation("LeftHeader")>] member inline this.LeftHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LeftHeader), (fun ctx x -> ctx.Element.LeftHeader <- x), x)
    [<CustomOperation("LeftHeader")>] member inline this.LeftHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LeftHeader), (fun ctx x -> ctx.Element.LeftHeader <- x), x)
    [<CustomOperation("LeftHeaderTemplate")>] member inline this.LeftHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LeftHeaderTemplate), (fun ctx x -> ctx.Element.LeftHeaderTemplate <- x), x)
    [<CustomOperation("LeftHeaderTemplate")>] member inline this.LeftHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LeftHeaderTemplate), (fun ctx x -> ctx.Element.LeftHeaderTemplate <- x), x)
    [<CustomOperation("RightHeader")>] member inline this.RightHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RightHeader), (fun ctx x -> ctx.Element.RightHeader <- x), x)
    [<CustomOperation("RightHeader")>] member inline this.RightHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RightHeader), (fun ctx x -> ctx.Element.RightHeader <- x), x)
    [<CustomOperation("RightHeaderTemplate")>] member inline this.RightHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RightHeaderTemplate), (fun ctx x -> ctx.Element.RightHeaderTemplate <- x), x)
    [<CustomOperation("RightHeaderTemplate")>] member inline this.RightHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RightHeaderTemplate), (fun ctx x -> ctx.Element.RightHeaderTemplate <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("TitleTemplate")>] member inline this.TitleTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TitleTemplate), (fun ctx x -> ctx.Element.TitleTemplate <- x), x)
    [<CustomOperation("TitleTemplate")>] member inline this.TitleTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TitleTemplate), (fun ctx x -> ctx.Element.TitleTemplate <- x), x)

    [<CustomOperation("PivotItemLoaded")>] member inline this.PivotItemLoaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PivotItemLoaded), "PivotItemLoaded", fn)
    [<CustomOperation("PivotItemLoading")>] member inline this.PivotItemLoading ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PivotItemLoading), "PivotItemLoading", fn)
    [<CustomOperation("PivotItemUnloaded")>] member inline this.PivotItemUnloaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PivotItemUnloaded), "PivotItemUnloaded", fn)
    [<CustomOperation("PivotItemUnloading")>] member inline this.PivotItemUnloading ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PivotItemUnloading), "PivotItemUnloading", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type MenuFlyoutItemBaseBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.MenuFlyoutItemBase>() =
    inherit ControlBuilder<'Element>()


                

type MenuFlyoutItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.MenuFlyoutItem>() =
    inherit MenuFlyoutItemBaseBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("KeyboardAcceleratorTextOverride")>] member inline this.KeyboardAcceleratorTextOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardAcceleratorTextOverride), (fun ctx x -> ctx.Element.KeyboardAcceleratorTextOverride <- x), x)
    [<CustomOperation("KeyboardAcceleratorTextOverride")>] member inline this.KeyboardAcceleratorTextOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardAcceleratorTextOverride), (fun ctx x -> ctx.Element.KeyboardAcceleratorTextOverride <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
                

type RadioMenuFlyoutItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem>() =
    inherit MenuFlyoutItemBuilder<'Element>()

    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)

                

type ToggleMenuFlyoutItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem>() =
    inherit MenuFlyoutItemBuilder<'Element>()

    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)

                

type MenuFlyoutSeparatorBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.MenuFlyoutSeparator>() =
    inherit MenuFlyoutItemBaseBuilder<'Element>()


                

type MenuFlyoutSubItemBuilder() =
    inherit MenuFlyoutItemBaseBuilder<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>()

    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>, x: Microsoft.UI.Xaml.Controls.IconElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type RangeBaseBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.RangeBase>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type SliderBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Slider>() =
    inherit Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IntermediateValue")>] member inline this.IntermediateValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IntermediateValue), (fun ctx x -> ctx.Element.IntermediateValue <- x), x)
    [<CustomOperation("IntermediateValue")>] member inline this.IntermediateValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IntermediateValue), (fun ctx x -> ctx.Element.IntermediateValue <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsThumbToolTipEnabled")>] member inline this.IsThumbToolTipEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsThumbToolTipEnabled), (fun ctx x -> ctx.Element.IsThumbToolTipEnabled <- x), x)
    [<CustomOperation("IsThumbToolTipEnabled")>] member inline this.IsThumbToolTipEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsThumbToolTipEnabled), (fun ctx x -> ctx.Element.IsThumbToolTipEnabled <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("SnapsTo")>] member inline this.SnapsTo ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.SliderSnapsTo) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SnapsTo), (fun ctx x -> ctx.Element.SnapsTo <- x), x)
    [<CustomOperation("SnapsTo")>] member inline this.SnapsTo ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SnapsTo), (fun ctx x -> ctx.Element.SnapsTo <- x), x)
    [<CustomOperation("StepFrequency")>] member inline this.StepFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StepFrequency), (fun ctx x -> ctx.Element.StepFrequency <- x), x)
    [<CustomOperation("StepFrequency")>] member inline this.StepFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StepFrequency), (fun ctx x -> ctx.Element.StepFrequency <- x), x)
    [<CustomOperation("ThumbToolTipValueConverter")>] member inline this.ThumbToolTipValueConverter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Data.IValueConverter) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ThumbToolTipValueConverter), (fun ctx x -> ctx.Element.ThumbToolTipValueConverter <- x), x)
    [<CustomOperation("ThumbToolTipValueConverter")>] member inline this.ThumbToolTipValueConverter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ThumbToolTipValueConverter), (fun ctx x -> ctx.Element.ThumbToolTipValueConverter <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickPlacement")>] member inline this.TickPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.TickPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickPlacement), (fun ctx x -> ctx.Element.TickPlacement <- x), x)
    [<CustomOperation("TickPlacement")>] member inline this.TickPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickPlacement), (fun ctx x -> ctx.Element.TickPlacement <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ColorPickerSliderBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.ColorPickerSlider>() =
    inherit SliderBuilder<'Element>()

    [<CustomOperation("ColorChannel")>] member inline this.ColorChannel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ColorPickerHsvChannel) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorChannel), (fun ctx x -> ctx.Element.ColorChannel <- x), x)
    [<CustomOperation("ColorChannel")>] member inline this.ColorChannel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColorChannel), (fun ctx x -> ctx.Element.ColorChannel <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ProgressBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ProgressBar>() =
    inherit Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("ShowError")>] member inline this.ShowError ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowError), (fun ctx x -> ctx.Element.ShowError <- x), x)
    [<CustomOperation("ShowError")>] member inline this.ShowError ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowError), (fun ctx x -> ctx.Element.ShowError <- x), x)
    [<CustomOperation("ShowPaused")>] member inline this.ShowPaused ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowPaused), (fun ctx x -> ctx.Element.ShowPaused <- x), x)
    [<CustomOperation("ShowPaused")>] member inline this.ShowPaused ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowPaused), (fun ctx x -> ctx.Element.ShowPaused <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ScrollBarBuilder() =
    inherit Primitives.RangeBaseBuilder<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>()

    [<CustomOperation("IndicatorMode")>] member inline this.IndicatorMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, x: Microsoft.UI.Xaml.Controls.Primitives.ScrollingIndicatorMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorMode), (fun ctx x -> ctx.Element.IndicatorMode <- x), x)
    [<CustomOperation("IndicatorMode")>] member inline this.IndicatorMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorMode), (fun ctx x -> ctx.Element.IndicatorMode <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)

    [<CustomOperation("Scroll")>] member inline this.Scroll ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scroll), "Scroll", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type UserControlBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.UserControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)

                

type PageBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Page>() =
    inherit UserControlBuilder<'Element>()

    [<CustomOperation("BottomAppBar")>] member inline this.BottomAppBar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.AppBar) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BottomAppBar), (fun ctx x -> ctx.Element.BottomAppBar <- x), x)
    [<CustomOperation("BottomAppBar")>] member inline this.BottomAppBar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BottomAppBar), (fun ctx x -> ctx.Element.BottomAppBar <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Frame), x)
    [<CustomOperation("Frame'")>] member inline this.Frame' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Frame), x)
    [<CustomOperation("NavigationCacheMode")>] member inline this.NavigationCacheMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Navigation.NavigationCacheMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigationCacheMode), (fun ctx x -> ctx.Element.NavigationCacheMode <- x), x)
    [<CustomOperation("NavigationCacheMode")>] member inline this.NavigationCacheMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NavigationCacheMode), (fun ctx x -> ctx.Element.NavigationCacheMode <- x), x)
    [<CustomOperation("TopAppBar")>] member inline this.TopAppBar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.AppBar) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TopAppBar), (fun ctx x -> ctx.Element.TopAppBar <- x), x)
    [<CustomOperation("TopAppBar")>] member inline this.TopAppBar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TopAppBar), (fun ctx x -> ctx.Element.TopAppBar <- x), x)

                

type AppBarSeparatorBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.AppBarSeparator>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("DynamicOverflowOrder")>] member inline this.DynamicOverflowOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DynamicOverflowOrder), (fun ctx x -> ctx.Element.DynamicOverflowOrder <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)
    [<CustomOperation("IsCompact")>] member inline this.IsCompact ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCompact), (fun ctx x -> ctx.Element.IsCompact <- x), x)

                

type BreadcrumbBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.BreadcrumbBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)

    [<CustomOperation("ItemClicked")>] member inline this.ItemClicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemClicked), "ItemClicked", fn)
                

type CalendarDatePickerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.CalendarDatePicker>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("CalendarIdentifier")>] member inline this.CalendarIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarIdentifier), (fun ctx x -> ctx.Element.CalendarIdentifier <- x), x)
    [<CustomOperation("CalendarIdentifier")>] member inline this.CalendarIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarIdentifier), (fun ctx x -> ctx.Element.CalendarIdentifier <- x), x)
    [<CustomOperation("CalendarViewStyle")>] member inline this.CalendarViewStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarViewStyle), (fun ctx x -> ctx.Element.CalendarViewStyle <- x), x)
    [<CustomOperation("CalendarViewStyle")>] member inline this.CalendarViewStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarViewStyle), (fun ctx x -> ctx.Element.CalendarViewStyle <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTimeOffset>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("DateFormat")>] member inline this.DateFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DateFormat), (fun ctx x -> ctx.Element.DateFormat <- x), x)
    [<CustomOperation("DateFormat")>] member inline this.DateFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DateFormat), (fun ctx x -> ctx.Element.DateFormat <- x), x)
    [<CustomOperation("DayOfWeekFormat")>] member inline this.DayOfWeekFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayOfWeekFormat), (fun ctx x -> ctx.Element.DayOfWeekFormat <- x), x)
    [<CustomOperation("DayOfWeekFormat")>] member inline this.DayOfWeekFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayOfWeekFormat), (fun ctx x -> ctx.Element.DayOfWeekFormat <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CalendarViewDisplayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.Globalization.DayOfWeek) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsCalendarOpen")>] member inline this.IsCalendarOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCalendarOpen), (fun ctx x -> ctx.Element.IsCalendarOpen <- x), x)
    [<CustomOperation("IsCalendarOpen")>] member inline this.IsCalendarOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCalendarOpen), (fun ctx x -> ctx.Element.IsCalendarOpen <- x), x)
    [<CustomOperation("IsGroupLabelVisible")>] member inline this.IsGroupLabelVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroupLabelVisible), (fun ctx x -> ctx.Element.IsGroupLabelVisible <- x), x)
    [<CustomOperation("IsGroupLabelVisible")>] member inline this.IsGroupLabelVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroupLabelVisible), (fun ctx x -> ctx.Element.IsGroupLabelVisible <- x), x)
    [<CustomOperation("IsOutOfScopeEnabled")>] member inline this.IsOutOfScopeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOutOfScopeEnabled), (fun ctx x -> ctx.Element.IsOutOfScopeEnabled <- x), x)
    [<CustomOperation("IsOutOfScopeEnabled")>] member inline this.IsOutOfScopeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOutOfScopeEnabled), (fun ctx x -> ctx.Element.IsOutOfScopeEnabled <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("MaxDate")>] member inline this.MaxDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDate), (fun ctx x -> ctx.Element.MaxDate <- x), x)
    [<CustomOperation("MaxDate")>] member inline this.MaxDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDate), (fun ctx x -> ctx.Element.MaxDate <- x), x)
    [<CustomOperation("MinDate")>] member inline this.MinDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinDate), (fun ctx x -> ctx.Element.MinDate <- x), x)
    [<CustomOperation("MinDate")>] member inline this.MinDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinDate), (fun ctx x -> ctx.Element.MinDate <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)

    [<CustomOperation("CalendarViewDayItemChanging")>] member inline this.CalendarViewDayItemChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarViewDayItemChanging), "CalendarViewDayItemChanging", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("DateChanged")>] member inline this.DateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DateChanged), "DateChanged", fn)
    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
                

type CalendarViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.CalendarView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("BlackoutBackground")>] member inline this.BlackoutBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BlackoutBackground), (fun ctx x -> ctx.Element.BlackoutBackground <- x), x)
    [<CustomOperation("BlackoutBackground")>] member inline this.BlackoutBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BlackoutBackground), (fun ctx x -> ctx.Element.BlackoutBackground <- x), x)
    [<CustomOperation("BlackoutForeground")>] member inline this.BlackoutForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BlackoutForeground), (fun ctx x -> ctx.Element.BlackoutForeground <- x), x)
    [<CustomOperation("BlackoutForeground")>] member inline this.BlackoutForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BlackoutForeground), (fun ctx x -> ctx.Element.BlackoutForeground <- x), x)
    [<CustomOperation("BlackoutStrikethroughBrush")>] member inline this.BlackoutStrikethroughBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BlackoutStrikethroughBrush), (fun ctx x -> ctx.Element.BlackoutStrikethroughBrush <- x), x)
    [<CustomOperation("BlackoutStrikethroughBrush")>] member inline this.BlackoutStrikethroughBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BlackoutStrikethroughBrush), (fun ctx x -> ctx.Element.BlackoutStrikethroughBrush <- x), x)
    [<CustomOperation("CalendarIdentifier")>] member inline this.CalendarIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarIdentifier), (fun ctx x -> ctx.Element.CalendarIdentifier <- x), x)
    [<CustomOperation("CalendarIdentifier")>] member inline this.CalendarIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarIdentifier), (fun ctx x -> ctx.Element.CalendarIdentifier <- x), x)
    [<CustomOperation("CalendarItemBackground")>] member inline this.CalendarItemBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemBackground), (fun ctx x -> ctx.Element.CalendarItemBackground <- x), x)
    [<CustomOperation("CalendarItemBackground")>] member inline this.CalendarItemBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemBackground), (fun ctx x -> ctx.Element.CalendarItemBackground <- x), x)
    [<CustomOperation("CalendarItemBorderBrush")>] member inline this.CalendarItemBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemBorderBrush), (fun ctx x -> ctx.Element.CalendarItemBorderBrush <- x), x)
    [<CustomOperation("CalendarItemBorderBrush")>] member inline this.CalendarItemBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemBorderBrush), (fun ctx x -> ctx.Element.CalendarItemBorderBrush <- x), x)
    [<CustomOperation("CalendarItemBorderThickness")>] member inline this.CalendarItemBorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemBorderThickness), (fun ctx x -> ctx.Element.CalendarItemBorderThickness <- x), x)
    [<CustomOperation("CalendarItemBorderThickness")>] member inline this.CalendarItemBorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemBorderThickness), (fun ctx x -> ctx.Element.CalendarItemBorderThickness <- x), x)
    [<CustomOperation("CalendarItemCornerRadius")>] member inline this.CalendarItemCornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemCornerRadius), (fun ctx x -> ctx.Element.CalendarItemCornerRadius <- x), x)
    [<CustomOperation("CalendarItemCornerRadius")>] member inline this.CalendarItemCornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemCornerRadius), (fun ctx x -> ctx.Element.CalendarItemCornerRadius <- x), x)
    [<CustomOperation("CalendarItemDisabledBackground")>] member inline this.CalendarItemDisabledBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemDisabledBackground), (fun ctx x -> ctx.Element.CalendarItemDisabledBackground <- x), x)
    [<CustomOperation("CalendarItemDisabledBackground")>] member inline this.CalendarItemDisabledBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemDisabledBackground), (fun ctx x -> ctx.Element.CalendarItemDisabledBackground <- x), x)
    [<CustomOperation("CalendarItemForeground")>] member inline this.CalendarItemForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemForeground), (fun ctx x -> ctx.Element.CalendarItemForeground <- x), x)
    [<CustomOperation("CalendarItemForeground")>] member inline this.CalendarItemForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemForeground), (fun ctx x -> ctx.Element.CalendarItemForeground <- x), x)
    [<CustomOperation("CalendarItemHoverBackground")>] member inline this.CalendarItemHoverBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemHoverBackground), (fun ctx x -> ctx.Element.CalendarItemHoverBackground <- x), x)
    [<CustomOperation("CalendarItemHoverBackground")>] member inline this.CalendarItemHoverBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemHoverBackground), (fun ctx x -> ctx.Element.CalendarItemHoverBackground <- x), x)
    [<CustomOperation("CalendarItemPressedBackground")>] member inline this.CalendarItemPressedBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemPressedBackground), (fun ctx x -> ctx.Element.CalendarItemPressedBackground <- x), x)
    [<CustomOperation("CalendarItemPressedBackground")>] member inline this.CalendarItemPressedBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarItemPressedBackground), (fun ctx x -> ctx.Element.CalendarItemPressedBackground <- x), x)
    [<CustomOperation("CalendarViewDayItemStyle")>] member inline this.CalendarViewDayItemStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarViewDayItemStyle), (fun ctx x -> ctx.Element.CalendarViewDayItemStyle <- x), x)
    [<CustomOperation("CalendarViewDayItemStyle")>] member inline this.CalendarViewDayItemStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarViewDayItemStyle), (fun ctx x -> ctx.Element.CalendarViewDayItemStyle <- x), x)
    [<CustomOperation("DayItemFontFamily")>] member inline this.DayItemFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontFamily), (fun ctx x -> ctx.Element.DayItemFontFamily <- x), x)
    [<CustomOperation("DayItemFontFamily")>] member inline this.DayItemFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontFamily), (fun ctx x -> ctx.Element.DayItemFontFamily <- x), x)
    [<CustomOperation("DayItemFontSize")>] member inline this.DayItemFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontSize), (fun ctx x -> ctx.Element.DayItemFontSize <- x), x)
    [<CustomOperation("DayItemFontSize")>] member inline this.DayItemFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontSize), (fun ctx x -> ctx.Element.DayItemFontSize <- x), x)
    [<CustomOperation("DayItemFontStyle")>] member inline this.DayItemFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontStyle), (fun ctx x -> ctx.Element.DayItemFontStyle <- x), x)
    [<CustomOperation("DayItemFontStyle")>] member inline this.DayItemFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontStyle), (fun ctx x -> ctx.Element.DayItemFontStyle <- x), x)
    [<CustomOperation("DayItemFontWeight")>] member inline this.DayItemFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontWeight), (fun ctx x -> ctx.Element.DayItemFontWeight <- x), x)
    [<CustomOperation("DayItemFontWeight")>] member inline this.DayItemFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemFontWeight), (fun ctx x -> ctx.Element.DayItemFontWeight <- x), x)
    [<CustomOperation("DayItemMargin")>] member inline this.DayItemMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemMargin), (fun ctx x -> ctx.Element.DayItemMargin <- x), x)
    [<CustomOperation("DayItemMargin")>] member inline this.DayItemMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayItemMargin), (fun ctx x -> ctx.Element.DayItemMargin <- x), x)
    [<CustomOperation("DayOfWeekFormat")>] member inline this.DayOfWeekFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayOfWeekFormat), (fun ctx x -> ctx.Element.DayOfWeekFormat <- x), x)
    [<CustomOperation("DayOfWeekFormat")>] member inline this.DayOfWeekFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayOfWeekFormat), (fun ctx x -> ctx.Element.DayOfWeekFormat <- x), x)
    [<CustomOperation("DisabledForeground")>] member inline this.DisabledForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisabledForeground), (fun ctx x -> ctx.Element.DisabledForeground <- x), x)
    [<CustomOperation("DisabledForeground")>] member inline this.DisabledForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisabledForeground), (fun ctx x -> ctx.Element.DisabledForeground <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CalendarViewDisplayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.Globalization.DayOfWeek) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontFamily")>] member inline this.FirstOfMonthLabelFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontFamily), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontFamily <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontFamily")>] member inline this.FirstOfMonthLabelFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontFamily), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontFamily <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontSize")>] member inline this.FirstOfMonthLabelFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontSize), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontSize <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontSize")>] member inline this.FirstOfMonthLabelFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontSize), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontSize <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontStyle")>] member inline this.FirstOfMonthLabelFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontStyle), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontStyle <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontStyle")>] member inline this.FirstOfMonthLabelFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontStyle), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontStyle <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontWeight")>] member inline this.FirstOfMonthLabelFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontWeight), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontWeight <- x), x)
    [<CustomOperation("FirstOfMonthLabelFontWeight")>] member inline this.FirstOfMonthLabelFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelFontWeight), (fun ctx x -> ctx.Element.FirstOfMonthLabelFontWeight <- x), x)
    [<CustomOperation("FirstOfMonthLabelMargin")>] member inline this.FirstOfMonthLabelMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelMargin), (fun ctx x -> ctx.Element.FirstOfMonthLabelMargin <- x), x)
    [<CustomOperation("FirstOfMonthLabelMargin")>] member inline this.FirstOfMonthLabelMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfMonthLabelMargin), (fun ctx x -> ctx.Element.FirstOfMonthLabelMargin <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontFamily")>] member inline this.FirstOfYearDecadeLabelFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontFamily), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontFamily <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontFamily")>] member inline this.FirstOfYearDecadeLabelFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontFamily), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontFamily <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontSize")>] member inline this.FirstOfYearDecadeLabelFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontSize), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontSize <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontSize")>] member inline this.FirstOfYearDecadeLabelFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontSize), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontSize <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontStyle")>] member inline this.FirstOfYearDecadeLabelFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontStyle), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontStyle <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontStyle")>] member inline this.FirstOfYearDecadeLabelFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontStyle), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontStyle <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontWeight")>] member inline this.FirstOfYearDecadeLabelFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontWeight), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontWeight <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelFontWeight")>] member inline this.FirstOfYearDecadeLabelFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelFontWeight), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelFontWeight <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelMargin")>] member inline this.FirstOfYearDecadeLabelMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelMargin), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelMargin <- x), x)
    [<CustomOperation("FirstOfYearDecadeLabelMargin")>] member inline this.FirstOfYearDecadeLabelMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstOfYearDecadeLabelMargin), (fun ctx x -> ctx.Element.FirstOfYearDecadeLabelMargin <- x), x)
    [<CustomOperation("FocusBorderBrush")>] member inline this.FocusBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FocusBorderBrush), (fun ctx x -> ctx.Element.FocusBorderBrush <- x), x)
    [<CustomOperation("FocusBorderBrush")>] member inline this.FocusBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FocusBorderBrush), (fun ctx x -> ctx.Element.FocusBorderBrush <- x), x)
    [<CustomOperation("HorizontalDayItemAlignment")>] member inline this.HorizontalDayItemAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalDayItemAlignment), (fun ctx x -> ctx.Element.HorizontalDayItemAlignment <- x), x)
    [<CustomOperation("HorizontalDayItemAlignment")>] member inline this.HorizontalDayItemAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalDayItemAlignment), (fun ctx x -> ctx.Element.HorizontalDayItemAlignment <- x), x)
    [<CustomOperation("HorizontalFirstOfMonthLabelAlignment")>] member inline this.HorizontalFirstOfMonthLabelAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalFirstOfMonthLabelAlignment), (fun ctx x -> ctx.Element.HorizontalFirstOfMonthLabelAlignment <- x), x)
    [<CustomOperation("HorizontalFirstOfMonthLabelAlignment")>] member inline this.HorizontalFirstOfMonthLabelAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalFirstOfMonthLabelAlignment), (fun ctx x -> ctx.Element.HorizontalFirstOfMonthLabelAlignment <- x), x)
    [<CustomOperation("HoverBorderBrush")>] member inline this.HoverBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HoverBorderBrush), (fun ctx x -> ctx.Element.HoverBorderBrush <- x), x)
    [<CustomOperation("HoverBorderBrush")>] member inline this.HoverBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HoverBorderBrush), (fun ctx x -> ctx.Element.HoverBorderBrush <- x), x)
    [<CustomOperation("IsGroupLabelVisible")>] member inline this.IsGroupLabelVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroupLabelVisible), (fun ctx x -> ctx.Element.IsGroupLabelVisible <- x), x)
    [<CustomOperation("IsGroupLabelVisible")>] member inline this.IsGroupLabelVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroupLabelVisible), (fun ctx x -> ctx.Element.IsGroupLabelVisible <- x), x)
    [<CustomOperation("IsOutOfScopeEnabled")>] member inline this.IsOutOfScopeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOutOfScopeEnabled), (fun ctx x -> ctx.Element.IsOutOfScopeEnabled <- x), x)
    [<CustomOperation("IsOutOfScopeEnabled")>] member inline this.IsOutOfScopeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOutOfScopeEnabled), (fun ctx x -> ctx.Element.IsOutOfScopeEnabled <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("MaxDate")>] member inline this.MaxDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDate), (fun ctx x -> ctx.Element.MaxDate <- x), x)
    [<CustomOperation("MaxDate")>] member inline this.MaxDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDate), (fun ctx x -> ctx.Element.MaxDate <- x), x)
    [<CustomOperation("MinDate")>] member inline this.MinDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinDate), (fun ctx x -> ctx.Element.MinDate <- x), x)
    [<CustomOperation("MinDate")>] member inline this.MinDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinDate), (fun ctx x -> ctx.Element.MinDate <- x), x)
    [<CustomOperation("MonthYearItemFontFamily")>] member inline this.MonthYearItemFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontFamily), (fun ctx x -> ctx.Element.MonthYearItemFontFamily <- x), x)
    [<CustomOperation("MonthYearItemFontFamily")>] member inline this.MonthYearItemFontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontFamily), (fun ctx x -> ctx.Element.MonthYearItemFontFamily <- x), x)
    [<CustomOperation("MonthYearItemFontSize")>] member inline this.MonthYearItemFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontSize), (fun ctx x -> ctx.Element.MonthYearItemFontSize <- x), x)
    [<CustomOperation("MonthYearItemFontSize")>] member inline this.MonthYearItemFontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontSize), (fun ctx x -> ctx.Element.MonthYearItemFontSize <- x), x)
    [<CustomOperation("MonthYearItemFontStyle")>] member inline this.MonthYearItemFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontStyle), (fun ctx x -> ctx.Element.MonthYearItemFontStyle <- x), x)
    [<CustomOperation("MonthYearItemFontStyle")>] member inline this.MonthYearItemFontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontStyle), (fun ctx x -> ctx.Element.MonthYearItemFontStyle <- x), x)
    [<CustomOperation("MonthYearItemFontWeight")>] member inline this.MonthYearItemFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontWeight), (fun ctx x -> ctx.Element.MonthYearItemFontWeight <- x), x)
    [<CustomOperation("MonthYearItemFontWeight")>] member inline this.MonthYearItemFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemFontWeight), (fun ctx x -> ctx.Element.MonthYearItemFontWeight <- x), x)
    [<CustomOperation("MonthYearItemMargin")>] member inline this.MonthYearItemMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemMargin), (fun ctx x -> ctx.Element.MonthYearItemMargin <- x), x)
    [<CustomOperation("MonthYearItemMargin")>] member inline this.MonthYearItemMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthYearItemMargin), (fun ctx x -> ctx.Element.MonthYearItemMargin <- x), x)
    [<CustomOperation("NumberOfWeeksInView")>] member inline this.NumberOfWeeksInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfWeeksInView), (fun ctx x -> ctx.Element.NumberOfWeeksInView <- x), x)
    [<CustomOperation("NumberOfWeeksInView")>] member inline this.NumberOfWeeksInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfWeeksInView), (fun ctx x -> ctx.Element.NumberOfWeeksInView <- x), x)
    [<CustomOperation("OutOfScopeBackground")>] member inline this.OutOfScopeBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopeBackground), (fun ctx x -> ctx.Element.OutOfScopeBackground <- x), x)
    [<CustomOperation("OutOfScopeBackground")>] member inline this.OutOfScopeBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopeBackground), (fun ctx x -> ctx.Element.OutOfScopeBackground <- x), x)
    [<CustomOperation("OutOfScopeForeground")>] member inline this.OutOfScopeForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopeForeground), (fun ctx x -> ctx.Element.OutOfScopeForeground <- x), x)
    [<CustomOperation("OutOfScopeForeground")>] member inline this.OutOfScopeForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopeForeground), (fun ctx x -> ctx.Element.OutOfScopeForeground <- x), x)
    [<CustomOperation("OutOfScopeHoverForeground")>] member inline this.OutOfScopeHoverForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopeHoverForeground), (fun ctx x -> ctx.Element.OutOfScopeHoverForeground <- x), x)
    [<CustomOperation("OutOfScopeHoverForeground")>] member inline this.OutOfScopeHoverForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopeHoverForeground), (fun ctx x -> ctx.Element.OutOfScopeHoverForeground <- x), x)
    [<CustomOperation("OutOfScopePressedForeground")>] member inline this.OutOfScopePressedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopePressedForeground), (fun ctx x -> ctx.Element.OutOfScopePressedForeground <- x), x)
    [<CustomOperation("OutOfScopePressedForeground")>] member inline this.OutOfScopePressedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OutOfScopePressedForeground), (fun ctx x -> ctx.Element.OutOfScopePressedForeground <- x), x)
    [<CustomOperation("PressedBorderBrush")>] member inline this.PressedBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PressedBorderBrush), (fun ctx x -> ctx.Element.PressedBorderBrush <- x), x)
    [<CustomOperation("PressedBorderBrush")>] member inline this.PressedBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PressedBorderBrush), (fun ctx x -> ctx.Element.PressedBorderBrush <- x), x)
    [<CustomOperation("PressedForeground")>] member inline this.PressedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PressedForeground), (fun ctx x -> ctx.Element.PressedForeground <- x), x)
    [<CustomOperation("PressedForeground")>] member inline this.PressedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PressedForeground), (fun ctx x -> ctx.Element.PressedForeground <- x), x)
    [<CustomOperation("SelectedBorderBrush")>] member inline this.SelectedBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedBorderBrush), (fun ctx x -> ctx.Element.SelectedBorderBrush <- x), x)
    [<CustomOperation("SelectedBorderBrush")>] member inline this.SelectedBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedBorderBrush), (fun ctx x -> ctx.Element.SelectedBorderBrush <- x), x)
    [<CustomOperation("SelectedDates")>] member inline this.SelectedDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectedDates'")>] member inline this.SelectedDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectedDisabledBorderBrush")>] member inline this.SelectedDisabledBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDisabledBorderBrush), (fun ctx x -> ctx.Element.SelectedDisabledBorderBrush <- x), x)
    [<CustomOperation("SelectedDisabledBorderBrush")>] member inline this.SelectedDisabledBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDisabledBorderBrush), (fun ctx x -> ctx.Element.SelectedDisabledBorderBrush <- x), x)
    [<CustomOperation("SelectedDisabledForeground")>] member inline this.SelectedDisabledForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDisabledForeground), (fun ctx x -> ctx.Element.SelectedDisabledForeground <- x), x)
    [<CustomOperation("SelectedDisabledForeground")>] member inline this.SelectedDisabledForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDisabledForeground), (fun ctx x -> ctx.Element.SelectedDisabledForeground <- x), x)
    [<CustomOperation("SelectedForeground")>] member inline this.SelectedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedForeground), (fun ctx x -> ctx.Element.SelectedForeground <- x), x)
    [<CustomOperation("SelectedForeground")>] member inline this.SelectedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedForeground), (fun ctx x -> ctx.Element.SelectedForeground <- x), x)
    [<CustomOperation("SelectedHoverBorderBrush")>] member inline this.SelectedHoverBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedHoverBorderBrush), (fun ctx x -> ctx.Element.SelectedHoverBorderBrush <- x), x)
    [<CustomOperation("SelectedHoverBorderBrush")>] member inline this.SelectedHoverBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedHoverBorderBrush), (fun ctx x -> ctx.Element.SelectedHoverBorderBrush <- x), x)
    [<CustomOperation("SelectedHoverForeground")>] member inline this.SelectedHoverForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedHoverForeground), (fun ctx x -> ctx.Element.SelectedHoverForeground <- x), x)
    [<CustomOperation("SelectedHoverForeground")>] member inline this.SelectedHoverForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedHoverForeground), (fun ctx x -> ctx.Element.SelectedHoverForeground <- x), x)
    [<CustomOperation("SelectedPressedBorderBrush")>] member inline this.SelectedPressedBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPressedBorderBrush), (fun ctx x -> ctx.Element.SelectedPressedBorderBrush <- x), x)
    [<CustomOperation("SelectedPressedBorderBrush")>] member inline this.SelectedPressedBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPressedBorderBrush), (fun ctx x -> ctx.Element.SelectedPressedBorderBrush <- x), x)
    [<CustomOperation("SelectedPressedForeground")>] member inline this.SelectedPressedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPressedForeground), (fun ctx x -> ctx.Element.SelectedPressedForeground <- x), x)
    [<CustomOperation("SelectedPressedForeground")>] member inline this.SelectedPressedForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPressedForeground), (fun ctx x -> ctx.Element.SelectedPressedForeground <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CalendarViewSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TodayBackground")>] member inline this.TodayBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayBackground), (fun ctx x -> ctx.Element.TodayBackground <- x), x)
    [<CustomOperation("TodayBackground")>] member inline this.TodayBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayBackground), (fun ctx x -> ctx.Element.TodayBackground <- x), x)
    [<CustomOperation("TodayBlackoutBackground")>] member inline this.TodayBlackoutBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayBlackoutBackground), (fun ctx x -> ctx.Element.TodayBlackoutBackground <- x), x)
    [<CustomOperation("TodayBlackoutBackground")>] member inline this.TodayBlackoutBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayBlackoutBackground), (fun ctx x -> ctx.Element.TodayBlackoutBackground <- x), x)
    [<CustomOperation("TodayBlackoutForeground")>] member inline this.TodayBlackoutForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayBlackoutForeground), (fun ctx x -> ctx.Element.TodayBlackoutForeground <- x), x)
    [<CustomOperation("TodayBlackoutForeground")>] member inline this.TodayBlackoutForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayBlackoutForeground), (fun ctx x -> ctx.Element.TodayBlackoutForeground <- x), x)
    [<CustomOperation("TodayDisabledBackground")>] member inline this.TodayDisabledBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayDisabledBackground), (fun ctx x -> ctx.Element.TodayDisabledBackground <- x), x)
    [<CustomOperation("TodayDisabledBackground")>] member inline this.TodayDisabledBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayDisabledBackground), (fun ctx x -> ctx.Element.TodayDisabledBackground <- x), x)
    [<CustomOperation("TodayFontWeight")>] member inline this.TodayFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Text.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayFontWeight), (fun ctx x -> ctx.Element.TodayFontWeight <- x), x)
    [<CustomOperation("TodayFontWeight")>] member inline this.TodayFontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayFontWeight), (fun ctx x -> ctx.Element.TodayFontWeight <- x), x)
    [<CustomOperation("TodayForeground")>] member inline this.TodayForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayForeground), (fun ctx x -> ctx.Element.TodayForeground <- x), x)
    [<CustomOperation("TodayForeground")>] member inline this.TodayForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayForeground), (fun ctx x -> ctx.Element.TodayForeground <- x), x)
    [<CustomOperation("TodayHoverBackground")>] member inline this.TodayHoverBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayHoverBackground), (fun ctx x -> ctx.Element.TodayHoverBackground <- x), x)
    [<CustomOperation("TodayHoverBackground")>] member inline this.TodayHoverBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayHoverBackground), (fun ctx x -> ctx.Element.TodayHoverBackground <- x), x)
    [<CustomOperation("TodayPressedBackground")>] member inline this.TodayPressedBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodayPressedBackground), (fun ctx x -> ctx.Element.TodayPressedBackground <- x), x)
    [<CustomOperation("TodayPressedBackground")>] member inline this.TodayPressedBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodayPressedBackground), (fun ctx x -> ctx.Element.TodayPressedBackground <- x), x)
    [<CustomOperation("TodaySelectedInnerBorderBrush")>] member inline this.TodaySelectedInnerBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TodaySelectedInnerBorderBrush), (fun ctx x -> ctx.Element.TodaySelectedInnerBorderBrush <- x), x)
    [<CustomOperation("TodaySelectedInnerBorderBrush")>] member inline this.TodaySelectedInnerBorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TodaySelectedInnerBorderBrush), (fun ctx x -> ctx.Element.TodaySelectedInnerBorderBrush <- x), x)
    [<CustomOperation("VerticalDayItemAlignment")>] member inline this.VerticalDayItemAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalDayItemAlignment), (fun ctx x -> ctx.Element.VerticalDayItemAlignment <- x), x)
    [<CustomOperation("VerticalDayItemAlignment")>] member inline this.VerticalDayItemAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalDayItemAlignment), (fun ctx x -> ctx.Element.VerticalDayItemAlignment <- x), x)
    [<CustomOperation("VerticalFirstOfMonthLabelAlignment")>] member inline this.VerticalFirstOfMonthLabelAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalFirstOfMonthLabelAlignment), (fun ctx x -> ctx.Element.VerticalFirstOfMonthLabelAlignment <- x), x)
    [<CustomOperation("VerticalFirstOfMonthLabelAlignment")>] member inline this.VerticalFirstOfMonthLabelAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalFirstOfMonthLabelAlignment), (fun ctx x -> ctx.Element.VerticalFirstOfMonthLabelAlignment <- x), x)

    [<CustomOperation("CalendarViewDayItemChanging")>] member inline this.CalendarViewDayItemChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarViewDayItemChanging), "CalendarViewDayItemChanging", fn)
    [<CustomOperation("SelectedDatesChanged")>] member inline this.SelectedDatesChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDatesChanged), "SelectedDatesChanged", fn)
                

type CalendarViewDayItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.CalendarViewDayItem>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("IsBlackout")>] member inline this.IsBlackout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsBlackout), (fun ctx x -> ctx.Element.IsBlackout <- x), x)
    [<CustomOperation("IsBlackout")>] member inline this.IsBlackout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsBlackout), (fun ctx x -> ctx.Element.IsBlackout <- x), x)

                

type ColorPickerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ColorPicker>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("ColorSpectrumComponents")>] member inline this.ColorSpectrumComponents ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ColorSpectrumComponents) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorSpectrumComponents), (fun ctx x -> ctx.Element.ColorSpectrumComponents <- x), x)
    [<CustomOperation("ColorSpectrumComponents")>] member inline this.ColorSpectrumComponents ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColorSpectrumComponents), (fun ctx x -> ctx.Element.ColorSpectrumComponents <- x), x)
    [<CustomOperation("ColorSpectrumShape")>] member inline this.ColorSpectrumShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ColorSpectrumShape) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorSpectrumShape), (fun ctx x -> ctx.Element.ColorSpectrumShape <- x), x)
    [<CustomOperation("ColorSpectrumShape")>] member inline this.ColorSpectrumShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColorSpectrumShape), (fun ctx x -> ctx.Element.ColorSpectrumShape <- x), x)
    [<CustomOperation("IsAlphaEnabled")>] member inline this.IsAlphaEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsAlphaEnabled), (fun ctx x -> ctx.Element.IsAlphaEnabled <- x), x)
    [<CustomOperation("IsAlphaEnabled")>] member inline this.IsAlphaEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsAlphaEnabled), (fun ctx x -> ctx.Element.IsAlphaEnabled <- x), x)
    [<CustomOperation("IsAlphaSliderVisible")>] member inline this.IsAlphaSliderVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsAlphaSliderVisible), (fun ctx x -> ctx.Element.IsAlphaSliderVisible <- x), x)
    [<CustomOperation("IsAlphaSliderVisible")>] member inline this.IsAlphaSliderVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsAlphaSliderVisible), (fun ctx x -> ctx.Element.IsAlphaSliderVisible <- x), x)
    [<CustomOperation("IsAlphaTextInputVisible")>] member inline this.IsAlphaTextInputVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsAlphaTextInputVisible), (fun ctx x -> ctx.Element.IsAlphaTextInputVisible <- x), x)
    [<CustomOperation("IsAlphaTextInputVisible")>] member inline this.IsAlphaTextInputVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsAlphaTextInputVisible), (fun ctx x -> ctx.Element.IsAlphaTextInputVisible <- x), x)
    [<CustomOperation("IsColorChannelTextInputVisible")>] member inline this.IsColorChannelTextInputVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorChannelTextInputVisible), (fun ctx x -> ctx.Element.IsColorChannelTextInputVisible <- x), x)
    [<CustomOperation("IsColorChannelTextInputVisible")>] member inline this.IsColorChannelTextInputVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorChannelTextInputVisible), (fun ctx x -> ctx.Element.IsColorChannelTextInputVisible <- x), x)
    [<CustomOperation("IsColorPreviewVisible")>] member inline this.IsColorPreviewVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorPreviewVisible), (fun ctx x -> ctx.Element.IsColorPreviewVisible <- x), x)
    [<CustomOperation("IsColorPreviewVisible")>] member inline this.IsColorPreviewVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorPreviewVisible), (fun ctx x -> ctx.Element.IsColorPreviewVisible <- x), x)
    [<CustomOperation("IsColorSliderVisible")>] member inline this.IsColorSliderVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorSliderVisible), (fun ctx x -> ctx.Element.IsColorSliderVisible <- x), x)
    [<CustomOperation("IsColorSliderVisible")>] member inline this.IsColorSliderVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorSliderVisible), (fun ctx x -> ctx.Element.IsColorSliderVisible <- x), x)
    [<CustomOperation("IsColorSpectrumVisible")>] member inline this.IsColorSpectrumVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorSpectrumVisible), (fun ctx x -> ctx.Element.IsColorSpectrumVisible <- x), x)
    [<CustomOperation("IsColorSpectrumVisible")>] member inline this.IsColorSpectrumVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorSpectrumVisible), (fun ctx x -> ctx.Element.IsColorSpectrumVisible <- x), x)
    [<CustomOperation("IsHexInputVisible")>] member inline this.IsHexInputVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHexInputVisible), (fun ctx x -> ctx.Element.IsHexInputVisible <- x), x)
    [<CustomOperation("IsHexInputVisible")>] member inline this.IsHexInputVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHexInputVisible), (fun ctx x -> ctx.Element.IsHexInputVisible <- x), x)
    [<CustomOperation("IsMoreButtonVisible")>] member inline this.IsMoreButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsMoreButtonVisible), (fun ctx x -> ctx.Element.IsMoreButtonVisible <- x), x)
    [<CustomOperation("IsMoreButtonVisible")>] member inline this.IsMoreButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsMoreButtonVisible), (fun ctx x -> ctx.Element.IsMoreButtonVisible <- x), x)
    [<CustomOperation("MaxHue")>] member inline this.MaxHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHue), (fun ctx x -> ctx.Element.MaxHue <- x), x)
    [<CustomOperation("MaxHue")>] member inline this.MaxHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHue), (fun ctx x -> ctx.Element.MaxHue <- x), x)
    [<CustomOperation("MaxSaturation")>] member inline this.MaxSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxSaturation), (fun ctx x -> ctx.Element.MaxSaturation <- x), x)
    [<CustomOperation("MaxSaturation")>] member inline this.MaxSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxSaturation), (fun ctx x -> ctx.Element.MaxSaturation <- x), x)
    [<CustomOperation("MaxValue")>] member inline this.MaxValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxValue), (fun ctx x -> ctx.Element.MaxValue <- x), x)
    [<CustomOperation("MaxValue")>] member inline this.MaxValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxValue), (fun ctx x -> ctx.Element.MaxValue <- x), x)
    [<CustomOperation("MinHue")>] member inline this.MinHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinHue), (fun ctx x -> ctx.Element.MinHue <- x), x)
    [<CustomOperation("MinHue")>] member inline this.MinHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinHue), (fun ctx x -> ctx.Element.MinHue <- x), x)
    [<CustomOperation("MinSaturation")>] member inline this.MinSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinSaturation), (fun ctx x -> ctx.Element.MinSaturation <- x), x)
    [<CustomOperation("MinSaturation")>] member inline this.MinSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinSaturation), (fun ctx x -> ctx.Element.MinSaturation <- x), x)
    [<CustomOperation("MinValue")>] member inline this.MinValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinValue), (fun ctx x -> ctx.Element.MinValue <- x), x)
    [<CustomOperation("MinValue")>] member inline this.MinValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinValue), (fun ctx x -> ctx.Element.MinValue <- x), x)
    [<CustomOperation("PreviousColor")>] member inline this.PreviousColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<Windows.UI.Color>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreviousColor), (fun ctx x -> ctx.Element.PreviousColor <- x), x)
    [<CustomOperation("PreviousColor")>] member inline this.PreviousColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreviousColor), (fun ctx x -> ctx.Element.PreviousColor <- x), x)

    [<CustomOperation("ColorChanged")>] member inline this.ColorChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorChanged), "ColorChanged", fn)
                

type DatePickerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.DatePicker>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("CalendarIdentifier")>] member inline this.CalendarIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarIdentifier), (fun ctx x -> ctx.Element.CalendarIdentifier <- x), x)
    [<CustomOperation("CalendarIdentifier")>] member inline this.CalendarIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarIdentifier), (fun ctx x -> ctx.Element.CalendarIdentifier <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("DayFormat")>] member inline this.DayFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayFormat), (fun ctx x -> ctx.Element.DayFormat <- x), x)
    [<CustomOperation("DayFormat")>] member inline this.DayFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayFormat), (fun ctx x -> ctx.Element.DayFormat <- x), x)
    [<CustomOperation("DayVisible")>] member inline this.DayVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayVisible), (fun ctx x -> ctx.Element.DayVisible <- x), x)
    [<CustomOperation("DayVisible")>] member inline this.DayVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayVisible), (fun ctx x -> ctx.Element.DayVisible <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("MaxYear")>] member inline this.MaxYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxYear), (fun ctx x -> ctx.Element.MaxYear <- x), x)
    [<CustomOperation("MaxYear")>] member inline this.MaxYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxYear), (fun ctx x -> ctx.Element.MaxYear <- x), x)
    [<CustomOperation("MinYear")>] member inline this.MinYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinYear), (fun ctx x -> ctx.Element.MinYear <- x), x)
    [<CustomOperation("MinYear")>] member inline this.MinYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinYear), (fun ctx x -> ctx.Element.MinYear <- x), x)
    [<CustomOperation("MonthFormat")>] member inline this.MonthFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthFormat), (fun ctx x -> ctx.Element.MonthFormat <- x), x)
    [<CustomOperation("MonthFormat")>] member inline this.MonthFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthFormat), (fun ctx x -> ctx.Element.MonthFormat <- x), x)
    [<CustomOperation("MonthVisible")>] member inline this.MonthVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthVisible), (fun ctx x -> ctx.Element.MonthVisible <- x), x)
    [<CustomOperation("MonthVisible")>] member inline this.MonthVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthVisible), (fun ctx x -> ctx.Element.MonthVisible <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTimeOffset>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("YearFormat")>] member inline this.YearFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.YearFormat), (fun ctx x -> ctx.Element.YearFormat <- x), x)
    [<CustomOperation("YearFormat")>] member inline this.YearFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.YearFormat), (fun ctx x -> ctx.Element.YearFormat <- x), x)
    [<CustomOperation("YearVisible")>] member inline this.YearVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.YearVisible), (fun ctx x -> ctx.Element.YearVisible <- x), x)
    [<CustomOperation("YearVisible")>] member inline this.YearVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.YearVisible), (fun ctx x -> ctx.Element.YearVisible <- x), x)

    [<CustomOperation("DateChanged")>] member inline this.DateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DateChanged), "DateChanged", fn)
    [<CustomOperation("SelectedDateChanged")>] member inline this.SelectedDateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateChanged), "SelectedDateChanged", fn)
                

type DatePickerFlyoutPresenterBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.DatePickerFlyoutPresenter>()

    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.DatePickerFlyoutPresenter>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)
    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.DatePickerFlyoutPresenter>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)

                

type HubBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Hub>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("DefaultSectionIndex")>] member inline this.DefaultSectionIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultSectionIndex), (fun ctx x -> ctx.Element.DefaultSectionIndex <- x), x)
    [<CustomOperation("DefaultSectionIndex")>] member inline this.DefaultSectionIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DefaultSectionIndex), (fun ctx x -> ctx.Element.DefaultSectionIndex <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsActiveView")>] member inline this.IsActiveView ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsActiveView), (fun ctx x -> ctx.Element.IsActiveView <- x), x)
    [<CustomOperation("IsActiveView")>] member inline this.IsActiveView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsActiveView), (fun ctx x -> ctx.Element.IsActiveView <- x), x)
    [<CustomOperation("IsZoomedInView")>] member inline this.IsZoomedInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomedInView), (fun ctx x -> ctx.Element.IsZoomedInView <- x), x)
    [<CustomOperation("IsZoomedInView")>] member inline this.IsZoomedInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomedInView), (fun ctx x -> ctx.Element.IsZoomedInView <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("SectionHeaders")>] member inline this.SectionHeaders ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SectionHeaders), x)
    [<CustomOperation("SectionHeaders'")>] member inline this.SectionHeaders' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SectionHeaders), x)
    [<CustomOperation("Sections")>] member inline this.Sections ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Sections), x)
    [<CustomOperation("Sections'")>] member inline this.Sections' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Sections), x)
    [<CustomOperation("SectionsInView")>] member inline this.SectionsInView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SectionsInView), x)
    [<CustomOperation("SectionsInView'")>] member inline this.SectionsInView' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SectionsInView), x)
    [<CustomOperation("SemanticZoomOwner")>] member inline this.SemanticZoomOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SemanticZoom) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SemanticZoomOwner), (fun ctx x -> ctx.Element.SemanticZoomOwner <- x), x)
    [<CustomOperation("SemanticZoomOwner")>] member inline this.SemanticZoomOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SemanticZoomOwner), (fun ctx x -> ctx.Element.SemanticZoomOwner <- x), x)

    [<CustomOperation("SectionHeaderClick")>] member inline this.SectionHeaderClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SectionHeaderClick), "SectionHeaderClick", fn)
    [<CustomOperation("SectionsInViewChanged")>] member inline this.SectionsInViewChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SectionsInViewChanged), "SectionsInViewChanged", fn)
                

type HubSectionBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.HubSection>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsHeaderInteractive")>] member inline this.IsHeaderInteractive ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHeaderInteractive), (fun ctx x -> ctx.Element.IsHeaderInteractive <- x), x)
    [<CustomOperation("IsHeaderInteractive")>] member inline this.IsHeaderInteractive ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHeaderInteractive), (fun ctx x -> ctx.Element.IsHeaderInteractive <- x), x)

                

type InfoBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.InfoBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ActionButton")>] member inline this.ActionButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.ButtonBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButton), (fun ctx x -> ctx.Element.ActionButton <- x), x)
    [<CustomOperation("ActionButton")>] member inline this.ActionButton ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ActionButton), (fun ctx x -> ctx.Element.ActionButton <- x), x)
    [<CustomOperation("CloseButtonCommand")>] member inline this.CloseButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommand), (fun ctx x -> ctx.Element.CloseButtonCommand <- x), x)
    [<CustomOperation("CloseButtonCommand")>] member inline this.CloseButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommand), (fun ctx x -> ctx.Element.CloseButtonCommand <- x), x)
    [<CustomOperation("CloseButtonCommandParameter")>] member inline this.CloseButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommandParameter), (fun ctx x -> ctx.Element.CloseButtonCommandParameter <- x), x)
    [<CustomOperation("CloseButtonCommandParameter")>] member inline this.CloseButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonCommandParameter), (fun ctx x -> ctx.Element.CloseButtonCommandParameter <- x), x)
    [<CustomOperation("CloseButtonStyle")>] member inline this.CloseButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonStyle), (fun ctx x -> ctx.Element.CloseButtonStyle <- x), x)
    [<CustomOperation("CloseButtonStyle")>] member inline this.CloseButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonStyle), (fun ctx x -> ctx.Element.CloseButtonStyle <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("IconSource")>] member inline this.IconSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.IconSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IconSource), (fun ctx x -> ctx.Element.IconSource <- x), x)
    [<CustomOperation("IconSource")>] member inline this.IconSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IconSource), (fun ctx x -> ctx.Element.IconSource <- x), x)
    [<CustomOperation("IsClosable")>] member inline this.IsClosable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClosable), (fun ctx x -> ctx.Element.IsClosable <- x), x)
    [<CustomOperation("IsClosable")>] member inline this.IsClosable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClosable), (fun ctx x -> ctx.Element.IsClosable <- x), x)
    [<CustomOperation("IsIconVisible")>] member inline this.IsIconVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsIconVisible), (fun ctx x -> ctx.Element.IsIconVisible <- x), x)
    [<CustomOperation("IsIconVisible")>] member inline this.IsIconVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsIconVisible), (fun ctx x -> ctx.Element.IsIconVisible <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("Message")>] member inline this.Message ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Message), (fun ctx x -> ctx.Element.Message <- x), x)
    [<CustomOperation("Message")>] member inline this.Message ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Message), (fun ctx x -> ctx.Element.Message <- x), x)
    [<CustomOperation("Severity")>] member inline this.Severity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.InfoBarSeverity) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Severity), (fun ctx x -> ctx.Element.Severity <- x), x)
    [<CustomOperation("Severity")>] member inline this.Severity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Severity), (fun ctx x -> ctx.Element.Severity <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

    [<CustomOperation("CloseButtonClick")>] member inline this.CloseButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonClick), "CloseButtonClick", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
                

type ListPickerFlyoutPresenterBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.ListPickerFlyoutPresenter>()


                

type MenuBarBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.MenuBar>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)

                

type MenuBarItemBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.MenuBarItem>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

                

type NumberBoxBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.NumberBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AcceptsExpression")>] member inline this.AcceptsExpression ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsExpression), (fun ctx x -> ctx.Element.AcceptsExpression <- x), x)
    [<CustomOperation("AcceptsExpression")>] member inline this.AcceptsExpression ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsExpression), (fun ctx x -> ctx.Element.AcceptsExpression <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsWrapEnabled")>] member inline this.IsWrapEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsWrapEnabled), (fun ctx x -> ctx.Element.IsWrapEnabled <- x), x)
    [<CustomOperation("IsWrapEnabled")>] member inline this.IsWrapEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsWrapEnabled), (fun ctx x -> ctx.Element.IsWrapEnabled <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("NumberFormatter")>] member inline this.NumberFormatter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.Globalization.NumberFormatting.INumberFormatter2) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NumberFormatter), (fun ctx x -> ctx.Element.NumberFormatter <- x), x)
    [<CustomOperation("NumberFormatter")>] member inline this.NumberFormatter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NumberFormatter), (fun ctx x -> ctx.Element.NumberFormatter <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.SolidColorBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SpinButtonPlacementMode")>] member inline this.SpinButtonPlacementMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SpinButtonPlacementMode), (fun ctx x -> ctx.Element.SpinButtonPlacementMode <- x), x)
    [<CustomOperation("SpinButtonPlacementMode")>] member inline this.SpinButtonPlacementMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SpinButtonPlacementMode), (fun ctx x -> ctx.Element.SpinButtonPlacementMode <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextReadingOrder) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("ValidationMode")>] member inline this.ValidationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.NumberBoxValidationMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ValidationMode), (fun ctx x -> ctx.Element.ValidationMode <- x), x)
    [<CustomOperation("ValidationMode")>] member inline this.ValidationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ValidationMode), (fun ctx x -> ctx.Element.ValidationMode <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                

type PasswordBoxBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.PasswordBox>()

    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: Microsoft.UI.Xaml.Input.InputScope) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("IsPasswordRevealButtonEnabled")>] member inline this.IsPasswordRevealButtonEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPasswordRevealButtonEnabled), (fun ctx x -> ctx.Element.IsPasswordRevealButtonEnabled <- x), x)
    [<CustomOperation("IsPasswordRevealButtonEnabled")>] member inline this.IsPasswordRevealButtonEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPasswordRevealButtonEnabled), (fun ctx x -> ctx.Element.IsPasswordRevealButtonEnabled <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("Password")>] member inline this.Password ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Password), (fun ctx x -> ctx.Element.Password <- x), x)
    [<CustomOperation("Password")>] member inline this.Password ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Password), (fun ctx x -> ctx.Element.Password <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PasswordRevealMode")>] member inline this.PasswordRevealMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: Microsoft.UI.Xaml.Controls.PasswordRevealMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordRevealMode), (fun ctx x -> ctx.Element.PasswordRevealMode <- x), x)
    [<CustomOperation("PasswordRevealMode")>] member inline this.PasswordRevealMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordRevealMode), (fun ctx x -> ctx.Element.PasswordRevealMode <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: Microsoft.UI.Xaml.Media.SolidColorBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x: Microsoft.UI.Xaml.TextReadingOrder) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)

    [<CustomOperation("ContextMenuOpening")>] member inline this.ContextMenuOpening ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuOpening), "ContextMenuOpening", fn)
    [<CustomOperation("PasswordChanged")>] member inline this.PasswordChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChanged), "PasswordChanged", fn)
    [<CustomOperation("PasswordChanging")>] member inline this.PasswordChanging ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChanging), "PasswordChanging", fn)
    [<CustomOperation("Paste")>] member inline this.Paste ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Paste), "Paste", fn)
                

type PersonPictureBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.PersonPicture>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("BadgeGlyph")>] member inline this.BadgeGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeGlyph), (fun ctx x -> ctx.Element.BadgeGlyph <- x), x)
    [<CustomOperation("BadgeGlyph")>] member inline this.BadgeGlyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeGlyph), (fun ctx x -> ctx.Element.BadgeGlyph <- x), x)
    [<CustomOperation("BadgeImageSource")>] member inline this.BadgeImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.ImageSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeImageSource), (fun ctx x -> ctx.Element.BadgeImageSource <- x), x)
    [<CustomOperation("BadgeImageSource")>] member inline this.BadgeImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeImageSource), (fun ctx x -> ctx.Element.BadgeImageSource <- x), x)
    [<CustomOperation("BadgeNumber")>] member inline this.BadgeNumber ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeNumber), (fun ctx x -> ctx.Element.BadgeNumber <- x), x)
    [<CustomOperation("BadgeNumber")>] member inline this.BadgeNumber ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeNumber), (fun ctx x -> ctx.Element.BadgeNumber <- x), x)
    [<CustomOperation("BadgeText")>] member inline this.BadgeText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeText), (fun ctx x -> ctx.Element.BadgeText <- x), x)
    [<CustomOperation("BadgeText")>] member inline this.BadgeText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BadgeText), (fun ctx x -> ctx.Element.BadgeText <- x), x)
    [<CustomOperation("Contact")>] member inline this.Contact ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.ApplicationModel.Contacts.Contact) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Contact), (fun ctx x -> ctx.Element.Contact <- x), x)
    [<CustomOperation("Contact")>] member inline this.Contact ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Contact), (fun ctx x -> ctx.Element.Contact <- x), x)
    [<CustomOperation("DisplayName")>] member inline this.DisplayName ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayName), (fun ctx x -> ctx.Element.DisplayName <- x), x)
    [<CustomOperation("DisplayName")>] member inline this.DisplayName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayName), (fun ctx x -> ctx.Element.DisplayName <- x), x)
    [<CustomOperation("Initials")>] member inline this.Initials ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Initials), (fun ctx x -> ctx.Element.Initials <- x), x)
    [<CustomOperation("Initials")>] member inline this.Initials ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Initials), (fun ctx x -> ctx.Element.Initials <- x), x)
    [<CustomOperation("IsGroup")>] member inline this.IsGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroup), (fun ctx x -> ctx.Element.IsGroup <- x), x)
    [<CustomOperation("IsGroup")>] member inline this.IsGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroup), (fun ctx x -> ctx.Element.IsGroup <- x), x)
    [<CustomOperation("PreferSmallImage")>] member inline this.PreferSmallImage ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreferSmallImage), (fun ctx x -> ctx.Element.PreferSmallImage <- x), x)
    [<CustomOperation("PreferSmallImage")>] member inline this.PreferSmallImage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreferSmallImage), (fun ctx x -> ctx.Element.PreferSmallImage <- x), x)
    [<CustomOperation("ProfilePicture")>] member inline this.ProfilePicture ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.ImageSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ProfilePicture), (fun ctx x -> ctx.Element.ProfilePicture <- x), x)
    [<CustomOperation("ProfilePicture")>] member inline this.ProfilePicture ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ProfilePicture), (fun ctx x -> ctx.Element.ProfilePicture <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

                

type PipsPagerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.PipsPager>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("MaxVisiblePips")>] member inline this.MaxVisiblePips ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxVisiblePips), (fun ctx x -> ctx.Element.MaxVisiblePips <- x), x)
    [<CustomOperation("MaxVisiblePips")>] member inline this.MaxVisiblePips ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxVisiblePips), (fun ctx x -> ctx.Element.MaxVisiblePips <- x), x)
    [<CustomOperation("NextButtonStyle")>] member inline this.NextButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NextButtonStyle), (fun ctx x -> ctx.Element.NextButtonStyle <- x), x)
    [<CustomOperation("NextButtonStyle")>] member inline this.NextButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NextButtonStyle), (fun ctx x -> ctx.Element.NextButtonStyle <- x), x)
    [<CustomOperation("NextButtonVisibility")>] member inline this.NextButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.PipsPagerButtonVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NextButtonVisibility), (fun ctx x -> ctx.Element.NextButtonVisibility <- x), x)
    [<CustomOperation("NextButtonVisibility")>] member inline this.NextButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NextButtonVisibility), (fun ctx x -> ctx.Element.NextButtonVisibility <- x), x)
    [<CustomOperation("NormalPipStyle")>] member inline this.NormalPipStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NormalPipStyle), (fun ctx x -> ctx.Element.NormalPipStyle <- x), x)
    [<CustomOperation("NormalPipStyle")>] member inline this.NormalPipStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NormalPipStyle), (fun ctx x -> ctx.Element.NormalPipStyle <- x), x)
    [<CustomOperation("NumberOfPages")>] member inline this.NumberOfPages ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfPages), (fun ctx x -> ctx.Element.NumberOfPages <- x), x)
    [<CustomOperation("NumberOfPages")>] member inline this.NumberOfPages ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfPages), (fun ctx x -> ctx.Element.NumberOfPages <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("PreviousButtonStyle")>] member inline this.PreviousButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreviousButtonStyle), (fun ctx x -> ctx.Element.PreviousButtonStyle <- x), x)
    [<CustomOperation("PreviousButtonStyle")>] member inline this.PreviousButtonStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreviousButtonStyle), (fun ctx x -> ctx.Element.PreviousButtonStyle <- x), x)
    [<CustomOperation("PreviousButtonVisibility")>] member inline this.PreviousButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.PipsPagerButtonVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreviousButtonVisibility), (fun ctx x -> ctx.Element.PreviousButtonVisibility <- x), x)
    [<CustomOperation("PreviousButtonVisibility")>] member inline this.PreviousButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreviousButtonVisibility), (fun ctx x -> ctx.Element.PreviousButtonVisibility <- x), x)
    [<CustomOperation("SelectedPageIndex")>] member inline this.SelectedPageIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPageIndex), (fun ctx x -> ctx.Element.SelectedPageIndex <- x), x)
    [<CustomOperation("SelectedPageIndex")>] member inline this.SelectedPageIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPageIndex), (fun ctx x -> ctx.Element.SelectedPageIndex <- x), x)
    [<CustomOperation("SelectedPipStyle")>] member inline this.SelectedPipStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPipStyle), (fun ctx x -> ctx.Element.SelectedPipStyle <- x), x)
    [<CustomOperation("SelectedPipStyle")>] member inline this.SelectedPipStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedPipStyle), (fun ctx x -> ctx.Element.SelectedPipStyle <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

    [<CustomOperation("SelectedIndexChanged")>] member inline this.SelectedIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndexChanged), "SelectedIndexChanged", fn)
                

type ProgressRingBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.ProgressRing>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("IsActive")>] member inline this.IsActive ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsActive), (fun ctx x -> ctx.Element.IsActive <- x), x)
    [<CustomOperation("IsActive")>] member inline this.IsActive ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsActive), (fun ctx x -> ctx.Element.IsActive <- x), x)
    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

                

type RadioButtonsBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RadioButtons>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("MaxColumns")>] member inline this.MaxColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxColumns), (fun ctx x -> ctx.Element.MaxColumns <- x), x)
    [<CustomOperation("MaxColumns")>] member inline this.MaxColumns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxColumns), (fun ctx x -> ctx.Element.MaxColumns <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)

    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type RatingControlBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RatingControl>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Caption")>] member inline this.Caption ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Caption), (fun ctx x -> ctx.Element.Caption <- x), x)
    [<CustomOperation("Caption")>] member inline this.Caption ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Caption), (fun ctx x -> ctx.Element.Caption <- x), x)
    [<CustomOperation("InitialSetValue")>] member inline this.InitialSetValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InitialSetValue), (fun ctx x -> ctx.Element.InitialSetValue <- x), x)
    [<CustomOperation("InitialSetValue")>] member inline this.InitialSetValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InitialSetValue), (fun ctx x -> ctx.Element.InitialSetValue <- x), x)
    [<CustomOperation("IsClearEnabled")>] member inline this.IsClearEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClearEnabled), (fun ctx x -> ctx.Element.IsClearEnabled <- x), x)
    [<CustomOperation("IsClearEnabled")>] member inline this.IsClearEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClearEnabled), (fun ctx x -> ctx.Element.IsClearEnabled <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("ItemInfo")>] member inline this.ItemInfo ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.RatingItemInfo) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemInfo), (fun ctx x -> ctx.Element.ItemInfo <- x), x)
    [<CustomOperation("ItemInfo")>] member inline this.ItemInfo ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemInfo), (fun ctx x -> ctx.Element.ItemInfo <- x), x)
    [<CustomOperation("MaxRating")>] member inline this.MaxRating ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxRating), (fun ctx x -> ctx.Element.MaxRating <- x), x)
    [<CustomOperation("MaxRating")>] member inline this.MaxRating ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxRating), (fun ctx x -> ctx.Element.MaxRating <- x), x)
    [<CustomOperation("PlaceholderValue")>] member inline this.PlaceholderValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderValue), (fun ctx x -> ctx.Element.PlaceholderValue <- x), x)
    [<CustomOperation("PlaceholderValue")>] member inline this.PlaceholderValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderValue), (fun ctx x -> ctx.Element.PlaceholderValue <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                

type RefreshVisualizerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RefreshVisualizer>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.RefreshVisualizerOrientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

    [<CustomOperation("RefreshRequested")>] member inline this.RefreshRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshRequested), "RefreshRequested", fn)
    [<CustomOperation("RefreshStateChanged")>] member inline this.RefreshStateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshStateChanged), "RefreshStateChanged", fn)
                

type RichEditBoxBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RichEditBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("CharacterCasing")>] member inline this.CharacterCasing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CharacterCasing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterCasing), (fun ctx x -> ctx.Element.CharacterCasing <- x), x)
    [<CustomOperation("CharacterCasing")>] member inline this.CharacterCasing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterCasing), (fun ctx x -> ctx.Element.CharacterCasing <- x), x)
    [<CustomOperation("ClipboardCopyFormat")>] member inline this.ClipboardCopyFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.RichEditClipboardFormat) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClipboardCopyFormat), (fun ctx x -> ctx.Element.ClipboardCopyFormat <- x), x)
    [<CustomOperation("ClipboardCopyFormat")>] member inline this.ClipboardCopyFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClipboardCopyFormat), (fun ctx x -> ctx.Element.ClipboardCopyFormat <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("DesiredCandidateWindowAlignment")>] member inline this.DesiredCandidateWindowAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CandidateWindowAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCandidateWindowAlignment), (fun ctx x -> ctx.Element.DesiredCandidateWindowAlignment <- x), x)
    [<CustomOperation("DesiredCandidateWindowAlignment")>] member inline this.DesiredCandidateWindowAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCandidateWindowAlignment), (fun ctx x -> ctx.Element.DesiredCandidateWindowAlignment <- x), x)
    [<CustomOperation("DisabledFormattingAccelerators")>] member inline this.DisabledFormattingAccelerators ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DisabledFormattingAccelerators) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisabledFormattingAccelerators), (fun ctx x -> ctx.Element.DisabledFormattingAccelerators <- x), x)
    [<CustomOperation("DisabledFormattingAccelerators")>] member inline this.DisabledFormattingAccelerators ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisabledFormattingAccelerators), (fun ctx x -> ctx.Element.DisabledFormattingAccelerators <- x), x)
    [<CustomOperation("Document")>] member inline this.Document ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Document), x)
    [<CustomOperation("Document'")>] member inline this.Document' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Document), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Input.InputScope) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("IsColorFontEnabled")>] member inline this.IsColorFontEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorFontEnabled), (fun ctx x -> ctx.Element.IsColorFontEnabled <- x), x)
    [<CustomOperation("IsColorFontEnabled")>] member inline this.IsColorFontEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorFontEnabled), (fun ctx x -> ctx.Element.IsColorFontEnabled <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsSpellCheckEnabled")>] member inline this.IsSpellCheckEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSpellCheckEnabled), (fun ctx x -> ctx.Element.IsSpellCheckEnabled <- x), x)
    [<CustomOperation("IsSpellCheckEnabled")>] member inline this.IsSpellCheckEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSpellCheckEnabled), (fun ctx x -> ctx.Element.IsSpellCheckEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("ProofingMenuFlyout")>] member inline this.ProofingMenuFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ProofingMenuFlyout), x)
    [<CustomOperation("ProofingMenuFlyout'")>] member inline this.ProofingMenuFlyout' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ProofingMenuFlyout), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.SolidColorBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SelectionHighlightColorWhenNotFocused")>] member inline this.SelectionHighlightColorWhenNotFocused ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.SolidColorBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColorWhenNotFocused), (fun ctx x -> ctx.Element.SelectionHighlightColorWhenNotFocused <- x), x)
    [<CustomOperation("SelectionHighlightColorWhenNotFocused")>] member inline this.SelectionHighlightColorWhenNotFocused ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColorWhenNotFocused), (fun ctx x -> ctx.Element.SelectionHighlightColorWhenNotFocused <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextDocument")>] member inline this.TextDocument ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TextDocument), x)
    [<CustomOperation("TextDocument'")>] member inline this.TextDocument' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TextDocument), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextReadingOrder) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)

    [<CustomOperation("CandidateWindowBoundsChanged")>] member inline this.CandidateWindowBoundsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CandidateWindowBoundsChanged), "CandidateWindowBoundsChanged", fn)
    [<CustomOperation("ContextMenuOpening")>] member inline this.ContextMenuOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuOpening), "ContextMenuOpening", fn)
    [<CustomOperation("CopyingToClipboard")>] member inline this.CopyingToClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CopyingToClipboard), "CopyingToClipboard", fn)
    [<CustomOperation("CuttingToClipboard")>] member inline this.CuttingToClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CuttingToClipboard), "CuttingToClipboard", fn)
    [<CustomOperation("Paste")>] member inline this.Paste ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Paste), "Paste", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
    [<CustomOperation("SelectionChanging")>] member inline this.SelectionChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanging), "SelectionChanging", fn)
    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
    [<CustomOperation("TextChanging")>] member inline this.TextChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanging), "TextChanging", fn)
    [<CustomOperation("TextCompositionChanged")>] member inline this.TextCompositionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextCompositionChanged), "TextCompositionChanged", fn)
    [<CustomOperation("TextCompositionEnded")>] member inline this.TextCompositionEnded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextCompositionEnded), "TextCompositionEnded", fn)
    [<CustomOperation("TextCompositionStarted")>] member inline this.TextCompositionStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextCompositionStarted), "TextCompositionStarted", fn)
                

type SemanticZoomBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.SemanticZoom>()

    [<CustomOperation("CanChangeViews")>] member inline this.CanChangeViews ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanChangeViews), (fun ctx x -> ctx.Element.CanChangeViews <- x), x)
    [<CustomOperation("CanChangeViews")>] member inline this.CanChangeViews ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanChangeViews), (fun ctx x -> ctx.Element.CanChangeViews <- x), x)
    [<CustomOperation("IsZoomOutButtonEnabled")>] member inline this.IsZoomOutButtonEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomOutButtonEnabled), (fun ctx x -> ctx.Element.IsZoomOutButtonEnabled <- x), x)
    [<CustomOperation("IsZoomOutButtonEnabled")>] member inline this.IsZoomOutButtonEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomOutButtonEnabled), (fun ctx x -> ctx.Element.IsZoomOutButtonEnabled <- x), x)
    [<CustomOperation("IsZoomedInViewActive")>] member inline this.IsZoomedInViewActive ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomedInViewActive), (fun ctx x -> ctx.Element.IsZoomedInViewActive <- x), x)
    [<CustomOperation("IsZoomedInViewActive")>] member inline this.IsZoomedInViewActive ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsZoomedInViewActive), (fun ctx x -> ctx.Element.IsZoomedInViewActive <- x), x)
    [<CustomOperation("ZoomedInView")>] member inline this.ZoomedInView ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x: Microsoft.UI.Xaml.Controls.ISemanticZoomInformation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomedInView), (fun ctx x -> ctx.Element.ZoomedInView <- x), x)
    [<CustomOperation("ZoomedInView")>] member inline this.ZoomedInView ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomedInView), (fun ctx x -> ctx.Element.ZoomedInView <- x), x)
    [<CustomOperation("ZoomedOutView")>] member inline this.ZoomedOutView ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x: Microsoft.UI.Xaml.Controls.ISemanticZoomInformation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomedOutView), (fun ctx x -> ctx.Element.ZoomedOutView <- x), x)
    [<CustomOperation("ZoomedOutView")>] member inline this.ZoomedOutView ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZoomedOutView), (fun ctx x -> ctx.Element.ZoomedOutView <- x), x)

    [<CustomOperation("ViewChangeCompleted")>] member inline this.ViewChangeCompleted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewChangeCompleted), "ViewChangeCompleted", fn)
    [<CustomOperation("ViewChangeStarted")>] member inline this.ViewChangeStarted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewChangeStarted), "ViewChangeStarted", fn)
                

type SplitViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.SplitView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("CompactPaneLength")>] member inline this.CompactPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CompactPaneLength), (fun ctx x -> ctx.Element.CompactPaneLength <- x), x)
    [<CustomOperation("CompactPaneLength")>] member inline this.CompactPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CompactPaneLength), (fun ctx x -> ctx.Element.CompactPaneLength <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SplitViewDisplayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("IsPaneOpen")>] member inline this.IsPaneOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneOpen), (fun ctx x -> ctx.Element.IsPaneOpen <- x), x)
    [<CustomOperation("IsPaneOpen")>] member inline this.IsPaneOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneOpen), (fun ctx x -> ctx.Element.IsPaneOpen <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("OpenPaneLength")>] member inline this.OpenPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OpenPaneLength), (fun ctx x -> ctx.Element.OpenPaneLength <- x), x)
    [<CustomOperation("OpenPaneLength")>] member inline this.OpenPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OpenPaneLength), (fun ctx x -> ctx.Element.OpenPaneLength <- x), x)
    [<CustomOperation("Pane")>] member inline this.Pane ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Pane), (fun ctx x -> ctx.Element.Pane <- x), x)
    [<CustomOperation("Pane")>] member inline this.Pane ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Pane), (fun ctx x -> ctx.Element.Pane <- x), x)
    [<CustomOperation("PaneBackground")>] member inline this.PaneBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneBackground), (fun ctx x -> ctx.Element.PaneBackground <- x), x)
    [<CustomOperation("PaneBackground")>] member inline this.PaneBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneBackground), (fun ctx x -> ctx.Element.PaneBackground <- x), x)
    [<CustomOperation("PanePlacement")>] member inline this.PanePlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.SplitViewPanePlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanePlacement), (fun ctx x -> ctx.Element.PanePlacement <- x), x)
    [<CustomOperation("PanePlacement")>] member inline this.PanePlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanePlacement), (fun ctx x -> ctx.Element.PanePlacement <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

    [<CustomOperation("PaneClosed")>] member inline this.PaneClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneClosed), "PaneClosed", fn)
    [<CustomOperation("PaneClosing")>] member inline this.PaneClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneClosing), "PaneClosing", fn)
    [<CustomOperation("PaneOpened")>] member inline this.PaneOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneOpened), "PaneOpened", fn)
    [<CustomOperation("PaneOpening")>] member inline this.PaneOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneOpening), "PaneOpening", fn)
                

type TabViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TabView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AddTabButtonCommand")>] member inline this.AddTabButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AddTabButtonCommand), (fun ctx x -> ctx.Element.AddTabButtonCommand <- x), x)
    [<CustomOperation("AddTabButtonCommand")>] member inline this.AddTabButtonCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AddTabButtonCommand), (fun ctx x -> ctx.Element.AddTabButtonCommand <- x), x)
    [<CustomOperation("AddTabButtonCommandParameter")>] member inline this.AddTabButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AddTabButtonCommandParameter), (fun ctx x -> ctx.Element.AddTabButtonCommandParameter <- x), x)
    [<CustomOperation("AddTabButtonCommandParameter")>] member inline this.AddTabButtonCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AddTabButtonCommandParameter), (fun ctx x -> ctx.Element.AddTabButtonCommandParameter <- x), x)
    [<CustomOperation("AllowDropTabs")>] member inline this.AllowDropTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowDropTabs), (fun ctx x -> ctx.Element.AllowDropTabs <- x), x)
    [<CustomOperation("AllowDropTabs")>] member inline this.AllowDropTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowDropTabs), (fun ctx x -> ctx.Element.AllowDropTabs <- x), x)
    [<CustomOperation("CanDragTabs")>] member inline this.CanDragTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanDragTabs), (fun ctx x -> ctx.Element.CanDragTabs <- x), x)
    [<CustomOperation("CanDragTabs")>] member inline this.CanDragTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanDragTabs), (fun ctx x -> ctx.Element.CanDragTabs <- x), x)
    [<CustomOperation("CanReorderTabs")>] member inline this.CanReorderTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderTabs), (fun ctx x -> ctx.Element.CanReorderTabs <- x), x)
    [<CustomOperation("CanReorderTabs")>] member inline this.CanReorderTabs ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderTabs), (fun ctx x -> ctx.Element.CanReorderTabs <- x), x)
    [<CustomOperation("CloseButtonOverlayMode")>] member inline this.CloseButtonOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonOverlayMode), (fun ctx x -> ctx.Element.CloseButtonOverlayMode <- x), x)
    [<CustomOperation("CloseButtonOverlayMode")>] member inline this.CloseButtonOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CloseButtonOverlayMode), (fun ctx x -> ctx.Element.CloseButtonOverlayMode <- x), x)
    [<CustomOperation("IsAddTabButtonVisible")>] member inline this.IsAddTabButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsAddTabButtonVisible), (fun ctx x -> ctx.Element.IsAddTabButtonVisible <- x), x)
    [<CustomOperation("IsAddTabButtonVisible")>] member inline this.IsAddTabButtonVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsAddTabButtonVisible), (fun ctx x -> ctx.Element.IsAddTabButtonVisible <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("TabItemTemplate")>] member inline this.TabItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemTemplate), (fun ctx x -> ctx.Element.TabItemTemplate <- x), x)
    [<CustomOperation("TabItemTemplate")>] member inline this.TabItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemTemplate), (fun ctx x -> ctx.Element.TabItemTemplate <- x), x)
    [<CustomOperation("TabItemTemplateSelector")>] member inline this.TabItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemTemplateSelector), (fun ctx x -> ctx.Element.TabItemTemplateSelector <- x), x)
    [<CustomOperation("TabItemTemplateSelector")>] member inline this.TabItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemTemplateSelector), (fun ctx x -> ctx.Element.TabItemTemplateSelector <- x), x)
    [<CustomOperation("TabItems")>] member inline this.TabItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TabItems), x)
    [<CustomOperation("TabItems'")>] member inline this.TabItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TabItems), x)
    [<CustomOperation("TabItemsSource")>] member inline this.TabItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemsSource), (fun ctx x -> ctx.Element.TabItemsSource <- x), x)
    [<CustomOperation("TabItemsSource")>] member inline this.TabItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemsSource), (fun ctx x -> ctx.Element.TabItemsSource <- x), x)
    [<CustomOperation("TabStripFooter")>] member inline this.TabStripFooter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripFooter), (fun ctx x -> ctx.Element.TabStripFooter <- x), x)
    [<CustomOperation("TabStripFooter")>] member inline this.TabStripFooter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripFooter), (fun ctx x -> ctx.Element.TabStripFooter <- x), x)
    [<CustomOperation("TabStripFooterTemplate")>] member inline this.TabStripFooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripFooterTemplate), (fun ctx x -> ctx.Element.TabStripFooterTemplate <- x), x)
    [<CustomOperation("TabStripFooterTemplate")>] member inline this.TabStripFooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripFooterTemplate), (fun ctx x -> ctx.Element.TabStripFooterTemplate <- x), x)
    [<CustomOperation("TabStripHeader")>] member inline this.TabStripHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripHeader), (fun ctx x -> ctx.Element.TabStripHeader <- x), x)
    [<CustomOperation("TabStripHeader")>] member inline this.TabStripHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripHeader), (fun ctx x -> ctx.Element.TabStripHeader <- x), x)
    [<CustomOperation("TabStripHeaderTemplate")>] member inline this.TabStripHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripHeaderTemplate), (fun ctx x -> ctx.Element.TabStripHeaderTemplate <- x), x)
    [<CustomOperation("TabStripHeaderTemplate")>] member inline this.TabStripHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripHeaderTemplate), (fun ctx x -> ctx.Element.TabStripHeaderTemplate <- x), x)
    [<CustomOperation("TabWidthMode")>] member inline this.TabWidthMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TabViewWidthMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabWidthMode), (fun ctx x -> ctx.Element.TabWidthMode <- x), x)
    [<CustomOperation("TabWidthMode")>] member inline this.TabWidthMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabWidthMode), (fun ctx x -> ctx.Element.TabWidthMode <- x), x)

    [<CustomOperation("AddTabButtonClick")>] member inline this.AddTabButtonClick ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AddTabButtonClick), "AddTabButtonClick", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
    [<CustomOperation("TabCloseRequested")>] member inline this.TabCloseRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabCloseRequested), "TabCloseRequested", fn)
    [<CustomOperation("TabDragCompleted")>] member inline this.TabDragCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabDragCompleted), "TabDragCompleted", fn)
    [<CustomOperation("TabDragStarting")>] member inline this.TabDragStarting ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabDragStarting), "TabDragStarting", fn)
    [<CustomOperation("TabDroppedOutside")>] member inline this.TabDroppedOutside ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabDroppedOutside), "TabDroppedOutside", fn)
    [<CustomOperation("TabItemsChanged")>] member inline this.TabItemsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabItemsChanged), "TabItemsChanged", fn)
    [<CustomOperation("TabStripDragOver")>] member inline this.TabStripDragOver ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripDragOver), "TabStripDragOver", fn)
    [<CustomOperation("TabStripDrop")>] member inline this.TabStripDrop ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripDrop), "TabStripDrop", fn)
                

type TextBoxBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TextBox>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("CharacterCasing")>] member inline this.CharacterCasing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CharacterCasing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterCasing), (fun ctx x -> ctx.Element.CharacterCasing <- x), x)
    [<CustomOperation("CharacterCasing")>] member inline this.CharacterCasing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterCasing), (fun ctx x -> ctx.Element.CharacterCasing <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("DesiredCandidateWindowAlignment")>] member inline this.DesiredCandidateWindowAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.CandidateWindowAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCandidateWindowAlignment), (fun ctx x -> ctx.Element.DesiredCandidateWindowAlignment <- x), x)
    [<CustomOperation("DesiredCandidateWindowAlignment")>] member inline this.DesiredCandidateWindowAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DesiredCandidateWindowAlignment), (fun ctx x -> ctx.Element.DesiredCandidateWindowAlignment <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Input.InputScope) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("InputScope")>] member inline this.InputScope ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputScope), (fun ctx x -> ctx.Element.InputScope <- x), x)
    [<CustomOperation("IsColorFontEnabled")>] member inline this.IsColorFontEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorFontEnabled), (fun ctx x -> ctx.Element.IsColorFontEnabled <- x), x)
    [<CustomOperation("IsColorFontEnabled")>] member inline this.IsColorFontEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsColorFontEnabled), (fun ctx x -> ctx.Element.IsColorFontEnabled <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsSpellCheckEnabled")>] member inline this.IsSpellCheckEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSpellCheckEnabled), (fun ctx x -> ctx.Element.IsSpellCheckEnabled <- x), x)
    [<CustomOperation("IsSpellCheckEnabled")>] member inline this.IsSpellCheckEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSpellCheckEnabled), (fun ctx x -> ctx.Element.IsSpellCheckEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("PlaceholderForeground")>] member inline this.PlaceholderForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderForeground), (fun ctx x -> ctx.Element.PlaceholderForeground <- x), x)
    [<CustomOperation("PlaceholderForeground")>] member inline this.PlaceholderForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderForeground), (fun ctx x -> ctx.Element.PlaceholderForeground <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("PreventKeyboardDisplayOnProgrammaticFocus")>] member inline this.PreventKeyboardDisplayOnProgrammaticFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus), (fun ctx x -> ctx.Element.PreventKeyboardDisplayOnProgrammaticFocus <- x), x)
    [<CustomOperation("ProofingMenuFlyout")>] member inline this.ProofingMenuFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ProofingMenuFlyout), x)
    [<CustomOperation("ProofingMenuFlyout'")>] member inline this.ProofingMenuFlyout' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ProofingMenuFlyout), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedText), (fun ctx x -> ctx.Element.SelectedText <- x), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedText), (fun ctx x -> ctx.Element.SelectedText <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionFlyout")>] member inline this.SelectionFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionFlyout), (fun ctx x -> ctx.Element.SelectionFlyout <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.SolidColorBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SelectionHighlightColor")>] member inline this.SelectionHighlightColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColor), (fun ctx x -> ctx.Element.SelectionHighlightColor <- x), x)
    [<CustomOperation("SelectionHighlightColorWhenNotFocused")>] member inline this.SelectionHighlightColorWhenNotFocused ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.SolidColorBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColorWhenNotFocused), (fun ctx x -> ctx.Element.SelectionHighlightColorWhenNotFocused <- x), x)
    [<CustomOperation("SelectionHighlightColorWhenNotFocused")>] member inline this.SelectionHighlightColorWhenNotFocused ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionHighlightColorWhenNotFocused), (fun ctx x -> ctx.Element.SelectionHighlightColorWhenNotFocused <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextReadingOrder) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("TextReadingOrder")>] member inline this.TextReadingOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextReadingOrder), (fun ctx x -> ctx.Element.TextReadingOrder <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)

    [<CustomOperation("BeforeTextChanging")>] member inline this.BeforeTextChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BeforeTextChanging), "BeforeTextChanging", fn)
    [<CustomOperation("CandidateWindowBoundsChanged")>] member inline this.CandidateWindowBoundsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CandidateWindowBoundsChanged), "CandidateWindowBoundsChanged", fn)
    [<CustomOperation("ContextMenuOpening")>] member inline this.ContextMenuOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuOpening), "ContextMenuOpening", fn)
    [<CustomOperation("CopyingToClipboard")>] member inline this.CopyingToClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CopyingToClipboard), "CopyingToClipboard", fn)
    [<CustomOperation("CuttingToClipboard")>] member inline this.CuttingToClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CuttingToClipboard), "CuttingToClipboard", fn)
    [<CustomOperation("Paste")>] member inline this.Paste ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Paste), "Paste", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
    [<CustomOperation("SelectionChanging")>] member inline this.SelectionChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanging), "SelectionChanging", fn)
    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
    [<CustomOperation("TextChanging")>] member inline this.TextChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanging), "TextChanging", fn)
    [<CustomOperation("TextCompositionChanged")>] member inline this.TextCompositionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextCompositionChanged), "TextCompositionChanged", fn)
    [<CustomOperation("TextCompositionEnded")>] member inline this.TextCompositionEnded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextCompositionEnded), "TextCompositionEnded", fn)
    [<CustomOperation("TextCompositionStarted")>] member inline this.TextCompositionStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextCompositionStarted), "TextCompositionStarted", fn)
                

type TimePickerBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TimePicker>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("ClockIdentifier")>] member inline this.ClockIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClockIdentifier), (fun ctx x -> ctx.Element.ClockIdentifier <- x), x)
    [<CustomOperation("ClockIdentifier")>] member inline this.ClockIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClockIdentifier), (fun ctx x -> ctx.Element.ClockIdentifier <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.LightDismissOverlayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("LightDismissOverlayMode")>] member inline this.LightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LightDismissOverlayMode), (fun ctx x -> ctx.Element.LightDismissOverlayMode <- x), x)
    [<CustomOperation("MinuteIncrement")>] member inline this.MinuteIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinuteIncrement), (fun ctx x -> ctx.Element.MinuteIncrement <- x), x)
    [<CustomOperation("MinuteIncrement")>] member inline this.MinuteIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinuteIncrement), (fun ctx x -> ctx.Element.MinuteIncrement <- x), x)
    [<CustomOperation("SelectedTime")>] member inline this.SelectedTime ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.TimeSpan>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTime), (fun ctx x -> ctx.Element.SelectedTime <- x), x)
    [<CustomOperation("SelectedTime")>] member inline this.SelectedTime ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTime), (fun ctx x -> ctx.Element.SelectedTime <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)

    [<CustomOperation("SelectedTimeChanged")>] member inline this.SelectedTimeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTimeChanged), "SelectedTimeChanged", fn)
    [<CustomOperation("TimeChanged")>] member inline this.TimeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TimeChanged), "TimeChanged", fn)
                

type TimePickerFlyoutPresenterBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.TimePickerFlyoutPresenter>()

    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TimePickerFlyoutPresenter>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)
    [<CustomOperation("IsDefaultShadowEnabled")>] member inline this.IsDefaultShadowEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TimePickerFlyoutPresenter>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefaultShadowEnabled), (fun ctx x -> ctx.Element.IsDefaultShadowEnabled <- x), x)

                

type ToggleSwitchBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.ToggleSwitch>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsOn")>] member inline this.IsOn ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOn), (fun ctx x -> ctx.Element.IsOn <- x), x)
    [<CustomOperation("IsOn")>] member inline this.IsOn ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOn), (fun ctx x -> ctx.Element.IsOn <- x), x)
    [<CustomOperation("OffContent")>] member inline this.OffContent ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OffContent), (fun ctx x -> ctx.Element.OffContent <- x), x)
    [<CustomOperation("OffContent")>] member inline this.OffContent ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OffContent), (fun ctx x -> ctx.Element.OffContent <- x), x)
    [<CustomOperation("OffContentTemplate")>] member inline this.OffContentTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OffContentTemplate), (fun ctx x -> ctx.Element.OffContentTemplate <- x), x)
    [<CustomOperation("OffContentTemplate")>] member inline this.OffContentTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OffContentTemplate), (fun ctx x -> ctx.Element.OffContentTemplate <- x), x)
    [<CustomOperation("OnContent")>] member inline this.OnContent ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnContent), (fun ctx x -> ctx.Element.OnContent <- x), x)
    [<CustomOperation("OnContent")>] member inline this.OnContent ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OnContent), (fun ctx x -> ctx.Element.OnContent <- x), x)
    [<CustomOperation("OnContentTemplate")>] member inline this.OnContentTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnContentTemplate), (fun ctx x -> ctx.Element.OnContentTemplate <- x), x)
    [<CustomOperation("OnContentTemplate")>] member inline this.OnContentTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OnContentTemplate), (fun ctx x -> ctx.Element.OnContentTemplate <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateSettings), x)
    [<CustomOperation("TemplateSettings'")>] member inline this.TemplateSettings' ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateSettings), x)

    [<CustomOperation("Toggled")>] member inline this.Toggled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Toggled), "Toggled", fn)
                

type TreeViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TreeView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("CanDragItems")>] member inline this.CanDragItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanDragItems), (fun ctx x -> ctx.Element.CanDragItems <- x), x)
    [<CustomOperation("CanDragItems")>] member inline this.CanDragItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanDragItems), (fun ctx x -> ctx.Element.CanDragItems <- x), x)
    [<CustomOperation("CanReorderItems")>] member inline this.CanReorderItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderItems), (fun ctx x -> ctx.Element.CanReorderItems <- x), x)
    [<CustomOperation("CanReorderItems")>] member inline this.CanReorderItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderItems), (fun ctx x -> ctx.Element.CanReorderItems <- x), x)
    [<CustomOperation("ItemContainerStyle")>] member inline this.ItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyle), (fun ctx x -> ctx.Element.ItemContainerStyle <- x), x)
    [<CustomOperation("ItemContainerStyle")>] member inline this.ItemContainerStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyle), (fun ctx x -> ctx.Element.ItemContainerStyle <- x), x)
    [<CustomOperation("ItemContainerStyleSelector")>] member inline this.ItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.StyleSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyleSelector), (fun ctx x -> ctx.Element.ItemContainerStyleSelector <- x), x)
    [<CustomOperation("ItemContainerStyleSelector")>] member inline this.ItemContainerStyleSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerStyleSelector), (fun ctx x -> ctx.Element.ItemContainerStyleSelector <- x), x)
    [<CustomOperation("ItemContainerTransitions")>] member inline this.ItemContainerTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Animation.TransitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTransitions), (fun ctx x -> ctx.Element.ItemContainerTransitions <- x), x)
    [<CustomOperation("ItemContainerTransitions")>] member inline this.ItemContainerTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemContainerTransitions), (fun ctx x -> ctx.Element.ItemContainerTransitions <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplateSelector")>] member inline this.ItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.DataTemplateSelector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplateSelector), (fun ctx x -> ctx.Element.ItemTemplateSelector <- x), x)
    [<CustomOperation("ItemTemplateSelector")>] member inline this.ItemTemplateSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplateSelector), (fun ctx x -> ctx.Element.ItemTemplateSelector <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("RootNodes")>] member inline this.RootNodes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RootNodes), x)
    [<CustomOperation("RootNodes'")>] member inline this.RootNodes' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RootNodes), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedItems'")>] member inline this.SelectedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedItems), x)
    [<CustomOperation("SelectedNode")>] member inline this.SelectedNode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TreeViewNode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedNode), (fun ctx x -> ctx.Element.SelectedNode <- x), x)
    [<CustomOperation("SelectedNode")>] member inline this.SelectedNode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedNode), (fun ctx x -> ctx.Element.SelectedNode <- x), x)
    [<CustomOperation("SelectedNodes")>] member inline this.SelectedNodes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedNodes), x)
    [<CustomOperation("SelectedNodes'")>] member inline this.SelectedNodes' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedNodes), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TreeViewSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)

    [<CustomOperation("Collapsed")>] member inline this.Collapsed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Collapsed), "Collapsed", fn)
    [<CustomOperation("Expanding")>] member inline this.Expanding ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Expanding), "Expanding", fn)
    [<CustomOperation("ItemInvoked")>] member inline this.ItemInvoked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemInvoked), "ItemInvoked", fn)
    [<CustomOperation("DragItemsCompleted")>] member inline this.DragItemsCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragItemsCompleted), "DragItemsCompleted", fn)
    [<CustomOperation("DragItemsStarting")>] member inline this.DragItemsStarting ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragItemsStarting), "DragItemsStarting", fn)
                

type TwoPaneViewBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.TwoPaneView>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("MinTallModeHeight")>] member inline this.MinTallModeHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinTallModeHeight), (fun ctx x -> ctx.Element.MinTallModeHeight <- x), x)
    [<CustomOperation("MinTallModeHeight")>] member inline this.MinTallModeHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinTallModeHeight), (fun ctx x -> ctx.Element.MinTallModeHeight <- x), x)
    [<CustomOperation("MinWideModeWidth")>] member inline this.MinWideModeWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinWideModeWidth), (fun ctx x -> ctx.Element.MinWideModeWidth <- x), x)
    [<CustomOperation("MinWideModeWidth")>] member inline this.MinWideModeWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinWideModeWidth), (fun ctx x -> ctx.Element.MinWideModeWidth <- x), x)
    [<CustomOperation("Pane1")>] member inline this.Pane1 ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Pane1), (fun ctx x -> ctx.Element.Pane1 <- x), x)
    [<CustomOperation("Pane1")>] member inline this.Pane1 ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Pane1), (fun ctx x -> ctx.Element.Pane1 <- x), x)
    [<CustomOperation("Pane1Length")>] member inline this.Pane1Length ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.GridLength) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Pane1Length), (fun ctx x -> ctx.Element.Pane1Length <- x), x)
    [<CustomOperation("Pane1Length")>] member inline this.Pane1Length ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Pane1Length), (fun ctx x -> ctx.Element.Pane1Length <- x), x)
    [<CustomOperation("Pane2")>] member inline this.Pane2 ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Pane2), (fun ctx x -> ctx.Element.Pane2 <- x), x)
    [<CustomOperation("Pane2")>] member inline this.Pane2 ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Pane2), (fun ctx x -> ctx.Element.Pane2 <- x), x)
    [<CustomOperation("Pane2Length")>] member inline this.Pane2Length ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.GridLength) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Pane2Length), (fun ctx x -> ctx.Element.Pane2Length <- x), x)
    [<CustomOperation("Pane2Length")>] member inline this.Pane2Length ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Pane2Length), (fun ctx x -> ctx.Element.Pane2Length <- x), x)
    [<CustomOperation("PanePriority")>] member inline this.PanePriority ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TwoPaneViewPriority) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanePriority), (fun ctx x -> ctx.Element.PanePriority <- x), x)
    [<CustomOperation("PanePriority")>] member inline this.PanePriority ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanePriority), (fun ctx x -> ctx.Element.PanePriority <- x), x)
    [<CustomOperation("TallModeConfiguration")>] member inline this.TallModeConfiguration ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TallModeConfiguration), (fun ctx x -> ctx.Element.TallModeConfiguration <- x), x)
    [<CustomOperation("TallModeConfiguration")>] member inline this.TallModeConfiguration ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TallModeConfiguration), (fun ctx x -> ctx.Element.TallModeConfiguration <- x), x)
    [<CustomOperation("WideModeConfiguration")>] member inline this.WideModeConfiguration ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WideModeConfiguration), (fun ctx x -> ctx.Element.WideModeConfiguration <- x), x)
    [<CustomOperation("WideModeConfiguration")>] member inline this.WideModeConfiguration ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WideModeConfiguration), (fun ctx x -> ctx.Element.WideModeConfiguration <- x), x)

    [<CustomOperation("ModeChanged")>] member inline this.ModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModeChanged), "ModeChanged", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ColorSpectrumBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.ColorSpectrum>() =
    inherit ControlBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Components")>] member inline this.Components ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ColorSpectrumComponents) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Components), (fun ctx x -> ctx.Element.Components <- x), x)
    [<CustomOperation("Components")>] member inline this.Components ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Components), (fun ctx x -> ctx.Element.Components <- x), x)
    [<CustomOperation("HsvColor")>] member inline this.HsvColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Numerics.Vector4) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HsvColor), (fun ctx x -> ctx.Element.HsvColor <- x), x)
    [<CustomOperation("HsvColor")>] member inline this.HsvColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HsvColor), (fun ctx x -> ctx.Element.HsvColor <- x), x)
    [<CustomOperation("MaxHue")>] member inline this.MaxHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHue), (fun ctx x -> ctx.Element.MaxHue <- x), x)
    [<CustomOperation("MaxHue")>] member inline this.MaxHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHue), (fun ctx x -> ctx.Element.MaxHue <- x), x)
    [<CustomOperation("MaxSaturation")>] member inline this.MaxSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxSaturation), (fun ctx x -> ctx.Element.MaxSaturation <- x), x)
    [<CustomOperation("MaxSaturation")>] member inline this.MaxSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxSaturation), (fun ctx x -> ctx.Element.MaxSaturation <- x), x)
    [<CustomOperation("MaxValue")>] member inline this.MaxValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxValue), (fun ctx x -> ctx.Element.MaxValue <- x), x)
    [<CustomOperation("MaxValue")>] member inline this.MaxValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxValue), (fun ctx x -> ctx.Element.MaxValue <- x), x)
    [<CustomOperation("MinHue")>] member inline this.MinHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinHue), (fun ctx x -> ctx.Element.MinHue <- x), x)
    [<CustomOperation("MinHue")>] member inline this.MinHue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinHue), (fun ctx x -> ctx.Element.MinHue <- x), x)
    [<CustomOperation("MinSaturation")>] member inline this.MinSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinSaturation), (fun ctx x -> ctx.Element.MinSaturation <- x), x)
    [<CustomOperation("MinSaturation")>] member inline this.MinSaturation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinSaturation), (fun ctx x -> ctx.Element.MinSaturation <- x), x)
    [<CustomOperation("MinValue")>] member inline this.MinValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinValue), (fun ctx x -> ctx.Element.MinValue <- x), x)
    [<CustomOperation("MinValue")>] member inline this.MinValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinValue), (fun ctx x -> ctx.Element.MinValue <- x), x)
    [<CustomOperation("Shape")>] member inline this.Shape ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.ColorSpectrumShape) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Shape), (fun ctx x -> ctx.Element.Shape <- x), x)
    [<CustomOperation("Shape")>] member inline this.Shape ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Shape), (fun ctx x -> ctx.Element.Shape <- x), x)

    [<CustomOperation("ColorChanged")>] member inline this.ColorChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ColorChanged), "ColorChanged", fn)
                

type LoopingSelectorBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>()

    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: Microsoft.UI.Xaml.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: System.Collections.Generic.IList<System.Object>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("ShouldLoop")>] member inline this.ShouldLoop ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldLoop), (fun ctx x -> ctx.Element.ShouldLoop <- x), x)
    [<CustomOperation("ShouldLoop")>] member inline this.ShouldLoop ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldLoop), (fun ctx x -> ctx.Element.ShouldLoop <- x), x)

    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelector>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type ThumbBuilder() =
    inherit ControlBuilder<Microsoft.UI.Xaml.Controls.Primitives.Thumb>()


    [<CustomOperation("DragCompleted")>] member inline this.DragCompleted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.Thumb>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragCompleted), "DragCompleted", fn)
    [<CustomOperation("DragDelta")>] member inline this.DragDelta ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.Thumb>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragDelta), "DragDelta", fn)
    [<CustomOperation("DragStarted")>] member inline this.DragStarted ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.Thumb>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStarted), "DragStarted", fn)
                
            

// =======================================================================================================================

namespace Fun.SunUI.WinUI

[<AutoOpen>]
module WinUIControlBuilderDslCE_MicrosoftUIXamlControls =
  
    open Fun.SunUI
    open Fun.SunUI.WinUI.DslInternals

    type ContentControl' () = 
        inherit ContentControlBuilder<Microsoft.UI.Xaml.Controls.ContentControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ContentControl>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ContentControl()), this.GetRenderMode())

    type Button' () = 
        inherit ButtonBuilder<Microsoft.UI.Xaml.Controls.Button>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Button>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Button()), this.GetRenderMode())

    type AppBarButton' () = 
        inherit AppBarButtonBuilder<Microsoft.UI.Xaml.Controls.AppBarButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AppBarButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.AppBarButton()), this.GetRenderMode())

    type DropDownButton' () = 
        inherit DropDownButtonBuilder<Microsoft.UI.Xaml.Controls.DropDownButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.DropDownButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.DropDownButton()), this.GetRenderMode())

    type AppBarToggleButton' () = 
        inherit AppBarToggleButtonBuilder<Microsoft.UI.Xaml.Controls.AppBarToggleButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AppBarToggleButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.AppBarToggleButton()), this.GetRenderMode())

    type CheckBox' () = 
        inherit CheckBoxBuilder<Microsoft.UI.Xaml.Controls.CheckBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.CheckBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.CheckBox()), this.GetRenderMode())

    type RadioButton' () = 
        inherit RadioButtonBuilder<Microsoft.UI.Xaml.Controls.RadioButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RadioButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RadioButton()), this.GetRenderMode())

    type HyperlinkButton' () = 
        inherit HyperlinkButtonBuilder<Microsoft.UI.Xaml.Controls.HyperlinkButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.HyperlinkButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.HyperlinkButton()), this.GetRenderMode())

    type ListViewItem' () = 
        inherit ListViewItemBuilder<Microsoft.UI.Xaml.Controls.ListViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ListViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ListViewItem()), this.GetRenderMode())

    type TabViewItem' () = 
        inherit TabViewItemBuilder<Microsoft.UI.Xaml.Controls.TabViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TabViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TabViewItem()), this.GetRenderMode())

    type TreeViewItem' () = 
        inherit TreeViewItemBuilder<Microsoft.UI.Xaml.Controls.TreeViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TreeViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TreeViewItem()), this.GetRenderMode())

    type ComboBoxItem' () = 
        inherit ComboBoxItemBuilder<Microsoft.UI.Xaml.Controls.ComboBoxItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ComboBoxItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ComboBoxItem()), this.GetRenderMode())

    type FlipViewItem' () = 
        inherit FlipViewItemBuilder<Microsoft.UI.Xaml.Controls.FlipViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.FlipViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.FlipViewItem()), this.GetRenderMode())

    type GridViewItem' () = 
        inherit GridViewItemBuilder<Microsoft.UI.Xaml.Controls.GridViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.GridViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.GridViewItem()), this.GetRenderMode())

    type ListBoxItem' () = 
        inherit ListBoxItemBuilder<Microsoft.UI.Xaml.Controls.ListBoxItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ListBoxItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ListBoxItem()), this.GetRenderMode())

    type AppBar' () = 
        inherit AppBarBuilder<Microsoft.UI.Xaml.Controls.AppBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AppBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.AppBar()), this.GetRenderMode())

    type CommandBar' () = 
        inherit CommandBarBuilder<Microsoft.UI.Xaml.Controls.CommandBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.CommandBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.CommandBar()), this.GetRenderMode())

    type GridViewHeaderItem' () = 
        inherit GridViewHeaderItemBuilder<Microsoft.UI.Xaml.Controls.GridViewHeaderItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.GridViewHeaderItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.GridViewHeaderItem()), this.GetRenderMode())

    type ListViewHeaderItem' () = 
        inherit ListViewHeaderItemBuilder<Microsoft.UI.Xaml.Controls.ListViewHeaderItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ListViewHeaderItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ListViewHeaderItem()), this.GetRenderMode())

    type NavigationViewItem' () = 
        inherit NavigationViewItemBuilder<Microsoft.UI.Xaml.Controls.NavigationViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.NavigationViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.NavigationViewItem()), this.GetRenderMode())

    type NavigationViewItemHeader' () = 
        inherit NavigationViewItemHeaderBuilder<Microsoft.UI.Xaml.Controls.NavigationViewItemHeader>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.NavigationViewItemHeader>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.NavigationViewItemHeader()), this.GetRenderMode())

    type NavigationViewItemSeparator' () = 
        inherit NavigationViewItemSeparatorBuilder<Microsoft.UI.Xaml.Controls.NavigationViewItemSeparator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.NavigationViewItemSeparator>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.NavigationViewItemSeparator()), this.GetRenderMode())

    type SplitButton' () = 
        inherit SplitButtonBuilder<Microsoft.UI.Xaml.Controls.SplitButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SplitButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.SplitButton()), this.GetRenderMode())

    type ToggleSplitButton' () = 
        inherit ToggleSplitButtonBuilder<Microsoft.UI.Xaml.Controls.ToggleSplitButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSplitButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ToggleSplitButton()), this.GetRenderMode())

    type AppBarElementContainer' () = 
        inherit AppBarElementContainerBuilder<Microsoft.UI.Xaml.Controls.AppBarElementContainer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AppBarElementContainer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.AppBarElementContainer()), this.GetRenderMode())

    type BreadcrumbBarItem' () = 
        inherit BreadcrumbBarItemBuilder<Microsoft.UI.Xaml.Controls.BreadcrumbBarItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.BreadcrumbBarItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.BreadcrumbBarItem()), this.GetRenderMode())

    type ContentDialog' () = 
        inherit ContentDialogBuilder<Microsoft.UI.Xaml.Controls.ContentDialog>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ContentDialog>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ContentDialog()), this.GetRenderMode())

    type Expander' () = 
        inherit ExpanderBuilder<Microsoft.UI.Xaml.Controls.Expander>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Expander>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Expander()), this.GetRenderMode())

    type FlyoutPresenter' () = 
        inherit FlyoutPresenterBuilder<Microsoft.UI.Xaml.Controls.FlyoutPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.FlyoutPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.FlyoutPresenter()), this.GetRenderMode())

    type Frame' () = 
        inherit FrameBuilder<Microsoft.UI.Xaml.Controls.Frame>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Frame>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Frame()), this.GetRenderMode())

    type GroupItem' () = 
        inherit GroupItemBuilder<Microsoft.UI.Xaml.Controls.GroupItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.GroupItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.GroupItem()), this.GetRenderMode())

    type NavigationView' () = 
        inherit NavigationViewBuilder<Microsoft.UI.Xaml.Controls.NavigationView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.NavigationView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.NavigationView()), this.GetRenderMode())

    type PivotItem' () = 
        inherit PivotItemBuilder<Microsoft.UI.Xaml.Controls.PivotItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PivotItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.PivotItem()), this.GetRenderMode())

    type RefreshContainer' () = 
        inherit RefreshContainerBuilder<Microsoft.UI.Xaml.Controls.RefreshContainer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RefreshContainer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RefreshContainer()), this.GetRenderMode())

    type ScrollViewer' () = 
        inherit ScrollViewerBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ScrollViewer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ScrollViewer()), this.GetRenderMode())

    type SwipeControl' () = 
        inherit SwipeControlBuilder<Microsoft.UI.Xaml.Controls.SwipeControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SwipeControl>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.SwipeControl()), this.GetRenderMode())

    type TeachingTip' () = 
        inherit TeachingTipBuilder<Microsoft.UI.Xaml.Controls.TeachingTip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TeachingTip>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TeachingTip()), this.GetRenderMode())

    type ToolTip' () = 
        inherit ToolTipBuilder<Microsoft.UI.Xaml.Controls.ToolTip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToolTip>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ToolTip()), this.GetRenderMode())

    type ItemsControl' () = 
        inherit ItemsControlBuilder<Microsoft.UI.Xaml.Controls.ItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ItemsControl()), this.GetRenderMode())

    type ListView' () = 
        inherit ListViewBuilder<Microsoft.UI.Xaml.Controls.ListView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ListView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ListView()), this.GetRenderMode())

    type TreeViewList' () = 
        inherit TreeViewListBuilder<Microsoft.UI.Xaml.Controls.TreeViewList>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TreeViewList>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TreeViewList()), this.GetRenderMode())

    type GridView' () = 
        inherit GridViewBuilder<Microsoft.UI.Xaml.Controls.GridView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.GridView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.GridView()), this.GetRenderMode())

    type ComboBox' () = 
        inherit ComboBoxBuilder<Microsoft.UI.Xaml.Controls.ComboBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ComboBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ComboBox()), this.GetRenderMode())

    type FlipView' () = 
        inherit FlipViewBuilder<Microsoft.UI.Xaml.Controls.FlipView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.FlipView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.FlipView()), this.GetRenderMode())

    type ListBox' () = 
        inherit ListBoxBuilder<Microsoft.UI.Xaml.Controls.ListBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ListBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ListBox()), this.GetRenderMode())

    type AutoSuggestBox' () = 
        inherit AutoSuggestBoxBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AutoSuggestBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.AutoSuggestBox()), this.GetRenderMode())

    type CommandBarOverflowPresenter' () = 
        inherit CommandBarOverflowPresenterBuilder<Microsoft.UI.Xaml.Controls.CommandBarOverflowPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.CommandBarOverflowPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.CommandBarOverflowPresenter()), this.GetRenderMode())

    type MenuFlyoutPresenter' () = 
        inherit MenuFlyoutPresenterBuilder<Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter()), this.GetRenderMode())

    type Pivot' () = 
        inherit PivotBuilder<Microsoft.UI.Xaml.Controls.Pivot>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Pivot>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Pivot()), this.GetRenderMode())

    type MenuFlyoutItem' () = 
        inherit MenuFlyoutItemBuilder<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.MenuFlyoutItem()), this.GetRenderMode())

    type RadioMenuFlyoutItem' () = 
        inherit RadioMenuFlyoutItemBuilder<Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem()), this.GetRenderMode())

    type ToggleMenuFlyoutItem' () = 
        inherit ToggleMenuFlyoutItemBuilder<Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem()), this.GetRenderMode())

    type MenuFlyoutSeparator' () = 
        inherit MenuFlyoutSeparatorBuilder<Microsoft.UI.Xaml.Controls.MenuFlyoutSeparator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSeparator>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.MenuFlyoutSeparator()), this.GetRenderMode())

    type MenuFlyoutSubItem' () = 
        inherit MenuFlyoutSubItemBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem()), this.GetRenderMode())

    type Slider' () = 
        inherit SliderBuilder<Microsoft.UI.Xaml.Controls.Slider>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Slider>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Slider()), this.GetRenderMode())

    type ProgressBar' () = 
        inherit ProgressBarBuilder<Microsoft.UI.Xaml.Controls.ProgressBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ProgressBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ProgressBar()), this.GetRenderMode())

    type UserControl' () = 
        inherit UserControlBuilder<Microsoft.UI.Xaml.Controls.UserControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.UserControl>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.UserControl()), this.GetRenderMode())

    type Page' () = 
        inherit PageBuilder<Microsoft.UI.Xaml.Controls.Page>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Page>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Page()), this.GetRenderMode())

    type AppBarSeparator' () = 
        inherit AppBarSeparatorBuilder<Microsoft.UI.Xaml.Controls.AppBarSeparator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.AppBarSeparator>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.AppBarSeparator()), this.GetRenderMode())

    type BreadcrumbBar' () = 
        inherit BreadcrumbBarBuilder<Microsoft.UI.Xaml.Controls.BreadcrumbBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.BreadcrumbBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.BreadcrumbBar()), this.GetRenderMode())

    type CalendarDatePicker' () = 
        inherit CalendarDatePickerBuilder<Microsoft.UI.Xaml.Controls.CalendarDatePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.CalendarDatePicker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.CalendarDatePicker()), this.GetRenderMode())

    type CalendarView' () = 
        inherit CalendarViewBuilder<Microsoft.UI.Xaml.Controls.CalendarView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.CalendarView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.CalendarView()), this.GetRenderMode())

    type CalendarViewDayItem' () = 
        inherit CalendarViewDayItemBuilder<Microsoft.UI.Xaml.Controls.CalendarViewDayItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.CalendarViewDayItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.CalendarViewDayItem()), this.GetRenderMode())

    type ColorPicker' () = 
        inherit ColorPickerBuilder<Microsoft.UI.Xaml.Controls.ColorPicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ColorPicker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ColorPicker()), this.GetRenderMode())

    type DatePicker' () = 
        inherit DatePickerBuilder<Microsoft.UI.Xaml.Controls.DatePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.DatePicker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.DatePicker()), this.GetRenderMode())

    type Hub' () = 
        inherit HubBuilder<Microsoft.UI.Xaml.Controls.Hub>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Hub>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Hub()), this.GetRenderMode())

    type HubSection' () = 
        inherit HubSectionBuilder<Microsoft.UI.Xaml.Controls.HubSection>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.HubSection>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.HubSection()), this.GetRenderMode())

    type InfoBar' () = 
        inherit InfoBarBuilder<Microsoft.UI.Xaml.Controls.InfoBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.InfoBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.InfoBar()), this.GetRenderMode())

    type MenuBar' () = 
        inherit MenuBarBuilder<Microsoft.UI.Xaml.Controls.MenuBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.MenuBar()), this.GetRenderMode())

    type MenuBarItem' () = 
        inherit MenuBarItemBuilder<Microsoft.UI.Xaml.Controls.MenuBarItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.MenuBarItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.MenuBarItem()), this.GetRenderMode())

    type NumberBox' () = 
        inherit NumberBoxBuilder<Microsoft.UI.Xaml.Controls.NumberBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.NumberBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.NumberBox()), this.GetRenderMode())

    type PasswordBox' () = 
        inherit PasswordBoxBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PasswordBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.PasswordBox()), this.GetRenderMode())

    type PersonPicture' () = 
        inherit PersonPictureBuilder<Microsoft.UI.Xaml.Controls.PersonPicture>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PersonPicture>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.PersonPicture()), this.GetRenderMode())

    type PipsPager' () = 
        inherit PipsPagerBuilder<Microsoft.UI.Xaml.Controls.PipsPager>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.PipsPager>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.PipsPager()), this.GetRenderMode())

    type ProgressRing' () = 
        inherit ProgressRingBuilder<Microsoft.UI.Xaml.Controls.ProgressRing>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ProgressRing>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ProgressRing()), this.GetRenderMode())

    type RadioButtons' () = 
        inherit RadioButtonsBuilder<Microsoft.UI.Xaml.Controls.RadioButtons>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RadioButtons>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RadioButtons()), this.GetRenderMode())

    type RatingControl' () = 
        inherit RatingControlBuilder<Microsoft.UI.Xaml.Controls.RatingControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RatingControl>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RatingControl()), this.GetRenderMode())

    type RefreshVisualizer' () = 
        inherit RefreshVisualizerBuilder<Microsoft.UI.Xaml.Controls.RefreshVisualizer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RefreshVisualizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RefreshVisualizer()), this.GetRenderMode())

    type RichEditBox' () = 
        inherit RichEditBoxBuilder<Microsoft.UI.Xaml.Controls.RichEditBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RichEditBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RichEditBox()), this.GetRenderMode())

    type SemanticZoom' () = 
        inherit SemanticZoomBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SemanticZoom>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.SemanticZoom()), this.GetRenderMode())

    type SplitView' () = 
        inherit SplitViewBuilder<Microsoft.UI.Xaml.Controls.SplitView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SplitView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.SplitView()), this.GetRenderMode())

    type TabView' () = 
        inherit TabViewBuilder<Microsoft.UI.Xaml.Controls.TabView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TabView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TabView()), this.GetRenderMode())

    type TextBox' () = 
        inherit TextBoxBuilder<Microsoft.UI.Xaml.Controls.TextBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TextBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TextBox()), this.GetRenderMode())

    type TimePicker' () = 
        inherit TimePickerBuilder<Microsoft.UI.Xaml.Controls.TimePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TimePicker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TimePicker()), this.GetRenderMode())

    type ToggleSwitch' () = 
        inherit ToggleSwitchBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ToggleSwitch>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ToggleSwitch()), this.GetRenderMode())

    type TreeView' () = 
        inherit TreeViewBuilder<Microsoft.UI.Xaml.Controls.TreeView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TreeView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TreeView()), this.GetRenderMode())

    type TwoPaneView' () = 
        inherit TwoPaneViewBuilder<Microsoft.UI.Xaml.Controls.TwoPaneView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.TwoPaneView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.TwoPaneView()), this.GetRenderMode())

            
namespace Fun.SunUI.WinUI.Primitives

[<AutoOpen>]
module WinUIControlBuilderDslCE_MicrosoftUIXamlControlsPrimitives =
  
    open Fun.SunUI
    open Fun.SunUI.WinUI.DslInternals.Primitives

    type ToggleButton' () = 
        inherit ToggleButtonBuilder<Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.ToggleButton()), this.GetRenderMode())

    type RepeatButton' () = 
        inherit RepeatButtonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.RepeatButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.RepeatButton()), this.GetRenderMode())

    type CommandBarFlyoutCommandBar' () = 
        inherit CommandBarFlyoutCommandBarBuilder<Microsoft.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBar()), this.GetRenderMode())

    type NavigationViewItemPresenter' () = 
        inherit NavigationViewItemPresenterBuilder<Microsoft.UI.Xaml.Controls.Primitives.NavigationViewItemPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.NavigationViewItemPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.NavigationViewItemPresenter()), this.GetRenderMode())

    type PivotHeaderItem' () = 
        inherit PivotHeaderItemBuilder<Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderItem()), this.GetRenderMode())

    type TabViewListView' () = 
        inherit TabViewListViewBuilder<Microsoft.UI.Xaml.Controls.Primitives.TabViewListView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.TabViewListView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.TabViewListView()), this.GetRenderMode())

    type ColorPickerSlider' () = 
        inherit ColorPickerSliderBuilder<Microsoft.UI.Xaml.Controls.Primitives.ColorPickerSlider>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ColorPickerSlider>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.ColorPickerSlider()), this.GetRenderMode())

    type ScrollBar' () = 
        inherit ScrollBarBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ScrollBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.ScrollBar()), this.GetRenderMode())

    type ColorSpectrum' () = 
        inherit ColorSpectrumBuilder<Microsoft.UI.Xaml.Controls.Primitives.ColorSpectrum>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.ColorSpectrum>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.ColorSpectrum()), this.GetRenderMode())

    type Thumb' () = 
        inherit ThumbBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.Thumb>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.Thumb()), this.GetRenderMode())

            