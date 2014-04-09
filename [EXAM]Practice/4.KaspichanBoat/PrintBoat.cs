using System;

class PrintBoat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // if 5
        int height = 6 + (((n - 3) / 2) * 3); //9
        int sails = (height/3)*2; // 6
        int bottom = height / 3; //3
        int width = n * 2 + 1; //11
        int outerDots = n-1; //4
        int innerDots = 0; //0

        //firstLine
        Console.WriteLine(new string('.', n) + "*" + new string('.', n));


        //sails
        for (int i = 1; i <= sails-2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");

            if (outerDots >= 0)
            {
                Console.Write(new string('.', innerDots));
                Console.Write("*");
            }
            else
            {

            }

             Console.Write(new string('.', innerDots));
             Console.Write("*");
             Console.WriteLine(new string('.', outerDots));

            outerDots--;
            innerDots++;

        }

       //Middle alone line
        Console.WriteLine(new string('*', width));

         outerDots++;
         innerDots--;
   
         for (int i = 1; i < bottom; i++)
        {

            Console.Write(new string('.', outerDots));
            Console.Write("*");

            if (outerDots >= 0)
            {
                Console.Write(new string('.', innerDots));
                Console.Write("*");
            }
            else
            {

            }

            Console.Write(new string('.', innerDots));
            Console.Write("*");
            Console.Write(new string('.', outerDots));



            Console.WriteLine();
            innerDots--;
            outerDots++;

        }

         innerDots+=2;
         
        //bottom
       Console.Write(new string('.', innerDots));
       Console.Write(new string('*', n));
       Console.WriteLine(new string('.',outerDots ));
 
 
 
    }
}

