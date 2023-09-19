open Canvas
open Color
open System 

type vec = float * float

let add ((x1, y1) : vec) ((x2, y2) : vec) : vec = 
    (x1 + x2, y1+ y2)

let mul ((x, y) : vec) (c : float) : vec = 
    ( c * x, c * y)

let rot ((x, y) : vec) (a : float) : vec = 
    ((x * cos (a) - y * sin(a)), (x * sin(a) + y * cos(a)))

printfn "%A" (rot (1.0, 1.0) System.Math.PI)
