using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptops
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop someLaptop = new Laptop(new Model("ThinkPad", "Z510"), Manufacturer.Lenovo, Processor.IntelCorei5, 8, VGA.GeForce440m, 1, 15.4, new Battery(4, 3000), 4.5, 1300);
            Console.WriteLine(someLaptop);  
        }
    }
}
