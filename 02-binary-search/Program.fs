open System

let rec binarySearch (array: int[]) = 
    printfn "binarySearch"
    printfn "%A" array.Length
    let slice = array.[0..(array.Length / 2 - 1)]
    Console.ReadKey();
    match slice with 
    | [||] -> printfn "Empty"
    | _ -> binarySearch slice

[<EntryPoint>]
let main argv =
    binarySearch [|0..10|]
    0 
