(* Auto-generated code below aims at helping you parse *)
(* the standard input according to the problem statement. *)
open System

let rec intToBinary i =
    match i with
    | 0 | 1 -> string i
    | _ ->
        let bit = string (i % 2)
        (intToBinary (i / 2)) + bit


let MESSAGE = Console.In.ReadLine()

let binary = System.Text.Encoding.ASCII.GetBytes(MESSAGE) 
            |> Seq.map (fun b -> intToBinary ((int)b))
            |> Seq.concat




(* Write an action using printfn *)
(* To debug: Console.Error.WriteLine("Debug message") *)

Console.Error.WriteLine(MESSAGE)

printfn "answer"