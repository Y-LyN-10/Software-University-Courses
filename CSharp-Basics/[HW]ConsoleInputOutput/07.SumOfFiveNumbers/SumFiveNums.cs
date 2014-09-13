// Problem 7. Sum of 5 Numbers
// Write a program that enters 5 numbers (given in a single line, 
// separated by a space), calculates and prints their sum. 
// Examples:
// numbers  	         sum	
// 1 2 3 4 5	          15					
// 1.5 3.14 8.2 -1 0    11.84

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfFiveNums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please, write 5 numbers separated by a space: ");
        var numbers = Console.ReadLine().Split().Take(5);

        Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
        double sum = digits.Sum();

        Console.WriteLine("The sum is: " + sum);
    }
}

