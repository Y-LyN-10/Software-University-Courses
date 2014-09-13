// Problem 8. Catalan Numbers
// In combinatorics, the Catalan numbers are calculated by the following formula:
// C = 1/(n+1)*(2*n / n) = (2*n)!/((n+1)!n!) = П((n+k)/k) for n>= 0
// Write a program to calculate the nth Catalan number by given n (1 < n < 100). 

using System;

class Catalan
{
    static void Main()
    {
        Console.Write("Give me a number for 'n', please:  ");
        int n = int.Parse(Console.ReadLine());

        int middleProduct = 1;
        decimal product = 1;

        int nPlusOne = n + 1;
        for (int i = 2 * n; i > nPlusOne; i--)
        {
            middleProduct *= i;
        }
        product *= middleProduct;
        for (int i = 1; i <= n; i++)
        {
            product /= i;
        }

        Console.WriteLine("(2n)! / (n + 1)! * n! = {0}", product);   
    }
}

