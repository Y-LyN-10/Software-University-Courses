using System;

namespace Point3D
{
    using StructPoint3D = Point3D.StructPoint3D;

    internal class PointTester
    {
        static void Main()
        {
            var firstPoint = new StructPoint3D(32, 40, 0);
            var secondPoint = new StructPoint3D(154, 284, -255);

            // Print start point coordinates
            Console.WriteLine(StructPoint3D.StartPoint3D.ToString());

            // Print First 3D Point's coordinates
            Console.WriteLine(firstPoint.ToString());

            // Second 3D Point's coordinates
            Console.WriteLine(secondPoint.ToString());

            Console.Write(Environment.NewLine);
            Console.Write("Distance between points: ");
            Console.WriteLine(CalculateTheDistance.CalcDistance(firstPoint, secondPoint));
        }
    }
}
