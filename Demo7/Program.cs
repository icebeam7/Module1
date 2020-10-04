// Demo 7 - Advanced Properties
using System;

namespace Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings = new BankAccount("89023", 200, 0.05);

            Console.WriteLine("Account number: " + savings.GetAccountNumber());
            Console.WriteLine("Account balance: " + savings.Balance);
            Console.WriteLine("Account interest rate: " + savings.InterestRate);

            savings.Deposit(50);
            Console.WriteLine("Account balance: " + savings.Balance);

            savings.Withdraw(100);
            Console.WriteLine("Account balance: " + savings.Balance);

            savings.Withdraw(90);
            Console.WriteLine("Account balance: " + savings.Balance);

            savings.Withdraw(70);
            Console.WriteLine("Account balance: " + savings.Balance);

            savings.Balance = 200;
            Console.WriteLine("Account balance: " + savings.Balance);

            savings.Balance = -200;
            Console.WriteLine("Account balance: " + savings.Balance);

            // Instantiating a class by initializing properties
            BankAccount checking = new BankAccount
            {
                Balance = 500,
                InterestRate = 0.12,
                //AccountNumber = "1234" <-- you can't do that because it is readonly
            };

            // Accessing method
            Console.WriteLine("Account number: " + checking.GetAccountNumber());

            // Accessing properties Balance (full) and InterestRate (auto)
            Console.WriteLine("Account balance: " + checking.Balance);
            Console.WriteLine("Account interest rate: " + checking.InterestRate);

            // Accessing property ExpectedInterest (calculated, read-only)
            Console.WriteLine("Account expected interest: " + checking.ExpectedInterest);

            savings.AddInterest();
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
