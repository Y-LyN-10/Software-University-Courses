namespace Animals
{
    using System;

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
                Console.WriteLine("The argument must not to be empty or null.");
                throw;
            }
        }

        public static void CheckForNegative(object number, string argumentName)
        {
            try
            {
                if (double.Parse(number.ToString()) < 0)
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
