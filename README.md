![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

# `MCTE 4327` Software Engineering

## Table of Contents

- [Chapter 1 - Introduction](#chapter-1---introduction)
- [Chapter 2 - Software Engineering Principles](#chapter-2---software-engineering-principles)
- [Chapter 3 - Primitive Data Types](#chapter-3---primitive-data-types)

## Chapter 1 - Introduction

<img src="https://imgs.xkcd.com/comics/abstraction.png" width="45%">

> Software is just a collection of instruction, to make a rock doing something useful.

In other words, **software** is **a collections of computer instruction that tell the hardware how to perform the task.**

Meanwhile, **hardware** is the physical matter that run the software.

### Programming languages

Modern programming languages, like C#, Python, Dart etc, are built on top of lower level programming languages.

#### Machine language

- Machine language is a low-level programming language that uses the binary numerals or hex to program computers.
- **Native language** of a particular processor architecture. Talks directly to the bare metal. Human barely can understand them.
- Processor dependent: a program written in one processor's machine language will not work on another processor without translation.
- Machine language is sometimes called **machine code** or **binary code**.

#### Assembly language

- Low-level programming language for a computer, or other programmable device.
- Each assembly language is specific to a particular computer architecture.
- Some syntax are understandable by human, but hardly to program it.
- It uses assembler to translate the assembly language into machine language.

#### C# language

- C# is a general-purpose, multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.
- Developed by Microsoft within its [.NET](https://dotnet.microsoft.com/en-us/) initiative and later approved as a standard by Ecma ([ECMA-334](https://www.ecma-international.org/publications-and-standards/standards/ecma-334/)) and ISO ([ISO/IEC 23270:2018](https://www.iso.org/standard/75178.html)).

### Operating System

![os](https://imgur.com/nLBtlRU.png)

- An operating system (OS) is system software that manages computer hardware and software resources and provides common services for computer programs.
- Provide API for the application to interact with the hardware.

### Takeaways

- Modern programming languages built on multiple layers of abstraction.
- The lower the level of abstraction, the **easier to talk to the bare metal**.
- The higher the level of abstraction, the **easier to understand by human and job can be done faster.**

**[⬆ Back to top](#mcte-4327-software-engineering)**

## Chapter 2 - Software Engineering Principles

<img src="https://user-images.githubusercontent.com/60868965/226318675-cad05c23-8e77-4d97-a68d-ea7cffc3801f.png" width="55%">

### Definition

```mermaid
mindmap
  root((Software))
    Sofware need to be engineered
    Software doesn't wear out, but detoriate over time
    Software is complex
```

### Sofware rot

~ is low detoriation of software performance over time or its deminishing responsiveness. Example of software rot is when a software is not maintained and updated, or change in environment _(eg: Windows XP to Windows 10, though, I've heard that Microsoft will keep as much backward compatibility as possible)_.

Some companies may have plan to deprecate the software after some times. For example, Microsoft have declared [End of Life (EOL) for Windows 7 and Windows 8.1](https://www.microsoft.com/en-us/windows/end-of-support) in favor of the newer versions of Windows. [Here](https://helpx.adobe.com/my_en/support/programs/eol-matrix.html) is another example of Adobe software that also have been declared end of support.

### Software release lifecycle

```mermaid
graph LR
subgraph Testing
PA[Pre-Alpha] --> A[Alpha]
A --> B[Beta]
B --> RC[RC]
end
subgraph Release
RC --> RTM[RTM]
RTM --> D[GA/Stable]
end
```

| Phase                               | Description                                                                                                                                   |
| ----------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| Pre-Alpha                           | The earliest stage of development where the software is not yet feature-complete and may be unstable or unusable. Tested internally           |
| Alpha                               | The software has basic functionality but may still have significant bugs or issues. Also tested internally                                    |
| Beta                                | The software is feature-complete and released to a limited audience for further testing and feedback. Start to test publicly                  |
| Release Candidate (RC)              | A version of the software that is intended to be very close to the final version, bug fixing may be needed before the official release.       |
| Release To Manufacturing (RTM)      | A term used primarily in software development for the commercial release of a product to the market. _(It's my first time knowing this term)_ |
| General Availability (GA) or Stable | The official release of the software that is considered stable and ready for general use.                                                     |

> **Info** The product MVP (Minimum Viable Product) is typically developed and released during the Alpha or Beta stages of the software release lifecycle.

You can see the example of the release process in many OSS, for example, in the [arduino-ide](https://github.com/arduino/arduino-ide/releases) development. Notice that, they started to release **beta** version publicly in the [`2.0.0-beta.1`](https://github.com/arduino/arduino-ide/releases/tag/2.0.0-beta.1) on 12 Feb 2021. After `beta.12`, they move to **RC** stages begin with [`2.0.0-rc1`](https://github.com/arduino/arduino-ide/releases/tag/2.0.0-rc1). Finally, the release the **stable** version [`2.0.0`](https://github.com/arduino/arduino-ide/releases/tag/2.0.0) on 14 September 2022. _Oh btw, software versioning is another interested topic to learn._

### Software Development Lifecycle (SDLC)

#### In general

```mermaid
graph LR
subgraph Planning
P[Planning] --> R[Requirements]
R --> D[Design]
end
subgraph Development
D --> C[Code]
C --> T[Test]
end
subgraph Deployment
T --> I[Install]
I --> M[Maintenance]
end
```

**[⬆ Back to top](#mcte-4327-software-engineering)**

## Chapter 3 - Primitive Data Types

<img src="https://user-images.githubusercontent.com/60868965/226317881-e8aac398-dbf3-483e-a7f5-35c57a80cada.png" width="40%">

### Built in types

Below are some examples:

- `int` - 32-bit signed integer
- `double` - 64-bit floating point number
- `char` - 16-bit Unicode character
- `bool` - Boolean value

Read more on [docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)

### Reference VS Value Types

**Value types** are types that _hold their values_ directly and are stored on the stack. Usually **doesn't require** a `new` keyword to declare the value. [[Docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)]

**Reference types**, _hold a reference_ to a memory location where the actual data is stored on the heap. Usually **requires** a `new` keyword to create an instance of the type. [[Docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)]

![reference type](https://www.tutorialsteacher.com/Content/images/csharp/raference-type-memory-allocation.png)

Example of value and reference types:

```mermaid
graph TB
V[Value types] --> A[int]
V[Value types] --> B[bool]
V[Value types] --> C[char]
V[Value types] --> D[float]
V[Value types] --> G[enum]
V[Value types] --> H[struct]

R[Reference types] --> I[string]
R[Reference types] --> J[object]
R[Reference types] --> K[array]
R[Reference types] --> L[delegate]
```

Example:

Assume `Coordinate` is a Class

```csharp
var pos1 = new Coordinate(101.2, 3.14);
var pos2 = pos1;

pos1.latitude = 300.2;

Console.WriteLine(pos1); // 300.2,3.14
Console.WriteLine(pos2); // 300.2,3.14
```

Since we have `pos2 = pos1`, `pos2` is a reference to `pos1`. So, when we change the value of `pos1`, `pos2` will also change.

Now, tet's change the `Coordinate` object from `Class` to a `struct`. Now, both value are independent. Changes with `pos1` will not affect `pos2`.

```csharp
...
Console.WriteLine(pos1); // 300.2,3.14
Console.WriteLine(pos2); // 101.2,3.14
```

### `var` keyword

The `var` keyword is used to declare a variable of a type that is inferred from the value of the expression on the right side of the assignment operator. [[Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var)]

```csharp
var a = 10; // a is an int
var b = 10.5; // b is a double
var c = "Hello World UwU"; // c is a string
```

### Arrays

An array is a data structure that contains a group of elements of the same type. [[Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)]

Example:

```csharp
int[] foo = new int[5]; // declare an array of 5 integers
foo[0] = 1;
foo[1] = 2;
foo[2] = 3;
foo[3] = 4;
foo[4] = 5;
```

or you can do it in one line:

```csharp
int[] foo = new int[5] {1, 2, 3, 4, 5};
```

### Iteration Statements

#### for-loop

The `for` loop is used to iterate a part of the program several times. [[Docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement)]

Take the array example above, we can use `for` loop to iterate through the array:

```csharp
for (int i = 0; i < foo.Length; i++)
{
    Console.WriteLine(foo[i]);
}
```

#### foreach-loop

The `foreach` loop is used to iterate through the elements of a collection. [[Docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement)]

```csharp
foreach (int i in foo)
{
    Console.WriteLine(i);
}
```

#### Takeways

`for` loop allows us to access the array element and modify it (if we wanted to). Meanwhile, `foreach` loop only allows us to read the array element but not modify it.

### Default value

The default value of a variable is the value that is assigned to it when it is declared. The default value of a variable depends on the type of the variable. [[Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default-values-table)]

```csharp
int a; // a is 0
double b; // b is 0
string c; // c is null
bool d; // d is false
```

> **Note** Any reference type will default to `null` if not initialized.

Note that the default value only be asssigned for **member variables** of a class/struct. Local variables must be initialized before use. See example code [here](https://github.com/iqfareez/MCTE-4327-Software-Engineering/blob/5d5a92e36ccd41a626d050fe8621395982756b2f/ConsoleApp1-2032023/ConsoleApp1-2032023/Program.cs#L112-L123).

For example, consider the code below:

```csharp
static void Main(string[] args)
{
    int a;
    Console.WriteLine(a);
}
```

The code above will yield an error: `Use of unassigned local variable 'a'`.

Let's consider another example:

```csharp
class Meow
{
    public int a;
}

class Program
{
    static void Main(string[] args)
    {
        var meow = new Meow();
        Console.WriteLine(meow.a); // 0
    }
}
```

This time, the uninitialized variable `a` will be assigned the default value of `0`. No error will be thrown.

### Anonymous Types

Anonymous types are used to create an object without having to explicitly define a type. [[Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/anonymous-types)]

```csharp
var kuceng = new { Name = "comot", Age = 4 };
Console.WriteLine(kuceng.toString()); // { Name = comot, Age = 4 }
```

However, anonymous types are **immutable**. You cannot change the value of the properties of an anonymous type.

```csharp
kuceng.Name = "mikail"; // error
```

### Methods

Methods? Oh, when a **function** is a part of a class, it's called a **method**.

> C# is an OOP language and doesn't have functions that are declared outside of classes, that's why all functions in C# are actually methods.
> Though, beside this formal difference, they are the same...

A method is a block of code that performs a specific task. [[Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)]

#### Basic method

```csharp
private static void PrintHello()
{
    Console.WriteLine("Hello world");
}
```

#### Method with return value

```csharp
private static int AddNumber(int a, int b)
{
    return a + b;
}
```

#### Method with multiple return values (Tuple)

```csharp
static (string, int) LookupCat()
{
    return ("Cicik", 12);
}

// you can 'unpack' the tuple value:
(string catName, int catAge) = LookupCat();
Console.WriteLine(catName); // Cicik
Console.WriteLine(catAge); // 12
```

**[⬆ Back to top](#mcte-4327-software-engineering)**

<!-- ## Chapter 4 - Object Oriented Programming -->

<!-- ## Chapter 12 - Software Security

![xkcd security](https://imgs.xkcd.com/comics/security.png) -->
