// Demo 4 - Constructors
using System;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now, we create a savings object using the constructor with 3 parameters
            BankAccount savings = new BankAccount("89023", 200, 0.05);

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

            // Create a checking object using the constructor with 2 parameters
            BankAccount checking = new BankAccount(500, 0);

            savings.AddInterest();
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
