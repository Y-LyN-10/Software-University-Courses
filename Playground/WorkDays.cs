//Exercise 5: Write a method that calculates the number of workdays between today and 
//given date, passed as parameter. Consider that workdays are all days from Monday to 
//Friday except a fixed list of public holidays specified preliminary as array.

using System;

class NumberOfWorkdays
{
    //Declare variables for all methods.
    private static DateTime today;
    private static DateTime lastDay;
    private static int allDays;
    private static int restDays;

    static void CountDays(DateTime lastDay)
    {
        //Create an array for all official holidays in 2014
        DateTime[] holidays = 
            { 
                new DateTime(2014, 1, 1), new DateTime(2014, 3, 3), new DateTime(2014, 4, 18),
                new DateTime(2014, 4, 19),new DateTime(2014, 4, 20),new DateTime(2014, 5, 1),
                new DateTime(2014, 5, 5), new DateTime(2014, 5, 6), new DateTime(2014, 5, 24),
                new DateTime(2014, 9, 6), new DateTime(2014, 9, 22),new DateTime(2014, 12, 24),
                new DateTime(2014, 12, 25),new DateTime(2014, 12, 26),new DateTime(2014, 12, 31) 
            };

        //Sometimes, we should work on a holidays... 
        DateTime[] workingSaturdays = {new DateTime(2014, 5, 10), new DateTime(2014, 5, 31), new DateTime(2014, 12, 13)};

        //First, the program counts all days till a certain date.
        today = DateTime.Today;
        allDays = (lastDay - today).Days;
        restDays = 0; //A little bonus from me ;)

        //And subtracts all holidays in a way, like they were never existed... I'm sorry, bro...
        while (lastDay >= today)
        {
            //Ok. Start. If today is a weekend, we check is it a working day or not.
            if ((today.DayOfWeek == DayOfWeek.Saturday) || (today.DayOfWeek == DayOfWeek.Sunday))
            {
                for (int i = 0; i < workingSaturdays.Length; i++)
                {
                    if (today == workingSaturdays[i])
                    {
                        allDays++;
                        restDays--;
                    }
                }
                allDays--;
                restDays++;
            }
            else // count all true holidays and substract them too. (For a working days count)
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today == holidays[i])
                    {
                        allDays--;
                        restDays++;
                    }
                }
                
                //Check for another working weekend days.
                for (int j = 0; j < workingSaturdays.Length; j++)
                {
                    if (today == workingSaturdays[j])
                    {
                        allDays++;
                        restDays--;
                    }
                }
            }
            today = today.AddDays(1);
        }
        Console.WriteLine("All working days are: " + allDays);
        //And... I love this part: 
        Console.WriteLine("But don't worry! You have {0} holidays!!! Use them smart ;)", restDays);
    }

    static void Main(string[] args)
    {
        Console.Write("This program will count how many working days remains till a certain date in 2014. \nEnter a day and month in format \"Day.Month\" : ");
        lastDay = DateTime.Parse(Console.ReadLine());

        CountDays(lastDay);
    }
    //Wow, I didn't noticed before how many rest days we have in a year... I should use them better...
}