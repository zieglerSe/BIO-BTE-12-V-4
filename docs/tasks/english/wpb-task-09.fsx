(**
---
title: Task 09
category: Tasks(english)
categoryindex: 3
index: 10
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task09 - Embracing bioinformatics in F#

## Preface

You can find the Plotly.NET documentation here: https://plotly.net

You can find the BioFSharp documentation here: https://csbiology.github.io/BioFSharp/

## Referencing Plotly.NET and BioFSharp

These lines must always be executed at least once, otherwise Plotly.NET and BioFSharp cannot be used:
*)
#r "nuget: Plotly.NET, 2.0.0-preview.1"
#r "nuget: Plotly.NET.Interactive, 2.0.0-preview.1"
#r "nuget: BioFSharp, 1.2.0"
#r "nuget: BioFSharp.IO, 1.2.0"

// Plotly.NET and BioFSharp are opened here.
open Plotly.NET
open BioFSharp
open BioFSharp.IO
// Additional namespaces/modules are also opened here to simplify the signatures.
open BioArray
open BioSeq
open AminoAcids
open Nucleotides

(**
## Copying paths

Reading in data will be discussed in more detail in a later exercise. In this exercise a file must be referenced and read in via a path.
How to get the absolute path of a file is shown here.

### Windows

* Navigate to the downloaded file

* Press `Shift` + `Right click` on the file

* Select "Copy as path" from the context menu:

    ![]({{root}}img/PfadWindows.png)

* With `Ctrl` + `V` you can paste the copied path at any position

### Mac

* Navigate to the downloaded file

* Press with `ctrl-click` or `right-click` on the file

* With the context menu open, also hold down `Alt`

* Select "Copy X as pathname" from the context menu:

    ![]({{root}}img/PfadMac.png)

* With `Command` + `V` you can paste the copied path at any position
*)
(**
## Task 1

### Task 1.0

`nucleotideString` is a sequence of nucleotides. This sequence is to be translated into the corresponding amino acid sequence.

* A Convert 'nucleotideString' to a BioArray.
* B Transcribe the result from A (the given sequence is the template strand)
* C Translate the result from B with an offset of 0
* D Create a function that gets a string, executes the previous steps and thus returns a `BioArray<AminoAcids>`.
*)

let nucleotideString = "TACCATGCAGCTACCTAAGGATCACCGACT"

(**
### Task 1.1

Download the nucleotide fasta of yeast (S. cerevisiae): https://github.com/CSBiology/BIO-BTE-12-V-4/releases/download/YeastFasta/orf_genomic_filtered.fasta. <br>
Source: http://sgd-archive.yeastgenome.org/sequence/S288C_reference/orf_dna/ <br>
Copy the path of the downloaded file and bind it to the name `filepath`.

Read the fasta and bind the result to `yeastFasta`. Use the function 
`FastA.fromFile` and use `BioArray.ofNucleotideString` as converter function.
Convert the resulting sequence into an array.
*)

let filepath = "Your/Path/here"

(**
### Task 1.2

From the created sequence (yeastFasta), generate an array of headers and an array of
sequences and bind these arrays to the names `header` and `dna`. 
Hint: `yeastFasta` consists of FastaItems, which are record types consisting of `header` and `sequence`. 
Since the whole exercise is based on these arrays, please report if it does not work.
*)

(******)

(**
### Task 1.3

Transcribe all nucleotide sequences from `dna` and bind the resulting array to the name 
`rna`.

* Tip: The DNA sequences represent the coding strand.
* Tip2: Use `Array.map` to iterate over the sequences (also applies to the following tasks).
*)

(******)

(**
### Task 1.4

In the following, translate the RNA sequences into proteins, that is, amino acid sequences.   
Bind the result to the name `proteins`.
*)

(******)

(**
### Task 1.5

Now the proteins are to be digested tryptically to peptides (trypsin is a protease which cuts proteins 
into lysine (single letter code K) and arginine (single letter code R).
The function 'Digestion.BioArray.digest' expects a proteinID. Here any integer 
can be used. Ideally, the index of the respective amino acid sequence should be entered here.
Bind the result to 'digestedProteins'.
*)

let trypsin = Digestion.Table.Trypsin

(**
### Task 1.6

No task<br>
The section below creates FastA items from the individual peptides and writes them to a 
FastA file.
*)

let convertDigPepToFasta (digPep: Digestion.DigestedPeptide<'a>[])=
    digPep
    |> Array.mapi (fun index peptide ->
        FastA.createFastaItem (sprintf "Protein %i Fragment %i" peptide.ProteinID index) peptide.PepSequence 
        )

// __SOURCE_DIRECTORY__ defines the path to the folder where this script is located.   
digestedProteins
|> Array.map convertDigPepToFasta
|> Array.concat
|> FastA.write BioItem.symbol (__SOURCE_DIRECTORY__ + "/digestedProteins.fasta")

(**
### Task 2.1

Below you can see the file path to the created peptide fasta.
Read in the fasta and bind the result to 'peptides'. Use a suitable 
Converter function
*)

let pathToPeptides = __SOURCE_DIRECTORY__ + "/digestedProteins.fasta"

(**
### Task 2.2 (optional)

Visualize the frequencies of the amino acids in a suitable diagram.
e.g. histogram, column chart, pie chart or others.
To convert `AminoAcids.AminoAcid` into chars (i.e. single letter codes) you can use `AminoAcids.symbol`.
*)

(******)

(**
### Task 2.3

Create a histogram of the molecular weights of all proteins in `proteins`.
Examine the `BioArray` module for a suitable function. 
Label the axes.  
*)

(******)

(**
### Task 2.4 (optional)

There are also mitochondrial ORFs in the nucleotide fasta (Task 1.2). 
Divide `yeastFasta` into two arrays. In one should be all nucleotide sequences from 'Chr I' to 
Chr 'XVI', and in the other all from 'Chr Mito'. Transcribe the sequences and visualize the codon usage with the function defined below (possibly Chart.Stack 1?).

* Highest percentage mitochondrion:           
    * associated codon:
    * associated amino acid:
* Highest percentage nucleus:
    * associated codon:
    * associated amino acids:
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