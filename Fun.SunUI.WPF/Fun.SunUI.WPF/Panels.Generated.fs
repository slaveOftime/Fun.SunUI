namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type PanelBuilder<'Element when 'Element :> System.Windows.Controls.Panel>() =
    inherit WPFPanelBuilder<'Element>()

    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Media.Brush) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("Background")>] member inline this.Background ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Background), (fun ctx x -> ctx.Element.Background <- x), x)
    [<CustomOperation("IsItemsHost")>] member inline this.IsItemsHost ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.IsItemsHost), (fun ctx x -> ctx.Element.IsItemsHost <- x), x)
    [<CustomOperation("IsItemsHost")>] member inline this.IsItemsHost ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.IsItemsHost), (fun ctx x -> ctx.Element.IsItemsHost <- x), x)

                

type VirtualizingPanelBuilder<'Element when 'Element :> System.Windows.Controls.VirtualizingPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("ItemContainerGenerator")>] member inline this.ItemContainerGenerator ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ItemContainerGenerator), x)
    [<CustomOperation("ItemContainerGenerator'")>] member inline this.ItemContainerGenerator' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ItemContainerGenerator), x)

                

type VirtualizingStackPanelBuilder<'Element when 'Element :> System.Windows.Controls.VirtualizingStackPanel>() =
    inherit VirtualizingPanelBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollViewer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DataGridRowsPresenterBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.DataGridRowsPresenter>() =
    inherit VirtualizingStackPanelBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type DataGridCellsPanelBuilder<'Element when 'Element :> System.Windows.Controls.DataGridCellsPanel>() =
    inherit VirtualizingPanelBuilder<'Element>()


                

type GridBuilder<'Element when 'Element :> System.Windows.Controls.Grid>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("ShowGridLines")>] member inline this.ShowGridLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ShowGridLines), (fun ctx x -> ctx.Element.ShowGridLines <- x), x)
    [<CustomOperation("ShowGridLines")>] member inline this.ShowGridLines ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ShowGridLines), (fun ctx x -> ctx.Element.ShowGridLines <- x), x)
    [<CustomOperation("ColumnDefinitions")>] member inline this.ColumnDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.ColumnDefinitions), x)
    [<CustomOperation("ColumnDefinitions'")>] member inline this.ColumnDefinitions' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.ColumnDefinitions), x)
    [<CustomOperation("RowDefinitions")>] member inline this.RowDefinitions ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyBuilder(builder, (fun x -> x.RowDefinitions), x)
    [<CustomOperation("RowDefinitions'")>] member inline this.RowDefinitions' ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeGetOnlyAdaptiveBuilder(builder, (fun x -> x.RowDefinitions), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type SelectiveScrollingGridBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.SelectiveScrollingGrid>() =
    inherit GridBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type StackPanelBuilder<'Element when 'Element :> System.Windows.Controls.StackPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanHorizontallyScroll")>] member inline this.CanHorizontallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanHorizontallyScroll), (fun ctx x -> ctx.Element.CanHorizontallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("CanVerticallyScroll")>] member inline this.CanVerticallyScroll ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.CanVerticallyScroll), (fun ctx x -> ctx.Element.CanVerticallyScroll <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.ScrollViewer) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)
    [<CustomOperation("ScrollOwner")>] member inline this.ScrollOwner ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ScrollOwner), (fun ctx x -> ctx.Element.ScrollOwner <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type ToolBarPanelBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.ToolBarPanel>() =
    inherit StackPanelBuilder<'Element>()


                
            
namespace rec Fun.SunUI.WPF.DslInternals
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type CanvasBuilder<'Element when 'Element :> System.Windows.Controls.Canvas>() =
    inherit PanelBuilder<'Element>()


                

type DockPanelBuilder<'Element when 'Element :> System.Windows.Controls.DockPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("LastChildFill")>] member inline this.LastChildFill ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Boolean) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.LastChildFill), (fun ctx x -> ctx.Element.LastChildFill <- x), x)
    [<CustomOperation("LastChildFill")>] member inline this.LastChildFill ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.LastChildFill), (fun ctx x -> ctx.Element.LastChildFill <- x), x)

                

type WrapPanelBuilder<'Element when 'Element :> System.Windows.Controls.WrapPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemWidth")>] member inline this.ItemWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemWidth), (fun ctx x -> ctx.Element.ItemWidth <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("ItemHeight")>] member inline this.ItemHeight ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.ItemHeight), (fun ctx x -> ctx.Element.ItemHeight <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Windows.Controls.Orientation) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)
    [<CustomOperation("Orientation")>] member inline this.Orientation ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Orientation), (fun ctx x -> ctx.Element.Orientation <- x), x)

                
            
namespace rec Fun.SunUI.WPF.DslInternals.Primitives
open Fun.SunUI.WPF.DslInternals
open Fun.SunUI
open Fun.SunUI.WPF


type TabPanelBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.TabPanel>() =
    inherit PanelBuilder<'Element>()


                

type ToolBarOverflowPanelBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.ToolBarOverflowPanel>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("WrapWidth")>] member inline this.WrapWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Double) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.WrapWidth), (fun ctx x -> ctx.Element.WrapWidth <- x), x)
    [<CustomOperation("WrapWidth")>] member inline this.WrapWidth ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.WrapWidth), (fun ctx x -> ctx.Element.WrapWidth <- x), x)

                

type UniformGridBuilder<'Element when 'Element :> System.Windows.Controls.Primitives.UniformGrid>() =
    inherit PanelBuilder<'Element>()

    [<CustomOperation("FirstColumn")>] member inline this.FirstColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.FirstColumn), (fun ctx x -> ctx.Element.FirstColumn <- x), x)
    [<CustomOperation("FirstColumn")>] member inline this.FirstColumn ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.FirstColumn), (fun ctx x -> ctx.Element.FirstColumn <- x), x)
    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Columns), (fun ctx x -> ctx.Element.Columns <- x), x)
    [<CustomOperation("Columns")>] member inline this.Columns ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Columns), (fun ctx x -> ctx.Element.Columns <- x), x)
    [<CustomOperation("Rows")>] member inline this.Rows ([<InlineIfLambda>] builder: BuildElement<'Element>, x: System.Int32) = this.MakeEqualityPropertyBuilder(builder, (fun ctx -> ctx.Element.Rows), (fun ctx x -> ctx.Element.Rows <- x), x)
    [<CustomOperation("Rows")>] member inline this.Rows ([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.MakeAdaptivePropertyBuilder(builder, (fun ctx -> ctx.Element.Rows), (fun ctx x -> ctx.Element.Rows <- x), x)

                
            

// =======================================================================================================================

namespace Fun.SunUI.WPF

[<AutoOpen>]
module WPFPanelBuilderDslCE_SystemWindowsControls =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals

    type VirtualizingStackPanel' () = 
        inherit VirtualizingStackPanelBuilder<System.Windows.Controls.VirtualizingStackPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.VirtualizingStackPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.VirtualizingStackPanel()), this.GetKey())

    type DataGridCellsPanel' () = 
        inherit DataGridCellsPanelBuilder<System.Windows.Controls.DataGridCellsPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DataGridCellsPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DataGridCellsPanel()), this.GetKey())

    type Grid' () = 
        inherit GridBuilder<System.Windows.Controls.Grid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Grid>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Grid()), this.GetKey())

    type StackPanel' () = 
        inherit StackPanelBuilder<System.Windows.Controls.StackPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.StackPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.StackPanel()), this.GetKey())

    type Canvas' () = 
        inherit CanvasBuilder<System.Windows.Controls.Canvas>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Canvas>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Canvas()), this.GetKey())

    type DockPanel' () = 
        inherit DockPanelBuilder<System.Windows.Controls.DockPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.DockPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.DockPanel()), this.GetKey())

    type WrapPanel' () = 
        inherit WrapPanelBuilder<System.Windows.Controls.WrapPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.WrapPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.WrapPanel()), this.GetKey())

            
namespace Fun.SunUI.WPF.Primitives

[<AutoOpen>]
module WPFPanelBuilderDslCE_SystemWindowsControlsPrimitives =
  
    open Fun.SunUI
    open Fun.SunUI.WPF.DslInternals.Primitives

    type DataGridRowsPresenter' () = 
        inherit DataGridRowsPresenterBuilder<System.Windows.Controls.Primitives.DataGridRowsPresenter>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.DataGridRowsPresenter>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.DataGridRowsPresenter()), this.GetKey())

    type SelectiveScrollingGrid' () = 
        inherit SelectiveScrollingGridBuilder<System.Windows.Controls.Primitives.SelectiveScrollingGrid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.SelectiveScrollingGrid>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.SelectiveScrollingGrid()), this.GetKey())

    type ToolBarPanel' () = 
        inherit ToolBarPanelBuilder<System.Windows.Controls.Primitives.ToolBarPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.ToolBarPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.ToolBarPanel()), this.GetKey())

    type TabPanel' () = 
        inherit TabPanelBuilder<System.Windows.Controls.Primitives.TabPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.TabPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.TabPanel()), this.GetKey())

    type ToolBarOverflowPanel' () = 
        inherit ToolBarOverflowPanelBuilder<System.Windows.Controls.Primitives.ToolBarOverflowPanel>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.ToolBarOverflowPanel>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.ToolBarOverflowPanel()), this.GetKey())

    type UniformGrid' () = 
        inherit UniformGridBuilder<System.Windows.Controls.Primitives.UniformGrid>()
        member inline this.Run([<InlineIfLambda>] builder: BuildElement<System.Windows.Controls.Primitives.UniformGrid>) = this.MakeElementCreator(builder, (fun _ -> new System.Windows.Controls.Primitives.UniformGrid()), this.GetKey())

            