module Tests

open System
open Xunit

let swap (array: int[]) (first: int) (second: int): int[] = 
    let originalFirst = array.[first]
    array.[first] <- array.[second];
    array.[second] <- originalFirst;
    array

[<Fact>]
let ``Swap returns an array`` () =
    let result = swap [|0..2|] 0 1
    Assert.IsType<int[]>(result);

[<Fact>]
let ``Swap switches only the values at index zero and index one`` () =
    let result = swap [|0..2|] 0 1
    Assert.StrictEqual(result.[0], 1);
    Assert.StrictEqual(result.[1], 0);
    Assert.StrictEqual(result.[2], 2);
