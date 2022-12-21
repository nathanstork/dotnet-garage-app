namespace GarageApp.Users
{
    [Serializable]
    internal class Manager : User
    {
        internal List<Mechanic> Mechanics;

        internal Manager(string username, string password, string name, string address, Contract contract, List<Mechanic> mechanics) : base(username, password, name, address, contract)
        {
            Mechanics = mechanics;
        }
    }
}
