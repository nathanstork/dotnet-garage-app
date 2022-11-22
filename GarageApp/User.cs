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
            Garage = Garage.GetInstance();

            Username = username;
            Password = password;
            Name = name;
            Address = address;
        }

        internal void AddJob(Job job)
        {
            Garage.AddJob(job);
        }
    }
}
