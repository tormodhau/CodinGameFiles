(* Auto-generated code below aims at helping you parse *)
(* the standard input according to the problem statement. *)
open System

let road = int(Console.In.ReadLine()) (* the length of the road before the gap. *)
let gap = int(Console.In.ReadLine()) (* the length of the gap. *)
let platform = int(Console.In.ReadLine()) (* the length of the landing platform. *)

(* game loop *)
while true do
    let speed = int(Console.In.ReadLine()) (* the motorbike's speed. *)
    let coordX = int(Console.In.ReadLine()) (* the position on the road of the motorbike. *)
    
    let action =
        match (speed, coordX) with
        | (s, x) when x >= road + gap  -> "SLOW"
        | (s, x) when s > gap+1 -> "SLOW"
        | (s, x) when s < gap+1 -> "SPEED"
        | (s, x) when road - x = 1 -> "JUMP"
        | _ -> "WAIT"

    printfn "%s" action
    ()