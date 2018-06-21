using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ThreeTasks
{
//Write a program that solves the following tasks:
//Put the digits from an integer number into a reversed order.
//Calculate the average of given sequence of numbers.
//Solve the linear equation a * x + b = 0.
//Create appropriate methods for each of the above tasks.
//Make the program show a text menu to the user. By choosing an option of that menu, the user will be able to choose which task to beinvoked.
//Perform validation of the input data:
//The integer number must be a positive in the range [1…50,000,000].
//The sequence of numbers cannot be empty.
// The coefficient a must be non-zero.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Make your choise for operation");
            Console.WriteLine("1 for reverses the digits of a number ");
            Console.WriteLine("2 for calculates the average of a sequence of integers");
            Console.WriteLine("3 for solves a linear equation a * x + b = 0");
            Console.Write("Your number for operation is: ");
            int choise = int.Parse(Console.ReadLine());

           
                switch (choise)
                {
                    case 1:
                        ReverseNumber();
                        break;
                    case 2:
                        Average();
                        break;
                    case 3:
                        Console.WriteLine("This program calculate linear equation");
                        Console.WriteLine("ax + b = 0");
                        Console.WriteLine("\'a\' should not be equal to 0");
                        Console.Write("a = ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        double b = double.Parse(Console.ReadLine());

                        LinearEquation(a, b);
                        break;

                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }

        
        public static void LinearEquation(double a, double b)
        {
            if ((b == 0) && (a == 0))
            {
                Console.WriteLine("Equation has infinite solutions");
            }
            else if (a == 0)
            {

            }
            else if (b == 0)
            {
                Console.WriteLine("Equation dont have solution");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine(x);
            }
        }


        private static void Average()
        {
            Console.WriteLine("How much numbers will enter?");
            int numberCounter = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(numberCounter);

            for (int j = 0; j < numberCounter; j++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int sum = numbers.Sum();
            double average = sum / numberCounter;
            Console.WriteLine("Average is: {0}", average);
        }


        private static void ReverseNumber()
        {
            Console.WriteLine("Enter your number");
            int n = int.Parse(Console.ReadLine());
            string reversN = n.ToString();

            for (int i = reversN.Length - 1; i >= 0; i--)
            {
                Console.Write(reversN[i]);
            }

            Console.WriteLine();
        }

    }
}
