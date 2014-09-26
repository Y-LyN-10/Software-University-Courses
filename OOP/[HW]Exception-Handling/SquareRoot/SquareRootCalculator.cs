namespace SquareRoot
{
    using System;

    class SquareRootCalculator
    {
        static void Main()
        {
            Console.Title = "Problem 1. Square Root Calculator";

            /* Write a program that reads an integer number and calculates and prints it's 
               square root. If the number is invalid or negative, print "Invalid number". 
               In all cases finally print "Good bye". Use try-catch-finally. */

            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            CalculateSquareRoot(input);
        }

        private static void CalculateSquareRoot(string input)
        {
            int number;
            bool isNumeric = int.TryParse(input, out number);

            try
            {
                if (!isNumeric)
                {
                    throw new FormatException();
                }
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                var result = Math.Sqrt(number);
                Console.WriteLine(string.Format("Square root of {0} is {1}", number, result));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
                //throw;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Number: Number can't be negative");
                //throw;
            }
            finally
            {
                Console.WriteLine("Good bye! (or try again)");
                Main();
            }
        }
    }
}
