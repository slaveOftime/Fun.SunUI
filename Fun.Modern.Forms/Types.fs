namespace Fun.Modern.Forms

open System


type IElementContext =
    inherit IDisposable

    abstract member Key: obj with get, set
    abstract member NativeElement: obj


[<Struct>]
type ElementCreator = {
    Key: obj
    CreateOrUpdate: IElementContext voption -> IElementContext
}


type ElementContext<'Element>(nativeElement: 'Element) as this =
    member val Properties = System.Collections.Generic.Dictionary<string, obj>()
    member val ChildrenContexts = ResizeArray<IElementContext>()

    member _.Element = nativeElement

    interface IElementContext with
        member val Key = null with get, set
        member _.NativeElement = box nativeElement

        member _.Dispose() =
            match tryUnbox<IDisposable> nativeElement with
            | Some x -> x.Dispose()
            | _ -> ()

            for KeyValue (_, property) in this.Properties do
                match tryUnbox<IDisposable> property with
                | Some x -> x.Dispose()
                | _ -> ()


type ElementBuilder<'Element> = delegate of ctx: ElementContext<'Element> * index: int -> int
