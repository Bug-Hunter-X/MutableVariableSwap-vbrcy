# F# Mutable Variable Swapping Bug

This example demonstrates a common misconception when working with mutable variables in F#.  The `swap` function attempts to swap the values of `x` and `y`, but due to F#'s scoping rules, it fails to modify the original variables outside the function's scope.

## Bug

The provided `bug.fs` file contains the erroneous code. The `swap` function appears to swap the values, but the printed result shows that the original variables remain unchanged.

## Solution

The `bugSolution.fs` file shows the corrected approach using tuples or a more idiomatic F# approach.

## How to run the code:

1. Save the code as `bug.fs` and `bugSolution.fs`
2. Compile and run using the F# compiler (fsharpc).