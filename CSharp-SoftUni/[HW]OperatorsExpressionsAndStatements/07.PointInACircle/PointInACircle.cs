// Problem 7. Point in a Circle
// Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
// Examples: (x = 0, y = 1 --> inside? true), (-2, 0 --> true), (-1, 2 --? inside? false) Etc...

using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //First, read the coordinates from the console
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double radius = 2;

        //Pythagorean theorem (a^2 + b^2 = c^2) checks if the point is within the circle.
        bool inside = ((x * x) + (y * y) <= (radius * radius));

        Console.WriteLine("inside? {0}", inside);
    }
}

