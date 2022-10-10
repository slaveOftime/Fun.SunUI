[<AutoOpen>]
module Fun.SunUI.MAUI.Extensions

open FSharp.Data.Adaptive
open Microsoft.Maui.Controls
open Fun.SunUI
open Fun.SunUI.MAUI.DslInternals


type ElementBuilder<'Element when 'Element :> Microsoft.Maui.Controls.Element> with

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


    [<CustomOperation("SematicDescription")>]
    member inline this.SematicDescription([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With(builder, (fun this -> SemanticProperties.SetDescription(this, x)))

    [<CustomOperation("SematicDescription")>]
    member inline this.SematicDescription([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                SemanticProperties.SetDescription(this, x)
            })
        )


    [<CustomOperation("SematicHeadingLevel")>]
    member inline this.SematicHeadingLevel([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With(builder, (fun this -> SemanticProperties.SetHeadingLevel(this, x)))

    [<CustomOperation("SematicHeadingLevel")>]
    member inline this.SematicHeadingLevel([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                SemanticProperties.SetHeadingLevel(this, x)
            })
        )


    [<CustomOperation("SematicHint")>]
    member inline this.SematicHint([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With(builder, (fun this -> SemanticProperties.SetHint(this, x)))

    [<CustomOperation("SematicHint")>]
    member inline this.SematicHint([<InlineIfLambda>] builder: BuildElement<'Element>, x) =
        this.With'(
            builder,
            (fun this -> adaptive {
                let! x = x
                SemanticProperties.SetHint(this, x)
            })
        )
