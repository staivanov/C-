using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Methods
{
    class HelloNames
    {

        public static void PrintName (string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }


        static void Main(string[] args)
        {

            Console.Write("Enter name ");
            string name = Console.ReadLine();
            PrintName(name);

        }
    }
}
