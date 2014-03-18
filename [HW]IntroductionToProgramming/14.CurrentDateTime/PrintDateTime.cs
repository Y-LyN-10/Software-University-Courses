// Problem 14.* Current Date and Time
// Create a console application that prints the current date and time. Find in Internet how.

using System;
using System.Text;

class CurrentDateTime
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
        Console.Title = "Problem 14.* Current Date and Time";

        string currentTime = DateTime.Now.ToString("F");
        Console.WriteLine("Current Date and Time is: " + currentTime);

        //More about DateTime struct here --> http://www.dotnetperls.com/datetime 
    }
}
