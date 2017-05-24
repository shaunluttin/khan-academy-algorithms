module LinearSearch

open System
open Xunit

let linearSearch (someList: 'a list) (target: 'a) : Option<int> = 
    let rec search index = 
        match someList.Length with 
        | l when index >= l -> None
        | _ -> 
            match someList.[index] with 
            | x when x = target -> Some index
            | y -> search (index + 1)
    search 0

let names = [
    "erdnase"
    "vernon"
    "le paul"
    "scarne"
    "ireland"
]

let numbers = [
    1
    3
    9
]

[<Fact>]
let ``Finds string in list of strings`` () =
    let result = linearSearch names "le paul" 
    Assert.StrictEqual(result, Some 2)

[<Fact>]
let ``Does not find string in list of strings`` () =
    let result = linearSearch names "luttin" 
    Assert.StrictEqual(result, None)

[<Fact>]
let ``Finds int in list of ints`` () =
    let result = linearSearch numbers 3 
    Assert.StrictEqual(result, Some 1)

[<Fact>]
let ``Does not find int in list of ints`` () =
    let result = linearSearch numbers 12 
    Assert.StrictEqual(result, None)
