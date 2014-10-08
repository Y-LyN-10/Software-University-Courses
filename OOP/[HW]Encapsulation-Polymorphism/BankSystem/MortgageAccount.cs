namespace BankSystem
{
    using System;

    class MortgageAccount : Account
    {
        public MortgageAccount()
            : base()
        { }

        public MortgageAccount(CustromerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override CustromerType Custromer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }

        public override decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                Validation.CheckForMinimalValue(value, "Your balance can't be under 1 cent!");
                balance = value;
            }
        }

        public override decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                Validation.CheckForNegativeOrZero(value, "Interest rate can't be under 0%");
                interestRate = value;
            }
        }

        public override void DepositMoney(decimal money)
        {
            base.DepositMoney(money);

            Console.WriteLine("Successfully deposit: " + money);
            Console.WriteLine("Your balance is: " + Balance);
        }

        public override void WithdrawMoney(decimal money)
        {
            Console.WriteLine("Your account is Mortagage.\nYou can't withdraw money only deposit!");
        }

        public override decimal InterestAmount(int months)
        {
            decimal amount = 0m;

            if (Custromer == CustromerType.Individual)
            {
                if (months - 6 < 0)
                {
                    return amount;
                }
                else
                {
                    amount = base.InterestAmount(months - 6);
                }
            }
            else if (Custromer == CustromerType.Company)
            {
                if (months > 12)
                {
                    decimal firstYear = base.InterestAmount(12) / 2;
                    amount = firstYear + base.InterestAmount(months - 12);
                }
                else
                {
                    amount = base.InterestAmount(months) / 2;
                }
            }
            else
            {
                return 0;
            }

            return amount;
        }
    }
}
