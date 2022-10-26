[<AutoOpen>]
module Avalonia.Controls.Extensions

open System
open FSharp.Data.Adaptive
open Avalonia
open Avalonia.Controls
open Avalonia.Controls.Templates
open Avalonia.DslInternals.Controls
open Fun.SunUI


type UI with

    static member inline CreateDataTemplate(sp: IServiceProvider, [<InlineIfLambda>] creator: 'Data -> ElementCreator<Avalonia>) =
        { new IDataTemplate with
            member _.Match _ = true
            member _.Build data = creator(unbox data).Build(sp)
        }


type ControlBuilder<'Element when 'Element :> Avalonia.Controls.Control> with

    [<CustomOperation("GridRow")>]
    member inline this.GridRow([<InlineIfLambda>] builder: BuildElement<'Element>, x) = this.With(builder, (fun this -> Grid.SetRow(this, x)))

    [<CustomOperation("GridRow")>]
    member inline this.GridRow([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                Grid.SetRow(this, x)
            }
            )
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
            }
            )
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
            }
            )
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
            }
            )
        )


type GridBuilder<'Element when 'Element :> Avalonia.Controls.Grid> with

    [<CustomOperation("RowDefinitions")>]
    member inline this.RowDefinitions([<InlineIfLambda>] builder: BuildElement<'Element>, x: string) =
        this.RowDefinitions(builder, Avalonia.Controls.RowDefinitions(x))

    [<CustomOperation("RowDefinitions")>]
    member inline this.RowDefinitions([<InlineIfLambda>] builder: BuildElement<'Element>, x: string aval) =
        this.RowDefinitions(builder, x |> AVal.map Avalonia.Controls.RowDefinitions)


    [<CustomOperation("ColDefinitions")>]
    member inline this.ColDefinitions([<InlineIfLambda>] builder: BuildElement<'Element>, x: string) =
        this.ColumnDefinitions(builder, Avalonia.Controls.ColumnDefinitions(x))

    [<CustomOperation("ColDefinitions")>]
    member inline this.ColDefinitions([<InlineIfLambda>] builder: BuildElement<'Element>, x: string aval) =
        this.ColumnDefinitions(builder, x |> AVal.map Avalonia.Controls.ColumnDefinitions)
