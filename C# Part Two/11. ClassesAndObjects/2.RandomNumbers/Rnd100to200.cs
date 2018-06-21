using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomNumbers
{
    class Rnd100to200
    {
       
        public static int count = 100;

        public static void RandomFilling()
        {
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Random number #{0} = {1}", i+1, rnd.Next(100, 201));
            }
        }


       static void Main(string[] args)
        {
            Console.WriteLine("This program print hundred random numbers between 100 and 200");
            RandomFilling();
        }

    }
}
