namespace Fun.SunUI.WinForms

open FSharp.Data.Adaptive
open System.Windows.Forms
open Fun.SunUI


type WinForms =
    class
    end


type WinFormsControlBuilder<'Element when 'Element :> Control>() =
    inherit ElementBuilder<WinForms, 'Element>()
