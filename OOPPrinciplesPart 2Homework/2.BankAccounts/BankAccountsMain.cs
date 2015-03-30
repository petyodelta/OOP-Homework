using _2.BankAccounts.Models;
using System;

namespace _2.BankAccounts
{
    class BankAccountsMain
    {
        static void Main()
        {
            Customer firstCustomer = new Customer("Ivan Petkov");

            DepositAccount depositAccount = new DepositAccount(firstCustomer, 1250, 1.1M);

            decimal interestAmmount = depositAccount.CalculateInterest(2);
            Console.WriteLine("Deposit account interest ammount: {0}",interestAmmount);

            Console.WriteLine("Balance: {0}",depositAccount.Balance);

            depositAccount.Deposit(25.5M);
            Console.WriteLine("Deposit made.");
            Console.WriteLine("Balance: {0}", depositAccount.Balance);

            depositAccount.Withdraw(255M);
            Console.WriteLine("Withdraw made");
            Console.WriteLine("Balance: {0}", depositAccount.Balance);

            Console.WriteLine(depositAccount.ToString());

            LoanAccount loanAccount = new LoanAccount(firstCustomer, 5000, 5.75M);

            interestAmmount = loanAccount.CalculateInterest(12);
            Console.WriteLine("Loan account interest ammount: {0}", interestAmmount);

            MortgageAccount mortgageAccount = new MortgageAccount(firstCustomer, 50000, 5.25M);
            interestAmmount = mortgageAccount.CalculateInterest(15);
            Console.WriteLine("Mortgage account interest ammount: {0}", interestAmmount);
        }
    }
}
