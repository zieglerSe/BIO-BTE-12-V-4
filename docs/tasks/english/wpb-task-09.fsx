(**
---
title: Task 09
category: Tasks(english)
categoryindex: 3
index: 10
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task09 - Data access

## 0 Preface

The following documentation may be helpful in completing the tasks:

* Deedle: https://fslab.org/Deedle

### Referencing Plotly.NET, Deedle and FSharp.Stats

These lines always have to be executed once, otherwise you can not use the library:
*)

#r "nuget: Deedle, 2.3.0"
open Deedle

(**
### Working with Deedle

Should you see this error message:
```
9_Data_exploration_using_FSharp.fsx(113,5): error FS0030: Value restriction. The value 'cpw'' has been inferred to have generic type val cpw' : Series<(string * int),'_a>      
Either define 'cpw'' as a simple data term, make it a function with explicit arguments or, if you do not intend for it to be generic, add a type annotation.
```
Then you should resort to an explicit type annotation.
Instead of:
```
let cpw' = persons |> Frame.getCol "cpw"
```
You should use:
```
let cpw' :Series<int,float> = persons |> Frame.getCol "cpw"
```
To display deedle objects in this notebook you can use the `.Print()` member:
*)

let firstNames' = Series.ofValues ["Kevin";"Lukas";"Benedikt";"Michael"]
firstNames'.Print()

(**
## 1 Basics

### Task 1.1

Given are 4 series of equal length. Use the function `Series.mapValues` to double the values of "coffeesPerWeek".
*)

let firstNames      = Series.ofValues ["Kevin";"Lukas";"Benedikt";"Michael"] 
let coffeesPerWeek  = Series.ofValues [15;12;10;11] 
let lastNames       = Series.ofValues ["Schneider";"Weil";"Venn";"Schroda"]  
let group           = Series.ofValues ["CSB";"CSB";"CSB";"MBS"]

(**
### Task 1.2

Create a frame named "persons" based on the 4 given Series.
*)

(******)

(**
### Task 1.3

Add a column named "sodasPerWeek" to the frame. Bind the resulting frame to a name.

Tip: Create a `Series<int,int>` first. Use `Frame.addCol`
*)

(******)

(**
### Task 1.4

Add the columns "sodasPerWeek" and "coffeesPerWeek". Add the resulting series as a column with the title "allPurchases" to the previously created frame.

Tip 1: This task can be solved in several ways.

Tip 2: Via `Series.values` you can access the values of each Series. Then you could iterate over both collections with `Seq.map2`. 
*)

(******)

(**
### Task 1.5

Determine the sum of "allPurchases".
*)

(******)

(**
## 2 Frame Operationen

### Task 2.1

Group the rows of the frame from Task 1.2 according to the elements of the "group" column.

Tip: Explicit type annotation (see: [Working with Deedle](#Working-with-Deedle)). 
*)

(******)

(**
### Task 2.2

Results tables often contain more than 40 columns. However, only a few are interesting for individual analysis. 
It is therefore often useful to create a frame that contains fewer columns. Use the function `Frame.sliceCols` to create a frame on the base of the 
frame from Task 1.2 to create a frame that contains only the columns "lastNames" and "coffeesPerWeek".
*)

(******)

(**
### Task 2.3

Many times you want to aggregate based on groupings. Calculate the sum of the "coffeePerWeek" column for each group.

Tip: Extract the "coffeePerWeek" column from the result of Task 2.1. Proceed as demonstrated in the lecture. 
*)

(******)

(**
### Task 2.4

Often you want to save intermediate results. Save the frame from task 1.2 as a CSV file. Use ';' as separator.
*)

(******)

(**
### Task 2.5

Use the function 'Frame.ReadCsv' to read the file again.
*)

(******)