using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class LongSequence
    {
        static void Main()
        {


            int j = -3;

            for (int i = 2; i < 1000; i+=2)
            {
               
               
                Console.WriteLine(i);
                Console.WriteLine(j);
                j -= 2;
            }
           

        }
    }
}
