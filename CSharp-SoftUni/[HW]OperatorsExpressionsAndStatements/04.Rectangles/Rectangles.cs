// Problem 4. Rectangles
// Write an expression that calculates rectangle’s  
// perimeter and area by given width and height. 

// Examples:
// width | height |	perimeter |	area
// 3	 |   4 	  |  14       |  12
// 2.5	 |   3	  |  11	      |  7.5
// 5	 |   5    |  20	      |  25

using System;
using System.Globalization;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Height: ");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.WriteLine("-------");
        Console.WriteLine("P = {0} \nS = {1}\n", (2*width + 2*height), (width*height));
    }
}

