(**
---
title: Übung 06
category: Übungen(deutsch)
categoryindex: 2
index: 7
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Typen-gesteuertes Design​ - Tic Tac Toe

***Disclaimer 1*** Wir haben einige Blaupausen von Typen und Wertebindungen (e.g. ValidMoves or diagonals) hinzugefügt die ihr benötigt um die Übung abzuschließen, vergesst nicht sie selbst zu implementieren!

***Disclaimer 2*** Diese Übung ist eure Chance Punkte zu sammeln! Wir werden diese Übung als 'Bonus' werten, d.h. ihr könnt
zusätzliche Punkte sammeln und damit den Prozentsatz an richtig gelösten Aufgaben erhöhen, nicht aber verringern. Viel Spaß!

In dieser Uebung soll das beliebte Spiel Tic Tac Toe implementiert werden. Im Vordergrund stehen - wie in der Vorlesung demonstriert -
die Zerlegung des Problems, die Abstraktion einzelner Elemente und Aktionen als Typen und final die Implementation der Logik.

### Task 1.1:

Abgebildet ist ein Tic Tac Toe Spielfeld:
```
    |-|X|-|
    |X|O|-|
    |O|-|-|
```
Das Spielfeld besteht aus insgesamt 9 Zellen. 
Jede Zelle kann gemaeß der Spielregeln drei Zustaende annehmen 

i.   leer 

ii.  Belegt von Spieler X 

iii. Belegt von Spieler Y. 

Definiere einen Typ der den Status (eng. State) einer Zelle abstrahiert.
*)
(******)

(**
### Task 1.2

Da die relativen Positionen einzelner Felder fuer das Spiel von Bedeutung sind, muss die Position einer Zelle 
ebenfalls modelliert werden. Da die Zahl der Felder endlich (9) und das Feld quadratisch ist ergibt sich eine endliche Anzahl
moeglicher Positionen. Definiere die noetigen Typen um die Zellposition in der Form HorizontalPosition * VerticalPosition angeben zu koennen.

*)
(******)

(**
### Task 1.3

Mit dem Zustand der Zelle und ihrer Position kann eine Zelle vollstaendig beschrieben werden. Deklariere einen Record-Typ der diesen Sachverhalt abbildet.

*)
(******)

(**
### Task 1.4

Da das Spielfeld aus einzelnen Zellen besteht laesst sich dieses vollstaendig beschreiben, wenn wir den Zustand aller Zellen kennen. Definiere einen Typ
der das Spielfeld modelliert.

*)
(******)


(**
### Task 2.1

Nun haben wir bereits alle Typen definiert um das Spielfeld zu beschreiben. Im Folgenden ist ein moeglicher Spielverlauf
schematisch dargestellt: 
                                                                                                                                       
```                                                                                                                                                                                                                                                                   
     Lust                    |-|-|-|                                               
     zu         ---------->  |-|-|-|, Liste moeglicher Zuege (bzw. freier Zellen) ODER Ergebnis (Sieger X, Sieger Y oder Unentschieden)
     spielen      Aktion A   |-|-|-|                                     
                                                |
                                                | Aktion B  
                                                |
                                                v
                             |X|-|-|                                               
                             |-|-|-| und Liste moeglicher Zuege ODER Ergebnis  (Sieger X, Sieger Y oder Unentschieden)                                                                   
                             |-|-|-|                                     
                                                |
                                                | Aktion C 
                                                |
                                                v  
                             |X|-|-|                                               
                             |O|-|-| und Liste moeglicher Zuege ODER Ergebnis (Sieger X, Sieger Y oder Unentschieden)
                             |-|-|-|                                     
                                                |
                                                | Aktion B 
                                                |
                                                v  
                             |X|-|-|                                               
                             |O|X|-| und Liste moeglicher Zuege ODER Ergebnis (Sieger X, Sieger Y oder Unentschieden)
                             |-|-|-|                                     
```                              
Aktionen(Moves) A, B und C haben entweder ein Ende des Spiels zur Folge (Sieger X, Sieger Y oder Unentschieden), oder 
resultieren in einer upgedateten Version des Spielfeldes, einer Liste weiterer freier Zellen, sowie der naechsten Aktion.
Um diesen Sachverhalt zu modellieren bietet sich ein Union Case an:
```fsharp
type ValidMoves = {
        Moves:List<CellPosition>
    }

type MoveResult = 
    | Win of Player
    | Tie 
    | Move of Player*GameState*ValidMoves
```
*)


(**
Definiere die Aktionen A, B und C als Typen. Nutze dazu den UnionCase MoveResult.
*)

(******)

(**
### Task 2.2
Implementiere eine Funktion, die das Spielfeld erstellt. Der
Rueckgabewert der Funktion soll vom Typ MoveResult sein. Spieler X soll das Spiel beginnen.
Tipp: Gegeben sind Listen aller horizontalen und vertikalen Positionen. 

```fsharp
let allHorizontal = [Left;Middle;Right]
let allVertical   = [Top;Center;Bottom] 
```
*)

(******)

(**
### Task 2.3
Bevor wir gemeinsam die Zuege von Spieler X und Spieler Y implementieren, ueberlegen wir was eine solche Funktion leisten muss.
Die Funktion wird das Spielfeld manipulieren. Implementiere eine Funktion die einen Parameter vom Typ GameState, einen Parameter vom 
Typ CellPosition und einen Parameter von Typ Player erhaelt. Der Rueckgabewert entspricht dem upgedateten GameState.
*)
(******)

(**
### Task 2.4
Desweiteren wird die Funktion ueberpruefen muessen ob ein Spiel gewonnen wurde. 
Dazu stellen wir uns die Frage: Wann ist das Spiel gewonnen? Das Spiel ist immer dann gewonnen, wenn
ein Spieler eine Spalte, eine Zeile oder eine der beiden Diagonalen vollstaendig besetzt hat. 
Implementiere eine Funktion die einen Parameter vom Typ GameState und einen Parameter vom Typ Player erhaelt. 
Die Funktion soll 'true' zurueckgeben wenn der Spieler gewonnen hat. 
Tipp: Gegeben sind alle moeglichen Spalten, Zeilen und Diagonalen.
```fsharp
let rows =
    let makeHLine v = [for h in allHorizontal do yield (h,v)]
    let rows = [for v in allVertical do yield makeHLine v] 
    rows

let columns =
    let makeVLine h = [for v in allVertical do yield (h,v)]
    let columns = [for h in allHorizontal do yield makeVLine h] 
    columns
 
let diagonals =
    let diagonal1 = [Left,Top; Middle,Center; Right,Bottom]
    let diagonal2 = [Left,Bottom; Middle,Center; Right,Top]
    [diagonal1;diagonal2] 
```
*)


(******)


(**
### Task 2.5
Natuerlich kann ein Spiel unentschieden ausgehen. Das ist beispielsweise immer der Fall, sollte niemand
gewonnen haben und alle Zellen einen anderen State als Empty aufweisen. Schreibe eine Funktion, die das ueberprueft.
*)

(******)

(**
.... und in der Uebung werden wir das Spiel gemeinsam beenden...
*)