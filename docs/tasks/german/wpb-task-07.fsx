(**
---
title: Übung 07
category: Übungen(deutsch)
categoryindex: 2
index: 8
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Datenvisualisierung mit Plotly.NET

**Verwenden Sie fuer alle Diagramme stets adequate Skalenbeschriftungen.**

**Der Code fuer die Erstellung der Charts reicht aus, Sie muessen keine Bilder einreichen.**

## 0 Vorwort

### Referenzieren von Plotly.NET

Diese Zeilen müssen immer mindestens 1 mal ausgeführt werden, sonst kann das Plotly.NET Softwarepaket nicht verwendet werden:
*)
#r "nuget: Plotly.NET, 2.0.0-beta10"
#r "nuget: Plotly.NET.Interactive, 2.0.0-beta10"
open Plotly.NET

(**
Bei dieser Uebung unterscheiden sich die Arbeitsweisen bezueglich des Anzeigens der erstellten Diagramme in Notebooks und .fsx Skripten grundlegend:

### Anzeigen von Charts in .fsx Skripten

In .fsx Skripten sollte die `Chart.Show` Funktion verwendet werden, welche ein Browserfenster öffnet um Diagramme anzuzeigen:
*)

(***do-not-eval***)
Chart.Point([(1,1); (2,2)])
|> Chart.withTitle "hello from .fsx"
|> Chart.Show

(**
### Anzeigen von Charts in Notebooks

In Notebooks kann zwar auch die Chart.Show Funktion verwendet werden, dank der oben referenzierten `Plotly.NET.Interactive` 
Erweiterung kann allerdings auch einfach der jeweilige Codeblock mit dem value des Charts beendet werden (so wie auch bei anderen Werten gewohnt), 
um den Chart direkt in der Ausgabezelle anzuzeigen:

*)

Chart.Point([(1,1); (2,2)])
|> Chart.withTitle "hello inside the notebook"

(**
## 1 Visualisierung von X/Y Beziehungen

### Task 1.1

Erstellen Sie eine Liste, welche die Werte von 0.0 bis (4 * PI) mit einer Schrittgroesse von 0.001 enthaelt.
binden Sie diese liste an den Namen 'xValues'

*)

(******)

(**
### Task 1.2

Erstellen Sie zwei Listen, die die passenden Funktionswerte von sin(x) und cos(x) fuer 'xValues' enthalten.

_Tipp: benutzen Sie die map Funktion_
*)

(******)

(**

### Task 1.3

Erstellen Sie zwei Punkt- und zwei Liniendiagramme in denen Sie die Werte von 'xValues' und die jeweiligen
Funktionswerte von sin(x) oder cos(x) auf je eine Positionsskala abbilden. Am Ende sollten Sie 4 einzelne 
Diagramme haben.
*)

(******)

(**
### Task 1.4

**a)** Kombinieren Sie die Punkt- und Liniendiagramme aus 1.3. in einem einzigen Koordinatensystem (zu einem einzigen Diagramm mit 4 Unterdiagrammen). 

_Tipp: Benutzen Sie Chart.Combine_

**b)** Warum ist das Resultat ein Diagramm mit einer zusaetzlichen Dimension, bzw. was ist die zusätzlich abgebildete Dimension?
*)

(******)

(**
### Task 1.5 

Visualisieren Sie die (x,y) tuple in der folgenden Liste zunaechst mit einer linearen X und Y Skala.
Transformieren Sie die Daten mit einer nichtlinearen Transformation, die Ihnen sinnvoll erscheint und 
visualisieren Sie das Ergebnis. 

_Tipp: sollten Sie anstatt der Daten die Achse transformieren wollen:_
`Chart.withY_Axis( Axis.LinearAxis.init(StyleParam.AxisType. ...)  )`
*)

let someData = [0. .. 1. .. 10.] |> List.map (fun x -> x,(10. ** x))

(**
## 2 Visualisierung von Anzahl/Groessen

### Task 2.1 

Visualisieren Sie die Abundanz verschiedener Haarfarben der Teilnehmer des Kurses. Falls keine Erhebung 
gemacht werden soll, denken Sie sich einen Datensatz mit 5 verschiedenen Haarfarben und 20 Probanden aus.

_Tipp: erstellen Sie entweder eine Liste mit (Haarfarbe,Abundanz) tupeln oder je eine Liste fuer Haarfarbe und Abundanz_
*)

(******)

(**
### Task 2.2

Visualisieren Sie die Menge an erzeugten Terawattstunden in Deutschland nach verschiedenen Energietraeger im Jahr 2020 hinsichtlich der absoluten Zahlen als Balkendiagramm, sortiert nach Groesse der Strommenge

_Quelle der Daten:_ https://de.wikipedia.org/wiki/Stromerzeugung#Bruttostromerzeugung_nach_Energietr%C3%A4gern_in_Deutschland
*)

(******)

(**
### Task 2.3 

Datenvisialisierung kann oft zur Erkennung von Mustern in einem Datensatz fuehren, die bei blosser 
Betrachtung der Werte nicht ersichtlich waeren, besonders wenn der Datensatz sehr gross und/oder 
mehrdimensional ist. 

Der vorbereitete Testdatensatz enthaelt 3 Dimensionen: die Indices des aeusseren Arrays, die Indices der 
inneren Arrays, und die tatsaechlichen Zahlenwerte in den inneren Arrays. Visualisieren Sie die drei 
Dimensionen mithilfe einer Heatmap.

Welche Information koennte in den 3 Dimensionen kodiert sein? Beschriften Sie die x und y Skalen nach Ihrer 
Einschaetzung.

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
## 3   Visualisierung von Proportionen

### Task 3.1 

Visualisieren Sie das Ergebnis der Landtagswahl in einem beliebigen Bundesland.

_Quelle der Daten:_ https://de.wikipedia.org/wiki/Liste_der_letzten_Landtagswahlergebnisse_in_Deutschland
*)

(******)

(**
### Task 3.2 
Vergleichen Sie die Stimmanteile aus 3.1 visuell mit mindestens 3 weiteren Landtagswahlergebnissen aus 
anderen Bundeslaendern.
*)

(******)

(**
### Task 3.3 
Visualisieren Sie die Daten aus 2.2 hinsichtlich ihres relativen Anteils an der Gesamtstromerzeugung als Doughnut-Chart 

_Tipp: Chart.Doughnut; Sie muessen die Ursprungsdaten jeweils durch die Gesamtmenge an erzeugten kWh Teilen._
*)

(******)

(**
### 4 Visualisierung von geographischer Lage

### Task 4.1

Visualisieren Sie den Anteil der 16 bevoelkerungsreichsten Laender an der Gesamtbevoelkerung der Erde. 

_Quelle der Daten:_ https://de.wikipedia.org/wiki/Weltbev%C3%B6lkerung#Die_bev%C3%B6lkerungsreichsten_Staaten

_Tipp: Chart.Choropleth. Idealerweise aehnelt ihr Ergebnis der Abbildung auf Wikipedia._
*)

(******)

(**
## 5 Bonus

Erstellen Sie ein Klimadiagramm fuer Kaiserslautern
Hierzu muessen verschiedene Charttypen miteinander kombiniert werden.

_Quelle der Daten:_ https://de.climate-data.org/europa/deutschland/rheinland-pfalz/kaiserslautern-2135/

*)

(******)