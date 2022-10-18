namespace GarageApp
{
    internal class Customer
    {
        public string id
        {
            get;
        }
        public string name
        {
            get;
        }
        public string address
        {
            get;
            set;
        }

        private List<string> cars = new List<string>();
        private List<string> jobs = new List<string>();

        internal Customer(string name, string address, string carId, string jobId)
        {
            id = IdGenerator.GetInstance().GetId();
            this.name = name;
            this.address = address;
            cars.Add(carId);
            jobs.Add(jobId);
        }

        public List<string> getCars()
        {
            return cars;
        }

        public void AddCar(string carId)
        {
            cars.Add(carId);
        }

        public List<string> GetJobs()
        {
            return jobs;
        }

        public void AddJob(string jobId)
        {
            jobs.Add(jobId);
        }
    }
}
