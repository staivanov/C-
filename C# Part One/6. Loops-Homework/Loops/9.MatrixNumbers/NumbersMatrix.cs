using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MatrixNumbers
{
    class NumbersMatrix
    {

        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in range (1 <= n <=20)");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    
                    Console.Write(row + col + " ");

                }
      
                Console.WriteLine();
            }

        }
    }
}
