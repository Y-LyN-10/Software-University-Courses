// Problem 3. Min, Max, Sum and Average of N Numbers
// Write a program that reads from the console a sequence of n integer 
// numbers and returns the minimal, the maximal number, the sum and the 
// average of all numbers (displayed with 2 digits after the decimal point). 
// The input starts by the number n (alone in a line) followed by n lines, 
// each holding an integer number. The output is like in the examples below.

using System;
using System.Linq;

class MinMaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        long sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());   
            sum += numbers[i];
        }

        Array.Sort(numbers); //sorts numbers in ascending order

        Console.WriteLine("min = {0}", numbers[0]);
        Console.WriteLine("max = {0}", numbers[numbers.Length-1]);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", numbers.Average()); //using Linq required
    }
}

