// Problem 8. Square Root
// Create a console application that calculates  
// and prints the square root of the number 12345. 
// Find in Internet “how to calculate square root in C#”.

using System;

class PrintSQRT
{
    static void Main()
    {
        Console.Title = "Problem 8. Square Root";
       
        double calculateSquareRoot = Math.Sqrt(12345);
        Console.WriteLine("Square root of 12345 is " + calculateSquareRoot);
    }
}
