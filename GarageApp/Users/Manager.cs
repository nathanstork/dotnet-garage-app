using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Users
{
    internal class Manager : User
    {
        internal Manager(string username, string password, string name, string address) : base(username, password, name, address)
        {
            
        }
    }
}
