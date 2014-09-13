//Task download here: bgcoder.com/Contests/Practice/DownloadResource/514

using System;

class Nightmare
{
    static void Main()
    {
        string text = Console.ReadLine();

        int sum = 0;
        int count = 0;

        for (int i = 1; i < text.Length; i += 2)
        {     
            if (char.IsDigit(text[i]))
            {
                count++;
                sum += (text[i]-48);
            }
        }

        Console.WriteLine("{0} {1}", count, sum);
    }
}