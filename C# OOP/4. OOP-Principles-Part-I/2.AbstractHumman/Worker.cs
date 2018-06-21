using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHumman
{
    class Worker : Human
    {
        private int _weekSalary;
        private int _workHourPerDay;

        public int WeekSalary
        {
            get { return this._weekSalary; }
            private set { this._weekSalary = value; }
        }

        public int WorkHourPerDay
        {
            get { return this._workHourPerDay; }
            private set { this._workHourPerDay = value; }
        }

        public Worker(string firstName, string lastName, int salaryForWeek, int workHour)
            : base(firstName, lastName)
        {
            this.WeekSalary = salaryForWeek;
            this.WorkHourPerDay = workHour;
        }

        public int  MoneyPerHours()
        {
            int salaryPerHour = this.WeekSalary / this.WorkHourPerDay;
            return salaryPerHour;
        } 

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", base.FirstName, base.LastName, this._weekSalary, this._workHourPerDay);
        }
    }
}
