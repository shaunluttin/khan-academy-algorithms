open System

let rec linearSearch (array: string[]) (target: string) (index: int) = 
    let next = array.[index]
    match next with 
    | x when x = target -> index
    | y -> linearSearch array target (index + 1)

[<EntryPoint>]
let main argv =
    linearSearch [|
        "erdnase"
        "vernon"
        "ortiz"
        "england" // 3
        "grant"
        "bernahart"
        "barker"
        "covernton"
    |] "england" 0 |> printfn "The target is at index: %A" 
    0 
