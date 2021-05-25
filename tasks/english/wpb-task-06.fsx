(**
// can't yet format YamlFrontmatter (["title: Task 06"; "category: Tasks(english)"; "categoryindex: 3"; "index: 7"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

[![Binder](/BIO-BTE-12-V-4/img/badge-binder.svg)](https://mybinder.org/v2/gh/csbiology/BIO-BTE-12-V-4/gh-pages?filepath=tasks/english/wpb-task-06.ipynb)&emsp;
[![Script](/BIO-BTE-12-V-4/img/badge-script.svg)](/BIO-BTE-12-V-4/tasks/english/wpb-task-06.fsx)&emsp;
[![Notebook](/BIO-BTE-12-V-4/img/badge-notebook.svg)](/BIO-BTE-12-V-4/tasks/english/wpb-task-06.ipynb)

# Typen-gesteuertes Design​ - Tic Tac Toe

***Disclaimer 1*** we included some blueprints of types or values which we think you might need (e.g. ValidMoves or diagonals), do not forget to implement them yourself!

***Disclaimer 2*** This task is your chance to farm some points! We will evaluate it as a 'bonus'. You can only 
collect additional points and thereby only raise the percentage of tasks solved correctly. Have fun!

### Task 1.1:

This is a tic tac toe board:
```
    |-|X|-|
    |X|O|-|
    |O|-|-|
```
The board consists of 9 Cells. 
Each cells can have one of three states:

i.   Empty 

ii.  Occupied by player X 

iii. Occupied by player Y. 

Define a type abstracting the possible state of a cell.

*)

(**
### Task 1.2

The relative positions of a cell is important for the game. This means that we have to model the position of a cell.
Since the number of cells is finit (9) and the field is quadratic, we have a finit number of possible positions. Define
the types needed to specify the cellpositions as: HorizontalPosition * VerticalPosition


*)

(**
### Task 1.3

Given the state of a cell and its position we can describe it completely. Declare a record type which contains this information.

*)

(**
### Task 1.4

We can describe the state of the board if we know the state of each cell. Define a type to model the tic tac toe board


*)

(**
### Task 2.1

Now you should be equipped with all types to describe the board. Given a schematic representation of a possible
game:
                                                                                                                                       
```                                                                                                                                                                                                                                                                   
     want                    |-|-|-|                                               
     to         ---------->  |-|-|-| and list of possible moves (or empty cells) OR Result (winner X, winner Y or draw)
     play         action A   |-|-|-|                                     
                                                |
                                                | action B  
                                                |
                                                v
                             |X|-|-|                                               
                             |-|-|-| and list of possible moves (or empty cells) OR Result (winner X, winner Y or draw)                                                                
                             |-|-|-|                                     
                                                |
                                                | action C 
                                                |
                                                v  
                             |X|-|-|                                               
                             |O|-|-| and list of possible moves (or empty cells) OR Result (winner X, winner Y or draw)
                             |-|-|-|                                     
                                                |
                                                | action B 
                                                |
                                                v  
                             |X|-|-|                                               
                             |O|X|-| and list of possible moves (or empty cells) OR Result (winner X, winner Y or draw)
                             |-|-|-|                                     
```                              
Actions (moves) A, B and C either end the game (Winner X, Winner Y or draw), or result in an updated version of the board, a list of still empty cells
and the next actions. To model this we can use a Union case:
```fsharp
type ValidMoves = {
        Moves:List<CellPosition>
    }

type MoveResult = 
    | Win of Player
    | Tie 
    | Move of Player*GameState*ValidMoves
```

Define actions A, B and C as types. Use the UnionCase MoveResult.

*)

(**
### Task 2.2
Implement a function that creates the board. The return value of the function
should be of type MoveResult. Player X should start the game.
Hint: Use lists of all horizontal and vertical positions.

```fsharp
let allHorizontal = [Left;Middle;Right]
let allVertical   = [Top;Center;Bottom] 
```

*)

(**
### Task 2.3
Befor we implement the moves of player X and player Y, we try to anticipate what this function has to do.
The function will manipulate the game. Implement a funtion with a parameter of type Gamestate, a parameter of
type CellPosition and a Parameter of type Player. The return value equals the updated gamestate.

*)

(**
### Task 2.4
Of course, the function has to check if the game has been won by either party.
So we ask the question: how to prove this? The game is over, if one player occupies a column, row
or diagonal completely. Implement a funciton with parameter of type GameState and a parameter of type player.
The function should return true, if the player won the game.
Hint: Use the lists of all possible rows, columns and diagonals:
```fsharp
let rows =
    let makeHLine v = [for h in allHorizontal do yield (h,v)]
    let rows = [for v in allVertical do yield makeHLine v] 
    rows

let columns =
    let makeVLine h = [for v in allVertical do yield (h,v)]
    let columns = [for h in allHorizontal do yield makeVLine h] 
    columns
 
let diagonals =
    let diagonal1 = [Left,Top; Middle,Center; Right,Bottom]
    let diagonal2 = [Left,Bottom; Middle,Center; Right,Top]
    [diagonal1;diagonal2] 
```

*)

(**
### Task 2.5
The game can end as a draw. This is always the case if no one won the game and all cells have a state different from empty. 
Write a function that checks for a draw:

*)

(**
.... With the abstraction done and all these functions at hand, we will finish the game together during the meeting...

*)