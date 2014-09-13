// Problem 5. The Biggest of 3 Numbers
// Write a program that finds the biggest of three numbers. 

using System;

class BiggestNum
{
    static void Main()
    {
        Console.WriteLine("Please, insert 3 numbers: ");
        double num1 = double.Parse(Console.In.ReadLine());
        double num2 = double.Parse(Console.In.ReadLine());
        double num3 = double.Parse(Console.In.ReadLine());

        double max1 = Math.Max(num1, num2);
        double max2 = Math.Max(max1, num3);

        Console.WriteLine("\nThe biggest number is: \n{0}", max2);
    }
}

