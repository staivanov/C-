using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TimeElapsePCon
{
    class PConElapsed
    {
        static void Main(string[] args)
        {
           ///Count day ,hour,minutes whitch have passes since the computer is started  
            double system = Environment.TickCount;
            var timespan = TimeSpan.FromMilliseconds(system);
            Console.WriteLine("{0} days {1} hours {2} minutes computer is ON", timespan.ToString("dd"), timespan.ToString("hh"), timespan.ToString("mm"));
        }
    }
}
