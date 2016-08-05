open System

let GetIndexOfMax l = 
    List.findIndex (fun e -> e = List.max l) l

(* game loop *)
while true do

    let heights = [
        for i in [0..7] do 
            yield int(Console.In.ReadLine())
            ]    

    let indexOfMax = GetIndexOfMax heights

    Console.Error.WriteLine("Heights: {0} MaxIndex: {1}", heights, indexOfMax)

    printfn "%i" indexOfMax (* The number of the mountain to fire on. *)
    ()


//---------
//---------
//Spennende løsning fra CodinGame:
open System

while true do
    Seq.init 8 (fun x -> int(Console.ReadLine()))
    |> Seq.mapi (fun i v -> i, v)
    |> Seq.maxBy snd
    |> fst
    |> printfn "%d"
    ()