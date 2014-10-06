namespace People
{
    using System;
    using System.Text.RegularExpressions;

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

        public static void ChekForValidFacultyNumber(string value, string argumentName)
        {
            CheckForNullOrEmpty(value, argumentName);

            try
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The argument must to be in range [5..10].");
                throw;
            }

            var regex = new Regex("[\\dA-Za-z]");
            var matches = regex.Matches(value);

            try
            {
                if (value.Length > matches.Count)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid argument. Use only digits or letters");
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

