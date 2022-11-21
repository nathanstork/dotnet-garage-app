using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Contracts
{
    [Serializable]
    internal class MontlyContract : Contract
    {
        public MontlyContract(int salary, int hours) : base(salary, hours)
        {
        }

        internal override int GetMontlyHours()
        {
            return hours;
        }

        internal override int GetMontlySalary()
        {
            return salary;
        }

        internal override int GetWeeklyHours()
        {
            return hours * 12 / 52;
        }

        internal override int GetWeeklySalary()
        {
            return salary * 12 / 52;
        }

        internal override int GetYearlyHours()
        {
            return hours * 12;
        }

        internal override int GetYearlySalary()
        {
            return salary * 12;
        }
    }
}
