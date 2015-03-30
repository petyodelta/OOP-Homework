
namespace _2.BankAccounts.Models
{
    public abstract class AccountsWithDeposit : Account
    {

        public AccountsWithDeposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }
        
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
    }
}
