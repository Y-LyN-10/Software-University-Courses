// Problem 5. Third Digit is 7?
// Write an expression that checks for given integer
// if its third digit from right-to-left is 7. 

//Examples:
// n = 5, Third digit 7? false
// 5 false // 701 true // 877 false // 777877 false // 9999799 true

using System;

class LuckySeven
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        // Now calculate...
        int thirdDigit = (inputNumber / 100) % 10;
        bool isSeven = (thirdDigit == 7) || (thirdDigit == -7);

        /* For example: 
         * 562735 / 100 = 5627,35 ¬ 5627
         * 5627 % 10 = 7 
         * (true) */

        Console.WriteLine("Third digit is 7? {0} ", isSeven);

    }
}