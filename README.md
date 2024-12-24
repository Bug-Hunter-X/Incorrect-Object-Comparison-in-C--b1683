# Incorrect Object Comparison in C#

This repository demonstrates a common mistake in C# when comparing objects using the == operator. The code compares two objects of the same class with the same value but shows they are not equal. This is because == operator compares object references instead of comparing object values. 

## How to Reproduce

1. Clone this repository.
2. Open the `bug.cs` file.
3. Run the code. Observe that the output is "Objects are not equal".

## Solution

To solve this problem, the `bugSolution.cs` file shows the correct way to compare objects' values using `Equals()` or by explicitly comparing their properties.