// Problem 16**  Bit Exchange (Advanced)
// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a
// given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 

//Some Examples:
//n	           |  p	 | q  |	k  | binary representation of n	          | binary result	                      result
//1140867093   |  3	 | 24 |	3  | 01000100 00000000 01000000 00010101  | 01000010 00000000 01000000 00100101	| 1107312677
//2369124121   |  2	 | 22 |	10 | 10001101 00110101 11110111 00011001  |	01110001 10110101 11111000 11010001	| 1907751121
//987654321	2  |  2	 | 8  |	11 | -                                    | -	                                | overlapping
//33333333333  | -1	 | 0  |	33 | -	                                  | -	                                | out of range

using System;

class AdvancedBitExchange
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine()); 
        string binaryNumber = Convert.ToString(num, 2).PadLeft(32, '0');

        Console.Write("p = ");
        sbyte p = sbyte.Parse(Console.ReadLine());

        if (p >= 0)
        {
            Console.WriteLine("Binary representation of N: {0}", binaryNumber);   
        }
        
        Console.Write("q = ");
        sbyte q = sbyte.Parse(Console.ReadLine());
        Console.Write("k = ");
        sbyte k = sbyte.Parse(Console.ReadLine());

        if (Math.Max(p, q) + k > 32 || Math.Min(p, q) < 0)
        {
            Console.WriteLine("out of range");
            return;
        }

        if (Math.Abs(q - p) < k)
        {
            Console.WriteLine("overlapping");
            return;
        }

        for (byte i = 0; i < k; i++)
        {
            num = BitExchange(num, p + i, q + i);
        }

        Console.WriteLine("Result: {0}", num);
        string binaryResult = Convert.ToString(num, 2).PadLeft(16, '0');
        Console.WriteLine("Binary result: {0}", binaryResult);

    }

    static long BitExchange(long num, int p, int q)
    {
        long shiftNumP = num >> p;
        byte bitP = (byte)(shiftNumP & 1);
        long shiftNumQ = num >> q;
        byte bitQ = (byte)(shiftNumQ & 1);

        //change bit P
        if (bitP == 0)
        {
            long maskP = (long)~(1 << q);
            num = num & maskP;
        }
        else
        {
            long maskP = (long)(1 << q);
            num = num | maskP;
        }

        //change bit Q
        if (bitQ == 0)
        {
            long maskQ = (long)~(1 << p);
            num = num & maskQ;
        }
        else
        {
            long maskQ = (long)1 << p;
            num = num | maskQ;
        }

        return num;
    }

}

