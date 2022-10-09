[<AutoOpen>]
module Fun.SunUI.Internal.Utils


let inline saferCast<'TargetType> (child: obj) =
    try
        child :?> 'TargetType
    with ex ->
#if !FABLE_COMPILER
        let converter = typeof<'TargetType>.GetMethod ("op_Implicit", [| child.GetType() |])
        if converter = null then
            failwith $"Cannot convert {child.GetType()} to {typeof<'TargetType>}"
        else
            converter.Invoke(null, [| child |]) :?> 'TargetType
#else
        raise ex
#endif
