(**
// can't yet format YamlFrontmatter (["title: Task 07"; "category: Tasks(english)"; "categoryindex: 3"; "index: 8"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

[![Binder](/BIO-BTE-12-V-4/img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath=tasks/english/wpb-task-07.ipynb)&emsp;
[![Script](/BIO-BTE-12-V-4/img/badge-script.svg)](/BIO-BTE-12-V-4/tasks/english/wpb-task-07.fsx)&emsp;
[![Notebook](/BIO-BTE-12-V-4/img/badge-notebook.svg)](/BIO-BTE-12-V-4/tasks/english/wpb-task-07.ipynb)

# Data visualization with Plotly.NET

**Use adequate axis titles for all charts**

**The code for generating the charts is sufficient, there is no need to send us images of charts.**

## 0 Preface

The Plotly.NET library documentation can be found at https://plotly.net

### Referencing Plotly.NET

These lines alsways have to be executted once, otherwise you can not use the Plotly.NET library:

*)
#r "nuget: Plotly.NET, 2.0.0-preview.1"
#r "nuget: Plotly.NET.Interactive, 2.0.0-preview.1"
open Plotly.NET
(**
There are two different approaches for displaying charts, depending on if you are working in a Notebook or .fsx scripting environment:

### Displaying Charts in .fsx scripts

Use the `Chart.Show` function in .fsx scripts to display charts in a browser window:

*)
Chart.Point([(1,1); (2,2)])
|> Chart.withTitle "hello from .fsx"
|> Chart.Show
(**
### Displaying charts in notebooks

While you can also use Chart.Show in a notebook environment, you can directly display charts in the respective output 
cell as long as you end the input cell with the chart value (just as known from all other types) thanks to the .`Plotly.NET.Interactive` extension:


*)
Chart.Point([(1,1); (2,2)])
|> Chart.withTitle "hello inside the notebook"
(**
## 1 Visualizing X/Y relationships

### Task 1.1

Create a list containing the values in the range from 0.0 to (4. * PI) with a step size of 0.001.
Bind it to the name 'xValues'

*)

(**
### Task 1.2

create two lists, containing the results of applying either sin(x) or cos(x) to the data in 'xValues' respectively.

_Hint: Use the map function_

*)

(**
### Task 1.3

Create 2 line and 2 point charts visualizing the relationship of 'xValues' and sin(x)/cos(x) respectively via position scales.
You should end up with 4 charts.

*)

(**
### Task 1.4

**a)** Combine the point and line charts from 1.3 in a single coordinate system (to a single chart with 4 subplots)

_Hint: Use Chart.Combine_

**b)** What is the third dimension of that Chart encoding?

*)

(**
### Task 1.5 

Visualize the (x,y) tuples from the following list. Use linear X and Y scales first, 
then transform the data via an adequate non linear transformation and visualize the result.

_Hint: if you want to transform the axis instead of the data:_
`Chart.withY_Axis( Axis.LinearAxis.init(StyleParam.AxisType. ...)  )`

*)
let someData = [0. .. 1. .. 10.] |> List.map (fun x -> x,(10. ** x))
(**
## 2 Visualizing sizes/abundances

### Task 2.1 

Visualize the abundances of hair color in the course. If there is no data available, 
make up a data set with at least 5 different hair colors for 20 imagined people.

_Hint: either create a list of (hair color, abundance) tupels or one list for hair color and abundance each._

*)

(**
### Task 2.2

Visualize the amount of the amount of generated terrawatt hours in germany in 2020 by energy source. Use a bar chart and sort the data by amount of electricity generated. 

_Data source:_ https://de.wikipedia.org/wiki/Stromerzeugung#Bruttostromerzeugung_nach_Energietr%C3%A4gern_in_Deutschland

*)

(**
### Task 2.3 

Data visualization can often lead to the discovery of patterns in data that would not be obvious by 
looking at the raw data alone - especially for large, multidimensional data sets.

The prepared data set below has three dimensions: the indices of the outer array, the indices of the inner arrays, 
and the actual float values contained in the inner arrays. Visualize this data set using a heatmap.

What kind of information is likely encoded in the respective dimensions? Use adequate titles for your chart.


*)
let data3D =
    [|
        [|2.;2.;2.;2.;2.;2.;2.;2.;2.|]
        [|2.;2.;0.;0.;1.;0.;0.;2.;2.|]
        [|2.;0.;0.;3.;3.;3.;0.;0.;2.|]
        [|2.;0.;3.;0.;0.;0.;3.;0.;2.|]
        [|2.;0.;3.;0.;0.;0.;3.;0.;2.|]
        [|2.;0.;0.;0.;3.;0.;0.;0.;2.|]
        [|2.;0.;0.;0.;0.;0.;0.;0.;2.|]
        [|2.;0.;3.;0.;0.;0.;3.;0.;2.|]
        [|2.;2.;0.;0.;0.;0.;0.;2.;2.|]
        [|2.;2.;2.;1.;1.;1.;2.;2.;2.|]
    |]
(**
## 3 Visualizing proportions

### Task 3.1 

Visualize the results of a federal election in germany.

_Data source:_ https://de.wikipedia.org/wiki/Liste_der_letzten_Landtagswahlergebnisse_in_Deutschland

*)

(**
### Task 3.2 

Compare the vote proportions from 3.1 visually with the results of 3 other federal states.


*)

(**
### Task 3.3 

Visualize the data from 2.2 regarding the proportions of the respective energy sources of the overall electricity production.

_Tipp: Chart.Doughnut; You have to divide the respective data points by the total electricity amount._

*)

(**
### 4 Visualisierung von geographischer Lage

### Task 4.1

Visualize the proportion of the world population of the 16 most populated countries in the world.

_Data source:_ https://de.wikipedia.org/wiki/Weltbev%C3%B6lkerung#Die_bev%C3%B6lkerungsreichsten_Staaten

_Tipp: Chart.Choropleth. Ideally your chart will result in something like the chart on wikipedia._

*)

(**
## 5 Bonus

Create a climate chart for Kaiserslautern.

You will have to combine multiple chart types.

_Data source:_ https://de.climate-data.org/europa/deutschland/rheinland-pfalz/kaiserslautern-2135/


*)
