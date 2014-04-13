// Problem 10. Join Lists
// Write a program that takes as input two lists of integers 
// and joins them. The result should hold all numbers from the 
// first list, and all numbers from the second list, without 
// repeating numbers, and arranged in increasing order. The 
// input and output lists are given as integers, separated 
// by a space, each list at a separate line. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        //Test 1:
        Console.SetIn(new StreamReader("../../input.txt"));
        //Test 2:
        //Console.SetIn(new StreamReader("../../input2.txt"));
        //Test 3:
        //Console.SetIn(new StreamReader("../../input3.txt"));

        //After long hours of solving this problem, I decided to use SortedSet class
        //It sorts automatically unique elements in increasing order.

        string[] firstLine =  Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');

        SortedSet<int> sortedNumbers = new SortedSet<int>();
        foreach (var number in firstLine) sortedNumbers.Add(int.Parse(number));
        foreach (var number in secondLine) sortedNumbers.Add(int.Parse(number));
        foreach (var number in sortedNumbers) Console.Write(number + " ");
    }
}
