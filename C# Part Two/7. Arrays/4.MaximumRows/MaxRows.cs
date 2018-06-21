using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaximumRows
{
    class MaxRows
    {
        //Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} à {2, 2, 2}.

        static void Main(string[] args)
        {
            Console.WriteLine("How much numbers will enter? ");
            int numbersLenght = int.Parse(Console.ReadLine());
            int[] numbs = new int[numbersLenght];
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLength = 0;
            Console.WriteLine();

            //Filling arr
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = int.Parse(Console.ReadLine());
            }

            //Checking
            Console.WriteLine();
            for (int j = 1; j < numbs.Length; j++)
            {
                // 2,3,4,5,6,7,7,7,9,2 -> 7,7,7

                if (numbs[j] == numbs[j - 1])
                {

                    len++;
                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestStart = start;
                    }

                }

                else if (numbs[j] != numbs[j - 1])
                {
                    start = j;
                }
            }

            //Print
            if (bestLength == 0)
            {

                Console.WriteLine("No best row");
            }
            else
            {
                for (int q = 0; q < bestLength; q++)
                {
                    Console.Write(numbs[bestStart] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
