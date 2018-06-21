using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class BankDatas
    {
        //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

        static void Main(string[] args)
        {
            //Full name
            string firstName = "Stanislav";
            string middleName = "Petrov";
            string lastName = "Ivanov";

            //Bank data
            long balance = 645623424;
            string bankName = "American Express";
            string iban = "GB82 WEST 1234 5698 7654 32";
            long firstCardNumber = 348346684489378L;
            long secondCardNumber = 37453190684413L;
            long thirdCardNumber = 340474329824359L;
        }
    }
}
