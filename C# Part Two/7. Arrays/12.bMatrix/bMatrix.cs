﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.bMatrix
{
    class bMatrix
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            int[,] matrix = new int[n, n];

            for (int col = 0; col < n; col++)
            {

                if ((col % 2) == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }

                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
            }


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0}" + " ", matrix[row, col]);
                }
                Console.WriteLine();
            }



        }
    }
}
