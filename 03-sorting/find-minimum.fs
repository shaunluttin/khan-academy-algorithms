module FindMinimumTests

open System
open Xunit

let indexOfMinimumValue (array: int[]): int =
    let rec find (index: int) (minIndex: int) = 
        printfn "index: %i minIndex: %i" index minIndex

        match index with
        | i when i >= array.Length -> minIndex
        | _ -> 
            let nextMinIndex = if array.[index] < array.[minIndex] then index else minIndex;
            find (index + 1) nextMinIndex
    find 0 0

[<Fact>]
let ``findMinimum returns the index of the minimum value in a subarray`` () = 
    let array = [|4; 5; 6; 7; 3; 2; 7; 4; 6; 8; 3|]
    let result = indexOfMinimumValue array
    Assert.StrictEqual(result, 5);


