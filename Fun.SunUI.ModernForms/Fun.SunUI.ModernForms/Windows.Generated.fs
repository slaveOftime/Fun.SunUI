namespace rec Fun.SunUI.ModernForms.DslInternals
open Fun.SunUI.ModernForms.DslInternals
open Fun.SunUI
open Fun.SunUI.ModernForms


type WindowBaseBuilder<'Element when 'Element :> Modern.Forms.WindowBase>() =
    inherit ModernFormsWindowBaseBuilder<'Element>()

    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("Bounds'")>] member inline this.Bounds' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Bounds), x)
    [<CustomOperation("CurrentStyle")>] member inline this.CurrentStyle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.CurrentStyle), x)
    [<CustomOperation("CurrentStyle'")>] member inline this.CurrentStyle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.CurrentStyle), x)
    [<CustomOperation("DisplayRectangle")>] member inline this.DisplayRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.DisplayRectangle), x)
    [<CustomOperation("DisplayRectangle'")>] member inline this.DisplayRectangle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.DisplayRectangle), x)
    [<CustomOperation("Location")>] member inline this.Location ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Location), x)
    [<CustomOperation("Location'")>] member inline this.Location' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Location), x)
    [<CustomOperation("Resizeable")>] member inline this.Resizeable ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Resizeable), (fun ctx x -> ctx.Element.Resizeable <- x), x)
    [<CustomOperation("Resizeable")>] member inline this.Resizeable ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Resizeable), (fun ctx x -> ctx.Element.Resizeable <- x), x)
    [<CustomOperation("ScaledDisplayRectangle")>] member inline this.ScaledDisplayRectangle ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ScaledDisplayRectangle), x)
    [<CustomOperation("ScaledDisplayRectangle'")>] member inline this.ScaledDisplayRectangle' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ScaledDisplayRectangle), x)
    [<CustomOperation("ScaledSize")>] member inline this.ScaledSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ScaledSize), x)
    [<CustomOperation("ScaledSize'")>] member inline this.ScaledSize' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ScaledSize), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Size), x)
    [<CustomOperation("Size'")>] member inline this.Size' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Size), x)
    [<CustomOperation("StartPosition")>] member inline this.StartPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.FormStartPosition) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.StartPosition), (fun ctx x -> ctx.Element.StartPosition <- x), x)
    [<CustomOperation("StartPosition")>] member inline this.StartPosition ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.StartPosition), (fun ctx x -> ctx.Element.StartPosition <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)

    [<CustomOperation("Closed")>] member inline this.Closed ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closed), "Closed", fn)
    [<CustomOperation("Deactivated")>] member inline this.Deactivated ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Deactivated), "Deactivated", fn)
    [<CustomOperation("MaximumSizeChanged")>] member inline this.MaximumSizeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumSizeChanged), "MaximumSizeChanged", fn)
    [<CustomOperation("MinimumSizeChanged")>] member inline this.MinimumSizeChanged ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumSizeChanged), "MinimumSizeChanged", fn)
    [<CustomOperation("Shown")>] member inline this.Shown ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Shown), "Shown", fn)
                

type FormBuilder<'Element when 'Element :> Modern.Forms.Form>() =
    inherit WindowBaseBuilder<'Element>()

    [<CustomOperation("AllowMaximize")>] member inline this.AllowMaximize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMaximize), (fun ctx x -> ctx.Element.AllowMaximize <- x), x)
    [<CustomOperation("AllowMaximize")>] member inline this.AllowMaximize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMaximize), (fun ctx x -> ctx.Element.AllowMaximize <- x), x)
    [<CustomOperation("AllowMinimize")>] member inline this.AllowMinimize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMinimize), (fun ctx x -> ctx.Element.AllowMinimize <- x), x)
    [<CustomOperation("AllowMinimize")>] member inline this.AllowMinimize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.AllowMinimize), (fun ctx x -> ctx.Element.AllowMinimize <- x), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Rectangle) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Bounds), (fun ctx x -> ctx.Element.Bounds <- x), x)
    [<CustomOperation("Bounds")>] member inline this.Bounds ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Bounds), (fun ctx x -> ctx.Element.Bounds <- x), x)
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.DialogResult) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("DialogResult")>] member inline this.DialogResult ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.DialogResult), (fun ctx x -> ctx.Element.DialogResult <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x: SkiaSharp.SKBitmap) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("Image")>] member inline this.Image ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Image), (fun ctx x -> ctx.Element.Image <- x), x)
    [<CustomOperation("Location")>] member inline this.Location ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Point) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Location), (fun ctx x -> ctx.Element.Location <- x), x)
    [<CustomOperation("Location")>] member inline this.Location ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Location), (fun ctx x -> ctx.Element.Location <- x), x)
    [<CustomOperation("MaximumSize")>] member inline this.MaximumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumSize), (fun ctx x -> ctx.Element.MaximumSize <- x), x)
    [<CustomOperation("MaximumSize")>] member inline this.MaximumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MaximumSize), (fun ctx x -> ctx.Element.MaximumSize <- x), x)
    [<CustomOperation("MinimumSize")>] member inline this.MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumSize), (fun ctx x -> ctx.Element.MinimumSize <- x), x)
    [<CustomOperation("MinimumSize")>] member inline this.MinimumSize ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.MinimumSize), (fun ctx x -> ctx.Element.MinimumSize <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("Text")>] member inline this.Text ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Text), (fun ctx x -> ctx.Element.Text <- x), x)
    [<CustomOperation("TitleBar")>] member inline this.TitleBar ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.TitleBar), x)
    [<CustomOperation("TitleBar'")>] member inline this.TitleBar' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.TitleBar), x)
    [<CustomOperation("UseSystemDecorations")>] member inline this.UseSystemDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.UseSystemDecorations), (fun ctx x -> ctx.Element.UseSystemDecorations <- x), x)
    [<CustomOperation("UseSystemDecorations")>] member inline this.UseSystemDecorations ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.UseSystemDecorations), (fun ctx x -> ctx.Element.UseSystemDecorations <- x), x)
    [<CustomOperation("WindowState")>] member inline this.WindowState ([<InlineIfLambda>] builder: BuildElement<'Element>, x: Modern.Forms.FormWindowState) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WindowState), (fun ctx x -> ctx.Element.WindowState <- x), x)
    [<CustomOperation("WindowState")>] member inline this.WindowState ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WindowState), (fun ctx x -> ctx.Element.WindowState <- x), x)

    [<CustomOperation("Closing")>] member inline this.Closing ([<InlineIfLambda>] builder: BuildElement<'Element>, fn) = this.MakeEventPropertyBuilder(builder, (fun ctx -> ctx.Element.Closing), "Closing", fn)
                

type MessageBoxFormBuilder<'Element when 'Element :> Modern.Forms.MessageBoxForm>() =
    inherit FormBuilder<'Element>()

    [<CustomOperation("Message")>] member inline this.Message ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.String) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Message), (fun ctx x -> ctx.Element.Message <- x), x)
    [<CustomOperation("Message")>] member inline this.Message ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Message), (fun ctx x -> ctx.Element.Message <- x), x)

                

type PopupWindowBuilder<'Element when 'Element :> Modern.Forms.PopupWindow>() =
    inherit WindowBaseBuilder<'Element>()

    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Drawing.Size) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Size")>] member inline this.Size ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Size), (fun ctx x -> ctx.Element.Size <- x), x)
    [<CustomOperation("Style")>] member inline this.Style ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.Style), x)
    [<CustomOperation("Style'")>] member inline this.Style' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.Style), x)

                
            

// =======================================================================================================================

namespace Fun.SunUI.ModernForms

[<AutoOpen>]
module ModernFormsWindowBaseBuilderDslCE_ModernForms =
  
    open Fun.SunUI
    open Fun.SunUI.ModernForms.DslInternals

    type Form' () = 
        inherit FormBuilder<Modern.Forms.Form>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.Form>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.Form()), this.GetRenderMode())

    type MessageBoxForm' () = 
        inherit MessageBoxFormBuilder<Modern.Forms.MessageBoxForm>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<Modern.Forms.MessageBoxForm>) = this.MakeElementCreator(builder, (fun _ -> new Modern.Forms.MessageBoxForm()), this.GetRenderMode())

            