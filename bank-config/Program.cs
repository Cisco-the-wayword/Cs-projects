using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[3];

            accounts[0] = new BankAccount("Mr. Sam", 1000);
            accounts[1] = new BankAccount("Mr. Ola", 500);
            accounts[2] = new BankAccount("Mr. Deji", 2000);


            Console.WriteLine("Welcome to Cisco Bank App!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. View account balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                int option = int.Parse(Console.ReadLine());

                if (option == 4)
                {
                    break;
                }

                Console.WriteLine("Please enter the account number (0-2):");
                int accountNumber = int.Parse(Console.ReadLine());

                if (accountNumber < 0 || accountNumber > 2)
                {
                    Console.WriteLine("Invalid account number.");
                    continue;
                }

                BankAccount account = accounts[accountNumber];

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"The account balance for {account.Owner} is {account.Balance:C}");
                        break;
                    case 2:
                        Console.WriteLine("Please enter the amount to deposit:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        Console.WriteLine($"The new account balance for {account.Owner} is {account.Balance:C}");
                        break;
                    case 3:
                        Console.WriteLine("Please enter the amount to withdraw:");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        if (account.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine($"The new account balance for {account.Owner} is {account.Balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the Cisco Bank App!");
        }
    }

    class BankAccount
    {
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
