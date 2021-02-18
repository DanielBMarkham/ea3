module Parser

open System
open FParsec
//open Types


let test p str =
    match run p str with
    | Success(result, _, _)   -> printfn "Success: %A" result
    | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg

let n:Parser<string,string> = pstring "dog"




let pword s = pstring s .>> spaces
let parens p = between (pword "(") (pword ")") p

type MarkdownType =
  | Markdown of string
  | MarkdownList of string
  | MarkdownEmptyLine of unit


let markdownListIndicator = pstring "- "
let markdownList:Parser<MarkdownType,unit> =
  let restOfLine=manyCharsTill anyChar (skipNewline <|> eof)
  markdownListIndicator >>. restOfLine |>> MarkdownList

let markdownNotList:Parser<MarkdownType,unit> =
  many1CharsTill anyChar (skipNewline <|> eof) |>> Markdown
  //many1CharsTillApply
let markdownEmptyLine:Parser<MarkdownType,unit> =
  skipNewline |>> MarkdownEmptyLine


let pcodeType =
  choice [
  markdownEmptyLine
  markdownList
  markdownNotList
  ]
let manyContainedMarkdownLines  =
  many pcodeType


type NoteType=
  | Note of MarkdownType list
  | Question of MarkdownType list
  | ToDo of MarkdownType list
  | Work of MarkdownType list

