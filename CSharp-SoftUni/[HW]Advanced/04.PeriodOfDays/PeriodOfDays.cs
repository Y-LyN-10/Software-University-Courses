// Problem 4.	Difference between Dates
// Write a program that enters two dates in format dd.MM.yyyy 
// and returns the number of days between them. Examples:
// First date = 17.03.2014; Second date = 30.04.2014; Days between = 44

using System;

class PeriodOfDays
{
    static void Main()
    {
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        DateTime endDay = DateTime.Parse(Console.ReadLine());
        double days = CountDays(startDate, endDay);

        Console.WriteLine("Days between: {0}", days);
    }

    private static double CountDays(DateTime start, DateTime end)
    {
        TimeSpan span = end - start;
        double result = span.TotalDays;

        return result;
    }
}

