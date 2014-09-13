// Problem 4. Print a Deck of 52 Cards
// Write a program that generates and prints all possible cards from a standard 
// deck of 52 cards (without the jokers). The cards should be printed using the 
// classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 
// 2 to A. Print each card face in its four possible suits: clubs, diamonds, 
// hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintADeck
{
    static void Main()
    {
        Console.WriteLine("\n Version 1:\n");

        for (int cardValue = 2; cardValue <= 14; cardValue++)
        {
            //start from 3, because of the (char) values in the 
            //ASCII Table, where 3 = ♥, 4 = ♦, 5 = ♣, 6 = ♠ ...
            for (int suit = 3; suit <= 6; suit++) 
            {
                string card;
                char symbol = (char)suit;

                if (cardValue <= 10)
                {
                    card = cardValue.ToString();
                    Console.Write(card.PadLeft(2) + symbol.ToString() + " ");
                }

                else
                {
                    switch (cardValue)
                    {
                        case 11: Console.Write("J".PadLeft(2) + symbol.ToString() + " "); break;
                        case 12: Console.Write("Q".PadLeft(2) + symbol.ToString() + " "); break;
                        case 13: Console.Write("K".PadLeft(2) + symbol.ToString() + " "); break;
                        case 14: Console.Write("A".PadLeft(2) + symbol.ToString() + " "); break;

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        //----------------------------------------------------------------------------------------------

        //Another nice solution, but ineligible to the conditions of this problem 
        //(because it's said to "use a switch-case statements".) But... i love it :)

        //There are two arrays with all card values and colors. And we just join these values
        //using String.Join() method for each of them.

        Console.WriteLine("\n Version 2: \n");
        string[] cardValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", " " };
        string[] cardSuits = { "♥", "♦", "♣", "♠" }; //2♥ 2♦ 2♣ 2♠

        foreach (string value in cardSuits)
        {
            Console.Write(" ");
            Console.WriteLine(String.Join(value + " ", cardValues));
        }

        Console.WriteLine();
    }
}

