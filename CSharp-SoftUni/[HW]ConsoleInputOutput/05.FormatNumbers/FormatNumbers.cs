// Problem 5. Formatting Numbers
// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a 
// floating-point c and prints them in 4 virtual columns on the console. Each column should 
// have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; 
// then the number a should be printed in binary form, padded with zeroes, then the number b 
// should be printed with 2 digits after the decimal point, right aligned; the number c should 
// be printed with 3 digits after the decimal point, left aligned. 
// Examples:
// a	| b	       |    C    |	            result                       |
// 254	| 11.6	   |   0.5	 |FE        |0011111110|     11.60|0.500     |
// 499	| -0.5559  |  10000	 |1F3       |0111110011|     -0.56|10000     |
// 0	| 3	       | -0.1234 | 0        |0000000000|         3|-0.123    |

using System;
using System.Globalization;
using System.Threading;

class FormatNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter integer number a = ");
        int a = int.Parse(Console.ReadLine());

        //Validation of 'a'
        while (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid input! Try again!");
            a = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter floating point number b: ");
        decimal decimalB = decimal.Parse(Console.ReadLine());

        Console.Write("Enter floating point number c: ");
        decimal decimalC = decimal.Parse(Console.ReadLine());

        Console.Write("\n|{0,-10:x} |", a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|{0,10:F2}|{0,-10:F3}|\n", decimalB, decimalC);
    }
}

