open System

let linearSearch (someList: 'a list) (target: 'a) : Option<int> = 
    let rec search index = 
        match someList.Length with 
        | l when index >= l -> None
        | _ -> 
            match someList.[index] with 
            | x when x = target -> Some index
            | y -> search (index + 1)
    search 0

[<EntryPoint>]
let main argv =
    let names = [
        "erdnase"
        "vernon"
        "le paul"
        "scarne"
        "ireland"
    ]

    linearSearch names "le paul" |> printfn "The target is at index: %A" // Some 2
    linearSearch names "luttin" |> printfn "The target is at index: %A" // <null>

    let numbers = [
        1
        3
        9
    ]

    linearSearch numbers 3 |> printfn "The target is at index %A" // 1
    linearSearch numbers 12 |> printfn "The target is at index %A" // Some <null>
    0 
