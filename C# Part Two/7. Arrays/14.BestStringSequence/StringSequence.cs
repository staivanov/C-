using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BestStringSequence
{
    class StringSequence
    {
        static void Main()
        {          

            string[,] matrix = new string[4, 4]
            {
                {"ha",  "fq", "qw", "ee"},     
                {"fo",  "ha", "hx", "ww"},      
                {"fc",  "ha", "ha", "vv"},
                {"hf",  "hr", "tt", "tt"}
            };

            int count = 1;
            int bestCount = 1;
            
            
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool check1 = (matrix[row, col] == matrix[row + 1, col + 1]);
                    bool check2 = (matrix[row, col] == matrix[row + 1, col]);
                    bool check3 = matrix[row,col] == matrix[row, col+1];

                    if (check1 || check2 || check3)
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                        }
                    }
                }
            }

            Console.WriteLine(bestCount);
            
        }
    }
}
