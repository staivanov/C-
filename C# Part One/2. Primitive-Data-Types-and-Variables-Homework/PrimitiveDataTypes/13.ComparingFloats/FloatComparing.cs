using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class FloatComparing
    {
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

        static void Main(string[] args)
        {
            //Condition
            double a = -4.999999;
            double b = -4.999998;
            double c;
            double eps = 0.000001;
            bool equal = true;
            bool notEqual = false;

            // Verification
            for (int i = 0; i < 2; i++)
            {
                if (a > b)
                {
                    if ((a - b) <= eps)
                    {
                        Console.WriteLine(equal);
                    }
                    else
                    {
                        Console.WriteLine(notEqual);
                    }
                    break;

                }

                else if (b > a)
                {
                    c = b;
                    b = a;
                    a = c;
                }
                else if (a == b)
                {
                    Console.WriteLine(equal);
                    break;
                }

            }
        }
    }
}
