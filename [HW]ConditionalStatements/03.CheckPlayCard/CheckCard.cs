// Problem 3. Check for a Play Card
// Classical play cards use the following signs to designate 
// the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if 
// it is a valid card sign or “no” otherwise. 

using System;

class CheckCard
{
    static void Main()
    {
        //Read string, because input can be more than one symbol
        string input = Console.ReadLine();
        
        //declare new variables
        char letter;
        int number;

        //check if the input is a letter, or a number
        bool isLetter = char.TryParse(input, out letter);
        bool isNumber = int.TryParse(input, out number);

        //and check for a playable card. 
        if (number >= 2 && number <= 10)
        {
            Console.WriteLine("yes");
        }
        else
        {
            switch (letter)
            {
                case 'J': case 'Q': case 'K':  case 'A': Console.WriteLine("yes"); break;
                default: Console.WriteLine("no"); break;
            }
        }

    }
}

