[<AutoOpen>]
module System.Windows.Controls.Extensions

open System.Windows.Controls
open System.Windows.DslInternals
open FSharp.Data.Adaptive
open Fun.SunUI


type UIElementBuilder<'Element when 'Element :> System.Windows.UIElement> with

    [<CustomOperation("GridRow")>]
    member inline this.GridRow([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.With(builder, (fun this -> Grid.SetRow(this, x)))

    [<CustomOperation("GridRow")>]
    member inline this.GridRow([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                Grid.SetRow(this, x)
            })
        )


    [<CustomOperation("GridCol")>]
    member inline this.GridCol([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.With(builder, (fun this -> Grid.SetColumn(this, x)))

    [<CustomOperation("GridCol")>]
    member inline this.GridCol([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                Grid.SetColumn(this, x)
            })
        )


    [<CustomOperation("GridRowSpan")>]
    member inline this.GridRowSpan([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.With(builder, (fun this -> Grid.SetRowSpan(this, x)))

    [<CustomOperation("GridRowSpan")>]
    member inline this.GridRowSpan([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                Grid.SetRowSpan(this, x)
            })
        )


    [<CustomOperation("GridColSpan")>]
    member inline this.GridColSpan([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With(builder, (fun this -> Grid.SetColumnSpan(this, x)))

    [<CustomOperation("GridColSpan")>]
    member inline this.GridColSpan([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                Grid.SetColumnSpan(this, x)
            })
        )


type Grid' with

    [<CustomOperation("Rows")>]
    member inline this.Rows([<InlineIfLambda>] builder: BuildElement<Grid>, rows: RowDefinition seq) = this.With(builder, fun comp -> comp.RowDefinitions.Clear(); rows |> Seq.iter comp.RowDefinitions.Add)

    [<CustomOperation("Columns")>]
    member inline this.Columns([<InlineIfLambda>] builder: BuildElement<Grid>, rows: ColumnDefinition seq) = this.With(builder, fun comp -> comp.ColumnDefinitions.Clear(); rows |> Seq.iter comp.ColumnDefinitions.Add)
