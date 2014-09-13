using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());

        BigInteger result = Fib(firstNum, secondNum, thirdNum, numberN);
        Console.WriteLine(result);
    }

    private static BigInteger Fib(BigInteger firstNum, BigInteger secondNum, BigInteger thirdNum, BigInteger numberN)
    {
        BigInteger nextNum;

        if (numberN == 1) return firstNum;
        if (numberN == 2) return secondNum;
        if (numberN == 3) return thirdNum;
        else
        {
            for (BigInteger i = 4; i <= numberN; i++)
            {
                nextNum = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = nextNum;

                if (i == numberN)
                {
                    return nextNum;
                }
            }
        }
        return 0;
    }

}

