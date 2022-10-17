using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Contracts
{
    internal abstract class Contract
    {
        internal int salary;
        internal int hours;

        internal Contract(int salary, int hours)
        {
            this.salary = salary;
            this.hours = hours;
        }

        internal abstract int GetMontlySalary();
        internal abstract int GetWeeklySalary();

        internal abstract int GetMontlyHours();
        internal abstract int GetWeeklyHours();

        internal abstract int GetYearlyHours();
        internal abstract int GetYearlySalary();
    }
}
