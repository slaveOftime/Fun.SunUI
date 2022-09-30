namespace Fun.Modern.Forms

open System
open FSharp.Data.Adaptive


type IElementContext =
    inherit IDisposable

    abstract member Key: obj with get, set
    abstract member NativeElement: obj
    abstract member ServiceProvider: IServiceProvider


type ElementFactories = (unit -> IElementContext) * (IElementContext -> IElementContext)


[<Struct>]
type ElementCreator = {
    Key: obj
    CreateOrUpdate: IServiceProvider * IElementContext voption -> IElementContext
}


type ElementContext<'Element>(nativeElement: 'Element, sp: IServiceProvider, ?key: obj) as this =
    member val Properties = System.Collections.Generic.Dictionary<string, obj>()
    member val ChildContexts = ResizeArray<IElementContext>()

    member _.Element = nativeElement

    interface IElementContext with
        member val Key = Option.toObj key with get, set

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


type ElementBuilder<'Element> = delegate of ctx: ElementContext<'Element> * index: int -> int
