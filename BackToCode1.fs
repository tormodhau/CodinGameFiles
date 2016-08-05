(* Auto-generated code below aims at helping you parse *)
(* the standard input according to the problem statement. *)
open System

let opponentCount = int(Console.In.ReadLine()) (* Opponent count *)

(* game loop *)
while true do
    let gameRound = int(Console.In.ReadLine())
    (* x: Your x position *)
    (* y: Your y position *)
    (* backInTimeLeft: Remaining back in time *)
    let token = (Console.In.ReadLine()).Split [|' '|]
    let x = int(token.[0])
    let y = int(token.[1])
    let backInTimeLeft = int(token.[2])
    for i in 0 .. opponentCount - 1 do
        (* opponentX: X position of the opponent *)
        (* opponentY: Y position of the opponent *)
        (* opponentBackInTimeLeft: Remaining back in time of the opponent *)
        let token1 = (Console.In.ReadLine()).Split [|' '|]
        let opponentX = int(token1.[0])
        let opponentY = int(token1.[1])
        let opponentBackInTimeLeft = int(token1.[2])

        Console.Error.WriteLine("Back in time left: {0}", backInTimeLeft)
        Console.Error.WriteLine("Position X: {0}", x)
        Console.Error.WriteLine("Position Y: {0}", y)

        Console.Error.WriteLine("Opponent - Back in time left: {0}", opponentBackInTimeLeft)
        Console.Error.WriteLine("Opponent - Position X: {0}", opponentX)
        Console.Error.WriteLine("Opponent - Position Y: {0}", opponentY)
        ()

    for i in 0 .. 20 - 1 do
        let line = Console.In.ReadLine() (* One line of the map ('.' = free, '0' = you, otherwise the id of the opponent) *)
        ()

    
    (* Write an action using printfn *)
    (* To debug: Console.Error.WriteLine("Debug message") *)
    

    (* action: "x y" to move or "BACK rounds" to go back in time *)
    printfn "17 10"
    ()
