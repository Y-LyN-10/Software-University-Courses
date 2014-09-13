/* Problem 4.	Hello World
   Create, compile and run a “Hello C#” console application. 
   Ensure you have named the application well (e.g. “”HelloCSharp”). */

class HelloCSharp
{
    static void Main()
    {
        System.Console.Title = "Problem 4. Hello World";
        System.Console.WriteLine("Hello C#!");
    }
}

// System.Console.WriteLine() is the same like if we write 
// "using System" and "Console.WriteLine()". 
// It's good if we need this "using" only once... ot twice ;)