// Problem 8. Digit as Word
// Write a program that asks for a digit (0-9), and depending 
// on the input, shows the digit as a word (in English). 
// Print “not a digit” in case of invalid inut. Use a switch statement. 

using System;

class DigitAsWord
{
    static void Main()
    {
        string input = Console.ReadLine();

        byte digit;
        bool isDigit = byte.TryParse(input, out digit);

        if (isDigit)
        {
            switch (digit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("not a digit");
                    break;
            }
        }
        else
        {
            Console.WriteLine("not a digit");
        }
        
    }
}

