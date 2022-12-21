namespace GarageApp
{
    [Serializable]
    internal class User
    {
        internal Garage Garage;

        internal string Username
        {
            get;
        }

        internal string Password
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

        internal Contract Contract
        {
            get;
            set;
        }

        internal User(string username, string password, string name, string address, Contract contract)
        {
            Garage = Garage.GetInstance();

            Username = username;
            Password = password;
            Name = name;
            Address = address;
            Contract = contract;
        }

        // Override display member with Name property
        public override string ToString()
        {
            return Name;
        }
    }
}
