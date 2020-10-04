// Demo 8 - Parameters: optional and out
using System;

namespace Demo8
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

            BankAccount checking = new BankAccount
            {
                Balance = 500,
                InterestRate = 0.12,
                //AccountNumber = "1234"
            };

            Console.WriteLine("Account number: " + checking.GetAccountNumber());
            Console.WriteLine("Account balance: " + checking.Balance);
            Console.WriteLine("Account interest rate: " + checking.InterestRate);
            Console.WriteLine("Account expected interest: " + checking.ExpectedInterest);

            // Calling the CalculateTax method with one parameter only, the second one will be default value
            double tax1 = checking.CalculateTax(2000);
            Console.WriteLine("Tax 1: " + tax1);

            // Calling the CalculateTax method with two parameters
            double tax2 = checking.CalculateTax(2000, 20);
            Console.WriteLine("Tax 2: " + tax2);

            // Calling the CalculateMortgage method that returns two values, print them
            double interestAmount;
            double paymentPerMonth = checking.CalculateMortgage(10000, out interestAmount);
            Console.WriteLine("Total Interest: " + interestAmount);
            Console.WriteLine("Monthly payment: " + paymentPerMonth);

            savings.AddInterest();
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
