namespace Fun.SunUI

open System


type IElementContext =
    inherit IDisposable

    abstract member Key: obj with get, set
    abstract member NativeElement: obj
    abstract member ServiceProvider: IServiceProvider


[<Struct>]
type ElementCreator<'UIStack> = {
    Key: obj
    CreateOrUpdate: IServiceProvider * IElementContext voption -> IElementContext
}


/// Used to attach DSL functions
type UI = class end
