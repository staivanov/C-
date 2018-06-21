using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Part_I
{
    class GSMCallHistoryTest
    {
        public static void Invoke()
        {
            GSM myPhone = new GSM("Nexus 4", "LG", 769, "Stanislav", new Battery("NXS", 200, 17, BatteryType.LiIon), new Display(4.8, 16000000));

            myPhone.MakeCall(new Call(0883777777, 1));
            myPhone.MakeCall(new Call(0888123987, 10));
            myPhone.MakeCall(new Call(0897000500, 20));
            myPhone.MakeCall(new Call(0887654312, 5));
            myPhone.MakeCall(new Call(0883984315, 40));
      
            for (int i = 0; i < myPhone.CallHistory.Count; i++)
            {
                Console.WriteLine(myPhone.CallHistory[i]);
            }
           
            Console.WriteLine();
            myPhone.CalculateCalls(0.37);
            Console.WriteLine();
            myPhone.RemoveCall();
            Console.WriteLine();
            myPhone.LogCall();
            Console.WriteLine();
            myPhone.CalculateCalls(0.37);
            myPhone.HistoryClear();

            Console.WriteLine("Numbers is my log are {0}", myPhone.CallHistory.Count);
        }
    }
}
