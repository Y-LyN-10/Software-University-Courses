// Problem 15. Hexadecimal to Decimal Number
// Using loops write a program that converts a hexadecimal integer 
// number to its decimal form. The input is entered as string. The 
// output should be a variable of type long. Do not use the 
// built-in .NET functionality. 

using System;
using System.Collections.Generic;

class HexToDec
{
    static void Main()
    {
        Console.Write("Hexadecimal: ");
        string hexadecimalNumber = Console.ReadLine().ToUpper();

        ConvertToDecimal(hexadecimalNumber);
    }
    static void ConvertToDecimal(string hexadecimalNumber)
    {
        // This program is the same, like the previous exerise, but we pow the number with '16'.
        // And we need to convert letters 

        long decimalNumber = 0;
        long number = 0;
        long index = hexadecimalNumber.Length - 1;

        List<char> list = new List<char>();

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            list.Add(hexadecimalNumber[i]);

            if (list[i] >= 65 && list[i] <= 70)
            {
                //A = 65, B = 66, etc... (65 -55) = number in 16th numeric system (A = 10, B=11...);
                number = list[i] - 55; 
            }
            else
            {
                number = list[i] - 48; //0 = 48; 1 = 49... etc.   
                
                // This also works:
                // number = (int)Char.GetNumericValue(hexadecimalNumber[i]);
            }

            decimalNumber += number * (long)Math.Pow(16, index);
            index--;
        }

        Console.WriteLine("Decimal:     {1} ", hexadecimalNumber, decimalNumber);
    }
}

