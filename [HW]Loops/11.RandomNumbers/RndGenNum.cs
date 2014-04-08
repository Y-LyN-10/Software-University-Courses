// Problem 11. Random Numbers in Given Range
// Write a program that enters 3 integers n, min and max (min ≤ max) 
// and prints n random numbers in the range [min...max]. 

using System;

class RndGenNum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int numbers = 1; numbers <= n; numbers++)
        {
            Console.Write(rand.Next(min, max+1) + " ");
        }
    }
}

