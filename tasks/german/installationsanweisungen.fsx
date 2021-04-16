(**
// can't yet format YamlFrontmatter (["title: Erste Schritte"; "category: Übungen(deutsch)"; "categoryindex: 2"; "index: 1"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

# Erste Schritte

## Installationsanweisung

* Lade die neuste stabile Version von [Visual Studio Code](https://code.visualstudio.com/) herunter und installiere sie.
* Lade die empfohlene [.NET SDK](https://dotnet.microsoft.com/download) herunter und installiere sie.
* Öffne Visual Studio Code, navigiere zum Reiter "Extensions" und installiere:
    * .NET Interactive Notebooks
    * Ionide-fsharp
    
    ![](/BIO-BTE-12-V-4/img/CodeExtensions.png)


## Bearbeiten der Übungen

Es gibt drei verschiedene Möglichkeiten zum bearbeiten der Übungen:

* Lokal als Notizbuch in Visual Studio Code
* Lokal als fsx in Visual Studio Code
* Online als Notizbuch auf Binder

### Lokal als Notizbuch in Visual Studio Code

* Lade das aktuelle Notizbuch von der links verlinkten Seite herunter.

    ![](/BIO-BTE-12-V-4/img/DownloadNotebook.png)

* Drücke `Strg + Shift + P` oder `F1` in Visual Studio Code und klicke auf `.NET Interactive Open notebook`.

    ![](/BIO-BTE-12-V-4/img/OpenNotebook.png)

* Navigiere zum Speicherort deines Notizbuchs und öffne es.
* Notizbücher beinhalten Text- und Codeblöcke:
    * Einen neuer Text- oder Codeblock kann hinzugefügt werden, indem man mit dem Mauszeiger über den oberen oder unteren Rand eines vorhandenen Blocks fährt:

    ![](/BIO-BTE-12-V-4/img/AddingBlock.png)

    * Arbeiten mit Textblöcken:
        Ein Textblock kann über einen Doppelklick bearbeitet werden. Innerhalb eines Textblocks kannst du normalen Text schreiben, oder den Text mit [Markdown](https://en.wikipedia.org/wiki/Markdown) anpassen.
        Sobald du fertig bist, kannst du die `Esc` Taste benutzen.
    * Arbeiten mit Codeblöcken:
        Ein Codeblock kann über einen Klick in dne Block bearbeitet werden. In diesem Block kannst du deinen eigenen Code schreiben, oder bereits existierenden Code bearbeiten. Sobald du mit dem bearbeiten fertig bist, kannst du `Strg + Alt + Enter` drücken, um den Codeblock auszuführen.
        Solltest du alle Codeblöcke auf einmal ausführen wollen, kannst du auf die beiden Pfeile in der oberen rechten Ecke des Notizbuches klicken:

    ![](/BIO-BTE-12-V-4/img/ExecuteAll.png)

### Lokal als fsx in Visual Studio Code

* Lade die aktuelle fsx von der links verlinkten Seite herunter.

    ![](/BIO-BTE-12-V-4/img/DownloadScript.png)

* Drücke `Strg + O` in Visual Studio Code, navigiere zum Speicherort deiner fsx und öffne sie.
* Du kannst, ähnlich wie bei einem Textfile, Code überall in der fsx schreiben. Über `Alt + Enter` kann der geschriebene Code ausgeführt werden
    * Das drücken von `Alt + Enter` in einer Zeile führt die aktuelle Zeile aus
    * Wenn man einen Abschnitt markiert und dann `Alt + Enter` drückt, wird der markierte Abschnitt ausgeführt
* Du kannst deinen Code kommentieren, indem du "//" vor deinen Kommentar setzt (z.B..: // Mein Kommentar)

### Online als Notizbuch auf Binder

* Öffne das aktuelle Notizbuch auf der links verlinkten Seite.

    ![](/BIO-BTE-12-V-4/img/RunBinder.png)

* Notizbücher beinhalten Text- und Codeblöcke:
    * Man kann einen neuen Text- oder Codeblock über das klicken von `Insert` am oberen Ende der Seite und dem Auswählen der Eigenschaften `Code` oder `Markdown` erstellen:

    ![](/BIO-BTE-12-V-4/img/BinderAddingBlock.png)

    * Arbeiten mit Textblöcken:
        Ein Textblock kann über einen Doppelklick bearbeitet werden. Innerhalb eines Textblocks kannst du normalen Text schreiben, oder den Text mit [Markdown](https://en.wikipedia.org/wiki/Markdown) anpassen.
        Sobald du fertig bist, kannst du `Strg + Enter` drücken.
    * Arbeiten mit Codeblöcken:
        Ein Codeblock kann über einen Klick in den Block bearbeitet werden. In diesem Block kannst du deinen eigenen Code schreiben, oder bereits existierenden Code bearbeiten. Sobald du mit dem bearbeiten fertig bist, kannst du `Strg + Enter` drücken, um den Codeblock auszuführen.
        Solltest du alle Codeblöcke auf einmal ausführen wollen, kannst du auf die beiden Pfeile am oberen Ende des Notizbuches klicken:

    ![](/BIO-BTE-12-V-4/img/BinderExecuteAll.png)

*)