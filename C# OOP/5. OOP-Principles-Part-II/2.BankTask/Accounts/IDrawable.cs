using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask.Accounts
{
    interface IDrawable
    {
        decimal DrawMoney(decimal cashDraw);
    }
}
