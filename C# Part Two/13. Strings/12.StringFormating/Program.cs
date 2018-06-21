using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StringFormating
{
    class Program
    {
        // Write a program that reads a number from console and prints it in 15-character field, aligned right in several ways: as a decimal number, hexadecimal number, percentage, currency and exponential (scientific) notation.
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0, 30}", num);
            Console.WriteLine("{0, 30:x4}", num);
            Console.WriteLine("{0, 30:P}", num);
            Console.WriteLine("{0, 30:C}", num);
            Console.WriteLine("{0, 30:E}", num);
        }
    }
}
