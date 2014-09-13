//  Problem 11.* Numbers in Interval Dividable by Given Number
//  Write a program that reads two positive integer numbers and 
//  prints how many numbers p exist between them such that the 
//  reminder of the division by 5 is 0. 
//  Example: start = 17, end = 25, p = 2, comments = 20, 25; etc

using System;
using System.Collections.Generic;

class DividableNumsInInterval
{
    static void Main()
    {
        Console.Write("Start: ");
        uint start = uint.Parse(Console.ReadLine());

        Console.Write("End: ");
        uint end = uint.Parse(Console.ReadLine());

        List<uint> comments = new List<uint>();
        int counter = 0;

        for (uint i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                comments.Add(i);
                counter++;
            }
        }

        Console.WriteLine("p = {0}", counter);

        foreach (uint number in comments)
        {
            Console.Write(number + ", ");
        }
    }
}
