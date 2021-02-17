
open System
open FParsec
open Tests

let n:Parser<string,string> = pstring "dog"



let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#"
    printfn "Hello world %s" message
    0