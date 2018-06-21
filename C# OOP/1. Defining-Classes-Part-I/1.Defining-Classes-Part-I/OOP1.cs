using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Part_I
{
    public class OOP1
    {
        static void Main(string[] args)
        {
            //GSM mySecondPhone = new GSM("Asha 210", "Nokia", 59, "Stanislav", new Battery("SH", 3000, 200, BatteryType.NiCD), new Display(2.6, 65000));
            //GSM nexus6 = new GSM("Nexus 6", "Motorola", 1100, "Carlo Gambino", new Battery("Non-removable", 330, 24, BatteryType.LiIon), new Display(5.96, 16000000));

            GSMtest.TestGSM();
            GSMCallHistoryTest.Invoke();

        }
    }
}
