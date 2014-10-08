namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    class Welcome
    {
        static void Main()
        {
            Console.Title = "Welcome to the Bank of Kurtovo Konare";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var bank = new Bank {Accounts = Accounts()};

            foreach (var account in bank.Accounts)
            {
                account.DepositMoney(500m);
                account.WithdrawMoney(400m);

                Console.WriteLine("Interest amount is: " + account.InterestAmount(3));
                Console.Write("Press any key to continue: ");

                Console.ReadKey();
                Console.Clear();
            }
        }

        public static List<Account> Accounts()
        {
            var accounts = new List<Account>();
            var customer = new CustromerType();
            var depositAccount = new DepositAccount();
            var loanAccount = new LoanAccount();

            Console.Write("Number of accounts to add: ");
            var numberOfAccounts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfAccounts; i++)
            {
                var customerType = 0;
                var accountType = 0;

                Console.WriteLine("[{0}] Account", i);
                do
                {
                    Console.WriteLine("Custromer types");
                    Console.WriteLine("1. Individual");
                    Console.WriteLine("2. Company");
                    Console.Write("Custromer: ");

                    customerType = int.Parse(Console.ReadLine());

                } while (customerType < 1 || customerType > 2);

                do
                {
                    Console.WriteLine("Account types");
                    Console.WriteLine("1. Deposit account");
                    Console.WriteLine("2. Loan account");
                    Console.WriteLine("3. Mortgage account");
                    Console.Write("Account: ");

                    accountType = int.Parse(Console.ReadLine());

                } while (accountType < 1 || accountType > 3);

                Console.Write("Balance: ");
                decimal balance = decimal.Parse(Console.ReadLine());
                Console.Write("Interest rate: ");
                decimal interestRate = decimal.Parse(Console.ReadLine());

                switch (customerType)
                {
                    case 1:
                        customer = CustromerType.Individual;
                        break;
                    case 2:
                        customer = CustromerType.Company;
                        break;
                }

                switch (accountType)
                {
                    case 1:
                        accounts.Add(new DepositAccount(customer, balance, interestRate));
                        break;
                    case 2:
                        accounts.Add(new LoanAccount(customer, balance, interestRate));
                        break;
                    case 3:
                        accounts.Add(new MortgageAccount(customer, balance, interestRate));
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }

            return accounts;
        }
    }
}
