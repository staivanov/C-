using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ZeroSupset
{
    class ZeroSupsets
    {
        //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());

            ///2 digits sum
            ///a
            if ((a + b) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
            }
            if ((a + c) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
            }
            if ((a + d) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
            }
            ///b
            if ((b + c) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
            }
            if ((b + d) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
            }
            if ((b + e) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
            }
            ///c
            if ((c + d) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
            }
            if ((c + e) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
            }
            ///d
            if ((d + e) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
            }

            ///3 digits sum
            //a+b+c
            if ((a + b + c) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            }
            //a+b+d
            if ((a + c + d) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            }
            //a+b+e
            if ((a + c + d) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            }
            //а+c+d
            if ((a + c + d) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            }
            //a+c+e
            if ((a + c + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            }
            //a+d+e
            if ((a + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            }
            //b+c+d
            if ((b + c + d) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }
            //b+c+e
            if ((b + c + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            }
            //b+d+e
            if ((b + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            }
            //c+d+e
            if ((c + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }
            //4 digits sum
            //a+b+c+d
            if ((a + b + c + d) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            //a+b+c+e
            if ((a + b + c + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            }
            //a+b+d+e
            if ((a + b + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            }
            //a+c+d+e
            if ((a + c + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            }
            //b+c+d+e
            if ((b + c + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            }
            // 5 digits sum
            if ((a + b + c + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }
            else
            {
                Console.WriteLine("No zero subset");
            }

        }
    }
}
