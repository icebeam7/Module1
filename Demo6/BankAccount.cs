// Demo 6 - Properties
using System;
namespace Demo6
{
    public class BankAccount
    {
        // Balance is now a proerty with getter and setter
        // There is a validation to avoid a negative balance
        private double balance;

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value >= 0)
                    balance = value;
            }
        }

        public double InterestRate;
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

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }
    }
}
