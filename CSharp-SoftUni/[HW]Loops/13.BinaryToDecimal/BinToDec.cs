// Problem 13. Binary to Decimal Number
// Using loops write a program that converts a binary integer 
// number to its decimal form. The input is entered as string. 
// The output should be a variable of type long. Do not use 
// the built-in .NET functionality. 

using System;
using System.Collections.Generic;

class BinToDec
{
    static void Main()
    {
        //To convert a binary number into decimal numeric system, we should pow
        //every digit to 2 in the exponent in which position the number is. And sum all results.

        Console.Write("Binary:  ");
        string binary = Console.ReadLine().ToString().TrimStart('0');

        long decNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            //this skips zeroes in the formula below.
            if (binary[binary.Length - i - 1] == '0')
            {
                continue; 
            }

            decNumber += (long)Math.Pow(2, i);
        }

        Console.WriteLine("Decimal: {0}", decNumber);

    }
}
