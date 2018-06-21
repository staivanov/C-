using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ReplaceAHREFurl
{
    class linReplace
    {
        //  Write a program that replaces all hyperlinks in a HTML document consisting of <a href="…">…</a> and hyperlinks in "forum" style, which look like [URL=…]…[/URL].
        static void Main(string[] args)
        {
            //Replace <a href="…">…</a>  with <url>...</url>
            string input = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            string openTag = "<a href=";
            string closeTag = "</a>";
            string openTagUrl = "[URL = ";
            string closeTagUrl = "[/URL]";
            StringBuilder sb = new StringBuilder(input);
            sb.Replace(openTag, openTagUrl);
            sb.Replace(closeTag, closeTagUrl);
            Console.WriteLine(sb);
        }
    }
}
