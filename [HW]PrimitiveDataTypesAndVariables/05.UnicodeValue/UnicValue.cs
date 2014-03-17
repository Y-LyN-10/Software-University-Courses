// Problem 4. Unicode Value
// Declare a character variable and assign it with the symbol that has 
// Unicode code 72, and then print it. Hint: first, use the Windows 
// Calculator to find the hexadecimal representation of 72. 
// The output should be “H”.

using System;
using System.Text;

class UnicValue
{
    static void Main()
    {
        Console.Title = "Problem 4. Unicode Value";
        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

        char symbol = '\u0048'; // The hex of 72 is 48.
        Console.WriteLine(symbol);

        //Just a check for cyrillic symbols
        //Console.WriteLine("и кирилица работи");
    }
}
