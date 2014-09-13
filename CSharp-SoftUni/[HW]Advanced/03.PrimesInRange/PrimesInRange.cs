// Problem 3. Primes in Given Range
// Write a method that calculates all prime numbers
// given range and returns them as list of integers:
// Write a method to print a list of integers. Write 
// a program that enters two integer numbers (each at
// a separate line) and prints all primes in their 
// range, separated by a comma.


using System;
using System.Collections.Generic;

class PrimesInRange
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        //Invoke the IsPrime() method
        List<int> primes = IsPrime(startNumber, endNumber);

        //Print the list
        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }
    }

    public static List<int> IsPrime(int start, int end)
    {
        List<int> primes = new List<int>();

        if (start <2)
        {
            start = 2;
        }

        for (int i = start; i <= end; i++)
        {

            bool isPrime = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}

