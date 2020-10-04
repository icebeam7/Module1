// Demo 5 - Access Modifiers
using System;
namespace Demo5
{
    public class BankAccount
    {
        public double Balance;
        public double InterestRate;

        // Add a private access modifier
        private string accountNumber;

        public BankAccount(string account, double balance, double rate)
        {
            accountNumber = account;
            InterestRate = rate;
            Balance = balance;
        }

        public BankAccount(double balance, double rate)
        {
            accountNumber = "0000";
            InterestRate = rate;
            Balance = balance;
        }

        public BankAccount(double balance)
        {
            accountNumber = "0000";
            InterestRate = 0.10;
            Balance = balance;
        }

        public BankAccount()
        {
            accountNumber = "0000";
            InterestRate = 0.10;
            Balance = 0;
        }

        public void AddInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // Declare this method as private too
        private bool IsOverdrawn(double amount)
        {
            return Balance - amount < 0;
        }

        public void Withdraw(double amount)
        {
            if (IsOverdrawn(amount))
                return;
            else
                Balance -= amount;
        }

        // Declare a new public method to access the private field accountNumber
        public string GetAccountNumber()
        {
            return accountNumber;
        }
    }
}
