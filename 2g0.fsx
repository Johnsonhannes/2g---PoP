open Canvas
open Color
open System 

type vec = float * float

///<summary> add tager 2 vektorer ind og adderer dem (lægger begge koordinater sammen) </summary>
///<param> tager 2 vec </param>
///<returns> vec som er summen af de 2 vektorer </returns>

let add ((x1, y1) : vec) ((x2, y2) : vec) : vec = 
    (x1 + x2, y1+ y2)

///<summary>  mul skalerer en vektor med skalaren c </summary>
///<param> (x,y) : vec </param>
///<param> c: float </param>
///<returns> (x,y)-vektoren skaleret med c </returns>

let mul ((x, y) : vec) (c : float) : vec = 
    ( c * x, c * y)

///<summary> rot tager en vektor og roterer den med a radianer mod uret </summary>
///<param> (x,y) : vec </param>
///<param> a : float </param>
///<returns> (x,y)-vektoren drejet a radianer </returns>

let rot ((x, y) : vec) (a : float) : vec = 
    ((x * cos (a) - y * sin(a)), (x * sin(a) + y * cos(a)))

printfn "%A" (rot (1.0, 1.0) System.Math.PI)
