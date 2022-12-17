namespace GarageApp
{
    [Serializable]
    internal class Customer
    {
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
        internal string Email
        {
            get;
            set;
        }
        internal string Phone
        {
            get;
            set;
        }

        internal Customer(string name, string address, string email, string phone)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }
    }
}
