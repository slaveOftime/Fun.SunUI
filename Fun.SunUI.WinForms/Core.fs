namespace Fun.SunUI.WinForms

open FSharp.Data.Adaptive
open System.Windows.Forms
open Fun.SunUI


type WinForms =
    class
    end


type WinFormsControlBuilder<'Element when 'Element :> Control>() =
    inherit ElementBuilder<WinForms, 'Element>()

    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinForms> seq) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x ->
                x.Element.SuspendLayout()
                x.Element.Controls.Clear()
            ),
            (fun x ls ->
                x.Element.Controls.AddRange(ls)
                x.Element.ResumeLayout(false)
                x.Element.PerformLayout()
            ),
            controls
        )


    [<CustomOperation("Controls")>]
    member inline this.Controls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinForms> alist) =
        this.MakeChildrenBuilder<'Element, Control>(
            builder,
            (fun x ->
                x.Element.SuspendLayout()
                x.Element.Controls.Clear()
            ),
            (fun x ls ->
                x.Element.Controls.AddRange(ls)

                x.Element.ResumeLayout(false)
                x.Element.PerformLayout()
            ),
            controls
        )


    [<CustomOperation("StaticControls")>]
    member inline this.StaticControls([<InlineIfLambda>] builder: BuildElement<'Element>, controls: ElementCreator<WinForms> seq) =
        this.MakeStaticChildrenBuilder<'Element, Control>(
            builder,
            (fun x ->
                x.Element.SuspendLayout()
                x.Element.Controls.Clear()
            ),
            (fun x ls ->
                x.Element.Controls.AddRange(ls)
                x.Element.ResumeLayout(false)
                x.Element.PerformLayout()
            ),
            controls
        )
