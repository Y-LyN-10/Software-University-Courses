// Problem 2. Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth. 
// Write a program that calculates the weight of a man on the moon by a given 
// weight on the Earth. 

// Examples:
// weight |  weight on the Moon
// 86	  |     14.62
// 74.6	  |     12.682
// 53.7	  |      9.129

using System;
using System.Globalization;
using System.Threading;

class Gravity
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("How much do you weight? ");
        double weightOnEarth = double.Parse(Console.ReadLine());
      
        //Calculate a percentage
        double weigthOnMoon = weightOnEarth * 17 / 100;
        Console.WriteLine("Now, imagine that you're walking trough the moon deserts..." +
            "\nYour weight there is only {0} kilos! ", weigthOnMoon);
    }
}

