using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal Mechanic(string username, string password, string name, string address, Contract contract) : base(username, password, name, address)
        {
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
