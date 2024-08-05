

### Painting a Wall

**Painting a Wall Covered with Tiles**

Consider a wall of length \( n \), where the height of position \( i \) is \( a \). We want to paint this wall using a number of disposable rollers, each one having a width of 1. Each roller can be applied either vertically or horizontally on the wall's tiles, but once we lift the roller off the wall, it becomes unusable. Additionally, painted bricks can be repainted. For example, consider a wall of length 6 with heights \([2, 2, 1, 2, 4, 2]\). To paint this wall, a minimum of 4 rollers are required.

**A Sample Wall**

Write a program that finds the minimum number of rollers needed to paint the wall using a divide-and-conquer approach.

Note that a roller cannot paint both horizontally and vertically, so two different rollers are needed for this task. (Hint: We only use the horizontal roller if the rows below it are also painted horizontally).

### Input
On the first line, the input \( n \) will indicate the length of the wall. On the next line, \( n \) numbers will describe the heights of the wall.

### Output
The minimum number of rollers required to paint the wall.

**Very Important Note**: There is no need to use a file to read the input or print the output. Read the numbers directly from the console and print your result in the console. However, remember that no text or explanation should be printed in the console by your program.

### Examples
Here are a few sample inputs and outputs for better understanding of the question format.

**Sample Input 1**
```
6
2 2 1 2 4 2
```
**Sample Output 1**
```
4
```
**Sample Input 2**
```
1
5
```
**Sample Output 2**
```
1
```
**Sample Input 3**
```
5
2 1 2 2 1
```
**Sample Output 3**
```
3
```
