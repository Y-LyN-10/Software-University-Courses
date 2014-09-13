// Problem 7. Quotes in Strings
// Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings. 
// Print the variables to ensure that their value was correctly defined.

using System;

class QuotesInStrings
{
    static void Main()
    {
        Console.Title = "Problem 7. Quotes in Strings"; //I just love this command, so... it will be everywhere, lol.

        string quoteVariant1 = "The \"use\" of quotations causes difficulties.";
        string quoteVariant2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quoteVariant1);
        Console.WriteLine(quoteVariant2);
    }
}

