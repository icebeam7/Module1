// Demo 5 - Access Modifiers
using System;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings = new BankAccount("89023", 200, 0.05);

            // Use the public GetAccountNumber to print the account number
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

            BankAccount checking = new BankAccount(500, 0);

            // Use the public GetAccountNumber to print the account number
            Console.WriteLine("Account number: " + checking.GetAccountNumber());

            savings.AddInterest();
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
