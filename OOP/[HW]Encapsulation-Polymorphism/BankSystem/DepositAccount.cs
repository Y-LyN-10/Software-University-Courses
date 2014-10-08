namespace BankSystem
{
    using System;

    class DepositAccount : Account
    {
        public DepositAccount()
            : base()
        { }

        public DepositAccount(CustromerType customer, decimal balance, decimal interestRate)
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
                Validation.CheckForMinimalValue(value, "Minimal deposit is 1 cent!");
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
                Validation.CheckForNegativeOrZero(value, "Interest rate can't be under 0% !");
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
            if (Balance > money)
            {
                base.WithdrawMoney(money);
                Console.WriteLine("Successfully withdraw money: $" + money);
                Console.WriteLine("Your balance is: $" + Balance);
            }
            else
            {
                Console.WriteLine("You can't withdraw ${0}, because your balance is: ${1}", money, Balance);
            }
        }

        public override decimal InterestAmount(int months)
        {
            if (Balance > 0m && Balance < 1000m)
            {
                return 0m;
            }
            return base.InterestAmount(months);
        }
    }
}
