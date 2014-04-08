// Problem 7. Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a
// group of n different elements (also known as the number of combinations) is 
// calculated by the following formula: (N! / (K! * (N-K)!)

// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck
// of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) 
// for given n and k (1 < k < n < 100). Try to use only two loops. 

using System;
using System.Numerics;

class CalcNByFormula
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger K = BigInteger.Parse(Console.ReadLine());
        BigInteger nMinusK = N - K;

        BigInteger result;
        BigInteger factorielOfN = 1;
        BigInteger factorielOfK = 1;
        BigInteger factorielNSubK = 1;

        for (int i = 1; i <= N; i++)
        {
            if (i <= K)
            {
                factorielOfK *= i;
            }
            if (i <= (N-K))
            {
                factorielNSubK *= i;
            }
            factorielOfN *= i;
        }

        result = factorielOfN / (factorielOfK * factorielNSubK);
        Console.WriteLine(result);
    }
}

