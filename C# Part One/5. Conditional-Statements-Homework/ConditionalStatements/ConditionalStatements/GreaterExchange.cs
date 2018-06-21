using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class GreaterExchange
    {
        //Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

        public static void GreaterNumber(float a, float b){

            float greater = a;

            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (b > a)
            {
                Console.WriteLine("{0} > {1}", b, a);
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }

        }


        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            float b = float.Parse(Console.ReadLine());

            GreaterNumber(a, b);

        }
    }
}
