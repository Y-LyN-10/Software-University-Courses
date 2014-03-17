//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 11. Bank Account Data";
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string name1 = "Morris";
        string name2 = "Lein";
        string name3 = "Blackwood";
        decimal balance = 62508.68m;
        char symbol = '$';
        string bankName = "Universe Bank";
        string numIBAN = "BG80 BNBG 9661 1020 3456 78";
        string codeBIC = "JGNSKORL";
        long cardNum1 = 4916398566336494;
        long cardNum2 = 340297789867901;
        long cardNum3 = 6011975583232662;

        object objName = (name1 + " " + name2 + " " + name3);
        object objMoney = (balance + "" + (char)symbol);

        Console.WriteLine(" Bank account record: \n \n Holder: {0} \n Bank: {1} \n Balance: {2} \n IBAN: {3} \n BIC: {4}", objName, bankName, objMoney, numIBAN, codeBIC);
        Console.WriteLine();
        Console.WriteLine(" Card Numbers: \n Visa: {0} \n American Express: {1} \n Discover: {2}", cardNum1, cardNum2, cardNum3);
        Console.WriteLine();
    }
}
