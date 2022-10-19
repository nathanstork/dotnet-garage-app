using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.Contracts;

namespace GarageApp.Users
{
    internal class Mechanic : User
    {
        internal Contract Contract
        {
            get;
            set;
        }

        internal List<string> jobs = new List<string>();

        internal Mechanic(string name, string address, Contract contract) : base(name, address)
        {
            Name = name;
            Address = address;
            Contract = contract;
        }

        internal void AddJob(string jobId)
        {
            jobs.Add(jobId);
        }

        internal void RemoveJob(string jobId)
        {

        }
    }
}
