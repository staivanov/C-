using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Matrix
{
    class MatrixTask
    {
//* Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
//* Implement an indexer this[row, col] to access the inner matrix cells.
//* Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//* Throw an exception when the operation cannot be performed.

        static void Main(string[] args)
        {

            Matrix<int> firstMatrix = new Matrix<int>(4, 4);
            Matrix<int> secondMatrix = new Matrix<int>(4, 4);
           
            //Filling 2 matrix
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    firstMatrix[row, col] = 5;
                }
            }


            for (int r = 0; r < secondMatrix.Rows; r++)
            {
                for (int c = 0; c < secondMatrix.Cols; c++)
                {
                    secondMatrix[r, c] = 3;
                }
            }

            //Test operation
            //Matrix<int> test = firstMatrix - secondMatrix;
            //Matrix<int> test = firstMatrix * secondMatrix;
            Matrix<int> test = firstMatrix + secondMatrix;

            for (int i = 0; i < test.Rows; i++)
            {
                for (int j = 0; j < test.Cols; j++)
                {
                    Console.Write(test[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
