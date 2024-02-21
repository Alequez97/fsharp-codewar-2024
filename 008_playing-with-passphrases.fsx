(*
    Everyone knows passphrases. One can choose passphrases from poems, songs, movies names and so on but frequently they can be guessed due to common cultural references. You can get your passphrases stronger by different means. One is the following:

    choose a text in capital letters including or not digits and non alphabetic characters,

    shift each letter by a given number but the transformed letter must be a letter (circular shift),
    replace each digit by its complement to 9,
    keep such as non alphabetic and non digit characters,
    downcase each letter in odd position, upcase each letter in even position (the first character is in position 0),
    reverse the whole result.
    Example:
    your text: "BORN IN 2015!", shift 1

    1 + 2 + 3 -> "CPSO JO 7984!"

    4 "CpSo jO 7984!"

    5 "!4897 Oj oSpC"

    With longer passphrases it's better to have a small and easy program. Would you write it?
*)

open System;

let rec findUppercaseLetterShiftedValue (shift: int) (c: char) =
    if shift = 0
        then c
        else
            if int c = 90
                then
                findUppercaseLetterShiftedValue (shift - 1) 'A'
                else 
                findUppercaseLetterShiftedValue (shift - 1) ((int c + 1) |> Convert.ToChar)

let rec findLowercaseLetterShiftedValue (shift: int) (c: char) =
    if shift = 0
        then c
        else
            if int c = 122
                then
                findLowercaseLetterShiftedValue (shift - 1) 'a'
                else 
                findLowercaseLetterShiftedValue (shift - 1) ((int c + 1) |> Convert.ToChar)

let playPass (s: string) (shift: int) : string =
    s
    |> Seq.map (fun c -> 
        match Char.IsDigit c with
        | true -> 48 + int '9' - int c |> Convert.ToChar
        | _ -> c)
    |> Seq.mapi (fun index c -> 
        match (Char.IsLetter c, index % 2) with
        | true, 0 -> c |> Char.ToUpper |> findUppercaseLetterShiftedValue shift |> Convert.ToChar
        | true, 1 -> c |> Char.ToLower |> findLowercaseLetterShiftedValue shift |> Convert.ToChar
        | _ -> c)
    |> Seq.rev
    |> String.Concat

printfn "%s" (playPass "MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015" 2) // Expected: 4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO
printfn "%s" "4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO"