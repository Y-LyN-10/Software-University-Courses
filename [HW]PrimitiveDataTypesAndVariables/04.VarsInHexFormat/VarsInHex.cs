// Problem 3. Variable in Hexadecimal Format
// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
// Use Windows Calculator to find its hexadecimal representation. 
// Print the variable and ensure that the result is “254”.

using System;

class VarsInHex
{
    static void Main()
    {
        Console.Title = "Problem 3. Variable in Hexadecimal Format";

        //This value is declared as integer variable and converted to hexadecimal format
        int value = 254;
        Console.WriteLine(value.ToString("X")); //FE
        
        //Declared in hexadecimal format and converted to it's decimal representation.
        int hexValue = 0xFE;
        Console.WriteLine(hexValue.ToString("D")); //254

        //http://msdn.microsoft.com/en-us/library/dwhawy9k%28v=vs.110%29.aspx

    }
}