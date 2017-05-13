open System

let binarySearch (array: int[]) (target: int) = 
    printfn "binarySearch"
    let rec search min max =
        printfn "search %i %i" min max
        match (min, max) with 
        | (min, max) when max < min -> -1 // 2.
        | _ -> 
            let guess = ((min + max) / 2); // 3. (ints rounds down by default)
            match array.[guess] with
            | value when value = target -> guess // 4.
            | value when value < target -> search (guess + 1) (max) // 5.
            | _ -> search (min) (guess - 1) // 6.
    search (0) (array.Length - 1) // 1.

[<EntryPoint>]
let main argv =
    binarySearch [|0..10|] 3 |> printfn "The target is at index %i"
    0 

// 1. Let min = 0 and max = n-1.
// 2. If max < min, then stop: target is not present in array. Return -1.
// 3. Compute guess as the average of max and min, rounded down (so that it is an integer).
// 4. If array[guess] equals target, then stop. You found it! Return guess.

// 5. If the guess was too low, that is, array[guess] < target, then set min = guess + 1.
// 6. Otherwise, the guess was too high. Set max = guess - 1.
// 7. Go back to step 2.
