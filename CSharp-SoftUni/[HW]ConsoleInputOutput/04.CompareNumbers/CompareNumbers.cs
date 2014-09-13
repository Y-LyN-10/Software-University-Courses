// Problem 4. Number Comparer
// Write a program that gets two numbers from the console and prints 
// the greater of them. Try to implement this without if statements. 
// Examples: 
// a	b	greater
// 5	6	6
// 0	0	0
// -5	-2	-2
// 1.5	1.6	1.6

using System;
using System.Globalization;
using System.Threading;

class CompareNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the first number: ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the second number:");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        decimal greater = Math.Max(a, b);
        Console.WriteLine("The greater of them is {0}", greater);
    }
}
