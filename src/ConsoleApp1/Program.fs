open FSharpPlus.Control

type CellType =
    | Bomb
    | Num of int
    | Empty

type Cell =
    | Covered of CellType
    | UnCovered of CellType

type Board = Map<(int * int), Cell>


