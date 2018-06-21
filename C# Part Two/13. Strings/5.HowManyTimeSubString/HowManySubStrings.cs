using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HowManyTimeSubString
{
    class HowManySubStrings
    {
        //Write a program that detects how many times a substring is contained in the text. For example, let’s look for the substring "in" in the text:
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string k = "in";
            int count = 0;
            int index = text.IndexOf(k, StringComparison.CurrentCultureIgnoreCase);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(k, index + 1, StringComparison.CurrentCultureIgnoreCase);
            }
            Console.WriteLine(count);

        }
    }
}
