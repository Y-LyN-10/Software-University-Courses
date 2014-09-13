// Problem 11.* Number as Words
// Write a program that converts a number in the range [0…999] 
// to words, corresponding to the English pronunciation. 

using System;

class Program
{
    static void Main()
    {
        string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",};
        string[] tens = { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] numsToTwenty = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        Console.Write("Enter a number in range [0...999]: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0 && num > 999)
        {
            Console.Clear();
            Console.WriteLine("Invalid number. Try again, please");
            Main();
        }
        else
        {
            if (num < 10) // 0 to 9
            {
                if (num == 0) Console.WriteLine("zero");
                else Console.WriteLine(ones[num]);
            }
            else if (num >= 10 && num < 20) // 11 to 19
            {
                Console.WriteLine(numsToTwenty[num % 10]);
            }
            else if (num >= 20 && num < 100) // 20 to 99
            {
                Console.WriteLine("{0} {1}", tens[num / 10], ones[num % 10]);
            }
            else if (num >= 100 && num < 1000) // 101 to 999
            {
                Console.Write("{0} Hundred ", ones[num / 100]);
                byte midDigit = (byte)((num / 10) % 10); // find middle digit
                byte lastDigit = (byte)((num % 10) % 10); // find last digit

                if (midDigit == 0 && lastDigit == 0)
                {
                    Console.WriteLine();
                }
                else if (midDigit == 0) // *00 to *09
                {
                    Console.WriteLine("And {0}", ones[lastDigit]);
                }
                else if (midDigit == 1) // *10 to *19
                {
                    Console.WriteLine("And {0}", numsToTwenty[lastDigit]);
                }
                else // *20 to *99
                {
                    Console.WriteLine("{0}-{1}", tens[midDigit], ones[lastDigit]);
                }
                if (num == 666)
                {
                    Console.WriteLine("The Number Of The Beast!");
                }
            }
        }

        Console.WriteLine();
    }
}

