// Problem 2. Bonus Score
// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
// •	If the score is between 1 and 3, the program multiplies it by 10.
// •	If the score is between 4 and 6, the program multiplies it by 100.
// •	If the score is between 7 and 9, the program multiplies it by 1000.
// •	If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter, please, one digit number in the range [1..9]: ");
        int digit = int.Parse(Console.ReadLine());

        //I use "if/else if/else" statements, because they are self-xoring and
        //the 'else' statement is working only when all the other statements are false.

        if (digit <= 0 || digit > 9)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Invalid score! Try again \n");
            Main(); //This loads the Main method again and the code is again. 
        }
        else if (digit >= 1 && digit <= 3)
        {
            digit *= 10;
            Console.WriteLine("Congratulations! You got a bonus *10 and your total result is: " + digit);
        }
        else if (digit >= 4 && digit <= 6)
        {
            digit *= 100;
            Console.WriteLine("You got a bonus *100 and your total result is: " + digit);
        }
        else //(digit >= 7 && digit <= 9)
        {
            digit *= 1000;
            Console.WriteLine("Congratulations! You got the highest bonus (*1000) and your total result is: " + digit);
        }
        
    }
}

