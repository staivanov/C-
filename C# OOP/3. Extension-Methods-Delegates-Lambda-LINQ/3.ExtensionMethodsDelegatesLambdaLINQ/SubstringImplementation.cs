using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    class SubstringImplementation
    {
        //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
        static void Main(string[] args)
        {

            StringBuilder my = new StringBuilder("Stanislav");
            StringBuilder az = my.Substring(0, 4);
            Console.WriteLine(az);

        }
    }
}
