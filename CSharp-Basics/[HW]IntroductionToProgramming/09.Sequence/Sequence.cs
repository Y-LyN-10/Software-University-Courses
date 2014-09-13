// Problem 9. Print a Sequence
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class Sequence
{
    static void Main()
    {
        Console.Title = "Problem 9. Print a Sequence";
        Console.WriteLine("Write a program that prints the first 10 members of the sequence:\n2, -3, 4, -5, 6, -7, ...");
        Console.WriteLine();
        Console.WriteLine("My solution: ");

        // We need to print the fisrt 10 members of the sequence. 
        // So, we need to repeat the same code 10 times and every time to check if the number is even or not.
        // Number starts from zero and every time it increases with one. 

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0,1}, ", i + 2);
            }
            if (i == 9) //this check is for the comma at the end of the sequence
            {
                Console.WriteLine("{0,1} ", i + 2);
            }
            else
            {
                Console.Write("{0,1}, ", -(i + 2));
            }
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
