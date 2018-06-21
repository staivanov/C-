using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Exceptions
{
    class PrintSqrt
    {
//Write a program that takes a positive integer from the console and prints the square root of this integer. If the input is negative or invalid print "Invalid Number" in the console. In all cases print "Good Bye".
       public static void CheckForNegativeNumber(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException("Invalid number! The square root is defined only for non-negative numbers!");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckForNegativeNumber(number);
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} is {1}.", number, squareRoot);
            }
            catch (FormatException formatException)
            {
                throw new FormatException("Invalid number! " + formatException.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The input number is too big or too small!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
