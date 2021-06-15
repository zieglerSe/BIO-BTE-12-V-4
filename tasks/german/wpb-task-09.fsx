(**
// can't yet format YamlFrontmatter (["title: Übung 09"; "category: Übungen(deutsch)"; "categoryindex: 2"; "index: 10"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 9 }) to pynb markdown

[![Binder](/BIO-BTE-12-V-4/img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath=tasks/german/wpb-task-09.ipynb)&emsp;
[![Script](/BIO-BTE-12-V-4/img/badge-script.svg)](/BIO-BTE-12-V-4/tasks/german/wpb-task-09.fsx)&emsp;
[![Notebook](/BIO-BTE-12-V-4/img/badge-notebook.svg)](/BIO-BTE-12-V-4/tasks/german/wpb-task-09.ipynb)

# Task09 - Bioinformatik mit F#

## Vorwort

Die Plotly.NET Dokumentation finden sie hier: https://plotly.net

Die BioFSharp Dokumentation finden sie hier: https://csbiology.github.io/BioFSharp/

## Referenzieren von Plotly.NET und BioFSharp

Diese Zeilen müssen immer mindestens einmal ausgeführt werden, sonst können Plotly.NET und BioFSharp nicht verwendet werden:

*)
#r "nuget: Plotly.NET, 2.0.0-preview.1"
#r "nuget: Plotly.NET.Interactive, 2.0.0-preview.1"
#r "nuget: BioFSharp, 1.2.0"
#r "nuget: BioFSharp.IO, 1.2.0"

// Hier werden Plotly.NET und BioFSharp geoeffnet.
open Plotly.NET
open BioFSharp
open BioFSharp.IO
// Zur Vereinfachung der Signaturen werden hier außerdem weitere Namespaces/Module geoeffnet.
open BioArray
open BioSeq
open AminoAcids
open Nucleotides
(**
## Kopieren von Pfaden

Das Einlesen von Daten wird in einer späteren Uebung genauer behandelt. In dieser Uebung muss eine Datei ueber einen Pfad referenziert und eingelesen werden.
Wie man an den absoluten Pfad einer Datei gelangt wird hier gezeigt.

### Windows

* Navigieren Sie zu der heruntergeladenen Datei

* Drücken Sie mit `Shift` + `Rechtsklick` auf die Datei

* Wählen sie "Als Pfad kopieren" in dem Kontextmenü aus:

    ![](/BIO-BTE-12-V-4/img/PfadWindows.png)

* Mit `Strg` + `V` können sie den so kopierten Pfad an einer beliebigen stelle einfügen

### Mac

* Navigieren Sie zu der heruntergeladenen Datei

* Drücken Sie mit `ctrl-Klick` oder `Rechtsklick` auf die Datei

* Halten sie bei geöffnetem Kontextmenü zusätzlich `Alt` gedrückt

* Wählen Sie "X als Pfadname kopieren" in dem Kontextmenü aus:

    ![](/BIO-BTE-12-V-4/img/PfadMac.png)

* Mit `Befehlstaste` + `V` können sie den so kopierten Pfad an einer beliebigen stelle einfügen

## Task 1

### Task 1.0

`nucleotideString` ist eine Sequenz aus Nucleotiden. Diese soll in die entsprechende Aminosaeure-
Sequenz translatiert werden.

* A Wandeln Sie 'nucleotideString' in ein BioArray um
* B Transkribieren Sie das Ergebnis aus A (die angegebene Sequenz ist der template strand)
* C Translatieren Sie das Ergebnis aus B mit einem offset von 0
* D Erstellen Sie eine Funktion, die einen string bekommt, die vorherigen Schritte ausfuehrt und somit
ein `BioArray<AminoAcids>` zurueck gibt.

*)
let nucleotideString = "TACCATGCAGCTACCTAAGGATCACCGACT"
(**
### Task 1.1

Laden sie die Nucleotid-Fasta von Hefe (S. cerevisiae) herunter: https://github.com/CSBiology/BIO-BTE-12-V-4/releases/download/YeastFasta/orf_genomic_filtered.fasta. <br>
Source: http://sgd-archive.yeastgenome.org/sequence/S288C_reference/orf_dna/ <br>
Kopieren sie den Pfad der heruntergeladenen Datei und binden ihn an den Namen `filepath`

Lesen Sie die Fasta ein und binden Sie das Ergebnis an `yeastFasta`. Nutzen Sie dafuer die Funktion 
`FastA.fromFile` und nutzen Sie `BioArray.ofNucleotideString` als Converter-Funktion.
Wandeln Sie die entstehende Sequenz in ein Array um. 

*)
let filepath = "Ihr/Pfad/hier"
(**
### Task 1.2

Generieren Sie aus der erstellten Sequenz (yeastFasta) jeweils ein einzelnes Array aus Headern und 
Sequenzen und binden Sie diese Arrays an die Namen `header` und `dna`. 
Tipp: `yeastFasta` besteht aus FastaItems, die wiederum Record Types aus `Header` und `Sequence` sind. 
Da die gesamte Uebung auf diesen Arrays beruht, melden Sie sich bitte wenn es nicht funktionieren sollte.

*)

(**
### Task 1.3

Transkribieren Sie alle Nukleotid-Sequenzen aus `dna` und binden Sie das resultierende Array an den Namen 
`rna`.

* Tipp:  Die DNA-Sequenzen stellen jeweils den coding strand dar.
* Tipp2: Nutzen Sie `Array.map` um ueber die Sequenzen zu iterieren (Gilt auch fuer die folgenden Aufgaben).

*)

(**
### Task 1.4

Im Folgenden sollen die RNA-Sequenzen in Proteine, also Aminosaeure-Sequenzen translatiert werden.   
Binden Sie das Ergebnis an den Namen `proteins`.

*)

(**
### Task 1.5

Nun sollen die Proteine tryptisch zu Peptiden verdaut werden (Trypsin ist eine Protease, die Proteine 
jeweils nach Lysin (Einbuchstabencode K) und Arginin (Einbuchstabencode R) schneidet.
Die Funktion `Digestion.BioArray.digest` erwartet eine proteinID. Hier kann ein beliebiger Integer 
eingesetzt werden. Idealerweise soll hier der Index der jeweiligen Aminosaeure-Sequenz eingetragen werden.
Binden Sie das Ergebnis an 'digestedProteins'.

*)
let trypsin = Digestion.Table.Trypsin
(**
### Task 1.6

Keine Aufgabe<br>
Der untenstehende Abschnitt erstellt aus den einzelnen Peptiden FastA-Items und schreibt diese in ein 
FastA-File.

*)
let convertDigPepToFasta (digPep: Digestion.DigestedPeptide<'a>[])=
    digPep
    |> Array.mapi (fun index peptide ->
        FastA.createFastaItem (sprintf "Protein %i Fragment %i" peptide.ProteinID index) peptide.PepSequence 
        )

// __SOURCE_DIRECTORY__ definiert hier den Pfad zum Ordner, in dem dieses Skript liegt.        
digestedProteins
|> Array.map convertDigPepToFasta
|> Array.concat
|> FastA.write BioItem.symbol (__SOURCE_DIRECTORY__ + "/digestedProteins.fasta")
(**
### Task 2.1

Unten sehen Sie den Dateipfad zu der erstellten Peptid-Fasta.
Lesen Sie die Fasta ein und binden Sie das Ergebnis an 'peptides'. Nutzen Sie eine geeignete 
Converter-Funktion

*)
let pathToPeptides = __SOURCE_DIRECTORY__ + "/digestedProteins.fasta"
(**
### Task 2.2 (optional)

Visualisieren Sie die Haeufigkeiten der Aminosaeuren in einem geeineten Diagramm.
zB. Histogramm, Saeulendiagramm, Kreisdiagramm o.ae.
Um `AminoAcids.AminoAcid` in chars (also Einbuchstabencodes) umzuwandeln koennen Sie `AminoAcids.symbol` 
nutzen.

*)

(**
### Task 2.3

Erstellen Sie ein Histogramm ueber die Molekulargewichte aller Proteine in `proteins`.
Untersuchen Sie das `BioArray` Modul nach einer geeigneten Funktion. 
Beschriften Sie die Achsen.  

*)

(**
### Task 2.4 (optional)

In der Nukleotid-Fasta (Task 1.2) befinden sich auch mitochondriale ORFs. 
Teilen sie `yeastFasta` in zwei Arrays auf. Im einen sollen alle Nucleotid Sequenzen von 'Chr I'  bis 
Chr 'XVI' sein, im anderen alle von 'Chr Mito'. Transkribieren Sie die Sequenzen und visualisieren Sie 
die Codon-Usage mit der unten definierten Funktion. (evtl. Chart.Stack 1?)

* Hoechste Prozentzahl Mitochondrion:           
    * zugehoeriges Codon:
    * zugehoerige Aminosaeure:
* Hoechste Prozentzahl Nucleus:
    * zugehoeriges Codon:
    * zugehoerige Aminosaeure:

*)
open Plotly.NET.Axis
open Plotly.NET.StyleParam

let myAxis title = LinearAxis.init(Title=title,Mirror=Mirror.All,Ticks=TickOptions.Inside,Showgrid=false,Showline=true,Zeroline=false)
let styleChart x y chart = chart |> Chart.withX_Axis (myAxis x) |> Chart.withY_Axis (myAxis y)
let plotCodonFrequency (rnaInput:BioArray.BioArray<Nucleotides.Nucleotide>[]) =
    let allTripletts =
        rnaInput
        |> Array.map (fun singleRna -> Seq.chunkBySize 3 singleRna)
        |> Seq.concat
        |> Array.ofSeq
    allTripletts
    |> Seq.groupBy id
    |> Seq.mapi (fun i (codon,items) -> 
        printfn "step %i, Codon %A" i codon
        let aminoAcid = Nucleotides.CodonMap.[codon.[0],codon.[1],codon.[2]]
        let codonString = sprintf "%A%A%A" codon.[0] codon.[1] codon.[2]
        aminoAcid,codonString,float (Seq.length items) / float (Seq.length allTripletts))
    |> Seq.sortBy (fun (_,co,_) -> co)
    |> Seq.groupBy (fun (aa,_,_) -> aa)
    |> Seq.map (fun (aa,codons) -> 
        codons
        |> Seq.sortByDescending (fun (aa,codon,count) -> count)
        |> Seq.map (fun (aa,codon,count) -> codon,count)
        |> Chart.Column
        |> Chart.withTraceName (sprintf "%A" aa)
        )
    |> Chart.Combine
    |> styleChart "" "rel. count (%)"
    |> Chart.withSize (900.,600.)
    |> fun x -> 
        Chart.Show x
        x