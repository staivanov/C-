using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _13.URLprotocol
{
    class protocolExtract
    {
        //Write a program that parses an URL in following format:[protocol]://[server]/[resource]
        static void Main(string[] args)
        {
            //[protocol]://[server]/[resource]
            //http://www.devbg.org/forum/index.php резултатът е:            
            //[protocol]="http"            
            //[server]="www.devbg.org"            
            //[resource]="/forum/index.php"
            string text = "http://www.devbg.org/forum/index.php";

            string protocol = @"\w{4}";
            string server = @"w{3}.([a-z]+).([a-z]+)";
            string resource = @"/([a-z]+)/([a-z]+).([a-z]+)";

            Match protocolMatch = Regex.Match(text, protocol);
            Match serverMatch = Regex.Match(text, server);
            Match resourceMatch = Regex.Match(text, resource);

            Console.WriteLine("[protocol] = {0}", protocolMatch);
            Console.WriteLine("[server] = {0}", serverMatch);
            Console.WriteLine("[resource] = {0}", resourceMatch);          
        }
    }
}
