// Problem 2. Print Company Information
// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and 
// its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine(" \n Welcome to the regiser form for your future Company! \n Please, follow the questions and press \"Enter\" when you're ready.\n");
        Console.Write("Company name: ");
        string companyName = (Console.ReadLine());

        Console.Write("Address: ");
        string companyAddress = (Console.ReadLine());

        Console.Write("Company Phone: ");
        string companyPhone = (Console.ReadLine());
        //It's 'string', because the inserted phone number can  contain special symbols.
        // For example: "+359 ..." or "(02) 41-61-46"

        Console.Write("Fax: ");
        string companyFax = (Console.ReadLine());
        
        if (String.IsNullOrEmpty(companyFax))
        {
            companyFax = "(no fax)";
        }

        Console.Write("Web site: ");
        string companyWebSite = (Console.ReadLine());

        Console.WriteLine("So, you are the manager of {0} Company.", companyName);
        Console.Write("First Name: ");
        string managerFirstName = (Console.ReadLine());

        Console.Write("Last Name: ");
        string managerLastName = (Console.ReadLine());

        Console.Write("Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Phone number: ");
        string managerPhone = (Console.ReadLine());

        Console.WriteLine("\n\n Thank you, {0} {1} ! Check the information below is it true.\n", managerFirstName, managerLastName);
        Console.WriteLine(" \n {0} \n Address: {1} \n Tel. {2} \n Fax: {3} \n Web Site: {4}", companyName, companyAddress, companyPhone, companyFax, companyWebSite);
        Console.WriteLine(" Manager: {0} {1} , (age: \n {2}, tel.  {3})\n\n", managerFirstName, managerLastName, managerAge, managerPhone);          
    }
}

//Input sample:

//Software University
//26 V. Kanchev, Sofia
//+359 899 55 55 92

//http://softuni.bg
//Svetlin
//Nakov
//25
//+359 2 981 981

