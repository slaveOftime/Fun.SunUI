namespace Fun.Modern.Forms

open System


type IElementContext =
    inherit IDisposable

    abstract member Key: obj
    abstract member NativeElement: obj
    abstract member ServiceProvider: IServiceProvider


type ElementContext<'Element>(nativeElement: 'Element, sp: IServiceProvider, ?key: obj) as this =
    member val Properties = System.Collections.Generic.Dictionary<string, obj>()
    member val ChildContexts = ResizeArray<IElementContext>()

    member _.Element = nativeElement

    interface IElementContext with
        member _.Key = Option.toObj key
        member _.NativeElement = box nativeElement
        member _.ServiceProvider = sp

        member _.Dispose() =
            match tryUnbox<IDisposable> nativeElement with
            | Some x -> x.Dispose()
            | _ -> ()

            for KeyValue (_, property) in this.Properties do
                match tryUnbox<IDisposable> property with
                | Some x -> x.Dispose()
                | _ -> ()


[<Struct>]
type ElementCreator = {
    Key: obj
    CreateOrUpdate: IServiceProvider * IElementContext voption -> IElementContext
}


type ElementBuilder<'Element> = delegate of ctx: ElementContext<'Element> * index: int -> int
