using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UnicodeCharacter
{
    class UnicodeChars
    {
        //Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be “*”.

        static void Main()
        {
            char someChar = '\u002A';
            Console.WriteLine(someChar);
        }
    }
}
