using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.Contracts;

namespace GarageApp
{
    internal class Mechanic
    {
        internal Mechanic()
        {
            MontlyContract contract = new MontlyContract(2000, 36);
            Console.WriteLine(contract.salary.ToString());
            Console.WriteLine(contract.hours.ToString());
        }
    }
}
