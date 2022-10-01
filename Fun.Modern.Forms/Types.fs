namespace Fun.Modern.Forms

open System


type IElementContext =
    inherit IDisposable

    abstract member Key: obj
    abstract member NativeElement: obj
    abstract member ServiceProvider: IServiceProvider


[<Struct>]
type ElementCreator = {
    Key: obj
    CreateOrUpdate: IServiceProvider * IElementContext voption -> IElementContext
}


/// Used to attach DSL functions
type UI = class end
