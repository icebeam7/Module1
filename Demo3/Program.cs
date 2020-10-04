// Demo 3 - Methods and parameters
using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings = new BankAccount();
            // Call the Initialize method and pass 3 parameters
            savings.Initialize("89023", 200, 0.05);

            // Print the account values that were just assigned
            Console.WriteLine("Account balance: " + savings.Balance);
            Console.WriteLine("Account interest rate: " + savings.InterestRate);

            // Call Deposit method, pass the parameter, print the new balance
            savings.Deposit(50);
            Console.WriteLine("Account balance: " + savings.Balance);

            // Call Withdraw method, pass the parameter, print the new balance
            savings.Withdraw(100);
            Console.WriteLine("Account balance: " + savings.Balance);

            // Call Withdraw method, pass the parameter, print the new balance
            savings.Withdraw(90);
            Console.WriteLine("Account balance: " + savings.Balance);

            // Call Withdraw method, pass the parameter, print the new balance
            savings.Withdraw(70);
            Console.WriteLine("Account balance: " + savings.Balance);
            // The balance remains the same because it is not possible to withdraw the money
            // (Not enough funds)

            BankAccount checking = new BankAccount();
            // Call the Initialize method and pass 2 parameters
            checking.Initialize(500, 0);

            savings.AddInterest();
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
