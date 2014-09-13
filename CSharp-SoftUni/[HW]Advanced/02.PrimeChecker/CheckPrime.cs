// Problem 2. Prime Checker
// Write a Boolean method IsPrime(n) that check whether 
// a given integer number n is prime. Examples: 
// n = 5. IsPrime(n) = true; n = 323, IsPrime(n) = false

using System;
using System.Numerics;

class CheckPrime
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

        //Check with a method IsPrime();
        bool prime = IsPrime(inputNumber);

        //Print the boolean result
        Console.WriteLine(prime);
    }

    public static bool IsPrime(BigInteger candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        for (BigInteger i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}

