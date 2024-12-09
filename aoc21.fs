module aoc21

open System.IO

let is_safe (line: string) =
    let diffs =
        line.Split " "
        |> Seq.map int
        |> Seq.pairwise
        |> Seq.fold (fun acc (f, s) -> f-s :: acc) []
        |> List.rev
    
    let same_signedness list =
        List.forall (fun e -> e > 0) list ||
        List.forall (fun e -> e < 0) list
    
    let bounded_diff list =
        list
        |> List.map abs
        |> List.forall (fun e -> e = 1 || e = 2)

    same_signedness diffs && bounded_diff diffs

let res =
    File.ReadLines "./aoc21_in"
    |> Seq.map is_safe
    |> Seq.fold (fun acc e -> if e then acc + 1 else acc) 0
    