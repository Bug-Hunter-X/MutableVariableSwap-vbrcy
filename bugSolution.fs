let x, y = 10, 20

let swap (x, y) =
    y, x

let x', y' = swap (x, y)
printf "%d %d" x' y'