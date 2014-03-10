/* Problem 11. Employee Data
 A marketing company wants to keep record of its employees. 
 Each record would have the following characteristics:
 •	First name
 •	Last name
 •	Age (0...100)
 •	Gender (m or f)
 •	Personal ID number (e.g. 8306112507)
 •	Unique employee number (27560000…27569999)
 Declare the variables needed to keep the information for a single 
 employee using appropriate primitive data types. Use descriptive names. 
 Print the data at the console. */

using System;

class EmployeeData
{
    static void Main()
    {
        Console.Title = "Problem 11. Employee Data";

        string firstName = "Michelle";
        string lastName = "Torini"; //Names are declared as strings.
        byte age = 35;               //Age can't be negative or more than 255 years (for humans xD), so that's why it is a "byte type".
        char gender = 'f';           // 'm' and 'f' are chars.
        int id = 316;                // If 'id' is the number of Employee's record in the data base, (for example) it can't be too big for a marketing firm. 
        uint uniqNum = 27560025u;    // Can't be negative, so uint is ok.

        Console.WriteLine("Employee: " + firstName + " " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee unique number: " + uniqNum);
    }
}
