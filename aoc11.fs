module aoc11

open parse

let diffs l1 l2 =
    List.zip (List.sort l1) (List.sort l2)
    |> List.map (fun (e1, e2) -> abs(e1 - e2))
    |> List.fold (fun i distance -> i + distance ) 0

let res =
    match parse_file "./aoc11_in" with
    | l1, l2 -> diffs l1 l2
