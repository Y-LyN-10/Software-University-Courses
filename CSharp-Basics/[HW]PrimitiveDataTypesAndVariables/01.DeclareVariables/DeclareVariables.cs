// Problem 1. Declare Variables
// Declare five variables choosing for each of them the most appropriate of the 
// types byte, sbyte, short, ushort, int, uint, long, ulong to represent the 
// following values: 52130, -115, 4825932, 97, -10000. Choose a large enough 
// type for each number to ensure it will fit in it. Try to compile the code. 
// Submit the source code of your Visual Studio project as part of your homework submission.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort ushortType = 52130;
        sbyte sbyteType = -115;
        int intType = 4825932;
        byte byteType = 97;
        short shortType = -10000;

        Console.Title = "Problem 1. Declare Variables";

        Console.WriteLine((ushortType) + (" is ushort "));
        Console.WriteLine((sbyteType) + (" is sbyte "));
        Console.WriteLine((intType) + (" is int "));
        Console.WriteLine((byteType) + (" is byte "));
        Console.WriteLine((shortType) + (" is short"));
    }
}
