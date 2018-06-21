using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.QuotesStrings
{
    class QuoteStrgns
    {
            //Declare two string variables and assign them with following value:
            //The "use" of quotations causes difficulties.
            //Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.


        static void Main(string[] args)
        {
            string quote = "The \"use\" of quations causes difficultes.";
            string quote2 = @"The ""use"" of quations causes difficultes.";
            Console.WriteLine(quote);
            Console.WriteLine(quote2);
        }
    }
}
