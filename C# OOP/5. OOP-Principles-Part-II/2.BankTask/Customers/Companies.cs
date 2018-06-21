using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask.Customers
{
    class Companies : Customer
    {
        private string _companyName;

        public string CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        public Companies(string fName, string lName)
            : base(fName, lName)
        {

        }

        public Companies(string fName, string lName, string companyName)
            : base(fName, lName)
        {
            this.CompanyName = companyName;
        }
    }
}
