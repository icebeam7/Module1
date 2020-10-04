// Demo 6 - Properties
using System;

namespace Demo6
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

            // Using the Balance property, it is updated
            savings.Balance = 200;
            Console.WriteLine("Account balance: " + savings.Balance);

            // Using the Balance property, it is not updated
            savings.Balance = -200;
            Console.WriteLine("Account balance: " + savings.Balance);

            BankAccount checking = new BankAccount(500, 0);

            savings.AddInterest();
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
