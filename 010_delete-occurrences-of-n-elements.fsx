(*
    Given a list and a number, create a new list that contains each number of list at most N times, without reordering.
    For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
    With list [20,37,20,21] and number 1, the result would be [20,37,21].
*)

let countOccurences list element = 
    list
    |> List.filter ( fun x -> x = element)
    |> List.length

let appendIfLessThanN list element n = 
    if countOccurences list element < n then 
        list @ [element] 
    else 
        list

let deleteNth (order: int list) max_e =
    order
    |> List.fold (fun accumulator element -> appendIfLessThanN accumulator element max_e) []

printfn "%A" (deleteNth [20; 37; 20; 21] 1)