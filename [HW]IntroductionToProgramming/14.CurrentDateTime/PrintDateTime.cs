// Problem 14.* Current Date and Time
// Create a console application that prints the current date and time. Find in Internet how.

using System;

class CurrentDateTime
{
    static void Main()
    {
        Console.Title = "Problem 14.* Current Date and Time";
        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Current Date and Time is: " + currentTime);

        //Or just
        //Console.WriteLine("Current Date and Time is: " + DateTime.Now);

        //More about DateTime struct here --> http://www.dotnetperls.com/datetime 
    }
}
