// Problem 10.	Point Inside a Circle & Outside of a Rectangle
// Write an expression that checks for given point (x, y) if it is within the
// circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

//Examples:
// x	    y	inside K & outside of R	 
// 1	    2	    yes	
// 2.5	    2	    no	
// 0	    1	    no	
//2.5    	1.5	    yes	
//Etc...

using System;
using System.Globalization;
using System.Threading;

class InCircleOutRect
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //Read the values
        Console.Write("x = ");
        decimal inputX = decimal.Parse(Console.ReadLine());
        Console.Write("y = ");
        decimal inputY = decimal.Parse(Console.ReadLine());
        Console.WriteLine("-------");

        //circle K({1, 1}, 1.5)
        decimal x = inputX - 1;
        decimal y = inputY - 1;
        decimal r = 1.5m;

        //Rectangle R 
        decimal top = 1;
        decimal left = -1;
        decimal width = 6;
        decimal height = 2;

        // Boolean checks
        bool withinCircle = (x * x) + (y * y) < (r * r);
        bool outOfRect = ((top > x) || (width < x) || (left > y) || (height < y));
        bool result;

        if (withinCircle == true && outOfRect == true)
        {
            result = true;
        }
        else
        {
            result = false;
        }

        //Print the result using the conditional operator (?:)
        Console.WriteLine("Inside the circle and outside of the rectangle? - {0}", result ? "Yes" : "No");
    }
}
