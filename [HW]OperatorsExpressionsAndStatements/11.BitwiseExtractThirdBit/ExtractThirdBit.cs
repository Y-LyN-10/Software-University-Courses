// Problem 11. Bitwise: Extract Bit #3
// Using bitwise operators, write an expression for finding the value of the bit #3
// of a given unsigned integer. The bits are counted from right to left, starting 
// from bit #0. The result of the expression should be either 1 or 0. 

// Examples:
// n  |	binary representation |	bit #3
// 5  |	  00000000 00000101	  |   0
// 0  |	  00000000 00000000	  |   0
// 15 |	  00000000 00001111	  |   1 

using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Number:  ");
        int inputNumber = int.Parse(Console.ReadLine());

        int moveRight = inputNumber >> 3;
        int bit = moveRight & 1;

        Console.WriteLine("Bit 3# is " + bit);
    }
}
