namespace Fractals

open System
open System.Numerics

module Divergent =

    let internal diverges (z: Complex) (c: Complex) maxItr =
        let rec dvrg (z: Complex) (c: Complex) maxItr itr =
            if Complex.Abs z >= 2.0 then itr    //diverges
            elif itr >= maxItr then 0           //converges
            else dvrg (z * z + c) c maxItr (itr + 1)
        dvrg z c maxItr 0

    let internal pointRes width height f =
        // Meant to return a list of points and how much each diverges from a certain set.
        // E.g. [[(2, 3, 0) ...] means that point x=2, y=3 doesn't diverge (0) from the set.
        seq {
            for x in 0..width - 1 do
            for y in 0..height - 1 do
            yield (x, y)
        }
        |> Seq.map (fun el -> (fst el), (snd el), f (fst el) (snd el))

    let internal commonScale width height =
        Math.Round (4.0 / Math.Min (float width, float height), 2)

    let internal pointToComplex x y width height scale =
        let w, h = width / 2, height / 2
        Complex(float (x - w) * scale, float (y - h) * scale)

    let Mandelbrot width height maxItr scale =
        pointRes width height (fun x y -> diverges (Complex (0.0, 0.0)) (pointToComplex x y width height scale) maxItr)
    let MandelbrotEasy width height =
        Mandelbrot width height 255 (commonScale width height)

    let Julia width height c maxItr scale =
        pointRes width height (fun x y -> diverges (pointToComplex x y width height scale) c maxItr)
    let JuliaEasy width height c =
        Julia width height c 255 (commonScale width height)

    let SanMarco width height = JuliaEasy width height (Complex (-0.75, 0.0))
    let SiegelDisk width height = JuliaEasy width height (Complex (-0.391, -0.587))
    let DouadyRabbit width height = JuliaEasy width height (Complex (-0.123, 0.745))
    let JuliaVar1 width height = JuliaEasy width height (Complex (-0.835, -0.2321))
    let JuliaVar2 width height = JuliaEasy width height (Complex (-0.70176, -0.3842))