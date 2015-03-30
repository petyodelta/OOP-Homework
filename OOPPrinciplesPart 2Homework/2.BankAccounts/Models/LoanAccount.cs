using System;

namespace _2.BankAccounts.Models
{
    class LoanAccount : AccountsWithDeposit
    {
        private const int indidualCustomerMonthPeriod = 3;
        private const int companyCustomerMonthPeriod = 2;
        
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months <= indidualCustomerMonthPeriod)
                {
                    Console.WriteLine("No interest for this account");
                    return 0;
                }
                else
                {
                    return (months - indidualCustomerMonthPeriod) * this.InterestRate;
                }
                
            }
            else
            {
                if (months <= companyCustomerMonthPeriod)
                {
                    Console.WriteLine("No interest for this account");
                    return 0;
                }
                else
                {
                    return (months - companyCustomerMonthPeriod) * this.InterestRate;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} Account: Loan account", base.ToString());
        }
    }
}
