[<AutoOpen>]
module Fun.SunUI.AdaptiveExtensions

open FSharp.Data.Adaptive


type AValBuilder with

    member _.Zero() = AVal.constant ()
