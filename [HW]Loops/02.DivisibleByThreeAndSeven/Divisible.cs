// Problem 2. Numbers Not Divisible by 3 and 7
// Write a program that enters from the console a positive integer n and prints all 
// the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
// Example: n = 10, Output: 1 2 4 5 8 10

using System;

class Dividable
{
    static void Main()
    {
        Console.Write("n =  ");
        uint n = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= n; i++)
        {
            bool divisible = (i % 3 == 0) || (i % 7 == 0);
            if (!divisible) Console.Write(i + " ");
        }
    }
}
