// Problem 6. Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic 
// equation ax2 + bx + c = 0 and solves it (prints its real roots). 
// Examples:
// a	 b	 c	 roots
// 2	 5	-3	 x1=-3; x2=0.5
// -1	 3	 0	 x1=3; x2=0
// -0.5  4	-8	 x1=x2=4
// 5	 2	 8	 no real roots

using System;
using System.Globalization;
using System.Threading;
class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter coefficient 'a': ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient 'b': ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient 'c': ");
        double c = double.Parse(Console.ReadLine());

        double dD = (b * b) - (4 * a * c);
        double root1;
        double root2;

        Console.WriteLine();

        if (dD > 0)
        {
            root1 = (-b - Math.Sqrt(dD)) / (2 * a);
            root2 = (-b + Math.Sqrt(dD)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", root1, root2);

        }
        else if (dD == 0)
        {
            root1 = root2 = (-b - Math.Sqrt(dD)) / (2 * a);
            Console.WriteLine("x1=x2={0}", root1);

        }
        else
        {
            Console.WriteLine("No real roots.");
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}

