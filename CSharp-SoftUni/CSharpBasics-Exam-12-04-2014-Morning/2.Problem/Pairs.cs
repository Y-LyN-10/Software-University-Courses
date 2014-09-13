using System;
using System.Collections.Generic;
using System.IO; //for StreamReader
using System.Linq; //for .Any()

class Program
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        string[] input = Console.ReadLine().Split(' ');
        
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        List<long> pairValues = new List<long>();
        for (int i = 0; i < numbers.Length; i+=2)
        {
            pairValues.Add(numbers[i] + numbers[i + 1]);
        }

        if (pairValues.Any(o => o != pairValues[0]))
        {
            pairValues.Sort();
            long maxDiff = (pairValues[pairValues.Count - 1]) - (pairValues[0]);

            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
        else
        {
            Console.WriteLine("Yes, value={0}", pairValues[0]);
        }
    }
}