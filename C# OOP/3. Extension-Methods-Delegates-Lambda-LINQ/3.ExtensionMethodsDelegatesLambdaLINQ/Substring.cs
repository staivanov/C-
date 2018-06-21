using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
   internal static class Extension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int lenght)
        {
            StringBuilder temp = new StringBuilder();
            string text = sb.ToString();
            text = text.Substring(index, lenght);
            return temp.Append(text);
        }
    }
}
