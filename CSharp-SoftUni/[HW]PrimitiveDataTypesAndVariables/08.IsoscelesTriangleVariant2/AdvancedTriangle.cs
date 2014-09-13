using System;

class AdvancedTriangle
{
    static void Main()
    {
        Console.Title = "Problem 8. Isocleses Triangle - Advanced";

        int n = int.Parse(Console.ReadLine()); // read the height of the triangle

        //To print a figure with empty spaces outside and 
        //inside, we need a variables to count them
        int outerSpace = n - 1; 
        int innerSpace = 1; 

        //Print the top of the triangle
        Console.WriteLine(new string(' ', n) + "@" + new string(' ', n));

        //The middle of the triangle we print with a loop, printing so many lines as needed.
        // n - 2, because the first line and the bottom are printed separately from this loop
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write(new string(' ', outerSpace)); // first time, outerSpace = n - 1. 
            Console.Write("@");

            Console.Write(new string(' ', innerSpace)); // first time, innterSpace symbol is printed only once.
            Console.WriteLine("@");

            outerSpace--;        //In every loop repeat outerSpace counter decreases 
            innerSpace += 2;     //with 1 and innerSpace counter increases with 2.
        }

        /*Print the bottom of the triangle (I made it with 
          empty intervals between copyright symbols.)*/
        Console.Write(new string(' ', outerSpace));
        for (int i = 0; i < n; i++) 
        {
            Console.Write('@');
            Console.Write(' ');
        }
        Console.WriteLine(new string(' ', outerSpace));

    }
}
