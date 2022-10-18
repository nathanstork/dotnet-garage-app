using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    internal class Manager : User
    {
        internal string Username
        {
            get;
            set;
        }

        internal string Password
        {
            get;
            set;
        }

        internal Manager(string name, string address, string username, string password) : base(name, address)
        {
            Username = username;
            Password = password;
        }
    }
}
