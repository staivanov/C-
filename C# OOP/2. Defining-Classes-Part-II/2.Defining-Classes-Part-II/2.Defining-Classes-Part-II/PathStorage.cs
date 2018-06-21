using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.Defining_Classes_Part_II
{
    public static class PathStorage
    {
        public static void Save(Path cc){
            string output = "output.txt";
            StreamWriter writer = new StreamWriter(output);

            using (writer)
            {
                writer.WriteLine(cc);
            }
        }

        public static void Load(string pathToFile)
        {
            StreamReader reader = new StreamReader(pathToFile);
            string line = reader.ReadLine();

            using (reader)
            {
                while (!String.IsNullOrEmpty(line))
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

    }
}
