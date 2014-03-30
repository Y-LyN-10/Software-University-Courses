// Problem 13.	Check a Bit at Given Position
// Write a Boolean expression that returns if the bit at position p
// (counting from 0, starting from the right) in given integer number n has value of 1. 

// Some Examples:
// n	  | binary representation of n	| p	| bit @ p == 1 |
// 5	  | 00000000 00000101	        | 2 | 	 true      |
// 0	  | 00000000 00000000	        | 9	|    false     |
// 62241  |	11110011 00100001	        | 11|	 false     |

using System;

class CheckBitAtGivenP
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int addMask = n & mask;

        bool bitValue = (addMask != 0);

        string binaryNumber = Convert.ToString(n, 2).PadLeft(16, '0');
        Console.WriteLine("Binary n: {0}\nBit @ p:  {1}", binaryNumber, bitValue);
    }
}
