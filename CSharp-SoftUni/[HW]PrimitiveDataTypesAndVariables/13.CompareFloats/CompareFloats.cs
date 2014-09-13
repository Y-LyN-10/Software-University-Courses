// Problem 13.*  Comparing Floats
// Write a program that safely compares floating-point numbers (double) 
// with precision eps = 0.000001. Note that we cannot directly compare 
// two floating-point numbers a and b by a==b because of the nature of 
// the floating-point arithmetic. Therefore, we assume two numbers are 
// equal if they are more closely to each other than a fixed constant eps. 
// Example: 5.00000005 and 5.00000001 --> True

using System;

class CompareFloats
{
    static void Main()
    {
        Console.Title = "Problem 13. Comparing Floats";

        //Read numbers from the console
        Console.WriteLine("Enter the first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        //Comparing
        //Math.Abs method returns the absolute value of a double-precision floating-point number.
        //And we can determine it's accuracy (< 0.000001)
        bool compare = (Math.Abs(firstNum - secondNum) < 0.000001);

        Console.WriteLine();

        if (compare)
        {
            Console.WriteLine((compare) + ": Numbers are equal with a precision of 0.000001.");
        }
        else
        {
            Console.WriteLine((compare) + ": Numbers are not equal with a precision of 0.000001.");
        }
    }
}