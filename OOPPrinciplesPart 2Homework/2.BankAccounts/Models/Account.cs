
namespace _2.BankAccounts.Models
{
    public abstract class Account
    {
        private Customer _customer;
        private decimal _balance;
        private decimal _interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this._customer; }
            private set { this._customer = value; }
        }
        

        public decimal Balance
        {
            get { return this._balance; }
            protected set { this._balance = value; }
        }

        public decimal InterestRate
        {
            get { return this._interestRate; }
            private set{this._interestRate = value;}
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Customer: {0} Balance: {1} Interest rate: {2}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
