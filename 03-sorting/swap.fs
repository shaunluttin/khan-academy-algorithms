module SwapTests

open System
open Xunit

// todo: Ask about this on codereview.stackexchange.com. Done.
// todo: Perform this using an immutable array (i.e. a list)
let swap (array: 'a[]) (first: int) (second: int): 'a[] = 
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
