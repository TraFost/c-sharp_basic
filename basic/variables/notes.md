````markdown
# Using Variables in C#

## Rules for Naming Variables

1. Variables in C# are case-sensitive (because it takes after the C style language / Language inheritance).
2. Variables in C# have to start with a type, name, and value.
3. Variables in C# have to be declared before they can be used.
4. Variables in C# need to start with a letter or an underscore.

## Declaring Variables

### Example 1

```csharp
string name = "John";
```
````

### Example 2: Multiple Variables

```csharp
string name = "John", lastName = "Doe";
```

### Example 3: Multiple Variables with the Same Type

```csharp
string name = "John", lastName = "Doe", fullName = name + " " + lastName;
```

### Example 4: Declaring a Variable without Initializing It

```csharp
string name;
string FirstName, LastName; // you can declare multiple variables in one line
```

### Example 5: Declaring a Constant Variable

```csharp
const string name = "John";
```

## Types of Variables in C#

1. `int` = integer (whole number) - 1, 2, 3, 4, 5 // 32-bit
2. `double` = decimal number (larger precision) - 1.1, 2.2, 3.3, 4.4, 5.5 << ~15 digits // 64-bit
3. `float` = decimal number (small precision) - 1.1, 2.2, 3.3, 4.4, 5.5(f) << ~7 digits // 32-bit
4. `bool` = boolean (true or false) - true, false
5. `string` = text - "Hello World"
6. `char` = single character - 'a', 'b', 'c'

## Float and Double

1. `float` is a 32-bit number with a precision of 7 digits, while `double` is a 64-bit number with a precision of 15-16 digits.
2. `float` is faster than `double`, but `double` is more precise.
3. Use `float` if you need to save memory, use `double` if you need more precision.
4. While using `float`, you need to specify the suffix (f) otherwise it will be considered as `double`.
5. `float` is more suitable for small numbers, `double` is more suitable for large numbers.
6. If we're doing graphics/game development, we should use `float` (aligns with Unity practices) << will dig it later.
7. If we're doing financial calculations/precision-critical work, we should use `double` << will dig it later.

## Char and String

1. `char` is a single character, while `string` is a sequence of characters.
2. `char` is enclosed in single quotes (''), while `string` is enclosed in double quotes ("").
3. `char` data type is a value type, while `string` data type is a reference type. << will dig it later.
4. `char` length is only 1, while `string` is unlimited.
5. Use `string` if you want to store/manipulate text (e.g., words, sentences, paragraphs).
6. Use `char` if you want to store a single character (e.g., checking for a specific character, input validation).

## Extra Tips

1. You can use the `var` keyword to declare a variable without specifying the type.
2. You can use the `dynamic` keyword to declare a variable that can change its type.
3. You can use the `object` keyword to declare a variable that can store any type of value.
4. Implicit casting is done automatically by the compiler, while explicit casting is done manually by the programmer.
5. Implicit casting is done when there is no data loss, e.g., `int` > `float` / `float` > `double`.
6. Explicit casting is done when there is data loss, e.g., `double` > `float` / `float` > `int`.
