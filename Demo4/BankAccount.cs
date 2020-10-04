// Demo 4 - Constructors
using System;
namespace Demo4
{
    public class BankAccount
    {
        public double Balance;
        public double InterestRate;
        string accountNumber;

        // Constructor overload
        // Several definitions

        // First one contains 3 parameters, which are assigned to the respective fields
        public BankAccount(string account, double balance, double rate)
        {
            accountNumber = account;
            InterestRate = rate;
            Balance = balance;
        }

        // Second constructor overload contains 2 parameters, which are assigned to the respective fields
        // and an initial value for accountNumber
        public BankAccount(double balance, double rate)
        {
            accountNumber = "0000";
            InterestRate = rate;
            Balance = balance;
        }

        // Third constructor overload contains one parameter, which is assigned to the respective field
        // and an initial value for accountNumber and InterestRate
        public BankAccount(double balance)
        {
            accountNumber = "0000";
            InterestRate = 0.10;
            Balance = balance;
        }

        // Basic constructor overload, parameterless
        // accountNumber, InterestRate and Balance are initialized
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

        public bool IsOverdrawn(double amount)
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
    }
}
