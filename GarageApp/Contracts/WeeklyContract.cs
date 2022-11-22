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
            return Hours * 52 / 12;
        }

        internal override int GetMontlySalary()
        {
            return Salary * 52 / 12;
        }

        internal override int GetWeeklyHours()
        {
            return Hours;
        }

        internal override int GetWeeklySalary()
        {
            return Salary;
        }

        internal override int GetYearlyHours()
        {
            return Hours * 52;
        }

        internal override int GetYearlySalary()
        {
            return Salary * 52;
        }
    }
}
