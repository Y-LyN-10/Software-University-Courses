using System;

class StringsAndObjects
{
    static void Main()
    {
        Console.Title = "Problem 6. Strings and Objects";

        // Declare two string variables and assign them with “Hello” and “World”. 
        string hello = "Hello";
        string world = "World";

        // Declare an object variable and assign it with the concatenation of the 
        // first two variables (mind adding an interval between). 
        object helloWorld = hello + " " + world;

        // Declare a third string variable and initialize it with the value of 
        // the object variable (you should perform type casting).
        string printHelloWorld = helloWorld.ToString();

        //Print the final string:
        Console.WriteLine(printHelloWorld);
    }
}

