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

let markdownListIndicator = pstring "- "
let markdownList:Parser<string,unit> =
  let restOfLine=manyCharsTill anyChar (skipNewline <|> eof)
  markdownListIndicator .>> restOfLine
let markdownNotList:Parser<string,unit> =
  manyCharsTill anyChar (skipNewline <|> eof)

let markdownSelect=many (markdownList <|> markdownNotList)
type MarkdownType =
  | Markdown of string
  | MarkdownList of string


let pcodeType =
  choice [
    markdownList |>> MarkdownList
    markdownNotList |>> Markdown
  ]




