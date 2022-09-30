namespace Fun.Modern.Forms

open System


type InjectviewContext = {
    ServiceProvider: IServiceProvider
    AddDispose: IDisposable -> unit
}

type ElementInjectviewContext(creatorFn: InjectviewContext -> ElementCreator, sp: IServiceProvider) =
    let disposes = ResizeArray<IDisposable>()

    let creator =
        creatorFn
            {
                ServiceProvider = sp
                AddDispose = fun d -> disposes.Add(d)
            }

    let mutable k = creator.Key
    let ctx = creator.CreateOrUpdate(sp, ValueNone)

    member _.Update() = creator.CreateOrUpdate(sp, ValueSome ctx)


    interface IElementContext with
        member _.Key
            with get () = k
            and set x = k <- x

        member _.NativeElement = ctx.NativeElement
        member _.ServiceProvider = sp

        member _.Dispose() =
            for item in disposes do
                item.Dispose()
            ctx.Dispose()
