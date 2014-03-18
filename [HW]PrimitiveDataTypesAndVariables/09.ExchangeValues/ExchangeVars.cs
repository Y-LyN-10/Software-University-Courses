// Problem 9. Exchange Variable Values
// Declare two integer variables a and b and assign them 
// with 5 and 10 and after that exchange their values. 
// Print the variable values before and after the exchange.

using System;

class ExchangeVars
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.Title = "Problem 9. Exchange Variable Values";
        Console.WriteLine("Variables before exhange: \nint a = {0};\nint b = {1};", a, b);

        a = a + b; // 5 + 10 = 15
        b = a - b; // 15 - 10 = 5
        a = a - b; // 15 - 5 = 10

        Console.WriteLine("\nVariables after exchange: \nint a = {0};\nint b = {1};\n", a, b);
    }
}

