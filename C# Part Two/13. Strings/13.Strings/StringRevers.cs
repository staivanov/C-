using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Strings
{
    class StringRevers
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            for (int i = value.Length - 1; i >= 0; i--)
            {
               Console.Write(value[i] + "");
            }
            Console.WriteLine();

        }
    }
}
