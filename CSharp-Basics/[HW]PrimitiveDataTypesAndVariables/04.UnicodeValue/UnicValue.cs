// Problem 4. Unicode Character
// Declare a character variable and assign it with the symbol that has 
// Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. 
// Hint: first, use the Windows Calculator to find the hexadecimal 
// representation of 42. The output should be “*”.


using System;
using System.Text;

class UnicValue
{
    static void Main()
    {
        Console.Title = "Problem 4. Unicode Value";
        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

        char symbol = '\u002A'; // The hex of 42 is 2A.
        Console.WriteLine(symbol);

        //Just a check for cyrillic symbols
        //Console.WriteLine("и кирилица работи");
    }
}
