module parse

open System.IO

let parse_file path =
    let lines = File.ReadLines path
    let ls1, ls2 =
        lines
        |> Seq.map (fun l -> l.Split "   ")
        |> Seq.fold (fun (l1, l2) tok -> int tok[0] :: l1, int tok[1] :: l2) ([], [])
    List.rev ls1, List.rev ls2
