using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTask.Accounts;

namespace BankTask
{
    class Bank
    {
        private List<Account> _accs;

        public List<Account> Acc
        {
            get
            {
                return this._accs;
            }
            set
            {
                this._accs = value;
            }
        }

        public Bank(List<Account> accs)
        {
            this.Acc = new List<Account>();
        }

    }
}
