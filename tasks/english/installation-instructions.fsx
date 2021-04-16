(**
// can't yet format YamlFrontmatter (["title: Getting Started"; "category: Tasks(english)"; "categoryindex: 3"; "index: 1"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

# Getting Started

## Installation instructions

* Download the latest stable build for [Visual Studio Code](https://code.visualstudio.com/) and install it.
* Download the recommended [.NET SDK](https://dotnet.microsoft.com/download) and install it.
* Open Visual Studio Code, navigate to the "Extensions" tab and install
    * .NET Interactive Notebooks
    * Ionide-fsharp
    
    ![](/BIO-BTE-12-V-4/img/CodeExtensions.png)


## Working on Exercises

There are three different possibilities to work on the exercises:

* Locally as notebook in Visual Studio Code
* Locally as fsx in Visual Studio Code
* Online as notebook on Binder

### Locally as notebook in Visual Studio Code

* Download the current notebook from the page linked on the left.

    ![](/BIO-BTE-12-V-4/img/DownloadNotebook.png)

* In Visual Studio Code press `Ctrl + Shift + P` or `F1` and klick on `.NET Interactive Open notebook`.

    ![](/BIO-BTE-12-V-4/img/OpenNotebook.png)

* Navigate to the location of your notebook and open it.
* Notebooks contain Text- and Codeblocks:
    * Adding a new Text- or Codeblock can be done by hovering at the upper or lower border of an existing block:

    ![](/BIO-BTE-12-V-4/img/AddingBlock.png)

    * Working with Textblocks:
        You can edit a Textblock by doubleklicking on it. Inside a Textblock you can write plain text or style it with [Markdown](https://en.wikipedia.org/wiki/Markdown).
        Once you are finished you can press the `Esc` button.
    * Working with Codeblocks:
        You can start editing any Codeblock by clicking in it. In there you can start writing your own code or edit existing code. Once you are done you can execute the Codeblock by pressing `Ctrl + Alt + Return`.
        If you want to execute all codeblocks at once, you can press on the two arrows in the upper right corner of the notebook:

    ![](/BIO-BTE-12-V-4/img/ExecuteAll.png)

### Locally as fsx in Visual Studio Code

* Download the current fsx from the page linked on the left.

    ![](/BIO-BTE-12-V-4/img/DownloadScript.png)

* In Visual Studio Code press `Ctrl + O`, navigate to the location of your fsx and open it.
* You can write code anywhere in the fsx file, similar to a normal text file, and execute it by pressing `Alt + Return`
    * Pressing `Alt + Return` in a line will execute the current line
    * Marking a section and pressing `Alt + Return` will execute the marked section
* You can comment your code by prefixing your comment with "//" (e.g.: // My Comment)

### Online as notebook on Binder

* Open the current notebook from the page linked on the left.

    ![](/BIO-BTE-12-V-4/img/RunBinder.png)

* Notebooks contain Text- and Codeblocks:
    * Adding a new Text- or Codeblock can be done by clicking `Insert` at the top of the page and choosing `Code` or `Markdown` as property:

    ![](/BIO-BTE-12-V-4/img/BinderAddingBlock.png)

    * Working with Textblocks:
        You can edit a Textblock by doubleklicking on it. Inside a Textblock you can write plain text or style it with [Markdown](https://en.wikipedia.org/wiki/Markdown).
        Once you are finished you can press `Ctrl + Return`.
    * Working with Codeblocks:
        You can start editing any Codeblock by clicking in it. In there you can start writing your own code or edit existing code. Once you are done you can execute the Codeblock by pressing `Ctrl + Return`.
        If you want to execute all codeblocks at once, you can klick on the two arrows at the top of the notebook:

    ![](/BIO-BTE-12-V-4/img/BinderExecuteAll.png)


*)