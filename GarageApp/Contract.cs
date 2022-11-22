using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    [Serializable]
    internal abstract class Contract
    {
        internal int Salary;
        internal int Hours;

        internal Contract(int salary, int hours)
        {
            Salary = salary;
            Hours = hours;
        }

        internal int GetHourlySalary()
        {
            return Salary / Hours;
        }

        internal abstract int GetWeeklySalary();
        internal abstract int GetWeeklyHours();

        internal abstract int GetMontlySalary();
        internal abstract int GetMontlyHours();

        internal abstract int GetYearlySalary();
        internal abstract int GetYearlyHours();
    }
}
