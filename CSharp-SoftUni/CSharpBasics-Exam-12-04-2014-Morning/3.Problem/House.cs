using System;
using System.IO;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // if 5

        int outerDots = ((n+1)/2-2);
        int innerDots = 1;
        int roofsHeight = (n+1)/2;

        //firstLine
        Console.WriteLine(new string('.', outerDots+1) + "*" + new string('.', outerDots+1));

        //roof
        for (int i = 2; i < roofsHeight; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");

            Console.Write(new string('.', innerDots)); 

            Console.Write("*");
            Console.WriteLine(new string('.', outerDots)); 

            outerDots--;        
            innerDots += 2;     
        }

        //middle line
        Console.WriteLine(new string('*', n));

        outerDots = n / 4;
        innerDots = n-((n/4)*2+2);

        //walls
        for (int i = 0; i < n-roofsHeight-1; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");
            Console.Write(new string('.', innerDots));
            Console.Write("*");
            Console.WriteLine(new string('.', outerDots));
        }

        //bottom
        Console.WriteLine(new string('.', outerDots) + new string('*', innerDots + 2) + new string('.', outerDots));
    }
}

