# TryParse


+ `int.TryParse(text, out number)` tries to turn a string to an int **without crashing**
+ It **returns a bool**: `true` if the text was a number, `false` if it wasn't 
+ The number comes back through the **out** variable. If it failed, that variable will be `0`

# Methods

static void SayHi()
^       ^   ^     ^
1       2   3     4

1. **static**: belonds to the program, not an object.
2. **return type**: what the method hands back. `void` means nothing
3. **name**: what you type to call it. Capitalized, like `Console.ReadLine();`
4. **parameters**: the inputs inside the parentheses. Empty means it needs nothing