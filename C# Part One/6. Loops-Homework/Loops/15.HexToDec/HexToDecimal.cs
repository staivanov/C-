using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexToDec
{
    class HexToDecimal
    {
      //  Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

        static void Main(string[] args)
        {
            //HEX SYMBOLS: A=10, B=11, C=12, D=13, E=14, F=15
            //Examples
            //D1E = 14*16^0 + 1*16^1 + 13*16^2 = 3358
            //FE = 14*16^0 + 15*16^1 = 254

            string hexNumber = Console.ReadLine();
            long decNumber = 0;
            long power = 1;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                int num;
                switch (hexNumber[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                    default: num = (int)hexNumber[i] - 48; break;
                }
                decNumber += num * power;
                power *= 16;
            }
            Console.WriteLine(decNumber);

        }
    }
}
