// Problem 3. Play with MSDN Library
// Play with Microsoft Developer Network (MSDN) Library Documentation. 
// You may find it online at http://msdn.microsoft.com/library.
// •	Find information about Console.WriteLine() method in MSDN.
// •	Find information about the Console class.
// •	Find information about the class keyword.

using System;
using System.Text;

/*Classes are declared using the keyword class
  Classes that you declare directly within a namespace, 
  not nested within other classes, can be either public 
  or internal. Classes are internal by default.*/

class playMSDN
{
    static void Main()
    {
        Console.Title = "Problem 3.	Play with MSDN Library";
        Console.InputEncoding = Encoding.GetEncoding("UTF-8");

        /* - Console.WriteLine() is a method that writes the specified data, followed 
             by the current line terminator, to the standard output stream. Example: */

        Console.WriteLine("Hello, Stranger! ^^");

        /* - Console class represents the standard input, output, and error streams 
             for console applications. This class cannot be inherited.*/

        Console.WriteLine("Let me show you some of my favorite commands from the Console class:\n");
        Console.WriteLine("1. I set Console.Title and Input/Output Encodings\n");
        Console.WriteLine("2. I set new WindowHeight and WindowWidth. Just wait to see it ;)\n");
        Console.Write("3. I set Background and Foreground colors: (Write something to test) ");
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        string something = Console.ReadLine();

        //Change the colors...
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WindowHeight = Console.BufferHeight + 3;
        Console.WindowWidth = Console.BufferWidth +1 ;
        
        //Draw the sky...
        for (int i = 25; i > 3; i--)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - i);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(new string(' ', Console.WindowWidth));
        }

        //Draw the house ^^
        Console.BackgroundColor = ConsoleColor.Cyan;  //white clears the color
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(Console.WindowWidth - 15, Console.WindowHeight - 7);
        Console.Write(@"   ___I_  ");
        Console.SetCursorPosition(Console.WindowWidth - 15, Console.WindowHeight - 6);
        Console.Write(@"  /\-_--\ ");
        Console.SetCursorPosition(Console.WindowWidth - 15, Console.WindowHeight - 5);
        Console.Write(@" /  \_-__\");
        Console.SetCursorPosition(Console.WindowWidth - 15, Console.WindowHeight - 4);
        Console.Write(@" |[]| [] |");

        //And turn back...
        Console.SetCursorPosition(0, 8);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Gray;
        
        System.Threading.Thread.Sleep(1500); //this adds some "pause" time

//----------------------------------------------------------------------------------------------------------------//
//-------------------------------------YOU CAN STOP READING THE CODE HERE-----------------------------------------//
//------------------- CAUTION! The code below may cause confusion xD Read it on your care! -----------------------//
//----------------------------------------------------------------------------------------------------------------//

        //I know, the things becomes a little complicated for a first homework.
        //I use methods to avoid repeating code, some if-statements and loops.
        //This part below is made only for personal practice and fun. 
        //If you don't understand it, don't worry, just don't read it.
        //But You can save this code and use it some day for some simple game logic. 

        Console.Write("\n4. Console.Key - Do you want to test it? ");
        TestKey();
    }

    private static void TestKey()
    {
        Console.Write("Enter y/n for 'yes' or 'no': ");
        ConsoleKeyInfo userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.Y)
        {
            Console.Write("\n\n   Yeah! Okaay, looks like it works. \n\n   Now, there's a little " +
                "surprise for you! Enter your favorite number! ");
            int number = int.Parse(Console.ReadLine()); 

            TrollBeep(number); 
        }
        else if (userInput.Key == ConsoleKey.N)
        {
            Console.Write("\n   You just tested it by pressing the 'n' key :} Thank you, Bye-bye\n   ");
            Console.SetCursorPosition(1, Console.WindowHeight - 2);
            return;
        }
        else
        {
            Console.WriteLine("\rInvalid input key. Try again.");
            TestKey();
        }
    }
  
    private static void TrollBeep(int number)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(10, 20);
        Console.Write(new string(' ', 29));
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write("TROLOLOLO\n");
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n" + new string(' ', 32) + "Enjoy the beat (beep) :D\n");
        System.Threading.Thread.Sleep(1000);

        for (int i = 0; i < number; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("\r" + new string(' ', 41) + "BEEP");
                Console.Beep();
            }
            else
            {
                Console.Write("\r" + new string(' ', 47));
                Console.Beep();
            }
        }

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(1, Console.WindowHeight - 2);
    }
}