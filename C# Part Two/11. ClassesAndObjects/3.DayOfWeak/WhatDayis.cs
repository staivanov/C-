﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DayOfWeak
{
    class WhatDayis
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Today is {0}", now.DayOfWeek);
        }
    }
}
