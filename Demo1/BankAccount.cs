// Demo 1 - Creating a Class
namespace Demo1
{
    // Class declaration with 3 fields and one method 
    public class BankAccount
    {
        double Balance;
        double InterestRate;
        string accountNumber;

        void AddInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
        }
    }
}
