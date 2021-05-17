(**
---
title: Übung 05
category: Übungen(deutsch)
categoryindex: 2
index: 6
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task05 - Programming with Objects 

## Veränderliche Werte

### Task 1.1:

Erstellen und Verändern von veränderlichen Werten

Tipp: 

- Benutzt das `mutable` keyword
- Zur Veränderung der Werte wird der `<-` Operator verwendet

### Subtask 1.1.1

Erstelle einen veränderlichen Integer mit dem Wert 1 und bindet ihn an den Namen x

*)
(******)


(**
### Subtask 1.1.2

Verändere den Wert der an x gebunden ist indem ihr den Wert den x trägt mit 5 multipliziert 
*)
(******)

(**
### Subtask 1.1.3

Erstelle einen Record Type `Mensch` mit 

- dem unveränderlichen Feld `Name` vom Typ string
- und dem veränderlichen Feld `Alter` vom Typ int
*)
(******)

(**
### Subtask 1.1.4

Erstelle die Funktion `geburtstagFeiern` die als Parameter einen Wert des Typen `Mensch` erhält und das Alter des Menschen um eins erhöht
*)
(******)

(**
### Subtask 1.1.5

Erstelle einen Menschen, binde ihn an einen Namen und lass diesen erstellten Menschen mit der Funktion `geburtstagFeiern` altern.
*)
(******)

(**
### Task 1.2 (Bonusaufgabe) Veränderliche Werte in Funktionen

Erstelle eine eigene Version der `Array.max` Funktion. Diese Funktion soll ein Array von ints erhalten und den größten der ints zurückgeben.
Signatur: `int [] -> int`

Dabei soll der aktuell größte int ein `veränderlicher Wert` sein und es soll eine `for-Schleife` verwendet werden.

*)
(******)

(**

## Vererbung

### Task 2.1 Erstellen von Klassen und Objekten

### Subtask 2.1.1

Im folgenden wird die Klasse `Fahrzeug` erstellt. Versuche nachzuvollziehen, was passiert und kommentiere jede Zeile kurz

Keywortfundgrube: Methode, Feld, Konstruktor, Parameter, alternativ, binden

*)
(******)

// Kommentar:
type Fahrzeug (hersteller:string) =
    // Kommentar:
    member self.Hersteller = hersteller
    // Kommentar:
    member self.Fahren() = printfn "%s macht brumm brumm" self.Hersteller
    // Kommentar:
    new() = Fahrzeug("VW")


(**
### Subtask 2.1.2

Instanziiere 2 Objekte des Typs `Fahrzeug`. Verwende einmal den den Haupt- und einmal den alternativen Konstruktor
*)
(******)

(**
### Task 2.2 Vererbung

### Subtask 2.2.1

Hier ist ein Beispiel für die Vererbung eines Typen, namentlich der Typ `Motorrad` der vom Typ `Fahrzeug` erbt. 

Erstelle analog einen Typen `Auto`, der auch vom Typ `Fahrzeug` erben soll. Dieser Typ soll aber zusätzlich das Feld `AnzahlTueren` enthalten. 
Wähle hierzu einen passenden primitiven Typen und passe auch den Konstruktor an, sodass diese Anzahl der Türen auch beim Instanziieren gesetzt werden kann.
*)
(******)

type Motorrad (hersteller:string) =

    inherit Fahrzeug(hersteller)

    new() = Motorrad("Kawasaki")

(**
### Subtask 2.2.2

Erstelle eine Funktion, welche einen Parameter des Typs `Fahrzeug` enthält und die Methode `Fahren` dieses Fahrzeuges ausführt.
*)
(******)

(**
### Subtask 2.2.3

Erstelle ein `Auto` und binde en an einen Namen. Dann wende die oben definierte Funktion zum `Fahren` darauf an.
*)

(**
### Task 2.3 (Bonusaufgabe) Veränderliche Werte in Objekten

Deklariere eine Klasse `Cabrio` die vom Typ `Fahrzeug` erbt. 

Diese Klasse soll ein Feld `DachOffen` vom Typ `bool` haben und zusätzlich Methoden, mit denen man das Dach öffnen und schließen kann
*)



(**
## Polymorphismus

### Task 3.1

Wir wollen hier Personen implementieren, die ihren Namen sagen können. In Japan wird auch im alltäglichen Leben normalerweise der Familienname vor dem Eigennamen genannt. 
So ist Yoko Ono in Japan als Ono Yoko bekannt. Um diesen Unterschied programmatisch darzustellen, wurde der Code folgendermassen geschrieben:

Ordne die folgenden Begriffen den zugehörigen Codebausteinen zu: `Klassendeklaration`, `Objektinstanziierung`, `Interfacedeklaration`

*)
(******)

// Bezeichnung:
type IPerson =
    abstract FamilienName   : string
    abstract EigenName      : string
    abstract NamenSagen     : unit -> string

// Bezeichnung:
type Japaner (fn, en) =
    let familienName = fn
    let eigenName = en
    interface IPerson with
        member self.FamilienName = familienName
        member self.EigenName = eigenName
        member self.NamenSagen () = familienName + " " + eigenName

// Bezeichnung:
type Deutscher (fn, en) =
    let familienName = fn
    let eigenName = en
    interface IPerson with
        member self.FamilienName = familienName
        member self.EigenName = eigenName
        member self.NamenSagen () = eigenName + " " + familienName

// Bezeichnung:
let yokoOno = Japaner("Ono","Yoko")

// Bezeichnung:
let angeloMerte = Deutscher("Merte","Angelo")

(**
### Task 3.2

Greife auf die Methode `NamenSagen` der beiden Personen zu. 
Tipp: Verwende den korrekten `casting Operator`
*)
(******)

(**
### Task 3.3

Erkläre kurz in eigenen Worten, warum in diesem Beispiel Polymorphismus verwendet wurde und nicht Vererbung.
*)
(******)

(**
### Task 3.4

Im fernen Land Dingeldongel wird wie auch in Deutschland erst der Eigenname und dann der Familienname genannt. Beide werden jedoch revertiert. (Angela Merkel -> alegnA lekreM)

Deklariere die Klasse `Dingeldongler`, die das Interface `IPerson` implementiert.

Tipp: Verwende die gegebene string-revertier Funktion

*)
(******)

let revert (s:string) = System.String(s.ToCharArray() |> Array.rev)

