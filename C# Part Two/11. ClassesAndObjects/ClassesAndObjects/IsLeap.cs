using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesAndObjects
{
    class IsLeap
    {

        public static void LeapCheck(DateTime myYear)
        {
            if (DateTime.IsLeapYear(myYear.Year) == false)
            {
                Console.WriteLine("This is not a leap year.");
            }
            else
            {
                Console.WriteLine("This is a leap year.");
            }
            
        }
 

        static void Main(string[] args)
        {
            Console.WriteLine("This program check year for leap");

            Console.Write("year: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("day: ");
            int d = int.Parse(Console.ReadLine());

            DateTime myYear = new DateTime(y, m, d);
            LeapCheck(myYear);

        }
    }
}
