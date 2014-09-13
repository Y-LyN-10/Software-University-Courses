// Problem 12. Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double
// variable. Try to print these variables at the console. Try to add some
// number or the null literal to these variables and print the result.

using System;

class NullableValues
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 12. Null Values Arithmetic";

        int? nullableInt = null;
        double? nullableDouble = null;

        int? nullMathInt = nullableInt + null;
        double? nullMathDouble = nullableDouble / 0;

        Console.WriteLine(nullableInt);
        Console.WriteLine(nullableDouble);
        Console.WriteLine(nullableInt - nullMathInt);
        Console.WriteLine(nullMathDouble);

        //Nothing happens, yes.
    }
}
