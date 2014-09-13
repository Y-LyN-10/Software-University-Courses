// Problem 7. Sort 3 Numbers with Nested Ifs
// Write a program that enters 3 real numbers and prints 
// them sorted in descending order. Use nested if statements. 
// Don’t use arrays and the built-in sorting functionality. 

using System;

class SortNums
{
    static void Main()
    {
        Console.WriteLine("Please, insert 3 numbers: ");
        double num1 = double.Parse(Console.In.ReadLine());
        double num2 = double.Parse(Console.In.ReadLine());
        double num3 = double.Parse(Console.In.ReadLine());

        Console.WriteLine("\nSorted in descending order: ");

        //Yes, there are much better ways to solve this 
        //problem, but these are the requirments... nested if's

        if (num1 >= num2 && num1 >= num3)
        { 
            if (num2 >= num3) 
                 Console.WriteLine("{0}\n{1}\n{2}\n", num1, num2, num3);
            else Console.WriteLine("{0}\n{1}\n{2}\n", num1, num3, num2);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            if (num1 >= num2) 
                 Console.WriteLine("{0}\n{1}\n{2}\n", num2, num1, num3);
            else Console.WriteLine("{0}\n{1}\n{2}\n", num2, num3, num1);
        }
        else if (num3 >= num1 && num3 >= num2)
        {
            if (num1 >= num2) 
                 Console.WriteLine("{0}\n{1}\n{2}\n", num3, num1, num2);
            else Console.WriteLine("{0}\n{1}\n{2}\n", num3, num2, num1); 
        }
    }
}

