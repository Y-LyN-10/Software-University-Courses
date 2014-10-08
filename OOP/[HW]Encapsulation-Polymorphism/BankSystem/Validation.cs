namespace BankSystem
{
    using System;

    // Some very basic validation - not full really
    public static class Validation
    {
        public static void CheckForNullOrEmpty(string value, string argumentName)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine(argumentName);
                throw;
            }
        }

        public static void CheckForMinimalValue(decimal value, string argumentName)
        {
            try
            {
                if (value < 0.01m)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine(argumentName);
                throw;
            }
        }

        public static void CheckForNegativeOrZero(object number, string argumentName)
        {
            try
            {
                if (double.Parse(number.ToString()) <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The argument must not to be negative or zero.");
                throw;
            }
        }
    }
}
