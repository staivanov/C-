using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8.IsoscelesTriangle
{

    class TrianglePrint
    {
//        Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.


        static void Main(string[] args)
        {
            char copy = '\u00a9';
            Console.OutputEncoding = Encoding.Unicode;
           
            double count = 1;
            int red = 3;
            double col = 2 * red - 1;

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j < (col / 2 - count / 2) || j > (col / 2 + count / 2 - 1))
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write(copy);
                }
                count = count + 2;
                Console.WriteLine();
            }

        }
    }
}
