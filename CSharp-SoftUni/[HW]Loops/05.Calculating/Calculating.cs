// Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
// Write a program that, for a given two integer numbers n and x, 
// calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only 
// one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class Calculating
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("X = ");
        int X = int.Parse(Console.ReadLine());

        double factoriel = 1;
        double totalResult = 1;

        for (int i = 1; i <= N; i++)
        {
            factoriel *= i;
            double result = Math.Pow(X, i);
            totalResult += factoriel / result;
        }

        Console.WriteLine("-----");
        Console.WriteLine("S = {0:F5}", totalResult);
    }
}