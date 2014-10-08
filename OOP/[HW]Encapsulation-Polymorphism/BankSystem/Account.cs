namespace BankSystem
{
    abstract class Account
    {
        protected CustromerType customer;
        protected decimal balance;
        protected decimal interestRate;

        protected Account()
        {
            this.customer = CustromerType.Individual;
            this.balance = decimal.MinValue;
            this.interestRate = decimal.MinValue;
        }

        protected Account(CustromerType customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public abstract CustromerType Custromer { get; set; }

        public abstract decimal Balance { get; set; }

        public abstract decimal InterestRate{ get; set; }

        public virtual void DepositMoney(decimal money)
        {
            balance += money;
        }

        public virtual void WithdrawMoney(decimal money)
        {
            balance -= money;
        }

        public virtual decimal InterestAmount(int months)
        {
            return (decimal)(months * interestRate);
        }
    }
}
