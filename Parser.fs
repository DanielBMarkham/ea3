module Parser

open System
open FParsec
open Types


let test p str =
    match run p str with
    | Success(result, _, _)   -> printfn "Success: %A" result
    | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg

let n:Parser<string,string> = pstring "dog"

let markdownListIndicator = pstring " - "

let getTokenLeadingLine:Parser<string,unit> =
  let restOfLine=manyCharsTill anyChar (skipNewline <|> eof)
  markdownListIndicator .>> restOfLine

let getLineNotAMarkdownList:Parser<string,unit> =
  manyCharsTill anyChar (skipNewline <|> eof)