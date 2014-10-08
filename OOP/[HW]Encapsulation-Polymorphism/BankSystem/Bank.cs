namespace BankSystem
{
    using System.Collections.Generic;

    class Bank
    {
        private List<Account> accounts;
        private int accountsCount;

        public Bank()
        {
            this.accounts = new List<Account>();
            this.accountsCount = 0;
        }

        public Bank(List<Account> accounts)
        {
            this.accounts = accounts;
            this.accountsCount = accounts.Count;
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
            set
            {
                Validation.CheckForNegativeOrZero(value, "Account can't be null or empty!");
                this.accounts = value;
            }
        }

        public int AccountsCount
        {
            get { return this.accountsCount; }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
            this.accountsCount++;
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
            this.accountsCount--;
        }
    }
}
