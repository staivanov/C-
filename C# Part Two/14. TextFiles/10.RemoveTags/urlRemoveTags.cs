using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace _10.RemoveTags
{
    class urlRemoveTags
    {
        //   Write a program that extracts from an XML file the text only (without the tags).

        static void Main(string[] args)
        {
            string fileSourcePath = "test.xml";
            string fileResultPath = "result.txt";

            try
            {
                using (XmlReader reader = XmlReader.Create(new StreamReader(fileSourcePath, Encoding.GetEncoding("utf-8"))))
                {
                    while (!reader.EOF)
                    {
                        using (StreamWriter writer = new StreamWriter(fileResultPath, false, Encoding.GetEncoding("utf-8")))
                        {
                            while (!reader.EOF)
                            {
                                reader.Read();
                                if (reader.NodeType == XmlNodeType.Text)
                                {
                                    writer.WriteLine(reader.Value);
                                }
                            }
                        }
                    }
                }
            }

            catch (IOException ex)
            {
                Console.WriteLine("io operation error!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
            catch (XmlException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }




        }
    }
}
