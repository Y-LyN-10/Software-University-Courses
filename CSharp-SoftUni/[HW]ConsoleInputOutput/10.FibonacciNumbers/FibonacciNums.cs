// Problem 10. Fibonacci Numbers
// Write a program that reads a number n and prints on the console 
// the first n members of the Fibonacci sequence (at a single line, 
// separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
// Note that you may need to learn how to use loops. 
// Example: n = 1, comments = 0; n = 3, comments = 0 1 1; etc...

using System;
using System.Numerics;

class FibonacciNums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger nextNum;

        Console.Write(firstNum + " " + secondNum + " ");

        for (int i = 0; i <= n; i++)
        {
            nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;

            Console.Write(nextNum + " ");
        }
    }
}

