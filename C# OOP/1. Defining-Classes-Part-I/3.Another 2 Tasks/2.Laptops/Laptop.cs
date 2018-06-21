using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptops
{
    public class Laptop
    {

        private Model model;
        private Manufacturer manufacturer;
        private Processor processor;
        private sbyte ram;
        private VGA graphicsCard;
        private ushort hdd;
        private double screen;
        private Battery battery;
        private double batteryLife;
        private double price;
    
        public Laptop() { }

        public Laptop(Model model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(Model model, Manufacturer manufacturer, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public Laptop(Model model, Manufacturer manufacturer, Processor processor, sbyte ram, VGA graphicsCard, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.Price = price;
        }

        public Laptop(Model model, Manufacturer manufacturer, Processor processor, sbyte ram, VGA graphicsCard, ushort hdd, double screen, Battery battery, double batteryLife, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Model Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Manufacturer Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public Processor Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public sbyte RAM
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public VGA GraphicsCard
        {
            get { return graphicsCard; }
            set { graphicsCard = value; }
        }

        public ushort HDD
        {
            get { return hdd; }
            set { this.hdd = value; }
        }

        public double Screen
        {
            get { return screen; }
            set { this.screen = value; }
        }

        public Battery Battery
        {
            get { return battery; }
            set { this.battery = value; }
        }

        public double BatteryLife
        {
            get { return batteryLife; }
            set { this.batteryLife = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return String.Format("Model - {0}, Manufactured - {1}, Processor - {2}, RAM - {3}, VGA - {4}, HDD - {5}Tb, Screen - {6} Inch, Battery - {7}, Battery Life - {8}h, Price - {9:0.00} lv", this.model, this.manufacturer, this.processor, this.ram, this.graphicsCard, this.hdd, this.screen, this.battery, this.batteryLife, this.price);
        }


    }
}
