(**
---
title: Erste Schritte
category: Übungen(deutsch)
categoryindex: 2
index: 1
---

# Erste Schritte

## Installationsanweisung

* Lade die neuste stabile Version von [Visual Studio Code](https://code.visualstudio.com/) herunter und installiere sie.
* Lade die empfohlene [.NET SDK](https://dotnet.microsoft.com/download) herunter und installiere sie.
* Oeffne Visual Studio Code, navigiere zum Reiter "Extensions" und installiere:
    * .NET Interactive Notebooks
    * Ionide-fsharp
    
    ![]({{root}}img/CodeExtensions.png)


## Bearbeiten der Übungen

Es gibt drei verschiedene Möglichkeiten zum bearbeiten der Übungen:

* Lokal als Notizbuch in Visual Studio Code
* Lokal als fsx in Visual Studio Code
* Online als Notizbuch auf Binder

### Lokal als Notizbuch in Visual Studio Code

* Lade das aktuelle Notizbuch von der links verlinkten Seite herunter.

    ![]({{root}}img/DownloadNotebook.png)

* Druecke `Strg + Shift + P` oder `F1` in Visual Studio Code und klicke auf `.NET Interactive Open notebook`.

    ![]({{root}}img/OpenNotebook.png)

* Navigiere zum Speicherort deines Notizbuchs und oeffne es.
* Notizbuecher beinhalten Text- und Codebloecke:
    * Einen neuer Text- oder Codeblock kann hinzugefuegt werden, indem man mit dem Mauszeiger ueber den oberen oder unteren Rand eines vorhandenen Blocks faehrt:

    ![]({{root}}img/AddingBlock.png)

    * Arbeiten mit Textbloecken:
        Ein Textblock kann ueber einen Doppelklick bearbeitet werden. Innerhalb eines Textblocks kannst du normalen Text schreiben, oder den Text mit [Markdown](https://en.wikipedia.org/wiki/Markdown) anpassen.
        Sobald du fertig bist, kannst du die `Esc` Taste benutzen.
    * Arbeiten mit Codebloecken:
        Ein Codeblock kann ueber einen Klick in dne Block bearbeitet werden. In diesem Block kannst du deinen eigenen Code schreiben, oder bereits existierenden Code bearbeiten. Sobald du mit dem bearbeiten fertig bist, kannst du `Strg + Alt + Enter` druecken, um den Codeblock auszufuehren.
        Solltest du alle Codebloecke auf einmal ausfuehren wollen, kannst du auf die beiden Pfeile in der oberen rechten Ecke des Notizbuches klicken:

    ![]({{root}}img/ExecuteAll.png)

### Lokal als fsx in Visual Studio Code

* Lade die aktuelle fsx von der links verlinkten Seite herunter.

    ![]({{root}}img/DownloadScript.png)

* Drücke `Strg + O` in Visual Studio Code, navigiere zum Speicherort deiner fsx und oeffne sie.
* Du kannst, aehnlich wie bei einem Textfile, Code ueberall in der fsx schreiben. Über `Alt + Enter` kann der geschriebene Code ausgeführt werden
    * Das druecken von `Alt + Enter` in einer Zeile führt die aktuelle Zeile aus
    * Wenn man einen Abschnitt markiert und dann `Alt + Enter` drueckt, wird der markierte Abschnitt ausgefuehrt
* Du kannst deinen Code kommentieren, indem du "//" vor deinen Kommentar setzt (z.B..: // Mein Kommentar)

### Online als Notizbuch auf Binder

* Oeffne das aktuelle Notizbuch auf der links verlinkten Seite.

    ![]({{root}}img/RunBinder.png)

* Notizbuecher beinhalten Text- und Codebloecke:
    * Man kann einen neuen Text- oder Codeblock über das klicken von `Insert` am oberen Ende der Seite und dem Auswählen der Eigenschaften `Code` oder `Markdown` erstellen:

    ![]({{root}}img/BinderAddingBlock.png)

    * Arbeiten mit Textbloecken:
        Ein Textblock kann ueber einen Doppelklick bearbeitet werden. Innerhalb eines Textblocks kannst du normalen Text schreiben, oder den Text mit [Markdown](https://en.wikipedia.org/wiki/Markdown) anpassen.
        Sobald du fertig bist, kannst du `Strg + Enter` drücken.
    * Arbeiten mit Codebloecken:
        Ein Codeblock kann ueber einen Klick in dne Block bearbeitet werden. In diesem Block kannst du deinen eigenen Code schreiben, oder bereits existierenden Code bearbeiten. Sobald du mit dem bearbeiten fertig bist, kannst du `Strg + Enter` druecken, um den Codeblock auszufuehren.
        Solltest du alle Codebloecke auf einmal ausfuehren wollen, kannst du auf die beiden Pfeile am oberen Ende des Notizbuches klicken:

    ![]({{root}}img/BinderExecuteAll.png)
*)
