using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExchangeVariables
{
    class VariablesExchange
    {
        //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.

        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine(" \'a\' is: {0} and \'b\' is: {1}", a, b);
            Console.WriteLine(" After some magic");

            c = a;
            a = b;
            b = c;

            Console.WriteLine(" \'a\' is: {0} and \'b\' is: {1}", a, b);

        }

    }
}
