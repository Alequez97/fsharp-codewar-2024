let sumTwoSmallestNumbers = Array.sort >> Array.take 2 >> Array.sum
let input = [|5;20;100;500;1|]
sumTwoSmallestNumbers input |> printfn "%i"