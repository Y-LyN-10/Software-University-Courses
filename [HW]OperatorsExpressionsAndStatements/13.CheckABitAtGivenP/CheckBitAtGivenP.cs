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
        //From the lecture:
        //How to get the bit at position p from a number n?
        int p = 5;
        int n = 291;               // 00000001 00100011
        int nRightP = n >> p;      // 00000000 00001001
        int bit = nRightP & 1;     // 00000000 00000001
        Console.WriteLine(bit);    // 1

        //How to set the bit at position p to 0?
        //int p = 5;
        //int n = 291;               // 00000001 00100011
        //int mask = ~(1 << p);      // 11111111 11011111
        //int result = n & mask;     // 00000001 00000011
        //Console.WriteLine(result); // 259


    }
}
