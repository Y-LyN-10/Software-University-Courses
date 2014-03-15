// Problem 1. Sum of 3 Integers
// Write a program that reads 3 integer numbers from 
// the console and prints their sum. Examples: 
// a = 3,   b = 4,   c = 11,    sum = 18;
// a = 5.5,	b = 4.5, c = 20.1,	sum = 30.1

using System;
using System.Globalization;
using System.Threading;

class SumIntegers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = (firstNumber + secondNumber) + thirdNumber;

        Console.WriteLine("----------\nTotal sum: " + sum);
    }
}

