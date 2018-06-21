using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DividedFiveAndSeven
{
    class FiveAndSeven
    {
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 

        static void Main(string[] args)
        {
            Console.WriteLine("Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5");
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            bool divided = true;
            bool notDivided = false;

            if ((num % 35) == 0)
            {
                Console.WriteLine(divided);
            }
            else
            {
                Console.WriteLine(notDivided);
            }

        }
    }
}
