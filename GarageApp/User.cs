namespace GarageApp
{
    [Serializable]
    internal class User
    {
        internal string Username
        {
            get;
        }

        internal string Password
        {
            get; set;
        }

        internal string Name
        {
            get; set;
        }

        internal string Address
        {
            get; set;
        }

        internal User(string username, string password, string name, string address)
        {
            Username = username;
            Password = password;
            Name = name;
            Address = address;
        }
    }
}
