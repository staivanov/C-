using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.PrintBestMatrixResult
{
    class BestMtrx
    {
        //Write a program that reads a square matrix of integers from a file and finds the sub-matrix with size 2 × 2 that has the maximal sum and writes this sum to a separate text file. The first line of input file contains the size of the recorded matrix (N). Thenext N lines contain N integers separated by spaces.

        static int[,] ReadMatrix()
        {
            using (StreamReader input = new StreamReader("matrix.txt"))
            {
                int n = int.Parse(input.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] numbers = input.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++) { 
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }
                return matrix;
            }
        }
        static int GetMax(int[,] matrix)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            { 
                for (int j = 0; j < matrix.GetLength(1) - 1; j++) 
                { 
                    maxSum = Math.Max(maxSum, matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                }
            }

            return maxSum;
        }

        static void WriteResult(int maxSum)
        {
            using (StreamWriter output = new StreamWriter("output.txt"))
            { 
                output.WriteLine(maxSum);
            }
        }

        static void Main(string[] args)
        {
            WriteResult(GetMax(ReadMatrix()));

        }
    }
}
