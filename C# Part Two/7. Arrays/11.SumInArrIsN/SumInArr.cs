using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumInArrIsN
{
    class SumInArr
    {
        static void Main(string[] args)
        {



            // {4, 3, 1, 4, 2, 5, 8} -> S = 11 {4,2,5}
            int[] arr = { 4, 3, 4, 4, 2, 5, 8 };
            int n = 11;
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if(sum == 11)
                    {
                        Console.WriteLine("-----------");
                        Console.WriteLine("super");
                        Console.WriteLine(i);
                        Console.WriteLine(j);
                        Console.WriteLine("------------");
                        for (int k = i; k <= j; k++)
                        {
                            Console.WriteLine(arr[k]);
                        }
                        sum = 0;
                        break;
                        
                    }
                }
            }


           








        }
    }
}
