open System

let rec linearSearch (array: string[]) (target: string) (index: int) = 
    match array.Length with 
    | l when index >= l -> -1
    | _ -> 
        match array.[index] with 
        | x when x = target -> index
        | y -> linearSearch array target (index + 1)

[<EntryPoint>]
let main argv =
    let names = [|
        "erdnase"
        "vernon"
        "le paul"
        "scarne"
        "ireland"
    |]
    linearSearch names "le paul" 0 |> printfn "The target is at index: %A" 
    linearSearch names "luttin" 0 |> printfn "The target is at index: %A" 
    0 
