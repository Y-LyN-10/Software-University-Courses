// Problem 15.* Bits Exchange
// Write a program that exchanges bits 3, 4 and 5 with, 
// bits 24, 25 and 26 of given 32-bit unsigned integer.

//Some examples:
//n	            |binary representation of n	          | binary result	                     |  result
//1140867093	|01000100 00000000 01000000 00010101  | 01000010 00000000 01000000 00100101	 |  1107312677
//255406592 	|00001111 00111001 00110010 00000000  |	00001000 00111001 00110010 00111000	 |  137966136
//4294901775	|11111111 11111111 00000000 00001111  |	11111001 11111111 00000000 00111111	 |  4194238527
//5351	        |00000000 00000000 00010100 11100111  |	00000100 00000000 00010100 11000111	 |  67114183
//2369124121	|10001101 00110101 11110111 00011001  |	10001011 00110101 11110111 00101001	 |  2335569705

using System;

class BitExchange
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine()); //prev: inputNumber
        string binaryNumber = Convert.ToString(num, 2).PadLeft(32, '0');

        uint result = num;

        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;

        // Take bits 3, 4 5 and 24, 25, 26
        uint bits345 = num & mask1;
        uint bits2456 = num & mask2;

        // put bits in position
        bits345 <<= 21;
        bits2456 >>= 21;

        //Replace binary digits with zeroes in bits 3, 4, 5 and 24, 25, 26
        result = ~mask1 & result;
        result = ~mask2 & result;

        //place bits in position
        result = result | bits345;
        result = result | bits2456;

        string binaryResult = Convert.ToString(result, 2).PadLeft(32, '0');

        //output

        Console.WriteLine("\nBinary of n:   {0}", binaryNumber);
        Console.WriteLine("Binary result: {0}", binaryResult);

        Console.WriteLine("Result:        " + result);
    }
}

