namespace BankSystem
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount()
            : base()
        { }

        public LoanAccount(CustromerType customer, decimal balance, decimal interestRate)
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
            Console.WriteLine("Your account is Loan.\nYou can't withdraw money only deposit!");
        }

        public override decimal InterestAmount(int months)
        {
            var amount = InterestRate;

            switch (Custromer)
            {
                case CustromerType.Individual:
                    if (months - 3 < 0)
                    {
                        amount = 0;
                    }
                    else
                    {
                        amount = base.InterestAmount(months - 3);
                    }
                    break;
                case CustromerType.Company:
                    if (months - 2 < 0)
                    {
                        amount = 0;
                    }
                    else
                    {
                        amount = base.InterestAmount(months - 2);
                    }
                    break;
                default:
                    return 0;
            }
            return amount;
        }
    }
}
