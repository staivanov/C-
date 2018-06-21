using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.aMatrix
{
    class aMatrix
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter h for heih and w for weight");
            Console.Write("h = ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("w = ");
            int w = int.Parse(Console.ReadLine());
         

            int[,] matrix = new int[h, w];

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++)
                {
                    matrix[row, col] = row  + h * col + 1;
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
               
            }


        }
    }
}
