using System;
using System.Linq;

class MagicBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            int result = 0;
            while(num > 0)
            {
                int lastBit = num & 1;
                num = num >> 1;
                result = result << 1;
                result = result | lastBit;   
            }

            Console.WriteLine(result);
        }
    }
}
