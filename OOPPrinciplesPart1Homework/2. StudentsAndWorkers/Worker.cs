using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private const byte workDaysPerWeek = 5;
        
        private double weekSalary;
        private double workHoursPerDay;

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.workHoursPerDay = value;
            }
        }
        
        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.weekSalary = value;
            }
        }

        public Worker(string firstName, string lastName, double workHoursPerDay, double weekSalary) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double moneyPerDay = this.WeekSalary / workDaysPerWeek;
            double moneyPerHour = moneyPerDay * this.WorkHoursPerDay;
            return moneyPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} Money Per Hour: {1}", base.ToString(), this.MoneyPerHour());
        }
    }
}
