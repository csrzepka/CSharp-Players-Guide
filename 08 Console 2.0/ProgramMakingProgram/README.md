# Program-Making Program

This is a challenge from [The C# Player's Guide by RB Whitaker, 5e](https://csharpplayersguide.com/). It is from Level 8 *Console 2.0* that explores the `System.Console` class to work with the console. This specific challenge is part of the [5th Edition Expansions](https://csharpplayersguide.com/expansions/), from the [C# 11 Expansion](https://rbwhitaker.gumroad.com/l/csharp11expansion) that introduces new C# 11 features. The expansion for level 8 introduces [Raw String Literals](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string).

Below is the challenge description:

## Challenge: Program-Making Program [100 XP]
You think back to the program you made for the triangle farmer, which computed the area of a triangle given its width and height. But you're unsettled about two things: (1) you want to specify different units like meters, feet, or lightyears, and (2) you may want to uase different types like `int`, `float`, and `double`. You have an idea: what if you made a program to write a triangle farmer program for you, where you specify the units and the C# type you want to use and then embed those into a raw string literal to generate the code for you?

**Objectives**:
- **Note**: This program is very "meta." You will have actual C# code, and you will have a string that contains C# code inside it. It will look a little strange, but that's what comes with the territory for code generators.
- Create a program that asks for two inputs: the units to use (for example, "meters", "feet", or "lightyears") and a C# type (like "int", "float", and "decimal"). **Note**: You do not need to check that these are valid. Trust the user to pick a good unit and C# type.
- Use a multi-line raw string literal with interpolation to produce and display the following program, filling in the placeholders with the text the user entered in the previous bullet point.
```csharp
Console.WriteLine("Enter the width (in [UNITS]) of the triangle: ");
[TYPE] width = [TYPE].Parse(Console.ReadLine());
Console.WriteLine("Enter the height (in [UNITS]) of the triangle: ");
[TYPE] height = [TYPE].Parse(Console.ReadLine());
[TYPE] result = width * height / 2;
Console.WriteLine($"{result} square [UNITS]");
```
- **Note**: You must modify the text above to make it work. The above is illustrative, not the actual text to put into a raw string literal.
- Run the program and enter good values for the units and type. Copy the output into a new program and run the generated program, now with your chosen units and C# type.
- **Note**: Your program does not need to run the final string. C# can execute arbitrary text as code, but it is tricky (and not secure). Take the text and copy/paste it into another program yourself.

***

The included C# project is my solution to this challenge. The author's solution is available with the download of the C# 11 expansion, and will not be provided here.
