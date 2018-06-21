namespace BankTask.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankTask.Customers;


    class Loan : Account, ICalculatableInterestAmount
    {
        private const decimal INDIVIDUAL_NO_INTEREST = 3;
        private const decimal INDIVIDUAL_MIN_INTEREST = 4;
        private const decimal COMPANY_NO_INTEREST = 2;
        private const decimal COMPANY_MIN_INTEREST = 3;


        public Loan(Customer customer, decimal balance, decimal rate, decimal monthRent)
            : base(customer, balance, rate, monthRent)
        {

        }

        public override void DepositMoney(decimal cash)
        {
            base.Balance += cash;

        }

        public decimal CalculateInterestAmount()
        {
            decimal result = 0;

            if ((Customer is Individuals) && (base.MonthRent >= INDIVIDUAL_MIN_INTEREST))
            {
                result = (base.MonthRent - INDIVIDUAL_NO_INTEREST) * base.InterestRate;
                return result;
            }

            else if ((Customer is Individuals) && (base.MonthRent > INDIVIDUAL_MIN_INTEREST))
            {
                result = base.MonthRent * base.InterestRate;
                return result;
            }

            if ((Customer is Companies) && (base.MonthRent >= COMPANY_MIN_INTEREST))
            {
                result = (base.MonthRent - COMPANY_NO_INTEREST) * base.InterestRate;
                return result;
            }

            else if ((Customer is Companies) && (base.MonthRent >= COMPANY_MIN_INTEREST))
            {
                result = base.MonthRent * base.InterestRate;
                return result;
            }
                
            return result;
        }
    }
}
