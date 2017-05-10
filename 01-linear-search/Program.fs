open System

let linearSearch (array: 'a[]) (target: 'a) : Option<int> = 
    let rec search index = 
        match array.Length with 
        | l when index >= l -> None
        | _ -> 
            match array.[index] with 
            | x when x = target -> Some index
            | y -> search (index + 1)
    search 0

[<EntryPoint>]
let main argv =
    let names = [|
        "erdnase"
        "vernon"
        "le paul"
        "scarne"
        "ireland"
    |]
    linearSearch names "le paul" |> printfn "The target is at index: %A" 
    linearSearch names "luttin" |> printfn "The target is at index: %A" 

    let numbers = [|
        1
        3
        9
    |]
    linearSearch numbers 3 |> printfn "The target is at index %A"
    linearSearch numbers 12 |> printfn "The target is at index %A"
    0 
