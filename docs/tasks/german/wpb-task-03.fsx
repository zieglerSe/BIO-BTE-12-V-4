(**
---
title: Übung 03
category: Übungen(deutsch)
categoryindex: 2
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

Deklariere eine Funktion, die einen Parameter `x` vom Typ float erhaelt. Ist der Wert von `x` groesser Null, so soll die Funktion den Wert zurueckgeben, falls nicht soll das 
Vorzeichen umgekehrt und denn der Wert zerueckgegeben werden.  
Tipp: Multiplikation

*)

(******)

(**

### Task 1.2:

Deklariere eine Funktion, die drei Zahlen als Parameter bekommt. Die groesste der drei Zahlen soll als Ergebnis ausgegeben werden.  
Tipp: `elif`!

*)

(******)

(**

### Task 1.3:

Deklariere eine Funktion, die eine Jahreszahl als Parameter bekommt. Wenn es sich um ein Schaltjahr handelt, soll das Ergebnis `true` sein, andernfalls `false`.  
Tipps:  
- Ist die Jahreszahl durch vier teilbar, aber nicht durch 100, ist es ein Schaltjahr. 2008 faellt unter diese Regel.  
- Ist die Jahreszahl durch 100 teilbar, aber nicht durch 400, ist es kein Schaltjahr. 2100 wird kein Schaltjahr sein.  
- Ist die Jahreszahl durch 400 teilbar, dann ist es immer ein Schaltjahr. Deshalb war das Jahr 2000 ein Schaltjahr.

*)

(******)

(**

## Pattern matching

### Task 2.1:

Deklariere eine Funktion mit denselben Eigenschaften wie in Task 1.1 beschrieben. Verzichte auf if-then-else Expressions und verwende Pattern Matching.  
Tipp: Guarding Rules + Wildcard

*)

(******)

(**

### Task 2.2:

Gegeben ist die UnionCase Definition `Monat`:
```fsharp
type Monat =
    | Januar
    | Februar
    | Maerz
    | April
    | Mai
    | Juni
    | Juli
    | August
    | September
    | Oktober
    | November
    | Dezember
```

und die UnionCase Definition `Jahreszeit`:
```fsharp
type Jahreszeit =
    | Fruehling
    | Sommer
    | Herbst
    | Winter
```

Deklariere eine Funktion, die einen Parameter `m` vom Typ `Monat` besitzt. Verwende Pattern Matching, um jeden
Monat einer Jahreszeit zuzuordnen.

*)

(******)

(**

### Task 2.3:

Pattern matching ist sehr gut dazu geeignet Datenstrukturen zu zerlegen (eng. deconstruction). Deklariere eine
Funktion, die den Record type `Person` (bekannt aus Uebung 2) erhaelt und `true` zurueckgibt, falls der Nachname `Mueller` lautet.  
Tipp: https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/records#pattern-matching-with-records

*)

(******)

(**

## Schleifen

### Task 3.1:

Deklariere eine Funktion, die einen Parameter `n` vom Typ `int` erhaelt.  
Die Funktion soll alle ganzen Zahlen von 1 bis n in der Konsole ausgeben (Tipp: `printfn`). Benutze dafuer eine `for`-Loop.

*)

(******)

(**

### Task 3.2:

Deklariere eine Funktion, die einen Parameter `n` vom Typ `int` erhaelt.  
Die Funktion soll alle ganzen Zahlen von 1 bis n in einer Liste speichern.  
Tipps: Sequence Expressions, Comprehensions  
Extra Punkt: schreibe nur alle geraden Zahlen in eine Liste, Tipps: if-then-else, modulo.

*)

(******)

(**

### Task 3.3:

Deklariere eine Funktion, die einen Parameter `n` vom Typ `int` und einen Parameter `f` mit der Signatur `(int -> int)` erhaelt.  
Die Funktion soll `f` auf alle ganzen Zahlen von 1 bis n anwenden und in einer in einer Liste speichern.  
Tipps: Sequence Expressions, Comprehensions

*)

(******)

(**

## Rekursion

### Task 4.1:

Modifiziere folgende Funktion (bekannt aus der Vorlesung) so, dass sie am Ende ausgibt wie viele Stufen bewaeltigt wurden.
```fsharp
let rec stufeSteigen nStufen position =
    if position = nStufen + 1 then
        printfn "Puh, geschafft"
    else
        printfn "Ich sollte mehr Sport machen"
        stufeSteigen nStufen (position + 1)
```

*)

(******)

(**

### Task 4.2:

Modifiziere die folgende Funktion (bekannt aus der Vorlesung) so, dass sie -1 zurueckgibt, falls abzusehen ist, dass das Ergebnis groesser als 1000 wird.  
Tipp: Hier hilft die `print`-Funktion um Zwischenergebnisse zu visualisieren und die Funktion besser zu verstehen. Z. B.: `printfn "n:%i, acc':%i" n acc`.
```fsharp
let rec facultaet acc n  =
    if n = 1 then
        acc 
    else
        let acc' = n * acc
        facultaet acc' (n-1)

facultaet 1 4
```

*)

(******)