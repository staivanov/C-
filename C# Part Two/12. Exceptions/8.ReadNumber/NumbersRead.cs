using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ReadNumber
{
    class NumbersRead
    {
	//Write a method ReadNumber(int start, int end) that reads an integer from the console in the range [start…end]. In case the input integer is not valid or it is not in the required range throw appropriate exception. Using this method, write a program that takes 10 integers a1, a2, …, a10 such that 1 < a1 < … < a10 < 100
        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());
            if (!(start < n && n < end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return n;
        }

        static void Main(string[] args)
        {
            int min = 1, max = 100;

            for (int i = 0; i < 10; i++)
            {
                min = ReadNumber(min, max);
            }

        }
    }
}
