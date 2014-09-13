// Problem 4. Multiplication Sign
// Write a program that shows the sign (+, - or 0) of the
// product of three real numbers, without calculating it. 
// Use a sequence of if operators. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        //Check for a border case first
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("\nThe product is (0)");
        }
        
        //There is no need to calculate the numbers. We need only to check
        //if the numbers are positive or negative, because of math "laws". 
        else if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) 
              || (c < 0 && b > 0 && a > 0) || (a < 0 && b < 0 && c < 0))
        {
            Console.WriteLine("\nThe product of the 3 numbers is negative (-)");
        }
        else
        {
            Console.WriteLine("\nThe product of the 3 numbers is positive (+)");
        }
    }
}

