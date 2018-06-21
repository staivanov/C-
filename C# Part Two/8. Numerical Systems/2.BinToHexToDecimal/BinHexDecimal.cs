using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinToHexToDecimal
{
    //  Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.

    class BinHexDecimal
    {
        static void Main(string[] args)
        {
            string num = "1111010110011110";
            //Bin to Hex
            string hex = Convert.ToInt32(num, 2).ToString("X");
            Console.WriteLine(hex);
            //Bin to Decimal
            string dec = Convert.ToInt32(num, 2).ToString();
            Console.WriteLine(dec);
        }
    }
}
