// Problem 7. Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a
// group of n different elements (also known as the number of combinations) is 
// calculated by the following formula: (N! / (K! * (N-K)!)

// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck
// of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) 
// for given n and k (1 < k < n < 100). Try to use only two loops. 

using System;

class CalcNByFormula
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int nMinusK = N - K;

        int result;
        int factorielOfN = 1;
        int factorielOfK = 1;
        int factorielNSubK = 1;

        for (int i = 1; i <= N; i++)
        {
            factorielOfN *= i;
        }

        for (int i = 1; i <= K; i++)
        {
            factorielOfK *= i;
        }

        for (int i = 1; i <= nMinusK; i++)
        {
            factorielNSubK *= i;
        }

        result = (factorielOfN / (factorielOfK * factorielNSubK));

        Console.WriteLine(result);
    }
}

