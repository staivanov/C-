using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class OddOrEven
    {
        //Write an expression that checks if given integer is odd or even. 

        static void Main(string[] args)
        {
            Console.WriteLine("This progrma check for odd or even number");
            Console.Write("Enter number your number: ");
            int num = int.Parse(Console.ReadLine());

            bool odd = true;
            bool even = false;

            if ((num % 2) == 0)
            {
                Console.WriteLine(even);
            }
            else
            {
                Console.WriteLine(odd);
            }

        }
    }
}
