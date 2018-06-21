using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HexToDecimalBin
{
    //   Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.

    class HexToDecBin
    {
        static void Main(string[] args)
        {
            string[] hex = new string[] { "2A3E", "FA", "FFFF", "5A0E9" };
            //Hex to Bin
            for (int i = 0; i < hex.Length; i++)
            {
                string bin = Convert.ToString(Convert.ToInt32(hex[i], 16), 2);
                Console.WriteLine(bin);
            }
            Console.WriteLine();
            //Hex to Dec
            for (int i = 0; i < hex.Length; i++)
            {
                int dec = Convert.ToInt32(hex[i], 16);
                Console.WriteLine(dec);
            }


        }
    }
}
