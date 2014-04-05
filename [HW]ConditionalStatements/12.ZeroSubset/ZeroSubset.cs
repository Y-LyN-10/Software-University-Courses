// Problem 12.* Zero Subset
// We are given 5 integer numbers. Write a program that finds 
// all subsets of these numbers whose sum is 0. Assume that 
// repeating the same subset several times is not a problem. 

using System;

class ZeroSubset
{
    static void Main()
    {
        //The input is in one line, so we need to split it and convert to integer
        string input = Console.ReadLine();
        string[] strNumbers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(strNumbers[i]);
        }

        // it's more easy to write letters, 
        // then array indexes, so declare
        // new variables for each of them

        int a = numbers[0];
        int b = numbers[1];
        int c = numbers[2];
        int d = numbers[3];
        int e = numbers[4];

        // Okay, many hours I tried to solve this problem with arrays, string processions, bitwise operations and etc...
        // But no one of these solutions worked for all tests, result wasn't formated EXACTLY like the needed output and 
        // the code was much longer. I watched many solutions and no one of them worked absolutely correctly, even the 
        // solution in the book (Intro into programming) So... this maybe looks stupid, but I think that this is the most
        // appropriate solution to this problem.

        Console.WriteLine();
        if ((a + b + c + d + e) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            return;
        }

        if ((a + b) == 0) Console.WriteLine("{0} + {1} = 0", a, b);
        if ((a + c) == 0) Console.WriteLine("{0} + {1} = 0", a, c);
        if ((a + d) == 0) Console.WriteLine("{0} + {1} = 0", a, d);
        if ((a + e) == 0) Console.WriteLine("{0} + {1} = 0", a, e);
        if ((c + b) == 0) Console.WriteLine("{0} + {1} = 0", c, b);
        if ((c + d) == 0) Console.WriteLine("{0} + {1} = 0", c, d);
        if ((d + b) == 0) Console.WriteLine("{0} + {1} = 0", d, b);
        if ((e + b) == 0) Console.WriteLine("{0} + {1} = 0", e, b);
        if ((e + d) == 0) Console.WriteLine("{0} + {1} = 0", e, d);
        if ((e + c) == 0) Console.WriteLine("{0} + {1} = 0", c, e);

        if ((a + b + c) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
        if ((a + b + d) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
        if ((a + b + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
        if ((a + c + d) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
        if ((a + c + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
        if ((a + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
        if ((b + c + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
        if ((b + d + c) == 0) Console.WriteLine("{0} + {1} + {2} = 0", b, d, c);
        if ((b + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
        if ((c + d + e) == 0) Console.WriteLine("{0} + {1} , {2} = 0", c, d, e);

        if ((a + b + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
        if ((a + b + c + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
        if ((a + b + d + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
        if ((a + e + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, e, c, d);
        if ((e + b + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", e, b, c, d);

        else
        {
            Console.WriteLine("no zero subset");
        }
    }
}
