using System;

namespace Point3D
{
    public static class CalculateTheDistance
    {
        /* Problem 2. Distance Calculator
           Write a static class DistanceCalculator with a static method to calculate the distance between
           two points in the 3D space. Search in Internet how to calculate distance in the 3D Euclidian space.
          
           Damn it this Math: http://freespace.virgin.net/hugo.elias/routines/r_dist.htm */

        public static double CalcDistance(Point3D.StructPoint3D firstPoint, Point3D.StructPoint3D secondPoint)
        {
            var distance = Math.Round(Math.Sqrt(
                    Math.Pow(secondPoint.X - firstPoint.X, 2) + 
                    Math.Pow(secondPoint.Y - firstPoint.Y, 2) + 
                    Math.Pow(secondPoint.Z - firstPoint.Z, 2)), 2);

            return distance;
        }
    }
}
