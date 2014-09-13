// Problem 14.* Print the ASCII Table
// Find online more information about ASCII (American Standard Code for 
// Information Interchange) and write a program to prints the entire ASCII 
// table of characters at the console (characters from 0 to 255). Note that 
// some characters have a special purpose and will not be displayed as expected. 
// You may skip them or display them differently. 
// You may need to use for-loops (learn in Internet how).

using System;

class ASCITable
{
    static void Main()
    {
        /* ASCII  character-encoding scheme originally based on the English alphabet that encodes
         * 128 specified characters - the numbers 0-9, the letters a-z and A-Z, some basic punctuation
         * symbols, some control codes and a blank space - into the 7-bit binary integers.*/ 

        Console.OutputEncoding = System.Text.Encoding.ASCII;
        Console.Title = "Problem 14.* Print the ASCII Table";

        //In the terms of the task is said that I can skip some characters, so I'll print only the visible ones:
        for (int i = 32; i < 127; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();
    }
}

