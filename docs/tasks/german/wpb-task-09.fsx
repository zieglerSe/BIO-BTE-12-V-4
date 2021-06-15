(**
---
title: Übung 09
category: Übungen(deutsch)
categoryindex: 2
index: 10
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task09 - Datenzugriff

## 0 Vorwort

Folgende Dokumentation könnte für die Bearbeitung der Aufgaben hilfreich sein:

* Deedle: https://fslab.org/Deedle

### Referenzieren von Plotly.NET, Deedle und FSharp.Stats

Diese Zeilen müssen immer mindestens einmal ausgeführt werden, sonst können die Softwarepakete nicht verwendet werden:
*)

#r "nuget: Deedle, 2.3.0"
open Deedle

(**
### Arbeiten mit Deedle

Sollten Sie diese Fehlermeldung sehen:
```
9_Data_exploration_using_FSharp.fsx(113,5): error FS0030: Value restriction. The value 'cpw'' has been inferred to have generic type val cpw' : Series<(string * int),'_a>      
Either define 'cpw'' as a simple data term, make it a function with explicit arguments or, if you do not intend for it to be generic, add a type annotation.
```
Dann sollten Sie auf eine explizite Typenanmerkung zurückgreifen.
Statt:
```
let cpw' = persons |> Frame.getCol "cpw"
```
Verwenden Sie:
```
let cpw' :Series<int,float> = persons |> Frame.getCol "cpw"
```
Zum anzeigen von Deedle-Objekten in diesem Notebook können Sie den `.Print()` Member verwenden:
*)

let firstNames' = Series.ofValues ["Kevin";"Lukas";"Benedikt";"Michael"]
firstNames'.Print()

(**
## 1 Basics

### Task 1.1

Gegeben sind 4 Series gleicher Länge. Nutzen Sie die Funktion `Series.mapValues` um die Werte von "coffeesPerWeek" zu verdoppeln. 
*)

let firstNames      = Series.ofValues ["Kevin";"Lukas";"Benedikt";"Michael"] 
let coffeesPerWeek  = Series.ofValues [15;12;10;11] 
let lastNames       = Series.ofValues ["Schneider";"Weil";"Venn";"Schroda"]  
let group           = Series.ofValues ["CSB";"CSB";"CSB";"MBS"]

(**
### Task 1.2

Erstellen Sie auf Basis der 4 gegebenen Series einen Frame mit dem Namen "persons". 
*)

(******)

(**
### Task 1.3

Fügen Sie eine Column mit dem Namen "sodasPerWeek" zu dem Frame hinzu. Binden Sie den resultierenden Frame an einen Namen.

Tipp: Erst eine `Series<int,int>` erstellen. Nutzen Sie `Frame.addCol`
*)

(******)

(**
### Task 1.4

Addieren Sie die Columns "sodasPerWeek" und "coffeesPerWeek". Fügen Sie die resultierende Series als Spalte mit dem Titel "allPurchases" zu dem zuvor erstellten Frame hinzu.

Tipp 1: Diese Task kann auf mehrere Arten und Weisen gelöst werden.

Tipp 2: Via `Series.values` können Sie auf die Werte der einzelnen Series zugreifen. Dann könnten Sie mit `Seq.map2` über beide Collections iterieren. 
*)

(******)

(**
### Task 1.5

Bestimmen Sie die Summe von "allPurchases".
*)

(******)

(**
## 2 Frame Operationen

### Task 2.1

Gruppieren Sie die Zeilen des Frames aus Task 1.2 nach den Elementen der Spalte "group".

Tipp: Explizite Typenanmerkung (siehe: [Arbeiten mit Deedle](#Arbeiten-mit-Deedle)) 
*)

(******)

(**
### Task 2.2

Oft enthalten Ergebnistabellen mehr als 40 Spalten. Für einzelne Analysen sind jedoch nur einige wenige interessant. 
Es bietet sich daher oft an einen Frame zu erstellen, der weniger Spalten enthält. Nutzen Sie die Funktion `Frame.sliceCols` um auf 
Basis des Frames aus Task 1.2 einen Frame zu erstellen, der lediglich die Spalten "lastNames" und "coffeesPerWeek" enthält. 
*)

(******)

(**
### Task 2.3

Oft möchte man auf Basis von Gruppierungen aggregieren. Berechnen Sie die Summe der Spalte "coffeePerWeek" für jede Gruppe.

Tipp: Extrahieren Sie die Spalte "coffeePerWeek" aus dem Ergebnis von Aufgabe 2.1. Verfahren Sie wie in der Vorlesung demonstriert. 
*)

(******)

(**
### Task 2.4

Oft möchte man Zwischenergebnisse abspeichern. Speichern Sie den Frame aus Aufgabe 1.2 als CSV Datei. Verwenden Sie ';' als Trennzeichen. 
*)

(******)

(**
### Task 2.5

Verwenden Sie die Funktion `Frame.ReadCsv` um die Datei erneut einzulesen. 
*)

(******)