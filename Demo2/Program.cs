// Demo 2 - Classes and Objects
using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two BankAccount instances (or two objects)
            BankAccount savings = new BankAccount();
            BankAccount checking = new BankAccount();

            // It is not possible to access accountNumber because it is not public
            //savings.accountNumber = "12345";

            // Accessing the public Balance field of each object
            savings.Balance = 200;
            checking.Balance = 500;

            // Accessing the public InterestRate field
            savings.InterestRate = 0.05;

            // Accessing the public AddInterest method
            savings.AddInterest();

            // Using Balance for calculation and printing the result
            double netWorth = savings.Balance + checking.Balance;
            Console.WriteLine("My net worth is " + netWorth);
        }
    }
}
