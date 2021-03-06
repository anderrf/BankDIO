using BankDIO.Enums;
using System;

namespace BankDIO.Classes
{
    public class Account
    {
        private string code { get; }
        private AccountType accountType { get; set; }
        private double balance { get; set; }
        private double credit { get; set; }
        private string owner { get; set; }

        public Account(string code, AccountType accountType, double balance, double credit, string owner)
        {
            this.code = code;
            this.accountType = accountType;
            this.balance = balance;
            this.credit = credit;
            this.owner = owner;
        }

        public bool Withdraw(double withdrawalValue)
        {
            if(this.balance - withdrawalValue < (this.credit * -1))
            {
                Console.WriteLine("Insufficient balance");
                return false;
            }
            this.balance -= withdrawalValue;
            Console.WriteLine("New balance for {0}'s account is US$ {1:F2}", this.owner, this.balance);
            return true;
        }

        public void Deposit(double depositValue)
        {
            this.balance += depositValue;
            Console.WriteLine("New balance for {0}'s account is US$ {1:F2}", this.owner, this.balance);
        }

        public void transfer(double transferValue, Account destinationAccount)
        {
            if(this.Withdraw(transferValue))
            {
                destinationAccount.Deposit(transferValue);
            }
        }

        public override string ToString()
        {
            string returnStr = "";
            returnStr += "\nAccountType: " + this.accountType;
            returnStr += "\nOwner: " + this.owner;
            returnStr += "\nBalance: US$ " + this.balance.ToString("N2");
            returnStr += "\nCredit: US$ " + this.credit.ToString("N2");
            return returnStr;
        }

        public string getCode()
        {
            return this.code;
        }
    }
}