namespace rec Fun.SunUI.Avalonia.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type AvaloniaObjectBuilder<'Element when 'Element :> Avalonia.AvaloniaObject>() =
    inherit AvaloniaElementBuilder<'Element>()


    [<CustomOperation("PropertyChanged")>] member inline this.PropertyChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PropertyChanged), "PropertyChanged", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Animation

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type AnimatableBuilder<'Element when 'Element :> Avalonia.Animation.Animatable>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("Clock")>] member inline this.Clock ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Animation.IClock) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Clock), (fun ctx x -> ctx.Element.Clock <- x), x)
    [<CustomOperation("Clock")>] member inline this.Clock ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Clock), (fun ctx x -> ctx.Element.Clock <- x), x)
    [<CustomOperation("Transitions")>] member inline this.Transitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Animation.Transitions) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Transitions), (fun ctx x -> ctx.Element.Transitions <- x), x)
    [<CustomOperation("Transitions")>] member inline this.Transitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Transitions), (fun ctx x -> ctx.Element.Transitions <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type StyledElementBuilder<'Element when 'Element :> Avalonia.StyledElement>() =
    inherit Animation.AnimatableBuilder<'Element>()

    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("Classes")>] member inline this.Classes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Classes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Classes), (fun ctx x -> ctx.Element.Classes <- x), x)
    [<CustomOperation("Classes")>] member inline this.Classes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Classes), (fun ctx x -> ctx.Element.Classes <- x), x)
    [<CustomOperation("DataContext")>] member inline this.DataContext ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DataContext), (fun ctx x -> ctx.Element.DataContext <- x), x)
    [<CustomOperation("DataContext")>] member inline this.DataContext ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DataContext), (fun ctx x -> ctx.Element.DataContext <- x), x)
    [<CustomOperation("StylesEx")>] member inline this.StylesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Styles), x)
    [<CustomOperation("StylesEx'")>] member inline this.StylesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Styles), x)
    [<CustomOperation("Styles")>] member inline this.Styles ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Styles), x)
    [<CustomOperation("Styles'")>] member inline this.Styles' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Styles), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.IResourceDictionary) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("TemplatedParentEx")>] member inline this.TemplatedParentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplatedParent), x)
    [<CustomOperation("TemplatedParentEx'")>] member inline this.TemplatedParentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplatedParent), x)
    [<CustomOperation("TemplatedParent")>] member inline this.TemplatedParent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.TemplatedParent), x)
    [<CustomOperation("TemplatedParent'")>] member inline this.TemplatedParent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.TemplatedParent), x)
    [<CustomOperation("ParentEx")>] member inline this.ParentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Parent), x)
    [<CustomOperation("ParentEx'")>] member inline this.ParentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Parent), x)
    [<CustomOperation("Parent")>] member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Parent), x)
    [<CustomOperation("Parent'")>] member inline this.Parent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Parent), x)

    [<CustomOperation("AttachedToLogicalTree")>] member inline this.AttachedToLogicalTree ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AttachedToLogicalTree), "AttachedToLogicalTree", fn)
    [<CustomOperation("DetachedFromLogicalTree")>] member inline this.DetachedFromLogicalTree ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DetachedFromLogicalTree), "DetachedFromLogicalTree", fn)
    [<CustomOperation("DataContextChanged")>] member inline this.DataContextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DataContextChanged), "DataContextChanged", fn)
    [<CustomOperation("Initialized")>] member inline this.Initialized ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Initialized), "Initialized", fn)
    [<CustomOperation("ResourcesChanged")>] member inline this.ResourcesChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ResourcesChanged), "ResourcesChanged", fn)
                

type VisualBuilder<'Element when 'Element :> Avalonia.Visual>() =
    inherit StyledElementBuilder<'Element>()

    [<CustomOperation("BoundsEx")>] member inline this.BoundsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("BoundsEx'")>] member inline this.BoundsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("Bounds'")>] member inline this.Bounds' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("TransformedBoundsEx")>] member inline this.TransformedBoundsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TransformedBounds), x)
    [<CustomOperation("TransformedBoundsEx'")>] member inline this.TransformedBoundsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TransformedBounds), x)
    [<CustomOperation("TransformedBounds")>] member inline this.TransformedBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.TransformedBounds), x)
    [<CustomOperation("TransformedBounds'")>] member inline this.TransformedBounds' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.TransformedBounds), x)
    [<CustomOperation("ClipToBounds")>] member inline this.ClipToBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClipToBounds), (fun ctx x -> ctx.Element.ClipToBounds <- x), x)
    [<CustomOperation("ClipToBounds")>] member inline this.ClipToBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClipToBounds), (fun ctx x -> ctx.Element.ClipToBounds <- x), x)
    [<CustomOperation("Clip")>] member inline this.Clip ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Geometry) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Clip), (fun ctx x -> ctx.Element.Clip <- x), x)
    [<CustomOperation("Clip")>] member inline this.Clip ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Clip), (fun ctx x -> ctx.Element.Clip <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("Opacity")>] member inline this.Opacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Opacity), (fun ctx x -> ctx.Element.Opacity <- x), x)
    [<CustomOperation("Opacity")>] member inline this.Opacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Opacity), (fun ctx x -> ctx.Element.Opacity <- x), x)
    [<CustomOperation("OpacityMask")>] member inline this.OpacityMask ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OpacityMask), (fun ctx x -> ctx.Element.OpacityMask <- x), x)
    [<CustomOperation("OpacityMask")>] member inline this.OpacityMask ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OpacityMask), (fun ctx x -> ctx.Element.OpacityMask <- x), x)
    [<CustomOperation("RenderTransform")>] member inline this.RenderTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.ITransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RenderTransform), (fun ctx x -> ctx.Element.RenderTransform <- x), x)
    [<CustomOperation("RenderTransform")>] member inline this.RenderTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RenderTransform), (fun ctx x -> ctx.Element.RenderTransform <- x), x)
    [<CustomOperation("RenderTransformOrigin")>] member inline this.RenderTransformOrigin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.RelativePoint) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RenderTransformOrigin), (fun ctx x -> ctx.Element.RenderTransformOrigin <- x), x)
    [<CustomOperation("RenderTransformOrigin")>] member inline this.RenderTransformOrigin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RenderTransformOrigin), (fun ctx x -> ctx.Element.RenderTransformOrigin <- x), x)
    [<CustomOperation("ZIndex")>] member inline this.ZIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZIndex), (fun ctx x -> ctx.Element.ZIndex <- x), x)
    [<CustomOperation("ZIndex")>] member inline this.ZIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZIndex), (fun ctx x -> ctx.Element.ZIndex <- x), x)

    [<CustomOperation("AttachedToVisualTree")>] member inline this.AttachedToVisualTree ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.AttachedToVisualTree), "AttachedToVisualTree", fn)
    [<CustomOperation("DetachedFromVisualTree")>] member inline this.DetachedFromVisualTree ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DetachedFromVisualTree), "DetachedFromVisualTree", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Layout

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type LayoutableBuilder<'Element when 'Element :> Avalonia.Layout.Layoutable>() =
    inherit VisualBuilder<'Element>()

    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("MinWidth")>] member inline this.MinWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinWidth), (fun ctx x -> ctx.Element.MinWidth <- x), x)
    [<CustomOperation("MinWidth")>] member inline this.MinWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinWidth), (fun ctx x -> ctx.Element.MinWidth <- x), x)
    [<CustomOperation("MaxWidth")>] member inline this.MaxWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxWidth), (fun ctx x -> ctx.Element.MaxWidth <- x), x)
    [<CustomOperation("MaxWidth")>] member inline this.MaxWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxWidth), (fun ctx x -> ctx.Element.MaxWidth <- x), x)
    [<CustomOperation("MinHeight")>] member inline this.MinHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinHeight), (fun ctx x -> ctx.Element.MinHeight <- x), x)
    [<CustomOperation("MinHeight")>] member inline this.MinHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinHeight), (fun ctx x -> ctx.Element.MinHeight <- x), x)
    [<CustomOperation("MaxHeight")>] member inline this.MaxHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHeight), (fun ctx x -> ctx.Element.MaxHeight <- x), x)
    [<CustomOperation("MaxHeight")>] member inline this.MaxHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHeight), (fun ctx x -> ctx.Element.MaxHeight <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("HorizontalAlignment")>] member inline this.HorizontalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalAlignment), (fun ctx x -> ctx.Element.HorizontalAlignment <- x), x)
    [<CustomOperation("HorizontalAlignment")>] member inline this.HorizontalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalAlignment), (fun ctx x -> ctx.Element.HorizontalAlignment <- x), x)
    [<CustomOperation("VerticalAlignment")>] member inline this.VerticalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalAlignment), (fun ctx x -> ctx.Element.VerticalAlignment <- x), x)
    [<CustomOperation("VerticalAlignment")>] member inline this.VerticalAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalAlignment), (fun ctx x -> ctx.Element.VerticalAlignment <- x), x)
    [<CustomOperation("DesiredSizeEx")>] member inline this.DesiredSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DesiredSize), x)
    [<CustomOperation("DesiredSizeEx'")>] member inline this.DesiredSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DesiredSize), x)
    [<CustomOperation("DesiredSize")>] member inline this.DesiredSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.DesiredSize), x)
    [<CustomOperation("DesiredSize'")>] member inline this.DesiredSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.DesiredSize), x)
    [<CustomOperation("UseLayoutRounding")>] member inline this.UseLayoutRounding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseLayoutRounding), (fun ctx x -> ctx.Element.UseLayoutRounding <- x), x)
    [<CustomOperation("UseLayoutRounding")>] member inline this.UseLayoutRounding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseLayoutRounding), (fun ctx x -> ctx.Element.UseLayoutRounding <- x), x)

    [<CustomOperation("EffectiveViewportChanged")>] member inline this.EffectiveViewportChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.EffectiveViewportChanged), "EffectiveViewportChanged", fn)
    [<CustomOperation("LayoutUpdated")>] member inline this.LayoutUpdated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutUpdated), "LayoutUpdated", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Interactivity

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type InteractiveBuilder<'Element when 'Element :> Avalonia.Interactivity.Interactive>() =
    inherit Layout.LayoutableBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Input

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type InputElementBuilder<'Element when 'Element :> Avalonia.Input.InputElement>() =
    inherit Interactivity.InteractiveBuilder<'Element>()

    [<CustomOperation("Focusable")>] member inline this.Focusable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Focusable), (fun ctx x -> ctx.Element.Focusable <- x), x)
    [<CustomOperation("Focusable")>] member inline this.Focusable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Focusable), (fun ctx x -> ctx.Element.Focusable <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.Cursor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("Cursor")>] member inline this.Cursor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Cursor), (fun ctx x -> ctx.Element.Cursor <- x), x)
    [<CustomOperation("IsHitTestVisible")>] member inline this.IsHitTestVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsHitTestVisible), (fun ctx x -> ctx.Element.IsHitTestVisible <- x), x)
    [<CustomOperation("IsHitTestVisible")>] member inline this.IsHitTestVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsHitTestVisible), (fun ctx x -> ctx.Element.IsHitTestVisible <- x), x)
    [<CustomOperation("IsTabStop")>] member inline this.IsTabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTabStop), (fun ctx x -> ctx.Element.IsTabStop <- x), x)
    [<CustomOperation("IsTabStop")>] member inline this.IsTabStop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTabStop), (fun ctx x -> ctx.Element.IsTabStop <- x), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("TabIndex")>] member inline this.TabIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabIndex), (fun ctx x -> ctx.Element.TabIndex <- x), x)
    [<CustomOperation("KeyBindingsEx")>] member inline this.KeyBindingsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.KeyBindings), x)
    [<CustomOperation("KeyBindingsEx'")>] member inline this.KeyBindingsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.KeyBindings), x)
    [<CustomOperation("KeyBindings")>] member inline this.KeyBindings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.KeyBindings), x)
    [<CustomOperation("KeyBindings'")>] member inline this.KeyBindings' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.KeyBindings), x)
    [<CustomOperation("GestureRecognizersEx")>] member inline this.GestureRecognizersEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GestureRecognizers), x)
    [<CustomOperation("GestureRecognizersEx'")>] member inline this.GestureRecognizersEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GestureRecognizers), x)
    [<CustomOperation("GestureRecognizers")>] member inline this.GestureRecognizers ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.GestureRecognizers), x)
    [<CustomOperation("GestureRecognizers'")>] member inline this.GestureRecognizers' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.GestureRecognizers), x)

    [<CustomOperation("GotFocus")>] member inline this.GotFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.GotFocus), "GotFocus", fn)
    [<CustomOperation("LostFocus")>] member inline this.LostFocus ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LostFocus), "LostFocus", fn)
    [<CustomOperation("KeyDown")>] member inline this.KeyDown ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyDown), "KeyDown", fn)
    [<CustomOperation("KeyUp")>] member inline this.KeyUp ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyUp), "KeyUp", fn)
    [<CustomOperation("TextInput")>] member inline this.TextInput ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextInput), "TextInput", fn)
    [<CustomOperation("TextInputMethodClientRequested")>] member inline this.TextInputMethodClientRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextInputMethodClientRequested), "TextInputMethodClientRequested", fn)
    [<CustomOperation("TextInputOptionsQuery")>] member inline this.TextInputOptionsQuery ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextInputOptionsQuery), "TextInputOptionsQuery", fn)
    [<CustomOperation("PointerEnter")>] member inline this.PointerEnter ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerEnter), "PointerEnter", fn)
    [<CustomOperation("PointerLeave")>] member inline this.PointerLeave ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerLeave), "PointerLeave", fn)
    [<CustomOperation("PointerMoved")>] member inline this.PointerMoved ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerMoved), "PointerMoved", fn)
    [<CustomOperation("PointerPressed")>] member inline this.PointerPressed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerPressed), "PointerPressed", fn)
    [<CustomOperation("PointerReleased")>] member inline this.PointerReleased ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerReleased), "PointerReleased", fn)
    [<CustomOperation("PointerCaptureLost")>] member inline this.PointerCaptureLost ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerCaptureLost), "PointerCaptureLost", fn)
    [<CustomOperation("PointerWheelChanged")>] member inline this.PointerWheelChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerWheelChanged), "PointerWheelChanged", fn)
    [<CustomOperation("Tapped")>] member inline this.Tapped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Tapped), "Tapped", fn)
    [<CustomOperation("DoubleTapped")>] member inline this.DoubleTapped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DoubleTapped), "DoubleTapped", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ControlBuilder<'Element when 'Element :> Avalonia.Controls.Control>() =
    inherit Input.InputElementBuilder<'Element>()

    [<CustomOperation("FocusAdorner")>] member inline this.FocusAdorner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FocusAdorner), (fun ctx x -> ctx.Element.FocusAdorner <- x), x)
    [<CustomOperation("FocusAdorner")>] member inline this.FocusAdorner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FocusAdorner), (fun ctx x -> ctx.Element.FocusAdorner <- x), x)
    [<CustomOperation("DataTemplatesEx")>] member inline this.DataTemplatesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("DataTemplatesEx'")>] member inline this.DataTemplatesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("DataTemplates")>] member inline this.DataTemplates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("DataTemplates'")>] member inline this.DataTemplates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.DataTemplates), x)

    [<CustomOperation("ContextMenu")>]
    member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ContextMenu <- x), creator)

    [<CustomOperation("ContextMenu")>]
    member inline this.ContextMenu ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ContextMenu <- x), creator)
                        
    [<CustomOperation("ContextFlyout")>] member inline this.ContextFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextFlyout), (fun ctx x -> ctx.Element.ContextFlyout <- x), x)
    [<CustomOperation("ContextFlyout")>] member inline this.ContextFlyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContextFlyout), (fun ctx x -> ctx.Element.ContextFlyout <- x), x)
    [<CustomOperation("Tag")>] member inline this.Tag ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Tag), (fun ctx x -> ctx.Element.Tag <- x), x)
    [<CustomOperation("Tag")>] member inline this.Tag ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Tag), (fun ctx x -> ctx.Element.Tag <- x), x)

    [<CustomOperation("ContextRequested")>] member inline this.ContextRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextRequested), "ContextRequested", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TemplatedControlBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.TemplatedControl>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)
    [<CustomOperation("Template")>] member inline this.Template ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Template), (fun ctx x -> ctx.Element.Template <- x), x)

    [<CustomOperation("TemplateApplied")>] member inline this.TemplateApplied ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TemplateApplied), "TemplateApplied", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ContentControlBuilder<'Element when 'Element :> Avalonia.Controls.ContentControl>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()



    member inline _.Yield(creator: ElementCreator<Avalonia>) = creator
    
    member inline this.Combine(creator: ElementCreator<Avalonia>, [<InlineIfLambda>] builder: BuildElement<'Element>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), fn ())
    
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia>) =
        this.MakeSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.Content <- x), fn ())

    
    member inline _.Yield(creator: ElementCreator<Avalonia> aval) = creator
    
    member inline this.Combine(creator: ElementCreator<Avalonia> aval, [<InlineIfLambda>] builder: BuildElement<'Element>) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia> aval) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), fn ())
                        
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia> aval) =
        this.MakeAdaptiveSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.Content <- x), fn ())

                        

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        
    [<CustomOperation("Content'")>] member inline this.Content' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content'")>] member inline this.Content' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)

                

type ButtonBuilder<'Element when 'Element :> Avalonia.Controls.Button>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("ClickMode")>] member inline this.ClickMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ClickMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClickMode), (fun ctx x -> ctx.Element.ClickMode <- x), x)
    [<CustomOperation("ClickMode")>] member inline this.ClickMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClickMode), (fun ctx x -> ctx.Element.ClickMode <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.KeyGesture) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("IsDefault")>] member inline this.IsDefault ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefault), (fun ctx x -> ctx.Element.IsDefault <- x), x)
    [<CustomOperation("IsDefault")>] member inline this.IsDefault ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDefault), (fun ctx x -> ctx.Element.IsDefault <- x), x)
    [<CustomOperation("IsCancel")>] member inline this.IsCancel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsCancel), (fun ctx x -> ctx.Element.IsCancel <- x), x)
    [<CustomOperation("IsCancel")>] member inline this.IsCancel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsCancel), (fun ctx x -> ctx.Element.IsCancel <- x), x)
    [<CustomOperation("Flyout")>] member inline this.Flyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.FlyoutBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Flyout), (fun ctx x -> ctx.Element.Flyout <- x), x)
    [<CustomOperation("Flyout")>] member inline this.Flyout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Flyout), (fun ctx x -> ctx.Element.Flyout <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ToggleButtonBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.ToggleButton>() =
    inherit Controls.ButtonBuilder<'Element>()

    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.Boolean>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsThreeState")>] member inline this.IsThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsThreeState), (fun ctx x -> ctx.Element.IsThreeState <- x), x)
    [<CustomOperation("IsThreeState")>] member inline this.IsThreeState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsThreeState), (fun ctx x -> ctx.Element.IsThreeState <- x), x)

    [<CustomOperation("Checked")>] member inline this.Checked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Checked), "Checked", fn)
    [<CustomOperation("Unchecked")>] member inline this.Unchecked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unchecked), "Unchecked", fn)
    [<CustomOperation("Indeterminate")>] member inline this.Indeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Indeterminate), "Indeterminate", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type CheckBoxBuilder<'Element when 'Element :> Avalonia.Controls.CheckBox>() =
    inherit Controls.Primitives.ToggleButtonBuilder<'Element>()


                

type RadioButtonBuilder<'Element when 'Element :> Avalonia.Controls.RadioButton>() =
    inherit Controls.Primitives.ToggleButtonBuilder<'Element>()

    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)

                

type ToggleSwitchBuilder<'Element when 'Element :> Avalonia.Controls.ToggleSwitch>() =
    inherit Controls.Primitives.ToggleButtonBuilder<'Element>()

    [<CustomOperation("OnContent")>] member inline this.OnContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnContent), (fun ctx x -> ctx.Element.OnContent <- x), x)
    [<CustomOperation("OnContent")>] member inline this.OnContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OnContent), (fun ctx x -> ctx.Element.OnContent <- x), x)
    [<CustomOperation("OffContent")>] member inline this.OffContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OffContent), (fun ctx x -> ctx.Element.OffContent <- x), x)
    [<CustomOperation("OffContent")>] member inline this.OffContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OffContent), (fun ctx x -> ctx.Element.OffContent <- x), x)
    [<CustomOperation("OffContentTemplate")>] member inline this.OffContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OffContentTemplate), (fun ctx x -> ctx.Element.OffContentTemplate <- x), x)
    [<CustomOperation("OffContentTemplate")>] member inline this.OffContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OffContentTemplate), (fun ctx x -> ctx.Element.OffContentTemplate <- x), x)
    [<CustomOperation("OnContentTemplate")>] member inline this.OnContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnContentTemplate), (fun ctx x -> ctx.Element.OnContentTemplate <- x), x)
    [<CustomOperation("OnContentTemplate")>] member inline this.OnContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OnContentTemplate), (fun ctx x -> ctx.Element.OnContentTemplate <- x), x)

                

type RepeatButtonBuilder<'Element when 'Element :> Avalonia.Controls.RepeatButton>() =
    inherit Controls.ButtonBuilder<'Element>()

    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)
    [<CustomOperation("Interval")>] member inline this.Interval ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Interval), (fun ctx x -> ctx.Element.Interval <- x), x)
    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.``Delay``), (fun ctx x -> ctx.Element.``Delay`` <- x), x)
    [<CustomOperation("Delay'")>] member inline this.Delay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.``Delay``), (fun ctx x -> ctx.Element.``Delay`` <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type CalendarButtonBuilder() =
    inherit Controls.ButtonBuilder<Avalonia.Controls.Primitives.CalendarButton>()


    [<CustomOperation("CalendarLeftMouseButtonDown")>] member inline this.CalendarLeftMouseButtonDown ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarButton>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarLeftMouseButtonDown), "CalendarLeftMouseButtonDown", fn)
    [<CustomOperation("CalendarLeftMouseButtonUp")>] member inline this.CalendarLeftMouseButtonUp ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarButton>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarLeftMouseButtonUp), "CalendarLeftMouseButtonUp", fn)
                

type CalendarDayButtonBuilder() =
    inherit Controls.ButtonBuilder<Avalonia.Controls.Primitives.CalendarDayButton>()


    [<CustomOperation("CalendarDayButtonMouseDown")>] member inline this.CalendarDayButtonMouseDown ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarDayButton>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarDayButtonMouseDown), "CalendarDayButtonMouseDown", fn)
    [<CustomOperation("CalendarDayButtonMouseUp")>] member inline this.CalendarDayButtonMouseUp ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarDayButton>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarDayButtonMouseUp), "CalendarDayButtonMouseUp", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ListBoxItemBuilder<'Element when 'Element :> Avalonia.Controls.ListBoxItem>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                

type ComboBoxItemBuilder<'Element when 'Element :> Avalonia.Controls.ComboBoxItem>() =
    inherit Controls.ListBoxItemBuilder<'Element>()


                

type DropDownItemBuilder<'Element when 'Element :> Avalonia.Controls.DropDownItem>() =
    inherit Controls.ComboBoxItemBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TabStripItemBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.TabStripItem>() =
    inherit Controls.ListBoxItemBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TopLevelBuilder<'Element when 'Element :> Avalonia.Controls.TopLevel>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("ClientSizeEx")>] member inline this.ClientSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("ClientSizeEx'")>] member inline this.ClientSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("ClientSize")>] member inline this.ClientSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("ClientSize'")>] member inline this.ClientSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ClientSize), x)
    [<CustomOperation("FrameSizeEx")>] member inline this.FrameSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FrameSize), x)
    [<CustomOperation("FrameSizeEx'")>] member inline this.FrameSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FrameSize), x)
    [<CustomOperation("FrameSize")>] member inline this.FrameSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FrameSize), x)
    [<CustomOperation("FrameSize'")>] member inline this.FrameSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FrameSize), x)
    [<CustomOperation("TransparencyLevelHint")>] member inline this.TransparencyLevelHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.WindowTransparencyLevel) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TransparencyLevelHint), (fun ctx x -> ctx.Element.TransparencyLevelHint <- x), x)
    [<CustomOperation("TransparencyLevelHint")>] member inline this.TransparencyLevelHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TransparencyLevelHint), (fun ctx x -> ctx.Element.TransparencyLevelHint <- x), x)
    [<CustomOperation("TransparencyBackgroundFallback")>] member inline this.TransparencyBackgroundFallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TransparencyBackgroundFallback), (fun ctx x -> ctx.Element.TransparencyBackgroundFallback <- x), x)
    [<CustomOperation("TransparencyBackgroundFallback")>] member inline this.TransparencyBackgroundFallback ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TransparencyBackgroundFallback), (fun ctx x -> ctx.Element.TransparencyBackgroundFallback <- x), x)
    [<CustomOperation("LayoutManagerEx")>] member inline this.LayoutManagerEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LayoutManager), x)
    [<CustomOperation("LayoutManagerEx'")>] member inline this.LayoutManagerEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LayoutManager), x)
    [<CustomOperation("LayoutManager")>] member inline this.LayoutManager ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.LayoutManager), x)
    [<CustomOperation("LayoutManager'")>] member inline this.LayoutManager' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.LayoutManager), x)
    [<CustomOperation("PlatformImplEx")>] member inline this.PlatformImplEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImplEx'")>] member inline this.PlatformImplEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl")>] member inline this.PlatformImpl ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl'")>] member inline this.PlatformImpl' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("RendererEx")>] member inline this.RendererEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Renderer), x)
    [<CustomOperation("RendererEx'")>] member inline this.RendererEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Renderer), x)
    [<CustomOperation("Renderer")>] member inline this.Renderer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Renderer), x)
    [<CustomOperation("Renderer'")>] member inline this.Renderer' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Renderer), x)

    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
                

type WindowBaseBuilder<'Element when 'Element :> Avalonia.Controls.WindowBase>() =
    inherit Controls.TopLevelBuilder<'Element>()

    [<CustomOperation("PlatformImplEx")>] member inline this.PlatformImplEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImplEx'")>] member inline this.PlatformImplEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl")>] member inline this.PlatformImpl ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl'")>] member inline this.PlatformImpl' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("ScreensEx")>] member inline this.ScreensEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Screens), x)
    [<CustomOperation("ScreensEx'")>] member inline this.ScreensEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Screens), x)
    [<CustomOperation("Screens")>] member inline this.Screens ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Screens), x)
    [<CustomOperation("Screens'")>] member inline this.Screens' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Screens), x)
    [<CustomOperation("Topmost")>] member inline this.Topmost ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Topmost), (fun ctx x -> ctx.Element.Topmost <- x), x)
    [<CustomOperation("Topmost")>] member inline this.Topmost ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Topmost), (fun ctx x -> ctx.Element.Topmost <- x), x)

    [<CustomOperation("Activated")>] member inline this.Activated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Activated), "Activated", fn)
    [<CustomOperation("Deactivated")>] member inline this.Deactivated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Deactivated), "Deactivated", fn)
    [<CustomOperation("PositionChanged")>] member inline this.PositionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PositionChanged), "PositionChanged", fn)
                

type WindowBuilder<'Element when 'Element :> Avalonia.Controls.Window>() =
    inherit Controls.WindowBaseBuilder<'Element>()

    [<CustomOperation("PlatformImplEx")>] member inline this.PlatformImplEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImplEx'")>] member inline this.PlatformImplEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl")>] member inline this.PlatformImpl ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl'")>] member inline this.PlatformImpl' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("OwnedWindowsEx")>] member inline this.OwnedWindowsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.OwnedWindows), x)
    [<CustomOperation("OwnedWindowsEx'")>] member inline this.OwnedWindowsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.OwnedWindows), x)
    [<CustomOperation("OwnedWindows")>] member inline this.OwnedWindows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.OwnedWindows), x)
    [<CustomOperation("OwnedWindows'")>] member inline this.OwnedWindows' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.OwnedWindows), x)
    [<CustomOperation("SizeToContent")>] member inline this.SizeToContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SizeToContent) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeToContent), (fun ctx x -> ctx.Element.SizeToContent <- x), x)
    [<CustomOperation("SizeToContent")>] member inline this.SizeToContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SizeToContent), (fun ctx x -> ctx.Element.SizeToContent <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("HasSystemDecorations")>] member inline this.HasSystemDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasSystemDecorations), (fun ctx x -> ctx.Element.HasSystemDecorations <- x), x)
    [<CustomOperation("HasSystemDecorations")>] member inline this.HasSystemDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasSystemDecorations), (fun ctx x -> ctx.Element.HasSystemDecorations <- x), x)
    [<CustomOperation("ExtendClientAreaToDecorationsHint")>] member inline this.ExtendClientAreaToDecorationsHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExtendClientAreaToDecorationsHint), (fun ctx x -> ctx.Element.ExtendClientAreaToDecorationsHint <- x), x)
    [<CustomOperation("ExtendClientAreaToDecorationsHint")>] member inline this.ExtendClientAreaToDecorationsHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExtendClientAreaToDecorationsHint), (fun ctx x -> ctx.Element.ExtendClientAreaToDecorationsHint <- x), x)
    [<CustomOperation("ExtendClientAreaChromeHints")>] member inline this.ExtendClientAreaChromeHints ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Platform.ExtendClientAreaChromeHints) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExtendClientAreaChromeHints), (fun ctx x -> ctx.Element.ExtendClientAreaChromeHints <- x), x)
    [<CustomOperation("ExtendClientAreaChromeHints")>] member inline this.ExtendClientAreaChromeHints ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExtendClientAreaChromeHints), (fun ctx x -> ctx.Element.ExtendClientAreaChromeHints <- x), x)
    [<CustomOperation("ExtendClientAreaTitleBarHeightHint")>] member inline this.ExtendClientAreaTitleBarHeightHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExtendClientAreaTitleBarHeightHint), (fun ctx x -> ctx.Element.ExtendClientAreaTitleBarHeightHint <- x), x)
    [<CustomOperation("ExtendClientAreaTitleBarHeightHint")>] member inline this.ExtendClientAreaTitleBarHeightHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExtendClientAreaTitleBarHeightHint), (fun ctx x -> ctx.Element.ExtendClientAreaTitleBarHeightHint <- x), x)
    [<CustomOperation("WindowDecorationMarginEx")>] member inline this.WindowDecorationMarginEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.WindowDecorationMargin), x)
    [<CustomOperation("WindowDecorationMarginEx'")>] member inline this.WindowDecorationMarginEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.WindowDecorationMargin), x)
    [<CustomOperation("WindowDecorationMargin")>] member inline this.WindowDecorationMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.WindowDecorationMargin), x)
    [<CustomOperation("WindowDecorationMargin'")>] member inline this.WindowDecorationMargin' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.WindowDecorationMargin), x)
    [<CustomOperation("OffScreenMarginEx")>] member inline this.OffScreenMarginEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.OffScreenMargin), x)
    [<CustomOperation("OffScreenMarginEx'")>] member inline this.OffScreenMarginEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.OffScreenMargin), x)
    [<CustomOperation("OffScreenMargin")>] member inline this.OffScreenMargin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.OffScreenMargin), x)
    [<CustomOperation("OffScreenMargin'")>] member inline this.OffScreenMargin' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.OffScreenMargin), x)
    [<CustomOperation("SystemDecorations")>] member inline this.SystemDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SystemDecorations) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SystemDecorations), (fun ctx x -> ctx.Element.SystemDecorations <- x), x)
    [<CustomOperation("SystemDecorations")>] member inline this.SystemDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SystemDecorations), (fun ctx x -> ctx.Element.SystemDecorations <- x), x)
    [<CustomOperation("ShowActivated")>] member inline this.ShowActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowActivated), (fun ctx x -> ctx.Element.ShowActivated <- x), x)
    [<CustomOperation("ShowActivated")>] member inline this.ShowActivated ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowActivated), (fun ctx x -> ctx.Element.ShowActivated <- x), x)
    [<CustomOperation("ShowInTaskbar")>] member inline this.ShowInTaskbar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowInTaskbar), (fun ctx x -> ctx.Element.ShowInTaskbar <- x), x)
    [<CustomOperation("ShowInTaskbar")>] member inline this.ShowInTaskbar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowInTaskbar), (fun ctx x -> ctx.Element.ShowInTaskbar <- x), x)
    [<CustomOperation("WindowState")>] member inline this.WindowState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.WindowState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowState), (fun ctx x -> ctx.Element.WindowState <- x), x)
    [<CustomOperation("WindowState")>] member inline this.WindowState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowState), (fun ctx x -> ctx.Element.WindowState <- x), x)
    [<CustomOperation("CanResize")>] member inline this.CanResize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanResize), (fun ctx x -> ctx.Element.CanResize <- x), x)
    [<CustomOperation("CanResize")>] member inline this.CanResize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanResize), (fun ctx x -> ctx.Element.CanResize <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.WindowIcon) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("WindowStartupLocation")>] member inline this.WindowStartupLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.WindowStartupLocation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowStartupLocation), (fun ctx x -> ctx.Element.WindowStartupLocation <- x), x)
    [<CustomOperation("WindowStartupLocation")>] member inline this.WindowStartupLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowStartupLocation), (fun ctx x -> ctx.Element.WindowStartupLocation <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.PixelPoint) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)

    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type PopupRootBuilder() =
    inherit Controls.WindowBaseBuilder<Avalonia.Controls.Primitives.PopupRoot>()

    [<CustomOperation("PlatformImplEx")>] member inline this.PlatformImplEx ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.PopupRoot>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImplEx'")>] member inline this.PlatformImplEx' ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.PopupRoot>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl")>] member inline this.PlatformImpl ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.PopupRoot>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PlatformImpl), x)
    [<CustomOperation("PlatformImpl'")>] member inline this.PlatformImpl' ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.PopupRoot>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PlatformImpl), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Embedding

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type EmbeddableControlRootBuilder<'Element when 'Element :> Avalonia.Controls.Embedding.EmbeddableControlRoot>() =
    inherit Controls.TopLevelBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type SpinnerBuilder<'Element when 'Element :> Avalonia.Controls.Spinner>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("ValidSpinDirection")>] member inline this.ValidSpinDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ValidSpinDirections) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ValidSpinDirection), (fun ctx x -> ctx.Element.ValidSpinDirection <- x), x)
    [<CustomOperation("ValidSpinDirection")>] member inline this.ValidSpinDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ValidSpinDirection), (fun ctx x -> ctx.Element.ValidSpinDirection <- x), x)

    [<CustomOperation("Spin")>] member inline this.Spin ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Spin), "Spin", fn)
                

type ButtonSpinnerBuilder<'Element when 'Element :> Avalonia.Controls.ButtonSpinner>() =
    inherit Controls.SpinnerBuilder<'Element>()

    [<CustomOperation("AllowSpin")>] member inline this.AllowSpin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowSpin), (fun ctx x -> ctx.Element.AllowSpin <- x), x)
    [<CustomOperation("AllowSpin")>] member inline this.AllowSpin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowSpin), (fun ctx x -> ctx.Element.AllowSpin <- x), x)
    [<CustomOperation("ShowButtonSpinner")>] member inline this.ShowButtonSpinner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowButtonSpinner), (fun ctx x -> ctx.Element.ShowButtonSpinner <- x), x)
    [<CustomOperation("ShowButtonSpinner")>] member inline this.ShowButtonSpinner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowButtonSpinner), (fun ctx x -> ctx.Element.ShowButtonSpinner <- x), x)
    [<CustomOperation("ButtonSpinnerLocation")>] member inline this.ButtonSpinnerLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Location) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ButtonSpinnerLocation), (fun ctx x -> ctx.Element.ButtonSpinnerLocation <- x), x)
    [<CustomOperation("ButtonSpinnerLocation")>] member inline this.ButtonSpinnerLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ButtonSpinnerLocation), (fun ctx x -> ctx.Element.ButtonSpinnerLocation <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type HeaderedContentControlBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.HeaderedContentControl>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ExpanderBuilder<'Element when 'Element :> Avalonia.Controls.Expander>() =
    inherit Controls.Primitives.HeaderedContentControlBuilder<'Element>()

    [<CustomOperation("ContentTransition")>] member inline this.ContentTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Animation.IPageTransition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTransition), (fun ctx x -> ctx.Element.ContentTransition <- x), x)
    [<CustomOperation("ContentTransition")>] member inline this.ContentTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTransition), (fun ctx x -> ctx.Element.ContentTransition <- x), x)
    [<CustomOperation("ExpandDirection")>] member inline this.ExpandDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ExpandDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandDirection), (fun ctx x -> ctx.Element.ExpandDirection <- x), x)
    [<CustomOperation("ExpandDirection")>] member inline this.ExpandDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ExpandDirection), (fun ctx x -> ctx.Element.ExpandDirection <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)

                

type TabItemBuilder<'Element when 'Element :> Avalonia.Controls.TabItem>() =
    inherit Controls.Primitives.HeaderedContentControlBuilder<'Element>()

    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)

                

type DataValidationErrorsBuilder<'Element when 'Element :> Avalonia.Controls.DataValidationErrors>() =
    inherit Controls.ContentControlBuilder<'Element>()


    [<CustomOperation("Owner")>]
    member inline this.Owner ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Owner <- x), creator)

    [<CustomOperation("Owner")>]
    member inline this.Owner ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Owner <- x), creator)
                        
    [<CustomOperation("ErrorTemplate")>] member inline this.ErrorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ErrorTemplate), (fun ctx x -> ctx.Element.ErrorTemplate <- x), x)
    [<CustomOperation("ErrorTemplate")>] member inline this.ErrorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ErrorTemplate), (fun ctx x -> ctx.Element.ErrorTemplate <- x), x)

                

type FlyoutPresenterBuilder<'Element when 'Element :> Avalonia.Controls.FlyoutPresenter>() =
    inherit Controls.ContentControlBuilder<'Element>()


                

type LabelBuilder<'Element when 'Element :> Avalonia.Controls.Label>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("Target")>] member inline this.Target ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.IInputElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Target), (fun ctx x -> ctx.Element.Target <- x), x)
    [<CustomOperation("Target")>] member inline this.Target ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Target), (fun ctx x -> ctx.Element.Target <- x), x)

                

type ScrollViewerBuilder<'Element when 'Element :> Avalonia.Controls.ScrollViewer>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("ExtentEx")>] member inline this.ExtentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Extent), x)
    [<CustomOperation("ExtentEx'")>] member inline this.ExtentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Extent")>] member inline this.Extent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Extent'")>] member inline this.Extent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Vector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("ViewportEx")>] member inline this.ViewportEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("ViewportEx'")>] member inline this.ViewportEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("Viewport")>] member inline this.Viewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("Viewport'")>] member inline this.Viewport' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("LargeChangeEx")>] member inline this.LargeChangeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LargeChange), x)
    [<CustomOperation("LargeChangeEx'")>] member inline this.LargeChangeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LargeChange), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.LargeChange), x)
    [<CustomOperation("LargeChange'")>] member inline this.LargeChange' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.LargeChange), x)
    [<CustomOperation("SmallChangeEx")>] member inline this.SmallChangeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SmallChange), x)
    [<CustomOperation("SmallChangeEx'")>] member inline this.SmallChangeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SmallChange), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SmallChange), x)
    [<CustomOperation("SmallChange'")>] member inline this.SmallChange' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SmallChange), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("AllowAutoHide")>] member inline this.AllowAutoHide ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowAutoHide), (fun ctx x -> ctx.Element.AllowAutoHide <- x), x)
    [<CustomOperation("AllowAutoHide")>] member inline this.AllowAutoHide ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowAutoHide), (fun ctx x -> ctx.Element.AllowAutoHide <- x), x)

    [<CustomOperation("ScrollChanged")>] member inline this.ScrollChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollChanged), "ScrollChanged", fn)
                

type SplitViewBuilder<'Element when 'Element :> Avalonia.Controls.SplitView>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("CompactPaneLength")>] member inline this.CompactPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CompactPaneLength), (fun ctx x -> ctx.Element.CompactPaneLength <- x), x)
    [<CustomOperation("CompactPaneLength")>] member inline this.CompactPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CompactPaneLength), (fun ctx x -> ctx.Element.CompactPaneLength <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SplitViewDisplayMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("IsPaneOpen")>] member inline this.IsPaneOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneOpen), (fun ctx x -> ctx.Element.IsPaneOpen <- x), x)
    [<CustomOperation("IsPaneOpen")>] member inline this.IsPaneOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPaneOpen), (fun ctx x -> ctx.Element.IsPaneOpen <- x), x)
    [<CustomOperation("OpenPaneLength")>] member inline this.OpenPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OpenPaneLength), (fun ctx x -> ctx.Element.OpenPaneLength <- x), x)
    [<CustomOperation("OpenPaneLength")>] member inline this.OpenPaneLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OpenPaneLength), (fun ctx x -> ctx.Element.OpenPaneLength <- x), x)
    [<CustomOperation("PaneBackground")>] member inline this.PaneBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneBackground), (fun ctx x -> ctx.Element.PaneBackground <- x), x)
    [<CustomOperation("PaneBackground")>] member inline this.PaneBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneBackground), (fun ctx x -> ctx.Element.PaneBackground <- x), x)
    [<CustomOperation("PanePlacement")>] member inline this.PanePlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SplitViewPanePlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanePlacement), (fun ctx x -> ctx.Element.PanePlacement <- x), x)
    [<CustomOperation("PanePlacement")>] member inline this.PanePlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanePlacement), (fun ctx x -> ctx.Element.PanePlacement <- x), x)
    [<CustomOperation("Pane")>] member inline this.Pane ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Pane), (fun ctx x -> ctx.Element.Pane <- x), x)
    [<CustomOperation("Pane")>] member inline this.Pane ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Pane), (fun ctx x -> ctx.Element.Pane <- x), x)
    [<CustomOperation("PaneTemplate")>] member inline this.PaneTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneTemplate), (fun ctx x -> ctx.Element.PaneTemplate <- x), x)
    [<CustomOperation("PaneTemplate")>] member inline this.PaneTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PaneTemplate), (fun ctx x -> ctx.Element.PaneTemplate <- x), x)
    [<CustomOperation("UseLightDismissOverlayMode")>] member inline this.UseLightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseLightDismissOverlayMode), (fun ctx x -> ctx.Element.UseLightDismissOverlayMode <- x), x)
    [<CustomOperation("UseLightDismissOverlayMode")>] member inline this.UseLightDismissOverlayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseLightDismissOverlayMode), (fun ctx x -> ctx.Element.UseLightDismissOverlayMode <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SplitViewTemplateSettings) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TemplateSettings), (fun ctx x -> ctx.Element.TemplateSettings <- x), x)
    [<CustomOperation("TemplateSettings")>] member inline this.TemplateSettings ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TemplateSettings), (fun ctx x -> ctx.Element.TemplateSettings <- x), x)

    [<CustomOperation("PaneClosed")>] member inline this.PaneClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneClosed), "PaneClosed", fn)
    [<CustomOperation("PaneClosing")>] member inline this.PaneClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneClosing), "PaneClosing", fn)
    [<CustomOperation("PaneOpened")>] member inline this.PaneOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneOpened), "PaneOpened", fn)
    [<CustomOperation("PaneOpening")>] member inline this.PaneOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PaneOpening), "PaneOpening", fn)
                

type ToolTipBuilder<'Element when 'Element :> Avalonia.Controls.ToolTip>() =
    inherit Controls.ContentControlBuilder<'Element>()


                

type TransitioningContentControlBuilder<'Element when 'Element :> Avalonia.Controls.TransitioningContentControl>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("PageTransition")>] member inline this.PageTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Animation.IPageTransition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PageTransition), (fun ctx x -> ctx.Element.PageTransition <- x), x)
    [<CustomOperation("PageTransition")>] member inline this.PageTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PageTransition), (fun ctx x -> ctx.Element.PageTransition <- x), x)
    [<CustomOperation("CurrentContentEx")>] member inline this.CurrentContentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentContent), x)
    [<CustomOperation("CurrentContentEx'")>] member inline this.CurrentContentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentContent), x)
    [<CustomOperation("CurrentContent")>] member inline this.CurrentContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.CurrentContent), x)
    [<CustomOperation("CurrentContent'")>] member inline this.CurrentContent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.CurrentContent), x)

                

type UserControlBuilder<'Element when 'Element :> Avalonia.Controls.UserControl>() =
    inherit Controls.ContentControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Notifications

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type NotificationCardBuilder<'Element when 'Element :> Avalonia.Controls.Notifications.NotificationCard>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("IsClosed")>] member inline this.IsClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClosed), (fun ctx x -> ctx.Element.IsClosed <- x), x)
    [<CustomOperation("IsClosed")>] member inline this.IsClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClosed), (fun ctx x -> ctx.Element.IsClosed <- x), x)

    [<CustomOperation("NotificationClosed")>] member inline this.NotificationClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NotificationClosed), "NotificationClosed", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type OverlayPopupHostBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.OverlayPopupHost>() =
    inherit Controls.ContentControlBuilder<'Element>()

    [<CustomOperation("HostedVisualTreeRootEx")>] member inline this.HostedVisualTreeRootEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.HostedVisualTreeRoot), x)
    [<CustomOperation("HostedVisualTreeRootEx'")>] member inline this.HostedVisualTreeRootEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.HostedVisualTreeRoot), x)
    [<CustomOperation("HostedVisualTreeRoot")>] member inline this.HostedVisualTreeRoot ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.HostedVisualTreeRoot), x)
    [<CustomOperation("HostedVisualTreeRoot'")>] member inline this.HostedVisualTreeRoot' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.HostedVisualTreeRoot), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ItemsControlBuilder<'Element when 'Element :> Avalonia.Controls.ItemsControl>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("ItemContainerGeneratorEx")>] member inline this.ItemContainerGeneratorEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGeneratorEx'")>] member inline this.ItemContainerGeneratorEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type SelectingItemsControlBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.SelectingItemsControl>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("AutoScrollToSelectedItem")>] member inline this.AutoScrollToSelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScrollToSelectedItem), (fun ctx x -> ctx.Element.AutoScrollToSelectedItem <- x), x)
    [<CustomOperation("AutoScrollToSelectedItem")>] member inline this.AutoScrollToSelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScrollToSelectedItem), (fun ctx x -> ctx.Element.AutoScrollToSelectedItem <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("IsTextSearchEnabled")>] member inline this.IsTextSearchEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchEnabled), (fun ctx x -> ctx.Element.IsTextSearchEnabled <- x), x)
    [<CustomOperation("IsTextSearchEnabled")>] member inline this.IsTextSearchEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextSearchEnabled), (fun ctx x -> ctx.Element.IsTextSearchEnabled <- x), x)

    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type MenuBaseBuilder<'Element when 'Element :> Avalonia.Controls.MenuBase>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()


    [<CustomOperation("MenuOpened")>] member inline this.MenuOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuOpened), "MenuOpened", fn)
    [<CustomOperation("MenuClosed")>] member inline this.MenuClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuClosed), "MenuClosed", fn)
                

type ContextMenuBuilder<'Element when 'Element :> Avalonia.Controls.ContextMenu>() =
    inherit Controls.MenuBaseBuilder<'Element>()

    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("PlacementAnchor")>] member inline this.PlacementAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementAnchor), (fun ctx x -> ctx.Element.PlacementAnchor <- x), x)
    [<CustomOperation("PlacementAnchor")>] member inline this.PlacementAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementAnchor), (fun ctx x -> ctx.Element.PlacementAnchor <- x), x)
    [<CustomOperation("PlacementConstraintAdjustment")>] member inline this.PlacementConstraintAdjustment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementConstraintAdjustment), (fun ctx x -> ctx.Element.PlacementConstraintAdjustment <- x), x)
    [<CustomOperation("PlacementConstraintAdjustment")>] member inline this.PlacementConstraintAdjustment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementConstraintAdjustment), (fun ctx x -> ctx.Element.PlacementConstraintAdjustment <- x), x)
    [<CustomOperation("PlacementGravity")>] member inline this.PlacementGravity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.PopupPositioning.PopupGravity) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementGravity), (fun ctx x -> ctx.Element.PlacementGravity <- x), x)
    [<CustomOperation("PlacementGravity")>] member inline this.PlacementGravity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementGravity), (fun ctx x -> ctx.Element.PlacementGravity <- x), x)
    [<CustomOperation("PlacementMode")>] member inline this.PlacementMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.PlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementMode), (fun ctx x -> ctx.Element.PlacementMode <- x), x)
    [<CustomOperation("PlacementMode")>] member inline this.PlacementMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementMode), (fun ctx x -> ctx.Element.PlacementMode <- x), x)
    [<CustomOperation("WindowManagerAddShadowHint")>] member inline this.WindowManagerAddShadowHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowManagerAddShadowHint), (fun ctx x -> ctx.Element.WindowManagerAddShadowHint <- x), x)
    [<CustomOperation("WindowManagerAddShadowHint")>] member inline this.WindowManagerAddShadowHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowManagerAddShadowHint), (fun ctx x -> ctx.Element.WindowManagerAddShadowHint <- x), x)
    [<CustomOperation("PlacementRect")>] member inline this.PlacementRect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<Avalonia.Rect>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRect), (fun ctx x -> ctx.Element.PlacementRect <- x), x)
    [<CustomOperation("PlacementRect")>] member inline this.PlacementRect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRect), (fun ctx x -> ctx.Element.PlacementRect <- x), x)

    [<CustomOperation("PlacementTarget")>]
    member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.PlacementTarget <- x), creator)

    [<CustomOperation("PlacementTarget")>]
    member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.PlacementTarget <- x), creator)
                        

    [<CustomOperation("ContextMenuOpening")>] member inline this.ContextMenuOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuOpening), "ContextMenuOpening", fn)
    [<CustomOperation("ContextMenuClosing")>] member inline this.ContextMenuClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ContextMenuClosing), "ContextMenuClosing", fn)
                

type MenuFlyoutPresenterBuilder<'Element when 'Element :> Avalonia.Controls.MenuFlyoutPresenter>() =
    inherit Controls.MenuBaseBuilder<'Element>()

    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)

                

type MenuBuilder<'Element when 'Element :> Avalonia.Controls.Menu>() =
    inherit Controls.MenuBaseBuilder<'Element>()


                

type ComboBoxBuilder<'Element when 'Element :> Avalonia.Controls.ComboBox>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()

    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderText")>] member inline this.PlaceholderText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderText), (fun ctx x -> ctx.Element.PlaceholderText <- x), x)
    [<CustomOperation("PlaceholderForeground")>] member inline this.PlaceholderForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderForeground), (fun ctx x -> ctx.Element.PlaceholderForeground <- x), x)
    [<CustomOperation("PlaceholderForeground")>] member inline this.PlaceholderForeground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderForeground), (fun ctx x -> ctx.Element.PlaceholderForeground <- x), x)
    [<CustomOperation("VirtualizationMode")>] member inline this.VirtualizationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ItemVirtualizationMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualizationMode), (fun ctx x -> ctx.Element.VirtualizationMode <- x), x)
    [<CustomOperation("VirtualizationMode")>] member inline this.VirtualizationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualizationMode), (fun ctx x -> ctx.Element.VirtualizationMode <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)

                

type DropDownBuilder<'Element when 'Element :> Avalonia.Controls.DropDown>() =
    inherit Controls.ComboBoxBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type HeaderedSelectingItemsControlBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.HeaderedSelectingItemsControl>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type MenuItemBuilder<'Element when 'Element :> Avalonia.Controls.MenuItem>() =
    inherit Controls.Primitives.HeaderedSelectingItemsControlBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.KeyGesture) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("HotKey")>] member inline this.HotKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HotKey), (fun ctx x -> ctx.Element.HotKey <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("InputGesture")>] member inline this.InputGesture ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.KeyGesture) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputGesture), (fun ctx x -> ctx.Element.InputGesture <- x), x)
    [<CustomOperation("InputGesture")>] member inline this.InputGesture ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputGesture), (fun ctx x -> ctx.Element.InputGesture <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSubMenuOpen")>] member inline this.IsSubMenuOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSubMenuOpen), (fun ctx x -> ctx.Element.IsSubMenuOpen <- x), x)
    [<CustomOperation("IsSubMenuOpen")>] member inline this.IsSubMenuOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSubMenuOpen), (fun ctx x -> ctx.Element.IsSubMenuOpen <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
    [<CustomOperation("PointerEnterItem")>] member inline this.PointerEnterItem ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerEnterItem), "PointerEnterItem", fn)
    [<CustomOperation("PointerLeaveItem")>] member inline this.PointerLeaveItem ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PointerLeaveItem), "PointerLeaveItem", fn)
    [<CustomOperation("SubmenuOpened")>] member inline this.SubmenuOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SubmenuOpened), "SubmenuOpened", fn)
                

type CarouselBuilder<'Element when 'Element :> Avalonia.Controls.Carousel>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()

    [<CustomOperation("IsVirtualized")>] member inline this.IsVirtualized ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVirtualized), (fun ctx x -> ctx.Element.IsVirtualized <- x), x)
    [<CustomOperation("IsVirtualized")>] member inline this.IsVirtualized ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVirtualized), (fun ctx x -> ctx.Element.IsVirtualized <- x), x)
    [<CustomOperation("PageTransition")>] member inline this.PageTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Animation.IPageTransition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PageTransition), (fun ctx x -> ctx.Element.PageTransition <- x), x)
    [<CustomOperation("PageTransition")>] member inline this.PageTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PageTransition), (fun ctx x -> ctx.Element.PageTransition <- x), x)

                

type ListBoxBuilder<'Element when 'Element :> Avalonia.Controls.ListBox>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()

    [<CustomOperation("ScrollEx")>] member inline this.ScrollEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Scroll), x)
    [<CustomOperation("ScrollEx'")>] member inline this.ScrollEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Scroll), x)
    [<CustomOperation("Scroll")>] member inline this.Scroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Scroll), x)
    [<CustomOperation("Scroll'")>] member inline this.Scroll' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Scroll), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IList) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItems), (fun ctx x -> ctx.Element.SelectedItems <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItems), (fun ctx x -> ctx.Element.SelectedItems <- x), x)
    [<CustomOperation("Selection")>] member inline this.Selection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Selection.ISelectionModel) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Selection), (fun ctx x -> ctx.Element.Selection <- x), x)
    [<CustomOperation("Selection")>] member inline this.Selection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Selection), (fun ctx x -> ctx.Element.Selection <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("VirtualizationMode")>] member inline this.VirtualizationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ItemVirtualizationMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualizationMode), (fun ctx x -> ctx.Element.VirtualizationMode <- x), x)
    [<CustomOperation("VirtualizationMode")>] member inline this.VirtualizationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualizationMode), (fun ctx x -> ctx.Element.VirtualizationMode <- x), x)

                

type TabControlBuilder<'Element when 'Element :> Avalonia.Controls.TabControl>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()

    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("TabStripPlacement")>] member inline this.TabStripPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Dock) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripPlacement), (fun ctx x -> ctx.Element.TabStripPlacement <- x), x)
    [<CustomOperation("TabStripPlacement")>] member inline this.TabStripPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TabStripPlacement), (fun ctx x -> ctx.Element.TabStripPlacement <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("SelectedContentEx")>] member inline this.SelectedContentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedContent), x)
    [<CustomOperation("SelectedContentEx'")>] member inline this.SelectedContentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedContent), x)
    [<CustomOperation("SelectedContent")>] member inline this.SelectedContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedContent), x)
    [<CustomOperation("SelectedContent'")>] member inline this.SelectedContent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedContent), x)
    [<CustomOperation("SelectedContentTemplateEx")>] member inline this.SelectedContentTemplateEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedContentTemplate), x)
    [<CustomOperation("SelectedContentTemplateEx'")>] member inline this.SelectedContentTemplateEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedContentTemplate), x)
    [<CustomOperation("SelectedContentTemplate")>] member inline this.SelectedContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedContentTemplate), x)
    [<CustomOperation("SelectedContentTemplate'")>] member inline this.SelectedContentTemplate' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedContentTemplate), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TabStripBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.TabStrip>() =
    inherit Controls.Primitives.SelectingItemsControlBuilder<'Element>()


                

type HeaderedItemsControlBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.HeaderedItemsControl>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TreeViewItemBuilder<'Element when 'Element :> Avalonia.Controls.TreeViewItem>() =
    inherit Controls.Primitives.HeaderedItemsControlBuilder<'Element>()

    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsExpanded")>] member inline this.IsExpanded ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsExpanded), (fun ctx x -> ctx.Element.IsExpanded <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("IsSelected")>] member inline this.IsSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSelected), (fun ctx x -> ctx.Element.IsSelected <- x), x)
    [<CustomOperation("ItemContainerGeneratorEx")>] member inline this.ItemContainerGeneratorEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGeneratorEx'")>] member inline this.ItemContainerGeneratorEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)

                

type TreeViewBuilder<'Element when 'Element :> Avalonia.Controls.TreeView>() =
    inherit Controls.ItemsControlBuilder<'Element>()

    [<CustomOperation("ItemContainerGeneratorEx")>] member inline this.ItemContainerGeneratorEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGeneratorEx'")>] member inline this.ItemContainerGeneratorEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("AutoScrollToSelectedItem")>] member inline this.AutoScrollToSelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScrollToSelectedItem), (fun ctx x -> ctx.Element.AutoScrollToSelectedItem <- x), x)
    [<CustomOperation("AutoScrollToSelectedItem")>] member inline this.AutoScrollToSelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoScrollToSelectedItem), (fun ctx x -> ctx.Element.AutoScrollToSelectedItem <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IList) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItems), (fun ctx x -> ctx.Element.SelectedItems <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItems), (fun ctx x -> ctx.Element.SelectedItems <- x), x)

    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type PickerPresenterBaseBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.PickerPresenterBase>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


    [<CustomOperation("Confirmed")>] member inline this.Confirmed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Confirmed), "Confirmed", fn)
    [<CustomOperation("Dismissed")>] member inline this.Dismissed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Dismissed), "Dismissed", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type DatePickerPresenterBuilder<'Element when 'Element :> Avalonia.Controls.DatePickerPresenter>() =
    inherit Controls.Primitives.PickerPresenterBaseBuilder<'Element>()

    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("DayFormat")>] member inline this.DayFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayFormat), (fun ctx x -> ctx.Element.DayFormat <- x), x)
    [<CustomOperation("DayFormat")>] member inline this.DayFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayFormat), (fun ctx x -> ctx.Element.DayFormat <- x), x)
    [<CustomOperation("DayVisible")>] member inline this.DayVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayVisible), (fun ctx x -> ctx.Element.DayVisible <- x), x)
    [<CustomOperation("DayVisible")>] member inline this.DayVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayVisible), (fun ctx x -> ctx.Element.DayVisible <- x), x)
    [<CustomOperation("MaxYear")>] member inline this.MaxYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxYear), (fun ctx x -> ctx.Element.MaxYear <- x), x)
    [<CustomOperation("MaxYear")>] member inline this.MaxYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxYear), (fun ctx x -> ctx.Element.MaxYear <- x), x)
    [<CustomOperation("MinYear")>] member inline this.MinYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinYear), (fun ctx x -> ctx.Element.MinYear <- x), x)
    [<CustomOperation("MinYear")>] member inline this.MinYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinYear), (fun ctx x -> ctx.Element.MinYear <- x), x)
    [<CustomOperation("MonthFormat")>] member inline this.MonthFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthFormat), (fun ctx x -> ctx.Element.MonthFormat <- x), x)
    [<CustomOperation("MonthFormat")>] member inline this.MonthFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthFormat), (fun ctx x -> ctx.Element.MonthFormat <- x), x)
    [<CustomOperation("MonthVisible")>] member inline this.MonthVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthVisible), (fun ctx x -> ctx.Element.MonthVisible <- x), x)
    [<CustomOperation("MonthVisible")>] member inline this.MonthVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthVisible), (fun ctx x -> ctx.Element.MonthVisible <- x), x)
    [<CustomOperation("YearFormat")>] member inline this.YearFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.YearFormat), (fun ctx x -> ctx.Element.YearFormat <- x), x)
    [<CustomOperation("YearFormat")>] member inline this.YearFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.YearFormat), (fun ctx x -> ctx.Element.YearFormat <- x), x)
    [<CustomOperation("YearVisible")>] member inline this.YearVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.YearVisible), (fun ctx x -> ctx.Element.YearVisible <- x), x)
    [<CustomOperation("YearVisible")>] member inline this.YearVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.YearVisible), (fun ctx x -> ctx.Element.YearVisible <- x), x)

                

type TimePickerPresenterBuilder<'Element when 'Element :> Avalonia.Controls.TimePickerPresenter>() =
    inherit Controls.Primitives.PickerPresenterBaseBuilder<'Element>()

    [<CustomOperation("MinuteIncrement")>] member inline this.MinuteIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinuteIncrement), (fun ctx x -> ctx.Element.MinuteIncrement <- x), x)
    [<CustomOperation("MinuteIncrement")>] member inline this.MinuteIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinuteIncrement), (fun ctx x -> ctx.Element.MinuteIncrement <- x), x)
    [<CustomOperation("ClockIdentifier")>] member inline this.ClockIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClockIdentifier), (fun ctx x -> ctx.Element.ClockIdentifier <- x), x)
    [<CustomOperation("ClockIdentifier")>] member inline this.ClockIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClockIdentifier), (fun ctx x -> ctx.Element.ClockIdentifier <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ThumbBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.Thumb>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


    [<CustomOperation("DragStarted")>] member inline this.DragStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStarted), "DragStarted", fn)
    [<CustomOperation("DragDelta")>] member inline this.DragDelta ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragDelta), "DragDelta", fn)
    [<CustomOperation("DragCompleted")>] member inline this.DragCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragCompleted), "DragCompleted", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type GridSplitterBuilder<'Element when 'Element :> Avalonia.Controls.GridSplitter>() =
    inherit Controls.Primitives.ThumbBuilder<'Element>()

    [<CustomOperation("ResizeDirection")>] member inline this.ResizeDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.GridResizeDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeDirection), (fun ctx x -> ctx.Element.ResizeDirection <- x), x)
    [<CustomOperation("ResizeDirection")>] member inline this.ResizeDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeDirection), (fun ctx x -> ctx.Element.ResizeDirection <- x), x)
    [<CustomOperation("ResizeBehavior")>] member inline this.ResizeBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.GridResizeBehavior) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeBehavior), (fun ctx x -> ctx.Element.ResizeBehavior <- x), x)
    [<CustomOperation("ResizeBehavior")>] member inline this.ResizeBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResizeBehavior), (fun ctx x -> ctx.Element.ResizeBehavior <- x), x)
    [<CustomOperation("ShowsPreview")>] member inline this.ShowsPreview ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsPreview), (fun ctx x -> ctx.Element.ShowsPreview <- x), x)
    [<CustomOperation("ShowsPreview")>] member inline this.ShowsPreview ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowsPreview), (fun ctx x -> ctx.Element.ShowsPreview <- x), x)
    [<CustomOperation("KeyboardIncrement")>] member inline this.KeyboardIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardIncrement), (fun ctx x -> ctx.Element.KeyboardIncrement <- x), x)
    [<CustomOperation("KeyboardIncrement")>] member inline this.KeyboardIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.KeyboardIncrement), (fun ctx x -> ctx.Element.KeyboardIncrement <- x), x)
    [<CustomOperation("DragIncrement")>] member inline this.DragIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragIncrement), (fun ctx x -> ctx.Element.DragIncrement <- x), x)
    [<CustomOperation("DragIncrement")>] member inline this.DragIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragIncrement), (fun ctx x -> ctx.Element.DragIncrement <- x), x)
    [<CustomOperation("PreviewContent")>] member inline this.PreviewContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PreviewContent), (fun ctx x -> ctx.Element.PreviewContent <- x), x)
    [<CustomOperation("PreviewContent")>] member inline this.PreviewContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PreviewContent), (fun ctx x -> ctx.Element.PreviewContent <- x), x)

                

type TextBoxBuilder<'Element when 'Element :> Avalonia.Controls.TextBox>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("AcceptsReturn")>] member inline this.AcceptsReturn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsReturn), (fun ctx x -> ctx.Element.AcceptsReturn <- x), x)
    [<CustomOperation("AcceptsTab")>] member inline this.AcceptsTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsTab), (fun ctx x -> ctx.Element.AcceptsTab <- x), x)
    [<CustomOperation("AcceptsTab")>] member inline this.AcceptsTab ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AcceptsTab), (fun ctx x -> ctx.Element.AcceptsTab <- x), x)
    [<CustomOperation("CaretIndex")>] member inline this.CaretIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretIndex), (fun ctx x -> ctx.Element.CaretIndex <- x), x)
    [<CustomOperation("CaretIndex")>] member inline this.CaretIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretIndex), (fun ctx x -> ctx.Element.CaretIndex <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Char) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionForegroundBrush")>] member inline this.SelectionForegroundBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionForegroundBrush), (fun ctx x -> ctx.Element.SelectionForegroundBrush <- x), x)
    [<CustomOperation("SelectionForegroundBrush")>] member inline this.SelectionForegroundBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionForegroundBrush), (fun ctx x -> ctx.Element.SelectionForegroundBrush <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedText), (fun ctx x -> ctx.Element.SelectedText <- x), x)
    [<CustomOperation("SelectedText")>] member inline this.SelectedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedText), (fun ctx x -> ctx.Element.SelectedText <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("UseFloatingWatermark")>] member inline this.UseFloatingWatermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseFloatingWatermark), (fun ctx x -> ctx.Element.UseFloatingWatermark <- x), x)
    [<CustomOperation("UseFloatingWatermark")>] member inline this.UseFloatingWatermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseFloatingWatermark), (fun ctx x -> ctx.Element.UseFloatingWatermark <- x), x)
    [<CustomOperation("InnerLeftContent")>] member inline this.InnerLeftContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InnerLeftContent), (fun ctx x -> ctx.Element.InnerLeftContent <- x), x)
    [<CustomOperation("InnerLeftContent")>] member inline this.InnerLeftContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InnerLeftContent), (fun ctx x -> ctx.Element.InnerLeftContent <- x), x)
    [<CustomOperation("InnerRightContent")>] member inline this.InnerRightContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InnerRightContent), (fun ctx x -> ctx.Element.InnerRightContent <- x), x)
    [<CustomOperation("InnerRightContent")>] member inline this.InnerRightContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InnerRightContent), (fun ctx x -> ctx.Element.InnerRightContent <- x), x)
    [<CustomOperation("RevealPassword")>] member inline this.RevealPassword ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RevealPassword), (fun ctx x -> ctx.Element.RevealPassword <- x), x)
    [<CustomOperation("RevealPassword")>] member inline this.RevealPassword ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RevealPassword), (fun ctx x -> ctx.Element.RevealPassword <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("NewLine")>] member inline this.NewLine ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NewLine), (fun ctx x -> ctx.Element.NewLine <- x), x)
    [<CustomOperation("NewLine")>] member inline this.NewLine ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NewLine), (fun ctx x -> ctx.Element.NewLine <- x), x)
    [<CustomOperation("IsUndoEnabled")>] member inline this.IsUndoEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsUndoEnabled), (fun ctx x -> ctx.Element.IsUndoEnabled <- x), x)
    [<CustomOperation("IsUndoEnabled")>] member inline this.IsUndoEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsUndoEnabled), (fun ctx x -> ctx.Element.IsUndoEnabled <- x), x)
    [<CustomOperation("UndoLimit")>] member inline this.UndoLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UndoLimit), (fun ctx x -> ctx.Element.UndoLimit <- x), x)
    [<CustomOperation("UndoLimit")>] member inline this.UndoLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UndoLimit), (fun ctx x -> ctx.Element.UndoLimit <- x), x)

    [<CustomOperation("CopyingToClipboard")>] member inline this.CopyingToClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CopyingToClipboard), "CopyingToClipboard", fn)
    [<CustomOperation("CuttingToClipboard")>] member inline this.CuttingToClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CuttingToClipboard), "CuttingToClipboard", fn)
    [<CustomOperation("PastingFromClipboard")>] member inline this.PastingFromClipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PastingFromClipboard), "PastingFromClipboard", fn)
                

type MaskedTextBoxBuilder<'Element when 'Element :> Avalonia.Controls.MaskedTextBox>() =
    inherit Controls.TextBoxBuilder<'Element>()

    [<CustomOperation("AsciiOnly")>] member inline this.AsciiOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AsciiOnly), (fun ctx x -> ctx.Element.AsciiOnly <- x), x)
    [<CustomOperation("AsciiOnly")>] member inline this.AsciiOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AsciiOnly), (fun ctx x -> ctx.Element.AsciiOnly <- x), x)
    [<CustomOperation("Culture")>] member inline this.Culture ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Globalization.CultureInfo) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Culture), (fun ctx x -> ctx.Element.Culture <- x), x)
    [<CustomOperation("Culture")>] member inline this.Culture ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Culture), (fun ctx x -> ctx.Element.Culture <- x), x)
    [<CustomOperation("HidePromptOnLeave")>] member inline this.HidePromptOnLeave ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HidePromptOnLeave), (fun ctx x -> ctx.Element.HidePromptOnLeave <- x), x)
    [<CustomOperation("HidePromptOnLeave")>] member inline this.HidePromptOnLeave ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HidePromptOnLeave), (fun ctx x -> ctx.Element.HidePromptOnLeave <- x), x)
    [<CustomOperation("Mask")>] member inline this.Mask ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Mask), (fun ctx x -> ctx.Element.Mask <- x), x)
    [<CustomOperation("Mask")>] member inline this.Mask ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Mask), (fun ctx x -> ctx.Element.Mask <- x), x)
    [<CustomOperation("MaskCompletedEx")>] member inline this.MaskCompletedEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MaskCompleted), x)
    [<CustomOperation("MaskCompletedEx'")>] member inline this.MaskCompletedEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MaskCompleted), x)
    [<CustomOperation("MaskCompleted")>] member inline this.MaskCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.MaskCompleted), x)
    [<CustomOperation("MaskCompleted'")>] member inline this.MaskCompleted' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.MaskCompleted), x)
    [<CustomOperation("MaskFullEx")>] member inline this.MaskFullEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MaskFull), x)
    [<CustomOperation("MaskFullEx'")>] member inline this.MaskFullEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MaskFull), x)
    [<CustomOperation("MaskFull")>] member inline this.MaskFull ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.MaskFull), x)
    [<CustomOperation("MaskFull'")>] member inline this.MaskFull' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.MaskFull), x)
    [<CustomOperation("MaskProviderEx")>] member inline this.MaskProviderEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.MaskProvider), x)
    [<CustomOperation("MaskProviderEx'")>] member inline this.MaskProviderEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.MaskProvider), x)
    [<CustomOperation("MaskProvider")>] member inline this.MaskProvider ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.MaskProvider), x)
    [<CustomOperation("MaskProvider'")>] member inline this.MaskProvider' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.MaskProvider), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Char) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PromptChar")>] member inline this.PromptChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Char) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PromptChar), (fun ctx x -> ctx.Element.PromptChar <- x), x)
    [<CustomOperation("PromptChar")>] member inline this.PromptChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PromptChar), (fun ctx x -> ctx.Element.PromptChar <- x), x)
    [<CustomOperation("ResetOnPrompt")>] member inline this.ResetOnPrompt ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResetOnPrompt), (fun ctx x -> ctx.Element.ResetOnPrompt <- x), x)
    [<CustomOperation("ResetOnPrompt")>] member inline this.ResetOnPrompt ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResetOnPrompt), (fun ctx x -> ctx.Element.ResetOnPrompt <- x), x)
    [<CustomOperation("ResetOnSpace")>] member inline this.ResetOnSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ResetOnSpace), (fun ctx x -> ctx.Element.ResetOnSpace <- x), x)
    [<CustomOperation("ResetOnSpace")>] member inline this.ResetOnSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ResetOnSpace), (fun ctx x -> ctx.Element.ResetOnSpace <- x), x)

                

type IconElementBuilder<'Element when 'Element :> Avalonia.Controls.IconElement>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


                

type PathIconBuilder<'Element when 'Element :> Avalonia.Controls.PathIcon>() =
    inherit Controls.IconElementBuilder<'Element>()

    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Geometry) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)
    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type RangeBaseBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.RangeBase>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("SmallChange")>] member inline this.SmallChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SmallChange), (fun ctx x -> ctx.Element.SmallChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)
    [<CustomOperation("LargeChange")>] member inline this.LargeChange ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LargeChange), (fun ctx x -> ctx.Element.LargeChange <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ProgressBarBuilder<'Element when 'Element :> Avalonia.Controls.ProgressBar>() =
    inherit Controls.Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("IndeterminateStartingOffset")>] member inline this.IndeterminateStartingOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndeterminateStartingOffset), (fun ctx x -> ctx.Element.IndeterminateStartingOffset <- x), x)
    [<CustomOperation("IndeterminateStartingOffset")>] member inline this.IndeterminateStartingOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndeterminateStartingOffset), (fun ctx x -> ctx.Element.IndeterminateStartingOffset <- x), x)
    [<CustomOperation("IndeterminateEndingOffset")>] member inline this.IndeterminateEndingOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndeterminateEndingOffset), (fun ctx x -> ctx.Element.IndeterminateEndingOffset <- x), x)
    [<CustomOperation("IndeterminateEndingOffset")>] member inline this.IndeterminateEndingOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndeterminateEndingOffset), (fun ctx x -> ctx.Element.IndeterminateEndingOffset <- x), x)
    [<CustomOperation("TemplatePropertiesEx")>] member inline this.TemplatePropertiesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplateProperties), x)
    [<CustomOperation("TemplatePropertiesEx'")>] member inline this.TemplatePropertiesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplateProperties), x)
    [<CustomOperation("TemplateProperties")>] member inline this.TemplateProperties ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.TemplateProperties), x)
    [<CustomOperation("TemplateProperties'")>] member inline this.TemplateProperties' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.TemplateProperties), x)
    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("IsIndeterminate")>] member inline this.IsIndeterminate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsIndeterminate), (fun ctx x -> ctx.Element.IsIndeterminate <- x), x)
    [<CustomOperation("ShowProgressText")>] member inline this.ShowProgressText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowProgressText), (fun ctx x -> ctx.Element.ShowProgressText <- x), x)
    [<CustomOperation("ShowProgressText")>] member inline this.ShowProgressText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowProgressText), (fun ctx x -> ctx.Element.ShowProgressText <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type SliderBuilder<'Element when 'Element :> Avalonia.Controls.Slider>() =
    inherit Controls.Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Collections.AvaloniaList<System.Double>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsSnapToTickEnabled")>] member inline this.IsSnapToTickEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSnapToTickEnabled), (fun ctx x -> ctx.Element.IsSnapToTickEnabled <- x), x)
    [<CustomOperation("IsSnapToTickEnabled")>] member inline this.IsSnapToTickEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSnapToTickEnabled), (fun ctx x -> ctx.Element.IsSnapToTickEnabled <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickPlacement")>] member inline this.TickPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.TickPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickPlacement), (fun ctx x -> ctx.Element.TickPlacement <- x), x)
    [<CustomOperation("TickPlacement")>] member inline this.TickPlacement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickPlacement), (fun ctx x -> ctx.Element.TickPlacement <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ScrollBarBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.ScrollBar>() =
    inherit Controls.Primitives.RangeBaseBuilder<'Element>()

    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("Visibility")>] member inline this.Visibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visibility), (fun ctx x -> ctx.Element.Visibility <- x), x)
    [<CustomOperation("Visibility")>] member inline this.Visibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visibility), (fun ctx x -> ctx.Element.Visibility <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("AllowAutoHide")>] member inline this.AllowAutoHide ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowAutoHide), (fun ctx x -> ctx.Element.AllowAutoHide <- x), x)
    [<CustomOperation("AllowAutoHide")>] member inline this.AllowAutoHide ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowAutoHide), (fun ctx x -> ctx.Element.AllowAutoHide <- x), x)
    [<CustomOperation("HideDelay")>] member inline this.HideDelay ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HideDelay), (fun ctx x -> ctx.Element.HideDelay <- x), x)
    [<CustomOperation("HideDelay")>] member inline this.HideDelay ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HideDelay), (fun ctx x -> ctx.Element.HideDelay <- x), x)
    [<CustomOperation("ShowDelay")>] member inline this.ShowDelay ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowDelay), (fun ctx x -> ctx.Element.ShowDelay <- x), x)
    [<CustomOperation("ShowDelay")>] member inline this.ShowDelay ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowDelay), (fun ctx x -> ctx.Element.ShowDelay <- x), x)

    [<CustomOperation("Scroll")>] member inline this.Scroll ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scroll), "Scroll", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type AutoCompleteBoxBuilder<'Element when 'Element :> Avalonia.Controls.AutoCompleteBox>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("MinimumPrefixLength")>] member inline this.MinimumPrefixLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumPrefixLength), (fun ctx x -> ctx.Element.MinimumPrefixLength <- x), x)
    [<CustomOperation("MinimumPrefixLength")>] member inline this.MinimumPrefixLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumPrefixLength), (fun ctx x -> ctx.Element.MinimumPrefixLength <- x), x)
    [<CustomOperation("IsTextCompletionEnabled")>] member inline this.IsTextCompletionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextCompletionEnabled), (fun ctx x -> ctx.Element.IsTextCompletionEnabled <- x), x)
    [<CustomOperation("IsTextCompletionEnabled")>] member inline this.IsTextCompletionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextCompletionEnabled), (fun ctx x -> ctx.Element.IsTextCompletionEnabled <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("MinimumPopulateDelay")>] member inline this.MinimumPopulateDelay ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumPopulateDelay), (fun ctx x -> ctx.Element.MinimumPopulateDelay <- x), x)
    [<CustomOperation("MinimumPopulateDelay")>] member inline this.MinimumPopulateDelay ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumPopulateDelay), (fun ctx x -> ctx.Element.MinimumPopulateDelay <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("MaxDropDownHeight")>] member inline this.MaxDropDownHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxDropDownHeight), (fun ctx x -> ctx.Element.MaxDropDownHeight <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("ValueMemberBinding")>] member inline this.ValueMemberBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Data.IBinding) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueMemberBinding), (fun ctx x -> ctx.Element.ValueMemberBinding <- x), x)
    [<CustomOperation("ValueMemberBinding")>] member inline this.ValueMemberBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ValueMemberBinding), (fun ctx x -> ctx.Element.ValueMemberBinding <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("SearchTextEx")>] member inline this.SearchTextEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SearchText), x)
    [<CustomOperation("SearchTextEx'")>] member inline this.SearchTextEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SearchText), x)
    [<CustomOperation("SearchText")>] member inline this.SearchText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SearchText), x)
    [<CustomOperation("SearchText'")>] member inline this.SearchText' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SearchText), x)
    [<CustomOperation("FilterMode")>] member inline this.FilterMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.AutoCompleteFilterMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FilterMode), (fun ctx x -> ctx.Element.FilterMode <- x), x)
    [<CustomOperation("FilterMode")>] member inline this.FilterMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FilterMode), (fun ctx x -> ctx.Element.FilterMode <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("ItemFilter")>] member inline this.ItemFilter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemFilter), (fun ctx x -> ctx.Element.ItemFilter <- x), x)
    [<CustomOperation("ItemFilter")>] member inline this.ItemFilter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemFilter), (fun ctx x -> ctx.Element.ItemFilter <- x), x)
    [<CustomOperation("TextFilter")>] member inline this.TextFilter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.AutoCompleteFilterPredicate<System.String>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextFilter), (fun ctx x -> ctx.Element.TextFilter <- x), x)
    [<CustomOperation("TextFilter")>] member inline this.TextFilter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextFilter), (fun ctx x -> ctx.Element.TextFilter <- x), x)
    [<CustomOperation("ItemSelector")>] member inline this.ItemSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.AutoCompleteSelector<System.Object>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemSelector), (fun ctx x -> ctx.Element.ItemSelector <- x), x)
    [<CustomOperation("ItemSelector")>] member inline this.ItemSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemSelector), (fun ctx x -> ctx.Element.ItemSelector <- x), x)
    [<CustomOperation("TextSelector")>] member inline this.TextSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.AutoCompleteSelector<System.String>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextSelector), (fun ctx x -> ctx.Element.TextSelector <- x), x)
    [<CustomOperation("TextSelector")>] member inline this.TextSelector ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextSelector), (fun ctx x -> ctx.Element.TextSelector <- x), x)
    [<CustomOperation("AsyncPopulator")>] member inline this.AsyncPopulator ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AsyncPopulator), (fun ctx x -> ctx.Element.AsyncPopulator <- x), (System.Func<System.String, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>fn))
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)

    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
    [<CustomOperation("Populating")>] member inline this.Populating ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Populating), "Populating", fn)
    [<CustomOperation("Populated")>] member inline this.Populated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Populated), "Populated", fn)
    [<CustomOperation("DropDownOpening")>] member inline this.DropDownOpening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownOpening), "DropDownOpening", fn)
    [<CustomOperation("DropDownOpened")>] member inline this.DropDownOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownOpened), "DropDownOpened", fn)
    [<CustomOperation("DropDownClosing")>] member inline this.DropDownClosing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownClosing), "DropDownClosing", fn)
    [<CustomOperation("DropDownClosed")>] member inline this.DropDownClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropDownClosed), "DropDownClosed", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type CalendarBuilder<'Element when 'Element :> Avalonia.Controls.Calendar>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DayOfWeek) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("HeaderBackground")>] member inline this.HeaderBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderBackground), (fun ctx x -> ctx.Element.HeaderBackground <- x), x)
    [<CustomOperation("HeaderBackground")>] member inline this.HeaderBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderBackground), (fun ctx x -> ctx.Element.HeaderBackground <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.CalendarMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("DisplayMode")>] member inline this.DisplayMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayMode), (fun ctx x -> ctx.Element.DisplayMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.CalendarSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDatesEx")>] member inline this.SelectedDatesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectedDatesEx'")>] member inline this.SelectedDatesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectedDates")>] member inline this.SelectedDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("SelectedDates'")>] member inline this.SelectedDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.SelectedDates), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("BlackoutDatesEx")>] member inline this.BlackoutDatesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDatesEx'")>] member inline this.BlackoutDatesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDates")>] member inline this.BlackoutDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDates'")>] member inline this.BlackoutDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)

    [<CustomOperation("SelectedDatesChanged")>] member inline this.SelectedDatesChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDatesChanged), "SelectedDatesChanged", fn)
    [<CustomOperation("DisplayDateChanged")>] member inline this.DisplayDateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateChanged), "DisplayDateChanged", fn)
    [<CustomOperation("DisplayModeChanged")>] member inline this.DisplayModeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayModeChanged), "DisplayModeChanged", fn)
                

type CalendarDatePickerBuilder<'Element when 'Element :> Avalonia.Controls.CalendarDatePicker>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("BlackoutDatesEx")>] member inline this.BlackoutDatesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDatesEx'")>] member inline this.BlackoutDatesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDates")>] member inline this.BlackoutDates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("BlackoutDates'")>] member inline this.BlackoutDates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.BlackoutDates), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDate")>] member inline this.DisplayDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDate), (fun ctx x -> ctx.Element.DisplayDate <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("DisplayDateStart")>] member inline this.DisplayDateStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateStart), (fun ctx x -> ctx.Element.DisplayDateStart <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("DisplayDateEnd")>] member inline this.DisplayDateEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDateEnd), (fun ctx x -> ctx.Element.DisplayDateEnd <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DayOfWeek) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("FirstDayOfWeek")>] member inline this.FirstDayOfWeek ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstDayOfWeek), (fun ctx x -> ctx.Element.FirstDayOfWeek <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsDropDownOpen")>] member inline this.IsDropDownOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDropDownOpen), (fun ctx x -> ctx.Element.IsDropDownOpen <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("IsTodayHighlighted")>] member inline this.IsTodayHighlighted ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTodayHighlighted), (fun ctx x -> ctx.Element.IsTodayHighlighted <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTime>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDateFormat")>] member inline this.SelectedDateFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.CalendarDatePickerFormat) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateFormat), (fun ctx x -> ctx.Element.SelectedDateFormat <- x), x)
    [<CustomOperation("SelectedDateFormat")>] member inline this.SelectedDateFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateFormat), (fun ctx x -> ctx.Element.SelectedDateFormat <- x), x)
    [<CustomOperation("CustomDateFormatString")>] member inline this.CustomDateFormatString ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CustomDateFormatString), (fun ctx x -> ctx.Element.CustomDateFormatString <- x), x)
    [<CustomOperation("CustomDateFormatString")>] member inline this.CustomDateFormatString ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CustomDateFormatString), (fun ctx x -> ctx.Element.CustomDateFormatString <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("UseFloatingWatermark")>] member inline this.UseFloatingWatermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseFloatingWatermark), (fun ctx x -> ctx.Element.UseFloatingWatermark <- x), x)
    [<CustomOperation("UseFloatingWatermark")>] member inline this.UseFloatingWatermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseFloatingWatermark), (fun ctx x -> ctx.Element.UseFloatingWatermark <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)

    [<CustomOperation("CalendarClosed")>] member inline this.CalendarClosed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarClosed), "CalendarClosed", fn)
    [<CustomOperation("CalendarOpened")>] member inline this.CalendarOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CalendarOpened), "CalendarOpened", fn)
    [<CustomOperation("DateValidationError")>] member inline this.DateValidationError ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DateValidationError), "DateValidationError", fn)
    [<CustomOperation("SelectedDateChanged")>] member inline this.SelectedDateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateChanged), "SelectedDateChanged", fn)
                

type DatePickerBuilder<'Element when 'Element :> Avalonia.Controls.DatePicker>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("DayFormat")>] member inline this.DayFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayFormat), (fun ctx x -> ctx.Element.DayFormat <- x), x)
    [<CustomOperation("DayFormat")>] member inline this.DayFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayFormat), (fun ctx x -> ctx.Element.DayFormat <- x), x)
    [<CustomOperation("DayVisible")>] member inline this.DayVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayVisible), (fun ctx x -> ctx.Element.DayVisible <- x), x)
    [<CustomOperation("DayVisible")>] member inline this.DayVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayVisible), (fun ctx x -> ctx.Element.DayVisible <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("MaxYear")>] member inline this.MaxYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxYear), (fun ctx x -> ctx.Element.MaxYear <- x), x)
    [<CustomOperation("MaxYear")>] member inline this.MaxYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxYear), (fun ctx x -> ctx.Element.MaxYear <- x), x)
    [<CustomOperation("MinYear")>] member inline this.MinYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTimeOffset) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinYear), (fun ctx x -> ctx.Element.MinYear <- x), x)
    [<CustomOperation("MinYear")>] member inline this.MinYear ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinYear), (fun ctx x -> ctx.Element.MinYear <- x), x)
    [<CustomOperation("MonthFormat")>] member inline this.MonthFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthFormat), (fun ctx x -> ctx.Element.MonthFormat <- x), x)
    [<CustomOperation("MonthFormat")>] member inline this.MonthFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthFormat), (fun ctx x -> ctx.Element.MonthFormat <- x), x)
    [<CustomOperation("MonthVisible")>] member inline this.MonthVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MonthVisible), (fun ctx x -> ctx.Element.MonthVisible <- x), x)
    [<CustomOperation("MonthVisible")>] member inline this.MonthVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MonthVisible), (fun ctx x -> ctx.Element.MonthVisible <- x), x)
    [<CustomOperation("YearFormat")>] member inline this.YearFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.YearFormat), (fun ctx x -> ctx.Element.YearFormat <- x), x)
    [<CustomOperation("YearFormat")>] member inline this.YearFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.YearFormat), (fun ctx x -> ctx.Element.YearFormat <- x), x)
    [<CustomOperation("YearVisible")>] member inline this.YearVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.YearVisible), (fun ctx x -> ctx.Element.YearVisible <- x), x)
    [<CustomOperation("YearVisible")>] member inline this.YearVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.YearVisible), (fun ctx x -> ctx.Element.YearVisible <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.DateTimeOffset>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)
    [<CustomOperation("SelectedDate")>] member inline this.SelectedDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDate), (fun ctx x -> ctx.Element.SelectedDate <- x), x)

    [<CustomOperation("SelectedDateChanged")>] member inline this.SelectedDateChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedDateChanged), "SelectedDateChanged", fn)
                

type TimePickerBuilder<'Element when 'Element :> Avalonia.Controls.TimePicker>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("MinuteIncrement")>] member inline this.MinuteIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinuteIncrement), (fun ctx x -> ctx.Element.MinuteIncrement <- x), x)
    [<CustomOperation("MinuteIncrement")>] member inline this.MinuteIncrement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinuteIncrement), (fun ctx x -> ctx.Element.MinuteIncrement <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("ClockIdentifier")>] member inline this.ClockIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClockIdentifier), (fun ctx x -> ctx.Element.ClockIdentifier <- x), x)
    [<CustomOperation("ClockIdentifier")>] member inline this.ClockIdentifier ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClockIdentifier), (fun ctx x -> ctx.Element.ClockIdentifier <- x), x)
    [<CustomOperation("SelectedTime")>] member inline this.SelectedTime ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<System.TimeSpan>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTime), (fun ctx x -> ctx.Element.SelectedTime <- x), x)
    [<CustomOperation("SelectedTime")>] member inline this.SelectedTime ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTime), (fun ctx x -> ctx.Element.SelectedTime <- x), x)

    [<CustomOperation("SelectedTimeChanged")>] member inline this.SelectedTimeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedTimeChanged), "SelectedTimeChanged", fn)
                

type NativeMenuBarBuilder<'Element when 'Element :> Avalonia.Controls.NativeMenuBar>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


                

type NumericUpDownBuilder<'Element when 'Element :> Avalonia.Controls.NumericUpDown>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("AllowSpin")>] member inline this.AllowSpin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowSpin), (fun ctx x -> ctx.Element.AllowSpin <- x), x)
    [<CustomOperation("AllowSpin")>] member inline this.AllowSpin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowSpin), (fun ctx x -> ctx.Element.AllowSpin <- x), x)
    [<CustomOperation("ButtonSpinnerLocation")>] member inline this.ButtonSpinnerLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Location) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ButtonSpinnerLocation), (fun ctx x -> ctx.Element.ButtonSpinnerLocation <- x), x)
    [<CustomOperation("ButtonSpinnerLocation")>] member inline this.ButtonSpinnerLocation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ButtonSpinnerLocation), (fun ctx x -> ctx.Element.ButtonSpinnerLocation <- x), x)
    [<CustomOperation("ShowButtonSpinner")>] member inline this.ShowButtonSpinner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowButtonSpinner), (fun ctx x -> ctx.Element.ShowButtonSpinner <- x), x)
    [<CustomOperation("ShowButtonSpinner")>] member inline this.ShowButtonSpinner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowButtonSpinner), (fun ctx x -> ctx.Element.ShowButtonSpinner <- x), x)
    [<CustomOperation("ClipValueToMinMax")>] member inline this.ClipValueToMinMax ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClipValueToMinMax), (fun ctx x -> ctx.Element.ClipValueToMinMax <- x), x)
    [<CustomOperation("ClipValueToMinMax")>] member inline this.ClipValueToMinMax ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClipValueToMinMax), (fun ctx x -> ctx.Element.ClipValueToMinMax <- x), x)
    [<CustomOperation("CultureInfo")>] member inline this.CultureInfo ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Globalization.CultureInfo) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CultureInfo), (fun ctx x -> ctx.Element.CultureInfo <- x), x)
    [<CustomOperation("CultureInfo")>] member inline this.CultureInfo ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CultureInfo), (fun ctx x -> ctx.Element.CultureInfo <- x), x)
    [<CustomOperation("FormatString")>] member inline this.FormatString ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FormatString), (fun ctx x -> ctx.Element.FormatString <- x), x)
    [<CustomOperation("FormatString")>] member inline this.FormatString ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FormatString), (fun ctx x -> ctx.Element.FormatString <- x), x)
    [<CustomOperation("Increment")>] member inline this.Increment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Increment), (fun ctx x -> ctx.Element.Increment <- x), x)
    [<CustomOperation("Increment")>] member inline this.Increment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Increment), (fun ctx x -> ctx.Element.Increment <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("ParsingNumberStyle")>] member inline this.ParsingNumberStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Globalization.NumberStyles) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ParsingNumberStyle), (fun ctx x -> ctx.Element.ParsingNumberStyle <- x), x)
    [<CustomOperation("ParsingNumberStyle")>] member inline this.ParsingNumberStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ParsingNumberStyle), (fun ctx x -> ctx.Element.ParsingNumberStyle <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("Watermark")>] member inline this.Watermark ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Watermark), (fun ctx x -> ctx.Element.Watermark <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)

    [<CustomOperation("Spinned")>] member inline this.Spinned ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Spinned), "Spinned", fn)
    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                

type SeparatorBuilder<'Element when 'Element :> Avalonia.Controls.Separator>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Notifications

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type WindowNotificationManagerBuilder<'Element when 'Element :> Avalonia.Controls.Notifications.WindowNotificationManager>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()

    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Notifications.NotificationPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("MaxItems")>] member inline this.MaxItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxItems), (fun ctx x -> ctx.Element.MaxItems <- x), x)
    [<CustomOperation("MaxItems")>] member inline this.MaxItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxItems), (fun ctx x -> ctx.Element.MaxItems <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Chrome

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type CaptionButtonsBuilder<'Element when 'Element :> Avalonia.Controls.Chrome.CaptionButtons>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


                

type TitleBarBuilder<'Element when 'Element :> Avalonia.Controls.Chrome.TitleBar>() =
    inherit Controls.Primitives.TemplatedControlBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type CalendarItemBuilder() =
    inherit Controls.Primitives.TemplatedControlBuilder<Avalonia.Controls.Primitives.CalendarItem>()

    [<CustomOperation("HeaderBackground")>] member inline this.HeaderBackground ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarItem>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderBackground), (fun ctx x -> ctx.Element.HeaderBackground <- x), x)
    [<CustomOperation("HeaderBackground")>] member inline this.HeaderBackground ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarItem>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderBackground), (fun ctx x -> ctx.Element.HeaderBackground <- x), x)
    [<CustomOperation("DayTitleTemplate")>] member inline this.DayTitleTemplate ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarItem>, x: Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DayTitleTemplate), (fun ctx x -> ctx.Element.DayTitleTemplate <- x), x)
    [<CustomOperation("DayTitleTemplate")>] member inline this.DayTitleTemplate ([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarItem>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DayTitleTemplate), (fun ctx x -> ctx.Element.DayTitleTemplate <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type PanelBuilder<'Element when 'Element :> Avalonia.Controls.Panel>() =
    inherit Controls.ControlBuilder<'Element>()


    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<Avalonia> seq) =
        this.MakeChildrenBuilder<'Element, Avalonia.Controls.IControl>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Avalonia.Controls.IControl[]) -> x.Element.Children.AddRange(ls)),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<Avalonia> alist) =
        this.MakeChildrenBuilder<'Element, Avalonia.Controls.IControl>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Avalonia.Controls.IControl[]) -> x.Element.Children.AddRange(ls)),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<Avalonia> seq) =
        this.MakeStaticChildrenBuilder<'Element, Avalonia.Controls.IControl>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Avalonia.Controls.IControl[]) -> x.Element.Children.AddRange(ls)),
            items
        )
                        
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)

                

type StackPanelBuilder<'Element when 'Element :> Avalonia.Controls.StackPanel>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)
    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type ReversibleStackPanelBuilder<'Element when 'Element :> Avalonia.Controls.ReversibleStackPanel>() =
    inherit Controls.StackPanelBuilder<'Element>()

    [<CustomOperation("ReverseOrder")>] member inline this.ReverseOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReverseOrder), (fun ctx x -> ctx.Element.ReverseOrder <- x), x)
    [<CustomOperation("ReverseOrder")>] member inline this.ReverseOrder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReverseOrder), (fun ctx x -> ctx.Element.ReverseOrder <- x), x)

                

type VirtualizingStackPanelBuilder<'Element when 'Element :> Avalonia.Controls.VirtualizingStackPanel>() =
    inherit Controls.StackPanelBuilder<'Element>()


                

type CanvasBuilder<'Element when 'Element :> Avalonia.Controls.Canvas>() =
    inherit Controls.PanelBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type AdornerLayerBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.AdornerLayer>() =
    inherit Controls.CanvasBuilder<'Element>()


                

type OverlayLayerBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.OverlayLayer>() =
    inherit Controls.CanvasBuilder<'Element>()

    [<CustomOperation("AvailableSizeEx")>] member inline this.AvailableSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AvailableSize), x)
    [<CustomOperation("AvailableSizeEx'")>] member inline this.AvailableSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AvailableSize), x)
    [<CustomOperation("AvailableSize")>] member inline this.AvailableSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.AvailableSize), x)
    [<CustomOperation("AvailableSize'")>] member inline this.AvailableSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.AvailableSize), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type DockPanelBuilder<'Element when 'Element :> Avalonia.Controls.DockPanel>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("LastChildFill")>] member inline this.LastChildFill ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LastChildFill), (fun ctx x -> ctx.Element.LastChildFill <- x), x)
    [<CustomOperation("LastChildFill")>] member inline this.LastChildFill ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LastChildFill), (fun ctx x -> ctx.Element.LastChildFill <- x), x)

                

type GridBuilder<'Element when 'Element :> Avalonia.Controls.Grid>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("ShowGridLines")>] member inline this.ShowGridLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowGridLines), (fun ctx x -> ctx.Element.ShowGridLines <- x), x)
    [<CustomOperation("ShowGridLines")>] member inline this.ShowGridLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowGridLines), (fun ctx x -> ctx.Element.ShowGridLines <- x), x)
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ColumnDefinitions) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDefinitions), (fun ctx x -> ctx.Element.ColumnDefinitions <- x), x)
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDefinitions), (fun ctx x -> ctx.Element.ColumnDefinitions <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.RowDefinitions) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDefinitions), (fun ctx x -> ctx.Element.RowDefinitions <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowDefinitions), (fun ctx x -> ctx.Element.RowDefinitions <- x), x)

                

type RelativePanelBuilder<'Element when 'Element :> Avalonia.Controls.RelativePanel>() =
    inherit Controls.PanelBuilder<'Element>()


                

type ItemsRepeaterBuilder<'Element when 'Element :> Avalonia.Controls.ItemsRepeater>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("Layout")>] member inline this.Layout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.AttachedLayout) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Layout), (fun ctx x -> ctx.Element.Layout <- x), x)
    [<CustomOperation("Layout")>] member inline this.Layout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Layout), (fun ctx x -> ctx.Element.Layout <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("HorizontalCacheLength")>] member inline this.HorizontalCacheLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalCacheLength), (fun ctx x -> ctx.Element.HorizontalCacheLength <- x), x)
    [<CustomOperation("HorizontalCacheLength")>] member inline this.HorizontalCacheLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalCacheLength), (fun ctx x -> ctx.Element.HorizontalCacheLength <- x), x)
    [<CustomOperation("VerticalCacheLength")>] member inline this.VerticalCacheLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalCacheLength), (fun ctx x -> ctx.Element.VerticalCacheLength <- x), x)
    [<CustomOperation("VerticalCacheLength")>] member inline this.VerticalCacheLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalCacheLength), (fun ctx x -> ctx.Element.VerticalCacheLength <- x), x)
    [<CustomOperation("ItemsSourceViewEx")>] member inline this.ItemsSourceViewEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemsSourceView), x)
    [<CustomOperation("ItemsSourceViewEx'")>] member inline this.ItemsSourceViewEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemsSourceView), x)
    [<CustomOperation("ItemsSourceView")>] member inline this.ItemsSourceView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ItemsSourceView), x)
    [<CustomOperation("ItemsSourceView'")>] member inline this.ItemsSourceView' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ItemsSourceView), x)

    [<CustomOperation("ElementClearing")>] member inline this.ElementClearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ElementClearing), "ElementClearing", fn)
    [<CustomOperation("ElementIndexChanged")>] member inline this.ElementIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ElementIndexChanged), "ElementIndexChanged", fn)
    [<CustomOperation("ElementPrepared")>] member inline this.ElementPrepared ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ElementPrepared), "ElementPrepared", fn)
                

type WrapPanelBuilder<'Element when 'Element :> Avalonia.Controls.WrapPanel>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type DateTimePickerPanelBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.DateTimePickerPanel>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("PanelType")>] member inline this.PanelType ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.DateTimePickerPanelType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PanelType), (fun ctx x -> ctx.Element.PanelType <- x), x)
    [<CustomOperation("PanelType")>] member inline this.PanelType ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PanelType), (fun ctx x -> ctx.Element.PanelType <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemFormat")>] member inline this.ItemFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemFormat), (fun ctx x -> ctx.Element.ItemFormat <- x), x)
    [<CustomOperation("ItemFormat")>] member inline this.ItemFormat ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemFormat), (fun ctx x -> ctx.Element.ItemFormat <- x), x)
    [<CustomOperation("ShouldLoop")>] member inline this.ShouldLoop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldLoop), (fun ctx x -> ctx.Element.ShouldLoop <- x), x)
    [<CustomOperation("ShouldLoop")>] member inline this.ShouldLoop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShouldLoop), (fun ctx x -> ctx.Element.ShouldLoop <- x), x)
    [<CustomOperation("MinimumValue")>] member inline this.MinimumValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumValue), (fun ctx x -> ctx.Element.MinimumValue <- x), x)
    [<CustomOperation("MinimumValue")>] member inline this.MinimumValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumValue), (fun ctx x -> ctx.Element.MinimumValue <- x), x)
    [<CustomOperation("MaximumValue")>] member inline this.MaximumValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumValue), (fun ctx x -> ctx.Element.MaximumValue <- x), x)
    [<CustomOperation("MaximumValue")>] member inline this.MaximumValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumValue), (fun ctx x -> ctx.Element.MaximumValue <- x), x)
    [<CustomOperation("SelectedValue")>] member inline this.SelectedValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValue), (fun ctx x -> ctx.Element.SelectedValue <- x), x)
    [<CustomOperation("SelectedValue")>] member inline this.SelectedValue ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedValue), (fun ctx x -> ctx.Element.SelectedValue <- x), x)
    [<CustomOperation("Increment")>] member inline this.Increment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Increment), (fun ctx x -> ctx.Element.Increment <- x), x)
    [<CustomOperation("Increment")>] member inline this.Increment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Increment), (fun ctx x -> ctx.Element.Increment <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Vector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ScrollSizeEx")>] member inline this.ScrollSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ScrollSize), x)
    [<CustomOperation("ScrollSizeEx'")>] member inline this.ScrollSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ScrollSize), x)
    [<CustomOperation("ScrollSize")>] member inline this.ScrollSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ScrollSize), x)
    [<CustomOperation("ScrollSize'")>] member inline this.ScrollSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ScrollSize), x)
    [<CustomOperation("PageScrollSizeEx")>] member inline this.PageScrollSizeEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PageScrollSize), x)
    [<CustomOperation("PageScrollSizeEx'")>] member inline this.PageScrollSizeEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PageScrollSize), x)
    [<CustomOperation("PageScrollSize")>] member inline this.PageScrollSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PageScrollSize), x)
    [<CustomOperation("PageScrollSize'")>] member inline this.PageScrollSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PageScrollSize), x)
    [<CustomOperation("ExtentEx")>] member inline this.ExtentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Extent), x)
    [<CustomOperation("ExtentEx'")>] member inline this.ExtentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Extent")>] member inline this.Extent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Extent'")>] member inline this.Extent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Extent), x)
    [<CustomOperation("ViewportEx")>] member inline this.ViewportEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("ViewportEx'")>] member inline this.ViewportEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("Viewport")>] member inline this.Viewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("Viewport'")>] member inline this.Viewport' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Viewport), x)

    [<CustomOperation("ScrollInvalidated")>] member inline this.ScrollInvalidated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollInvalidated), "ScrollInvalidated", fn)
    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type ChromeOverlayLayerBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.ChromeOverlayLayer>() =
    inherit Controls.PanelBuilder<'Element>()


                

type UniformGridBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.UniformGrid>() =
    inherit Controls.PanelBuilder<'Element>()

    [<CustomOperation("Rows")>] member inline this.Rows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Rows), (fun ctx x -> ctx.Element.Rows <- x), x)
    [<CustomOperation("Rows")>] member inline this.Rows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Rows), (fun ctx x -> ctx.Element.Rows <- x), x)
    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Columns), (fun ctx x -> ctx.Element.Columns <- x), x)
    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Columns), (fun ctx x -> ctx.Element.Columns <- x), x)
    [<CustomOperation("FirstColumn")>] member inline this.FirstColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstColumn), (fun ctx x -> ctx.Element.FirstColumn <- x), x)
    [<CustomOperation("FirstColumn")>] member inline this.FirstColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstColumn), (fun ctx x -> ctx.Element.FirstColumn <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type DecoratorBuilder<'Element when 'Element :> Avalonia.Controls.Decorator>() =
    inherit Controls.ControlBuilder<'Element>()



    member inline _.Yield(creator: ElementCreator<Avalonia>) = creator
    
    member inline this.Combine(creator: ElementCreator<Avalonia>, [<InlineIfLambda>] builder: BuildElement<'Element>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), fn ())
    
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia>) =
        this.MakeSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.Child <- x), fn ())

    
    member inline _.Yield(creator: ElementCreator<Avalonia> aval) = creator
    
    member inline this.Combine(creator: ElementCreator<Avalonia> aval, [<InlineIfLambda>] builder: BuildElement<'Element>) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia> aval) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), fn ())
                        
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia> aval) =
        this.MakeAdaptiveSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.Child <- x), fn ())

                        

    [<CustomOperation("Child")>]
    member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)

    [<CustomOperation("Child")>]
    member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
                        
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)

                

type BorderBuilder<'Element when 'Element :> Avalonia.Controls.Border>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderDashArray")>] member inline this.BorderDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Collections.AvaloniaList<System.Double>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderDashArray), (fun ctx x -> ctx.Element.BorderDashArray <- x), x)
    [<CustomOperation("BorderDashArray")>] member inline this.BorderDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderDashArray), (fun ctx x -> ctx.Element.BorderDashArray <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderDashOffset")>] member inline this.BorderDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderDashOffset), (fun ctx x -> ctx.Element.BorderDashOffset <- x), x)
    [<CustomOperation("BorderDashOffset")>] member inline this.BorderDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderDashOffset), (fun ctx x -> ctx.Element.BorderDashOffset <- x), x)
    [<CustomOperation("BorderLineCap")>] member inline this.BorderLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderLineCap), (fun ctx x -> ctx.Element.BorderLineCap <- x), x)
    [<CustomOperation("BorderLineCap")>] member inline this.BorderLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderLineCap), (fun ctx x -> ctx.Element.BorderLineCap <- x), x)
    [<CustomOperation("BorderLineJoin")>] member inline this.BorderLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.PenLineJoin) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderLineJoin), (fun ctx x -> ctx.Element.BorderLineJoin <- x), x)
    [<CustomOperation("BorderLineJoin")>] member inline this.BorderLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderLineJoin), (fun ctx x -> ctx.Element.BorderLineJoin <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("BoxShadow")>] member inline this.BoxShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.BoxShadows) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BoxShadow), (fun ctx x -> ctx.Element.BoxShadow <- x), x)
    [<CustomOperation("BoxShadow")>] member inline this.BoxShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BoxShadow), (fun ctx x -> ctx.Element.BoxShadow <- x), x)
    [<CustomOperation("ClipToBoundsRadiusEx")>] member inline this.ClipToBoundsRadiusEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ClipToBoundsRadius), x)
    [<CustomOperation("ClipToBoundsRadiusEx'")>] member inline this.ClipToBoundsRadiusEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ClipToBoundsRadius), x)
    [<CustomOperation("ClipToBoundsRadius")>] member inline this.ClipToBoundsRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ClipToBoundsRadius), x)
    [<CustomOperation("ClipToBoundsRadius'")>] member inline this.ClipToBoundsRadius' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ClipToBoundsRadius), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type LightDismissOverlayLayerBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.LightDismissOverlayLayer>() =
    inherit Controls.BorderBuilder<'Element>()

    [<CustomOperation("InputPassThroughElement")>] member inline this.InputPassThroughElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.IInputElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputPassThroughElement), (fun ctx x -> ctx.Element.InputPassThroughElement <- x), x)
    [<CustomOperation("InputPassThroughElement")>] member inline this.InputPassThroughElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputPassThroughElement), (fun ctx x -> ctx.Element.InputPassThroughElement <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ExperimentalAcrylicBorderBuilder<'Element when 'Element :> Avalonia.Controls.ExperimentalAcrylicBorder>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("Material")>] member inline this.Material ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.ExperimentalAcrylicMaterial) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Material), (fun ctx x -> ctx.Element.Material <- x), x)
    [<CustomOperation("Material")>] member inline this.Material ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Material), (fun ctx x -> ctx.Element.Material <- x), x)

                

type LayoutTransformControlBuilder<'Element when 'Element :> Avalonia.Controls.LayoutTransformControl>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("LayoutTransform")>] member inline this.LayoutTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.ITransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutTransform), (fun ctx x -> ctx.Element.LayoutTransform <- x), x)
    [<CustomOperation("LayoutTransform")>] member inline this.LayoutTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutTransform), (fun ctx x -> ctx.Element.LayoutTransform <- x), x)
    [<CustomOperation("UseRenderTransform")>] member inline this.UseRenderTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseRenderTransform), (fun ctx x -> ctx.Element.UseRenderTransform <- x), x)
    [<CustomOperation("UseRenderTransform")>] member inline this.UseRenderTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseRenderTransform), (fun ctx x -> ctx.Element.UseRenderTransform <- x), x)

                

type ViewboxBuilder<'Element when 'Element :> Avalonia.Controls.Viewbox>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.StretchDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type VisualLayerManagerBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.VisualLayerManager>() =
    inherit Controls.DecoratorBuilder<'Element>()

    [<CustomOperation("IsPopup")>] member inline this.IsPopup ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPopup), (fun ctx x -> ctx.Element.IsPopup <- x), x)
    [<CustomOperation("IsPopup")>] member inline this.IsPopup ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPopup), (fun ctx x -> ctx.Element.IsPopup <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Shapes

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ShapeBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Shape>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("DefiningGeometryEx")>] member inline this.DefiningGeometryEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DefiningGeometry), x)
    [<CustomOperation("DefiningGeometryEx'")>] member inline this.DefiningGeometryEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DefiningGeometry), x)
    [<CustomOperation("DefiningGeometry")>] member inline this.DefiningGeometry ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.DefiningGeometry), x)
    [<CustomOperation("DefiningGeometry'")>] member inline this.DefiningGeometry' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.DefiningGeometry), x)
    [<CustomOperation("RenderedGeometryEx")>] member inline this.RenderedGeometryEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("RenderedGeometryEx'")>] member inline this.RenderedGeometryEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("RenderedGeometry")>] member inline this.RenderedGeometry ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("RenderedGeometry'")>] member inline this.RenderedGeometry' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.RenderedGeometry), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stroke")>] member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stroke), (fun ctx x -> ctx.Element.Stroke <- x), x)
    [<CustomOperation("Stroke")>] member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stroke), (fun ctx x -> ctx.Element.Stroke <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Collections.AvaloniaList<System.Double>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeLineCap")>] member inline this.StrokeLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineCap), (fun ctx x -> ctx.Element.StrokeLineCap <- x), x)
    [<CustomOperation("StrokeLineCap")>] member inline this.StrokeLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineCap), (fun ctx x -> ctx.Element.StrokeLineCap <- x), x)
    [<CustomOperation("StrokeJoin")>] member inline this.StrokeJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.PenLineJoin) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeJoin), (fun ctx x -> ctx.Element.StrokeJoin <- x), x)
    [<CustomOperation("StrokeJoin")>] member inline this.StrokeJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeJoin), (fun ctx x -> ctx.Element.StrokeJoin <- x), x)

                

type ArcBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Arc>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()

    [<CustomOperation("StartAngle")>] member inline this.StartAngle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StartAngle), (fun ctx x -> ctx.Element.StartAngle <- x), x)
    [<CustomOperation("StartAngle")>] member inline this.StartAngle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StartAngle), (fun ctx x -> ctx.Element.StartAngle <- x), x)
    [<CustomOperation("SweepAngle")>] member inline this.SweepAngle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SweepAngle), (fun ctx x -> ctx.Element.SweepAngle <- x), x)
    [<CustomOperation("SweepAngle")>] member inline this.SweepAngle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SweepAngle), (fun ctx x -> ctx.Element.SweepAngle <- x), x)

                

type EllipseBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Ellipse>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()


                

type LineBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Line>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()

    [<CustomOperation("StartPoint")>] member inline this.StartPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StartPoint), (fun ctx x -> ctx.Element.StartPoint <- x), x)
    [<CustomOperation("StartPoint")>] member inline this.StartPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StartPoint), (fun ctx x -> ctx.Element.StartPoint <- x), x)
    [<CustomOperation("EndPoint")>] member inline this.EndPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EndPoint), (fun ctx x -> ctx.Element.EndPoint <- x), x)
    [<CustomOperation("EndPoint")>] member inline this.EndPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EndPoint), (fun ctx x -> ctx.Element.EndPoint <- x), x)

                

type PathBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Path>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()

    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Geometry) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)
    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)

                

type PolygonBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Polygon>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()

    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<Avalonia.Point>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)

                

type PolylineBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Polyline>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()

    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<Avalonia.Point>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)

                

type RectangleBuilder<'Element when 'Element :> Avalonia.Controls.Shapes.Rectangle>() =
    inherit Controls.Shapes.ShapeBuilder<'Element>()


                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Presenters

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ItemsPresenterBaseBuilder<'Element when 'Element :> Avalonia.Controls.Presenters.ItemsPresenterBase>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("ItemContainerGeneratorEx")>] member inline this.ItemContainerGeneratorEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGeneratorEx'")>] member inline this.ItemContainerGeneratorEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemsPanel")>] member inline this.ItemsPanel ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsPanel), (fun ctx x -> ctx.Element.ItemsPanel <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)

                

type CarouselPresenterBuilder<'Element when 'Element :> Avalonia.Controls.Presenters.CarouselPresenter>() =
    inherit Controls.Presenters.ItemsPresenterBaseBuilder<'Element>()

    [<CustomOperation("IsVirtualized")>] member inline this.IsVirtualized ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVirtualized), (fun ctx x -> ctx.Element.IsVirtualized <- x), x)
    [<CustomOperation("IsVirtualized")>] member inline this.IsVirtualized ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVirtualized), (fun ctx x -> ctx.Element.IsVirtualized <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("PageTransition")>] member inline this.PageTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Animation.IPageTransition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PageTransition), (fun ctx x -> ctx.Element.PageTransition <- x), x)
    [<CustomOperation("PageTransition")>] member inline this.PageTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PageTransition), (fun ctx x -> ctx.Element.PageTransition <- x), x)

                

type ItemsPresenterBuilder<'Element when 'Element :> Avalonia.Controls.Presenters.ItemsPresenter>() =
    inherit Controls.Presenters.ItemsPresenterBaseBuilder<'Element>()

    [<CustomOperation("VirtualizationMode")>] member inline this.VirtualizationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ItemVirtualizationMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualizationMode), (fun ctx x -> ctx.Element.VirtualizationMode <- x), x)
    [<CustomOperation("VirtualizationMode")>] member inline this.VirtualizationMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VirtualizationMode), (fun ctx x -> ctx.Element.VirtualizationMode <- x), x)

                

type ContentPresenterBuilder<'Element when 'Element :> Avalonia.Controls.Presenters.ContentPresenter>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("BoxShadow")>] member inline this.BoxShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.BoxShadows) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BoxShadow), (fun ctx x -> ctx.Element.BoxShadow <- x), x)
    [<CustomOperation("BoxShadow")>] member inline this.BoxShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BoxShadow), (fun ctx x -> ctx.Element.BoxShadow <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("HorizontalContentAlignment")>] member inline this.HorizontalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalContentAlignment), (fun ctx x -> ctx.Element.HorizontalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("VerticalContentAlignment")>] member inline this.VerticalContentAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalContentAlignment), (fun ctx x -> ctx.Element.VerticalContentAlignment <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("RecognizesAccessKey")>] member inline this.RecognizesAccessKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RecognizesAccessKey), (fun ctx x -> ctx.Element.RecognizesAccessKey <- x), x)
    [<CustomOperation("RecognizesAccessKey")>] member inline this.RecognizesAccessKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RecognizesAccessKey), (fun ctx x -> ctx.Element.RecognizesAccessKey <- x), x)

                

type ScrollContentPresenterBuilder<'Element when 'Element :> Avalonia.Controls.Presenters.ScrollContentPresenter>() =
    inherit Controls.Presenters.ContentPresenterBuilder<'Element>()

    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ExtentEx")>] member inline this.ExtentEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Extent), x)
    [<CustomOperation("ExtentEx'")>] member inline this.ExtentEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Extent")>] member inline this.Extent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Extent'")>] member inline this.Extent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Extent), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Vector) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("ViewportEx")>] member inline this.ViewportEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("ViewportEx'")>] member inline this.ViewportEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("Viewport")>] member inline this.Viewport ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Viewport), x)
    [<CustomOperation("Viewport'")>] member inline this.Viewport' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Viewport), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TextBlockBuilder<'Element when 'Element :> Avalonia.Controls.TextBlock>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("TextLayoutEx")>] member inline this.TextLayoutEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TextLayout), x)
    [<CustomOperation("TextLayoutEx'")>] member inline this.TextLayoutEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TextLayout), x)
    [<CustomOperation("TextLayout")>] member inline this.TextLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.TextLayout), x)
    [<CustomOperation("TextLayout'")>] member inline this.TextLayout' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.TextLayout), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("MaxLines")>] member inline this.MaxLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLines), (fun ctx x -> ctx.Element.MaxLines <- x), x)
    [<CustomOperation("MaxLines")>] member inline this.MaxLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLines), (fun ctx x -> ctx.Element.MaxLines <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextTrimming")>] member inline this.TextTrimming ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextTrimming) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTrimming), (fun ctx x -> ctx.Element.TextTrimming <- x), x)
    [<CustomOperation("TextTrimming")>] member inline this.TextTrimming ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTrimming), (fun ctx x -> ctx.Element.TextTrimming <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextDecorationCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type AccessTextBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.AccessText>() =
    inherit Controls.TextBlockBuilder<'Element>()

    [<CustomOperation("ShowAccessKey")>] member inline this.ShowAccessKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowAccessKey), (fun ctx x -> ctx.Element.ShowAccessKey <- x), x)
    [<CustomOperation("ShowAccessKey")>] member inline this.ShowAccessKey ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowAccessKey), (fun ctx x -> ctx.Element.ShowAccessKey <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type DrawingPresenterBuilder<'Element when 'Element :> Avalonia.Controls.DrawingPresenter>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Drawing")>] member inline this.Drawing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Drawing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Drawing), (fun ctx x -> ctx.Element.Drawing <- x), x)
    [<CustomOperation("Drawing")>] member inline this.Drawing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Drawing), (fun ctx x -> ctx.Element.Drawing <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)

                

type ImageBuilder<'Element when 'Element :> Avalonia.Controls.Image>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IImage) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("Stretch")>] member inline this.Stretch ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Stretch), (fun ctx x -> ctx.Element.Stretch <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.StretchDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)
    [<CustomOperation("StretchDirection")>] member inline this.StretchDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StretchDirection), (fun ctx x -> ctx.Element.StretchDirection <- x), x)

                

type NativeControlHostBuilder<'Element when 'Element :> Avalonia.Controls.NativeControlHost>() =
    inherit Controls.ControlBuilder<'Element>()


                

type TickBarBuilder<'Element when 'Element :> Avalonia.Controls.TickBar>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Fill")>] member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Fill), (fun ctx x -> ctx.Element.Fill <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("TickFrequency")>] member inline this.TickFrequency ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TickFrequency), (fun ctx x -> ctx.Element.TickFrequency <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Collections.AvaloniaList<System.Double>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("Ticks")>] member inline this.Ticks ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Ticks), (fun ctx x -> ctx.Element.Ticks <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.TickBarPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("ReservedSpace")>] member inline this.ReservedSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReservedSpace), (fun ctx x -> ctx.Element.ReservedSpace <- x), x)
    [<CustomOperation("ReservedSpace")>] member inline this.ReservedSpace ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReservedSpace), (fun ctx x -> ctx.Element.ReservedSpace <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Remote

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type RemoteWidgetBuilder<'Element when 'Element :> Avalonia.Controls.Remote.RemoteWidget>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Mode")>] member inline this.Mode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Remote.RemoteWidget.SizingMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Mode), (fun ctx x -> ctx.Element.Mode <- x), x)
    [<CustomOperation("Mode")>] member inline this.Mode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Mode), (fun ctx x -> ctx.Element.Mode <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Presenters

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type TextPresenterBuilder<'Element when 'Element :> Avalonia.Controls.Presenters.TextPresenter>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontFamily) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontStyle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontStyle")>] member inline this.FontStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontStyle), (fun ctx x -> ctx.Element.FontStyle <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.FontWeight) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("FontWeight")>] member inline this.FontWeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontWeight), (fun ctx x -> ctx.Element.FontWeight <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Foreground), (fun ctx x -> ctx.Element.Foreground <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextWrapping) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextWrapping")>] member inline this.TextWrapping ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextWrapping), (fun ctx x -> ctx.Element.TextWrapping <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("TextAlignment")>] member inline this.TextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextAlignment), (fun ctx x -> ctx.Element.TextAlignment <- x), x)
    [<CustomOperation("FormattedTextEx")>] member inline this.FormattedTextEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FormattedText), x)
    [<CustomOperation("FormattedTextEx'")>] member inline this.FormattedTextEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FormattedText), x)
    [<CustomOperation("FormattedText")>] member inline this.FormattedText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FormattedText), x)
    [<CustomOperation("FormattedText'")>] member inline this.FormattedText' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FormattedText), x)
    [<CustomOperation("CaretIndex")>] member inline this.CaretIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretIndex), (fun ctx x -> ctx.Element.CaretIndex <- x), x)
    [<CustomOperation("CaretIndex")>] member inline this.CaretIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretIndex), (fun ctx x -> ctx.Element.CaretIndex <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Char) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("PasswordChar")>] member inline this.PasswordChar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PasswordChar), (fun ctx x -> ctx.Element.PasswordChar <- x), x)
    [<CustomOperation("RevealPassword")>] member inline this.RevealPassword ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RevealPassword), (fun ctx x -> ctx.Element.RevealPassword <- x), x)
    [<CustomOperation("RevealPassword")>] member inline this.RevealPassword ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RevealPassword), (fun ctx x -> ctx.Element.RevealPassword <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionBrush")>] member inline this.SelectionBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionBrush), (fun ctx x -> ctx.Element.SelectionBrush <- x), x)
    [<CustomOperation("SelectionForegroundBrush")>] member inline this.SelectionForegroundBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionForegroundBrush), (fun ctx x -> ctx.Element.SelectionForegroundBrush <- x), x)
    [<CustomOperation("SelectionForegroundBrush")>] member inline this.SelectionForegroundBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionForegroundBrush), (fun ctx x -> ctx.Element.SelectionForegroundBrush <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.IBrush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("CaretBrush")>] member inline this.CaretBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CaretBrush), (fun ctx x -> ctx.Element.CaretBrush <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionStart")>] member inline this.SelectionStart ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionStart), (fun ctx x -> ctx.Element.SelectionStart <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)
    [<CustomOperation("SelectionEnd")>] member inline this.SelectionEnd ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionEnd), (fun ctx x -> ctx.Element.SelectionEnd <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type PopupBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.Popup>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("HostEx")>] member inline this.HostEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Host), x)
    [<CustomOperation("HostEx'")>] member inline this.HostEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Host), x)
    [<CustomOperation("Host")>] member inline this.Host ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Host), x)
    [<CustomOperation("Host'")>] member inline this.Host' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Host), x)
    [<CustomOperation("WindowManagerAddShadowHint")>] member inline this.WindowManagerAddShadowHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowManagerAddShadowHint), (fun ctx x -> ctx.Element.WindowManagerAddShadowHint <- x), x)
    [<CustomOperation("WindowManagerAddShadowHint")>] member inline this.WindowManagerAddShadowHint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowManagerAddShadowHint), (fun ctx x -> ctx.Element.WindowManagerAddShadowHint <- x), x)


    member inline _.Yield(creator: ElementCreator<Avalonia>) = creator
    
    member inline this.Combine(creator: ElementCreator<Avalonia>, [<InlineIfLambda>] builder: BuildElement<'Element>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia>) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), fn ())
    
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia>) =
        this.MakeSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.Child <- x), fn ())

    
    member inline _.Yield(creator: ElementCreator<Avalonia> aval) = creator
    
    member inline this.Combine(creator: ElementCreator<Avalonia> aval, [<InlineIfLambda>] builder: BuildElement<'Element>) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
    
    member inline this.For([<InlineIfLambda>] builder: BuildElement<'Element>, [<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia> aval) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), fn ())
                        
    member inline this.Delay([<InlineIfLambda>] fn: unit -> ElementCreator<Avalonia> aval) =
        this.MakeAdaptiveSingleChildBuilder(BuildElement(fun _ i -> i), (fun ctx x -> ctx.Element.Child <- x), fn ())

                        

    [<CustomOperation("Child")>]
    member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)

    [<CustomOperation("Child")>]
    member inline this.Child ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Child <- x), creator)
                        
    [<CustomOperation("DependencyResolver")>] member inline this.DependencyResolver ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.IAvaloniaDependencyResolver) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DependencyResolver), (fun ctx x -> ctx.Element.DependencyResolver <- x), x)
    [<CustomOperation("DependencyResolver")>] member inline this.DependencyResolver ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DependencyResolver), (fun ctx x -> ctx.Element.DependencyResolver <- x), x)
    [<CustomOperation("IsLightDismissEnabled")>] member inline this.IsLightDismissEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsLightDismissEnabled), (fun ctx x -> ctx.Element.IsLightDismissEnabled <- x), x)
    [<CustomOperation("IsLightDismissEnabled")>] member inline this.IsLightDismissEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsLightDismissEnabled), (fun ctx x -> ctx.Element.IsLightDismissEnabled <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("IsOpen")>] member inline this.IsOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpen), (fun ctx x -> ctx.Element.IsOpen <- x), x)
    [<CustomOperation("PlacementAnchor")>] member inline this.PlacementAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementAnchor), (fun ctx x -> ctx.Element.PlacementAnchor <- x), x)
    [<CustomOperation("PlacementAnchor")>] member inline this.PlacementAnchor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementAnchor), (fun ctx x -> ctx.Element.PlacementAnchor <- x), x)
    [<CustomOperation("PlacementConstraintAdjustment")>] member inline this.PlacementConstraintAdjustment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementConstraintAdjustment), (fun ctx x -> ctx.Element.PlacementConstraintAdjustment <- x), x)
    [<CustomOperation("PlacementConstraintAdjustment")>] member inline this.PlacementConstraintAdjustment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementConstraintAdjustment), (fun ctx x -> ctx.Element.PlacementConstraintAdjustment <- x), x)
    [<CustomOperation("PlacementGravity")>] member inline this.PlacementGravity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Primitives.PopupPositioning.PopupGravity) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementGravity), (fun ctx x -> ctx.Element.PlacementGravity <- x), x)
    [<CustomOperation("PlacementGravity")>] member inline this.PlacementGravity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementGravity), (fun ctx x -> ctx.Element.PlacementGravity <- x), x)
    [<CustomOperation("PlacementMode")>] member inline this.PlacementMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.PlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementMode), (fun ctx x -> ctx.Element.PlacementMode <- x), x)
    [<CustomOperation("PlacementMode")>] member inline this.PlacementMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementMode), (fun ctx x -> ctx.Element.PlacementMode <- x), x)
    [<CustomOperation("PlacementRect")>] member inline this.PlacementRect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Nullable<Avalonia.Rect>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRect), (fun ctx x -> ctx.Element.PlacementRect <- x), x)
    [<CustomOperation("PlacementRect")>] member inline this.PlacementRect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlacementRect), (fun ctx x -> ctx.Element.PlacementRect <- x), x)

    [<CustomOperation("PlacementTarget")>]
    member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.PlacementTarget <- x), creator)

    [<CustomOperation("PlacementTarget")>]
    member inline this.PlacementTarget ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.PlacementTarget <- x), creator)
                        
    [<CustomOperation("ObeyScreenEdges")>] member inline this.ObeyScreenEdges ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ObeyScreenEdges), (fun ctx x -> ctx.Element.ObeyScreenEdges <- x), x)
    [<CustomOperation("ObeyScreenEdges")>] member inline this.ObeyScreenEdges ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ObeyScreenEdges), (fun ctx x -> ctx.Element.ObeyScreenEdges <- x), x)
    [<CustomOperation("OverlayDismissEventPassThrough")>] member inline this.OverlayDismissEventPassThrough ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OverlayDismissEventPassThrough), (fun ctx x -> ctx.Element.OverlayDismissEventPassThrough <- x), x)
    [<CustomOperation("OverlayDismissEventPassThrough")>] member inline this.OverlayDismissEventPassThrough ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OverlayDismissEventPassThrough), (fun ctx x -> ctx.Element.OverlayDismissEventPassThrough <- x), x)
    [<CustomOperation("OverlayInputPassThroughElement")>] member inline this.OverlayInputPassThroughElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.IInputElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OverlayInputPassThroughElement), (fun ctx x -> ctx.Element.OverlayInputPassThroughElement <- x), x)
    [<CustomOperation("OverlayInputPassThroughElement")>] member inline this.OverlayInputPassThroughElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OverlayInputPassThroughElement), (fun ctx x -> ctx.Element.OverlayInputPassThroughElement <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("HorizontalOffset")>] member inline this.HorizontalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOffset), (fun ctx x -> ctx.Element.HorizontalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("VerticalOffset")>] member inline this.VerticalOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOffset), (fun ctx x -> ctx.Element.VerticalOffset <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("StaysOpen")>] member inline this.StaysOpen ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StaysOpen), (fun ctx x -> ctx.Element.StaysOpen <- x), x)
    [<CustomOperation("Topmost")>] member inline this.Topmost ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Topmost), (fun ctx x -> ctx.Element.Topmost <- x), x)
    [<CustomOperation("Topmost")>] member inline this.Topmost ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Topmost), (fun ctx x -> ctx.Element.Topmost <- x), x)

    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
                

type TrackBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.Track>() =
    inherit Controls.ControlBuilder<'Element>()

    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("ViewportSize")>] member inline this.ViewportSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ViewportSize), (fun ctx x -> ctx.Element.ViewportSize <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Layout.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

    [<CustomOperation("Thumb")>]
    member inline this.Thumb ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Thumb <- x), creator)

    [<CustomOperation("Thumb")>]
    member inline this.Thumb ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Thumb <- x), creator)
                        

    [<CustomOperation("IncreaseButton")>]
    member inline this.IncreaseButton ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IncreaseButton <- x), creator)

    [<CustomOperation("IncreaseButton")>]
    member inline this.IncreaseButton ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IncreaseButton <- x), creator)
                        

    [<CustomOperation("DecreaseButton")>]
    member inline this.DecreaseButton ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.DecreaseButton <- x), creator)

    [<CustomOperation("DecreaseButton")>]
    member inline this.DecreaseButton ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.DecreaseButton <- x), creator)
                        
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsDirectionReversed")>] member inline this.IsDirectionReversed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDirectionReversed), (fun ctx x -> ctx.Element.IsDirectionReversed <- x), x)
    [<CustomOperation("IsThumbDragHandled")>] member inline this.IsThumbDragHandled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsThumbDragHandled), (fun ctx x -> ctx.Element.IsThumbDragHandled <- x), x)
    [<CustomOperation("IsThumbDragHandled")>] member inline this.IsThumbDragHandled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsThumbDragHandled), (fun ctx x -> ctx.Element.IsThumbDragHandled <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type NativeMenuItemBaseBuilder<'Element when 'Element :> Avalonia.Controls.NativeMenuItemBase>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("Parent")>] member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.NativeMenu) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Parent), (fun ctx x -> ctx.Element.Parent <- x), x)
    [<CustomOperation("Parent")>] member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Parent), (fun ctx x -> ctx.Element.Parent <- x), x)

                

type NativeMenuItemSeparatorBuilder<'Element when 'Element :> Avalonia.Controls.NativeMenuItemSeparator>() =
    inherit Controls.NativeMenuItemBaseBuilder<'Element>()


                

type NativeMenuItemSeperatorBuilder<'Element when 'Element :> Avalonia.Controls.NativeMenuItemSeperator>() =
    inherit Controls.NativeMenuItemSeparatorBuilder<'Element>()


                

type NativeMenuItemBuilder<'Element when 'Element :> Avalonia.Controls.NativeMenuItem>() =
    inherit Controls.NativeMenuItemBaseBuilder<'Element>()

    [<CustomOperation("Menu")>] member inline this.Menu ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.NativeMenu) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Menu), (fun ctx x -> ctx.Element.Menu <- x), x)
    [<CustomOperation("Menu")>] member inline this.Menu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Menu), (fun ctx x -> ctx.Element.Menu <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Media.Imaging.IBitmap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Gesture")>] member inline this.Gesture ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Input.KeyGesture) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Gesture), (fun ctx x -> ctx.Element.Gesture <- x), x)
    [<CustomOperation("Gesture")>] member inline this.Gesture ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Gesture), (fun ctx x -> ctx.Element.Gesture <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("ToggleType")>] member inline this.ToggleType ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.NativeMenuItemToggleType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ToggleType), (fun ctx x -> ctx.Element.ToggleType <- x), x)
    [<CustomOperation("ToggleType")>] member inline this.ToggleType ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ToggleType), (fun ctx x -> ctx.Element.ToggleType <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)

    [<CustomOperation("Click")>] member inline this.Click ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Click), "Click", fn)
    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Clicked), "Clicked", fn)
                

type DefinitionBaseBuilder<'Element when 'Element :> Avalonia.Controls.DefinitionBase>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("SharedSizeGroup")>] member inline this.SharedSizeGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SharedSizeGroup), (fun ctx x -> ctx.Element.SharedSizeGroup <- x), x)
    [<CustomOperation("SharedSizeGroup")>] member inline this.SharedSizeGroup ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SharedSizeGroup), (fun ctx x -> ctx.Element.SharedSizeGroup <- x), x)

                

type ColumnDefinitionBuilder<'Element when 'Element :> Avalonia.Controls.ColumnDefinition>() =
    inherit Controls.DefinitionBaseBuilder<'Element>()

    [<CustomOperation("MaxWidth")>] member inline this.MaxWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxWidth), (fun ctx x -> ctx.Element.MaxWidth <- x), x)
    [<CustomOperation("MaxWidth")>] member inline this.MaxWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxWidth), (fun ctx x -> ctx.Element.MaxWidth <- x), x)
    [<CustomOperation("MinWidth")>] member inline this.MinWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinWidth), (fun ctx x -> ctx.Element.MinWidth <- x), x)
    [<CustomOperation("MinWidth")>] member inline this.MinWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinWidth), (fun ctx x -> ctx.Element.MinWidth <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.GridLength) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)
    [<CustomOperation("Width")>] member inline this.Width ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Width), (fun ctx x -> ctx.Element.Width <- x), x)

                

type RowDefinitionBuilder<'Element when 'Element :> Avalonia.Controls.RowDefinition>() =
    inherit Controls.DefinitionBaseBuilder<'Element>()

    [<CustomOperation("MaxHeight")>] member inline this.MaxHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHeight), (fun ctx x -> ctx.Element.MaxHeight <- x), x)
    [<CustomOperation("MaxHeight")>] member inline this.MaxHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxHeight), (fun ctx x -> ctx.Element.MaxHeight <- x), x)
    [<CustomOperation("MinHeight")>] member inline this.MinHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinHeight), (fun ctx x -> ctx.Element.MinHeight <- x), x)
    [<CustomOperation("MinHeight")>] member inline this.MinHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinHeight), (fun ctx x -> ctx.Element.MinHeight <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.GridLength) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type FlyoutBaseBuilder<'Element when 'Element :> Avalonia.Controls.Primitives.FlyoutBase>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.FlyoutPlacementMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("Placement")>] member inline this.Placement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placement), (fun ctx x -> ctx.Element.Placement <- x), x)
    [<CustomOperation("ShowMode")>] member inline this.ShowMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.FlyoutShowMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowMode), (fun ctx x -> ctx.Element.ShowMode <- x), x)
    [<CustomOperation("ShowMode")>] member inline this.ShowMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowMode), (fun ctx x -> ctx.Element.ShowMode <- x), x)

    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
    [<CustomOperation("Opened")>] member inline this.Opened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opened), "Opened", fn)
    [<CustomOperation("Opening")>] member inline this.Opening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opening), "Opening", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type FlyoutBuilder<'Element when 'Element :> Avalonia.Controls.Flyout>() =
    inherit Controls.Primitives.FlyoutBaseBuilder<'Element>()

    [<CustomOperation("FlyoutPresenterClassesEx")>] member inline this.FlyoutPresenterClassesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("FlyoutPresenterClassesEx'")>] member inline this.FlyoutPresenterClassesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("FlyoutPresenterClasses")>] member inline this.FlyoutPresenterClasses ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("FlyoutPresenterClasses'")>] member inline this.FlyoutPresenterClasses' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)

                

type MenuFlyoutBuilder<'Element when 'Element :> Avalonia.Controls.MenuFlyout>() =
    inherit Controls.Primitives.FlyoutBaseBuilder<'Element>()

    [<CustomOperation("FlyoutPresenterClassesEx")>] member inline this.FlyoutPresenterClassesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("FlyoutPresenterClassesEx'")>] member inline this.FlyoutPresenterClassesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("FlyoutPresenterClasses")>] member inline this.FlyoutPresenterClasses ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("FlyoutPresenterClasses'")>] member inline this.FlyoutPresenterClasses' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FlyoutPresenterClasses), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Items), (fun ctx x -> ctx.Element.Items <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.Templates.IDataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)

                
            
namespace rec Fun.SunUI.Avalonia.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type ApplicationBuilder<'Element when 'Element :> Avalonia.Application>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("DataContext")>] member inline this.DataContext ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DataContext), (fun ctx x -> ctx.Element.DataContext <- x), x)
    [<CustomOperation("DataContext")>] member inline this.DataContext ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DataContext), (fun ctx x -> ctx.Element.DataContext <- x), x)
    [<CustomOperation("DataTemplatesEx")>] member inline this.DataTemplatesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("DataTemplatesEx'")>] member inline this.DataTemplatesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("DataTemplates")>] member inline this.DataTemplates ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("DataTemplates'")>] member inline this.DataTemplates' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.DataTemplates), x)
    [<CustomOperation("FocusManagerEx")>] member inline this.FocusManagerEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FocusManager), x)
    [<CustomOperation("FocusManagerEx'")>] member inline this.FocusManagerEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FocusManager), x)
    [<CustomOperation("FocusManager")>] member inline this.FocusManager ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.FocusManager), x)
    [<CustomOperation("FocusManager'")>] member inline this.FocusManager' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.FocusManager), x)
    [<CustomOperation("InputManagerEx")>] member inline this.InputManagerEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.InputManager), x)
    [<CustomOperation("InputManagerEx'")>] member inline this.InputManagerEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.InputManager), x)
    [<CustomOperation("InputManager")>] member inline this.InputManager ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.InputManager), x)
    [<CustomOperation("InputManager'")>] member inline this.InputManager' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.InputManager), x)
    [<CustomOperation("ClipboardEx")>] member inline this.ClipboardEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Clipboard), x)
    [<CustomOperation("ClipboardEx'")>] member inline this.ClipboardEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Clipboard), x)
    [<CustomOperation("Clipboard")>] member inline this.Clipboard ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Clipboard), x)
    [<CustomOperation("Clipboard'")>] member inline this.Clipboard' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Clipboard), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.IResourceDictionary) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("StylesEx")>] member inline this.StylesEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Styles), x)
    [<CustomOperation("StylesEx'")>] member inline this.StylesEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Styles), x)
    [<CustomOperation("Styles")>] member inline this.Styles ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Styles), x)
    [<CustomOperation("Styles'")>] member inline this.Styles' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Styles), x)
    [<CustomOperation("ApplicationLifetime")>] member inline this.ApplicationLifetime ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.ApplicationLifetimes.IApplicationLifetime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ApplicationLifetime), (fun ctx x -> ctx.Element.ApplicationLifetime <- x), x)
    [<CustomOperation("ApplicationLifetime")>] member inline this.ApplicationLifetime ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ApplicationLifetime), (fun ctx x -> ctx.Element.ApplicationLifetime <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)
    [<CustomOperation("Name")>] member inline this.Name ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Name), (fun ctx x -> ctx.Element.Name <- x), x)

    [<CustomOperation("ResourcesChanged")>] member inline this.ResourcesChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ResourcesChanged), "ResourcesChanged", fn)
    [<CustomOperation("UrlsOpened")>] member inline this.UrlsOpened ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.UrlsOpened), "UrlsOpened", fn)
                
            
namespace rec Fun.SunUI.Avalonia.DslInternals.Controls

open FSharp.Data.Adaptive
open Fun.SunUI.Avalonia.DslInternals
open Fun.SunUI
open Fun.SunUI.Avalonia


type NativeMenuBuilder<'Element when 'Element :> Avalonia.Controls.NativeMenu>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("ItemsEx")>] member inline this.ItemsEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsEx'")>] member inline this.ItemsEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.Items), x)
    [<CustomOperation("Parent")>] member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.NativeMenuItem) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Parent), (fun ctx x -> ctx.Element.Parent <- x), x)
    [<CustomOperation("Parent")>] member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Parent), (fun ctx x -> ctx.Element.Parent <- x), x)

    [<CustomOperation("NeedsUpdate")>] member inline this.NeedsUpdate ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NeedsUpdate), "NeedsUpdate", fn)
    [<CustomOperation("Opening")>] member inline this.Opening ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Opening), "Opening", fn)
    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
                

type SplitViewTemplateSettingsBuilder<'Element when 'Element :> Avalonia.Controls.SplitViewTemplateSettings>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("PaneColumnGridLengthEx")>] member inline this.PaneColumnGridLengthEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.PaneColumnGridLength), x)
    [<CustomOperation("PaneColumnGridLengthEx'")>] member inline this.PaneColumnGridLengthEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.PaneColumnGridLength), x)
    [<CustomOperation("PaneColumnGridLength")>] member inline this.PaneColumnGridLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.PaneColumnGridLength), x)
    [<CustomOperation("PaneColumnGridLength'")>] member inline this.PaneColumnGridLength' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.PaneColumnGridLength), x)

                

type TrayIconBuilder<'Element when 'Element :> Avalonia.Controls.TrayIcon>() =
    inherit AvaloniaObjectBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("Menu")>] member inline this.Menu ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.NativeMenu) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Menu), (fun ctx x -> ctx.Element.Menu <- x), x)
    [<CustomOperation("Menu")>] member inline this.Menu ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Menu), (fun ctx x -> ctx.Element.Menu <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Avalonia.Controls.WindowIcon) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("Icon")>] member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Icon), (fun ctx x -> ctx.Element.Icon <- x), x)
    [<CustomOperation("ToolTipText")>] member inline this.ToolTipText ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ToolTipText), (fun ctx x -> ctx.Element.ToolTipText <- x), x)
    [<CustomOperation("ToolTipText")>] member inline this.ToolTipText ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ToolTipText), (fun ctx x -> ctx.Element.ToolTipText <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("NativeMenuExporterEx")>] member inline this.NativeMenuExporterEx ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NativeMenuExporter), x)
    [<CustomOperation("NativeMenuExporterEx'")>] member inline this.NativeMenuExporterEx' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NativeMenuExporter), x)
    [<CustomOperation("NativeMenuExporter")>] member inline this.NativeMenuExporter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder1(builder, (fun x -> x.NativeMenuExporter), x)
    [<CustomOperation("NativeMenuExporter'")>] member inline this.NativeMenuExporter' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder1(builder, (fun x -> x.NativeMenuExporter), x)

    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Clicked), "Clicked", fn)
                
            

// =======================================================================================================================

namespace Fun.SunUI.Avalonia

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_Avalonia =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals

    type AvaloniaObject' () = 
        inherit AvaloniaObjectBuilder<Avalonia.AvaloniaObject>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.AvaloniaObject>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.AvaloniaObject()), this.GetRenderMode())

    type StyledElement' () = 
        inherit StyledElementBuilder<Avalonia.StyledElement>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.StyledElement>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.StyledElement()), this.GetRenderMode())

    type Visual' () = 
        inherit VisualBuilder<Avalonia.Visual>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Visual>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Visual()), this.GetRenderMode())

    type Application' () = 
        inherit ApplicationBuilder<Avalonia.Application>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Application>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Application()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Animation

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaAnimation =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Animation

    type Animatable' () = 
        inherit AnimatableBuilder<Avalonia.Animation.Animatable>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Animation.Animatable>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Animation.Animatable()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Layout

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaLayout =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Layout

    type Layoutable' () = 
        inherit LayoutableBuilder<Avalonia.Layout.Layoutable>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Layout.Layoutable>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Layout.Layoutable()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Interactivity

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaInteractivity =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Interactivity

    type Interactive' () = 
        inherit InteractiveBuilder<Avalonia.Interactivity.Interactive>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Interactivity.Interactive>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Interactivity.Interactive()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Input

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaInput =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Input

    type InputElement' () = 
        inherit InputElementBuilder<Avalonia.Input.InputElement>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Input.InputElement>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Input.InputElement()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControls =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls

    type Control' () = 
        inherit ControlBuilder<Avalonia.Controls.Control>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Control>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Control()), this.GetRenderMode())

    type ContentControl' () = 
        inherit ContentControlBuilder<Avalonia.Controls.ContentControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ContentControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ContentControl()), this.GetRenderMode())

    type Button' () = 
        inherit ButtonBuilder<Avalonia.Controls.Button>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Button>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Button()), this.GetRenderMode())

    type CheckBox' () = 
        inherit CheckBoxBuilder<Avalonia.Controls.CheckBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.CheckBox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.CheckBox()), this.GetRenderMode())

    type RadioButton' () = 
        inherit RadioButtonBuilder<Avalonia.Controls.RadioButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.RadioButton>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.RadioButton()), this.GetRenderMode())

    type ToggleSwitch' () = 
        inherit ToggleSwitchBuilder<Avalonia.Controls.ToggleSwitch>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ToggleSwitch>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ToggleSwitch()), this.GetRenderMode())

    type RepeatButton' () = 
        inherit RepeatButtonBuilder<Avalonia.Controls.RepeatButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.RepeatButton>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.RepeatButton()), this.GetRenderMode())

    type ListBoxItem' () = 
        inherit ListBoxItemBuilder<Avalonia.Controls.ListBoxItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ListBoxItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ListBoxItem()), this.GetRenderMode())

    type ComboBoxItem' () = 
        inherit ComboBoxItemBuilder<Avalonia.Controls.ComboBoxItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ComboBoxItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ComboBoxItem()), this.GetRenderMode())

    type DropDownItem' () = 
        inherit DropDownItemBuilder<Avalonia.Controls.DropDownItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DropDownItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DropDownItem()), this.GetRenderMode())

    type Window' () = 
        inherit WindowBuilder<Avalonia.Controls.Window>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Window>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Window()), this.GetRenderMode())

    type ButtonSpinner' () = 
        inherit ButtonSpinnerBuilder<Avalonia.Controls.ButtonSpinner>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ButtonSpinner>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ButtonSpinner()), this.GetRenderMode())

    type Expander' () = 
        inherit ExpanderBuilder<Avalonia.Controls.Expander>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Expander>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Expander()), this.GetRenderMode())

    type TabItem' () = 
        inherit TabItemBuilder<Avalonia.Controls.TabItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TabItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TabItem()), this.GetRenderMode())

    type DataValidationErrors' () = 
        inherit DataValidationErrorsBuilder<Avalonia.Controls.DataValidationErrors>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DataValidationErrors>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DataValidationErrors()), this.GetRenderMode())

    type FlyoutPresenter' () = 
        inherit FlyoutPresenterBuilder<Avalonia.Controls.FlyoutPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.FlyoutPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.FlyoutPresenter()), this.GetRenderMode())

    type Label' () = 
        inherit LabelBuilder<Avalonia.Controls.Label>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Label>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Label()), this.GetRenderMode())

    type ScrollViewer' () = 
        inherit ScrollViewerBuilder<Avalonia.Controls.ScrollViewer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ScrollViewer>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ScrollViewer()), this.GetRenderMode())

    type SplitView' () = 
        inherit SplitViewBuilder<Avalonia.Controls.SplitView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.SplitView>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.SplitView()), this.GetRenderMode())

    type ToolTip' () = 
        inherit ToolTipBuilder<Avalonia.Controls.ToolTip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ToolTip>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ToolTip()), this.GetRenderMode())

    type TransitioningContentControl' () = 
        inherit TransitioningContentControlBuilder<Avalonia.Controls.TransitioningContentControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TransitioningContentControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TransitioningContentControl()), this.GetRenderMode())

    type UserControl' () = 
        inherit UserControlBuilder<Avalonia.Controls.UserControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.UserControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.UserControl()), this.GetRenderMode())

    type ItemsControl' () = 
        inherit ItemsControlBuilder<Avalonia.Controls.ItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ItemsControl()), this.GetRenderMode())

    type ContextMenu' () = 
        inherit ContextMenuBuilder<Avalonia.Controls.ContextMenu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ContextMenu>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ContextMenu()), this.GetRenderMode())

    type MenuFlyoutPresenter' () = 
        inherit MenuFlyoutPresenterBuilder<Avalonia.Controls.MenuFlyoutPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.MenuFlyoutPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.MenuFlyoutPresenter()), this.GetRenderMode())

    type Menu' () = 
        inherit MenuBuilder<Avalonia.Controls.Menu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Menu>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Menu()), this.GetRenderMode())

    type ComboBox' () = 
        inherit ComboBoxBuilder<Avalonia.Controls.ComboBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ComboBox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ComboBox()), this.GetRenderMode())

    type DropDown' () = 
        inherit DropDownBuilder<Avalonia.Controls.DropDown>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DropDown>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DropDown()), this.GetRenderMode())

    type MenuItem' () = 
        inherit MenuItemBuilder<Avalonia.Controls.MenuItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.MenuItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.MenuItem()), this.GetRenderMode())

    type Carousel' () = 
        inherit CarouselBuilder<Avalonia.Controls.Carousel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Carousel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Carousel()), this.GetRenderMode())

    type ListBox' () = 
        inherit ListBoxBuilder<Avalonia.Controls.ListBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ListBox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ListBox()), this.GetRenderMode())

    type TabControl' () = 
        inherit TabControlBuilder<Avalonia.Controls.TabControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TabControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TabControl()), this.GetRenderMode())

    type TreeViewItem' () = 
        inherit TreeViewItemBuilder<Avalonia.Controls.TreeViewItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TreeViewItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TreeViewItem()), this.GetRenderMode())

    type TreeView' () = 
        inherit TreeViewBuilder<Avalonia.Controls.TreeView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TreeView>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TreeView()), this.GetRenderMode())

    type DatePickerPresenter' () = 
        inherit DatePickerPresenterBuilder<Avalonia.Controls.DatePickerPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DatePickerPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DatePickerPresenter()), this.GetRenderMode())

    type TimePickerPresenter' () = 
        inherit TimePickerPresenterBuilder<Avalonia.Controls.TimePickerPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TimePickerPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TimePickerPresenter()), this.GetRenderMode())

    type GridSplitter' () = 
        inherit GridSplitterBuilder<Avalonia.Controls.GridSplitter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.GridSplitter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.GridSplitter()), this.GetRenderMode())

    type TextBox' () = 
        inherit TextBoxBuilder<Avalonia.Controls.TextBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TextBox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TextBox()), this.GetRenderMode())

    type MaskedTextBox' () = 
        inherit MaskedTextBoxBuilder<Avalonia.Controls.MaskedTextBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.MaskedTextBox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.MaskedTextBox()), this.GetRenderMode())

    type PathIcon' () = 
        inherit PathIconBuilder<Avalonia.Controls.PathIcon>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.PathIcon>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.PathIcon()), this.GetRenderMode())

    type ProgressBar' () = 
        inherit ProgressBarBuilder<Avalonia.Controls.ProgressBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ProgressBar>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ProgressBar()), this.GetRenderMode())

    type Slider' () = 
        inherit SliderBuilder<Avalonia.Controls.Slider>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Slider>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Slider()), this.GetRenderMode())

    type AutoCompleteBox' () = 
        inherit AutoCompleteBoxBuilder<Avalonia.Controls.AutoCompleteBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.AutoCompleteBox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.AutoCompleteBox()), this.GetRenderMode())

    type Calendar' () = 
        inherit CalendarBuilder<Avalonia.Controls.Calendar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Calendar>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Calendar()), this.GetRenderMode())

    type CalendarDatePicker' () = 
        inherit CalendarDatePickerBuilder<Avalonia.Controls.CalendarDatePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.CalendarDatePicker>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.CalendarDatePicker()), this.GetRenderMode())

    type DatePicker' () = 
        inherit DatePickerBuilder<Avalonia.Controls.DatePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DatePicker>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DatePicker()), this.GetRenderMode())

    type TimePicker' () = 
        inherit TimePickerBuilder<Avalonia.Controls.TimePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TimePicker>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TimePicker()), this.GetRenderMode())

    type NativeMenuBar' () = 
        inherit NativeMenuBarBuilder<Avalonia.Controls.NativeMenuBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NativeMenuBar>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NativeMenuBar()), this.GetRenderMode())

    type NumericUpDown' () = 
        inherit NumericUpDownBuilder<Avalonia.Controls.NumericUpDown>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NumericUpDown>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NumericUpDown()), this.GetRenderMode())

    type Separator' () = 
        inherit SeparatorBuilder<Avalonia.Controls.Separator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Separator>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Separator()), this.GetRenderMode())

    type Panel' () = 
        inherit PanelBuilder<Avalonia.Controls.Panel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Panel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Panel()), this.GetRenderMode())

    type StackPanel' () = 
        inherit StackPanelBuilder<Avalonia.Controls.StackPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.StackPanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.StackPanel()), this.GetRenderMode())

    type ReversibleStackPanel' () = 
        inherit ReversibleStackPanelBuilder<Avalonia.Controls.ReversibleStackPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ReversibleStackPanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ReversibleStackPanel()), this.GetRenderMode())

    type VirtualizingStackPanel' () = 
        inherit VirtualizingStackPanelBuilder<Avalonia.Controls.VirtualizingStackPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.VirtualizingStackPanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.VirtualizingStackPanel()), this.GetRenderMode())

    type Canvas' () = 
        inherit CanvasBuilder<Avalonia.Controls.Canvas>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Canvas>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Canvas()), this.GetRenderMode())

    type DockPanel' () = 
        inherit DockPanelBuilder<Avalonia.Controls.DockPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DockPanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DockPanel()), this.GetRenderMode())

    type Grid' () = 
        inherit GridBuilder<Avalonia.Controls.Grid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Grid>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Grid()), this.GetRenderMode())

    type RelativePanel' () = 
        inherit RelativePanelBuilder<Avalonia.Controls.RelativePanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.RelativePanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.RelativePanel()), this.GetRenderMode())

    type ItemsRepeater' () = 
        inherit ItemsRepeaterBuilder<Avalonia.Controls.ItemsRepeater>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ItemsRepeater>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ItemsRepeater()), this.GetRenderMode())

    type WrapPanel' () = 
        inherit WrapPanelBuilder<Avalonia.Controls.WrapPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.WrapPanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.WrapPanel()), this.GetRenderMode())

    type Decorator' () = 
        inherit DecoratorBuilder<Avalonia.Controls.Decorator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Decorator>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Decorator()), this.GetRenderMode())

    type Border' () = 
        inherit BorderBuilder<Avalonia.Controls.Border>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Border>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Border()), this.GetRenderMode())

    type ExperimentalAcrylicBorder' () = 
        inherit ExperimentalAcrylicBorderBuilder<Avalonia.Controls.ExperimentalAcrylicBorder>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ExperimentalAcrylicBorder>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ExperimentalAcrylicBorder()), this.GetRenderMode())

    type LayoutTransformControl' () = 
        inherit LayoutTransformControlBuilder<Avalonia.Controls.LayoutTransformControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.LayoutTransformControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.LayoutTransformControl()), this.GetRenderMode())

    type Viewbox' () = 
        inherit ViewboxBuilder<Avalonia.Controls.Viewbox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Viewbox>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Viewbox()), this.GetRenderMode())

    type TextBlock' () = 
        inherit TextBlockBuilder<Avalonia.Controls.TextBlock>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TextBlock>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TextBlock()), this.GetRenderMode())

    type DrawingPresenter' () = 
        inherit DrawingPresenterBuilder<Avalonia.Controls.DrawingPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.DrawingPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.DrawingPresenter()), this.GetRenderMode())

    type Image' () = 
        inherit ImageBuilder<Avalonia.Controls.Image>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Image>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Image()), this.GetRenderMode())

    type NativeControlHost' () = 
        inherit NativeControlHostBuilder<Avalonia.Controls.NativeControlHost>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NativeControlHost>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NativeControlHost()), this.GetRenderMode())

    type TickBar' () = 
        inherit TickBarBuilder<Avalonia.Controls.TickBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TickBar>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TickBar()), this.GetRenderMode())

    type NativeMenuItemSeparator' () = 
        inherit NativeMenuItemSeparatorBuilder<Avalonia.Controls.NativeMenuItemSeparator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NativeMenuItemSeparator>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NativeMenuItemSeparator()), this.GetRenderMode())

    type NativeMenuItemSeperator' () = 
        inherit NativeMenuItemSeperatorBuilder<Avalonia.Controls.NativeMenuItemSeperator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NativeMenuItemSeperator>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NativeMenuItemSeperator()), this.GetRenderMode())

    type NativeMenuItem' () = 
        inherit NativeMenuItemBuilder<Avalonia.Controls.NativeMenuItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NativeMenuItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NativeMenuItem()), this.GetRenderMode())

    type ColumnDefinition' () = 
        inherit ColumnDefinitionBuilder<Avalonia.Controls.ColumnDefinition>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.ColumnDefinition>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.ColumnDefinition()), this.GetRenderMode())

    type RowDefinition' () = 
        inherit RowDefinitionBuilder<Avalonia.Controls.RowDefinition>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.RowDefinition>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.RowDefinition()), this.GetRenderMode())

    type Flyout' () = 
        inherit FlyoutBuilder<Avalonia.Controls.Flyout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Flyout>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Flyout()), this.GetRenderMode())

    type MenuFlyout' () = 
        inherit MenuFlyoutBuilder<Avalonia.Controls.MenuFlyout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.MenuFlyout>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.MenuFlyout()), this.GetRenderMode())

    type NativeMenu' () = 
        inherit NativeMenuBuilder<Avalonia.Controls.NativeMenu>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.NativeMenu>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.NativeMenu()), this.GetRenderMode())

    type TrayIcon' () = 
        inherit TrayIconBuilder<Avalonia.Controls.TrayIcon>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.TrayIcon>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.TrayIcon()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Primitives

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsPrimitives =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Primitives

    type TemplatedControl' () = 
        inherit TemplatedControlBuilder<Avalonia.Controls.Primitives.TemplatedControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.TemplatedControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.TemplatedControl()), this.GetRenderMode())

    type ToggleButton' () = 
        inherit ToggleButtonBuilder<Avalonia.Controls.Primitives.ToggleButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.ToggleButton>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.ToggleButton()), this.GetRenderMode())

    type CalendarButton' () = 
        inherit CalendarButtonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarButton>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.CalendarButton()), this.GetRenderMode())

    type CalendarDayButton' () = 
        inherit CalendarDayButtonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarDayButton>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.CalendarDayButton()), this.GetRenderMode())

    type TabStripItem' () = 
        inherit TabStripItemBuilder<Avalonia.Controls.Primitives.TabStripItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.TabStripItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.TabStripItem()), this.GetRenderMode())

    type HeaderedContentControl' () = 
        inherit HeaderedContentControlBuilder<Avalonia.Controls.Primitives.HeaderedContentControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.HeaderedContentControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.HeaderedContentControl()), this.GetRenderMode())

    type SelectingItemsControl' () = 
        inherit SelectingItemsControlBuilder<Avalonia.Controls.Primitives.SelectingItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.SelectingItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.SelectingItemsControl()), this.GetRenderMode())

    type HeaderedSelectingItemsControl' () = 
        inherit HeaderedSelectingItemsControlBuilder<Avalonia.Controls.Primitives.HeaderedSelectingItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.HeaderedSelectingItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.HeaderedSelectingItemsControl()), this.GetRenderMode())

    type TabStrip' () = 
        inherit TabStripBuilder<Avalonia.Controls.Primitives.TabStrip>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.TabStrip>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.TabStrip()), this.GetRenderMode())

    type HeaderedItemsControl' () = 
        inherit HeaderedItemsControlBuilder<Avalonia.Controls.Primitives.HeaderedItemsControl>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.HeaderedItemsControl>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.HeaderedItemsControl()), this.GetRenderMode())

    type Thumb' () = 
        inherit ThumbBuilder<Avalonia.Controls.Primitives.Thumb>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.Thumb>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.Thumb()), this.GetRenderMode())

    type ScrollBar' () = 
        inherit ScrollBarBuilder<Avalonia.Controls.Primitives.ScrollBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.ScrollBar>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.ScrollBar()), this.GetRenderMode())

    type CalendarItem' () = 
        inherit CalendarItemBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.CalendarItem>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.CalendarItem()), this.GetRenderMode())

    type AdornerLayer' () = 
        inherit AdornerLayerBuilder<Avalonia.Controls.Primitives.AdornerLayer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.AdornerLayer>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.AdornerLayer()), this.GetRenderMode())

    type OverlayLayer' () = 
        inherit OverlayLayerBuilder<Avalonia.Controls.Primitives.OverlayLayer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.OverlayLayer>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.OverlayLayer()), this.GetRenderMode())

    type DateTimePickerPanel' () = 
        inherit DateTimePickerPanelBuilder<Avalonia.Controls.Primitives.DateTimePickerPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.DateTimePickerPanel>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.DateTimePickerPanel()), this.GetRenderMode())

    type ChromeOverlayLayer' () = 
        inherit ChromeOverlayLayerBuilder<Avalonia.Controls.Primitives.ChromeOverlayLayer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.ChromeOverlayLayer>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.ChromeOverlayLayer()), this.GetRenderMode())

    type UniformGrid' () = 
        inherit UniformGridBuilder<Avalonia.Controls.Primitives.UniformGrid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.UniformGrid>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.UniformGrid()), this.GetRenderMode())

    type LightDismissOverlayLayer' () = 
        inherit LightDismissOverlayLayerBuilder<Avalonia.Controls.Primitives.LightDismissOverlayLayer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.LightDismissOverlayLayer>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.LightDismissOverlayLayer()), this.GetRenderMode())

    type VisualLayerManager' () = 
        inherit VisualLayerManagerBuilder<Avalonia.Controls.Primitives.VisualLayerManager>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.VisualLayerManager>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.VisualLayerManager()), this.GetRenderMode())

    type AccessText' () = 
        inherit AccessTextBuilder<Avalonia.Controls.Primitives.AccessText>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.AccessText>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.AccessText()), this.GetRenderMode())

    type Popup' () = 
        inherit PopupBuilder<Avalonia.Controls.Primitives.Popup>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.Popup>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.Popup()), this.GetRenderMode())

    type Track' () = 
        inherit TrackBuilder<Avalonia.Controls.Primitives.Track>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Primitives.Track>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Primitives.Track()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Embedding

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsEmbedding =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Embedding

    type EmbeddableControlRoot' () = 
        inherit EmbeddableControlRootBuilder<Avalonia.Controls.Embedding.EmbeddableControlRoot>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Embedding.EmbeddableControlRoot>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Embedding.EmbeddableControlRoot()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Notifications

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsNotifications =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Notifications

    type NotificationCard' () = 
        inherit NotificationCardBuilder<Avalonia.Controls.Notifications.NotificationCard>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Notifications.NotificationCard>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Notifications.NotificationCard()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Chrome

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsChrome =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Chrome

    type CaptionButtons' () = 
        inherit CaptionButtonsBuilder<Avalonia.Controls.Chrome.CaptionButtons>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Chrome.CaptionButtons>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Chrome.CaptionButtons()), this.GetRenderMode())

    type TitleBar' () = 
        inherit TitleBarBuilder<Avalonia.Controls.Chrome.TitleBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Chrome.TitleBar>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Chrome.TitleBar()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Shapes

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsShapes =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Shapes

    type Arc' () = 
        inherit ArcBuilder<Avalonia.Controls.Shapes.Arc>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Arc>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Arc()), this.GetRenderMode())

    type Ellipse' () = 
        inherit EllipseBuilder<Avalonia.Controls.Shapes.Ellipse>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Ellipse>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Ellipse()), this.GetRenderMode())

    type Line' () = 
        inherit LineBuilder<Avalonia.Controls.Shapes.Line>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Line>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Line()), this.GetRenderMode())

    type Path' () = 
        inherit PathBuilder<Avalonia.Controls.Shapes.Path>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Path>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Path()), this.GetRenderMode())

    type Polygon' () = 
        inherit PolygonBuilder<Avalonia.Controls.Shapes.Polygon>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Polygon>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Polygon()), this.GetRenderMode())

    type Polyline' () = 
        inherit PolylineBuilder<Avalonia.Controls.Shapes.Polyline>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Polyline>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Polyline()), this.GetRenderMode())

    type Rectangle' () = 
        inherit RectangleBuilder<Avalonia.Controls.Shapes.Rectangle>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Shapes.Rectangle>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Shapes.Rectangle()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Presenters

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsPresenters =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Presenters

    type CarouselPresenter' () = 
        inherit CarouselPresenterBuilder<Avalonia.Controls.Presenters.CarouselPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Presenters.CarouselPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Presenters.CarouselPresenter()), this.GetRenderMode())

    type ItemsPresenter' () = 
        inherit ItemsPresenterBuilder<Avalonia.Controls.Presenters.ItemsPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Presenters.ItemsPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Presenters.ItemsPresenter()), this.GetRenderMode())

    type ContentPresenter' () = 
        inherit ContentPresenterBuilder<Avalonia.Controls.Presenters.ContentPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Presenters.ContentPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Presenters.ContentPresenter()), this.GetRenderMode())

    type ScrollContentPresenter' () = 
        inherit ScrollContentPresenterBuilder<Avalonia.Controls.Presenters.ScrollContentPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Presenters.ScrollContentPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Presenters.ScrollContentPresenter()), this.GetRenderMode())

    type TextPresenter' () = 
        inherit TextPresenterBuilder<Avalonia.Controls.Presenters.TextPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Avalonia.Controls.Presenters.TextPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Avalonia.Controls.Presenters.TextPresenter()), this.GetRenderMode())

            
namespace Fun.SunUI.Avalonia.Controls.Remote

[<AutoOpen>]
module AvaloniaElementBuilderDslCE_AvaloniaControlsRemote =
  
    open Fun.SunUI
    open Fun.SunUI.Avalonia.DslInternals.Controls.Remote


            