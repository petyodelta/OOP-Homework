using System;

namespace _2.BankAccounts.Models
{
    public class MortgageAccount : Account
    {
        private const int indidualCustomerMonthPeriod = 6;
        private const int companyCustomerMonthPeriod = 12;
        
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
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
                    return (months - indidualCustomerMonthPeriod) * this.InterestRate
                        + (indidualCustomerMonthPeriod * this.InterestRate) / 2;
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
                    return (months - companyCustomerMonthPeriod) * this.InterestRate
                        + (companyCustomerMonthPeriod * this.InterestRate) / 2;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} Account: Mortgage account", base.ToString());
        }
    }
}
