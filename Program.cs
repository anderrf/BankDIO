using System;
using BankDIO.Classes;
using BankDIO.Enums;

namespace BankDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(AccountType.NaturalPerson, 900.00, 2700.00, "Anderson Rocha Farias");
            Console.WriteLine(account.ToString());
            Console.ReadKey();
        }
    }
}
