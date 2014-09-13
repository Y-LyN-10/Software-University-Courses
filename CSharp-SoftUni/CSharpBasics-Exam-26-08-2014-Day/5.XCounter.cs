using System;
using System.IO;

class XCounter
{
    static void Main()
    {

#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        string[] bs = new string[8]; // bs = binaryString

        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            bs[i] = Convert.ToString(currentNumber, 2).PadLeft(32, '0');
        }

        string upDownValidLine = "101";
        string middleValidLine = "010";

        int countX = 0;
        for (int i = 0; i < bs.Length-2; i++)
        {
            for (int j = 0; j < bs[i].Length -2; j++)
            {
                // Add "" to convert numbers to string
                if (("" + bs[i][j] + bs[i][j+1] + bs[i][j+2]) == upDownValidLine &&
                    ("" + bs[i+1][j] + bs[i+1][j + 1] + bs[i+1][j + 2]) == middleValidLine &&
                    ("" + bs[i+2][j] + bs[i+2][j + 1] + bs[i+2][j + 2]) == upDownValidLine)
                {
                    countX++;
                }
            }
        }
        Console.WriteLine(countX);
    }
}