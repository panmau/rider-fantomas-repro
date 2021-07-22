# Rider and Fantomas Repro

## Reproduction
1. Ctrl+Alt+L in Rider
2. Inspect changes in git

The changes are inconsistent to the formatting of Fantomas.  
Rider doesn't seem to respect the setting `fsharp_multi_line_lambda_closing_newline=true`.

## Difference
Fantomas:
```fsharp
let x =
    [ "Item"; "Item"; "Item" ]
    |> List.mapi (fun i x ->
        let index = i + 1
        sprintf "%s: %i" x index
    )
```

Rider:
```fsharp
let x =
    [ "Item"; "Item"; "Item" ]
    |> List.mapi
        (fun i x ->
            let index = i + 1
            sprintf "%s: %i" x index)
```

## Environment
- Rider version: Rider 2021.2 EAP 8
- Fantomas CLI: 4.5.0
- OS: Manjaro Linux 21.1.0 Pahvo