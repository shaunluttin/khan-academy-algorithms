module BinarySearch

open System
open Xunit

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

let sortedNames = [
    "erdnase"
    "ireland"
    "le paul"
    "scarne"
    "vernon"
]

[<Fact>]
let ``Binary search finds number`` () =
    let result = binarySearch [0..10] 3 
    Assert.StrictEqual(result, Some 3)

[<Fact>]
let ``Binary search finds string`` () =
    let result = binarySearch sortedNames "le paul"
    Assert.StrictEqual(result, Some 2)

[<Fact>]
let ``Binary search does not find string`` () =
    let result = binarySearch sortedNames "luttin" 
    Assert.StrictEqual(result, None)
