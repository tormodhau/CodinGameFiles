open System


if int(Console.In.ReadLine()) = 0 
    then 
        printfn "0" // No values are preset
    else
    
        let temps =                                         
            Console.In.ReadLine().Split ' ' 
                |> Seq.ofArray
                |> Seq.map Int32.Parse

        match temps with 
            | t when Seq.max t < 0 -> printfn "%i" (Seq.max t)       // All negative? Fin max value
            | _ -> temps                                             // Else find minimum of absolute value
                |> Seq.map abs 
                |> Seq.min 
                |> printfn "%i"