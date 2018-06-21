using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Numerical_Systems
{
    // Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.

    class NumToBin
    {
        static void Main(string[] args)
        {
            double[] numbs = new double[] { 151, 35, 43, 251, -0.41 };
            for (int i = 0; i < numbs.Length; i++)
            {
                string binary = Convert.ToString(Convert.ToInt32(numbs[i]), 2);                
                Console.WriteLine(binary.PadLeft(13,'0'));
                Console.WriteLine();
            }
        }
    }
}
