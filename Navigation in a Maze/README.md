** Navigation in a Maze**

**Part One**

You are trapped in a maze and want to get from your starting point (house **S**) to the exit (house **T**). If we consider the maze as an \( n \times n \) grid, the entry and exit can be any of the cells in the maze. In each move, you can go to any of the adjacent cells (that is, the cell above, below, left, or right).

**Notes about the maze cells:**

- Some cells in the maze are blocked with obstacles (cells marked as **B**) that cannot be crossed.
- Some cells have traps (cells marked as **X**) in which you become trapped, and it takes \( k \) seconds to free yourself from these traps. Thus, in general, it takes 1 second to move through normal cells, and \( k + 1 \) seconds to move through trap cells and free yourself.

**Part Two**

In addition to you, there is another person trapped in the maze who starts at another cell (house **A**) and also wants to reach the exit (house **T**). This person, apparently, has a special power that allows them to escape from trap cells without spending any extra time. In other words, if this person enters a trap cell (the **X** cells), they can move through them in 1 second without any time spent escaping, so for them \( k = 0 \). However, they still require 1 second to enter any cell (whether it is a trap or not).

Write a program using graph algorithms to calculate the shortest time for you to get from **S** to **T** (using algorithms like Dijkstra) and also the shortest time for the other person to reach **T** from **A** (using algorithms like DFS and BFS).

**Input**

In the first line of input, the number \( n \) indicating the grid dimensions is provided along with the number \( k \) which indicates the time required to escape from a trap.

In the next \( n \) lines, a representation of the maze is given. Each line represents one of the rows of the grid. In this grid, your starting cell is **S**, the other person's starting cell is **A**, and the exit cell is **T**. Blocked cells are represented by **B**, normal cells by **O**, and trap cells by **X**. (The cells **A**, **S**, and **T** are also considered normal and can be crossed.)

**Output**

The output of the program should contain two lines, printing first the shortest time needed for you to reach cell **T** and second the shortest time for the other person to reach cell **T**.

**Examples:**

**Example Input 1**
```
3 4
SOA
BOB
TXO
```
**Example Output 1**
```
8
4
```

**Example Input 2**
```
5 6
SAOOO
XBBBO
XBBBO
XBBBO
TOOOO
```
**Example Output 2**
```
12
5
```

**Example Input 3**
```
6 3
OTBBBB
OBSBBB
OXOOXX
OBOBBX
OOOBBX
BBOOOA
```
**Example Output 3**
```
9
11
```

