using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FormattingNumbers
{
    class FormatNumber
    {
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned

        public static void PrintingPositions(int a, float b, float c)
        {
            Console.WriteLine("{0:X}" + " " + "|" + Convert.ToString(a, 2).PadLeft(10, '0') + " " + "|{1,5:F2}|" + " " + "|{2:F3}" + " " + "|", a, b, c);
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            PrintingPositions(a, b, c);

        }

    }
}
