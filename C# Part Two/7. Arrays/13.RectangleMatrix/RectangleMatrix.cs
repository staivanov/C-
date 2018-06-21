using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.RectangleMatrix
{
    class RectangleMatrix
    {
        static void Main(string[] args)
        {

            Console.WriteLine("3x3 best sum");

            int[,] matrix = {
			{0, 2, 4, 0, 9, 5},
			{7, 1, 3, 3, 2, 1},
			{1, 3, 9, 8, 5, 6},
			{4, 6, 7, 9, 1, 0},
	       	};
        
            int bestSum = int.MinValue;
            

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                  int  sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum) {
                        bestSum = sum;
                    }
                }
            }

  
            Console.WriteLine("The maximal sum is: {0}", bestSum);






        }
    }
}
