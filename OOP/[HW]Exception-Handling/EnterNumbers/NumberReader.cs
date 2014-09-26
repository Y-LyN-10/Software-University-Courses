namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public static class NumberReader
    {
        public const int NumberOfLoops = 10;
        public static List<int> numbers = new List<int>();

        private static void ReadNumber(int startNumber, int endNumber, int index)
        {
            if (index > NumberOfLoops)
            {
                Console.WriteLine("You entered these numbers: ");
                foreach (var number in numbers)
                {
                    Console.Write(number + ", ");
                }

                Console.WriteLine("Thank you!");
                Console.WriteLine("Have a good luck in the Lottery!");
            }
            else
            {
                Console.Write(string.Format("a{0} = ", index));
                int number;
                string input = Console.ReadLine();
                bool isNumeric = int.TryParse(input, out number);

                try
                {
                    if (!isNumeric)
                    {
                        throw new FormatException();
                    }
                    if (number < startNumber || number > endNumber)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    startNumber = number;
                    numbers.Add(number);
                    ReadNumber(startNumber, endNumber, index + 1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number");
                    ReadNumber(startNumber, endNumber, index);
                    //throw;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine(string.Format("Next number should be in range[{0}..100]", startNumber));
                    ReadNumber(startNumber, endNumber, index);
                    //throw;
                }
            }
        }

        static void Main()
        {
            Console.Title = "Problem 2. Enter Numbers";

            /* Write a method ReadNumber(int start, int end) that enters an integer number in given range
               [start…end]. If an invalid number or non-number text is entered, the method should throw an
               exception. Using this method write a program that enters 10 numbers: a1, a2, … a10, such that
               1 < a1 < … < a10 < 100. If the user enters an invalid number, let the user to enter again. */

            int startNumber = 1;
            int endNumber = 100;

            ReadNumber(startNumber, endNumber, 1);
        }
    }
}
