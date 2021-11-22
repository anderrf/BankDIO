using System;
using System.Collections.Generic;
using BankDIO.Classes;
using BankDIO.Enums;

namespace BankDIO
{
    class Program
    {
        static List<Account> accountsList = new List<Account>();

        static void Main(string[] args)
        {
            bool run;
            string userOption;
            run = true;
            while(run)
            {
                userOption = GetUserOption();
                switch(userOption)
                {
                    case "1":
                        ListAllAccounts();
                        break;
                    case "2":
                        InsertAccount();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option!");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("\nThank you for using our services!");
            Console.ReadKey();
        }

        private static void ListAllAccounts()
        {
            if(accountsList.Count == 0)
            {
                Console.WriteLine("\nNo account is registered yet!");
                Console.ReadKey();
                return;
            }
            foreach(Account account in accountsList)
            {
                Console.WriteLine(account.ToString());
                Console.WriteLine("----------------------------");
            }
            Console.ReadKey();
        }

        private static void InsertAccount()
        {
            int inputAccountType;
            double inputBalance, inputCredit;
            string inputOwner;
            Console.WriteLine("\nInsert new account");
            Console.WriteLine("Type 1 for natural account or 2 for legal account: ");
            while(!int.TryParse(Console.ReadLine(), out inputAccountType))
            {
                Console.WriteLine("Type 1 for natural account or 2 for legal account: ");
            }
            Console.WriteLine("Type the owner's name: ");
            inputOwner = Console.ReadLine();
            Console.WriteLine("Type the initial balance: ");
            while(!double.TryParse(Console.ReadLine(), out inputBalance))
            {
                Console.WriteLine("Type the initial balance: ");
            }
            Console.WriteLine("Type the credit value: ");
            while(!double.TryParse(Console.ReadLine(), out inputCredit))
            {
                Console.WriteLine("Type the credit value: ");
            }
            Account newAccount = new Account(
                accountType: (AccountType)inputAccountType,
                balance: inputBalance,
                credit: inputCredit,
                owner: inputOwner
            );
            accountsList.Add(newAccount);
            Console.WriteLine("New account inserted!");
            Console.ReadKey();
        }

        private static string GetUserOption()
        {
            string userOption;
            Console.WriteLine("\nType to select an option:");
            Console.WriteLine("1 - List all accounts");
            Console.WriteLine("2 - Insert new account");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - Exit");
            userOption = Console.ReadLine().ToUpper();
            return userOption;
        }
    }
}
