// Problem 1. Exchange If Greater
// Write an if-statement that takes two integer variables a and b 
// and exchanges their values if the first one is greater than the 
// second one. As a result print the values a and b, separated by 
// a space. Example: a = 5, b = 2 --> Result: a = 2, b = 5;

using System;

class ExchangeIf
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(new string('-',6));

        if (a == b)
        {
            Console.WriteLine("Equals");
        }
        else if (a > b)
        {
            Console.WriteLine("a = {0}\nb = {1}\n", b, a);
        }
        else
        {
            Console.WriteLine("a = {0}\nb = {1}\n", a, b);
        }
        
        //All this could be solved with the operator ?:
        //Console.Write("a = {0}\nb = {1}\n", (a > b) ? b : a, (a > b) ? a : b);

       



        


    
    }
}

