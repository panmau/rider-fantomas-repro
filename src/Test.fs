module App.Test

let x =
    [ "Item"; "Item"; "Item" ]
    |> List.mapi
        (fun i x ->
            let index = i + 1
            sprintf "%s: %i" x index)
