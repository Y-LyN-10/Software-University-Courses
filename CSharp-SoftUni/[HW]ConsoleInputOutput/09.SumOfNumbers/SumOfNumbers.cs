// Problem 9. Sum of n Numbers
// Write a program that enters a number n and after that 
// enters more n numbers and calculates and prints their sum. 
// Note that you may need to use a for-loop. 
// Example: numbers = 3, 20, 60, 10; sum = 90

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers you want to sum?");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            sum += inputNumber;   
        }

        Console.WriteLine("----------");
        Console.WriteLine("Total sum: " + sum);
    }
}
