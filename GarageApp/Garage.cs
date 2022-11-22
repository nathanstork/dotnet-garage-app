namespace GarageApp
{
    internal class Garage
    {
        private static Garage? _instance;

        private List<Job> Jobs = new List<Job>();

        private Garage()
        {
            // TODO: Set jobs, cars and customers from file
        }

        internal static Garage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Garage();
            }
            return _instance;
        }

        public void AddJob(Job job)
        {
            Jobs.Add(job);
        }
    }
}
