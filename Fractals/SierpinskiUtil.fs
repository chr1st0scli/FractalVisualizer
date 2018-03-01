namespace Fractals

open System
open Sierpinski

module SierpinskiUtil =

    // Converts a triangle's Cartesian to screen coordinates, so that it can be easily drawn.
    let CartToScrCoords (tri: Triangle) scrSize =
        {
            p1 = {x = tri.p1.x; y = scrSize - tri.p1.y}
            p2 = {x = tri.p2.x; y = scrSize - tri.p2.y}
            p3 = {x = tri.p3.x; y = scrSize - tri.p3.y}           
        }

    // Gets the optimal side length for an isosceles triangle based on the
    // drawing area's width and height and a desired empty space serving as a frame.
    let GetTriangleOptimalSide canvasWidth canvasHeight gap = 
        let x = int (canvasWidth - 2.0 * gap)
        let y = int (Math.Round ((2.0 * canvasHeight - 4.0 * gap) / Math.Sqrt 3.0))
        Math.Min (x, y)