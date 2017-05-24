module FindMinimumTests

open System
open Xunit

let findMinimumValueIndex (array: int list): int Option =
    let rec find (index: int) (minimumValueIndex: int): int Option = 
        let findNext = find (index + 1)
        match index with 
        | i when i >= array.Length -> Some minimumValueIndex // base case
        | i when array.[i] < array.[minimumValueIndex] -> findNext i
        | _ -> findNext minimumValueIndex
    find 0 0

[<Fact>]
let ``findMinimum returns the index of the minimum value in an array`` () = 
    let array = [4; 5; 6; 7; 3; 2; 7; 4; 6; 8; 3]
    let result = findMinimumValueIndex array
    Assert.StrictEqual(result, Some 5);


