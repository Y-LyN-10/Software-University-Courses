// Problem 15.* Age after 10 Years
// Write a program to read your age from the console 
//and print how old you will be after 10 years.

using System;
using System.Globalization;
using System.Threading;

class YourAge
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Title = "Problem 15.*  Age after 10 years";

        Console.WriteLine("Hello! Insert a birth date in format \"Year.Month.Day\"");

        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Now;
        DateTime after10Years = currentDate.AddYears(10);

        int ageAfter = after10Years.Year - birthDate.Year;

        if (currentDate.Month <  birthDate.Month ||
           (currentDate.Month == birthDate.Month &&
                 birthDate.Day < currentDate.Day ))
        {
            ageAfter--;
        }

        Console.WriteLine("By the same date in {0}, " + 
            "man that was born in {1}, should be {2} years old."
            , after10Years.Year, birthDate.Year, ageAfter);

    }
}
