﻿using System;
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
            return Hours;
        }

        internal override int GetMontlySalary()
        {
            return Salary;
        }

        internal override int GetWeeklyHours()
        {
            return Hours * 12 / 52;
        }

        internal override int GetWeeklySalary()
        {
            return Salary * 12 / 52;
        }

        internal override int GetYearlyHours()
        {
            return Hours * 12;
        }

        internal override int GetYearlySalary()
        {
            return Salary * 12;
        }
    }
}
