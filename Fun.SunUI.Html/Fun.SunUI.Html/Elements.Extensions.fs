[<AutoOpen>]
module Fun.SunUI.Html.ElementsExtensions

open Browser.Dom
open Browser.Types
open Fun.SunUI
open Fun.SunUI.Html.DslInternals


//let eles = [ "Div"; "Anchor"; "Area"; "Audio"; "BR"; "Base"; "Block"; "Body"; "Button"; "Canvas"; "DD"; "DList"; "DT"; "DataList"; "Directory"; "Embed"; "FieldSet"; "Font"; "Form"; "Frame"; "Heading"; "IFrame"; "Input"; "LI"; "Label"; "Legend"; "Link"; "Map"; "Media"; "Menu"; "Meta"; "Mod"; "NextId"; "OList"; "OptGroup"; "Option"; "Paragraph"; "Param"; "Phrase"; "Pre"; "Progress"; "Quote"; "Script"; "Select"; "Source"; "Span"; "Style"; "TableCaption"; "TableCell"; "TableCol"; "TableDataCell"; "Table"; "TableHeaderCell"; "TableRow"; "TableSection"; "TextArea"; "Title"; "Track"; "UList"; "Unknown"; "Video" ]

//for ele in eles do
//    printfn $"""
//type {ele.ToLower()}() =
//    inherit HTMLElementBuilder<HTML{ele}Element>()

//    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTML{ele}Element>) =
//        this.MakeElementCreator(builder, (fun _ -> document.createElement "{ele.ToLower()}" :?> HTML{ele}Element), this.GetRenderMode())
//    """


type div() =
    inherit HTMLElementBuilder<HTMLDivElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLDivElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "div" :?> HTMLDivElement), this.GetRenderMode())


type anchor() =
    inherit HTMLElementBuilder<HTMLAnchorElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLAnchorElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "anchor" :?> HTMLAnchorElement), this.GetRenderMode())


type area() =
    inherit HTMLElementBuilder<HTMLAreaElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLAreaElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "area" :?> HTMLAreaElement), this.GetRenderMode())


type audio() =
    inherit HTMLElementBuilder<HTMLAudioElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLAudioElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "audio" :?> HTMLAudioElement), this.GetRenderMode())


type bre() =
    inherit HTMLElementBuilder<HTMLBRElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLBRElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "bre" :?> HTMLBRElement), this.GetRenderMode())


type base'() =
    inherit HTMLElementBuilder<HTMLBaseElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLBaseElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "base" :?> HTMLBaseElement), this.GetRenderMode())


type block() =
    inherit HTMLElementBuilder<HTMLBlockElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLBlockElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "block" :?> HTMLBlockElement), this.GetRenderMode())


type body() =
    inherit HTMLElementBuilder<HTMLBodyElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLBodyElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "body" :?> HTMLBodyElement), this.GetRenderMode())


type button() =
    inherit HTMLElementBuilder<HTMLButtonElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLButtonElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "button" :?> HTMLButtonElement), this.GetRenderMode())


type canvas() =
    inherit HTMLElementBuilder<HTMLCanvasElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLCanvasElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "canvas" :?> HTMLCanvasElement), this.GetRenderMode())


type dd() =
    inherit HTMLElementBuilder<HTMLDDElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLDDElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "dd" :?> HTMLDDElement), this.GetRenderMode())


type dlist() =
    inherit HTMLElementBuilder<HTMLDListElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLDListElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "dlist" :?> HTMLDListElement), this.GetRenderMode())


type dte() =
    inherit HTMLElementBuilder<HTMLDTElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLDTElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "dt" :?> HTMLDTElement), this.GetRenderMode())


type datalist() =
    inherit HTMLElementBuilder<HTMLDataListElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLDataListElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "datalist" :?> HTMLDataListElement), this.GetRenderMode())


type directory() =
    inherit HTMLElementBuilder<HTMLDirectoryElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLDirectoryElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "directory" :?> HTMLDirectoryElement), this.GetRenderMode())


type embed() =
    inherit HTMLElementBuilder<HTMLEmbedElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLEmbedElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "embed" :?> HTMLEmbedElement), this.GetRenderMode())


type fieldset() =
    inherit HTMLElementBuilder<HTMLFieldSetElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLFieldSetElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "fieldset" :?> HTMLFieldSetElement), this.GetRenderMode())


type font() =
    inherit HTMLElementBuilder<HTMLFontElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLFontElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "font" :?> HTMLFontElement), this.GetRenderMode())


type form() =
    inherit HTMLElementBuilder<HTMLFormElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLFormElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "form" :?> HTMLFormElement), this.GetRenderMode())


type frame() =
    inherit HTMLElementBuilder<HTMLFrameElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLFrameElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "frame" :?> HTMLFrameElement), this.GetRenderMode())


type heading() =
    inherit HTMLElementBuilder<HTMLHeadingElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLHeadingElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "heading" :?> HTMLHeadingElement), this.GetRenderMode())


type iframe() =
    inherit HTMLElementBuilder<HTMLIFrameElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLIFrameElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "iframe" :?> HTMLIFrameElement), this.GetRenderMode())


type input() =
    inherit HTMLElementBuilder<HTMLInputElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLInputElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "input" :?> HTMLInputElement), this.GetRenderMode())


type li() =
    inherit HTMLElementBuilder<HTMLLIElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLLIElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "li" :?> HTMLLIElement), this.GetRenderMode())


type label() =
    inherit HTMLElementBuilder<HTMLLabelElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLLabelElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "label" :?> HTMLLabelElement), this.GetRenderMode())


type legend() =
    inherit HTMLElementBuilder<HTMLLegendElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLLegendElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "legend" :?> HTMLLegendElement), this.GetRenderMode())


type link() =
    inherit HTMLElementBuilder<HTMLLinkElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLLinkElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "link" :?> HTMLLinkElement), this.GetRenderMode())


type map() =
    inherit HTMLElementBuilder<HTMLMapElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLMapElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "map" :?> HTMLMapElement), this.GetRenderMode())


type media() =
    inherit HTMLElementBuilder<HTMLMediaElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLMediaElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "media" :?> HTMLMediaElement), this.GetRenderMode())


type menu() =
    inherit HTMLElementBuilder<HTMLMenuElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLMenuElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "menu" :?> HTMLMenuElement), this.GetRenderMode())


type meta() =
    inherit HTMLElementBuilder<HTMLMetaElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLMetaElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "meta" :?> HTMLMetaElement), this.GetRenderMode())


type mod'() =
    inherit HTMLElementBuilder<HTMLModElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLModElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "mod" :?> HTMLModElement), this.GetRenderMode())


type nextid() =
    inherit HTMLElementBuilder<HTMLNextIdElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLNextIdElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "nextid" :?> HTMLNextIdElement), this.GetRenderMode())


type olist() =
    inherit HTMLElementBuilder<HTMLOListElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLOListElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "olist" :?> HTMLOListElement), this.GetRenderMode())


type optgroup() =
    inherit HTMLElementBuilder<HTMLOptGroupElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLOptGroupElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "optgroup" :?> HTMLOptGroupElement), this.GetRenderMode())


type option() =
    inherit HTMLElementBuilder<HTMLOptionElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLOptionElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "option" :?> HTMLOptionElement), this.GetRenderMode())


type paragraph() =
    inherit HTMLElementBuilder<HTMLParagraphElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLParagraphElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "paragraph" :?> HTMLParagraphElement), this.GetRenderMode())


type param() =
    inherit HTMLElementBuilder<HTMLParamElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLParamElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "param" :?> HTMLParamElement), this.GetRenderMode())


type phrase() =
    inherit HTMLElementBuilder<HTMLPhraseElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLPhraseElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "phrase" :?> HTMLPhraseElement), this.GetRenderMode())


type pre() =
    inherit HTMLElementBuilder<HTMLPreElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLPreElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "pre" :?> HTMLPreElement), this.GetRenderMode())


type progress() =
    inherit HTMLElementBuilder<HTMLProgressElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLProgressElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "progress" :?> HTMLProgressElement), this.GetRenderMode())


type quote() =
    inherit HTMLElementBuilder<HTMLQuoteElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLQuoteElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "quote" :?> HTMLQuoteElement), this.GetRenderMode())


type script() =
    inherit HTMLElementBuilder<HTMLScriptElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLScriptElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "script" :?> HTMLScriptElement), this.GetRenderMode())


type select() =
    inherit HTMLElementBuilder<HTMLSelectElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLSelectElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "select" :?> HTMLSelectElement), this.GetRenderMode())


type source() =
    inherit HTMLElementBuilder<HTMLSourceElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLSourceElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "source" :?> HTMLSourceElement), this.GetRenderMode())


type span() =
    inherit HTMLElementBuilder<HTMLSpanElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLSpanElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "span" :?> HTMLSpanElement), this.GetRenderMode())


type style() =
    inherit HTMLElementBuilder<HTMLStyleElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLStyleElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "style" :?> HTMLStyleElement), this.GetRenderMode())


type tablecaption() =
    inherit HTMLElementBuilder<HTMLTableCaptionElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableCaptionElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tablecaption" :?> HTMLTableCaptionElement), this.GetRenderMode())


type tablecell() =
    inherit HTMLElementBuilder<HTMLTableCellElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableCellElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tablecell" :?> HTMLTableCellElement), this.GetRenderMode())


type tablecol() =
    inherit HTMLElementBuilder<HTMLTableColElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableColElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tablecol" :?> HTMLTableColElement), this.GetRenderMode())


type tabledatacell() =
    inherit HTMLElementBuilder<HTMLTableDataCellElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableDataCellElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tabledatacell" :?> HTMLTableDataCellElement), this.GetRenderMode())


type table() =
    inherit HTMLElementBuilder<HTMLTableElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "table" :?> HTMLTableElement), this.GetRenderMode())


type tableheadercell() =
    inherit HTMLElementBuilder<HTMLTableHeaderCellElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableHeaderCellElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tableheadercell" :?> HTMLTableHeaderCellElement), this.GetRenderMode())


type tablerow() =
    inherit HTMLElementBuilder<HTMLTableRowElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableRowElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tablerow" :?> HTMLTableRowElement), this.GetRenderMode())


type tablesection() =
    inherit HTMLElementBuilder<HTMLTableSectionElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTableSectionElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "tablesection" :?> HTMLTableSectionElement), this.GetRenderMode())


type textarea() =
    inherit HTMLElementBuilder<HTMLTextAreaElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTextAreaElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "textarea" :?> HTMLTextAreaElement), this.GetRenderMode())


type title() =
    inherit HTMLElementBuilder<HTMLTitleElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTitleElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "title" :?> HTMLTitleElement), this.GetRenderMode())


type track() =
    inherit HTMLElementBuilder<HTMLTrackElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLTrackElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "track" :?> HTMLTrackElement), this.GetRenderMode())


type ulist() =
    inherit HTMLElementBuilder<HTMLUListElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLUListElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "ulist" :?> HTMLUListElement), this.GetRenderMode())


type unknown() =
    inherit HTMLElementBuilder<HTMLUnknownElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLUnknownElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "unknown" :?> HTMLUnknownElement), this.GetRenderMode())


type video() =
    inherit HTMLElementBuilder<HTMLVideoElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLVideoElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "video" :?> HTMLVideoElement), this.GetRenderMode())


type p() =
    inherit paragraph()


type h1() =
    inherit HTMLElementBuilder<HTMLElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "h1"), this.GetRenderMode())

type h2() =
    inherit HTMLElementBuilder<HTMLElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "h2"), this.GetRenderMode())

type h3() =
    inherit HTMLElementBuilder<HTMLElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "h3"), this.GetRenderMode())

type h4() =
    inherit HTMLElementBuilder<HTMLElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "h4"), this.GetRenderMode())

type h5() =
    inherit HTMLElementBuilder<HTMLElement>()

    member inline this.Run([<InlineIfLambda>] builder: BuildElement<HTMLElement>) =
        this.MakeElementCreator(builder, (fun _ -> document.createElement "h5"), this.GetRenderMode())
