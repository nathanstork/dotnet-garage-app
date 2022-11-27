namespace GarageApp
{
    [Serializable]
    internal class Garage
    {
        private static Garage? _instance;

        internal List<Job> Jobs = new List<Job>();

        private Garage()
        {
            // TODO: Set jobs, cars and customers from file
            Jobs.Add(new Job("Test description", "23-11-2022", 1200, new Car("plate", "model", "brand", CarColor.Navy), new Customer("name", "address", "email@gmail.nl", "+31 0612345678")));
            Jobs.Add(new Job("Test description 2", "23-11-2022", 1200, new Car("plate", "model", "brand", CarColor.Navy), new Customer("name", "address", "email@gmail.nl", "+31 0612345678")));
            Jobs.Add(new Job("Test description 3", "23-11-2022", 1200, new Car("plate", "model", "brand", CarColor.Navy), new Customer("name", "address", "email@gmail.nl", "+31 0612345678")));
        }

        internal static Garage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Garage();
            }
            return _instance;
        }

        internal void AddJob(Job job)
        {
            Jobs.Add(job);
        }
    }
}
