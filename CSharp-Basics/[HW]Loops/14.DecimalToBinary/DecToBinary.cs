// Problem 14. Decimal to Binary Number
// Using loops write a program that converts an integer number to 
// its binary representation. The input is entered as long. The 
// output should be a variable of type string. Do not use the 
// built-in .NET functionality. 

using System;
using System.Collections.Generic;
using System.Text;

class DecToBinary
{
    private static void DecToBin(List<int> binNumber, long input)
    {
        int digit;

        for (int i = 0; i < 32; i++)
        {
            //bitwise check
            if ((digit = (int)input & 1 << i) != 0) binNumber.Add(1);
            else binNumber.Add(0);
        }
    }

    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        //Daclare a list and save all binary digits there.
        List<int> binNumber = new List<int>();

        //Extract the solution in another method.
        DecToBin(binNumber, input);

        // Print the result
        // I used StringBuilder, because I want to save the whole string before printing it
        // In other case, we could just print every [i] and the result would be still right.

        StringBuilder binary = new StringBuilder("");

        for (int i = binNumber.Count - 1; i >= 0; i--)
        {
            binary.Append(binNumber[i]);
        }

        // When the final result is in one string, I can trim the zeroes
        // at the begining and then the output will be exactly like the needed one :)

        string result = binary.ToString().TrimStart('0');
        Console.WriteLine(result);
    }
}
