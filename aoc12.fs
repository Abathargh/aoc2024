module aoc12

open parse

let similarity i l =
    let count =
        l
        |> List.filter (fun e -> e = i)
        |> List.length 
    count * i
    
let sums l1 l2 =
    l1
    |> Seq.map (fun e -> similarity e l2)
    |> Seq.sum

let res =
    match parse_file "./aoc12_in" with
    | l1, l2 -> sums l1 l2
