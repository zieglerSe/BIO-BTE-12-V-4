(**
---
title: Task 03
category: Tasks(english)
categoryindex: 3
index: 4
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task03 - Control Flow


## If-then-else

### Task 1.1:

Declare a function that takes a parameter `x` of type `float`. It shall return the value if `x` is greater than zero. If that is not the case, it shall return the value with the 
sign inversed.  
Hint: Multiplication

*)

(******)

(**

### Task 1.2:

Declare a function that gets three numbers as parameters. The biggest of the three numbers shall be returned as the result.  
Hint: `elif`!

*)

(******)

(**

### Task 1.3:

Declare a function that gets a year as parameter. If it is a leapyear, the result shall be `true` else `false`.
Hints:  
- If the year can be divided by four but not by 100, it is a leapyear. The year 2008 falls under this rule.  
- If the year can be divided by 100 but not by 400, it is no leapyear. 2100 will be no leapyear.  
- If the year can be divided by 400, it always is a leapyear. Because of this, the year 2000 was a leapyear.

*)

(******)

(**

## Pattern matching

### Task 2.1:

Delcare a function with the same attributes as described in Task 1.1. Spare i-then-else expressions and use pattern matching.  
Hint: Guarding Rules & Wildcard

*)

(******)

(**

### Task 2.2:

UnionCase definition `Month` is given:
```fsharp
type Month =
    | January
    | February
    | March
    | April
    | May
    | June
    | July
    | August
    | September
    | Oktober
    | November
    | December
```

as well as UnionCase definition `Season`:
```fsharp
type Season =
    | Spring
    | Summer
    | Autumn
    | Winter
```

Declare a function with parameter `m` of type `Month`. Use pattern matching to assign every month to a season.

*)

(******)

(**

### Task 2.3:

Pattern matching is very useful for deconstructing data structures. Declare a function that gets Record type `Person` (as seen in Task 2) and returns `true` if the
surname is `Mueller`.
Hint: https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/records#pattern-matching-with-records

*)

(******)

(**

## Loops

### Task 3.1:

Declare a function that gets parameter `n` of type `int`.  
The function shall print all numbers from 1 to n into the console (Hint: `printfn`). Use a for loop.

*)

(******)

(**

### Task 3.2:

Declare a function that gets parameter `n` of type `int`.  
The function shall save all numbers from 1 to n in a list.  
Hints: Sequence expressions, comprehesions  
Extra point: Only write all even numbers in a list; Hints: if-then-else, modulo.

*)

(******)

(**

### Task 3.3:

Declare a function that gets a parameter `n` of type `int` and a parameter `f` with signature `(int -> int)`.  
The function shall apply `f` onto all numbers from 1 to n and save them in a list.  
Hints: Sequence expressions, comprehensions  

*)

(******)

(**

## Rekursion

### Task 4.1:

Modify the following function (as seen in the lecture), so that it displays in the end how many steps have been overcome.
```fsharp
let rec climbStep nSteps position =
    if position = nSteps + 1 then
        printfn "Puh, done"
    else
        printfn "I should do more sports"
        climbStep nSteps (position + 1)
```

*)

(******)

(**

### Task 4.2:

Modify the following function (as seen in the lecture), so that it returns -1 if it is expected that the result will be greater than 1000.  
Hint: Use the `print` function to visualize intermediate result and to better understand the function. E.g.: `printfn "n:%i, acc':%i" n acc`.
```fsharp
let rec factorial acc n  =
    if n = 1 then
        acc 
    else
        let acc' = n * acc
        factorial acc' (n-1)

factorial 1 4
```

*)

(******)