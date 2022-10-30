[<AutoOpen>]
module Fun.SunUI.HotReloadDsl

open Fun.SunUI
open Fun.SunUI.HotReload


type UI with

    /// Default host will be http://localhost:9025
    static member hotreload<'UIStack, 'T>
        (
            renderEntryName: string,
            renderFn: 'T -> ElementCreator<'UIStack>,
            renderFnArg: 'T,
            dispatcher: (unit -> unit) -> unit,
            ?host: string
        ) =
        HotreloadContext.CreateElementCreator<'UIStack, 'T>(
            defaultArg host "http://localhost:9025",
            renderEntryName,
            renderFn,
            renderFnArg,
            dispatcher
        )
