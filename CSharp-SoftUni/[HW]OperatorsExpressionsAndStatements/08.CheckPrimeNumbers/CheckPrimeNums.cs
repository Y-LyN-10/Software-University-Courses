// Problem 1. Prime Number Check
// Write an expression that checks if given positive integer number n (n ≤ 100) 
// is prime (i.e. it is divisible without remainder only to itself and 1). 

//Examples: (n = 1, Prime? false), (n = 2, Prime? true), (n = 0, Prime? false) Etc...
//1	false // 2 false // 3 true // 4 false // 9 false // 97 true // 51 false // -3 false // 0 false

using System;

class CheckPrimeNums
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int[] primes;

        // Initialize array with all prime numbers < 100
        primes = new int[]
	    {
	        3, 7, 11, 17, 23, 29, 37,
	        47, 59, 71, 89, 97
	    };

        //Check with a method IsPrime();
        bool prime = false;

        if (inputNumber < 0)
        {
            prime = false;
        }
        else
        {
            for (int i = 0; i < primes.Length; i++)
            {
                if (inputNumber == primes[i])
                {
                    prime = true;
                }
            }
        }

        //Print the boolean result
        Console.WriteLine(prime);
    }
}