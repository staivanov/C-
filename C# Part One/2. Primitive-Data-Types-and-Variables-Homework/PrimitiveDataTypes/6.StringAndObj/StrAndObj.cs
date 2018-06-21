using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringAndObj
{
    class StrAndObj
    {
        //Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare 	 string variable and initialize it with the value of the object variable (you should perform type casting).

        static void Main(string[] args)
        {
            string greeting = "Hello";
            string who = "World";
            object totalGreeting = greeting + " " + who;
            Console.WriteLine(totalGreeting);
        }
    }
}
