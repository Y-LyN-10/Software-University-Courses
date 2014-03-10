// Problem 5. Unicode Value
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
        Console.Title = "Problem 5. Unicode Value";
        Console.OutputEncoding = Encoding.GetEncoding("UTF-16");

        char symbol = '\u0048'; // Hex of 72. It's 48.
        Console.WriteLine(symbol);

        //TOASK: How to print runes :)
       
        char rune = '\u16BA'; //ᚺ 0 Rune Hagalaz
        Console.WriteLine(rune);
        Console.WriteLine("Кирилица работи");
    }
}
