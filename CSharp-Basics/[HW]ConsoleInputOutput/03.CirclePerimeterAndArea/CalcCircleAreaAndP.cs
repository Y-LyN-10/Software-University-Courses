// Problem 3. Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its 
// perimeter and area formatted with 2 digits after the decimal point. 
// Examples: r = 2, P = 12.57, A = 12.57; r = 3.5, P = 21.99, A = 38.48;

using System;
using System.Globalization;
using System.Threading;

class CalcCircleAreaAndP
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Radius = ");
        double r = double.Parse(Console.ReadLine()); //Read a double number for radius

        /*I could write the result in one line, but for the quality of the code, it's 
        better to declare new variables and assign them with the result*/

        double perimeter = Math.PI * (r * 2);
        double area = Math.PI * (r * r);

        Console.WriteLine("-----------\nP =  {0:0.00}\nA =  {1:0.00}", perimeter, area);
    }
}

