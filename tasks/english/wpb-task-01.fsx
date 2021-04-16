(**
// can't yet format YamlFrontmatter (["title: Task 01 "; "category: Tasks(english)"; "categoryindex: 3"; "index: 2"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

[![Binder](/BIO-BTE-12-V-4/img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath=tasks/english/wpb-task-01.ipynb)&emsp;
[![Script](/BIO-BTE-12-V-4/img/badge-script.svg)](/BIO-BTE-12-V-4/tasks/english/wpb-task-01.fsx)&emsp;
[![Notebook](/BIO-BTE-12-V-4/img/badge-notebook.svg)](/BIO-BTE-12-V-4/tasks/english/wpb-task-01.ipynb)

# Task01 - Hello F#

-------------------------------


Let's start with the basics:

- **In a .fsx script:** 

    Highlight the '10' and press Alt+Enter, which will open a console and give the output 'val it: int = 10'.
    (If the code to execute has only one line, you can just click into the line and press Alt+Enter without highlighting.)

- **In a notebook:**

    There is a 'play' button in the left upper corner of the field below. Press it to execute the respective code block, 
    which in this case will simply give '10' as output.


*)
10
(**
Working in this interactive way has the advantage that you can always directly test your code and look at the output.
Try it with the line below and appreciate that the result of the calculation is 30.

*)
10 + 20
(**
Everything after a "//" or inside of (* ... *) is treated as a comment and will not get executed as code.
You can use (* ... *) to comment parts of a single line. 
The standard keybinding for commenting a selection is (Strg + K -> Strg + C)


*)
10 (*+ 40 *) + 30
(**
If you not quite get a task right, please submit partial solutions or trails of thought as comments to get partial points!

## Das 'let'-Binding

## Task 1

### Task 1.1

Bind the value 10 to the name 'x'. Bind the value 20 to the name 'kaesebrot'.

*)

(**
### Task 1.2

Bind the result of the Addition of 'x' and 10 to the name 'y'.

*)

(**
### Task 1.3

Bind any first name as string to 'vorname'.

*)

(**
### Task 1.4

Calculate the remainder of 432858049/41 and bind the result to 'modulo'

*)

(**
### Task 1.5

Binde the sum of both sums (x + 10) and (y + 20) to the Name 'sumXY'. 
Die Zwischenergebnisse sollten nicht im globalen Sichtbarkeitsbereich (Scope) liegen.

*)

(**
## Die "printfn" - Funktion

### Task 2

_Tipp: https://docs.microsoft.com/de-de/dotnet/fsharp/language-reference/plaintext-formatting_

### Task 2.1:  

Use the printfn function to print "Hello F#" to the console.

*)

(**
### Task 2.2:  

Use the printfn function to print the value of 'vorname' to the console.

*)

(**
### Task 2.3:  

Benutzt printfn um 'y' in die Konsole auszugeben.

*)

(**
## Primitive Datentypen und Funktionen

### Task 3

### Task 3.1

Binde einen beliebigen Wert vom Typ Integer an den Namen intI.

*)

(**
### Task 3.2

Binde einen beliebigen Wert vom Typ Float an den Namen floatI.

*)

(**
### Task 3.3

Wandelt entweder intI oder floatI in den Datentyp des anderen um und addiert beide.

*)

(**
### Task 3.4

Berechne den Quotienten aus '27' und '13'. Dann berechne den Quotienten von beiden Integern als Float.

*)

(**
### Task 3.5:

Konkateniere einen beliebigen Wert vom Typ String mit einem einzelnem Buchstaben (Typ Char)

*)

(**
### Task 3.6:

Deklariere eine Funktion 'mulitplyBy2' die einen float verdoppelt. 

*)

(**
### Task 3.7:  

Deklariere eine Funktion 'calculateCylinderVolume' die aus Radius und Laenge das Volumen eines Zylinders 
zurueckgibt UND zusaetzlich "Das Volumen des Zylinders ist: XX" in die Konsole printed. Wobei XX natuerlich 
das korrekte Volumen des Zylinders ist. (Der Output einer printfn Funktion ist Unit.)
Warum kann es Sinn machen, Ergebnisse zu printen? 

*)

(**
### Task 3.8:  

Deklariere eine Funktion die einen Parameter vom Typ Integer als Input nimmt und die 'multiplyBy2' 
Funtkion darauf anwendet

*)

(**
### Task 3.9:  

Deklariere eine Funktion die als Input zwei Parameter vom Typ Floats, einen Vergleichsoperator z.B. 
(<, >, = ), und einen Parameter vom Typ Boolean akzeptiert. Das Ergebnis aus der Anwendung des angegebenen 
Operators auf die numerischen Parameter soll mit dem Parameter vom Typ Boolean auf Gleichheit ueberprueft werden.

(_2 Punkte_)


*)
