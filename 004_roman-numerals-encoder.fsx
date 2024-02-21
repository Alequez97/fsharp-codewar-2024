(*
    Create a function taking a positive integer between 1 and 3999 (both included) as its parameter and returning a string containing the Roman Numeral representation of that integer.

    Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

    Example:

    solution(1000); // should return 'M'
    Help:

    Symbol    Value
    I          1
    V          5
    X          10
    L          50
    C          100
    D          500
    M          1,000
    Remember that there can't be more than 3 identical symbols in a row.

    More about roman numerals - http://en.wikipedia.org/wiki/Roman_numerals
*)

(*
    https://www.codewars.com/kata/51b62bf6a9c58071c600001b/train/fsharp
*)

open System

let intToRomanString num =
    let rec helper num result =
        match num with
        | 0 -> result
        | _ when num >= 1000 -> helper (num - 1000) (result + "M")
        | _ when num >= 900 -> helper (num - 900) (result + "CM")
        | _ when num >= 500 -> helper (num - 500) (result + "D")
        | _ when num >= 400 -> helper (num - 400) (result + "CD")
        | _ when num >= 100 -> helper (num - 100) (result + "C")
        | _ when num >= 90 -> helper (num - 90) (result + "XC")
        | _ when num >= 50 -> helper (num - 50) (result + "L")
        | _ when num >= 40 -> helper (num - 40) (result + "XL")
        | _ when num >= 10 -> helper (num - 10) (result + "X")
        | _ when num >= 9 -> helper (num - 9) (result + "IX")
        | _ when num >= 5 -> helper (num - 5) (result + "V")
        | _ when num >= 4 -> helper (num - 4) (result + "IV")
        | _ -> helper (num - 1) (result + "I")

    helper num ""
    
let solution(num: int): String =
    intToRomanString num

printfn "%s" (solution 3724)
