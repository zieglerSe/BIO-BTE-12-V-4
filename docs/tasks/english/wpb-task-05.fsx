(**
---
title: Task 05
category: Tasks(english)
categoryindex: 3
index: 6
---
*)

(**

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath={{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

# Task05 - Programming with Objects 

## Mutable values

### Task 1.1:

Create and change mutable values

Hint: 

- Use the `mutable` keyword
- For changing mutable values, use the `<-` operator 

### Subtask 1.1.1

Create a mutable integer of value 1 and bind it to the name x

*)
(******)


(**
### Subtask 1.1.2

Change the value which is bound to x to its previous value multiplied by 5
*)
(******)

(**
### Subtask 1.1.3

Create a record type `Human` with

- the immutable field `Name` of type string
- and the mutable field `Age` of type int
*)
(******)

(**
### Subtask 1.1.4

Create the the function `celebrateBirthday`, which takes one parameter of type `Human` and increments the `Age` of the human by one.
*)
(******)

(**
### Subtask 1.1.5

Create a `Human`, bind it to a name and let him age by applying the `celebrateBirthday` function on him.
*)
(******)

(**
### Task 1.2 (Bonus taks) Mutable values in functions

Create your own version of the `Array.max` function. This function should take an array of ints as a parameter and return the highest value of this array.
Signature: `int [] -> int`

In the function, the currently highest int is supposed to be stored as a `mutable value` and you should use a `for-loop`.

*)
(******)

(**

## Vererbung

### Task 2.1 Creating classes and objects

### Subtask 2.1.1

Here the class `Vehicle` gets declared. Try to comprehend what happens and shortly comment each line

_keyword treasure trove_: method, field, constructor, parameter, alternative, bind

*)
(******)

// Comment:
type Vehicle (manufacturer:string) =
    // Comment:
    member self.Manufacturer = manufacturer
    // Comment:
    member self.Drive() = printfn "%s makes wroooom" self.Manufacturer
    // Comment:
    new() = Vehicle("Cadillac")


(**
### Subtask 2.1.2

Instantiate 2 objects of type `Vehicle`. In one case use the main constructor and in the other use the alternative constructor.
*)
(******)

(**
### Task 2.2 Inheritance

### Subtask 2.2.1

Here is an example for the inheritance of a class. The class `Motorcycle` inherits from the class `Vehicle`

Analogously, create the class `Car`, which also inherits from `Vehicle`. Additionally, it should have the field `NumDoors`. 
For this, choose an appropriate primitive type and adjust the constructor to allow for setting the number of doors when instantiating a car object.
*)
(******)

type Motorcycle (manufacturer:string) =

    inherit Vehicle(manufacturer)

    new() = Motorcycle("Kawasaki")

(**
### Subtask 2.2.2

Create a function which has a parameter of type `Vehicle` and calls the `Drive` method of this vehicle.
*)
(******)

(**
### Subtask 2.2.3

Instantiate a `Car` and bind it to a name. Use the function defined in subtaks 2.2.2 to let the car drive
*)

(**
### Task 2.3 (Bonus task) Mutable values in objects

Define a class `Convertible` which inherits from `Vehicle`. 

This class should contain a field `RoofOpen` of type `bool` and additionally methods for closing and opening its roof.
*)



(**
## Polymorphismus

### Task 3.1

We want to implement people which can say their name. In Japan, usually the surname is stated prior to the given name. In germany it's the other way round.
The singer known as Yoko Ono in germany therefore is known as Ono Yoko in Japan. To express this difference programmatically, we wrote the following code:

Assign the following keywords to the codeblocks below: `Class declaration`, `Object instantiation`, `Interface declaration`

*)
(******)

// Keyword:
type IPerson =
    abstract Surname    : string
    abstract GivenName  : string
    abstract SayName    : unit -> string

// Keyword:
type Japanese (sn, gn) =
    let surname = sn
    let givenName = gn
    interface IPerson with
        member self.Surname = surname
        member self.GivenName = givenName
        member self.SayName () = surname + " " + givenName

// Keyword:
type German (sn, gn) =
    let surname = sn
    let givenName = gn
    interface IPerson with
        member self.Surname = surname
        member self.GivenName = givenName
        member self.SayName () = givenName + " " + surname

// Keyword:
let yokoOno = Japanese("Ono","Yoko")

// Keyword:
let angeloMerte = German("Merte","Angelo")

(**
### Task 3.2

Call the method `NamenSagen` of both persons. 

Hint: Use the correct `casting Operator`
*)
(******)

(**
### Task 3.3

Shortly explain in your own words, why we used polymorphism instead of inheritance in this example.
*)
(******)

(**
### Task 3.4

In the mystic country Bambaloozle the surname of a person gets said prior to the given name, just like in Germany. But: Both names get reverted (Angela Merkel -> alegnA lekreM)

Declare the class `Bambaloose`, which implements the interface `IPerson`.

Hint: Use the given string revert function

*)
(******)

let revert (s:string) = System.String(s.ToCharArray() |> Array.rev)

