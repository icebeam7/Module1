// Demo 2 - Classes and Objects
using System;
namespace Demo2
{
    public class BankAccount
    {
        // Two fields now include an accessor (public)
        // It means they are accessible from outside (in Main, for instance)
        public double Balance;
        public double InterestRate;
        string accountNumber;

        // The method is also accessible from outside because it is public
        public void AddInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
        }
    }
}
