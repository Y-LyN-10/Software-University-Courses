using System.Runtime.Remoting.Messaging;

namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public static class NumberReader
    {
        public const int NumberOfLoops = 10;
        public static List<int> numbers = new List<int>();

        private static void ReadNextNumber(int startNumber, int endNumber, int index)
        {
            if (index > NumberOfLoops)
            {
                PrintNumbers(numbers);
            }
            else
            {
                Console.Write(string.Format("a{0} = ", index));
               
                string input = Console.ReadLine();
                bool numberIsValid = ValidateNumber(input, startNumber, endNumber);

                if (numberIsValid)
                {
                    int number = int.Parse(input);
                    numbers.Add(number);
                    startNumber = number;
                    ReadNextNumber(startNumber, endNumber, index + 1);
                }
                else
                {
                    ReadNextNumber(startNumber, endNumber, index);
                }
            }
        }

        private static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine("You entered these numbers: ");
            foreach (var number in numbers)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine("Thank you!");
        }

        private static bool ValidateNumber(string input, int startNumber, int endNumber)
        {
            int number;
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

                return true;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid Number");
                return false;
            }
            catch (ArgumentException)
            {
                Console.WriteLine(string.Format("Next number should be in range[{0}..100]", startNumber));
                return false;
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

            ReadNextNumber(startNumber, endNumber, 1);
        }
    }
}
