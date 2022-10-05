namespace rec Fun.SunUI.MAUI.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type ElementBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Element>() =
    inherit MAUIElementBuilder<'Element>()

    [<CustomOperation("AutomationId")>] member inline this.AutomationId ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutomationId), (fun ctx x -> ctx.Element.AutomationId <- x), x)
    [<CustomOperation("AutomationId")>] member inline this.AutomationId ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutomationId), (fun ctx x -> ctx.Element.AutomationId <- x), x)
    [<CustomOperation("ClassId")>] member inline this.ClassId ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClassId), (fun ctx x -> ctx.Element.ClassId <- x), x)
    [<CustomOperation("ClassId")>] member inline this.ClassId ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClassId), (fun ctx x -> ctx.Element.ClassId <- x), x)
    [<CustomOperation("Effects")>] member inline this.Effects ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Effects), x)
    [<CustomOperation("Effects'")>] member inline this.Effects' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Effects), x)
    [<CustomOperation("StyleId")>] member inline this.StyleId ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StyleId), (fun ctx x -> ctx.Element.StyleId <- x), x)
    [<CustomOperation("StyleId")>] member inline this.StyleId ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StyleId), (fun ctx x -> ctx.Element.StyleId <- x), x)
    [<CustomOperation("RealParent")>] member inline this.RealParent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RealParent), x)
    [<CustomOperation("RealParent'")>] member inline this.RealParent' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RealParent), x)

    [<CustomOperation("Parent")>]
    member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Parent <- x), creator)

    [<CustomOperation("Parent")>]
    member inline this.Parent ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Parent <- x), creator)
                        
    [<CustomOperation("EffectControlProvider")>] member inline this.EffectControlProvider ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.IEffectControlProvider) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EffectControlProvider), (fun ctx x -> ctx.Element.EffectControlProvider <- x), x)
    [<CustomOperation("EffectControlProvider")>] member inline this.EffectControlProvider ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EffectControlProvider), (fun ctx x -> ctx.Element.EffectControlProvider <- x), x)
    [<CustomOperation("Handler")>] member inline this.Handler ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.IElementHandler) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Handler), (fun ctx x -> ctx.Element.Handler <- x), x)
    [<CustomOperation("Handler")>] member inline this.Handler ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Handler), (fun ctx x -> ctx.Element.Handler <- x), x)

    [<CustomOperation("ChildAdded")>] member inline this.ChildAdded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ChildAdded), "ChildAdded", fn)
    [<CustomOperation("ChildRemoved")>] member inline this.ChildRemoved ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ChildRemoved), "ChildRemoved", fn)
    [<CustomOperation("DescendantAdded")>] member inline this.DescendantAdded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DescendantAdded), "DescendantAdded", fn)
    [<CustomOperation("DescendantRemoved")>] member inline this.DescendantRemoved ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DescendantRemoved), "DescendantRemoved", fn)
    [<CustomOperation("ParentChanging")>] member inline this.ParentChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ParentChanging), "ParentChanging", fn)
    [<CustomOperation("ParentChanged")>] member inline this.ParentChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ParentChanged), "ParentChanged", fn)
    [<CustomOperation("HandlerChanging")>] member inline this.HandlerChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HandlerChanging), "HandlerChanging", fn)
    [<CustomOperation("HandlerChanged")>] member inline this.HandlerChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.HandlerChanged), "HandlerChanged", fn)
                

type NavigableElementBuilder<'Element when 'Element :> Microsoft.Maui.Controls.NavigableElement>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("Navigation")>] member inline this.Navigation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Navigation), x)
    [<CustomOperation("Navigation'")>] member inline this.Navigation' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Navigation), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("StyleClass")>] member inline this.StyleClass ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<System.String>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StyleClass), (fun ctx x -> ctx.Element.StyleClass <- x), x)
    [<CustomOperation("StyleClass")>] member inline this.StyleClass ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StyleClass), (fun ctx x -> ctx.Element.StyleClass <- x), x)
    [<CustomOperation("class'")>] member inline this.class' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<System.String>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.``class``), (fun ctx x -> ctx.Element.``class`` <- x), x)
    [<CustomOperation("class'")>] member inline this.class' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.``class``), (fun ctx x -> ctx.Element.``class`` <- x), x)
    [<CustomOperation("NavigationProxy")>] member inline this.NavigationProxy ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NavigationProxy), x)
    [<CustomOperation("NavigationProxy'")>] member inline this.NavigationProxy' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NavigationProxy), x)

                

type VisualElementBuilder<'Element when 'Element :> Microsoft.Maui.Controls.VisualElement>() =
    inherit NavigableElementBuilder<'Element>()

    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Frame")>] member inline this.Frame ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Frame), (fun ctx x -> ctx.Element.Frame <- x), x)
    [<CustomOperation("Handler")>] member inline this.Handler ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.IViewHandler) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Handler), (fun ctx x -> ctx.Element.Handler <- x), x)
    [<CustomOperation("Handler")>] member inline this.Handler ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Handler), (fun ctx x -> ctx.Element.Handler <- x), x)

    [<CustomOperation("Shadow")>]
    member inline this.Shadow ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Shadow <- x), creator)

    [<CustomOperation("Shadow")>]
    member inline this.Shadow ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Shadow <- x), creator)
                        
    [<CustomOperation("ZIndex")>] member inline this.ZIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ZIndex), (fun ctx x -> ctx.Element.ZIndex <- x), x)
    [<CustomOperation("ZIndex")>] member inline this.ZIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ZIndex), (fun ctx x -> ctx.Element.ZIndex <- x), x)
    [<CustomOperation("DesiredSize")>] member inline this.DesiredSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DesiredSize), x)
    [<CustomOperation("DesiredSize'")>] member inline this.DesiredSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DesiredSize), x)
    [<CustomOperation("Visual")>] member inline this.Visual ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.IVisual) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Visual), (fun ctx x -> ctx.Element.Visual <- x), x)
    [<CustomOperation("Visual")>] member inline this.Visual ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Visual), (fun ctx x -> ctx.Element.Visual <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.FlowDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("Window")>] member inline this.Window ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Window), x)
    [<CustomOperation("Window'")>] member inline this.Window' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Window), x)
    [<CustomOperation("AnchorX")>] member inline this.AnchorX ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AnchorX), (fun ctx x -> ctx.Element.AnchorX <- x), x)
    [<CustomOperation("AnchorX")>] member inline this.AnchorX ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AnchorX), (fun ctx x -> ctx.Element.AnchorX <- x), x)
    [<CustomOperation("AnchorY")>] member inline this.AnchorY ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AnchorY), (fun ctx x -> ctx.Element.AnchorY <- x), x)
    [<CustomOperation("AnchorY")>] member inline this.AnchorY ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AnchorY), (fun ctx x -> ctx.Element.AnchorY <- x), x)
    [<CustomOperation("BackgroundColor")>] member inline this.BackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundColor), (fun ctx x -> ctx.Element.BackgroundColor <- x), x)
    [<CustomOperation("BackgroundColor")>] member inline this.BackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundColor), (fun ctx x -> ctx.Element.BackgroundColor <- x), x)

    [<CustomOperation("Background")>]
    member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Background <- x), creator)

    [<CustomOperation("Background")>]
    member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Background <- x), creator)
                        
    [<CustomOperation("Behaviors")>] member inline this.Behaviors ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Behaviors), x)
    [<CustomOperation("Behaviors'")>] member inline this.Behaviors' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Behaviors), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("Bounds'")>] member inline this.Bounds' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("HeightRequest")>] member inline this.HeightRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeightRequest), (fun ctx x -> ctx.Element.HeightRequest <- x), x)
    [<CustomOperation("HeightRequest")>] member inline this.HeightRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeightRequest), (fun ctx x -> ctx.Element.HeightRequest <- x), x)
    [<CustomOperation("InputTransparent")>] member inline this.InputTransparent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.InputTransparent), (fun ctx x -> ctx.Element.InputTransparent <- x), x)
    [<CustomOperation("InputTransparent")>] member inline this.InputTransparent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.InputTransparent), (fun ctx x -> ctx.Element.InputTransparent <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("MinimumHeightRequest")>] member inline this.MinimumHeightRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumHeightRequest), (fun ctx x -> ctx.Element.MinimumHeightRequest <- x), x)
    [<CustomOperation("MinimumHeightRequest")>] member inline this.MinimumHeightRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumHeightRequest), (fun ctx x -> ctx.Element.MinimumHeightRequest <- x), x)
    [<CustomOperation("MinimumWidthRequest")>] member inline this.MinimumWidthRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumWidthRequest), (fun ctx x -> ctx.Element.MinimumWidthRequest <- x), x)
    [<CustomOperation("MinimumWidthRequest")>] member inline this.MinimumWidthRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumWidthRequest), (fun ctx x -> ctx.Element.MinimumWidthRequest <- x), x)
    [<CustomOperation("MaximumHeightRequest")>] member inline this.MaximumHeightRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumHeightRequest), (fun ctx x -> ctx.Element.MaximumHeightRequest <- x), x)
    [<CustomOperation("MaximumHeightRequest")>] member inline this.MaximumHeightRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumHeightRequest), (fun ctx x -> ctx.Element.MaximumHeightRequest <- x), x)
    [<CustomOperation("MaximumWidthRequest")>] member inline this.MaximumWidthRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumWidthRequest), (fun ctx x -> ctx.Element.MaximumWidthRequest <- x), x)
    [<CustomOperation("MaximumWidthRequest")>] member inline this.MaximumWidthRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumWidthRequest), (fun ctx x -> ctx.Element.MaximumWidthRequest <- x), x)
    [<CustomOperation("Opacity")>] member inline this.Opacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Opacity), (fun ctx x -> ctx.Element.Opacity <- x), x)
    [<CustomOperation("Opacity")>] member inline this.Opacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Opacity), (fun ctx x -> ctx.Element.Opacity <- x), x)
    [<CustomOperation("Rotation")>] member inline this.Rotation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Rotation), (fun ctx x -> ctx.Element.Rotation <- x), x)
    [<CustomOperation("Rotation")>] member inline this.Rotation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Rotation), (fun ctx x -> ctx.Element.Rotation <- x), x)
    [<CustomOperation("RotationX")>] member inline this.RotationX ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RotationX), (fun ctx x -> ctx.Element.RotationX <- x), x)
    [<CustomOperation("RotationX")>] member inline this.RotationX ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RotationX), (fun ctx x -> ctx.Element.RotationX <- x), x)
    [<CustomOperation("RotationY")>] member inline this.RotationY ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RotationY), (fun ctx x -> ctx.Element.RotationY <- x), x)
    [<CustomOperation("RotationY")>] member inline this.RotationY ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RotationY), (fun ctx x -> ctx.Element.RotationY <- x), x)
    [<CustomOperation("Scale")>] member inline this.Scale ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Scale), (fun ctx x -> ctx.Element.Scale <- x), x)
    [<CustomOperation("Scale")>] member inline this.Scale ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Scale), (fun ctx x -> ctx.Element.Scale <- x), x)
    [<CustomOperation("ScaleX")>] member inline this.ScaleX ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScaleX), (fun ctx x -> ctx.Element.ScaleX <- x), x)
    [<CustomOperation("ScaleX")>] member inline this.ScaleX ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScaleX), (fun ctx x -> ctx.Element.ScaleX <- x), x)
    [<CustomOperation("ScaleY")>] member inline this.ScaleY ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScaleY), (fun ctx x -> ctx.Element.ScaleY <- x), x)
    [<CustomOperation("ScaleY")>] member inline this.ScaleY ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScaleY), (fun ctx x -> ctx.Element.ScaleY <- x), x)
    [<CustomOperation("TranslationX")>] member inline this.TranslationX ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TranslationX), (fun ctx x -> ctx.Element.TranslationX <- x), x)
    [<CustomOperation("TranslationX")>] member inline this.TranslationX ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TranslationX), (fun ctx x -> ctx.Element.TranslationX <- x), x)
    [<CustomOperation("TranslationY")>] member inline this.TranslationY ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TranslationY), (fun ctx x -> ctx.Element.TranslationY <- x), x)
    [<CustomOperation("TranslationY")>] member inline this.TranslationY ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TranslationY), (fun ctx x -> ctx.Element.TranslationY <- x), x)
    [<CustomOperation("Triggers")>] member inline this.Triggers ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Triggers), x)
    [<CustomOperation("Triggers'")>] member inline this.Triggers' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Triggers), x)
    [<CustomOperation("WidthRequest")>] member inline this.WidthRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WidthRequest), (fun ctx x -> ctx.Element.WidthRequest <- x), x)
    [<CustomOperation("WidthRequest")>] member inline this.WidthRequest ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WidthRequest), (fun ctx x -> ctx.Element.WidthRequest <- x), x)
    [<CustomOperation("Clip")>] member inline this.Clip ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Shapes.Geometry) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Clip), (fun ctx x -> ctx.Element.Clip <- x), x)
    [<CustomOperation("Clip")>] member inline this.Clip ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Clip), (fun ctx x -> ctx.Element.Clip <- x), x)
    [<CustomOperation("DisableLayout")>] member inline this.DisableLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DisableLayout), (fun ctx x -> ctx.Element.DisableLayout <- x), x)
    [<CustomOperation("DisableLayout")>] member inline this.DisableLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DisableLayout), (fun ctx x -> ctx.Element.DisableLayout <- x), x)
    [<CustomOperation("IsInPlatformLayout")>] member inline this.IsInPlatformLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsInPlatformLayout), (fun ctx x -> ctx.Element.IsInPlatformLayout <- x), x)
    [<CustomOperation("IsInPlatformLayout")>] member inline this.IsInPlatformLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsInPlatformLayout), (fun ctx x -> ctx.Element.IsInPlatformLayout <- x), x)
    [<CustomOperation("IsPlatformStateConsistent")>] member inline this.IsPlatformStateConsistent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPlatformStateConsistent), (fun ctx x -> ctx.Element.IsPlatformStateConsistent <- x), x)
    [<CustomOperation("IsPlatformStateConsistent")>] member inline this.IsPlatformStateConsistent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPlatformStateConsistent), (fun ctx x -> ctx.Element.IsPlatformStateConsistent <- x), x)
    [<CustomOperation("IsPlatformEnabled")>] member inline this.IsPlatformEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPlatformEnabled), (fun ctx x -> ctx.Element.IsPlatformEnabled <- x), x)
    [<CustomOperation("IsPlatformEnabled")>] member inline this.IsPlatformEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPlatformEnabled), (fun ctx x -> ctx.Element.IsPlatformEnabled <- x), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ResourceDictionary) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)

    [<CustomOperation("Loaded")>] member inline this.Loaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Loaded), "Loaded", fn)
    [<CustomOperation("Unloaded")>] member inline this.Unloaded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unloaded), "Unloaded", fn)
    [<CustomOperation("ChildrenReordered")>] member inline this.ChildrenReordered ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ChildrenReordered), "ChildrenReordered", fn)
    [<CustomOperation("Focused")>] member inline this.Focused ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Focused), "Focused", fn)
    [<CustomOperation("MeasureInvalidated")>] member inline this.MeasureInvalidated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MeasureInvalidated), "MeasureInvalidated", fn)
    [<CustomOperation("SizeChanged")>] member inline this.SizeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SizeChanged), "SizeChanged", fn)
    [<CustomOperation("Unfocused")>] member inline this.Unfocused ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Unfocused), "Unfocused", fn)
    [<CustomOperation("BatchCommitted")>] member inline this.BatchCommitted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.BatchCommitted), "BatchCommitted", fn)
    [<CustomOperation("FocusChangeRequested")>] member inline this.FocusChangeRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.FocusChangeRequested), "FocusChangeRequested", fn)
                

type PageBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Page>() =
    inherit VisualElementBuilder<'Element>()


    [<CustomOperation("BackgroundImageSource")>]
    member inline this.BackgroundImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.BackgroundImageSource <- x), creator)

    [<CustomOperation("BackgroundImageSource")>]
    member inline this.BackgroundImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.BackgroundImageSource <- x), creator)
                        

    [<CustomOperation("IconImageSource")>]
    member inline this.IconImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IconImageSource <- x), creator)

    [<CustomOperation("IconImageSource")>]
    member inline this.IconImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IconImageSource <- x), creator)
                        
    [<CustomOperation("IsBusy")>] member inline this.IsBusy ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsBusy), (fun ctx x -> ctx.Element.IsBusy <- x), x)
    [<CustomOperation("IsBusy")>] member inline this.IsBusy ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsBusy), (fun ctx x -> ctx.Element.IsBusy <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

    [<CustomOperation("ToolbarItems")>]
    member inline this.ToolbarItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ToolbarItem>(
            builder,
            (fun x -> x.Element.ToolbarItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ToolbarItem[]) -> for i in ls do x.Element.ToolbarItems.Add(i) |> ignore),
            items
        )

    [<CustomOperation("ToolbarItems")>]
    member inline this.ToolbarItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ToolbarItem>(
            builder,
            (fun x -> x.Element.ToolbarItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ToolbarItem[]) -> for i in ls do x.Element.ToolbarItems.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticToolbarItems")>]
    member inline this.StaticToolbarItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.ToolbarItem>(
            builder,
            (fun x -> x.Element.ToolbarItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ToolbarItem[]) -> for i in ls do x.Element.ToolbarItems.Add(i) |> ignore),
            items
        )
                        

    [<CustomOperation("MenuBarItems")>]
    member inline this.MenuBarItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuBarItem>(
            builder,
            (fun x -> x.Element.MenuBarItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuBarItem[]) -> for i in ls do x.Element.MenuBarItems.Add(i) |> ignore),
            items
        )

    [<CustomOperation("MenuBarItems")>]
    member inline this.MenuBarItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuBarItem>(
            builder,
            (fun x -> x.Element.MenuBarItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuBarItem[]) -> for i in ls do x.Element.MenuBarItems.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticMenuBarItems")>]
    member inline this.StaticMenuBarItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuBarItem>(
            builder,
            (fun x -> x.Element.MenuBarItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuBarItem[]) -> for i in ls do x.Element.MenuBarItems.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("ContainerArea")>] member inline this.ContainerArea ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContainerArea), (fun ctx x -> ctx.Element.ContainerArea <- x), x)
    [<CustomOperation("ContainerArea")>] member inline this.ContainerArea ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContainerArea), (fun ctx x -> ctx.Element.ContainerArea <- x), x)
    [<CustomOperation("IgnoresContainerArea")>] member inline this.IgnoresContainerArea ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IgnoresContainerArea), (fun ctx x -> ctx.Element.IgnoresContainerArea <- x), x)
    [<CustomOperation("IgnoresContainerArea")>] member inline this.IgnoresContainerArea ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IgnoresContainerArea), (fun ctx x -> ctx.Element.IgnoresContainerArea <- x), x)
    [<CustomOperation("InternalChildren")>] member inline this.InternalChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.InternalChildren), x)
    [<CustomOperation("InternalChildren'")>] member inline this.InternalChildren' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.InternalChildren), x)

    [<CustomOperation("NavigatedTo")>] member inline this.NavigatedTo ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigatedTo), "NavigatedTo", fn)
    [<CustomOperation("NavigatingFrom")>] member inline this.NavigatingFrom ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigatingFrom), "NavigatingFrom", fn)
    [<CustomOperation("NavigatedFrom")>] member inline this.NavigatedFrom ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.NavigatedFrom), "NavigatedFrom", fn)
    [<CustomOperation("LayoutChanged")>] member inline this.LayoutChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutChanged), "LayoutChanged", fn)
    [<CustomOperation("Appearing")>] member inline this.Appearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Appearing), "Appearing", fn)
    [<CustomOperation("Disappearing")>] member inline this.Disappearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Disappearing), "Disappearing", fn)
                

type TemplatedPageBuilder<'Element when 'Element :> Microsoft.Maui.Controls.TemplatedPage>() =
    inherit PageBuilder<'Element>()

    [<CustomOperation("ControlTemplate")>] member inline this.ControlTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ControlTemplate), (fun ctx x -> ctx.Element.ControlTemplate <- x), x)
    [<CustomOperation("ControlTemplate")>] member inline this.ControlTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ControlTemplate), (fun ctx x -> ctx.Element.ControlTemplate <- x), x)

                

type ContentPageBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ContentPage>() =
    inherit TemplatedPageBuilder<'Element>()


    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        

                

type ShellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Shell>() =
    inherit PageBuilder<'Element>()

    [<CustomOperation("CurrentPage")>] member inline this.CurrentPage ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentPage), x)
    [<CustomOperation("CurrentPage'")>] member inline this.CurrentPage' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentPage), x)
    [<CustomOperation("FlyoutVerticalScrollMode")>] member inline this.FlyoutVerticalScrollMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ScrollMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutVerticalScrollMode), (fun ctx x -> ctx.Element.FlyoutVerticalScrollMode <- x), x)
    [<CustomOperation("FlyoutVerticalScrollMode")>] member inline this.FlyoutVerticalScrollMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutVerticalScrollMode), (fun ctx x -> ctx.Element.FlyoutVerticalScrollMode <- x), x)

    [<CustomOperation("FlyoutIcon")>]
    member inline this.FlyoutIcon ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutIcon <- x), creator)

    [<CustomOperation("FlyoutIcon")>]
    member inline this.FlyoutIcon ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutIcon <- x), creator)
                        

    [<CustomOperation("CurrentItem")>]
    member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentItem <- x), creator)

    [<CustomOperation("CurrentItem")>]
    member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentItem <- x), creator)
                        
    [<CustomOperation("CurrentState")>] member inline this.CurrentState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentState), x)
    [<CustomOperation("CurrentState'")>] member inline this.CurrentState' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentState), x)

    [<CustomOperation("FlyoutBackgroundImage")>]
    member inline this.FlyoutBackgroundImage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutBackgroundImage <- x), creator)

    [<CustomOperation("FlyoutBackgroundImage")>]
    member inline this.FlyoutBackgroundImage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutBackgroundImage <- x), creator)
                        
    [<CustomOperation("FlyoutBackgroundImageAspect")>] member inline this.FlyoutBackgroundImageAspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Aspect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutBackgroundImageAspect), (fun ctx x -> ctx.Element.FlyoutBackgroundImageAspect <- x), x)
    [<CustomOperation("FlyoutBackgroundImageAspect")>] member inline this.FlyoutBackgroundImageAspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutBackgroundImageAspect), (fun ctx x -> ctx.Element.FlyoutBackgroundImageAspect <- x), x)
    [<CustomOperation("FlyoutBackgroundColor")>] member inline this.FlyoutBackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutBackgroundColor), (fun ctx x -> ctx.Element.FlyoutBackgroundColor <- x), x)
    [<CustomOperation("FlyoutBackgroundColor")>] member inline this.FlyoutBackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutBackgroundColor), (fun ctx x -> ctx.Element.FlyoutBackgroundColor <- x), x)

    [<CustomOperation("FlyoutBackground")>]
    member inline this.FlyoutBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutBackground <- x), creator)

    [<CustomOperation("FlyoutBackground")>]
    member inline this.FlyoutBackground ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutBackground <- x), creator)
                        

    [<CustomOperation("FlyoutBackdrop")>]
    member inline this.FlyoutBackdrop ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutBackdrop <- x), creator)

    [<CustomOperation("FlyoutBackdrop")>]
    member inline this.FlyoutBackdrop ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutBackdrop <- x), creator)
                        
    [<CustomOperation("FlyoutWidth")>] member inline this.FlyoutWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutWidth), (fun ctx x -> ctx.Element.FlyoutWidth <- x), x)
    [<CustomOperation("FlyoutWidth")>] member inline this.FlyoutWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutWidth), (fun ctx x -> ctx.Element.FlyoutWidth <- x), x)
    [<CustomOperation("FlyoutHeight")>] member inline this.FlyoutHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeight), (fun ctx x -> ctx.Element.FlyoutHeight <- x), x)
    [<CustomOperation("FlyoutHeight")>] member inline this.FlyoutHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeight), (fun ctx x -> ctx.Element.FlyoutHeight <- x), x)
    [<CustomOperation("FlyoutBehavior")>] member inline this.FlyoutBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.FlyoutBehavior) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutBehavior), (fun ctx x -> ctx.Element.FlyoutBehavior <- x), x)
    [<CustomOperation("FlyoutBehavior")>] member inline this.FlyoutBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutBehavior), (fun ctx x -> ctx.Element.FlyoutBehavior <- x), x)
    [<CustomOperation("FlyoutHeader")>] member inline this.FlyoutHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeader), (fun ctx x -> ctx.Element.FlyoutHeader <- x), x)
    [<CustomOperation("FlyoutHeader")>] member inline this.FlyoutHeader ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeader), (fun ctx x -> ctx.Element.FlyoutHeader <- x), x)
    [<CustomOperation("FlyoutFooter")>] member inline this.FlyoutFooter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutFooter), (fun ctx x -> ctx.Element.FlyoutFooter <- x), x)
    [<CustomOperation("FlyoutFooter")>] member inline this.FlyoutFooter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutFooter), (fun ctx x -> ctx.Element.FlyoutFooter <- x), x)
    [<CustomOperation("FlyoutHeaderBehavior")>] member inline this.FlyoutHeaderBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FlyoutHeaderBehavior) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeaderBehavior), (fun ctx x -> ctx.Element.FlyoutHeaderBehavior <- x), x)
    [<CustomOperation("FlyoutHeaderBehavior")>] member inline this.FlyoutHeaderBehavior ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeaderBehavior), (fun ctx x -> ctx.Element.FlyoutHeaderBehavior <- x), x)
    [<CustomOperation("FlyoutHeaderTemplate")>] member inline this.FlyoutHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeaderTemplate), (fun ctx x -> ctx.Element.FlyoutHeaderTemplate <- x), x)
    [<CustomOperation("FlyoutHeaderTemplate")>] member inline this.FlyoutHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutHeaderTemplate), (fun ctx x -> ctx.Element.FlyoutHeaderTemplate <- x), x)
    [<CustomOperation("FlyoutFooterTemplate")>] member inline this.FlyoutFooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutFooterTemplate), (fun ctx x -> ctx.Element.FlyoutFooterTemplate <- x), x)
    [<CustomOperation("FlyoutFooterTemplate")>] member inline this.FlyoutFooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutFooterTemplate), (fun ctx x -> ctx.Element.FlyoutFooterTemplate <- x), x)
    [<CustomOperation("FlyoutIsPresented")>] member inline this.FlyoutIsPresented ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutIsPresented), (fun ctx x -> ctx.Element.FlyoutIsPresented <- x), x)
    [<CustomOperation("FlyoutIsPresented")>] member inline this.FlyoutIsPresented ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutIsPresented), (fun ctx x -> ctx.Element.FlyoutIsPresented <- x), x)

    [<CustomOperation("Items")>]
    member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellItem>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellItem[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Items")>]
    member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellItem>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellItem[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticItems")>]
    member inline this.StaticItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellItem>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellItem[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("MenuItemTemplate")>] member inline this.MenuItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemTemplate), (fun ctx x -> ctx.Element.MenuItemTemplate <- x), x)
    [<CustomOperation("MenuItemTemplate")>] member inline this.MenuItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MenuItemTemplate), (fun ctx x -> ctx.Element.MenuItemTemplate <- x), x)
    [<CustomOperation("FlyoutItems")>] member inline this.FlyoutItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FlyoutItems), x)
    [<CustomOperation("FlyoutItems'")>] member inline this.FlyoutItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FlyoutItems), x)
    [<CustomOperation("FlyoutContent")>] member inline this.FlyoutContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutContent), (fun ctx x -> ctx.Element.FlyoutContent <- x), x)
    [<CustomOperation("FlyoutContent")>] member inline this.FlyoutContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutContent), (fun ctx x -> ctx.Element.FlyoutContent <- x), x)
    [<CustomOperation("FlyoutContentTemplate")>] member inline this.FlyoutContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutContentTemplate), (fun ctx x -> ctx.Element.FlyoutContentTemplate <- x), x)
    [<CustomOperation("FlyoutContentTemplate")>] member inline this.FlyoutContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutContentTemplate), (fun ctx x -> ctx.Element.FlyoutContentTemplate <- x), x)

    [<CustomOperation("Navigated")>] member inline this.Navigated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigated), "Navigated", fn)
    [<CustomOperation("Navigating")>] member inline this.Navigating ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigating), "Navigating", fn)
                

type MultiPageBuilder<'Element, 'T when 'T :> Microsoft.Maui.Controls.Page and 'Element :> Microsoft.Maui.Controls.MultiPage<'T>>() =
    inherit PageBuilder<'Element>()

    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)

    [<CustomOperation("CurrentPage")>]
    member inline this.CurrentPage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentPage <- x), creator)

    [<CustomOperation("CurrentPage")>]
    member inline this.CurrentPage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentPage <- x), creator)
                        

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, 'T>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: 'T[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, 'T>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: 'T[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, 'T>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: 'T[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )
                        

    [<CustomOperation("CurrentPageChanged")>] member inline this.CurrentPageChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentPageChanged), "CurrentPageChanged", fn)
    [<CustomOperation("PagesChanged")>] member inline this.PagesChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PagesChanged), "PagesChanged", fn)
                

type ViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.View>() =
    inherit VisualElementBuilder<'Element>()

    [<CustomOperation("GestureRecognizers")>] member inline this.GestureRecognizers ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GestureRecognizers), x)
    [<CustomOperation("GestureRecognizers'")>] member inline this.GestureRecognizers' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GestureRecognizers), x)
    [<CustomOperation("HorizontalOptions")>] member inline this.HorizontalOptions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.LayoutOptions) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOptions), (fun ctx x -> ctx.Element.HorizontalOptions <- x), x)
    [<CustomOperation("HorizontalOptions")>] member inline this.HorizontalOptions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalOptions), (fun ctx x -> ctx.Element.HorizontalOptions <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("Margin")>] member inline this.Margin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Margin), (fun ctx x -> ctx.Element.Margin <- x), x)
    [<CustomOperation("VerticalOptions")>] member inline this.VerticalOptions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.LayoutOptions) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOptions), (fun ctx x -> ctx.Element.VerticalOptions <- x), x)
    [<CustomOperation("VerticalOptions")>] member inline this.VerticalOptions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalOptions), (fun ctx x -> ctx.Element.VerticalOptions <- x), x)

                
            
namespace rec Fun.SunUI.MAUI.DslInternals.Compatibility

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type LayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Compatibility.Layout>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("IsClippedToBounds")>] member inline this.IsClippedToBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClippedToBounds), (fun ctx x -> ctx.Element.IsClippedToBounds <- x), x)
    [<CustomOperation("IsClippedToBounds")>] member inline this.IsClippedToBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClippedToBounds), (fun ctx x -> ctx.Element.IsClippedToBounds <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("CascadeInputTransparent")>] member inline this.CascadeInputTransparent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CascadeInputTransparent), (fun ctx x -> ctx.Element.CascadeInputTransparent <- x), x)
    [<CustomOperation("CascadeInputTransparent")>] member inline this.CascadeInputTransparent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CascadeInputTransparent), (fun ctx x -> ctx.Element.CascadeInputTransparent <- x), x)
    [<CustomOperation("Children")>] member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Children), x)
    [<CustomOperation("Children'")>] member inline this.Children' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Children), x)

    [<CustomOperation("LayoutChanged")>] member inline this.LayoutChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutChanged), "LayoutChanged", fn)
                
            
namespace rec Fun.SunUI.MAUI.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type TemplatedViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.TemplatedView>() =
    inherit Compatibility.LayoutBuilder<'Element>()

    [<CustomOperation("ControlTemplate")>] member inline this.ControlTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ControlTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ControlTemplate), (fun ctx x -> ctx.Element.ControlTemplate <- x), x)
    [<CustomOperation("ControlTemplate")>] member inline this.ControlTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ControlTemplate), (fun ctx x -> ctx.Element.ControlTemplate <- x), x)

                

type ContentViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ContentView>() =
    inherit TemplatedViewBuilder<'Element>()


    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        

                

type FrameBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Frame>() =
    inherit ContentViewBuilder<'Element>()

    [<CustomOperation("HasShadow")>] member inline this.HasShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasShadow), (fun ctx x -> ctx.Element.HasShadow <- x), x)
    [<CustomOperation("HasShadow")>] member inline this.HasShadow ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasShadow), (fun ctx x -> ctx.Element.HasShadow <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)

                

type RefreshViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.RefreshView>() =
    inherit ContentViewBuilder<'Element>()

    [<CustomOperation("IsRefreshing")>] member inline this.IsRefreshing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsRefreshing), (fun ctx x -> ctx.Element.IsRefreshing <- x), x)
    [<CustomOperation("IsRefreshing")>] member inline this.IsRefreshing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsRefreshing), (fun ctx x -> ctx.Element.IsRefreshing <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("RefreshColor")>] member inline this.RefreshColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshColor), (fun ctx x -> ctx.Element.RefreshColor <- x), x)
    [<CustomOperation("RefreshColor")>] member inline this.RefreshColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshColor), (fun ctx x -> ctx.Element.RefreshColor <- x), x)

    [<CustomOperation("Refreshing")>] member inline this.Refreshing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Refreshing), "Refreshing", fn)
                

type SwipeItemViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SwipeItemView>() =
    inherit ContentViewBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)

    [<CustomOperation("Invoked")>] member inline this.Invoked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Invoked), "Invoked", fn)
                

type SwipeViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SwipeView>() =
    inherit ContentViewBuilder<'Element>()

    [<CustomOperation("Threshold")>] member inline this.Threshold ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Threshold), (fun ctx x -> ctx.Element.Threshold <- x), x)
    [<CustomOperation("Threshold")>] member inline this.Threshold ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Threshold), (fun ctx x -> ctx.Element.Threshold <- x), x)

    [<CustomOperation("LeftItems")>]
    member inline this.LeftItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.LeftItems <- x), creator)

    [<CustomOperation("LeftItems")>]
    member inline this.LeftItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.LeftItems <- x), creator)
                        

    [<CustomOperation("RightItems")>]
    member inline this.RightItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.RightItems <- x), creator)

    [<CustomOperation("RightItems")>]
    member inline this.RightItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.RightItems <- x), creator)
                        

    [<CustomOperation("TopItems")>]
    member inline this.TopItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.TopItems <- x), creator)

    [<CustomOperation("TopItems")>]
    member inline this.TopItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.TopItems <- x), creator)
                        

    [<CustomOperation("BottomItems")>]
    member inline this.BottomItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.BottomItems <- x), creator)

    [<CustomOperation("BottomItems")>]
    member inline this.BottomItems ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.BottomItems <- x), creator)
                        

    [<CustomOperation("SwipeStarted")>] member inline this.SwipeStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SwipeStarted), "SwipeStarted", fn)
    [<CustomOperation("SwipeChanging")>] member inline this.SwipeChanging ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SwipeChanging), "SwipeChanging", fn)
    [<CustomOperation("SwipeEnded")>] member inline this.SwipeEnded ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SwipeEnded), "SwipeEnded", fn)
    [<CustomOperation("OpenRequested")>] member inline this.OpenRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.OpenRequested), "OpenRequested", fn)
    [<CustomOperation("CloseRequested")>] member inline this.CloseRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CloseRequested), "CloseRequested", fn)
                

type IndicatorViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.IndicatorView>() =
    inherit TemplatedViewBuilder<'Element>()

    [<CustomOperation("IndicatorsShape")>] member inline this.IndicatorsShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.IndicatorShape) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorsShape), (fun ctx x -> ctx.Element.IndicatorsShape <- x), x)
    [<CustomOperation("IndicatorsShape")>] member inline this.IndicatorsShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorsShape), (fun ctx x -> ctx.Element.IndicatorsShape <- x), x)
    [<CustomOperation("IndicatorLayout")>] member inline this.IndicatorLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.IBindableLayout) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorLayout), (fun ctx x -> ctx.Element.IndicatorLayout <- x), x)
    [<CustomOperation("IndicatorLayout")>] member inline this.IndicatorLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorLayout), (fun ctx x -> ctx.Element.IndicatorLayout <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Count")>] member inline this.Count ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Count), (fun ctx x -> ctx.Element.Count <- x), x)
    [<CustomOperation("Count")>] member inline this.Count ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Count), (fun ctx x -> ctx.Element.Count <- x), x)
    [<CustomOperation("MaximumVisible")>] member inline this.MaximumVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumVisible), (fun ctx x -> ctx.Element.MaximumVisible <- x), x)
    [<CustomOperation("MaximumVisible")>] member inline this.MaximumVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumVisible), (fun ctx x -> ctx.Element.MaximumVisible <- x), x)
    [<CustomOperation("IndicatorTemplate")>] member inline this.IndicatorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorTemplate), (fun ctx x -> ctx.Element.IndicatorTemplate <- x), x)
    [<CustomOperation("IndicatorTemplate")>] member inline this.IndicatorTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorTemplate), (fun ctx x -> ctx.Element.IndicatorTemplate <- x), x)
    [<CustomOperation("HideSingle")>] member inline this.HideSingle ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HideSingle), (fun ctx x -> ctx.Element.HideSingle <- x), x)
    [<CustomOperation("HideSingle")>] member inline this.HideSingle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HideSingle), (fun ctx x -> ctx.Element.HideSingle <- x), x)
    [<CustomOperation("IndicatorColor")>] member inline this.IndicatorColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorColor), (fun ctx x -> ctx.Element.IndicatorColor <- x), x)
    [<CustomOperation("IndicatorColor")>] member inline this.IndicatorColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorColor), (fun ctx x -> ctx.Element.IndicatorColor <- x), x)
    [<CustomOperation("SelectedIndicatorColor")>] member inline this.SelectedIndicatorColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndicatorColor), (fun ctx x -> ctx.Element.SelectedIndicatorColor <- x), x)
    [<CustomOperation("SelectedIndicatorColor")>] member inline this.SelectedIndicatorColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndicatorColor), (fun ctx x -> ctx.Element.SelectedIndicatorColor <- x), x)
    [<CustomOperation("IndicatorSize")>] member inline this.IndicatorSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorSize), (fun ctx x -> ctx.Element.IndicatorSize <- x), x)
    [<CustomOperation("IndicatorSize")>] member inline this.IndicatorSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IndicatorSize), (fun ctx x -> ctx.Element.IndicatorSize <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)

                

type RadioButtonBuilder<'Element when 'Element :> Microsoft.Maui.Controls.RadioButton>() =
    inherit TemplatedViewBuilder<'Element>()

    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content")>] member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("GroupName")>] member inline this.GroupName ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupName), (fun ctx x -> ctx.Element.GroupName <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextTransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("BorderWidth")>] member inline this.BorderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderWidth), (fun ctx x -> ctx.Element.BorderWidth <- x), x)
    [<CustomOperation("BorderWidth")>] member inline this.BorderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderWidth), (fun ctx x -> ctx.Element.BorderWidth <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)

    [<CustomOperation("CheckedChanged")>] member inline this.CheckedChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckedChanged), "CheckedChanged", fn)
                

type ContentPresenterBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ContentPresenter>() =
    inherit Compatibility.LayoutBuilder<'Element>()


    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        

                

type ScrollViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ScrollView>() =
    inherit Compatibility.LayoutBuilder<'Element>()

    [<CustomOperation("LayoutAreaOverride")>] member inline this.LayoutAreaOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Rect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutAreaOverride), (fun ctx x -> ctx.Element.LayoutAreaOverride <- x), x)
    [<CustomOperation("LayoutAreaOverride")>] member inline this.LayoutAreaOverride ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LayoutAreaOverride), (fun ctx x -> ctx.Element.LayoutAreaOverride <- x), x)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        
    [<CustomOperation("ContentSize")>] member inline this.ContentSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ContentSize), x)
    [<CustomOperation("ContentSize'")>] member inline this.ContentSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ContentSize), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollOrientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)

    [<CustomOperation("ScrollToRequested")>] member inline this.ScrollToRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollToRequested), "ScrollToRequested", fn)
    [<CustomOperation("Scrolled")>] member inline this.Scrolled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scrolled), "Scrolled", fn)
                
            
namespace rec Fun.SunUI.MAUI.DslInternals.Compatibility

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type LayoutBuilder2<'Element, 'T when 'T :> Microsoft.Maui.Controls.View and 'Element :> Microsoft.Maui.Controls.Compatibility.Layout<'T>>() =
    inherit Compatibility.LayoutBuilder<'Element>()


    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, 'T>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: 'T[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, 'T>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: 'T[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, 'T>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: 'T[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("LayoutHandler")>] member inline this.LayoutHandler ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.LayoutHandler), x)
    [<CustomOperation("LayoutHandler'")>] member inline this.LayoutHandler' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.LayoutHandler), x)

                

type AbsoluteLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Compatibility.AbsoluteLayout>() =
    inherit Compatibility.LayoutBuilder2<'Element, Microsoft.Maui.Controls.View>()


    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )
                        

                

type FlexLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Compatibility.FlexLayout>() =
    inherit Compatibility.LayoutBuilder2<'Element, Microsoft.Maui.Controls.View>()

    [<CustomOperation("Direction")>] member inline this.Direction ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Direction), (fun ctx x -> ctx.Element.Direction <- x), x)
    [<CustomOperation("Direction")>] member inline this.Direction ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Direction), (fun ctx x -> ctx.Element.Direction <- x), x)
    [<CustomOperation("JustifyContent")>] member inline this.JustifyContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexJustify) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.JustifyContent), (fun ctx x -> ctx.Element.JustifyContent <- x), x)
    [<CustomOperation("JustifyContent")>] member inline this.JustifyContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.JustifyContent), (fun ctx x -> ctx.Element.JustifyContent <- x), x)
    [<CustomOperation("AlignContent")>] member inline this.AlignContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexAlignContent) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlignContent), (fun ctx x -> ctx.Element.AlignContent <- x), x)
    [<CustomOperation("AlignContent")>] member inline this.AlignContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlignContent), (fun ctx x -> ctx.Element.AlignContent <- x), x)
    [<CustomOperation("AlignItems")>] member inline this.AlignItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexAlignItems) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlignItems), (fun ctx x -> ctx.Element.AlignItems <- x), x)
    [<CustomOperation("AlignItems")>] member inline this.AlignItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlignItems), (fun ctx x -> ctx.Element.AlignItems <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Wrap")>] member inline this.Wrap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexWrap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Wrap), (fun ctx x -> ctx.Element.Wrap <- x), x)
    [<CustomOperation("Wrap")>] member inline this.Wrap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Wrap), (fun ctx x -> ctx.Element.Wrap <- x), x)

                

type GridBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Compatibility.Grid>() =
    inherit Compatibility.LayoutBuilder2<'Element, Microsoft.Maui.Controls.View>()


    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ColumnDefinitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDefinitions), (fun ctx x -> ctx.Element.ColumnDefinitions <- x), x)
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDefinitions), (fun ctx x -> ctx.Element.ColumnDefinitions <- x), x)
    [<CustomOperation("ColumnSpacing")>] member inline this.ColumnSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnSpacing), (fun ctx x -> ctx.Element.ColumnSpacing <- x), x)
    [<CustomOperation("ColumnSpacing")>] member inline this.ColumnSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnSpacing), (fun ctx x -> ctx.Element.ColumnSpacing <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.RowDefinitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDefinitions), (fun ctx x -> ctx.Element.RowDefinitions <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowDefinitions), (fun ctx x -> ctx.Element.RowDefinitions <- x), x)
    [<CustomOperation("RowSpacing")>] member inline this.RowSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowSpacing), (fun ctx x -> ctx.Element.RowSpacing <- x), x)
    [<CustomOperation("RowSpacing")>] member inline this.RowSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowSpacing), (fun ctx x -> ctx.Element.RowSpacing <- x), x)

                

type RelativeLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Compatibility.RelativeLayout>() =
    inherit Compatibility.LayoutBuilder2<'Element, Microsoft.Maui.Controls.View>()


    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.View>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.View[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )
                        

                

type StackLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Compatibility.StackLayout>() =
    inherit Compatibility.LayoutBuilder2<'Element, Microsoft.Maui.Controls.View>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.StackOrientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)
    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)

                
            
namespace rec Fun.SunUI.MAUI.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type ItemsViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ItemsView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("EmptyView")>] member inline this.EmptyView ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EmptyView), (fun ctx x -> ctx.Element.EmptyView <- x), x)
    [<CustomOperation("EmptyView")>] member inline this.EmptyView ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EmptyView), (fun ctx x -> ctx.Element.EmptyView <- x), x)
    [<CustomOperation("EmptyViewTemplate")>] member inline this.EmptyViewTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EmptyViewTemplate), (fun ctx x -> ctx.Element.EmptyViewTemplate <- x), x)
    [<CustomOperation("EmptyViewTemplate")>] member inline this.EmptyViewTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EmptyViewTemplate), (fun ctx x -> ctx.Element.EmptyViewTemplate <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("RemainingItemsThresholdReachedCommand")>] member inline this.RemainingItemsThresholdReachedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThresholdReachedCommand), (fun ctx x -> ctx.Element.RemainingItemsThresholdReachedCommand <- x), x)
    [<CustomOperation("RemainingItemsThresholdReachedCommand")>] member inline this.RemainingItemsThresholdReachedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThresholdReachedCommand), (fun ctx x -> ctx.Element.RemainingItemsThresholdReachedCommand <- x), x)
    [<CustomOperation("RemainingItemsThresholdReachedCommandParameter")>] member inline this.RemainingItemsThresholdReachedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThresholdReachedCommandParameter), (fun ctx x -> ctx.Element.RemainingItemsThresholdReachedCommandParameter <- x), x)
    [<CustomOperation("RemainingItemsThresholdReachedCommandParameter")>] member inline this.RemainingItemsThresholdReachedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThresholdReachedCommandParameter), (fun ctx x -> ctx.Element.RemainingItemsThresholdReachedCommandParameter <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("RemainingItemsThreshold")>] member inline this.RemainingItemsThreshold ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThreshold), (fun ctx x -> ctx.Element.RemainingItemsThreshold <- x), x)
    [<CustomOperation("RemainingItemsThreshold")>] member inline this.RemainingItemsThreshold ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThreshold), (fun ctx x -> ctx.Element.RemainingItemsThreshold <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemsUpdatingScrollMode")>] member inline this.ItemsUpdatingScrollMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ItemsUpdatingScrollMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsUpdatingScrollMode), (fun ctx x -> ctx.Element.ItemsUpdatingScrollMode <- x), x)
    [<CustomOperation("ItemsUpdatingScrollMode")>] member inline this.ItemsUpdatingScrollMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsUpdatingScrollMode), (fun ctx x -> ctx.Element.ItemsUpdatingScrollMode <- x), x)

    [<CustomOperation("ScrollToRequested")>] member inline this.ScrollToRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollToRequested), "ScrollToRequested", fn)
    [<CustomOperation("Scrolled")>] member inline this.Scrolled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scrolled), "Scrolled", fn)
    [<CustomOperation("RemainingItemsThresholdReached")>] member inline this.RemainingItemsThresholdReached ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RemainingItemsThresholdReached), "RemainingItemsThresholdReached", fn)
                

type StructuredItemsViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.StructuredItemsView>() =
    inherit ItemsViewBuilder<'Element>()

    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("Footer")>] member inline this.Footer ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Footer), (fun ctx x -> ctx.Element.Footer <- x), x)
    [<CustomOperation("Footer")>] member inline this.Footer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Footer), (fun ctx x -> ctx.Element.Footer <- x), x)
    [<CustomOperation("FooterTemplate")>] member inline this.FooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTemplate), (fun ctx x -> ctx.Element.FooterTemplate <- x), x)
    [<CustomOperation("FooterTemplate")>] member inline this.FooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTemplate), (fun ctx x -> ctx.Element.FooterTemplate <- x), x)
    [<CustomOperation("ItemsLayout")>] member inline this.ItemsLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.IItemsLayout) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsLayout), (fun ctx x -> ctx.Element.ItemsLayout <- x), x)
    [<CustomOperation("ItemsLayout")>] member inline this.ItemsLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsLayout), (fun ctx x -> ctx.Element.ItemsLayout <- x), x)
    [<CustomOperation("ItemSizingStrategy")>] member inline this.ItemSizingStrategy ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ItemSizingStrategy) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemSizingStrategy), (fun ctx x -> ctx.Element.ItemSizingStrategy <- x), x)
    [<CustomOperation("ItemSizingStrategy")>] member inline this.ItemSizingStrategy ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemSizingStrategy), (fun ctx x -> ctx.Element.ItemSizingStrategy <- x), x)

                

type SelectableItemsViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SelectableItemsView>() =
    inherit StructuredItemsViewBuilder<'Element>()

    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<System.Object>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItems), (fun ctx x -> ctx.Element.SelectedItems <- x), x)
    [<CustomOperation("SelectedItems")>] member inline this.SelectedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItems), (fun ctx x -> ctx.Element.SelectedItems <- x), x)
    [<CustomOperation("SelectionChangedCommand")>] member inline this.SelectionChangedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChangedCommand), (fun ctx x -> ctx.Element.SelectionChangedCommand <- x), x)
    [<CustomOperation("SelectionChangedCommand")>] member inline this.SelectionChangedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChangedCommand), (fun ctx x -> ctx.Element.SelectionChangedCommand <- x), x)
    [<CustomOperation("SelectionChangedCommandParameter")>] member inline this.SelectionChangedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChangedCommandParameter), (fun ctx x -> ctx.Element.SelectionChangedCommandParameter <- x), x)
    [<CustomOperation("SelectionChangedCommandParameter")>] member inline this.SelectionChangedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChangedCommandParameter), (fun ctx x -> ctx.Element.SelectionChangedCommandParameter <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.SelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)

    [<CustomOperation("SelectionChanged")>] member inline this.SelectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionChanged), "SelectionChanged", fn)
                

type GroupableItemsViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.GroupableItemsView>() =
    inherit SelectableItemsViewBuilder<'Element>()

    [<CustomOperation("IsGrouped")>] member inline this.IsGrouped ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsGrouped), (fun ctx x -> ctx.Element.IsGrouped <- x), x)
    [<CustomOperation("IsGrouped")>] member inline this.IsGrouped ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsGrouped), (fun ctx x -> ctx.Element.IsGrouped <- x), x)
    [<CustomOperation("GroupHeaderTemplate")>] member inline this.GroupHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderTemplate), (fun ctx x -> ctx.Element.GroupHeaderTemplate <- x), x)
    [<CustomOperation("GroupHeaderTemplate")>] member inline this.GroupHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderTemplate), (fun ctx x -> ctx.Element.GroupHeaderTemplate <- x), x)
    [<CustomOperation("GroupFooterTemplate")>] member inline this.GroupFooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupFooterTemplate), (fun ctx x -> ctx.Element.GroupFooterTemplate <- x), x)
    [<CustomOperation("GroupFooterTemplate")>] member inline this.GroupFooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupFooterTemplate), (fun ctx x -> ctx.Element.GroupFooterTemplate <- x), x)

                

type ReorderableItemsViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ReorderableItemsView>() =
    inherit GroupableItemsViewBuilder<'Element>()

    [<CustomOperation("CanMixGroups")>] member inline this.CanMixGroups ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanMixGroups), (fun ctx x -> ctx.Element.CanMixGroups <- x), x)
    [<CustomOperation("CanMixGroups")>] member inline this.CanMixGroups ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanMixGroups), (fun ctx x -> ctx.Element.CanMixGroups <- x), x)
    [<CustomOperation("CanReorderItems")>] member inline this.CanReorderItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderItems), (fun ctx x -> ctx.Element.CanReorderItems <- x), x)
    [<CustomOperation("CanReorderItems")>] member inline this.CanReorderItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanReorderItems), (fun ctx x -> ctx.Element.CanReorderItems <- x), x)

    [<CustomOperation("ReorderCompleted")>] member inline this.ReorderCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ReorderCompleted), "ReorderCompleted", fn)
                

type CollectionViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.CollectionView>() =
    inherit ReorderableItemsViewBuilder<'Element>()


                

type CarouselViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.CarouselView>() =
    inherit ItemsViewBuilder<'Element>()

    [<CustomOperation("Loop")>] member inline this.Loop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Loop), (fun ctx x -> ctx.Element.Loop <- x), x)
    [<CustomOperation("Loop")>] member inline this.Loop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Loop), (fun ctx x -> ctx.Element.Loop <- x), x)
    [<CustomOperation("PeekAreaInsets")>] member inline this.PeekAreaInsets ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PeekAreaInsets), (fun ctx x -> ctx.Element.PeekAreaInsets <- x), x)
    [<CustomOperation("PeekAreaInsets")>] member inline this.PeekAreaInsets ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PeekAreaInsets), (fun ctx x -> ctx.Element.PeekAreaInsets <- x), x)
    [<CustomOperation("VisibleViews")>] member inline this.VisibleViews ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.VisibleViews), x)
    [<CustomOperation("VisibleViews'")>] member inline this.VisibleViews' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.VisibleViews), x)
    [<CustomOperation("IsBounceEnabled")>] member inline this.IsBounceEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsBounceEnabled), (fun ctx x -> ctx.Element.IsBounceEnabled <- x), x)
    [<CustomOperation("IsBounceEnabled")>] member inline this.IsBounceEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsBounceEnabled), (fun ctx x -> ctx.Element.IsBounceEnabled <- x), x)
    [<CustomOperation("IsSwipeEnabled")>] member inline this.IsSwipeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSwipeEnabled), (fun ctx x -> ctx.Element.IsSwipeEnabled <- x), x)
    [<CustomOperation("IsSwipeEnabled")>] member inline this.IsSwipeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSwipeEnabled), (fun ctx x -> ctx.Element.IsSwipeEnabled <- x), x)
    [<CustomOperation("IsScrollAnimated")>] member inline this.IsScrollAnimated ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrollAnimated), (fun ctx x -> ctx.Element.IsScrollAnimated <- x), x)
    [<CustomOperation("IsScrollAnimated")>] member inline this.IsScrollAnimated ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrollAnimated), (fun ctx x -> ctx.Element.IsScrollAnimated <- x), x)
    [<CustomOperation("CurrentItem")>] member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItem), (fun ctx x -> ctx.Element.CurrentItem <- x), x)
    [<CustomOperation("CurrentItem")>] member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItem), (fun ctx x -> ctx.Element.CurrentItem <- x), x)
    [<CustomOperation("CurrentItemChangedCommand")>] member inline this.CurrentItemChangedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItemChangedCommand), (fun ctx x -> ctx.Element.CurrentItemChangedCommand <- x), x)
    [<CustomOperation("CurrentItemChangedCommand")>] member inline this.CurrentItemChangedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItemChangedCommand), (fun ctx x -> ctx.Element.CurrentItemChangedCommand <- x), x)
    [<CustomOperation("CurrentItemChangedCommandParameter")>] member inline this.CurrentItemChangedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItemChangedCommandParameter), (fun ctx x -> ctx.Element.CurrentItemChangedCommandParameter <- x), x)
    [<CustomOperation("CurrentItemChangedCommandParameter")>] member inline this.CurrentItemChangedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItemChangedCommandParameter), (fun ctx x -> ctx.Element.CurrentItemChangedCommandParameter <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("PositionChangedCommand")>] member inline this.PositionChangedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PositionChangedCommand), (fun ctx x -> ctx.Element.PositionChangedCommand <- x), x)
    [<CustomOperation("PositionChangedCommand")>] member inline this.PositionChangedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PositionChangedCommand), (fun ctx x -> ctx.Element.PositionChangedCommand <- x), x)
    [<CustomOperation("PositionChangedCommandParameter")>] member inline this.PositionChangedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PositionChangedCommandParameter), (fun ctx x -> ctx.Element.PositionChangedCommandParameter <- x), x)
    [<CustomOperation("PositionChangedCommandParameter")>] member inline this.PositionChangedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PositionChangedCommandParameter), (fun ctx x -> ctx.Element.PositionChangedCommandParameter <- x), x)
    [<CustomOperation("ItemsLayout")>] member inline this.ItemsLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.LinearItemsLayout) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsLayout), (fun ctx x -> ctx.Element.ItemsLayout <- x), x)
    [<CustomOperation("ItemsLayout")>] member inline this.ItemsLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsLayout), (fun ctx x -> ctx.Element.ItemsLayout <- x), x)

    [<CustomOperation("IndicatorView")>]
    member inline this.IndicatorView ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IndicatorView <- x), creator)

    [<CustomOperation("IndicatorView")>]
    member inline this.IndicatorView ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IndicatorView <- x), creator)
                        
    [<CustomOperation("IsScrolling")>] member inline this.IsScrolling ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrolling), (fun ctx x -> ctx.Element.IsScrolling <- x), x)
    [<CustomOperation("IsScrolling")>] member inline this.IsScrolling ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsScrolling), (fun ctx x -> ctx.Element.IsScrolling <- x), x)

    [<CustomOperation("CurrentItemChanged")>] member inline this.CurrentItemChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CurrentItemChanged), "CurrentItemChanged", fn)
    [<CustomOperation("PositionChanged")>] member inline this.PositionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PositionChanged), "PositionChanged", fn)
                

type LayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Layout>() =
    inherit ViewBuilder<'Element>()


    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.IView>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.IView[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Children")>]
    member inline this.Children ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.IView>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.IView[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticChildren")>]
    member inline this.StaticChildren ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.IView>(
            builder,
            (fun x -> x.Element.Children.Clear()),
            (fun x (ls: Microsoft.Maui.IView[]) -> for i in ls do x.Element.Children.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("IsClippedToBounds")>] member inline this.IsClippedToBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsClippedToBounds), (fun ctx x -> ctx.Element.IsClippedToBounds <- x), x)
    [<CustomOperation("IsClippedToBounds")>] member inline this.IsClippedToBounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsClippedToBounds), (fun ctx x -> ctx.Element.IsClippedToBounds <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("IgnoreSafeArea")>] member inline this.IgnoreSafeArea ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IgnoreSafeArea), (fun ctx x -> ctx.Element.IgnoreSafeArea <- x), x)
    [<CustomOperation("IgnoreSafeArea")>] member inline this.IgnoreSafeArea ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IgnoreSafeArea), (fun ctx x -> ctx.Element.IgnoreSafeArea <- x), x)
    [<CustomOperation("CascadeInputTransparent")>] member inline this.CascadeInputTransparent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CascadeInputTransparent), (fun ctx x -> ctx.Element.CascadeInputTransparent <- x), x)
    [<CustomOperation("CascadeInputTransparent")>] member inline this.CascadeInputTransparent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CascadeInputTransparent), (fun ctx x -> ctx.Element.CascadeInputTransparent <- x), x)

                

type StackBaseBuilder<'Element when 'Element :> Microsoft.Maui.Controls.StackBase>() =
    inherit LayoutBuilder<'Element>()

    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)
    [<CustomOperation("Spacing")>] member inline this.Spacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Spacing), (fun ctx x -> ctx.Element.Spacing <- x), x)

                

type HorizontalStackLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.HorizontalStackLayout>() =
    inherit StackBaseBuilder<'Element>()


                

type StackLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.StackLayout>() =
    inherit StackBaseBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.StackOrientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                

type VerticalStackLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.VerticalStackLayout>() =
    inherit StackBaseBuilder<'Element>()


                

type AbsoluteLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.AbsoluteLayout>() =
    inherit LayoutBuilder<'Element>()


                

type FlexLayoutBuilder<'Element when 'Element :> Microsoft.Maui.Controls.FlexLayout>() =
    inherit LayoutBuilder<'Element>()

    [<CustomOperation("Direction")>] member inline this.Direction ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Direction), (fun ctx x -> ctx.Element.Direction <- x), x)
    [<CustomOperation("Direction")>] member inline this.Direction ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Direction), (fun ctx x -> ctx.Element.Direction <- x), x)
    [<CustomOperation("JustifyContent")>] member inline this.JustifyContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexJustify) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.JustifyContent), (fun ctx x -> ctx.Element.JustifyContent <- x), x)
    [<CustomOperation("JustifyContent")>] member inline this.JustifyContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.JustifyContent), (fun ctx x -> ctx.Element.JustifyContent <- x), x)
    [<CustomOperation("AlignContent")>] member inline this.AlignContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexAlignContent) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlignContent), (fun ctx x -> ctx.Element.AlignContent <- x), x)
    [<CustomOperation("AlignContent")>] member inline this.AlignContent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlignContent), (fun ctx x -> ctx.Element.AlignContent <- x), x)
    [<CustomOperation("AlignItems")>] member inline this.AlignItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexAlignItems) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AlignItems), (fun ctx x -> ctx.Element.AlignItems <- x), x)
    [<CustomOperation("AlignItems")>] member inline this.AlignItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AlignItems), (fun ctx x -> ctx.Element.AlignItems <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Position")>] member inline this.Position ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Position), (fun ctx x -> ctx.Element.Position <- x), x)
    [<CustomOperation("Wrap")>] member inline this.Wrap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Layouts.FlexWrap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Wrap), (fun ctx x -> ctx.Element.Wrap <- x), x)
    [<CustomOperation("Wrap")>] member inline this.Wrap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Wrap), (fun ctx x -> ctx.Element.Wrap <- x), x)

                

type GridBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Grid>() =
    inherit LayoutBuilder<'Element>()

    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ColumnDefinitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDefinitions), (fun ctx x -> ctx.Element.ColumnDefinitions <- x), x)
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnDefinitions), (fun ctx x -> ctx.Element.ColumnDefinitions <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.RowDefinitionCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowDefinitions), (fun ctx x -> ctx.Element.RowDefinitions <- x), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowDefinitions), (fun ctx x -> ctx.Element.RowDefinitions <- x), x)
    [<CustomOperation("RowSpacing")>] member inline this.RowSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowSpacing), (fun ctx x -> ctx.Element.RowSpacing <- x), x)
    [<CustomOperation("RowSpacing")>] member inline this.RowSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowSpacing), (fun ctx x -> ctx.Element.RowSpacing <- x), x)
    [<CustomOperation("ColumnSpacing")>] member inline this.ColumnSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnSpacing), (fun ctx x -> ctx.Element.ColumnSpacing <- x), x)
    [<CustomOperation("ColumnSpacing")>] member inline this.ColumnSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ColumnSpacing), (fun ctx x -> ctx.Element.ColumnSpacing <- x), x)

                

type InputViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.InputView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("MaxLength")>] member inline this.MaxLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLength), (fun ctx x -> ctx.Element.MaxLength <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Keyboard")>] member inline this.Keyboard ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Keyboard) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Keyboard), (fun ctx x -> ctx.Element.Keyboard <- x), x)
    [<CustomOperation("Keyboard")>] member inline this.Keyboard ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Keyboard), (fun ctx x -> ctx.Element.Keyboard <- x), x)
    [<CustomOperation("IsSpellCheckEnabled")>] member inline this.IsSpellCheckEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsSpellCheckEnabled), (fun ctx x -> ctx.Element.IsSpellCheckEnabled <- x), x)
    [<CustomOperation("IsSpellCheckEnabled")>] member inline this.IsSpellCheckEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsSpellCheckEnabled), (fun ctx x -> ctx.Element.IsSpellCheckEnabled <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("IsReadOnly")>] member inline this.IsReadOnly ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsReadOnly), (fun ctx x -> ctx.Element.IsReadOnly <- x), x)
    [<CustomOperation("Placeholder")>] member inline this.Placeholder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placeholder), (fun ctx x -> ctx.Element.Placeholder <- x), x)
    [<CustomOperation("Placeholder")>] member inline this.Placeholder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placeholder), (fun ctx x -> ctx.Element.Placeholder <- x), x)
    [<CustomOperation("PlaceholderColor")>] member inline this.PlaceholderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderColor), (fun ctx x -> ctx.Element.PlaceholderColor <- x), x)
    [<CustomOperation("PlaceholderColor")>] member inline this.PlaceholderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.PlaceholderColor), (fun ctx x -> ctx.Element.PlaceholderColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextTransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)

    [<CustomOperation("TextChanged")>] member inline this.TextChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.TextChanged), "TextChanged", fn)
                

type EditorBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Editor>() =
    inherit InputViewBuilder<'Element>()

    [<CustomOperation("AutoSize")>] member inline this.AutoSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.EditorAutoSizeOption) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSize), (fun ctx x -> ctx.Element.AutoSize <- x), x)
    [<CustomOperation("AutoSize")>] member inline this.AutoSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AutoSize), (fun ctx x -> ctx.Element.AutoSize <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)

    [<CustomOperation("Completed")>] member inline this.Completed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Completed), "Completed", fn)
                

type EntryBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Entry>() =
    inherit InputViewBuilder<'Element>()

    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("IsPassword")>] member inline this.IsPassword ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPassword), (fun ctx x -> ctx.Element.IsPassword <- x), x)
    [<CustomOperation("IsPassword")>] member inline this.IsPassword ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPassword), (fun ctx x -> ctx.Element.IsPassword <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("ReturnType")>] member inline this.ReturnType ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ReturnType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReturnType), (fun ctx x -> ctx.Element.ReturnType <- x), x)
    [<CustomOperation("ReturnType")>] member inline this.ReturnType ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReturnType), (fun ctx x -> ctx.Element.ReturnType <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("ReturnCommand")>] member inline this.ReturnCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReturnCommand), (fun ctx x -> ctx.Element.ReturnCommand <- x), x)
    [<CustomOperation("ReturnCommand")>] member inline this.ReturnCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReturnCommand), (fun ctx x -> ctx.Element.ReturnCommand <- x), x)
    [<CustomOperation("ReturnCommandParameter")>] member inline this.ReturnCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ReturnCommandParameter), (fun ctx x -> ctx.Element.ReturnCommandParameter <- x), x)
    [<CustomOperation("ReturnCommandParameter")>] member inline this.ReturnCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ReturnCommandParameter), (fun ctx x -> ctx.Element.ReturnCommandParameter <- x), x)
    [<CustomOperation("ClearButtonVisibility")>] member inline this.ClearButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ClearButtonVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ClearButtonVisibility), (fun ctx x -> ctx.Element.ClearButtonVisibility <- x), x)
    [<CustomOperation("ClearButtonVisibility")>] member inline this.ClearButtonVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ClearButtonVisibility), (fun ctx x -> ctx.Element.ClearButtonVisibility <- x), x)

    [<CustomOperation("Completed")>] member inline this.Completed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Completed), "Completed", fn)
                

type SearchBarBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SearchBar>() =
    inherit InputViewBuilder<'Element>()

    [<CustomOperation("CancelButtonColor")>] member inline this.CancelButtonColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CancelButtonColor), (fun ctx x -> ctx.Element.CancelButtonColor <- x), x)
    [<CustomOperation("CancelButtonColor")>] member inline this.CancelButtonColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CancelButtonColor), (fun ctx x -> ctx.Element.CancelButtonColor <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("SearchCommand")>] member inline this.SearchCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SearchCommand), (fun ctx x -> ctx.Element.SearchCommand <- x), x)
    [<CustomOperation("SearchCommand")>] member inline this.SearchCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SearchCommand), (fun ctx x -> ctx.Element.SearchCommand <- x), x)
    [<CustomOperation("SearchCommandParameter")>] member inline this.SearchCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SearchCommandParameter), (fun ctx x -> ctx.Element.SearchCommandParameter <- x), x)
    [<CustomOperation("SearchCommandParameter")>] member inline this.SearchCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SearchCommandParameter), (fun ctx x -> ctx.Element.SearchCommandParameter <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("IsTextPredictionEnabled")>] member inline this.IsTextPredictionEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsTextPredictionEnabled), (fun ctx x -> ctx.Element.IsTextPredictionEnabled <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("CursorPosition")>] member inline this.CursorPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CursorPosition), (fun ctx x -> ctx.Element.CursorPosition <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("SelectionLength")>] member inline this.SelectionLength ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionLength), (fun ctx x -> ctx.Element.SelectionLength <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)

    [<CustomOperation("SearchButtonPressed")>] member inline this.SearchButtonPressed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SearchButtonPressed), "SearchButtonPressed", fn)
                
            
namespace rec Fun.SunUI.MAUI.DslInternals.Shapes

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type ShapeBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Shapes.Shape>() =
    inherit ViewBuilder<'Element>()


    [<CustomOperation("Fill")>]
    member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Fill <- x), creator)

    [<CustomOperation("Fill")>]
    member inline this.Fill ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Fill <- x), creator)
                        

    [<CustomOperation("Stroke")>]
    member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Stroke <- x), creator)

    [<CustomOperation("Stroke")>]
    member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Stroke <- x), creator)
                        
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DoubleCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeLineCap")>] member inline this.StrokeLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Shapes.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineCap), (fun ctx x -> ctx.Element.StrokeLineCap <- x), x)
    [<CustomOperation("StrokeLineCap")>] member inline this.StrokeLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineCap), (fun ctx x -> ctx.Element.StrokeLineCap <- x), x)
    [<CustomOperation("StrokeLineJoin")>] member inline this.StrokeLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Shapes.PenLineJoin) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineJoin), (fun ctx x -> ctx.Element.StrokeLineJoin <- x), x)
    [<CustomOperation("StrokeLineJoin")>] member inline this.StrokeLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineJoin), (fun ctx x -> ctx.Element.StrokeLineJoin <- x), x)
    [<CustomOperation("StrokeMiterLimit")>] member inline this.StrokeMiterLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeMiterLimit), (fun ctx x -> ctx.Element.StrokeMiterLimit <- x), x)
    [<CustomOperation("StrokeMiterLimit")>] member inline this.StrokeMiterLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeMiterLimit), (fun ctx x -> ctx.Element.StrokeMiterLimit <- x), x)
    [<CustomOperation("Aspect")>] member inline this.Aspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Stretch) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Aspect), (fun ctx x -> ctx.Element.Aspect <- x), x)
    [<CustomOperation("Aspect")>] member inline this.Aspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Aspect), (fun ctx x -> ctx.Element.Aspect <- x), x)
    [<CustomOperation("StrokeDashPattern")>] member inline this.StrokeDashPattern ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.StrokeDashPattern), x)
    [<CustomOperation("StrokeDashPattern'")>] member inline this.StrokeDashPattern' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.StrokeDashPattern), x)

                

type EllipseBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.Ellipse>()


                

type LineBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.Line>()

    [<CustomOperation("X1")>] member inline this.X1 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.X1), (fun ctx x -> ctx.Element.X1 <- x), x)
    [<CustomOperation("X1")>] member inline this.X1 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.X1), (fun ctx x -> ctx.Element.X1 <- x), x)
    [<CustomOperation("Y1")>] member inline this.Y1 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Y1), (fun ctx x -> ctx.Element.Y1 <- x), x)
    [<CustomOperation("Y1")>] member inline this.Y1 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Y1), (fun ctx x -> ctx.Element.Y1 <- x), x)
    [<CustomOperation("X2")>] member inline this.X2 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.X2), (fun ctx x -> ctx.Element.X2 <- x), x)
    [<CustomOperation("X2")>] member inline this.X2 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.X2), (fun ctx x -> ctx.Element.X2 <- x), x)
    [<CustomOperation("Y2")>] member inline this.Y2 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Y2), (fun ctx x -> ctx.Element.Y2 <- x), x)
    [<CustomOperation("Y2")>] member inline this.Y2 ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Y2), (fun ctx x -> ctx.Element.Y2 <- x), x)

                

type PathBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.Path>()

    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Path>, x: Microsoft.Maui.Controls.Shapes.Geometry) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)
    [<CustomOperation("Data")>] member inline this.Data ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Path>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Data), (fun ctx x -> ctx.Element.Data <- x), x)
    [<CustomOperation("RenderTransform")>] member inline this.RenderTransform ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Path>, x: Microsoft.Maui.Controls.Shapes.Transform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RenderTransform), (fun ctx x -> ctx.Element.RenderTransform <- x), x)
    [<CustomOperation("RenderTransform")>] member inline this.RenderTransform ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Path>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RenderTransform), (fun ctx x -> ctx.Element.RenderTransform <- x), x)

                

type PolygonBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.Polygon>()

    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polygon>, x: Microsoft.Maui.Controls.PointCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polygon>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polygon>, x: Microsoft.Maui.Controls.Shapes.FillRule) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polygon>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)

                

type PolylineBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.Polyline>()

    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polyline>, x: Microsoft.Maui.Controls.PointCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("Points")>] member inline this.Points ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polyline>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Points), (fun ctx x -> ctx.Element.Points <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polyline>, x: Microsoft.Maui.Controls.Shapes.FillRule) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)
    [<CustomOperation("FillRule")>] member inline this.FillRule ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polyline>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FillRule), (fun ctx x -> ctx.Element.FillRule <- x), x)

                

type RectangleBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.Rectangle>()

    [<CustomOperation("RadiusX")>] member inline this.RadiusX ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Rectangle>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusX), (fun ctx x -> ctx.Element.RadiusX <- x), x)
    [<CustomOperation("RadiusX")>] member inline this.RadiusX ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Rectangle>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusX), (fun ctx x -> ctx.Element.RadiusX <- x), x)
    [<CustomOperation("RadiusY")>] member inline this.RadiusY ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Rectangle>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusY), (fun ctx x -> ctx.Element.RadiusY <- x), x)
    [<CustomOperation("RadiusY")>] member inline this.RadiusY ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Rectangle>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RadiusY), (fun ctx x -> ctx.Element.RadiusY <- x), x)

                

type RoundRectangleBuilder() =
    inherit Shapes.ShapeBuilder<Microsoft.Maui.Controls.Shapes.RoundRectangle>()

    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.RoundRectangle>, x: Microsoft.Maui.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.RoundRectangle>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)

                
            
namespace rec Fun.SunUI.MAUI.DslInternals

open FSharp.Data.Adaptive
open Fun.SunUI.MAUI.DslInternals
open Fun.SunUI
open Fun.SunUI.MAUI


type ActivityIndicatorBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ActivityIndicator>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("IsRunning")>] member inline this.IsRunning ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsRunning), (fun ctx x -> ctx.Element.IsRunning <- x), x)
    [<CustomOperation("IsRunning")>] member inline this.IsRunning ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsRunning), (fun ctx x -> ctx.Element.IsRunning <- x), x)

                

type BorderBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Border>() =
    inherit ViewBuilder<'Element>()


    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("StrokeShape")>] member inline this.StrokeShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.IShape) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeShape), (fun ctx x -> ctx.Element.StrokeShape <- x), x)
    [<CustomOperation("StrokeShape")>] member inline this.StrokeShape ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeShape), (fun ctx x -> ctx.Element.StrokeShape <- x), x)

    [<CustomOperation("Stroke")>]
    member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Stroke <- x), creator)

    [<CustomOperation("Stroke")>]
    member inline this.Stroke ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Stroke <- x), creator)
                        
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeThickness")>] member inline this.StrokeThickness ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeThickness), (fun ctx x -> ctx.Element.StrokeThickness <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DoubleCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashArray")>] member inline this.StrokeDashArray ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashArray), (fun ctx x -> ctx.Element.StrokeDashArray <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeDashOffset")>] member inline this.StrokeDashOffset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeDashOffset), (fun ctx x -> ctx.Element.StrokeDashOffset <- x), x)
    [<CustomOperation("StrokeLineCap")>] member inline this.StrokeLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Shapes.PenLineCap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineCap), (fun ctx x -> ctx.Element.StrokeLineCap <- x), x)
    [<CustomOperation("StrokeLineCap")>] member inline this.StrokeLineCap ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineCap), (fun ctx x -> ctx.Element.StrokeLineCap <- x), x)
    [<CustomOperation("StrokeLineJoin")>] member inline this.StrokeLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Shapes.PenLineJoin) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineJoin), (fun ctx x -> ctx.Element.StrokeLineJoin <- x), x)
    [<CustomOperation("StrokeLineJoin")>] member inline this.StrokeLineJoin ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeLineJoin), (fun ctx x -> ctx.Element.StrokeLineJoin <- x), x)
    [<CustomOperation("StrokeMiterLimit")>] member inline this.StrokeMiterLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeMiterLimit), (fun ctx x -> ctx.Element.StrokeMiterLimit <- x), x)
    [<CustomOperation("StrokeMiterLimit")>] member inline this.StrokeMiterLimit ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StrokeMiterLimit), (fun ctx x -> ctx.Element.StrokeMiterLimit <- x), x)
    [<CustomOperation("StrokeDashPattern")>] member inline this.StrokeDashPattern ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.StrokeDashPattern), x)
    [<CustomOperation("StrokeDashPattern'")>] member inline this.StrokeDashPattern' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.StrokeDashPattern), x)

                

type BoxViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.BoxView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.CornerRadius) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)

                

type ButtonBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Button>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("LineBreakMode")>] member inline this.LineBreakMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.LineBreakMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineBreakMode), (fun ctx x -> ctx.Element.LineBreakMode <- x), x)
    [<CustomOperation("LineBreakMode")>] member inline this.LineBreakMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineBreakMode), (fun ctx x -> ctx.Element.LineBreakMode <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("BorderWidth")>] member inline this.BorderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderWidth), (fun ctx x -> ctx.Element.BorderWidth <- x), x)
    [<CustomOperation("BorderWidth")>] member inline this.BorderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderWidth), (fun ctx x -> ctx.Element.BorderWidth <- x), x)
    [<CustomOperation("ContentLayout")>] member inline this.ContentLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Button.ButtonContentLayout) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentLayout), (fun ctx x -> ctx.Element.ContentLayout <- x), x)
    [<CustomOperation("ContentLayout")>] member inline this.ContentLayout ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentLayout), (fun ctx x -> ctx.Element.ContentLayout <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)

    [<CustomOperation("ImageSource")>]
    member inline this.ImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ImageSource <- x), creator)

    [<CustomOperation("ImageSource")>]
    member inline this.ImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ImageSource <- x), creator)
                        
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextTransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)

    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Clicked), "Clicked", fn)
    [<CustomOperation("Pressed")>] member inline this.Pressed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Pressed), "Pressed", fn)
    [<CustomOperation("Released")>] member inline this.Released ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Released), "Released", fn)
                

type CheckBoxBuilder<'Element when 'Element :> Microsoft.Maui.Controls.CheckBox>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("IsChecked")>] member inline this.IsChecked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsChecked), (fun ctx x -> ctx.Element.IsChecked <- x), x)
    [<CustomOperation("Foreground")>] member inline this.Foreground ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Foreground), x)
    [<CustomOperation("Foreground'")>] member inline this.Foreground' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Foreground), x)

    [<CustomOperation("CheckedChanged")>] member inline this.CheckedChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CheckedChanged), "CheckedChanged", fn)
                

type DatePickerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.DatePicker>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("Date")>] member inline this.Date ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Date), (fun ctx x -> ctx.Element.Date <- x), x)
    [<CustomOperation("Format")>] member inline this.Format ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Format), (fun ctx x -> ctx.Element.Format <- x), x)
    [<CustomOperation("Format")>] member inline this.Format ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Format), (fun ctx x -> ctx.Element.Format <- x), x)
    [<CustomOperation("MaximumDate")>] member inline this.MaximumDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumDate), (fun ctx x -> ctx.Element.MaximumDate <- x), x)
    [<CustomOperation("MaximumDate")>] member inline this.MaximumDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumDate), (fun ctx x -> ctx.Element.MaximumDate <- x), x)
    [<CustomOperation("MinimumDate")>] member inline this.MinimumDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.DateTime) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumDate), (fun ctx x -> ctx.Element.MinimumDate <- x), x)
    [<CustomOperation("MinimumDate")>] member inline this.MinimumDate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumDate), (fun ctx x -> ctx.Element.MinimumDate <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)

    [<CustomOperation("DateSelected")>] member inline this.DateSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DateSelected), "DateSelected", fn)
                

type GraphicsViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.GraphicsView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Drawable")>] member inline this.Drawable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.IDrawable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Drawable), (fun ctx x -> ctx.Element.Drawable <- x), x)
    [<CustomOperation("Drawable")>] member inline this.Drawable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Drawable), (fun ctx x -> ctx.Element.Drawable <- x), x)

    [<CustomOperation("StartHoverInteraction")>] member inline this.StartHoverInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StartHoverInteraction), "StartHoverInteraction", fn)
    [<CustomOperation("MoveHoverInteraction")>] member inline this.MoveHoverInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MoveHoverInteraction), "MoveHoverInteraction", fn)
    [<CustomOperation("EndHoverInteraction")>] member inline this.EndHoverInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.EndHoverInteraction), "EndHoverInteraction", fn)
    [<CustomOperation("StartInteraction")>] member inline this.StartInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.StartInteraction), "StartInteraction", fn)
    [<CustomOperation("DragInteraction")>] member inline this.DragInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragInteraction), "DragInteraction", fn)
    [<CustomOperation("EndInteraction")>] member inline this.EndInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.EndInteraction), "EndInteraction", fn)
    [<CustomOperation("CancelInteraction")>] member inline this.CancelInteraction ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CancelInteraction), "CancelInteraction", fn)
                

type ImageBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Image>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Aspect")>] member inline this.Aspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Aspect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Aspect), (fun ctx x -> ctx.Element.Aspect <- x), x)
    [<CustomOperation("Aspect")>] member inline this.Aspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Aspect), (fun ctx x -> ctx.Element.Aspect <- x), x)
    [<CustomOperation("IsOpaque")>] member inline this.IsOpaque ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpaque), (fun ctx x -> ctx.Element.IsOpaque <- x), x)
    [<CustomOperation("IsOpaque")>] member inline this.IsOpaque ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpaque), (fun ctx x -> ctx.Element.IsOpaque <- x), x)
    [<CustomOperation("IsAnimationPlaying")>] member inline this.IsAnimationPlaying ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsAnimationPlaying), (fun ctx x -> ctx.Element.IsAnimationPlaying <- x), x)
    [<CustomOperation("IsAnimationPlaying")>] member inline this.IsAnimationPlaying ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsAnimationPlaying), (fun ctx x -> ctx.Element.IsAnimationPlaying <- x), x)

    [<CustomOperation("Source")>]
    member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Source <- x), creator)

    [<CustomOperation("Source")>]
    member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Source <- x), creator)
                        

                

type ImageButtonBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ImageButton>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("BorderColor")>] member inline this.BorderColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderColor), (fun ctx x -> ctx.Element.BorderColor <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("CornerRadius")>] member inline this.CornerRadius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CornerRadius), (fun ctx x -> ctx.Element.CornerRadius <- x), x)
    [<CustomOperation("BorderWidth")>] member inline this.BorderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BorderWidth), (fun ctx x -> ctx.Element.BorderWidth <- x), x)
    [<CustomOperation("BorderWidth")>] member inline this.BorderWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BorderWidth), (fun ctx x -> ctx.Element.BorderWidth <- x), x)
    [<CustomOperation("Aspect")>] member inline this.Aspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Aspect) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Aspect), (fun ctx x -> ctx.Element.Aspect <- x), x)
    [<CustomOperation("Aspect")>] member inline this.Aspect ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Aspect), (fun ctx x -> ctx.Element.Aspect <- x), x)
    [<CustomOperation("IsOpaque")>] member inline this.IsOpaque ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpaque), (fun ctx x -> ctx.Element.IsOpaque <- x), x)
    [<CustomOperation("IsOpaque")>] member inline this.IsOpaque ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsOpaque), (fun ctx x -> ctx.Element.IsOpaque <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)

    [<CustomOperation("Source")>]
    member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Source <- x), creator)

    [<CustomOperation("Source")>]
    member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Source <- x), creator)
                        
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)

    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Clicked), "Clicked", fn)
    [<CustomOperation("Pressed")>] member inline this.Pressed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Pressed), "Pressed", fn)
    [<CustomOperation("Released")>] member inline this.Released ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Released), "Released", fn)
                

type LabelBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Label>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextTransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)

    [<CustomOperation("FormattedText")>]
    member inline this.FormattedText ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FormattedText <- x), creator)

    [<CustomOperation("FormattedText")>]
    member inline this.FormattedText ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FormattedText <- x), creator)
                        
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("LineBreakMode")>] member inline this.LineBreakMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.LineBreakMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineBreakMode), (fun ctx x -> ctx.Element.LineBreakMode <- x), x)
    [<CustomOperation("LineBreakMode")>] member inline this.LineBreakMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineBreakMode), (fun ctx x -> ctx.Element.LineBreakMode <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextDecorations) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("MaxLines")>] member inline this.MaxLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLines), (fun ctx x -> ctx.Element.MaxLines <- x), x)
    [<CustomOperation("MaxLines")>] member inline this.MaxLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaxLines), (fun ctx x -> ctx.Element.MaxLines <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Thickness) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("Padding")>] member inline this.Padding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Padding), (fun ctx x -> ctx.Element.Padding <- x), x)
    [<CustomOperation("TextType")>] member inline this.TextType ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextType) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextType), (fun ctx x -> ctx.Element.TextType <- x), x)
    [<CustomOperation("TextType")>] member inline this.TextType ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextType), (fun ctx x -> ctx.Element.TextType <- x), x)

                

type PickerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Picker>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("Items")>] member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("Items'")>] member inline this.Items' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Items), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IList) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedIndex")>] member inline this.SelectedIndex ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndex), (fun ctx x -> ctx.Element.SelectedIndex <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("TitleColor")>] member inline this.TitleColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TitleColor), (fun ctx x -> ctx.Element.TitleColor <- x), x)
    [<CustomOperation("TitleColor")>] member inline this.TitleColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TitleColor), (fun ctx x -> ctx.Element.TitleColor <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("ItemDisplayBinding")>] member inline this.ItemDisplayBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.BindingBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemDisplayBinding), (fun ctx x -> ctx.Element.ItemDisplayBinding <- x), x)
    [<CustomOperation("ItemDisplayBinding")>] member inline this.ItemDisplayBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemDisplayBinding), (fun ctx x -> ctx.Element.ItemDisplayBinding <- x), x)

    [<CustomOperation("SelectedIndexChanged")>] member inline this.SelectedIndexChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedIndexChanged), "SelectedIndexChanged", fn)
                

type ProgressBarBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ProgressBar>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("ProgressColor")>] member inline this.ProgressColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ProgressColor), (fun ctx x -> ctx.Element.ProgressColor <- x), x)
    [<CustomOperation("ProgressColor")>] member inline this.ProgressColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ProgressColor), (fun ctx x -> ctx.Element.ProgressColor <- x), x)
    [<CustomOperation("Progress")>] member inline this.Progress ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Progress), (fun ctx x -> ctx.Element.Progress <- x), x)
    [<CustomOperation("Progress")>] member inline this.Progress ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Progress), (fun ctx x -> ctx.Element.Progress <- x), x)

                

type SliderBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Slider>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("MinimumTrackColor")>] member inline this.MinimumTrackColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumTrackColor), (fun ctx x -> ctx.Element.MinimumTrackColor <- x), x)
    [<CustomOperation("MinimumTrackColor")>] member inline this.MinimumTrackColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumTrackColor), (fun ctx x -> ctx.Element.MinimumTrackColor <- x), x)
    [<CustomOperation("MaximumTrackColor")>] member inline this.MaximumTrackColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumTrackColor), (fun ctx x -> ctx.Element.MaximumTrackColor <- x), x)
    [<CustomOperation("MaximumTrackColor")>] member inline this.MaximumTrackColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumTrackColor), (fun ctx x -> ctx.Element.MaximumTrackColor <- x), x)
    [<CustomOperation("ThumbColor")>] member inline this.ThumbColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ThumbColor), (fun ctx x -> ctx.Element.ThumbColor <- x), x)
    [<CustomOperation("ThumbColor")>] member inline this.ThumbColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ThumbColor), (fun ctx x -> ctx.Element.ThumbColor <- x), x)

    [<CustomOperation("ThumbImageSource")>]
    member inline this.ThumbImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ThumbImageSource <- x), creator)

    [<CustomOperation("ThumbImageSource")>]
    member inline this.ThumbImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ThumbImageSource <- x), creator)
                        
    [<CustomOperation("DragStartedCommand")>] member inline this.DragStartedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStartedCommand), (fun ctx x -> ctx.Element.DragStartedCommand <- x), x)
    [<CustomOperation("DragStartedCommand")>] member inline this.DragStartedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragStartedCommand), (fun ctx x -> ctx.Element.DragStartedCommand <- x), x)
    [<CustomOperation("DragCompletedCommand")>] member inline this.DragCompletedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragCompletedCommand), (fun ctx x -> ctx.Element.DragCompletedCommand <- x), x)
    [<CustomOperation("DragCompletedCommand")>] member inline this.DragCompletedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragCompletedCommand), (fun ctx x -> ctx.Element.DragCompletedCommand <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
    [<CustomOperation("DragStarted")>] member inline this.DragStarted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStarted), "DragStarted", fn)
    [<CustomOperation("DragCompleted")>] member inline this.DragCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragCompleted), "DragCompleted", fn)
                

type StepperBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Stepper>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Increment")>] member inline this.Increment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Increment), (fun ctx x -> ctx.Element.Increment <- x), x)
    [<CustomOperation("Increment")>] member inline this.Increment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Increment), (fun ctx x -> ctx.Element.Increment <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Maximum")>] member inline this.Maximum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Maximum), (fun ctx x -> ctx.Element.Maximum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Minimum")>] member inline this.Minimum ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Minimum), (fun ctx x -> ctx.Element.Minimum <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)
    [<CustomOperation("Value")>] member inline this.Value ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Value), (fun ctx x -> ctx.Element.Value <- x), x)

    [<CustomOperation("ValueChanged")>] member inline this.ValueChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ValueChanged), "ValueChanged", fn)
                

type SwitchBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Switch>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("OnColor")>] member inline this.OnColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnColor), (fun ctx x -> ctx.Element.OnColor <- x), x)
    [<CustomOperation("OnColor")>] member inline this.OnColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OnColor), (fun ctx x -> ctx.Element.OnColor <- x), x)
    [<CustomOperation("ThumbColor")>] member inline this.ThumbColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ThumbColor), (fun ctx x -> ctx.Element.ThumbColor <- x), x)
    [<CustomOperation("ThumbColor")>] member inline this.ThumbColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ThumbColor), (fun ctx x -> ctx.Element.ThumbColor <- x), x)
    [<CustomOperation("IsToggled")>] member inline this.IsToggled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsToggled), (fun ctx x -> ctx.Element.IsToggled <- x), x)
    [<CustomOperation("IsToggled")>] member inline this.IsToggled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsToggled), (fun ctx x -> ctx.Element.IsToggled <- x), x)

    [<CustomOperation("Toggled")>] member inline this.Toggled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Toggled), "Toggled", fn)
                

type TimePickerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.TimePicker>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Format")>] member inline this.Format ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Format), (fun ctx x -> ctx.Element.Format <- x), x)
    [<CustomOperation("Format")>] member inline this.Format ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Format), (fun ctx x -> ctx.Element.Format <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)
    [<CustomOperation("Time")>] member inline this.Time ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Time), (fun ctx x -> ctx.Element.Time <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)

                

type WebViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.WebView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("Cookies")>] member inline this.Cookies ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Net.CookieContainer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Cookies), (fun ctx x -> ctx.Element.Cookies <- x), x)
    [<CustomOperation("Cookies")>] member inline this.Cookies ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Cookies), (fun ctx x -> ctx.Element.Cookies <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.WebViewSource) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)
    [<CustomOperation("Source")>] member inline this.Source ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Source), (fun ctx x -> ctx.Element.Source <- x), x)

    [<CustomOperation("Navigated")>] member inline this.Navigated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigated), "Navigated", fn)
    [<CustomOperation("Navigating")>] member inline this.Navigating ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Navigating), "Navigating", fn)
                

type ItemsViewBuilder2<'Element, 'TVisual when 'TVisual :> Microsoft.Maui.Controls.BindableObject and 'Element :> Microsoft.Maui.Controls.ItemsView<'TVisual>>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.IEnumerable) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemsSource")>] member inline this.ItemsSource ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemsSource), (fun ctx x -> ctx.Element.ItemsSource <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("ItemTemplate")>] member inline this.ItemTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTemplate), (fun ctx x -> ctx.Element.ItemTemplate <- x), x)
    [<CustomOperation("TemplatedItems")>] member inline this.TemplatedItems ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TemplatedItems), x)
    [<CustomOperation("TemplatedItems'")>] member inline this.TemplatedItems' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TemplatedItems), x)

                

type ListViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ListView>() =
    inherit ItemsViewBuilder2<'Element, Microsoft.Maui.Controls.Cell>()

    [<CustomOperation("Footer")>] member inline this.Footer ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Footer), (fun ctx x -> ctx.Element.Footer <- x), x)
    [<CustomOperation("Footer")>] member inline this.Footer ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Footer), (fun ctx x -> ctx.Element.Footer <- x), x)
    [<CustomOperation("FooterTemplate")>] member inline this.FooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTemplate), (fun ctx x -> ctx.Element.FooterTemplate <- x), x)
    [<CustomOperation("FooterTemplate")>] member inline this.FooterTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FooterTemplate), (fun ctx x -> ctx.Element.FooterTemplate <- x), x)
    [<CustomOperation("GroupDisplayBinding")>] member inline this.GroupDisplayBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.BindingBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupDisplayBinding), (fun ctx x -> ctx.Element.GroupDisplayBinding <- x), x)
    [<CustomOperation("GroupDisplayBinding")>] member inline this.GroupDisplayBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupDisplayBinding), (fun ctx x -> ctx.Element.GroupDisplayBinding <- x), x)
    [<CustomOperation("GroupHeaderTemplate")>] member inline this.GroupHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderTemplate), (fun ctx x -> ctx.Element.GroupHeaderTemplate <- x), x)
    [<CustomOperation("GroupHeaderTemplate")>] member inline this.GroupHeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupHeaderTemplate), (fun ctx x -> ctx.Element.GroupHeaderTemplate <- x), x)
    [<CustomOperation("GroupShortNameBinding")>] member inline this.GroupShortNameBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.BindingBase) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GroupShortNameBinding), (fun ctx x -> ctx.Element.GroupShortNameBinding <- x), x)
    [<CustomOperation("GroupShortNameBinding")>] member inline this.GroupShortNameBinding ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GroupShortNameBinding), (fun ctx x -> ctx.Element.GroupShortNameBinding <- x), x)
    [<CustomOperation("HasUnevenRows")>] member inline this.HasUnevenRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnevenRows), (fun ctx x -> ctx.Element.HasUnevenRows <- x), x)
    [<CustomOperation("HasUnevenRows")>] member inline this.HasUnevenRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnevenRows), (fun ctx x -> ctx.Element.HasUnevenRows <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("Header")>] member inline this.Header ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Header), (fun ctx x -> ctx.Element.Header <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("HeaderTemplate")>] member inline this.HeaderTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HeaderTemplate), (fun ctx x -> ctx.Element.HeaderTemplate <- x), x)
    [<CustomOperation("IsGroupingEnabled")>] member inline this.IsGroupingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroupingEnabled), (fun ctx x -> ctx.Element.IsGroupingEnabled <- x), x)
    [<CustomOperation("IsGroupingEnabled")>] member inline this.IsGroupingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsGroupingEnabled), (fun ctx x -> ctx.Element.IsGroupingEnabled <- x), x)
    [<CustomOperation("IsPullToRefreshEnabled")>] member inline this.IsPullToRefreshEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsPullToRefreshEnabled), (fun ctx x -> ctx.Element.IsPullToRefreshEnabled <- x), x)
    [<CustomOperation("IsPullToRefreshEnabled")>] member inline this.IsPullToRefreshEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsPullToRefreshEnabled), (fun ctx x -> ctx.Element.IsPullToRefreshEnabled <- x), x)
    [<CustomOperation("IsRefreshing")>] member inline this.IsRefreshing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsRefreshing), (fun ctx x -> ctx.Element.IsRefreshing <- x), x)
    [<CustomOperation("IsRefreshing")>] member inline this.IsRefreshing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsRefreshing), (fun ctx x -> ctx.Element.IsRefreshing <- x), x)
    [<CustomOperation("RefreshCommand")>] member inline this.RefreshCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshCommand), (fun ctx x -> ctx.Element.RefreshCommand <- x), x)
    [<CustomOperation("RefreshCommand")>] member inline this.RefreshCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshCommand), (fun ctx x -> ctx.Element.RefreshCommand <- x), x)
    [<CustomOperation("RowHeight")>] member inline this.RowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeight), (fun ctx x -> ctx.Element.RowHeight <- x), x)
    [<CustomOperation("RowHeight")>] member inline this.RowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeight), (fun ctx x -> ctx.Element.RowHeight <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectedItem")>] member inline this.SelectedItem ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectedItem), (fun ctx x -> ctx.Element.SelectedItem <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ListViewSelectionMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SelectionMode")>] member inline this.SelectionMode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SelectionMode), (fun ctx x -> ctx.Element.SelectionMode <- x), x)
    [<CustomOperation("SeparatorColor")>] member inline this.SeparatorColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorColor), (fun ctx x -> ctx.Element.SeparatorColor <- x), x)
    [<CustomOperation("SeparatorColor")>] member inline this.SeparatorColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorColor), (fun ctx x -> ctx.Element.SeparatorColor <- x), x)
    [<CustomOperation("RefreshControlColor")>] member inline this.RefreshControlColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshControlColor), (fun ctx x -> ctx.Element.RefreshControlColor <- x), x)
    [<CustomOperation("RefreshControlColor")>] member inline this.RefreshControlColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshControlColor), (fun ctx x -> ctx.Element.RefreshControlColor <- x), x)
    [<CustomOperation("SeparatorVisibility")>] member inline this.SeparatorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.SeparatorVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorVisibility), (fun ctx x -> ctx.Element.SeparatorVisibility <- x), x)
    [<CustomOperation("SeparatorVisibility")>] member inline this.SeparatorVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SeparatorVisibility), (fun ctx x -> ctx.Element.SeparatorVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("HorizontalScrollBarVisibility")>] member inline this.HorizontalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalScrollBarVisibility), (fun ctx x -> ctx.Element.HorizontalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ScrollBarVisibility) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("VerticalScrollBarVisibility")>] member inline this.VerticalScrollBarVisibility ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalScrollBarVisibility), (fun ctx x -> ctx.Element.VerticalScrollBarVisibility <- x), x)
    [<CustomOperation("RefreshAllowed")>] member inline this.RefreshAllowed ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshAllowed), (fun ctx x -> ctx.Element.RefreshAllowed <- x), x)
    [<CustomOperation("RefreshAllowed")>] member inline this.RefreshAllowed ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RefreshAllowed), (fun ctx x -> ctx.Element.RefreshAllowed <- x), x)
    [<CustomOperation("FooterElement")>] member inline this.FooterElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.FooterElement), x)
    [<CustomOperation("FooterElement'")>] member inline this.FooterElement' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.FooterElement), x)
    [<CustomOperation("HeaderElement")>] member inline this.HeaderElement ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.HeaderElement), x)
    [<CustomOperation("HeaderElement'")>] member inline this.HeaderElement' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.HeaderElement), x)

    [<CustomOperation("ItemAppearing")>] member inline this.ItemAppearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemAppearing), "ItemAppearing", fn)
    [<CustomOperation("ItemDisappearing")>] member inline this.ItemDisappearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemDisappearing), "ItemDisappearing", fn)
    [<CustomOperation("ItemSelected")>] member inline this.ItemSelected ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemSelected), "ItemSelected", fn)
    [<CustomOperation("ItemTapped")>] member inline this.ItemTapped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemTapped), "ItemTapped", fn)
    [<CustomOperation("Scrolled")>] member inline this.Scrolled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Scrolled), "Scrolled", fn)
    [<CustomOperation("Refreshing")>] member inline this.Refreshing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Refreshing), "Refreshing", fn)
    [<CustomOperation("ScrollToRequested")>] member inline this.ScrollToRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollToRequested), "ScrollToRequested", fn)
                

type OpenGLViewBuilder() =
    inherit ViewBuilder<Microsoft.Maui.Controls.OpenGLView>()

    [<CustomOperation("HasRenderLoop")>] member inline this.HasRenderLoop ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.OpenGLView>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasRenderLoop), (fun ctx x -> ctx.Element.HasRenderLoop <- x), x)
    [<CustomOperation("HasRenderLoop")>] member inline this.HasRenderLoop ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.OpenGLView>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasRenderLoop), (fun ctx x -> ctx.Element.HasRenderLoop <- x), x)
    [<CustomOperation("OnDisplay")>] member inline this.OnDisplay ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.OpenGLView>, fn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnDisplay), (fun ctx x -> ctx.Element.OnDisplay <- x), (System.Action<Microsoft.Maui.Graphics.Rect>fn))

    [<CustomOperation("DisplayRequested")>] member inline this.DisplayRequested ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.OpenGLView>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayRequested), "DisplayRequested", fn)
                

type TableViewBuilder<'Element when 'Element :> Microsoft.Maui.Controls.TableView>() =
    inherit ViewBuilder<'Element>()

    [<CustomOperation("HasUnevenRows")>] member inline this.HasUnevenRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnevenRows), (fun ctx x -> ctx.Element.HasUnevenRows <- x), x)
    [<CustomOperation("HasUnevenRows")>] member inline this.HasUnevenRows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HasUnevenRows), (fun ctx x -> ctx.Element.HasUnevenRows <- x), x)
    [<CustomOperation("Intent")>] member inline this.Intent ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.TableIntent) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Intent), (fun ctx x -> ctx.Element.Intent <- x), x)
    [<CustomOperation("Intent")>] member inline this.Intent ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Intent), (fun ctx x -> ctx.Element.Intent <- x), x)
    [<CustomOperation("Root")>] member inline this.Root ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.TableRoot) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Root), (fun ctx x -> ctx.Element.Root <- x), x)
    [<CustomOperation("Root")>] member inline this.Root ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Root), (fun ctx x -> ctx.Element.Root <- x), x)
    [<CustomOperation("RowHeight")>] member inline this.RowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeight), (fun ctx x -> ctx.Element.RowHeight <- x), x)
    [<CustomOperation("RowHeight")>] member inline this.RowHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.RowHeight), (fun ctx x -> ctx.Element.RowHeight <- x), x)
    [<CustomOperation("Model")>] member inline this.Model ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Internals.TableModel) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Model), (fun ctx x -> ctx.Element.Model <- x), x)
    [<CustomOperation("Model")>] member inline this.Model ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Model), (fun ctx x -> ctx.Element.Model <- x), x)

    [<CustomOperation("ModelChanged")>] member inline this.ModelChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModelChanged), "ModelChanged", fn)
                

type BaseShellItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.BaseShellItem>() =
    inherit NavigableElementBuilder<'Element>()


    [<CustomOperation("FlyoutIcon")>]
    member inline this.FlyoutIcon ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutIcon <- x), creator)

    [<CustomOperation("FlyoutIcon")>]
    member inline this.FlyoutIcon ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.FlyoutIcon <- x), creator)
                        

    [<CustomOperation("Icon")>]
    member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Icon <- x), creator)

    [<CustomOperation("Icon")>]
    member inline this.Icon ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Icon <- x), creator)
                        
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("Route")>] member inline this.Route ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Route), (fun ctx x -> ctx.Element.Route <- x), x)
    [<CustomOperation("Route")>] member inline this.Route ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Route), (fun ctx x -> ctx.Element.Route <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("FlyoutItemIsVisible")>] member inline this.FlyoutItemIsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutItemIsVisible), (fun ctx x -> ctx.Element.FlyoutItemIsVisible <- x), x)
    [<CustomOperation("FlyoutItemIsVisible")>] member inline this.FlyoutItemIsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutItemIsVisible), (fun ctx x -> ctx.Element.FlyoutItemIsVisible <- x), x)
    [<CustomOperation("Window")>] member inline this.Window ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Window), x)
    [<CustomOperation("Window'")>] member inline this.Window' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Window), x)

    [<CustomOperation("Appearing")>] member inline this.Appearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Appearing), "Appearing", fn)
    [<CustomOperation("Disappearing")>] member inline this.Disappearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Disappearing), "Disappearing", fn)
                

type ShellGroupItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ShellGroupItem>() =
    inherit BaseShellItemBuilder<'Element>()

    [<CustomOperation("FlyoutDisplayOptions")>] member inline this.FlyoutDisplayOptions ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FlyoutDisplayOptions) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutDisplayOptions), (fun ctx x -> ctx.Element.FlyoutDisplayOptions <- x), x)
    [<CustomOperation("FlyoutDisplayOptions")>] member inline this.FlyoutDisplayOptions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlyoutDisplayOptions), (fun ctx x -> ctx.Element.FlyoutDisplayOptions <- x), x)

                

type ShellItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ShellItem>() =
    inherit ShellGroupItemBuilder<'Element>()


    [<CustomOperation("CurrentItem")>]
    member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentItem <- x), creator)

    [<CustomOperation("CurrentItem")>]
    member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentItem <- x), creator)
                        

    [<CustomOperation("Items")>]
    member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellSection>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellSection[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Items")>]
    member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellSection>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellSection[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticItems")>]
    member inline this.StaticItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellSection>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellSection[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )
                        

                

type FlyoutItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.FlyoutItem>() =
    inherit ShellItemBuilder<'Element>()


                

type TabBarBuilder<'Element when 'Element :> Microsoft.Maui.Controls.TabBar>() =
    inherit ShellItemBuilder<'Element>()


                

type ShellSectionBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ShellSection>() =
    inherit ShellGroupItemBuilder<'Element>()


    [<CustomOperation("CurrentItem")>]
    member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentItem <- x), creator)

    [<CustomOperation("CurrentItem")>]
    member inline this.CurrentItem ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.CurrentItem <- x), creator)
                        

    [<CustomOperation("Items")>]
    member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellContent>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellContent[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Items")>]
    member inline this.Items ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellContent>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellContent[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticItems")>]
    member inline this.StaticItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.ShellContent>(
            builder,
            (fun x -> x.Element.Items.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.ShellContent[]) -> for i in ls do x.Element.Items.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("Stack")>] member inline this.Stack ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Stack), x)
    [<CustomOperation("Stack'")>] member inline this.Stack' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Stack), x)

                

type TabBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Tab>() =
    inherit ShellSectionBuilder<'Element>()


                

type ShellContentBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ShellContent>() =
    inherit BaseShellItemBuilder<'Element>()


    [<CustomOperation("MenuItems")>]
    member inline this.MenuItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuItem>(
            builder,
            (fun x -> x.Element.MenuItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuItem[]) -> for i in ls do x.Element.MenuItems.Add(i) |> ignore),
            items
        )

    [<CustomOperation("MenuItems")>]
    member inline this.MenuItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuItem>(
            builder,
            (fun x -> x.Element.MenuItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuItem[]) -> for i in ls do x.Element.MenuItems.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticMenuItems")>]
    member inline this.StaticMenuItems ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuItem>(
            builder,
            (fun x -> x.Element.MenuItems.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuItem[]) -> for i in ls do x.Element.MenuItems.Add(i) |> ignore),
            items
        )
                        

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)

    [<CustomOperation("Content")>]
    member inline this.Content ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Content <- x), creator)
                        
    [<CustomOperation("Content'")>] member inline this.Content' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("Content'")>] member inline this.Content' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Content), (fun ctx x -> ctx.Element.Content <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.DataTemplate) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)
    [<CustomOperation("ContentTemplate")>] member inline this.ContentTemplate ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ContentTemplate), (fun ctx x -> ctx.Element.ContentTemplate <- x), x)

                

type WindowBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Window>() =
    inherit NavigableElementBuilder<'Element>()

    [<CustomOperation("Overlays")>] member inline this.Overlays ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Overlays), x)
    [<CustomOperation("Overlays'")>] member inline this.Overlays' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Overlays), x)
    [<CustomOperation("VisualDiagnosticsOverlay")>] member inline this.VisualDiagnosticsOverlay ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.VisualDiagnosticsOverlay), x)
    [<CustomOperation("VisualDiagnosticsOverlay'")>] member inline this.VisualDiagnosticsOverlay' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.VisualDiagnosticsOverlay), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

    [<CustomOperation("Page")>]
    member inline this.Page ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Page <- x), creator)

    [<CustomOperation("Page")>]
    member inline this.Page ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Page <- x), creator)
                        
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.FlowDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)
    [<CustomOperation("FlowDirection")>] member inline this.FlowDirection ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FlowDirection), (fun ctx x -> ctx.Element.FlowDirection <- x), x)

    [<CustomOperation("ModalPopped")>] member inline this.ModalPopped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPopped), "ModalPopped", fn)
    [<CustomOperation("ModalPopping")>] member inline this.ModalPopping ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPopping), "ModalPopping", fn)
    [<CustomOperation("ModalPushed")>] member inline this.ModalPushed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPushed), "ModalPushed", fn)
    [<CustomOperation("ModalPushing")>] member inline this.ModalPushing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPushing), "ModalPushing", fn)
    [<CustomOperation("PopCanceled")>] member inline this.PopCanceled ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PopCanceled), "PopCanceled", fn)
    [<CustomOperation("Created")>] member inline this.Created ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Created), "Created", fn)
    [<CustomOperation("Resumed")>] member inline this.Resumed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Resumed), "Resumed", fn)
    [<CustomOperation("Activated")>] member inline this.Activated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Activated), "Activated", fn)
    [<CustomOperation("Deactivated")>] member inline this.Deactivated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Deactivated), "Deactivated", fn)
    [<CustomOperation("Stopped")>] member inline this.Stopped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Stopped), "Stopped", fn)
    [<CustomOperation("Destroying")>] member inline this.Destroying ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Destroying), "Destroying", fn)
    [<CustomOperation("Backgrounding")>] member inline this.Backgrounding ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Backgrounding), "Backgrounding", fn)
    [<CustomOperation("DisplayDensityChanged")>] member inline this.DisplayDensityChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DisplayDensityChanged), "DisplayDensityChanged", fn)
                

type CellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Cell>() =
    inherit ElementBuilder<'Element>()


    [<CustomOperation("ContextActions")>]
    member inline this.ContextActions ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuItem>(
            builder,
            (fun x -> x.Element.ContextActions.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuItem[]) -> for i in ls do x.Element.ContextActions.Add(i) |> ignore),
            items
        )

    [<CustomOperation("ContextActions")>]
    member inline this.ContextActions ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuItem>(
            builder,
            (fun x -> x.Element.ContextActions.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuItem[]) -> for i in ls do x.Element.ContextActions.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticContextActions")>]
    member inline this.StaticContextActions ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.MenuItem>(
            builder,
            (fun x -> x.Element.ContextActions.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.MenuItem[]) -> for i in ls do x.Element.ContextActions.Add(i) |> ignore),
            items
        )
                        
    [<CustomOperation("IsContextActionsLegacyModeEnabled")>] member inline this.IsContextActionsLegacyModeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsContextActionsLegacyModeEnabled), (fun ctx x -> ctx.Element.IsContextActionsLegacyModeEnabled <- x), x)
    [<CustomOperation("IsContextActionsLegacyModeEnabled")>] member inline this.IsContextActionsLegacyModeEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsContextActionsLegacyModeEnabled), (fun ctx x -> ctx.Element.IsContextActionsLegacyModeEnabled <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("Height")>] member inline this.Height ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Height), (fun ctx x -> ctx.Element.Height <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)

    [<CustomOperation("Appearing")>] member inline this.Appearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Appearing), "Appearing", fn)
    [<CustomOperation("Disappearing")>] member inline this.Disappearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Disappearing), "Disappearing", fn)
    [<CustomOperation("ForceUpdateSizeRequested")>] member inline this.ForceUpdateSizeRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ForceUpdateSizeRequested), "ForceUpdateSizeRequested", fn)
    [<CustomOperation("Tapped")>] member inline this.Tapped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Tapped), "Tapped", fn)
                

type TextCellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.TextCell>() =
    inherit CellBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("Detail")>] member inline this.Detail ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Detail), (fun ctx x -> ctx.Element.Detail <- x), x)
    [<CustomOperation("Detail")>] member inline this.Detail ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Detail), (fun ctx x -> ctx.Element.Detail <- x), x)
    [<CustomOperation("DetailColor")>] member inline this.DetailColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DetailColor), (fun ctx x -> ctx.Element.DetailColor <- x), x)
    [<CustomOperation("DetailColor")>] member inline this.DetailColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DetailColor), (fun ctx x -> ctx.Element.DetailColor <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)

                

type ImageCellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ImageCell>() =
    inherit TextCellBuilder<'Element>()


    [<CustomOperation("ImageSource")>]
    member inline this.ImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ImageSource <- x), creator)

    [<CustomOperation("ImageSource")>]
    member inline this.ImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.ImageSource <- x), creator)
                        

                

type EntryCellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.EntryCell>() =
    inherit CellBuilder<'Element>()

    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("HorizontalTextAlignment")>] member inline this.HorizontalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.HorizontalTextAlignment), (fun ctx x -> ctx.Element.HorizontalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextAlignment) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("VerticalTextAlignment")>] member inline this.VerticalTextAlignment ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.VerticalTextAlignment), (fun ctx x -> ctx.Element.VerticalTextAlignment <- x), x)
    [<CustomOperation("Keyboard")>] member inline this.Keyboard ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Keyboard) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Keyboard), (fun ctx x -> ctx.Element.Keyboard <- x), x)
    [<CustomOperation("Keyboard")>] member inline this.Keyboard ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Keyboard), (fun ctx x -> ctx.Element.Keyboard <- x), x)
    [<CustomOperation("Label")>] member inline this.Label ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Label), (fun ctx x -> ctx.Element.Label <- x), x)
    [<CustomOperation("Label")>] member inline this.Label ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Label), (fun ctx x -> ctx.Element.Label <- x), x)
    [<CustomOperation("LabelColor")>] member inline this.LabelColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LabelColor), (fun ctx x -> ctx.Element.LabelColor <- x), x)
    [<CustomOperation("LabelColor")>] member inline this.LabelColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LabelColor), (fun ctx x -> ctx.Element.LabelColor <- x), x)
    [<CustomOperation("Placeholder")>] member inline this.Placeholder ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Placeholder), (fun ctx x -> ctx.Element.Placeholder <- x), x)
    [<CustomOperation("Placeholder")>] member inline this.Placeholder ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Placeholder), (fun ctx x -> ctx.Element.Placeholder <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

    [<CustomOperation("Completed")>] member inline this.Completed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Completed), "Completed", fn)
                

type SwitchCellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SwitchCell>() =
    inherit CellBuilder<'Element>()

    [<CustomOperation("OnColor")>] member inline this.OnColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.OnColor), (fun ctx x -> ctx.Element.OnColor <- x), x)
    [<CustomOperation("OnColor")>] member inline this.OnColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.OnColor), (fun ctx x -> ctx.Element.OnColor <- x), x)
    [<CustomOperation("On")>] member inline this.On ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.On), (fun ctx x -> ctx.Element.On <- x), x)
    [<CustomOperation("On")>] member inline this.On ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.On), (fun ctx x -> ctx.Element.On <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

    [<CustomOperation("OnChanged")>] member inline this.OnChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.OnChanged), "OnChanged", fn)
                

type ViewCellBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ViewCell>() =
    inherit CellBuilder<'Element>()


    [<CustomOperation("View")>]
    member inline this.View ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.View <- x), creator)

    [<CustomOperation("View")>]
    member inline this.View ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.View <- x), creator)
                        

                

type BaseMenuItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.BaseMenuItem>() =
    inherit ElementBuilder<'Element>()


                

type MenuItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.MenuItem>() =
    inherit BaseMenuItemBuilder<'Element>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)

    [<CustomOperation("IconImageSource")>]
    member inline this.IconImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IconImageSource <- x), creator)

    [<CustomOperation("IconImageSource")>]
    member inline this.IconImageSource ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.IconImageSource <- x), creator)
                        
    [<CustomOperation("IsDestructive")>] member inline this.IsDestructive ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsDestructive), (fun ctx x -> ctx.Element.IsDestructive <- x), x)
    [<CustomOperation("IsDestructive")>] member inline this.IsDestructive ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsDestructive), (fun ctx x -> ctx.Element.IsDestructive <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("StyleClass")>] member inline this.StyleClass ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<System.String>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StyleClass), (fun ctx x -> ctx.Element.StyleClass <- x), x)
    [<CustomOperation("StyleClass")>] member inline this.StyleClass ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StyleClass), (fun ctx x -> ctx.Element.StyleClass <- x), x)
    [<CustomOperation("class'")>] member inline this.class' ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Collections.Generic.IList<System.String>) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.``class``), (fun ctx x -> ctx.Element.``class`` <- x), x)
    [<CustomOperation("class'")>] member inline this.class' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.``class``), (fun ctx x -> ctx.Element.``class`` <- x), x)

    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Clicked), "Clicked", fn)
                

type MenuFlyoutItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.MenuFlyoutItem>() =
    inherit MenuItemBuilder<'Element>()


                

type MenuFlyoutSubItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.MenuFlyoutSubItem>() =
    inherit MenuFlyoutItemBuilder<'Element>()


                

type SwipeItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SwipeItem>() =
    inherit MenuItemBuilder<'Element>()

    [<CustomOperation("BackgroundColor")>] member inline this.BackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundColor), (fun ctx x -> ctx.Element.BackgroundColor <- x), x)
    [<CustomOperation("BackgroundColor")>] member inline this.BackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundColor), (fun ctx x -> ctx.Element.BackgroundColor <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)
    [<CustomOperation("IsVisible")>] member inline this.IsVisible ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsVisible), (fun ctx x -> ctx.Element.IsVisible <- x), x)

    [<CustomOperation("Invoked")>] member inline this.Invoked ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Invoked), "Invoked", fn)
                

type ToolbarItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ToolbarItem>() =
    inherit MenuItemBuilder<'Element>()

    [<CustomOperation("Order")>] member inline this.Order ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ToolbarItemOrder) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Order), (fun ctx x -> ctx.Element.Order <- x), x)
    [<CustomOperation("Order")>] member inline this.Order ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Order), (fun ctx x -> ctx.Element.Order <- x), x)
    [<CustomOperation("Priority")>] member inline this.Priority ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Priority), (fun ctx x -> ctx.Element.Priority <- x), x)
    [<CustomOperation("Priority")>] member inline this.Priority ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Priority), (fun ctx x -> ctx.Element.Priority <- x), x)

                

type MenuBarItemBuilder<'Element when 'Element :> Microsoft.Maui.Controls.MenuBarItem>() =
    inherit BaseMenuItemBuilder<'Element>()

    [<CustomOperation("Priority")>] member inline this.Priority ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Priority), (fun ctx x -> ctx.Element.Priority <- x), x)
    [<CustomOperation("Priority")>] member inline this.Priority ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Priority), (fun ctx x -> ctx.Element.Priority <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)

                

type BrushBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Brush>() =
    inherit ElementBuilder<'Element>()


                

type GradientBrushBuilder<'Element when 'Element :> Microsoft.Maui.Controls.GradientBrush>() =
    inherit BrushBuilder<'Element>()

    [<CustomOperation("GradientStops")>] member inline this.GradientStops ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.GradientStopCollection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.GradientStops), (fun ctx x -> ctx.Element.GradientStops <- x), x)
    [<CustomOperation("GradientStops")>] member inline this.GradientStops ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.GradientStops), (fun ctx x -> ctx.Element.GradientStops <- x), x)

    [<CustomOperation("InvalidateGradientBrushRequested")>] member inline this.InvalidateGradientBrushRequested ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.InvalidateGradientBrushRequested), "InvalidateGradientBrushRequested", fn)
                

type LinearGradientBrushBuilder<'Element when 'Element :> Microsoft.Maui.Controls.LinearGradientBrush>() =
    inherit GradientBrushBuilder<'Element>()

    [<CustomOperation("StartPoint")>] member inline this.StartPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StartPoint), (fun ctx x -> ctx.Element.StartPoint <- x), x)
    [<CustomOperation("StartPoint")>] member inline this.StartPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StartPoint), (fun ctx x -> ctx.Element.StartPoint <- x), x)
    [<CustomOperation("EndPoint")>] member inline this.EndPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.EndPoint), (fun ctx x -> ctx.Element.EndPoint <- x), x)
    [<CustomOperation("EndPoint")>] member inline this.EndPoint ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.EndPoint), (fun ctx x -> ctx.Element.EndPoint <- x), x)

                

type RadialGradientBrushBuilder<'Element when 'Element :> Microsoft.Maui.Controls.RadialGradientBrush>() =
    inherit GradientBrushBuilder<'Element>()

    [<CustomOperation("Center")>] member inline this.Center ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Center), (fun ctx x -> ctx.Element.Center <- x), x)
    [<CustomOperation("Center")>] member inline this.Center ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Center), (fun ctx x -> ctx.Element.Center <- x), x)
    [<CustomOperation("Radius")>] member inline this.Radius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Radius), (fun ctx x -> ctx.Element.Radius <- x), x)
    [<CustomOperation("Radius")>] member inline this.Radius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Radius), (fun ctx x -> ctx.Element.Radius <- x), x)

                

type SolidColorBrushBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SolidColorBrush>() =
    inherit BrushBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)

                

type GestureRecognizerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.GestureRecognizer>() =
    inherit ElementBuilder<'Element>()


                

type ClickGestureRecognizerBuilder() =
    inherit GestureRecognizerBuilder<Microsoft.Maui.Controls.ClickGestureRecognizer>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("NumberOfClicksRequired")>] member inline this.NumberOfClicksRequired ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfClicksRequired), (fun ctx x -> ctx.Element.NumberOfClicksRequired <- x), x)
    [<CustomOperation("NumberOfClicksRequired")>] member inline this.NumberOfClicksRequired ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfClicksRequired), (fun ctx x -> ctx.Element.NumberOfClicksRequired <- x), x)
    [<CustomOperation("Buttons")>] member inline this.Buttons ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x: Microsoft.Maui.Controls.ButtonsMask) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Buttons), (fun ctx x -> ctx.Element.Buttons <- x), x)
    [<CustomOperation("Buttons")>] member inline this.Buttons ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Buttons), (fun ctx x -> ctx.Element.Buttons <- x), x)

    [<CustomOperation("Clicked")>] member inline this.Clicked ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Clicked), "Clicked", fn)
                

type DragGestureRecognizerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.DragGestureRecognizer>() =
    inherit GestureRecognizerBuilder<'Element>()

    [<CustomOperation("CanDrag")>] member inline this.CanDrag ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanDrag), (fun ctx x -> ctx.Element.CanDrag <- x), x)
    [<CustomOperation("CanDrag")>] member inline this.CanDrag ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanDrag), (fun ctx x -> ctx.Element.CanDrag <- x), x)
    [<CustomOperation("DropCompletedCommand")>] member inline this.DropCompletedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DropCompletedCommand), (fun ctx x -> ctx.Element.DropCompletedCommand <- x), x)
    [<CustomOperation("DropCompletedCommand")>] member inline this.DropCompletedCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DropCompletedCommand), (fun ctx x -> ctx.Element.DropCompletedCommand <- x), x)
    [<CustomOperation("DropCompletedCommandParameter")>] member inline this.DropCompletedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DropCompletedCommandParameter), (fun ctx x -> ctx.Element.DropCompletedCommandParameter <- x), x)
    [<CustomOperation("DropCompletedCommandParameter")>] member inline this.DropCompletedCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DropCompletedCommandParameter), (fun ctx x -> ctx.Element.DropCompletedCommandParameter <- x), x)
    [<CustomOperation("DragStartingCommand")>] member inline this.DragStartingCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStartingCommand), (fun ctx x -> ctx.Element.DragStartingCommand <- x), x)
    [<CustomOperation("DragStartingCommand")>] member inline this.DragStartingCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragStartingCommand), (fun ctx x -> ctx.Element.DragStartingCommand <- x), x)
    [<CustomOperation("DragStartingCommandParameter")>] member inline this.DragStartingCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStartingCommandParameter), (fun ctx x -> ctx.Element.DragStartingCommandParameter <- x), x)
    [<CustomOperation("DragStartingCommandParameter")>] member inline this.DragStartingCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragStartingCommandParameter), (fun ctx x -> ctx.Element.DragStartingCommandParameter <- x), x)

    [<CustomOperation("DropCompleted")>] member inline this.DropCompleted ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DropCompleted), "DropCompleted", fn)
    [<CustomOperation("DragStarting")>] member inline this.DragStarting ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragStarting), "DragStarting", fn)
                

type DropGestureRecognizerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.DropGestureRecognizer>() =
    inherit GestureRecognizerBuilder<'Element>()

    [<CustomOperation("AllowDrop")>] member inline this.AllowDrop ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowDrop), (fun ctx x -> ctx.Element.AllowDrop <- x), x)
    [<CustomOperation("AllowDrop")>] member inline this.AllowDrop ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowDrop), (fun ctx x -> ctx.Element.AllowDrop <- x), x)
    [<CustomOperation("DragOverCommand")>] member inline this.DragOverCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragOverCommand), (fun ctx x -> ctx.Element.DragOverCommand <- x), x)
    [<CustomOperation("DragOverCommand")>] member inline this.DragOverCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragOverCommand), (fun ctx x -> ctx.Element.DragOverCommand <- x), x)
    [<CustomOperation("DragOverCommandParameter")>] member inline this.DragOverCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragOverCommandParameter), (fun ctx x -> ctx.Element.DragOverCommandParameter <- x), x)
    [<CustomOperation("DragOverCommandParameter")>] member inline this.DragOverCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragOverCommandParameter), (fun ctx x -> ctx.Element.DragOverCommandParameter <- x), x)
    [<CustomOperation("DragLeaveCommand")>] member inline this.DragLeaveCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragLeaveCommand), (fun ctx x -> ctx.Element.DragLeaveCommand <- x), x)
    [<CustomOperation("DragLeaveCommand")>] member inline this.DragLeaveCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragLeaveCommand), (fun ctx x -> ctx.Element.DragLeaveCommand <- x), x)
    [<CustomOperation("DragLeaveCommandParameter")>] member inline this.DragLeaveCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DragLeaveCommandParameter), (fun ctx x -> ctx.Element.DragLeaveCommandParameter <- x), x)
    [<CustomOperation("DragLeaveCommandParameter")>] member inline this.DragLeaveCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DragLeaveCommandParameter), (fun ctx x -> ctx.Element.DragLeaveCommandParameter <- x), x)
    [<CustomOperation("DropCommand")>] member inline this.DropCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DropCommand), (fun ctx x -> ctx.Element.DropCommand <- x), x)
    [<CustomOperation("DropCommand")>] member inline this.DropCommand ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DropCommand), (fun ctx x -> ctx.Element.DropCommand <- x), x)
    [<CustomOperation("DropCommandParameter")>] member inline this.DropCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DropCommandParameter), (fun ctx x -> ctx.Element.DropCommandParameter <- x), x)
    [<CustomOperation("DropCommandParameter")>] member inline this.DropCommandParameter ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DropCommandParameter), (fun ctx x -> ctx.Element.DropCommandParameter <- x), x)

    [<CustomOperation("DragLeave")>] member inline this.DragLeave ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragLeave), "DragLeave", fn)
    [<CustomOperation("DragOver")>] member inline this.DragOver ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.DragOver), "DragOver", fn)
    [<CustomOperation("Drop")>] member inline this.Drop ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Drop), "Drop", fn)
                

type PanGestureRecognizerBuilder<'Element when 'Element :> Microsoft.Maui.Controls.PanGestureRecognizer>() =
    inherit GestureRecognizerBuilder<'Element>()

    [<CustomOperation("TouchPoints")>] member inline this.TouchPoints ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TouchPoints), (fun ctx x -> ctx.Element.TouchPoints <- x), x)
    [<CustomOperation("TouchPoints")>] member inline this.TouchPoints ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TouchPoints), (fun ctx x -> ctx.Element.TouchPoints <- x), x)

    [<CustomOperation("PanUpdated")>] member inline this.PanUpdated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PanUpdated), "PanUpdated", fn)
                

type PinchGestureRecognizerBuilder() =
    inherit GestureRecognizerBuilder<Microsoft.Maui.Controls.PinchGestureRecognizer>()


    [<CustomOperation("PinchUpdated")>] member inline this.PinchUpdated ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.PinchGestureRecognizer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PinchUpdated), "PinchUpdated", fn)
                

type SwipeGestureRecognizerBuilder() =
    inherit GestureRecognizerBuilder<Microsoft.Maui.Controls.SwipeGestureRecognizer>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("Direction")>] member inline this.Direction ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x: Microsoft.Maui.SwipeDirection) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Direction), (fun ctx x -> ctx.Element.Direction <- x), x)
    [<CustomOperation("Direction")>] member inline this.Direction ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Direction), (fun ctx x -> ctx.Element.Direction <- x), x)
    [<CustomOperation("Threshold")>] member inline this.Threshold ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x: System.UInt32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Threshold), (fun ctx x -> ctx.Element.Threshold <- x), x)
    [<CustomOperation("Threshold")>] member inline this.Threshold ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Threshold), (fun ctx x -> ctx.Element.Threshold <- x), x)

    [<CustomOperation("Swiped")>] member inline this.Swiped ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Swiped), "Swiped", fn)
                

type TapGestureRecognizerBuilder() =
    inherit GestureRecognizerBuilder<Microsoft.Maui.Controls.TapGestureRecognizer>()

    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, x: System.Windows.Input.ICommand) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("Command")>] member inline this.Command ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Command), (fun ctx x -> ctx.Element.Command <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, x: System.Object) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("CommandParameter")>] member inline this.CommandParameter ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CommandParameter), (fun ctx x -> ctx.Element.CommandParameter <- x), x)
    [<CustomOperation("NumberOfTapsRequired")>] member inline this.NumberOfTapsRequired ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfTapsRequired), (fun ctx x -> ctx.Element.NumberOfTapsRequired <- x), x)
    [<CustomOperation("NumberOfTapsRequired")>] member inline this.NumberOfTapsRequired ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.NumberOfTapsRequired), (fun ctx x -> ctx.Element.NumberOfTapsRequired <- x), x)

    [<CustomOperation("Tapped")>] member inline this.Tapped ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Tapped), "Tapped", fn)
                

type ImageSourceBuilder<'Element when 'Element :> Microsoft.Maui.Controls.ImageSource>() =
    inherit ElementBuilder<'Element>()


                

type FileImageSourceBuilder() =
    inherit ImageSourceBuilder<Microsoft.Maui.Controls.FileImageSource>()

    [<CustomOperation("File")>] member inline this.File ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FileImageSource>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.File), (fun ctx x -> ctx.Element.File <- x), x)
    [<CustomOperation("File")>] member inline this.File ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FileImageSource>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.File), (fun ctx x -> ctx.Element.File <- x), x)

                

type FontImageSourceBuilder<'Element when 'Element :> Microsoft.Maui.Controls.FontImageSource>() =
    inherit ImageSourceBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("Glyph")>] member inline this.Glyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Glyph), (fun ctx x -> ctx.Element.Glyph <- x), x)
    [<CustomOperation("Glyph")>] member inline this.Glyph ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Glyph), (fun ctx x -> ctx.Element.Glyph <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)

                

type StreamImageSourceBuilder<'Element when 'Element :> Microsoft.Maui.Controls.StreamImageSource>() =
    inherit ImageSourceBuilder<'Element>()

    [<CustomOperation("Stream")>] member inline this.Stream ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Stream), (fun ctx x -> ctx.Element.Stream <- x), (System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IO.Stream>>fn))

                

type UriImageSourceBuilder() =
    inherit ImageSourceBuilder<Microsoft.Maui.Controls.UriImageSource>()

    [<CustomOperation("CacheValidity")>] member inline this.CacheValidity ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>, x: System.TimeSpan) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CacheValidity), (fun ctx x -> ctx.Element.CacheValidity <- x), x)
    [<CustomOperation("CacheValidity")>] member inline this.CacheValidity ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CacheValidity), (fun ctx x -> ctx.Element.CacheValidity <- x), x)
    [<CustomOperation("CachingEnabled")>] member inline this.CachingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CachingEnabled), (fun ctx x -> ctx.Element.CachingEnabled <- x), x)
    [<CustomOperation("CachingEnabled")>] member inline this.CachingEnabled ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CachingEnabled), (fun ctx x -> ctx.Element.CachingEnabled <- x), x)
    [<CustomOperation("Uri")>] member inline this.Uri ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Uri), (fun ctx x -> ctx.Element.Uri <- x), x)
    [<CustomOperation("Uri")>] member inline this.Uri ([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Uri), (fun ctx x -> ctx.Element.Uri <- x), x)

                

type GestureElementBuilder<'Element when 'Element :> Microsoft.Maui.Controls.GestureElement>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("GestureRecognizers")>] member inline this.GestureRecognizers ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.GestureRecognizers), x)
    [<CustomOperation("GestureRecognizers'")>] member inline this.GestureRecognizers' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.GestureRecognizers), x)

                

type SpanBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Span>() =
    inherit GestureElementBuilder<'Element>()

    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.Style) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Style), (fun ctx x -> ctx.Element.Style <- x), x)
    [<CustomOperation("BackgroundColor")>] member inline this.BackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundColor), (fun ctx x -> ctx.Element.BackgroundColor <- x), x)
    [<CustomOperation("BackgroundColor")>] member inline this.BackgroundColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.BackgroundColor), (fun ctx x -> ctx.Element.BackgroundColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("TextColor")>] member inline this.TextColor ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextColor), (fun ctx x -> ctx.Element.TextColor <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("CharacterSpacing")>] member inline this.CharacterSpacing ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CharacterSpacing), (fun ctx x -> ctx.Element.CharacterSpacing <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextTransform) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("TextTransform")>] member inline this.TextTransform ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextTransform), (fun ctx x -> ctx.Element.TextTransform <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.FontAttributes) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontAttributes")>] member inline this.FontAttributes ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAttributes), (fun ctx x -> ctx.Element.FontAttributes <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontFamily")>] member inline this.FontFamily ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontFamily), (fun ctx x -> ctx.Element.FontFamily <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontSize")>] member inline this.FontSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontSize), (fun ctx x -> ctx.Element.FontSize <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("FontAutoScalingEnabled")>] member inline this.FontAutoScalingEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FontAutoScalingEnabled), (fun ctx x -> ctx.Element.FontAutoScalingEnabled <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.TextDecorations) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("TextDecorations")>] member inline this.TextDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.TextDecorations), (fun ctx x -> ctx.Element.TextDecorations <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)
    [<CustomOperation("LineHeight")>] member inline this.LineHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LineHeight), (fun ctx x -> ctx.Element.LineHeight <- x), x)

                

type ApplicationBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Application>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("AppLinks")>] member inline this.AppLinks ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.AppLinks), x)
    [<CustomOperation("AppLinks'")>] member inline this.AppLinks' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.AppLinks), x)

    [<CustomOperation("MainPage")>]
    member inline this.MainPage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.MainPage <- x), creator)

    [<CustomOperation("MainPage")>]
    member inline this.MainPage ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.MainPage <- x), creator)
                        
    [<CustomOperation("NavigationProxy")>] member inline this.NavigationProxy ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.NavigationProxy), x)
    [<CustomOperation("NavigationProxy'")>] member inline this.NavigationProxy' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.NavigationProxy), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Controls.ResourceDictionary) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("Resources")>] member inline this.Resources ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Resources), (fun ctx x -> ctx.Element.Resources <- x), x)
    [<CustomOperation("UserAppTheme")>] member inline this.UserAppTheme ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.ApplicationModel.AppTheme) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UserAppTheme), (fun ctx x -> ctx.Element.UserAppTheme <- x), x)
    [<CustomOperation("UserAppTheme")>] member inline this.UserAppTheme ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UserAppTheme), (fun ctx x -> ctx.Element.UserAppTheme <- x), x)
    [<CustomOperation("Windows")>] member inline this.Windows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Windows), x)
    [<CustomOperation("Windows'")>] member inline this.Windows' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Windows), x)

    [<CustomOperation("RequestedThemeChanged")>] member inline this.RequestedThemeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.RequestedThemeChanged), "RequestedThemeChanged", fn)
    [<CustomOperation("ModalPopped")>] member inline this.ModalPopped ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPopped), "ModalPopped", fn)
    [<CustomOperation("ModalPopping")>] member inline this.ModalPopping ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPopping), "ModalPopping", fn)
    [<CustomOperation("ModalPushed")>] member inline this.ModalPushed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPushed), "ModalPushed", fn)
    [<CustomOperation("ModalPushing")>] member inline this.ModalPushing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.ModalPushing), "ModalPushing", fn)
    [<CustomOperation("PageAppearing")>] member inline this.PageAppearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PageAppearing), "PageAppearing", fn)
    [<CustomOperation("PageDisappearing")>] member inline this.PageDisappearing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.PageDisappearing), "PageDisappearing", fn)
                

type AppLinkEntryBuilder<'Element when 'Element :> Microsoft.Maui.Controls.AppLinkEntry>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("AppLinkUri")>] member inline this.AppLinkUri ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Uri) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AppLinkUri), (fun ctx x -> ctx.Element.AppLinkUri <- x), x)
    [<CustomOperation("AppLinkUri")>] member inline this.AppLinkUri ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AppLinkUri), (fun ctx x -> ctx.Element.AppLinkUri <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("Description")>] member inline this.Description ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Description), (fun ctx x -> ctx.Element.Description <- x), x)
    [<CustomOperation("IsLinkActive")>] member inline this.IsLinkActive ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsLinkActive), (fun ctx x -> ctx.Element.IsLinkActive <- x), x)
    [<CustomOperation("IsLinkActive")>] member inline this.IsLinkActive ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsLinkActive), (fun ctx x -> ctx.Element.IsLinkActive <- x), x)
    [<CustomOperation("KeyValues")>] member inline this.KeyValues ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.KeyValues), x)
    [<CustomOperation("KeyValues'")>] member inline this.KeyValues' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.KeyValues), x)

    [<CustomOperation("Thumbnail")>]
    member inline this.Thumbnail ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Thumbnail <- x), creator)

    [<CustomOperation("Thumbnail")>]
    member inline this.Thumbnail ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Thumbnail <- x), creator)
                        
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)
    [<CustomOperation("Title")>] member inline this.Title ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Title), (fun ctx x -> ctx.Element.Title <- x), x)

                

type FormattedStringBuilder<'Element when 'Element :> Microsoft.Maui.Controls.FormattedString>() =
    inherit ElementBuilder<'Element>()


    [<CustomOperation("Spans")>]
    member inline this.Spans ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.Span>(
            builder,
            (fun x -> x.Element.Spans.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.Span[]) -> for i in ls do x.Element.Spans.Add(i) |> ignore),
            items
        )

    [<CustomOperation("Spans")>]
    member inline this.Spans ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> alist) =
        this.MakeChildrenBuilder<'Element, Microsoft.Maui.Controls.Span>(
            builder,
            (fun x -> x.Element.Spans.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.Span[]) -> for i in ls do x.Element.Spans.Add(i) |> ignore),
            items
        )

    [<CustomOperation("StaticSpans")>]
    member inline this.StaticSpans ([<InlineIfLambda>] builder: BuildElement<'Element>, items: ElementCreator<MAUI> seq) =
        this.MakeStaticChildrenBuilder<'Element, Microsoft.Maui.Controls.Span>(
            builder,
            (fun x -> x.Element.Spans.Clear()),
            (fun x (ls: Microsoft.Maui.Controls.Span[]) -> for i in ls do x.Element.Spans.Add(i) |> ignore),
            items
        )
                        

                

type GradientStopBuilder<'Element when 'Element :> Microsoft.Maui.Controls.GradientStop>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Color) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Color")>] member inline this.Color ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Color), (fun ctx x -> ctx.Element.Color <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)

                

type MenuBarBuilder<'Element when 'Element :> Microsoft.Maui.Controls.MenuBar>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)
    [<CustomOperation("IsEnabled")>] member inline this.IsEnabled ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsEnabled), (fun ctx x -> ctx.Element.IsEnabled <- x), x)

                

type ShadowBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Shadow>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("Radius")>] member inline this.Radius ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Radius), (fun ctx x -> ctx.Element.Radius <- x), x)
    [<CustomOperation("Radius")>] member inline this.Radius ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Radius), (fun ctx x -> ctx.Element.Radius <- x), x)
    [<CustomOperation("Opacity")>] member inline this.Opacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Single) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Opacity), (fun ctx x -> ctx.Element.Opacity <- x), x)
    [<CustomOperation("Opacity")>] member inline this.Opacity ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Opacity), (fun ctx x -> ctx.Element.Opacity <- x), x)

    [<CustomOperation("Brush")>]
    member inline this.Brush ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Brush <- x), creator)

    [<CustomOperation("Brush")>]
    member inline this.Brush ([<InlineIfLambda>] builder: BuildElement<'Element>, creator) =
        this.MakeAdaptiveSingleChildBuilder(builder, (fun ctx x -> ctx.Element.Brush <- x), creator)
                        
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.Graphics.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)
    [<CustomOperation("Offset")>] member inline this.Offset ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Offset), (fun ctx x -> ctx.Element.Offset <- x), x)

                

type SwipeItemsBuilder<'Element when 'Element :> Microsoft.Maui.Controls.SwipeItems>() =
    inherit ElementBuilder<'Element>()

    [<CustomOperation("Mode")>] member inline this.Mode ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.SwipeMode) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Mode), (fun ctx x -> ctx.Element.Mode <- x), x)
    [<CustomOperation("Mode")>] member inline this.Mode ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Mode), (fun ctx x -> ctx.Element.Mode <- x), x)
    [<CustomOperation("SwipeBehaviorOnInvoked")>] member inline this.SwipeBehaviorOnInvoked ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Microsoft.Maui.SwipeBehaviorOnInvoked) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.SwipeBehaviorOnInvoked), (fun ctx x -> ctx.Element.SwipeBehaviorOnInvoked <- x), x)
    [<CustomOperation("SwipeBehaviorOnInvoked")>] member inline this.SwipeBehaviorOnInvoked ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.SwipeBehaviorOnInvoked), (fun ctx x -> ctx.Element.SwipeBehaviorOnInvoked <- x), x)

    [<CustomOperation("CollectionChanged")>] member inline this.CollectionChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.CollectionChanged), "CollectionChanged", fn)
                
            

// =======================================================================================================================

namespace Fun.SunUI.MAUI

[<AutoOpen>]
module MAUIElementBuilderDslCE_MicrosoftMauiControls =
  
    open Fun.SunUI
    open Fun.SunUI.MAUI.DslInternals

    type Page' () = 
        inherit PageBuilder<Microsoft.Maui.Controls.Page>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Page>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Page()), this.GetRenderMode())

    type TemplatedPage' () = 
        inherit TemplatedPageBuilder<Microsoft.Maui.Controls.TemplatedPage>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TemplatedPage>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TemplatedPage()), this.GetRenderMode())

    type ContentPage' () = 
        inherit ContentPageBuilder<Microsoft.Maui.Controls.ContentPage>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ContentPage>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ContentPage()), this.GetRenderMode())

    type Shell' () = 
        inherit ShellBuilder<Microsoft.Maui.Controls.Shell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shell>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shell()), this.GetRenderMode())

    type TemplatedView' () = 
        inherit TemplatedViewBuilder<Microsoft.Maui.Controls.TemplatedView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TemplatedView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TemplatedView()), this.GetRenderMode())

    type ContentView' () = 
        inherit ContentViewBuilder<Microsoft.Maui.Controls.ContentView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ContentView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ContentView()), this.GetRenderMode())

    type Frame' () = 
        inherit FrameBuilder<Microsoft.Maui.Controls.Frame>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Frame>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Frame()), this.GetRenderMode())

    type RefreshView' () = 
        inherit RefreshViewBuilder<Microsoft.Maui.Controls.RefreshView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.RefreshView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.RefreshView()), this.GetRenderMode())

    type SwipeItemView' () = 
        inherit SwipeItemViewBuilder<Microsoft.Maui.Controls.SwipeItemView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeItemView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SwipeItemView()), this.GetRenderMode())

    type SwipeView' () = 
        inherit SwipeViewBuilder<Microsoft.Maui.Controls.SwipeView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SwipeView()), this.GetRenderMode())

    type IndicatorView' () = 
        inherit IndicatorViewBuilder<Microsoft.Maui.Controls.IndicatorView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.IndicatorView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.IndicatorView()), this.GetRenderMode())

    type RadioButton' () = 
        inherit RadioButtonBuilder<Microsoft.Maui.Controls.RadioButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.RadioButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.RadioButton()), this.GetRenderMode())

    type ContentPresenter' () = 
        inherit ContentPresenterBuilder<Microsoft.Maui.Controls.ContentPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ContentPresenter>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ContentPresenter()), this.GetRenderMode())

    type ScrollView' () = 
        inherit ScrollViewBuilder<Microsoft.Maui.Controls.ScrollView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ScrollView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ScrollView()), this.GetRenderMode())

    type StructuredItemsView' () = 
        inherit StructuredItemsViewBuilder<Microsoft.Maui.Controls.StructuredItemsView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.StructuredItemsView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.StructuredItemsView()), this.GetRenderMode())

    type SelectableItemsView' () = 
        inherit SelectableItemsViewBuilder<Microsoft.Maui.Controls.SelectableItemsView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SelectableItemsView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SelectableItemsView()), this.GetRenderMode())

    type GroupableItemsView' () = 
        inherit GroupableItemsViewBuilder<Microsoft.Maui.Controls.GroupableItemsView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.GroupableItemsView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.GroupableItemsView()), this.GetRenderMode())

    type ReorderableItemsView' () = 
        inherit ReorderableItemsViewBuilder<Microsoft.Maui.Controls.ReorderableItemsView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ReorderableItemsView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ReorderableItemsView()), this.GetRenderMode())

    type CollectionView' () = 
        inherit CollectionViewBuilder<Microsoft.Maui.Controls.CollectionView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.CollectionView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.CollectionView()), this.GetRenderMode())

    type CarouselView' () = 
        inherit CarouselViewBuilder<Microsoft.Maui.Controls.CarouselView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.CarouselView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.CarouselView()), this.GetRenderMode())

    type HorizontalStackLayout' () = 
        inherit HorizontalStackLayoutBuilder<Microsoft.Maui.Controls.HorizontalStackLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.HorizontalStackLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.HorizontalStackLayout()), this.GetRenderMode())

    type StackLayout' () = 
        inherit StackLayoutBuilder<Microsoft.Maui.Controls.StackLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.StackLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.StackLayout()), this.GetRenderMode())

    type VerticalStackLayout' () = 
        inherit VerticalStackLayoutBuilder<Microsoft.Maui.Controls.VerticalStackLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.VerticalStackLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.VerticalStackLayout()), this.GetRenderMode())

    type AbsoluteLayout' () = 
        inherit AbsoluteLayoutBuilder<Microsoft.Maui.Controls.AbsoluteLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.AbsoluteLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.AbsoluteLayout()), this.GetRenderMode())

    type FlexLayout' () = 
        inherit FlexLayoutBuilder<Microsoft.Maui.Controls.FlexLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FlexLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.FlexLayout()), this.GetRenderMode())

    type Grid' () = 
        inherit GridBuilder<Microsoft.Maui.Controls.Grid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Grid>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Grid()), this.GetRenderMode())

    type Editor' () = 
        inherit EditorBuilder<Microsoft.Maui.Controls.Editor>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Editor>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Editor()), this.GetRenderMode())

    type Entry' () = 
        inherit EntryBuilder<Microsoft.Maui.Controls.Entry>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Entry>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Entry()), this.GetRenderMode())

    type SearchBar' () = 
        inherit SearchBarBuilder<Microsoft.Maui.Controls.SearchBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SearchBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SearchBar()), this.GetRenderMode())

    type ActivityIndicator' () = 
        inherit ActivityIndicatorBuilder<Microsoft.Maui.Controls.ActivityIndicator>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ActivityIndicator>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ActivityIndicator()), this.GetRenderMode())

    type Border' () = 
        inherit BorderBuilder<Microsoft.Maui.Controls.Border>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Border>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Border()), this.GetRenderMode())

    type BoxView' () = 
        inherit BoxViewBuilder<Microsoft.Maui.Controls.BoxView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.BoxView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.BoxView()), this.GetRenderMode())

    type Button' () = 
        inherit ButtonBuilder<Microsoft.Maui.Controls.Button>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Button>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Button()), this.GetRenderMode())

    type CheckBox' () = 
        inherit CheckBoxBuilder<Microsoft.Maui.Controls.CheckBox>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.CheckBox>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.CheckBox()), this.GetRenderMode())

    type DatePicker' () = 
        inherit DatePickerBuilder<Microsoft.Maui.Controls.DatePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.DatePicker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.DatePicker()), this.GetRenderMode())

    type GraphicsView' () = 
        inherit GraphicsViewBuilder<Microsoft.Maui.Controls.GraphicsView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.GraphicsView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.GraphicsView()), this.GetRenderMode())

    type Image' () = 
        inherit ImageBuilder<Microsoft.Maui.Controls.Image>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Image>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Image()), this.GetRenderMode())

    type ImageButton' () = 
        inherit ImageButtonBuilder<Microsoft.Maui.Controls.ImageButton>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ImageButton>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ImageButton()), this.GetRenderMode())

    type Label' () = 
        inherit LabelBuilder<Microsoft.Maui.Controls.Label>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Label>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Label()), this.GetRenderMode())

    type Picker' () = 
        inherit PickerBuilder<Microsoft.Maui.Controls.Picker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Picker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Picker()), this.GetRenderMode())

    type ProgressBar' () = 
        inherit ProgressBarBuilder<Microsoft.Maui.Controls.ProgressBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ProgressBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ProgressBar()), this.GetRenderMode())

    type Slider' () = 
        inherit SliderBuilder<Microsoft.Maui.Controls.Slider>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Slider>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Slider()), this.GetRenderMode())

    type Stepper' () = 
        inherit StepperBuilder<Microsoft.Maui.Controls.Stepper>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Stepper>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Stepper()), this.GetRenderMode())

    type Switch' () = 
        inherit SwitchBuilder<Microsoft.Maui.Controls.Switch>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Switch>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Switch()), this.GetRenderMode())

    type TimePicker' () = 
        inherit TimePickerBuilder<Microsoft.Maui.Controls.TimePicker>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TimePicker>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TimePicker()), this.GetRenderMode())

    type WebView' () = 
        inherit WebViewBuilder<Microsoft.Maui.Controls.WebView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.WebView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.WebView()), this.GetRenderMode())

    type ListView' () = 
        inherit ListViewBuilder<Microsoft.Maui.Controls.ListView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ListView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ListView()), this.GetRenderMode())

    type OpenGLView' () = 
        inherit OpenGLViewBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.OpenGLView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.OpenGLView()), this.GetRenderMode())

    type TableView' () = 
        inherit TableViewBuilder<Microsoft.Maui.Controls.TableView>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TableView>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TableView()), this.GetRenderMode())

    type BaseShellItem' () = 
        inherit BaseShellItemBuilder<Microsoft.Maui.Controls.BaseShellItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.BaseShellItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.BaseShellItem()), this.GetRenderMode())

    type ShellGroupItem' () = 
        inherit ShellGroupItemBuilder<Microsoft.Maui.Controls.ShellGroupItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ShellGroupItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ShellGroupItem()), this.GetRenderMode())

    type ShellItem' () = 
        inherit ShellItemBuilder<Microsoft.Maui.Controls.ShellItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ShellItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ShellItem()), this.GetRenderMode())

    type FlyoutItem' () = 
        inherit FlyoutItemBuilder<Microsoft.Maui.Controls.FlyoutItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FlyoutItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.FlyoutItem()), this.GetRenderMode())

    type TabBar' () = 
        inherit TabBarBuilder<Microsoft.Maui.Controls.TabBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TabBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TabBar()), this.GetRenderMode())

    type ShellSection' () = 
        inherit ShellSectionBuilder<Microsoft.Maui.Controls.ShellSection>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ShellSection>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ShellSection()), this.GetRenderMode())

    type Tab' () = 
        inherit TabBuilder<Microsoft.Maui.Controls.Tab>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Tab>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Tab()), this.GetRenderMode())

    type ShellContent' () = 
        inherit ShellContentBuilder<Microsoft.Maui.Controls.ShellContent>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ShellContent>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ShellContent()), this.GetRenderMode())

    type Window' () = 
        inherit WindowBuilder<Microsoft.Maui.Controls.Window>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Window>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Window()), this.GetRenderMode())

    type TextCell' () = 
        inherit TextCellBuilder<Microsoft.Maui.Controls.TextCell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TextCell>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TextCell()), this.GetRenderMode())

    type ImageCell' () = 
        inherit ImageCellBuilder<Microsoft.Maui.Controls.ImageCell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ImageCell>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ImageCell()), this.GetRenderMode())

    type EntryCell' () = 
        inherit EntryCellBuilder<Microsoft.Maui.Controls.EntryCell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.EntryCell>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.EntryCell()), this.GetRenderMode())

    type SwitchCell' () = 
        inherit SwitchCellBuilder<Microsoft.Maui.Controls.SwitchCell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwitchCell>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SwitchCell()), this.GetRenderMode())

    type ViewCell' () = 
        inherit ViewCellBuilder<Microsoft.Maui.Controls.ViewCell>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ViewCell>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ViewCell()), this.GetRenderMode())

    type MenuItem' () = 
        inherit MenuItemBuilder<Microsoft.Maui.Controls.MenuItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.MenuItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.MenuItem()), this.GetRenderMode())

    type MenuFlyoutItem' () = 
        inherit MenuFlyoutItemBuilder<Microsoft.Maui.Controls.MenuFlyoutItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.MenuFlyoutItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.MenuFlyoutItem()), this.GetRenderMode())

    type MenuFlyoutSubItem' () = 
        inherit MenuFlyoutSubItemBuilder<Microsoft.Maui.Controls.MenuFlyoutSubItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.MenuFlyoutSubItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.MenuFlyoutSubItem()), this.GetRenderMode())

    type SwipeItem' () = 
        inherit SwipeItemBuilder<Microsoft.Maui.Controls.SwipeItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SwipeItem()), this.GetRenderMode())

    type ToolbarItem' () = 
        inherit ToolbarItemBuilder<Microsoft.Maui.Controls.ToolbarItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ToolbarItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ToolbarItem()), this.GetRenderMode())

    type MenuBarItem' () = 
        inherit MenuBarItemBuilder<Microsoft.Maui.Controls.MenuBarItem>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.MenuBarItem>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.MenuBarItem()), this.GetRenderMode())

    type LinearGradientBrush' () = 
        inherit LinearGradientBrushBuilder<Microsoft.Maui.Controls.LinearGradientBrush>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.LinearGradientBrush>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.LinearGradientBrush()), this.GetRenderMode())

    type RadialGradientBrush' () = 
        inherit RadialGradientBrushBuilder<Microsoft.Maui.Controls.RadialGradientBrush>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.RadialGradientBrush>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.RadialGradientBrush()), this.GetRenderMode())

    type SolidColorBrush' () = 
        inherit SolidColorBrushBuilder<Microsoft.Maui.Controls.SolidColorBrush>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SolidColorBrush>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SolidColorBrush()), this.GetRenderMode())

    type GestureRecognizer' () = 
        inherit GestureRecognizerBuilder<Microsoft.Maui.Controls.GestureRecognizer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.GestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.GestureRecognizer()), this.GetRenderMode())

    type ClickGestureRecognizer' () = 
        inherit ClickGestureRecognizerBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.ClickGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.ClickGestureRecognizer()), this.GetRenderMode())

    type DragGestureRecognizer' () = 
        inherit DragGestureRecognizerBuilder<Microsoft.Maui.Controls.DragGestureRecognizer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.DragGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.DragGestureRecognizer()), this.GetRenderMode())

    type DropGestureRecognizer' () = 
        inherit DropGestureRecognizerBuilder<Microsoft.Maui.Controls.DropGestureRecognizer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.DropGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.DropGestureRecognizer()), this.GetRenderMode())

    type PanGestureRecognizer' () = 
        inherit PanGestureRecognizerBuilder<Microsoft.Maui.Controls.PanGestureRecognizer>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.PanGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.PanGestureRecognizer()), this.GetRenderMode())

    type PinchGestureRecognizer' () = 
        inherit PinchGestureRecognizerBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.PinchGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.PinchGestureRecognizer()), this.GetRenderMode())

    type SwipeGestureRecognizer' () = 
        inherit SwipeGestureRecognizerBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SwipeGestureRecognizer()), this.GetRenderMode())

    type TapGestureRecognizer' () = 
        inherit TapGestureRecognizerBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.TapGestureRecognizer>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.TapGestureRecognizer()), this.GetRenderMode())

    type FileImageSource' () = 
        inherit FileImageSourceBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FileImageSource>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.FileImageSource()), this.GetRenderMode())

    type FontImageSource' () = 
        inherit FontImageSourceBuilder<Microsoft.Maui.Controls.FontImageSource>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FontImageSource>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.FontImageSource()), this.GetRenderMode())

    type StreamImageSource' () = 
        inherit StreamImageSourceBuilder<Microsoft.Maui.Controls.StreamImageSource>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.StreamImageSource>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.StreamImageSource()), this.GetRenderMode())

    type UriImageSource' () = 
        inherit UriImageSourceBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.UriImageSource>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.UriImageSource()), this.GetRenderMode())

    type GestureElement' () = 
        inherit GestureElementBuilder<Microsoft.Maui.Controls.GestureElement>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.GestureElement>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.GestureElement()), this.GetRenderMode())

    type Span' () = 
        inherit SpanBuilder<Microsoft.Maui.Controls.Span>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Span>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Span()), this.GetRenderMode())

    type Application' () = 
        inherit ApplicationBuilder<Microsoft.Maui.Controls.Application>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Application>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Application()), this.GetRenderMode())

    type AppLinkEntry' () = 
        inherit AppLinkEntryBuilder<Microsoft.Maui.Controls.AppLinkEntry>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.AppLinkEntry>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.AppLinkEntry()), this.GetRenderMode())

    type FormattedString' () = 
        inherit FormattedStringBuilder<Microsoft.Maui.Controls.FormattedString>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.FormattedString>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.FormattedString()), this.GetRenderMode())

    type GradientStop' () = 
        inherit GradientStopBuilder<Microsoft.Maui.Controls.GradientStop>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.GradientStop>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.GradientStop()), this.GetRenderMode())

    type MenuBar' () = 
        inherit MenuBarBuilder<Microsoft.Maui.Controls.MenuBar>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.MenuBar>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.MenuBar()), this.GetRenderMode())

    type Shadow' () = 
        inherit ShadowBuilder<Microsoft.Maui.Controls.Shadow>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shadow>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shadow()), this.GetRenderMode())

    type SwipeItems' () = 
        inherit SwipeItemsBuilder<Microsoft.Maui.Controls.SwipeItems>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.SwipeItems>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.SwipeItems()), this.GetRenderMode())

            
namespace Fun.SunUI.MAUI.Compatibility

[<AutoOpen>]
module MAUIElementBuilderDslCE_MicrosoftMauiControlsCompatibility =
  
    open Fun.SunUI
    open Fun.SunUI.MAUI.DslInternals.Compatibility

    type AbsoluteLayout' () = 
        inherit AbsoluteLayoutBuilder<Microsoft.Maui.Controls.Compatibility.AbsoluteLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Compatibility.AbsoluteLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Compatibility.AbsoluteLayout()), this.GetRenderMode())

    type FlexLayout' () = 
        inherit FlexLayoutBuilder<Microsoft.Maui.Controls.Compatibility.FlexLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Compatibility.FlexLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Compatibility.FlexLayout()), this.GetRenderMode())

    type Grid' () = 
        inherit GridBuilder<Microsoft.Maui.Controls.Compatibility.Grid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Compatibility.Grid>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Compatibility.Grid()), this.GetRenderMode())

    type RelativeLayout' () = 
        inherit RelativeLayoutBuilder<Microsoft.Maui.Controls.Compatibility.RelativeLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Compatibility.RelativeLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Compatibility.RelativeLayout()), this.GetRenderMode())

    type StackLayout' () = 
        inherit StackLayoutBuilder<Microsoft.Maui.Controls.Compatibility.StackLayout>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Compatibility.StackLayout>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Compatibility.StackLayout()), this.GetRenderMode())

            
namespace Fun.SunUI.MAUI.Shapes

[<AutoOpen>]
module MAUIElementBuilderDslCE_MicrosoftMauiControlsShapes =
  
    open Fun.SunUI
    open Fun.SunUI.MAUI.DslInternals.Shapes

    type Ellipse' () = 
        inherit EllipseBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Ellipse>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.Ellipse()), this.GetRenderMode())

    type Line' () = 
        inherit LineBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Line>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.Line()), this.GetRenderMode())

    type Path' () = 
        inherit PathBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Path>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.Path()), this.GetRenderMode())

    type Polygon' () = 
        inherit PolygonBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polygon>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.Polygon()), this.GetRenderMode())

    type Polyline' () = 
        inherit PolylineBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Polyline>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.Polyline()), this.GetRenderMode())

    type Rectangle' () = 
        inherit RectangleBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.Rectangle>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.Rectangle()), this.GetRenderMode())

    type RoundRectangle' () = 
        inherit RoundRectangleBuilder()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Microsoft.Maui.Controls.Shapes.RoundRectangle>) = this.MakeElementCreator(builder, (fun _ -> new Microsoft.Maui.Controls.Shapes.RoundRectangle()), this.GetRenderMode())

            