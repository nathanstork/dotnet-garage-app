namespace GarageApp
{
    internal class User
    {
        private int UserId
        {
            get { return UserId; }
            set { UserId = value; }
        }

        private string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Address
        {
            get { return Address; }
            set { Address = value; }
        }

        protected User(int identifier, string name, string address)
        {
            UserId = identifier;
            Name = name;
            Address = address;
        }
    }
}
