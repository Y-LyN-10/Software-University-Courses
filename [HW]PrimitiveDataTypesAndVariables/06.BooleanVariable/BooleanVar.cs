// Problem 5. Boolean Variable
// Declare a Boolean variable called isFemale and assign an appropriate 
// value corresponding to your gender. Print it on the console.

using System;

class BooleanVar
{
    static void Main()
    {
        Console.Title = "Problem 5. Boolean Variable";

        bool isFemale = true;
        Console.WriteLine("My gender is {0}.", isFemale? "female" : "male" );

        // I used a condition operator (?:) to print the result.
        // You can read more about it here: http://msdn.microsoft.com/en-us/library/ty67wk28.aspx
    }
}

