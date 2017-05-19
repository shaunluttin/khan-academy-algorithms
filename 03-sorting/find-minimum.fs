module FindMinimumTests

open System
open Xunit

// todo use recursion to implement this without mutation.
let findMinimum (array: int[]): int =
    0

[<Fact>]
let ``findMinimum returns the index of the minimum value in a subarray`` () = 
    let array = [|4; 5; 6; 7; 3; 2; 7; 4; 6; 8; 3|]
    let result = findMinimum array
    Assert.StrictEqual(result, 5);


