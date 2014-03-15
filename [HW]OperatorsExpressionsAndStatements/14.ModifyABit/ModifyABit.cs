// Problem 14. Modify a Bit at Given Position
// We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a
// sequence of operators (a few lines of C# code) that modifies n to hold the value v at
// the position p from the binary representation of n while preserving all other bits in n. 

// Some Examples:
// n    | binary representation of n | p |	v |	binary result	   | result |
// 5	|     00000000 00000101	     | 2 |	0 |	00000000 00000001  |   1    |
// 0	|     00000000 00000000	     | 9 |	1 |	00000010 00000000  |  512   |
// 5343	|     00010100 11011111	     | 7 |	0 |	00010100 01011111  |  5215  |

using System;

    class ModifyABit
    {
        static void Main()
        {
            Console.Write("N = ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Bit value = "); //1 or 0
            sbyte bitValue = sbyte.Parse(Console.ReadLine());

            Console.Write("Position = ");
            sbyte position = sbyte.Parse(Console.ReadLine());
            
            int result;

            if (bitValue == 0)
            {
                int mask = ~(1 << position);
                result = number & mask;
            }
            else
            {
                int mask = 1 << position;         
                result = number | mask;      
            }

            string binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            string binaryResult = Convert.ToString(result, 2).PadLeft(16, '0');

            Console.WriteLine("Result = {0}\nBinary representation of N: {1}" +
                "\nBinary final result:        {2}", result, binaryNumber, binaryResult);
        }
    }

