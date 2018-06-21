using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LexicographArrs
{
    class LexicographCheck
    {
        //Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.

        static void Main()
        {
            char[] a = new char[5];
            char[] b = new char[5];

            ///Arr fills
            Console.WriteLine("Enter arr1 letters");
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter arr2 letters");
            for (int j = 0; j < b.Length; j++)
            {

                b[j] = char.Parse(Console.ReadLine());

            }

           ///Checking arrys
            Console.WriteLine();
            for (int q = 0; q < a.Length; q++)
            {

                if (a[q] == b[q])
                {
                    Console.WriteLine("Lexicographically the  arrays are equal");
                }

                else if (a[q] > b[q])
                {
                    Console.WriteLine("Lexicographically arr2 is first");
                    break;
                }

                else
                {
                    Console.WriteLine("Lexicographically arr1 is first");
                    break;
                }
            }

        }
    }
}
