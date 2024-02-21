let sumExcludingMinMax (arr : int list option) =
    match arr with
    | Some(lst) when List.length lst >= 3 ->
        let sortedList = List.sort lst
        let sumExcludingMinMax = List.sum (List.tail (List.take (List.length lst - 1) sortedList))
        sumExcludingMinMax
    | _ -> 0

let sumExcludingMinMax2 optionList =
    match optionList with
    | None | Some [] | Some [_] -> 0
    | Some x -> (List.sum x) - (List.max x) - (List.min x)

sumExcludingMinMax (Some [1;2;3;4]) |> printfn "%i"