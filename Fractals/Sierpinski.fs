namespace Fractals

open System

module Sierpinski =
    //A point in the Cartesian system on the positive side of axises.
    type CartPoint = {x: int; y: int}

    //A triangle whose p1 and p2 vertexes have the same y's and p2's x is greater than p1's.
    type Triangle = {p1: CartPoint; p2: CartPoint; p3: CartPoint}

    let internal isUpsideDown (tri: Triangle) = tri.p3.y < tri.p1.y

    //Get vertex of same (level 1) or inner (level 2) triangle based on Pythagorean properties.
    let internal getVertex p1 side level upDown =
        let xOffset = int (Math.Round (side / Math.Pow(2.0, level)))
        let yOffset = int (Math.Round (side * Math.Pow(2.0, level) * Math.Sqrt(3.0) / Math.Pow(2.0, 2.0 * level)))
        {x = p1.x + xOffset; y = p1.y + if upDown then -yOffset else yOffset}

    let internal isoscelesTri p1 side upDown =
        {
            p1 = p1
            p2 = {x = p1.x + side; y = p1.y}
            p3 = getVertex p1 (float side) 1.0 upDown
        }

    let internal splitTri (tri: Triangle) =
        let side = tri.p2.x - tri.p1.x
        let upDown = isUpsideDown tri
        let newTri = 
            isoscelesTri 
                (getVertex tri.p1 (float side) 2.0 upDown)
                (int (Math.Round (float side / 2.0))) 
                (not upDown)
        seq [
            {p1 = newTri.p1; p2 = newTri.p2; p3 = tri.p3}
            {p1 = tri.p1; p2 = newTri.p3; p3 = newTri.p1}
            {p1 = newTri.p3; p2 = tri.p2; p3 = newTri.p2}
            newTri
        ]

    let SierpinskiTriangle vertex sideLength depth =
        // Splits a tree only if it's upside. In the end, returns just the upsidedown trees.
        // These and the first upside are adequate for the Sierpinski triangle to be drawn.
        let rec split depth tris =
            if depth <= 0 then
                tris |> Seq.filter isUpsideDown
            else
                split (depth - 1)
                    (tris |> Seq.map (fun t -> if isUpsideDown t then seq [t] else splitTri t) |> Seq.concat)
            
        let outterTri = isoscelesTri vertex sideLength false
        Seq.append [outterTri] (split depth [outterTri])