module Tests

open System
open Xunit

let swap (array: int[]): int[] = 
    [|1|]        

[<Fact>]
let ``Swap test returns an array`` () =
    let result = swap [|1..10|]
    Assert.IsType<int[]>(result);
