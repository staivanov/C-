namespace BankTask.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankTask.Customers;

    abstract class Account
    {
        private Customer _customer;
        private decimal _balance;
        private decimal _interestRate;
        private decimal _monthRent;

        public Customer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        public decimal Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
        }

        public decimal InterestRate
        {
            get { return this._interestRate; }
            set { this._interestRate = value; }
        }

        public decimal MonthRent
        {
            get { return this._monthRent; }
            set { this._monthRent = value; }
        }

        protected Account(Customer customer, decimal balance, decimal rate, decimal monthRent)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = rate;
            this.MonthRent = monthRent;
        }

        public abstract void DepositMoney(decimal cash);

    }
}
