(* Auto-generated code below aims at helping you parse *)
(* the standard input according to the problem statement. *)
open System

let surfaceN = int(Console.In.ReadLine()) (* the number of points used to draw the surface of Mars. *)
for i in 0 .. surfaceN - 1 do
    (* landX: X coordinate of a surface point. (0 to 6999) *)
    (* landY: Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars. *)
    let token = (Console.In.ReadLine()).Split [|' '|]
    let landX = int(token.[0])
    let landY = int(token.[1])
    ()


(* game loop *)
while true do
    (* hSpeed: the horizontal speed (in m/s), can be negative. *)
    (* vSpeed: the vertical speed (in m/s), can be negative. *)
    (* fuel: the quantity of remaining fuel in liters. *)
    (* rotate: the rotation angle in degrees (-90 to 90). *)
    (* power: the thrust power (0 to 4). *)
    let token1 = (Console.In.ReadLine()).Split [|' '|]
    let X = int(token1.[0])
    let Y = int(token1.[1])
    let hSpeed = int(token1.[2])
    let vSpeed = int(token1.[3])
    let fuel = int(token1.[4])
    let rotate = int(token1.[5])
    let power = int(token1.[6])
    
    (* Write an action using printfn *)
    (* To debug: Console.Error.WriteLine("Debug message") *)
    
    let u = 1*Y + 1*vSpeed
    let output = 
        match u with
        | u when u > 4 -> 4
        | u when u < 0 -> 0
        | _ -> u    


    (* 2 integers: rotate power. rotate is the desired rotation angle (should be 0 for level 1), power is the desired thrust power (0 to 4). *)
    printfn "0 %i" output
    ()
