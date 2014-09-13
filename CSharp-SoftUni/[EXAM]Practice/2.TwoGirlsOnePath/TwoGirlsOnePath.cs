using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger[] flowerArea;

        string input = Console.ReadLine();

        string[] inputNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        flowerArea = new BigInteger[inputNumbers.Length];

        for (int i = 0; i < flowerArea.Length; i++)
        {
            flowerArea[i] = BigInteger.Parse(inputNumbers[i]);
        }

        string result = GatherFlowers(flowerArea);
        Console.WriteLine(result);
    }

    private static string GatherFlowers(BigInteger[] valley)
    {
        int fieldLength = valley.Length;

        int mollysCurrentPosition = 0; 
        int dollysCurrentPosition = fieldLength - 1; 

        BigInteger mollyJumpSize = valley[mollysCurrentPosition] % fieldLength;
        BigInteger dollyJumpSize = valley[dollysCurrentPosition] % fieldLength;

        BigInteger mollysFlowersOnField = valley[mollysCurrentPosition];
        BigInteger dollysFlowersOnField = valley[dollysCurrentPosition];

        BigInteger mollysTotalFlowers = mollysFlowersOnField;
        BigInteger dollysTotalFlowers = dollysFlowersOnField;

        valley[mollysCurrentPosition] = 0;
        valley[dollysCurrentPosition] = 0;

        while (true)
        {
            // check if the game ends
            if (dollysFlowersOnField < 1 && mollysFlowersOnField < 1)
            {
                return "Draw\n" + mollysTotalFlowers + " " + dollysTotalFlowers;
            }

            if (mollysFlowersOnField < 1 /*&& dollysFlowersOnField > 0*/)
            {
                return "Dolly\n" + mollysTotalFlowers + " " + dollysTotalFlowers;
            }

            if (dollysFlowersOnField < 1 /*&& mollysFlowersOnField > 0*/)
            {
                return "Molly\n" + mollysTotalFlowers + " " + dollysTotalFlowers;
            }

            // Move Molly
            if (mollyJumpSize >= fieldLength - mollysCurrentPosition)
            {
                mollysCurrentPosition = (int)(mollyJumpSize - (fieldLength - mollysCurrentPosition));
            }
            else
            {
                mollysCurrentPosition += (int)mollyJumpSize; 
            }

            // Move Dolly
            if (dollyJumpSize > dollysCurrentPosition)
            {
                dollysCurrentPosition = (int)(fieldLength - (dollyJumpSize - dollysCurrentPosition));
            }
            else
            {
                dollysCurrentPosition -= (int)dollyJumpSize;
            }

            mollysFlowersOnField = valley[mollysCurrentPosition];
            dollysFlowersOnField = valley[dollysCurrentPosition];

            mollyJumpSize = mollysFlowersOnField % fieldLength;
            dollyJumpSize = dollysFlowersOnField % fieldLength;

            //Gather flowers
            if (mollysCurrentPosition != dollysCurrentPosition)
            {
                mollysTotalFlowers += mollysFlowersOnField;
                dollysTotalFlowers += dollysFlowersOnField; 

                valley[mollysCurrentPosition] = 0;
                valley[dollysCurrentPosition] = 0;
            }
            else
            {
                BigInteger flowersOnField = mollysFlowersOnField;

                if (flowersOnField % 2 == 0)
                {
                    mollysTotalFlowers += flowersOnField / 2;
                    dollysTotalFlowers += flowersOnField / 2;

                    valley[mollysCurrentPosition] = 0;
                }
                else
                {
                    mollysTotalFlowers += flowersOnField / 2;
                    dollysTotalFlowers += flowersOnField / 2;

                    valley[mollysCurrentPosition] = 1;
                }
            }
        }
    }
}