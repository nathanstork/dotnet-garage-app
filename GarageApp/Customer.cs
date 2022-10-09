namespace GarageApp
{
    internal class Customer
    {
        public int id
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

        private List<int> cars = new List<int>();
        private List<int> jobs = new List<int>();

        internal Customer(int id, string name, string address, int car, int job)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            cars.Add(car);
            jobs.Add(job);
        }

        public List<int> getCars()
        {
            return cars;
        }

        public void AddCar(int car)
        {
            cars.Add(car);
        }

        public List<int> GetJobs()
        {
            return jobs;
        }

        public void AddJob(int job)
        {
            jobs.Add(job);
        }
    }
}
