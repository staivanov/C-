using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SplitSlash
{
    class HowMuchSlashes
    {
        //   How many backslashes you must specify as an argument to the method Split(…) in order to split the text by a backslash?
        static void Main(string[] args)
        {
            StringBuilder path = new StringBuilder();
            path.Append("MyComputer");
            path.Append("\\");
            path.Append("New Volume(Z)");
            path.Append("\\");
            path.Append("Come");
            Console.WriteLine(path);
            Console.WriteLine("To use backslash in code, we need to write it two times");
        }
    }
}
