namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type PanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Panel>() =
    inherit WinUIPanelBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("BackgroundTransition")>] member inline this.BackgroundTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.BrushTransition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundTransition), (fun ctx x -> ctx.Element.BackgroundTransition <- x), x)
    [<CustomOperation("BackgroundTransition")>] member inline this.BackgroundTransition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundTransition), (fun ctx x -> ctx.Element.BackgroundTransition <- x), x)
    [<CustomOperation("ChildrenTransitions")>] member inline this.ChildrenTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Animation.TransitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ChildrenTransitions), (fun ctx x -> ctx.Element.ChildrenTransitions <- x), x)
    [<CustomOperation("ChildrenTransitions")>] member inline this.ChildrenTransitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ChildrenTransitions), (fun ctx x -> ctx.Element.ChildrenTransitions <- x), x)

                

type VirtualizingPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.VirtualizingPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type OrientedVirtualizingPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel>() =
    inherit VirtualizingPanelBuilder<'Element>()

    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)

    [<CustomOperation("HorizontalSnapPointsChanged")>] member inline this.HorizontalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsChanged), "HorizontalSnapPointsChanged", fn)
    [<CustomOperation("VerticalSnapPointsChanged")>] member inline this.VerticalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsChanged), "VerticalSnapPointsChanged", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type VirtualizingStackPanelBuilder() =
    inherit Primitives.OrientedVirtualizingPanelBuilder<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>()

    [<CustomOperation("AreScrollSnapPointsRegular")>] member inline this.AreScrollSnapPointsRegular ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AreScrollSnapPointsRegular), (fun ctx x -> ctx.Element.AreScrollSnapPointsRegular <- x), x)
    [<CustomOperation("AreScrollSnapPointsRegular")>] member inline this.AreScrollSnapPointsRegular ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AreScrollSnapPointsRegular), (fun ctx x -> ctx.Element.AreScrollSnapPointsRegular <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

    [<CustomOperation("CleanUpVirtualizedItemEvent")>] member inline this.CleanUpVirtualizedItemEvent ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CleanUpVirtualizedItemEvent), "CleanUpVirtualizedItemEvent", fn)
                

type WrapGridBuilder() =
    inherit Primitives.OrientedVirtualizingPanelBuilder<Microsoft.UI.Xaml.Controls.WrapGrid>()

    [<CustomOperation("HorizontalChildrenAlignment")>] member inline this.HorizontalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x: Microsoft.UI.Xaml.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalChildrenAlignment), (fun ctx x -> ctx.Element.HorizontalChildrenAlignment <- x), x)
    [<CustomOperation("HorizontalChildrenAlignment")>] member inline this.HorizontalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalChildrenAlignment), (fun ctx x -> ctx.Element.HorizontalChildrenAlignment <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("MaximumRowsOrColumns")>] member inline this.MaximumRowsOrColumns ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumRowsOrColumns), (fun ctx x -> ctx.Element.MaximumRowsOrColumns <- x), x)
    [<CustomOperation("MaximumRowsOrColumns")>] member inline this.MaximumRowsOrColumns ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumRowsOrColumns), (fun ctx x -> ctx.Element.MaximumRowsOrColumns <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("VerticalChildrenAlignment")>] member inline this.VerticalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x: Microsoft.UI.Xaml.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalChildrenAlignment), (fun ctx x -> ctx.Element.VerticalChildrenAlignment <- x), x)
    [<CustomOperation("VerticalChildrenAlignment")>] member inline this.VerticalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalChildrenAlignment), (fun ctx x -> ctx.Element.VerticalChildrenAlignment <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type CarouselPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel>() =
    inherit VirtualizingPanelBuilder<'Element>()

    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)

    [<CustomOperation("HorizontalSnapPointsChanged")>] member inline this.HorizontalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsChanged), "HorizontalSnapPointsChanged", fn)
    [<CustomOperation("VerticalSnapPointsChanged")>] member inline this.VerticalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsChanged), "VerticalSnapPointsChanged", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type GridBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Grid>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.BackgroundSizing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ColumnDefinitions), x)
    [<CustomOperation("ColumnDefinitions'")>] member inline this.ColumnDefinitions' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ColumnDefinitions), x)
    [<CustomOperation("ColumnSpacing")>] member inline this.ColumnSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnSpacing), (fun ctx x -> ctx.Element.ColumnSpacing <- x), x)
    [<CustomOperation("ColumnSpacing")>] member inline this.ColumnSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnSpacing), (fun ctx x -> ctx.Element.ColumnSpacing <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RowDefinitions), x)
    [<CustomOperation("RowDefinitions'")>] member inline this.RowDefinitions' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RowDefinitions), x)
    [<CustomOperation("RowSpacing")>] member inline this.RowSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowSpacing), (fun ctx x -> ctx.Element.RowSpacing <- x), x)
    [<CustomOperation("RowSpacing")>] member inline this.RowSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowSpacing), (fun ctx x -> ctx.Element.RowSpacing <- x), x)

                

type SwapChainBackgroundPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.SwapChainBackgroundPanel>() =
    inherit GridBuilder<'Element>()


                

type SwapChainPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.SwapChainPanel>() =
    inherit GridBuilder<'Element>()


    [<CustomOperation("CompositionScaleChanged")>] member inline this.CompositionScaleChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CompositionScaleChanged), "CompositionScaleChanged", fn)
                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type MonochromaticOverlayPresenterBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.MonochromaticOverlayPresenter>() =
    inherit GridBuilder<'Element>()

    [<CustomOperation("ReplacementColor")>] member inline this.ReplacementColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Windows.UI.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReplacementColor), (fun ctx x -> ctx.Element.ReplacementColor <- x), x)
    [<CustomOperation("ReplacementColor")>] member inline this.ReplacementColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReplacementColor), (fun ctx x -> ctx.Element.ReplacementColor <- x), x)
    [<CustomOperation("SourceElement")>] member inline this.SourceElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.UIElement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SourceElement), (fun ctx x -> ctx.Element.SourceElement <- x), x)
    [<CustomOperation("SourceElement")>] member inline this.SourceElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SourceElement), (fun ctx x -> ctx.Element.SourceElement <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type CanvasBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Canvas>() =
    inherit PanelBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type LoopingSelectorPanelBuilder() =
    inherit CanvasBuilder<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel>()


    [<CustomOperation("HorizontalSnapPointsChanged")>] member inline this.HorizontalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsChanged), "HorizontalSnapPointsChanged", fn)
    [<CustomOperation("VerticalSnapPointsChanged")>] member inline this.VerticalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsChanged), "VerticalSnapPointsChanged", fn)
                

type PivotHeaderPanelBuilder() =
    inherit CanvasBuilder<Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderPanel>()


                
            
namespace rec Fun.SunUI.WinUI.DslInternals
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type ItemsStackPanelBuilder() =
    inherit PanelBuilder<Microsoft.UI.Xaml.Controls.ItemsStackPanel>()

    [<CustomOperation("AreStickyGroupHeadersEnabled")>] member inline this.AreStickyGroupHeadersEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AreStickyGroupHeadersEnabled), (fun ctx x -> ctx.Element.AreStickyGroupHeadersEnabled <- x), x)
    [<CustomOperation("AreStickyGroupHeadersEnabled")>] member inline this.AreStickyGroupHeadersEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AreStickyGroupHeadersEnabled), (fun ctx x -> ctx.Element.AreStickyGroupHeadersEnabled <- x), x)
    [<CustomOperation("CacheLength")>] member inline this.CacheLength ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CacheLength), (fun ctx x -> ctx.Element.CacheLength <- x), x)
    [<CustomOperation("CacheLength")>] member inline this.CacheLength ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CacheLength), (fun ctx x -> ctx.Element.CacheLength <- x), x)
    [<CustomOperation("GroupHeaderPlacement")>] member inline this.GroupHeaderPlacement ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x: Microsoft.UI.Xaml.Controls.Primitives.GroupHeaderPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderPlacement), (fun ctx x -> ctx.Element.GroupHeaderPlacement <- x), x)
    [<CustomOperation("GroupHeaderPlacement")>] member inline this.GroupHeaderPlacement ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderPlacement), (fun ctx x -> ctx.Element.GroupHeaderPlacement <- x), x)
    [<CustomOperation("GroupPadding")>] member inline this.GroupPadding ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupPadding), (fun ctx x -> ctx.Element.GroupPadding <- x), x)
    [<CustomOperation("GroupPadding")>] member inline this.GroupPadding ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupPadding), (fun ctx x -> ctx.Element.GroupPadding <- x), x)
    [<CustomOperation("ItemsUpdatingScrollMode")>] member inline this.ItemsUpdatingScrollMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x: Microsoft.UI.Xaml.Controls.ItemsUpdatingScrollMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsUpdatingScrollMode), (fun ctx x -> ctx.Element.ItemsUpdatingScrollMode <- x), x)
    [<CustomOperation("ItemsUpdatingScrollMode")>] member inline this.ItemsUpdatingScrollMode ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsUpdatingScrollMode), (fun ctx x -> ctx.Element.ItemsUpdatingScrollMode <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type ItemsWrapGridBuilder() =
    inherit PanelBuilder<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>()

    [<CustomOperation("AreStickyGroupHeadersEnabled")>] member inline this.AreStickyGroupHeadersEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AreStickyGroupHeadersEnabled), (fun ctx x -> ctx.Element.AreStickyGroupHeadersEnabled <- x), x)
    [<CustomOperation("AreStickyGroupHeadersEnabled")>] member inline this.AreStickyGroupHeadersEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AreStickyGroupHeadersEnabled), (fun ctx x -> ctx.Element.AreStickyGroupHeadersEnabled <- x), x)
    [<CustomOperation("CacheLength")>] member inline this.CacheLength ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CacheLength), (fun ctx x -> ctx.Element.CacheLength <- x), x)
    [<CustomOperation("CacheLength")>] member inline this.CacheLength ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CacheLength), (fun ctx x -> ctx.Element.CacheLength <- x), x)
    [<CustomOperation("GroupHeaderPlacement")>] member inline this.GroupHeaderPlacement ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: Microsoft.UI.Xaml.Controls.Primitives.GroupHeaderPlacement) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderPlacement), (fun ctx x -> ctx.Element.GroupHeaderPlacement <- x), x)
    [<CustomOperation("GroupHeaderPlacement")>] member inline this.GroupHeaderPlacement ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderPlacement), (fun ctx x -> ctx.Element.GroupHeaderPlacement <- x), x)
    [<CustomOperation("GroupPadding")>] member inline this.GroupPadding ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupPadding), (fun ctx x -> ctx.Element.GroupPadding <- x), x)
    [<CustomOperation("GroupPadding")>] member inline this.GroupPadding ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupPadding), (fun ctx x -> ctx.Element.GroupPadding <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("MaximumRowsOrColumns")>] member inline this.MaximumRowsOrColumns ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumRowsOrColumns), (fun ctx x -> ctx.Element.MaximumRowsOrColumns <- x), x)
    [<CustomOperation("MaximumRowsOrColumns")>] member inline this.MaximumRowsOrColumns ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumRowsOrColumns), (fun ctx x -> ctx.Element.MaximumRowsOrColumns <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type RelativePanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.RelativePanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.BackgroundSizing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)

                

type StackPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.StackPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("AreScrollSnapPointsRegular")>] member inline this.AreScrollSnapPointsRegular ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AreScrollSnapPointsRegular), (fun ctx x -> ctx.Element.AreScrollSnapPointsRegular <- x), x)
    [<CustomOperation("AreScrollSnapPointsRegular")>] member inline this.AreScrollSnapPointsRegular ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AreScrollSnapPointsRegular), (fun ctx x -> ctx.Element.AreScrollSnapPointsRegular <- x), x)
    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.BackgroundSizing) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BackgroundSizing")>] member inline this.BackgroundSizing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundSizing), (fun ctx x -> ctx.Element.BackgroundSizing <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderBrush")>] member inline this.BorderBrush ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderBrush), (fun ctx x -> ctx.Element.BorderBrush <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("BorderThickness")>] member inline this.BorderThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderThickness), (fun ctx x -> ctx.Element.BorderThickness <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)
    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)

    [<CustomOperation("HorizontalSnapPointsChanged")>] member inline this.HorizontalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsChanged), "HorizontalSnapPointsChanged", fn)
    [<CustomOperation("VerticalSnapPointsChanged")>] member inline this.VerticalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsChanged), "VerticalSnapPointsChanged", fn)
                

type VariableSizedWrapGridBuilder() =
    inherit PanelBuilder<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>()

    [<CustomOperation("HorizontalChildrenAlignment")>] member inline this.HorizontalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x: Microsoft.UI.Xaml.HorizontalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalChildrenAlignment), (fun ctx x -> ctx.Element.HorizontalChildrenAlignment <- x), x)
    [<CustomOperation("HorizontalChildrenAlignment")>] member inline this.HorizontalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalChildrenAlignment), (fun ctx x -> ctx.Element.HorizontalChildrenAlignment <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("MaximumRowsOrColumns")>] member inline this.MaximumRowsOrColumns ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumRowsOrColumns), (fun ctx x -> ctx.Element.MaximumRowsOrColumns <- x), x)
    [<CustomOperation("MaximumRowsOrColumns")>] member inline this.MaximumRowsOrColumns ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumRowsOrColumns), (fun ctx x -> ctx.Element.MaximumRowsOrColumns <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x: Microsoft.UI.Xaml.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("VerticalChildrenAlignment")>] member inline this.VerticalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x: Microsoft.UI.Xaml.VerticalAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalChildrenAlignment), (fun ctx x -> ctx.Element.VerticalChildrenAlignment <- x), x)
    [<CustomOperation("VerticalChildrenAlignment")>] member inline this.VerticalChildrenAlignment ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalChildrenAlignment), (fun ctx x -> ctx.Element.VerticalChildrenAlignment <- x), x)

                
            
namespace rec Fun.SunUI.WinUI.DslInternals.Primitives
open Fun.SunUI.WinUI.DslInternals
open Fun.SunUI
open Fun.SunUI.WinUI


type CalendarPanelBuilder() =
    inherit PanelBuilder<Microsoft.UI.Xaml.Controls.Primitives.CalendarPanel>()


                

type InfoBarPanelBuilder<'Element when 'Element :> Microsoft.UI.Xaml.Controls.Primitives.InfoBarPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("HorizontalOrientationPadding")>] member inline this.HorizontalOrientationPadding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOrientationPadding), (fun ctx x -> ctx.Element.HorizontalOrientationPadding <- x), x)
    [<CustomOperation("HorizontalOrientationPadding")>] member inline this.HorizontalOrientationPadding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOrientationPadding), (fun ctx x -> ctx.Element.HorizontalOrientationPadding <- x), x)
    [<CustomOperation("VerticalOrientationPadding")>] member inline this.VerticalOrientationPadding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.UI.Xaml.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOrientationPadding), (fun ctx x -> ctx.Element.VerticalOrientationPadding <- x), x)
    [<CustomOperation("VerticalOrientationPadding")>] member inline this.VerticalOrientationPadding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOrientationPadding), (fun ctx x -> ctx.Element.VerticalOrientationPadding <- x), x)

                

type PivotPanelBuilder() =
    inherit PanelBuilder<Microsoft.UI.Xaml.Controls.Primitives.PivotPanel>()


    [<CustomOperation("HorizontalSnapPointsChanged")>] member inline this.HorizontalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.PivotPanel>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalSnapPointsChanged), "HorizontalSnapPointsChanged", fn)
    [<CustomOperation("VerticalSnapPointsChanged")>] member inline this.VerticalSnapPointsChanged ([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.PivotPanel>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalSnapPointsChanged), "VerticalSnapPointsChanged", fn)
                
            

// =======================================================================================================================

namespace Fun.SunUI.WinUI

[<AutoOpen>]
module WinUIPanelBuilderDslCE_MicrosoftUIXamlControls =
  
    open Fun.SunUI
    open Fun.SunUI.WinUI.DslInternals

    type VirtualizingStackPanel' () = 
        inherit VirtualizingStackPanelBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VirtualizingStackPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.VirtualizingStackPanel()), this.GetRenderMode())

    type WrapGrid' () = 
        inherit WrapGridBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.WrapGrid>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.WrapGrid()), this.GetRenderMode())

    type Grid' () = 
        inherit GridBuilder<Microsoft.UI.Xaml.Controls.Grid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Grid>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Grid()), this.GetRenderMode())

    type SwapChainBackgroundPanel' () = 
        inherit SwapChainBackgroundPanelBuilder<Microsoft.UI.Xaml.Controls.SwapChainBackgroundPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SwapChainBackgroundPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.SwapChainBackgroundPanel()), this.GetRenderMode())

    type SwapChainPanel' () = 
        inherit SwapChainPanelBuilder<Microsoft.UI.Xaml.Controls.SwapChainPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.SwapChainPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.SwapChainPanel()), this.GetRenderMode())

    type Canvas' () = 
        inherit CanvasBuilder<Microsoft.UI.Xaml.Controls.Canvas>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Canvas>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Canvas()), this.GetRenderMode())

    type ItemsStackPanel' () = 
        inherit ItemsStackPanelBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsStackPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ItemsStackPanel()), this.GetRenderMode())

    type ItemsWrapGrid' () = 
        inherit ItemsWrapGridBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.ItemsWrapGrid>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.ItemsWrapGrid()), this.GetRenderMode())

    type RelativePanel' () = 
        inherit RelativePanelBuilder<Microsoft.UI.Xaml.Controls.RelativePanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.RelativePanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.RelativePanel()), this.GetRenderMode())

    type StackPanel' () = 
        inherit StackPanelBuilder<Microsoft.UI.Xaml.Controls.StackPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.StackPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.StackPanel()), this.GetRenderMode())

    type VariableSizedWrapGrid' () = 
        inherit VariableSizedWrapGridBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.VariableSizedWrapGrid()), this.GetRenderMode())

            
namespace Fun.SunUI.WinUI.Primitives

[<AutoOpen>]
module WinUIPanelBuilderDslCE_MicrosoftUIXamlControlsPrimitives =
  
    open Fun.SunUI
    open Fun.SunUI.WinUI.DslInternals.Primitives

    type CarouselPanel' () = 
        inherit CarouselPanelBuilder<Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel()), this.GetRenderMode())

    type MonochromaticOverlayPresenter' () = 
        inherit MonochromaticOverlayPresenterBuilder<Microsoft.UI.Xaml.Controls.Primitives.MonochromaticOverlayPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.MonochromaticOverlayPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.MonochromaticOverlayPresenter()), this.GetRenderMode())

    type PivotHeaderPanel' () = 
        inherit PivotHeaderPanelBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.PivotHeaderPanel()), this.GetRenderMode())

    type CalendarPanel' () = 
        inherit CalendarPanelBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.CalendarPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.CalendarPanel()), this.GetRenderMode())

    type InfoBarPanel' () = 
        inherit InfoBarPanelBuilder<Microsoft.UI.Xaml.Controls.Primitives.InfoBarPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.InfoBarPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.InfoBarPanel()), this.GetRenderMode())

    type PivotPanel' () = 
        inherit PivotPanelBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.UI.Xaml.Controls.Primitives.PivotPanel>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.UI.Xaml.Controls.Primitives.PivotPanel()), this.GetRenderMode())

            