[<AutoOpen>]
module Fun.SunUI.AdaptiveExtensions

open FSharp.Data.Adaptive
open System.Runtime.CompilerServices


type AValBuilder with

    member _.Zero() = AVal.constant ()


[<Extension>]
type Extensions =
    [<Extension>]
    static member Publish(this: cval<'T>, x: 'T) = transact (fun () -> this.Value <- x)

    [<Extension>]
    static member Publish(this: cval<'T>, fn: 'T -> 'T) = transact (fun () -> this.Value <- fn this.Value)

    [<Extension>]
    static member WithSetter(this: cval<'T>) =
        let setValue x = transact (fun () -> this.Value <- x)
        this |> AVal.map (fun x -> x, setValue)


    /// The action will be triggered immediately
    /// The default AddCallback will have the same effect, but it has an override with (obj -> unit) which make type infer harder
    [<Extension>]
    static member AddInstantCallback(value: aval<'T>, action: 'T -> unit) = value.AddCallback(fun (x: 'T) -> action x)


    /// This is a helper method to avoid trigger action when you first call this function
    /// Because the default AddCallback will trigger the action immediately
    [<Extension>]
    static member AddLazyCallback(value: aval<'T>, action: 'T -> unit) =
        let last = ref ValueNone

        let sub =
            value.AddMarkingCallback(fun () ->
                Transaction.Running.Value.AddFinalizer(fun () ->
                    let v = AVal.force value
                    match last.Value with
                    | ValueSome o when DefaultEquality.equals o v -> ()
                    | _ ->
                        last.Value <- ValueSome v
                        action v
                )
            )

        match Transaction.Running with
        | ValueSome t -> t.AddFinalizer(fun () -> value |> AVal.force |> ignore)
        | ValueNone -> value |> AVal.force |> ignore

        sub
