// Problem 12.	** Falling Rocks
// Implement the "Falling Rocks" game in the text console. A small dwarf stays at the 
// bottom of the screen and can move left and right (by the arrows keys). A number of 
// rocks of different sizes and forms constantly fall down and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate 
// density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
// Implement collision detection and scoring system.

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.IO;

class FallingRocks
{

    struct Rock
    {
        public int x;
        public int y;
        public char c;
        public ConsoleColor color;
    }
    struct Dwarf
    {
        public int myX;
        public int myY;
        public string str;
        public ConsoleColor dcolor;
    }

    class fallingRocks
    {
        static void PrintPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.DarkGreen)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        static void PrintStringPosition(int x, int y, string str, ConsoleColor dcolor = ConsoleColor.Cyan)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = dcolor;
            Console.Write(str);
        }

        static void PrintDwarf(int x, int y, string str, ConsoleColor dcolor = ConsoleColor.Blue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = dcolor;
            Console.Write(str);
        }

        private static void LoadScreen()
        {
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 55;

            StreamReader screen = new StreamReader(@"..\..\media\Screen.txt");

            using (screen)
            {
                List<string> startScreen = new List<string>();
                string reader = screen.ReadLine();
                while (reader != null)
                {
                    startScreen.Add(reader);
                    reader = screen.ReadLine();
                }

                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(startScreen[i]);
                }

                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.SetCursorPosition(14, 28);
                        Console.Write("\r" + new string(' ', 14) + ". . . L O A D I N G . . .");
                    }
                    else
                    {
                        Console.SetCursorPosition(15, 28);
                        Console.Write("\r" + new string(' ', 40));
                    }
                    Thread.Sleep(500);
                }

                //TODO: Menu with options: /Play(choose difficulty), controls, highscores, exit

                PlayGame();
            }
        }

        static void Main()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\media\DisturbedTheGame.wav");
            simpleSound.Play();

            //Main ---> LoadScreen ---> PlayGame ---> ReadKey ---> PlayGame
            LoadScreen();
        }

        private static void PlayGame()
        {
            int playfieldWidth = 32;
            int livesCount = 3;
            int scoresCount = 0;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 55;
            Dwarf dwarf = new Dwarf();
            dwarf.myX = 12;
            dwarf.myY = Console.WindowHeight - 1;
            dwarf.str = "(0)";
            Random randomGenerator = new Random();
            List<Rock> rocks = new List<Rock>();

            while (true)
            {
                char[] symbol = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
                Random randomChar = new Random();
                int c = randomChar.Next(0, 12);
                char symbolPrint = symbol[c];

                string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
                Random randomColor = new Random();
                string randomColorName = colorNames[randomColor.Next(colorNames.Length)];
                Rock newRock = new Rock();
                newRock.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), randomColorName);
                if (newRock.color == ConsoleColor.Black || newRock.color == ConsoleColor.White) newRock.color = ConsoleColor.Yellow;
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0;
                newRock.c = symbolPrint;
                rocks.Add(newRock);

                // Move rocks
                List<Rock> newList = new List<Rock>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    Rock oldRock = rocks[i];
                    newRock.x = oldRock.x;
                    newRock.y = oldRock.y + 1;
                    newRock.c = oldRock.c;
                    newRock.color = oldRock.color;
                    if (newRock.x == dwarf.myX && newRock.y == dwarf.myY || newRock.x == dwarf.myX + 1
                        && newRock.y == dwarf.myY || newRock.x == dwarf.myX + 2 && newRock.y == dwarf.myY)
                    {
                        livesCount--;
                        Console.Beep();
                        if (livesCount <= 0)
                        {
                            PrintStringPosition(10, 7, "GAME OVER!", ConsoleColor.Red);
                            PrintStringPosition(8, 8, "Play again? y/n", ConsoleColor.Yellow);
                            Console.ForegroundColor = ConsoleColor.White;

                            ReadKey();

                            return;
                        }
                    }
                    if (newRock.y < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                        scoresCount++;
                    }
                }
                rocks = newList;

                // Move the dwarf
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.myX - 1 >= 0)
                        {
                            dwarf.myX--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.myX + 1 < playfieldWidth)
                        {
                            dwarf.myX++;
                        }
                    }
                }
                Console.Clear();

                // Redraw playfield
                PrintDwarf(dwarf.myX, dwarf.myY, dwarf.str, dwarf.dcolor = ConsoleColor.Yellow);
                foreach (Rock rock in rocks)
                {
                    PrintPosition(rock.x, rock.y, rock.c, rock.color);
                }

                // Draw info

                for (int borderY = 0; borderY <= Console.WindowHeight - 1; borderY++)
                {
                    PrintStringPosition(33, borderY, "|", ConsoleColor.DarkMagenta);
                }

                PrintStringPosition(36, 4, "Falling Rocks", ConsoleColor.Gray);
                PrintStringPosition(36, 7, "Lives Left: " + livesCount, ConsoleColor.Red);
                PrintStringPosition(36, 8, "Score: " + scoresCount, ConsoleColor.Yellow);
                PrintStringPosition(36, 11, "Controls:", ConsoleColor.DarkMagenta);
                PrintStringPosition(36, 12, "Use the left", ConsoleColor.Gray);
                PrintStringPosition(36, 13, "and right arrow", ConsoleColor.Gray);
                PrintStringPosition(36, 14, "to move the dwarf", ConsoleColor.Gray);

                //Slow down the program
                Thread.Sleep(150);
            }
        }

        private static void ReadKey()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.Y)
            {
                PlayGame();
            }
            else if (userInput.Key == ConsoleKey.N)
            {
                PrintStringPosition(6, 11, "Thank you. Bye-bye!", ConsoleColor.DarkMagenta);
                Console.SetCursorPosition(0, 0);
                return;
            }
            else
            {
                Console.SetCursorPosition(26,29);
                ReadKey();
            }
        }
    }
}


