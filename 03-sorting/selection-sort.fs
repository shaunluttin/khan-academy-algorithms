module SelectionSort

open System
open Xunit

let selectionSort (someList: int list): int list = 
    someList

[<Fact>]
let ``Selection sort puts numbers in order`` () =
    let list = [22; 11; 99; 88; 9; 7; 42];
    let result = selectionSort list
    Assert.StrictEqual(result, [7; 9; 11; 22; 42; 88; 99])
