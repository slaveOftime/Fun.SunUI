namespace Fun.SunUI

open System


[<RequireQualifiedAccess; Struct>]
type RenderMode =
    /// Try to create if no old state, and rerender if the state is existing. This is default behavior.
    | CreateOnce
    /// Try to create if no old state, and do not rerender.
    | CreateOnceNoRerender
    /// Try to create if no old state with the same key, recreate if key changed. Rerender with old state.
    | Key of obj
    /// Always create new native element.
    | AlwaysRecreate


type IElementContext =
    inherit IDisposable

    abstract member RenderMode: RenderMode with get, set
    abstract member NativeElement: obj
    abstract member ServiceProvider: IServiceProvider


[<Struct>]
type ElementCreator<'UIStack> = {
    RenderMode: RenderMode
    CreateOrUpdate: IServiceProvider * IElementContext voption -> IElementContext
}


/// Used to attach DSL functions
type UI = class end
