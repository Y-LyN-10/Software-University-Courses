// Problem 11. Count of Letters
// Write a program that reads a list of letters and prints 
// for each letter how many times it appears in the list.
// The letters should be listed in alphabetical order. Use 
// the input and output format from the examples below. 
// Example: Input	        Output
//          b b a a b	    a -> 2
//                          b -> 3

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Test 1:");
        Console.SetIn(new StreamReader("../../input.txt"));
        Solution();

        Console.WriteLine("Test 2:");
        Console.SetIn(new StreamReader("../../input2.txt"));
        Solution();
    }
    
    static void Solution()
    {
        string[] letters = Console.ReadLine().Split(' ');
        Array.Sort(letters);

        var alphabet = new HashSet<string>();
        for (int i = 0; i < letters.Length; i++)
        {
            alphabet.Add(letters[i]);
        }

        int count = 0;
        foreach(string letter in alphabet)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (letter == letters[j]) count++;
            }
            
            Console.WriteLine(letter + " -> " + count);
            count = 0;
        }
        Console.WriteLine();
    }
}

