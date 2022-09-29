namespace Fun.Modern.Forms

open FSharp.Data.Adaptive
open Modern.Forms


type AdaptiveControl () =
    inherit Control()

    let source = clist<ElementCreator>([])

    member _.Source: alist<ElementCreator> = source

