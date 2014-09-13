// Problem 12.	Count of Names
// Write a program that reads a list of names and prints
// for each name how many times it appears in the list. 
// The names should be listed in alphabetical order. Use 
// the input and output format from the examples below.           
// Example: Input | Nakov Nakov Nakov SoftUni Nakov                
//          Output| SoftUni -> 1 Nakov -> 5

using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        //This solution is ABSOLUTELY the same, like for the "Count of letters" task.

        string[] input = Console.ReadLine().Split(' ');
        Array.Sort(input);

        var words = new HashSet<string>();
        for (int i = 0; i < input.Length; i++)
        {
            words.Add(input[i]);
        }

        int count = 0;
        foreach (string letter in words)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (letter == input[j]) count++;
            }

            Console.WriteLine(letter + " -> " + count);
            count = 0;
        }
        Console.WriteLine();
    }
}

