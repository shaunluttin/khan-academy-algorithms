module Swap

open System
open Xunit

let swap (someList: 'a list) (first: int) (second: int): 'a list = 
    List.mapi(fun i x -> 
        if (i = first) then someList.[second]
        elif (i = second) then someList.[first]
        else x
    ) someList

[<Fact>]
let ``Swap returns an array`` () =
    let result = swap [0..2] 0 1
    Assert.IsType<int list>(result);

[<Fact>]
let ``Swap switches only the values at index zero and index one`` () =
    let result = swap [0..2] 0 1
    Assert.StrictEqual(result.[0], 1);
    Assert.StrictEqual(result.[1], 0);
    Assert.StrictEqual(result.[2], 2);
