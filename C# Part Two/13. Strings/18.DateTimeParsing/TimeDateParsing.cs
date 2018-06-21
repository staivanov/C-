using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DateTimeParsing
{
    class TimeDateParsing
    {
        //Write a program that reads the date and time entered in the format "day.month.year hour:minutes:seconds" and prints the date and time after 6 hours and 30 minutes in the same format.
        static void Main(string[] args)
        {
            DateTime input = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(input.AddHours(6).AddMinutes(30));

        }
    }
}
