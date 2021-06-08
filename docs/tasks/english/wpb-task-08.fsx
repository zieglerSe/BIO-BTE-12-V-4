(**
---
title: Task 08
category: Tasks(english)
categoryindex: 3
index: 9
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task04 - Programming with functions

## Dispersion measures in FSharp

### Preface

The Plotly.NET library documentation can be found at https://plotly.net.

The FSharp.Stats library documentation can be found at https://fslab.org/FSharp.Stats/.

### Referencing Plotly.NET and FSharp.Stats

These lines always have to be executed once, otherwise you can not use the referenced libraries:
*)
(******)
#r "nuget: FSharp.Stats, 0.4.1"
#r "nuget: Plotly.NET, 2.0.0-preview.1"
#r "nuget: Plotly.NET.Interactive, 2.0.0-preview.1"

open Plotly.NET
open FSharp.Stats
open Plotly.NET.StyleParam

(**
### Task 1.1

Create a normal distribution that has 3.50 as mean and 1.20 as standard deviation.
Bind this distribution to the name `myDistribution`.

*)
(******)
open FSharp.Stats.Distributions


(**
### Task 1.2

  - a) Access the `Variance` field of the previously created distribution. 
  - b) Draw a random value from the distribution.

*)
(******)

(**
### Task 1.3

Here a function is defined that takes a sample from a distribution. Understand the function and create a sample from `myDistribution` with n=15. Bind the result to `mySample`.

*)
(******)

let getSample (dist:Distributions.Distribution<float,float>) n = 
    let distribution = dist
    Array.init n (fun _ -> distribution.Sample())

(**
### Task 1.4

Erstellen Sie eine Funktion, die einen Mittelwert mean (float), eine Standardabweichung stabw (float) und eine Stichprobengroesse n (int) als Parameter bekommt. 
Aus mean und stabw soll eine Normalverteilung erstellt werden. Die Funktion soll ein float array der Laenge n als Stichprobe aus der Verteilung zurueckgeben.
Als Vorlage kann `getSample` aus 1.3 dienen. Binden Sie die Funktion an den Namen `getSampleOfGaussWith`.

Create a function that takes a mean (mean: float), a standard deviation (stdev: float) and a sample size (n: int) as parameters. 
In the functions body create a normal distribution from mean and stdev. The function should return a float array of length n as a sample from the distribution.
`getSample` from 1.3 can be used as template. Bind the function to the name `getSampleOfGaussWith`.

*)
(******)


(**
### Task 1.5

Determine the mean and variance of mySample. 

*)
(******)


(**
### Task 1.6

Below is a function that calculates the standard error from a sample. 

  - a) Create a list with the name 'semsOfSample'. The list should consist of 100 standard errors based on samples of the following distribution: 

    - mean = 6.0

    - stabw = 1.5

    - Sample size: 12 each

  - b) Create a list with the name 'stDevsOfSample', which calculates the standard deviation from samples of the same distribution.


*)
(******)

let sem (sample:float []) =
    let sd = Seq.stDev sample
    let n = float (Seq.length sample)
    sd / sqrt n



(**
### Task 1.7 (optional)

Visualise the two lists with any chart. Compare the values with the standard deviation of the original distribution (one sentence).

*)
(******)

(**
## t test with FSharp.Stats

### Task 2.1 

Create a sample with sample size n=12 from each of the distributions with the following parameters

  - a) mean=12., stabw=1.3
  
  - b) mean=14., stabw=1.3

Bind the samples to the names 'sampleA' and 'sampleB'. A vector is a type of sequence and often is used in FSharp.Stats. This is also the case with the T-test. The transformation
of sequences, lists or arrays into vectors can be performed with: 'Vector.ofSeq [sequence]' or 'vector [sequence]'. 

*)
(******)



(**
### Task 2.2

Apply a two-sample t test to both samples. Assume unequal variances of the two population distributions.

*)
(******)

(**
### Task 2.3

Below you see a function whose function body is missing. Within the function two samples
with sample size = n are created from distributions with mean1, mean2 and in each case the same standard deviation.
Assume equal variances of the two population distributions.
A t test has to be applied to the samples created in the function body. The function should return the p value of the test.

*)
(******)

let getPValueOfTTest mean1 mean2 stabw1 stabw2 equal n =
    1. //replace me

(**
### Task 2.4

In the function below, 1000 t tests are performed and the p values are plotted as a histogram.
Create graphs with: 

  - a) equal means with large sample size

  - b) equal means with small sample size

  - c) different means

Look at the behaviour of the p values. How many p values are significant in each case?

  - a)

  - b)

  - c)

*)
(******)

let plotPValue mean1 mean2 stabw1 stabw2 equal n =
    let pValues = Array.init 100000 (fun i -> 
        if i%10000=0 then printfn "progress %i/100000" i
        getPValueOfTTest mean1 mean2 stabw1 stabw2 equal n)
    let pVals =
        Chart.Histogram(pValues,Xbins=Bins.init(0.,1.,0.05),HistNorm=HistNorm.Probability)
        |> Chart.withX_AxisStyle ("p values",MinMax=(0.,1.))
        |> Chart.withY_AxisStyle ("relative count",MinMax=(0.045,0.06))
        |> Chart.withTitle (sprintf "%.1f %.1f s1:%.1f s2:%.1f n:%i %b" mean1 mean2 stabw1 stabw2 n equal)
        |> Chart.withTraceName "pVal distribution"

    let distA = Continuous.normal mean1 stabw1
    let distB = Continuous.normal mean2 stabw2
    let dists = 
        [
            [-5. ..0.1 .. 5.] |> List.map (fun x -> x,distA.PDF x) |> Chart.Area |> Chart.withTraceName (sprintf "m:%.1f s:%.1f" mean1 stabw1)
            [-5. ..0.1 .. 5.] |> List.map (fun x -> x,distB.PDF x) |> Chart.Area |> Chart.withTraceName (sprintf "m:%.1f s:%.1f" mean2 stabw2)
        ]
        |> Chart.Combine
        |> Chart.withY_AxisStyle "pdf"

    [pVals;dists]
    |> Chart.Stack (1,0.2)
    |> Chart.Show

