// Problem 6. The Biggest of Five Numbers
// Write a program that finds the biggest of 
// five numbers by using only five if statements. 

using System;

class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("Please, insert 5 numbers: ");
        double num1 = double.Parse(Console.In.ReadLine());
        double num2 = double.Parse(Console.In.ReadLine());
        double num3 = double.Parse(Console.In.ReadLine());
        double num4 = double.Parse(Console.In.ReadLine());
        double num5 = double.Parse(Console.In.ReadLine());

        Console.Write("\nThe greatest number of them is: ");

        //Use five If-statements? Okay...
        if (num1 >= num1 && num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5) Console.Write(num1);
        if (num2 >= num1 && num2 >= num2 && num2 >= num3 && num2 >= num4 && num2 >= num5) Console.Write(num2);
        if (num3 >= num1 && num3 >= num2 && num3 >= num3 && num3 >= num4 && num3 >= num5) Console.Write(num3);
        if (num4 >= num1 && num4 >= num2 && num4 >= num3 && num4 >= num4 && num4 >= num5) Console.Write(num4);
        if (num5 >= num1 && num5 >= num2 && num5 >= num3 && num5 >= num4 && num5 >= num5) Console.Write(num5);

        Console.WriteLine();
    }
}
