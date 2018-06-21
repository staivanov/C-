using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _11.BeerTime
{
    class Time4Beer
    {
        // A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 

        static void Main(string[] args)
        {
            //BeerTime after 1:00PM and before 3:00AM
            // hh:mm tt
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt.ToString("hh:mm tt"));

            DateTime t1 = Convert.ToDateTime(dt);
            DateTime t2 = Convert.ToDateTime("1:00 PM"); // ->13:00
            DateTime t3 = Convert.ToDateTime("3:00 AM"); // <-3:00
            bool night = t1.TimeOfDay.Ticks < t3.TimeOfDay.Ticks;
            if ((t1.TimeOfDay.Ticks > t2.TimeOfDay.Ticks) || night )
            {
                Console.WriteLine("beer time");           
            }
            else
            {
                Console.WriteLine("not beer time");
            }

        }
    }
}
