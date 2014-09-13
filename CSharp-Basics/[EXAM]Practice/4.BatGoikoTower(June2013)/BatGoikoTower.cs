using System;

class BatGoikoTower
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine()); //Height

        int outerSpace = h-1;
        int innerSpace = 0;
        //int lineRow = 2;
        //int lineUpdate = 2;

        for (int row = 1; row <= h; row++)
        {
            Console.Write(new string('.', outerSpace));
            Console.Write("/");

            if /*(row == lineRow)*/ ((row == 2) || (row == 4) || (row == 7) || (row == 11) ||
                                     (row == 16) ||(row == 22)|| (row == 29)|| (row == 37) )
            {
                Console.Write(new string('-', innerSpace));
                //lineRow += lineCount;
                //lineUpdate++;
            }
            else
            {
                Console.Write(new string('.', innerSpace));
            }
            
            Console.Write("\\");

            Console.WriteLine(new string('.', outerSpace));

            outerSpace--;        
            innerSpace += 2;     
        }
    }
}
