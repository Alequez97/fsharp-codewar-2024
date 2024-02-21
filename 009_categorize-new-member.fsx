let categorizeMember (memberInfo: int * int) =
    match memberInfo with
    | (age, handicap) when age >= 55 && handicap > 7 -> "Senior"
    | _ -> "Open"

let OpenOrSenior (xs : (int * int) list) : string list =
    xs |> List.map categorizeMember

// let output = OpenOrSenior input
// output |> List.iter (printfn "%s")

let input = [(18, 20); (45, 2); (61, 12); (37, 6); (21, 21); (78, 9)]
input |> List.iter (fun (age, handicap) -> printfn "Age: %d, Handicap: %d, Position: %s" age handicap (categorizeMember (age, handicap)))
