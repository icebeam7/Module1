// Demo 7 - Advanced Properties
using System;
namespace Demo7
{
    public class BankAccount
    {
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

        // InterestRate is an Auto-property (empty getter and setter)
        public double InterestRate
        {
            get;
            set;
        }

        // AccountNumber is a read-only property (only getter is defined)
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // ExpectedInterest is a read-only property (only getter is defined)
        // its value is calculated by an operation
        public double ExpectedInterest
        {
            get { return balance * InterestRate; }
        }

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
