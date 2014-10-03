using System;
using System.Collections.Generic;
using System.Linq;

public class Mines
{
    public static void Main(string[] arguments)
    {
        string command = string.Empty;
        char[,] playField = CreatePlayField();
        char[,] bombField = CreateBombField();
        int personalScore = 0;
        bool hitBomb = false;
        List<Score> topScorers = new List<Score>(6);
        int row = 0;
        int col = 0;
        bool isNewGame = true;
        const int MaxScore = 35;
        bool isWon = false;

        do
        {
            if (isNewGame)
            {
                Console.WriteLine("Let's play Minesweeper! :) ");
                Console.WriteLine("Try your luck :) and find the cells without bombs or ...");
                Console.WriteLine("...you will die :))))))");
                Console.WriteLine("\n####################################");
                Console.WriteLine("Menu:");
                Console.WriteLine("'top' - show the rating");
                Console.WriteLine("'restart' - start a new game");
                Console.WriteLine("'exit' - exit the game");
                Console.WriteLine("'4x7' - example for entering row and col");
                Console.WriteLine("####################################");
                DrawPlayField(playField);
                isNewGame = false;
            }

            Console.Write("Enter row and col[row x col]: ");
            command = Console.ReadLine().Trim();
            if (command.Length >= 3)
            {
                if (int.TryParse(command[0].ToString(), out row) &&
                int.TryParse(command[2].ToString(), out col) &&
                    row <= playField.GetLength(0) && col <= playField.GetLength(1))
                {
                    command = "turn";
                }
            }

            switch (command)
            {
                case "top":
                    GetRating(topScorers);
                    break;
                case "restart":
                    playField = CreatePlayField();
                    bombField = CreateBombField();
                    DrawPlayField(playField);
                    hitBomb = false;
                    isNewGame = false;
                    break;
                case "exit":
                    Console.WriteLine("Bye Bye! :)");
                    break;
                case "turn":
                    if (bombField[row, col] != '*')
                    {
                        if (bombField[row, col] == '-')
                        {
                            EnterSurroundingBombCount(playField, bombField, row, col);
                            personalScore++;
                        }

                        if (MaxScore == personalScore)
                        {
                            isWon = true;
                        }
                        else
                        {
                            DrawPlayField(playField);
                        }
                    }
                    else
                    {
                        hitBomb = true;
                    }

                    break;
                default:
                    Console.WriteLine("\nError: Invalid call\n");
                    break;
            }

            if (hitBomb)
            {
                DrawPlayField(bombField);

                Console.WriteLine("You hit a bomb and ... you are dead. You should try Again");
                Console.Write("\nPersonal Score: {0} Enter your Nickname: ", personalScore);
                string nickname = Console.ReadLine();
                Score playerScore = new Score(nickname, personalScore);
                if (topScorers.Count < 5)
                {
                    topScorers.Add(playerScore);
                }
                else
                {
                    for (int index = 0; index < topScorers.Count; index++)
                    {
                        if (topScorers[index].Points < playerScore.Points)
                        {
                            topScorers.Insert(index, playerScore);
                            topScorers.RemoveAt(topScorers.Count - 1);
                            break;
                        }
                    }
                }

                topScorers.Sort((Score firstPlayer, Score secondPlayer)
                    => secondPlayer.Nickname.CompareTo(firstPlayer.Nickname));
                topScorers.Sort((Score firstPlayer, Score secondPlayer)
                    => secondPlayer.Points.CompareTo(firstPlayer.Points));
                GetRating(topScorers);

                playField = CreatePlayField();
                bombField = CreateBombField();
                personalScore = 0;
                hitBomb = false;
                isNewGame = true;
            }

            if (isWon)
            {
                Console.WriteLine("\nBRAVO! You just beat the sh*t out of me! Max Score: {0} reached! ", MaxScore);
                DrawPlayField(bombField);
                Console.WriteLine("Enter your Nickname/probably MASTER :)/: ");
                string nickname = Console.ReadLine();
                Score playerScore = new Score(nickname, personalScore);
                topScorers.Add(playerScore);
                GetRating(topScorers);
                playField = CreatePlayField();
                bombField = CreateBombField();
                personalScore = 0;
                isWon = false;
                isNewGame = true;
            }
        }
        while (command != "exit");
        Console.WriteLine("Have a nice day! :)");
        Console.WriteLine("Made in Bulgaria!");
        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
    }

    private static void GetRating(List<Score> topScorers)
    {
        Console.WriteLine("\nRating:");
        if (topScorers.Count > 0)
        {
            for (int i = 0; i < topScorers.Count; i++)
            {
                Console.WriteLine("{0}. {1} --> {2} opened cells", i + 1, topScorers[i].Nickname, topScorers[i].Points);
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Nobody is in here! Maybe you are THE CHOSEN?! :)\n");
        }
    }

    private static void EnterSurroundingBombCount(char[,] playField, char[,] bombField, int row, int col)
    {
        char surroundingBombCount = GetSurroundingBombCount(bombField, row, col);
        bombField[row, col] = surroundingBombCount;
        playField[row, col] = surroundingBombCount;
    }

    private static void DrawPlayField(char[,] playField)
    {
        int rowCount = playField.GetLength(0);
        int colCount = playField.GetLength(1);
        Console.WriteLine("\n 0 1 2 3 4 5 6 7 8 9");
        Console.WriteLine(" ---------------------");
        for (int row = 0; row < rowCount; row++)
        {
            Console.Write("{0} | ", row);
            for (int col = 0; col < colCount; col++)
            {
                Console.Write(string.Format("{0} ", playField[row, col]));
            }

            Console.Write("|");
            Console.WriteLine();
        }

        Console.WriteLine(" ---------------------\n");
    }

    private static char[,] CreatePlayField()
    {
        int fieldRows = 5;
        int fieldCols = 10;
        char[,] playField = new char[fieldRows, fieldCols];
        for (int row = 0; row < fieldRows; row++)
        {
            for (int col = 0; col < fieldCols; col++)
            {
                playField[row, col] = '?';
            }
        }

        return playField;
    }

    private static char[,] CreateBombField()
    {
        int fieldRows = 5;
        int fieldCols = 10;
        char[,] bombField = new char[fieldRows, fieldCols];

        for (int row = 0; row < fieldRows; row++)
        {
            for (int col = 0; col < fieldCols; col++)
            {
                bombField[row, col] = '-';
            }
        }

        List<int> bombMap = new List<int>();
        while (bombMap.Count < 15)
        {
            Random randomInteger = new Random();
            int randomLocation = randomInteger.Next(50);
            if (!bombMap.Contains(randomLocation))
            {
                bombMap.Add(randomLocation);
            }
        }

        foreach (int bombLocation in bombMap)
        {
            int col = bombLocation / fieldCols;
            int row = bombLocation % fieldCols;
            if (row == 0 && bombLocation != 0)
            {
                col--;
                row = fieldCols;
            }
            else
            {
                row++;
            }

            bombField[col, row - 1] = '*';
        }

        return bombField;
    }

    private static char GetSurroundingBombCount(char[,] bombField, int row, int col)
    {
        int bombCount = 0;
        int rowCount = bombField.GetLength(0);
        int colCount = bombField.GetLength(1);

        if (row - 1 >= 0)
        {
            if (bombField[row - 1, col] == '*')
            {
                bombCount++;
            }
        }

        if (row + 1 < rowCount)
        {
            if (bombField[row + 1, col] == '*')
            {
                bombCount++;
            }
        }

        if (col - 1 >= 0)
        {
            if (bombField[row, col - 1] == '*')
            {
                bombCount++;
            }
        }

        if (col + 1 < colCount)
        {
            if (bombField[row, col + 1] == '*')
            {
                bombCount++;
            }
        }

        if ((row - 1 >= 0) && (col - 1 >= 0))
        {
            if (bombField[row - 1, col - 1] == '*')
            {
                bombCount++;
            }
        }

        if ((row - 1 >= 0) && (col + 1 < colCount))
        {
            if (bombField[row - 1, col + 1] == '*')
            {
                bombCount++;
            }
        }

        if ((row + 1 < rowCount) && (col - 1 >= 0))
        {
            if (bombField[row + 1, col - 1] == '*')
            {
                bombCount++;
            }
        }

        if ((row + 1 < rowCount) && (col + 1 < colCount))
        {
            if (bombField[row + 1, col + 1] == '*')
            {
                bombCount++;
            }
        }

        return char.Parse(bombCount.ToString());
    }

    public class Score
    {
        private string nickname;
        private int points;

        public Score()
        {
        }

        public Score(string nickname, int current)
        {
            this.Nickname = nickname;
            this.Points = current;
        }

        public string Nickname
        {
            get { return this.nickname; }
            set { this.nickname = value; }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}
