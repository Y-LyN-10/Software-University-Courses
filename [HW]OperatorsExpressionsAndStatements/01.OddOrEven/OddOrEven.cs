// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even. 
// Examples: n = 3, odd? true; n = 2, odd? false; n = -1, odd? true;
// n = 0, odd? false

using System;

class OddOrEven
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        
        //I use bitwise operations for this check.
        bool even = ((inputNumber & 1) != 0);

        Console.WriteLine("odd? " + even);
    }
}
