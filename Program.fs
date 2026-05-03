// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

open myLib.myModule

let x = fog 2
let y = gof 2

printfn "gof of 2 %s" (string y)
printfn "fog of 2 %s" (string x)
