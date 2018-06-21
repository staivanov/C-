using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.WorkingDay
{
    class CalcWorkDay
    {
        static int WorkingDaysUntil(DateTime endDate)
        {
            List<DateTime> holidays = new List<DateTime>() {
            DateTime.Parse("01.01.2013"),
            DateTime.Parse("23.01.2013"),
            DateTime.Parse("24.01.2013")
        };

            int workingdays = 0;
            for (DateTime date = DateTime.Today; date <= endDate; date = date.AddDays(1))
            {
                if ((date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday)
                    && (holidays.IndexOf(date) != -1))
                {
                    workingdays++;
                }
            }

            return workingdays;
        }

        static void Main()
        {
            Console.WriteLine(WorkingDaysUntil(DateTime.Parse("25.01.2013")));
        }
    }
}