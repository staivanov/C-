using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ThirdDigitSeven
{
    class DigitSeven
    {
        //Write an expression that checks for given integer if its third digit from right-to-left is 7. 

        static void Main()
        {
            Console.WriteLine("Expression that checks for given integer if its third digit from right-to-left is 7");
            Console.Write("Enter your integer: ");

            int num = int.Parse(Console.ReadLine());
            bool thirdDigit = true;

            if (((num/100)%10) == 7)
            {
                Console.WriteLine(thirdDigit);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
