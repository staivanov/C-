namespace BankTask.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankTask.Customers;


    class Deposit : Account, IDrawable, ICalculatableInterestAmount
    {
        public Deposit(Customer customer, decimal balance, decimal rate, decimal monthRent)
            : base(customer, balance, rate, monthRent)
        {

        }

        public override void DepositMoney(decimal cash)
        {
            base.Balance += cash;
        }

        public decimal DrawMoney(decimal cashDraw)
        {
            if (cashDraw > this.Balance)
            {
                throw new ArgumentException("Its a crime!");
            }

            this.Balance -= cashDraw;
            return cashDraw;
        }

        public decimal CalculateInterestAmount()
        {
            decimal result = 0;

            if ((base.Balance > 0) && (base.Balance < 1000))
            {
                return result;
            }

            else
            {
                result = base.MonthRent * base.InterestRate;
                return result;
            }

        }
    }
}
