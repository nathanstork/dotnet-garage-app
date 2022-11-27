using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Users
{
    [Serializable]
    internal class Manager : User
    {
        internal List<Mechanic> Mechanics;

        internal Manager(string username, string password, string name, string address, List<Mechanic> mechanics) : base(username, password, name, address)
        {
            Mechanics = mechanics;
        }
    }
}
