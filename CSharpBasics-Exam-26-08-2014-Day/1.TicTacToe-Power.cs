using System;
using System.Numerics;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int nextValue = v;

        int[,] ticTacToe = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                ticTacToe[i, j] = nextValue;
                if(i == y && j == x){
                    Console.WriteLine((BigInteger)(Math.Pow(nextValue, (nextValue + 1) - v)));
                }
                nextValue ++;
            }
        }
    }
}