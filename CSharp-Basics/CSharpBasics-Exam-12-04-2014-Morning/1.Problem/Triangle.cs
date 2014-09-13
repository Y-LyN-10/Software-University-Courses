using System;
using System.Globalization;
using System.IO;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));

        StreamWriter sw = new StreamWriter(new FileStream("../../output.txt", FileMode.Create));
#endif

        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        bool triangle = false;
        double area = 0.00;
        double p = 0.00;

        double aB = Math.Sqrt(CalcDistance(aX, aY, bX, bY));
        double bC = Math.Sqrt(CalcDistance(bX, bY, cX, cY));
        double cA = Math.Sqrt(CalcDistance(cX, cY, aX, aY));

        if (aB + bC > cA && bC + cA > aB && aB + cA > bC)
        {
            triangle = true;
            p = (aB + bC + cA) / 2;
            area = Math.Sqrt(p*(p - aB)*(p - bC)*(p - cA));
        }

        if (triangle)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", aB);
        }
    }

    private static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double formula = ((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1));
        return formula;
    }
}

