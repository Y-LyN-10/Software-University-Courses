using System;

class Coordinates
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine()); //read x
        double y = double.Parse(Console.ReadLine()); //read y

        double result = CheckArea(x, y);
        
        Console.WriteLine(result);
    }

    static double CheckArea(double x, double y)
    {
        double result;

        if (x == 0 & y == 0) result = 0; 
        else if (x == 0 & y != 0) result = 5;
        else if (x != 0 & y == 0) result = 6;
        else if (x > 0 & y > 0) result = 1; 
        else if (x < 0 & y > 0) result = 2; 
        else if (x < 0 & y < 0) result = 3;
        else /*(x > 0 & y < 0)*/ result = 4; 

        return result; 
    }
}

