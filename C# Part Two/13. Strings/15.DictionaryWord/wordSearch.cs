using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.DictionaryWord
{
    class wordSearch
    {
        // A dictionary is given, which consists of several lines of text. Each line consists of a word and its explanation, separated by a hyphen:

        //.NET – platform for applications from Microsoft
        //CLR – managed execution environment for .NET
        //namespace – hierarchical organization of classes
        static void Main(string[] args)
        {
            string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes",
                              "Java - object-oriented programming language, similar to C#",
                              "Javascript - web programming language"};
            string word = Console.ReadLine();
            foreach (string line in dictionary)
            {
                if (line.IndexOf(word + " -") == 0)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
