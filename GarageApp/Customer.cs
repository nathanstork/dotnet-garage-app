namespace GarageApp
{
    [Serializable]
    internal class Customer
    {
        internal string Name
        {
            get;
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
        internal string Phonenumber
        {
            get;
            set;
        }

        internal Customer(string name, string address, string email, string phonenumber)
        {
            Name = name;
            Address = address;
            Email = email;
            Phonenumber = phonenumber;
        }
    }
}
