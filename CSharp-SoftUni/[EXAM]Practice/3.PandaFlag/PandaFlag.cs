using System;

class PandaFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int currentCharIndex = 0;
        char currentChar = alphabet[0];
        char nextChar = alphabet[1];

        int innerSharps = n - 2;

        for (int i = 0; i <= n / 2 - 1; i++)
        {
            innerSharps = (n - 2 * i) - 2;

            Console.Write(new string('~', i));
            Console.Write(innerSharps < 0 ? currentChar + "" : currentChar + (new string('#', innerSharps)) + nextChar);
            Console.WriteLine(new string('~', i));

            currentCharIndex+=2;
            currentChar = alphabet[currentCharIndex % 26];
            nextChar = alphabet[(currentCharIndex + 1) % 26];
        }

        Console.WriteLine(new string('-', n/2) + currentChar + new string('-', n/2));
        currentCharIndex++;

        for (int j = n / 2 -1; j >= 0; j--)
        {
            currentChar = alphabet[currentCharIndex % 26];
            nextChar = alphabet[(currentCharIndex + 1) % 26];

            innerSharps = (n - 2 * j) - 2;

            Console.Write(new string('~', j));
            Console.Write(innerSharps < 0 ? currentChar + "" : currentChar + (new string('#', innerSharps)) + nextChar);
            Console.WriteLine(new string('~', j));
            
            currentCharIndex += 2;
        }
    }
}

