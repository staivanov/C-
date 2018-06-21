using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PlayIntAndDoubleAndString
{
    class IntDoubleString
    {
        //Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

        static void Main()
        {
            Console.WriteLine("1 for int, 2 for double, 3 for string");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    int one = int.Parse(Console.ReadLine());
                    Console.WriteLine(one + 1);
                    break;
                case 2:
                    double two = double.Parse(Console.ReadLine());
                    Console.WriteLine(two + 1);
                    break;
                case 3:
                    string three = Console.ReadLine();
                    Console.WriteLine(three + '*');
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
