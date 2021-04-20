# BIO-BTE-12-V-4
Notebooks, scripts and guides for the lecture Wissenschaftliche Programmierung für Biologen (BIO-BTE-12-V-4)

Überführen der alten Übungen:
- `(******)` sind notwendig zwischen zwei Kommentarblöcken falls dazwischen ein Codeblock kommen soll.
- Englische versionen der übungen in `/docs/tasks/english`, deutsche in `/docs/tasks/german`
- Frontmatter muss am anfang der jeweiligen .fsx datei stehen: 

    ```fsharp
    (**
    ---
    title: Übung 01 // titel, der in der sidebar angezeigt wird
    category: Übungen(deutsch) // Kategorie, unter der der artikel in der sidebar eingeordnet wird
    categoryindex: 2 // index (für Reihenfolge) der Kategorie
    index: 2 // index (für Reihenfolge) des artikels innerhalb der kategorie 
    ---
    *)
    ```
- Binder links:
```
[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)
```
