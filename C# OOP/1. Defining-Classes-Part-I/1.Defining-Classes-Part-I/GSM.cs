using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Part_I
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private uint price;
        private string owner;
        private Battery battery;
        private Display display;
        private static string modeliPhone4s = "iPhone 4s";
        private static double displayiPhone4s = 4;
        private static string processoriPhone4s = "Cortex-A8";
        private List<Call> callHistory;

        //Constructors
        public GSM() { }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, uint price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSM(string model, string manufacturer, uint price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;

        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.MyBattery = battery;
            this.MyDisplay = display;
        }


        public GSM(string model, string manufacturer, uint price, string owner, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.MyBattery = battery;
        }

        public GSM(string model, string manufacturer, uint price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.MyBattery = battery;
            this.MyDisplay = display;
            this.CallHistory = new List<Call>();
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public uint Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery MyBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display MyDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }

        private static string ModeliPhone4s
        {
            get { return modeliPhone4s; }
            set { modeliPhone4s = value; }
        }

        private static double DisplayIphone4s
        {
            get { return displayiPhone4s; }
            set { displayiPhone4s = value; }
        }

        private static string ProcessoriPhone4s
        {
            get { return processoriPhone4s; }
            set { processoriPhone4s = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
           private set { this.callHistory = value; }
        }

        //Methods
        public void LogCall()
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, this.callHistory[i]);
            }
        }

        public void MakeCall(Call start)
        {
            this.CallHistory.Add(start);
        }

        public void RemoveCall()
        {
            if (callHistory.Count == 0)
            {
                Console.WriteLine("No data for clear");
            }

            else
            {
                Console.WriteLine("You can choose between 1 and {0}", callHistory.Count);
                for (int i = 0; i < callHistory.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, this.callHistory[i]);
                }

                try
                {
                    Console.Write("Enter number: ");
                    int num = int.Parse(Console.ReadLine());
                    this.callHistory.RemoveAt(num - 1);
                    Console.WriteLine("Number successfully removed.");
                }

                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine("Incorrect data input!");
                }
            }
        }

        public void HistoryClear()
        {
            callHistory.Clear();
        }

        public void CalculateCalls(double price)
        {
            uint sum = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                sum += callHistory[i].Duration;
            }
            Console.WriteLine("If one minute is {0}$ your due is {1}$", price, sum * price);

        }

        public override string ToString()
        {
            return String.Format("My GSM is model {0} created by {1}. When i buy it was {2}lv. Yes, i am {3} and the owner of this phone {0}. I am not very satisfied by battery. Here some detail info - {4}, but display is {5} and is very good!", this.model, this.manufacturer, this.price, this.owner, this.battery, this.display);
        }

        public static void iPhone4s()
        {
            Console.WriteLine("Model: " + modeliPhone4s);
            Console.WriteLine("Display: " + displayiPhone4s + " inch");
            Console.WriteLine("Processor type: " + processoriPhone4s);
        }

    }
}
