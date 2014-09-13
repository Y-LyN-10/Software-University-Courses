// Problem 9. Matrix of Numbers
// Write a program that reads from the console a positive 
// integer number n (1 ≤ n ≤ 20) and prints a matrix like 
// in the examples below. Use two nested loops. 

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(0, 0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 1 + i; j <= n+i; j++)
            {
                //No, I am not a patriot. I'm just tired of all these same numbers...
                if (i == n/3) Console.ForegroundColor = ConsoleColor.Green;
                if (i == n/3 + n/3) Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(j.ToString().PadRight(3));
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}
