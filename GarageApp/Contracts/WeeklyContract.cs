using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Contracts
{
    [Serializable]
    internal class WeeklyContract : Contract
    {
        public WeeklyContract(int salary, int hours) : base(salary, hours)
        {
        }

        internal override int GetMontlyHours()
        {
            return hours * 52 / 12;
        }

        internal override int GetMontlySalary()
        {
            return salary * 52 / 12;
        }

        internal override int GetWeeklyHours()
        {
            return hours;
        }

        internal override int GetWeeklySalary()
        {
            return salary;
        }

        internal override int GetYearlyHours()
        {
            return hours * 52;
        }

        internal override int GetYearlySalary()
        {
            return salary * 52;
        }
    }
}
