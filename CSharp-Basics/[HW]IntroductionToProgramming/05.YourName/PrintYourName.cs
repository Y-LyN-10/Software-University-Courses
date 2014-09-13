// Problem 5. Print Your Name
// Modify the previous application to print your name. 
// Ensure you have named the application well (e.g. “PrintMyName”).

using System;

class PrintYourName
{
    static void Main()
    {
        Console.Title = "Problem 5.	 Print Your Name";
        Console.WriteLine("Hello! What is your name?");
        
        string yourName = Console.ReadLine();
        Console.WriteLine("Nice to meet you, {0}! ", yourName );
    }
}