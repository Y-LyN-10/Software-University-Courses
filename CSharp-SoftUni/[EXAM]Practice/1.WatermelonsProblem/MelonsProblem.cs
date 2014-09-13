using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        int amountOfDays = int.Parse(Console.ReadLine());

        string result = countEaten(dayOfWeek, amountOfDays);

        Console.WriteLine(result);
    }

    private static string countEaten(int dayOfWeek, int amountOfDays)
    {
        int totalMelons = 0;
        int totalWatermelons = 0;

        for (int i = 0; i < amountOfDays; i++)
        {
            switch (dayOfWeek)
            {
                case 1: totalWatermelons += 1; break;
                case 2: totalMelons += 2; break;
                case 3: totalMelons += 1; totalWatermelons += 1; break;
                case 4: totalWatermelons += 2; break;
                case 5: totalMelons += 2; totalWatermelons += 2; break;
                case 6: totalMelons += 2; totalWatermelons += 1; break;
                case 7: break;
                default: dayOfWeek = 1; totalWatermelons += 1; break;
            }

            dayOfWeek++;
        }

        return totalMelons == totalWatermelons ?
            "Equal amount: " + totalMelons : totalMelons > totalWatermelons ?
                (totalMelons - totalWatermelons) + " more melons" :
                (totalWatermelons - totalMelons) + " more watermelons";
    }
}

// Monday	 1 Watermelon
// Tuesday	 2 Melons
// Wednesday 1 Watermelon and 1 Melon
// Thursday	 2 Watermelons
// Friday	 2 Watermelons and 2 Melons
// Saturday	 1 Watermelon and 2 Melons
// Sunday	 Didko takes a break

