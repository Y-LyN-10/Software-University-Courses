namespace Point3D
{
    public class Point3D
    {
        /* Problem 1: Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the 
           Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
           
           Add a private static read-only field in the Point3D class to hold the start of the coordinate 
           system – the point StartingPoint {0, 0, 0}. Add a static property to return the starting point. */

        public struct StructPoint3D
        {
            public StructPoint3D(double x, double y, double z)
                : this()
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public double X { get; private set; }
            public double Y { get; private set; }
            public double Z { get; private set; }

            private static readonly StructPoint3D StartPointIn3D = new StructPoint3D(0, 0, 0);

            public static StructPoint3D StartPoint3D
            {
                get { return StartPointIn3D; }
            }

            public override string ToString()
            {
                return "X: " + this.X + ", Y: " + this.Y + ", Z: " + this.Z;
            }
        }
    }
}
