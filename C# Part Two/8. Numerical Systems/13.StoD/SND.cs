using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.StoD
{
    // Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral system.

    class SND
    {
        public static int BinToDecimal(string n)
        {
            int[] num = new int[100];
            int p = 1;
            int result = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == ('0'))
                {
                    num[i] = 0;
                }
                else if (n[i] == '1')
                {
                    num[i] = 1;
                }
            }

            for (int j = n.Length - 1; j >= 0; j--)
            {
                result = result + num[j] * p;
                p = p * 2;
            }

            return result;
        }

        public static long HexToDecimal(string hexNumber)
        {

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
            return decNumber;
        }

        public static void DecimalToBin()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            long remainder;
            string result = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Enter what is your current numerical system");
            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter what value with number wanna convert");
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());


            if ((s >= 2) && (d <= 16))
            {

                switch (s)
                {
                    case 2:
                        string n = Console.ReadLine();
                        BinToDecimal(n);
                        break;
                    case 8:

                        break;

                    case 16:
                        string hexNumber = Console.ReadLine();
                        HexToDecimal(hexNumber.ToUpper());
                        break;

                    default:
                        Console.WriteLine("Incorect input");
                        break;
                }

                switch (d)
                {
                    case 2:                     
                        break;
                    case 8:
                        break;
                    case 10:
                        break;
                    case 16:
                        break;

                    default:
                        break;
                }


            }

        }
    }
}
