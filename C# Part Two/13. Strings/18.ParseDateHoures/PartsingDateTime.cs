using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ParseDateHoures
{
    class PartsingDateTime
    {
        //Write a program that reads two dates entered in the format "day.month.year" and calculates the number of days between them.
        public static void CalcDate(DateTime now, DateTime late)
        {
            if (now < late)
            {
                DateTime temp = now;
                now = late;
                late = temp;
            }
     
            Console.WriteLine((now - late).TotalDays);
        }

        static void Main(string[] args)
        {
            DateTime now = DateTime.Parse(Console.ReadLine());
            DateTime late = DateTime.Parse(Console.ReadLine());
            CalcDate(now, late);
        }
    }
}
