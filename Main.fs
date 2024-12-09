module aoc_fsharp.Main

let entries = [
    [aoc11.res; aoc12.res];
    [aoc21.res; 0]
]

[<EntryPoint>]
let main argv =
    entries
    |> Seq.iteri (fun i e -> printfn $"Day %d{i+1}:\n\t1) %d{e[0]}\n\t2) %d{e[1]}")
    0
