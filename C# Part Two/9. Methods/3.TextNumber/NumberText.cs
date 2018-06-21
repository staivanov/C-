﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TextNumber
{
    class NumberText
    {
     //   Write a method that returns the English name of the last digit of a given number. Example: for 512 prints "two"; for 1024 à "four".//

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            NumberToText(n);
        }

        public static void NumberToText(int n)
        {
            switch (n % 10)
            {
                case 0:
                    {
                        Console.WriteLine("Zero");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("One");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Two");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Three");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Four");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Five");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Six");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Seven");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Eight");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Nine");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Incorect input");
                        break;
                    }
            }
        }
    }
}
