using GarageApp.Utils;

namespace GarageApp.Tempname
{
    internal class Customer
    {
        public string Id
        {
            get;
        }
        public string Name
        {
            get;
        }
        public string Address
        {
            get;
            set;
        }

        private List<string> Cars = new List<string>();
        private List<string> Jobs = new List<string>();

        internal Customer(string name, string address, string carId, string jobId)
        {
            Id = IdGenerator.GetInstance().GetId();
            Name = name;
            Address = address;
            Cars.Add(carId);
            Jobs.Add(jobId);
        }

        public List<string> getCars()
        {
            return Cars;
        }

        public void AddCar(string carId)
        {
            Cars.Add(carId);
        }

        public List<string> GetJobs()
        {
            return Jobs;
        }

        public void AddJob(string jobId)
        {
            Jobs.Add(jobId);
        }
    }
}
