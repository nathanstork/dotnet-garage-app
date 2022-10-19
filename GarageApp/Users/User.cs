using GarageApp.Utils;

namespace GarageApp.Users
{
    internal class User
    {
        internal string Id
        {
            get;
        }

        internal string Name
        {
            get;
            set;
        }

        internal string Address
        {
            get;
            set;
        }

        internal User(string name, string address)
        {
            Id = IdGenerator.GetInstance().GetId();
            Name = name;
            Address = address;
        }
    }
}
