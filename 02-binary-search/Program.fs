open System

let binarySearch (array: 'a list) (target: 'a): int Option =
    let rec search min max: int Option =
        match (min, max) with 
        | (min, max) when max < min -> None 
        | _ -> 
            let guess = ((min + max) / 2);
            match array.[guess] with
            | x when x > target -> search (min) (guess - 1)
            | x when x < target -> search (guess + 1) (max) 
            | _ -> Some guess
    search (0) (array.Length - 1) 

[<EntryPoint>]
let main argv =

    binarySearch [0..10] 3 |> printfn "The target is at index %A" // Some 3

    let sortedNames = [
        "erdnase"
        "ireland"
        "le paul"
        "scarne"
        "vernon"
    ]

    binarySearch sortedNames "le paul" |> printfn "The target is at index: %A"  // Some 2
    binarySearch sortedNames "luttin" |> printfn "The target is at index: %A" // <null>

    0 

// 1. Let min = 0 and max = n-1.
// 2. If max < min, then stop: target is not present in array. Return -1.
// 3. Compute guess as the average of max and min, rounded down (so that it is an integer).
// 4. If array[guess] equals target, then stop. You found it! Return guess.
// 5. If the guess was too low, that is, array[guess] < target, then set min = guess + 1.
// 6. Otherwise, the guess was too high. Set max = guess - 1.
// 7. Go back to step 2.
