﻿namespace GarageApp.Users
{
    [Serializable]
    internal class Mechanic : User
    {
        internal List<Job> Jobs = new List<Job>();

        internal Mechanic(string username, string password, string name, string address, Contract contract) : base(username, password, name, address, contract) { }
    }
}
