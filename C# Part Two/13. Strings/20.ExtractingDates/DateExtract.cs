﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _20.ExtractingDates
{
    class DateExtract
    {
        //Write a program that extracts from a text all dates written in format DD.MM.YYYY and prints them on the console in the standard format for Canada. Sample text:
        static void Main(string[] args)
        {
            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
            string pattern = @"\b((\d{1,2})\.(\d{1,2})\.(\d{4}))\b";
            Match m = Regex.Match(text, pattern);

            while (m.Success)
            {
                Console.WriteLine(m);
                m = m.NextMatch();
            }

        }
    }
}
