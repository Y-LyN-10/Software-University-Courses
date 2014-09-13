// Problem 8. Numbers from 1 to n
// Write a program that reads an integer number n from the console 
// and prints all the numbers in the interval [1..n], each on a  
// single line. Note that you may need to use a for-loop. 
// Example: numbers = 3, sum = 1, 2, 3; 

using System;

class NumbersToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

