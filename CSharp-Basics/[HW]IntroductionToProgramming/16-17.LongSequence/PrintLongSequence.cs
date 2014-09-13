// Problem 16.*  Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
// You might need to learn how to use loops (search in Internet).

// PRoblem 17.* Play with the Debugger in Visual Studio
// Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. 
// Run the program through the debugger using the [F5] key. 
// When the debugger stops at the breakpoint trace the code execution with [F10] key. - DONE √

using System;

class LongSequence
{
    static void Main()
    {
        Console.Title = "Problem 16.* Print Long Sequence";

        //Ok, this task is the same like "problem 9", where we printed the first 10 numbers
        //of the same sequence. Here we just need to change the number of loops to 1001.

        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = 70;

        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i.ToString().PadLeft(5));
            }
            else
            {
                Console.Write((-i).ToString().PadLeft(5));
            } 
        }

        Console.Write("\n  ");
    }
}
