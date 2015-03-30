using System;

namespace _2.BankAccounts.Models
{
    class DepositAccount : AccountsWithDeposit
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                Console.WriteLine("No interest for this account");
                return 0;
            }
            
            return months * this.InterestRate;
        }

        public void Withdraw(decimal ammount)
        {
            if (ammount > this.Balance)
            {
                Console.WriteLine("Unsufficient ammount of money in this account");
            }
            else
            {
                this.Balance -= ammount;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} Account: Deposit account",base.ToString());
        }
    }
}
