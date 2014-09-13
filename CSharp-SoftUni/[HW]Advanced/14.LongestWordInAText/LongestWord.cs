// Problem 14. Longest Word in a Text
// Write a program to find the longest word in a text. 
// Examples: Input  - Welcome to the Software University.
//           Output - University

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //Test 1:
        //Console.SetIn(new StreamReader("../../input.txt"));
        //Test 2:
        //Console.SetIn(new StreamReader("../../input2.txt"));

        string input = Console.ReadLine().TrimEnd('.');
        string[] words = input.Split(' ');

        int letterCounter = 0;
        int maxCount = 0;
        string longestWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                letterCounter++;
                
                if (letterCounter >= maxCount)
                {
                    maxCount = letterCounter;
                    longestWord = words[i];
                }
            }
            letterCounter = 0;
        }
        Console.WriteLine(longestWord);
    }
}

