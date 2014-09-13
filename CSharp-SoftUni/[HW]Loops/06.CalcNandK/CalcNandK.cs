// Problem 6. Calculate N! / K!
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

using System;
using System.Globalization;
using System.Threading;

class CalcNandK
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        int factorielOfN = 1;
        int factorielOfK = 1;
        
        int result;

        for (int i = 1; i <= N; i++)
        {
            factorielOfN *= i;
        }

        for (int i = 1; i <= K; i++)
        {
            factorielOfK *= i;
        }


        result = (factorielOfN / factorielOfK);

        Console.WriteLine(result);
    }
}
