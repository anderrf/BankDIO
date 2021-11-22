using BankDIO.Enums;

namespace BankDIO.Classes
{
    public class Account
    {
        private AccountType accountType { get; set; }
        private double balance { get; set; }
        private double credit { get; set; }
        private string owner { get; set; }

        public Account(AccountType accountType, double balance, double credit, string owner)
        {
            this.accountType = accountType;
            this.balance = balance;
            this.credit = credit;
            this.owner = owner;
        }
    }
}