using System;
using System.Numerics;

class TicTacPower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int startValue = int.Parse(Console.ReadLine());

        int value = startValue;

        int[,] matrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = value;
                if(i == y && j == x){
                    Console.WriteLine((BigInteger)(Math.Pow(value, (value + 1) - startValue)));
                }
                value ++;
            }
        }
    }
}