using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaxUpperSequence
{
    //Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} à {2, 3, 4}.

    class upperSequence
    {
        private static void PrintSequence(int[] numbs, int bestLength, int bestIndex)
        {
            for (int q = bestIndex; q < bestIndex + bestLength; q++)
            {
                Console.WriteLine(numbs[q]);
            }
        }

        private static int[] FillingArr(int[] numbs)
        {
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = int.Parse(Console.ReadLine());
            }
            return numbs;
        }

        private static void CheckingNumbs(int[] numbs, ref int len, ref int index, ref int bestLength, ref int bestIndex)
        {
            for (int j = 1; j < numbs.Length; j++)
            {

                if (numbs[j] > numbs[j - 1])
                {
                    len++;
                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestIndex = index;
                    }
                }

                else if (numbs[j] <= numbs[j - 1])
                {
                    len = 1;
                    index = j;
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("How much numbers will enter? ");
            int numbersLength = int.Parse(Console.ReadLine());
            int[] numbs = new int[numbersLength];
            int len = 1;
            int index = 0;
            int bestLength = 0;
            int bestIndex = 0;
            Console.WriteLine();

            FillingArr(numbs);
            CheckingNumbs(numbs, ref len, ref index, ref bestLength, ref bestIndex);
            PrintSequence(numbs, bestLength, bestIndex);


        }


    }
}
