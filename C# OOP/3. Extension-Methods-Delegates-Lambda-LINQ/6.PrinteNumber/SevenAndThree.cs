using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PrinteNumber
{
    class SevenAndThree
    {
        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 21, 7, 42, 33, 82, 63, 81, 210, 59, 109, 168 };
            //Lambda
            var myNumbers = arr.Where(x => (x % 21 == 0));
            PrintCollection(myNumbers);
            Console.WriteLine(new string('*', 50));
            //LiNQ
            var result =
                from num in arr
                where num % 21 == 0
                select num;
            PrintCollection(result);
        }
    }
}
