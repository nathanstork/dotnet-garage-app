using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Users
{
    [Serializable]
    internal class Mechanic : User
    {
        internal List<Job> Jobs = new List<Job>();

        internal Contract Contract
        {
            get;
            set;
        }

        internal Mechanic(string username, string password, string name, string address, Contract contract) : base(username, password, name, address)
        {
            Contract = contract;
        }

        internal void SetJobStatus(Job job, JobStatus status)
        {
            job.Status = status;
        }
    }
}
