using System;
using System.Linq;

class Randomize
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        //Invoke this very unique method :D
        UniqueRandomArray(array, n);

        //Print the unique array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    private static int[] UniqueRandomArray(int[] uniqueArray, int size)
    {
        Random rnd = new Random();
        int randomNumber;

        for (int i = 0; i < size; i++)
        {
            randomNumber = rnd.Next(1, size);

            //check if the number is already added
            for (int j = i; j >= 0; j--)
            {
                if (uniqueArray[j] == randomNumber)
                { 
                    randomNumber = rnd.Next(1, size + 1); 
                    j = i; 
                }
            }

            uniqueArray[i] = randomNumber;
        }

        return uniqueArray;
    }
}

