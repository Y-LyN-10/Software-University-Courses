// Problem 3. Divide by 7 and 5
// Write a Boolean expression that checks for given integer if it can 
// be divided (without remainder) by 7 and 5 in the same time. 

// Examples: (n = 3, Divided by 7 and 5? false)
// 3	false  // 0	false  //5 false  //7 false  //35 true  //140  true

using System;

class Dividable
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        // A number, that can be divided by 7 and 5 in the
        // same time, can be devided by 35 without remainder
        bool dividable = (inputNumber % 35 == 0) && (inputNumber != 0);

        Console.WriteLine("n = {0}, Divided by 7 and 5? {1} ", inputNumber, dividable);
    }
}
