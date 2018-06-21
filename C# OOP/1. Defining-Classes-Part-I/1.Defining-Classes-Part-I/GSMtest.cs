using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.Defining_Classes_Part_I
{
    public class GSMtest
    {
        //Write a class GSMTest to test the GSM class:
        //Create an array of few instances of the GSM class.
        //Display the information about the GSMs in the array.
        //Display the information about the static property IPhone4S.

        public static void TestGSM()
        {
            GSM myPhone = new GSM("Nexus 4", "LG", 769, "Stanislav", new Battery("NXS", 200, 17, BatteryType.LiIon), new Display(4.8, 16000000));
            GSM mySecondPhone = new GSM("Asha 210", "Nokia", 59, "Stanislav", new Battery("SH", 180, 10, BatteryType.NiCD), new Display(2.6, 65000));
            GSM nexus6 = new GSM("Nexus 6", "Motorola", 1100, "Carlo Gambino", new Battery("Non-removable", 256, 24, BatteryType.LiIon), new Display(5.96, 16000000));

            GSM[] phones = new GSM[3] { myPhone, mySecondPhone, nexus6 };

            foreach (var p in phones)
            {
                Console.WriteLine(new string('*', 70));
                Console.WriteLine(p);
                Console.WriteLine(new string('*', 70));            
            }

            GSM.iPhone4s();
        }

    }
}
