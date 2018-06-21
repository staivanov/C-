using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ArrsEqual
{
    class EqualArrs
    {
        //Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).

        static void Main(string[] args)
        {
            int[] a = new int[3];
            int[] b = new int[3];
            bool equal = true;
            
            //Enter values in arr
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }

            for (int j = 0; j < b.Length; j++)
            {
                b[j] = int.Parse(Console.ReadLine());
            }

            //Check for equals
            for (int q = 0; q < a.Length; q++)
            {                
               if( a[q] != b[q]) {
                   equal = false;
                   break;
                }            
            }

            Console.WriteLine("Arr is {0}", equal);

        }
    }
}
