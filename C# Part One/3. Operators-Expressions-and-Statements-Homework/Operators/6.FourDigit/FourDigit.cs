using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FourDigit
{
    class FourDigit
    {
//        Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).

        static void Main(string[] args)
        {
            Console.WriteLine("Program that takes as input a four-digit number in format abcd ");

            Console.WriteLine("Calculates the sum of the digit");
            Console.WriteLine("Prints on the console the number in reversed order: dcba");
            Console.WriteLine("Puts the last digit in the first position: dabc");
            Console.WriteLine("Exchanges the second and the third digits: acbd");
            Console.WriteLine();
            Console.WriteLine(new string('*', 75));
            Console.Write("Enter your 4 digit number: ");
            int num = int.Parse(Console.ReadLine());

            int a = num / 1000;
            int b = (num / 100) % 10;
            int c = (num % 100) / 10;
            int d = num % 10;

            int sumABCD = a + b + d + c;

            Console.WriteLine();
            Console.WriteLine("Sum of digits is: {0}", sumABCD );
            Console.WriteLine("Revers order: {0}{1}{2}{3}", d, c, b,a);
            Console.WriteLine("Last digit in first position: {0}{1}{2}{3}",d,a,b,c);
            Console.WriteLine("Second and Third digits exchanged: {0}{1}{2}{3}", a,c,b,d);
            Console.WriteLine();

        }
    }
}
