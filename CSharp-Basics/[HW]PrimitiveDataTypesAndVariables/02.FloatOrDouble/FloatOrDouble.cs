// Problem 2. Float or Double?
// Which of the following values can be assigned to a variable of 
// type float and which to a variable of type double: 34.567839023, 
// 12.345, 8923.1234857, 3456.091? Write a program to assign the 
// numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        Console.Title = "Problem 2. Float or Double?";

        float floatNum1 = 12.345f;
        float floatNum2 = 3456.091f;
        double doubleNum1 = 34.567839023d;
        double doubleNum2 = 8923.1234857d;

        Console.WriteLine(("Values ") + (floatNum1) + (" and ") + (floatNum2) + (" are float, but they can be double too."));
        Console.WriteLine(("Values ") + (doubleNum1) + (" and ") + (doubleNum2) + (" are double only."));
       
    }
}