// Demo 3 - Methods and parameters
using System;
namespace Demo3
{
    public class BankAccount
    {
        public double Balance;
        public double InterestRate;
        string accountNumber;

        public void AddInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
        }

        // New method: Deposit, with a parameter
        // It adds the amount to the Balance
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // New method: IsOverdrawn, with a parameter
        // It checks if it is possible to withdraw the amount and still have funds
        public bool IsOverdrawn(double amount)
        {
            return Balance - amount < 0;
        }

        // New method: Withdraw, with a parameter
        // If possible, it takes money from the account
        public void Withdraw(double amount)
        {
            if (IsOverdrawn(amount))
                return;
            else
                Balance -= amount;
        }

        // Overloading the Initialize method:
        // Several definitions

        // First one contains 3 parameters, which are assigned to the respective fields
        public void Initialize(string account, double balance, double rate)
        {
            accountNumber = account;
            Balance = balance;
            InterestRate = rate;
        }

        // Second overload contains 2 parameters, which are assigned to the respective fields
        public void Initialize(double balance, double rate)
        {
            Balance = balance;
            InterestRate = rate;
        }

        // Third overload contains one parameter, which is assigned to the respective fields
        public void Initialize(double balance)
        {
            Balance = balance;
        }
    }
}
