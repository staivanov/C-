using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTask.Customers;

namespace BankTask.Accounts
{
    class Mortgage : Account, ICalculatableInterestAmount
    {
        private const decimal INDIVIDUAL_NO_INTEREST = 6;
        private const decimal COMPANY_HALF_INTEREST = 12;

        public Mortgage(Customer customer, decimal balance, decimal rate, decimal monthRent)
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

            if ((Customer is Individuals) && (base.MonthRent <= INDIVIDUAL_NO_INTEREST))
            {
                result = 0;
                return result;
            }

            else if ((Customer is Individuals) && (base.MonthRent > INDIVIDUAL_NO_INTEREST))
            {
                result = (base.MonthRent - INDIVIDUAL_NO_INTEREST) * base.InterestRate;
                return result;
            }

            if ((Customer is Customer) && (base.MonthRent <= COMPANY_HALF_INTEREST))
            {
                result = (base.MonthRent * base.InterestRate) / 2;
                return result;
            }
            else if ((Customer is Companies) && (base.MonthRent > COMPANY_HALF_INTEREST))
            {
                decimal AmountOfHalfInterest = (base.MonthRent * base.InterestRate) / 2;

                result = (base.MonthRent * base.InterestRate) - AmountOfHalfInterest;
                return result;
            }

            return 0;

        }
    }
}
