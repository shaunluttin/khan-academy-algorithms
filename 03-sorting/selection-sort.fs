module SelectionSort

open System
open Xunit

open FindMinimum
open Swap

// hack: This is ugly, and I can forgive myself, because I am learning.
let selectionSort (someList: int list): int list = 
    let rec sort (newList: int list) (index: int) = 
        if (index < someList.Length) 
        then 
            let minIndexOption = FindMinimum.findMinimumValueIndex newList.[index..]
            let minIndex = minIndexOption.Value + index
            let afterSwap = Swap.swap newList index minIndex
            sort afterSwap (index + 1)
        else newList
    sort someList 0

[<Fact>]
let ``Selection sort puts numbers in order`` () =
    let list = [22; 11; 99; 88; 9; 7; 42];
    let result = selectionSort list
    printfn "%A" result
    Assert.StrictEqual([7; 9; 11; 22; 42; 88; 99], result)
