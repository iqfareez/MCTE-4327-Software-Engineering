# Exercise 1

## Instruction

- Ask user to input string/message
- Send this string to a function called `Process`
- `Process` function
    - Save the message into the text file called `saved.txt`
- Content of saved.txt
    - Message + Current DateTime
- Add exception handling

## Demo

https://user-images.githubusercontent.com/60868965/227813240-13161711-9166-47ba-9ec8-5bc47f01fb65.mp4

## Steps to reproduce exception

- Run the program
- `saved.txt` file will be created on the same directory level as the program
- Open the file properties, change the permission for Administrator to Deny all.

## Takeways

### `Console.ReadLine()`'s exception

According to the [docs](https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-8.0), the aforementioned method can throws three exception. One of 
them is `ArgumentOutOfRangeException` which is thrown when the number of characters in the next line of characters is greater than `Int32.MaxValue`.

`Int32.MaxValue` is 2,147,483,647. So, (theoritically) if you try to read a line with more than 2,147,483,647 characters, you will get an exception. But, I found it is very difficult 
to reproduce this exception. For context, the [bee movie script](http://www.script-o-rama.com/movie_scripts/a1/bee-movie-script-transcript-seinfeld.html) have 48,111 characters. We need about
44636 more of them to get the exception!

### `using` statement

```csharp
using StreamWriter sw = File.CreateText(filePath);
sw.WriteLine(messageContent);
```
The using statement is a convenient way to ensure that an object is disposed of when it is no longer needed, without requiring explicit calls to the Dispose method. When the using block is exited, the Dispose method is automatically called on the object, releasing any unmanaged resources it may be using.

