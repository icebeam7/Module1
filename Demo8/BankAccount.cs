// Demo 8 - Parameters: optional and out
using System;
namespace Demo8
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

        public double InterestRate
        {
            get;
            set;
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

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

        // New method, CalculateTax with two parameters, but one is default (rate)
        // If it is called and only amount is set, the rate will be 15.0
        // If it is called and both amount and rate are sent, these values will be used
        public double CalculateTax(double amount, double rate = 15.0)
        {
            return amount * rate / 100;
        }

        // New method, CalculateMortgage, with one output parameter
        // so it returns two values: a double and the totalInterest
        public double CalculateMortgage(double loanAmount, out double totalInterest)
        {
            totalInterest = loanAmount * 0.20;
            double monthlyPayment = (loanAmount + totalInterest) / 36;
            return monthlyPayment;
        }
    }

}
