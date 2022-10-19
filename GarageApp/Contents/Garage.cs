namespace GarageApp.Tempname
{
    internal class Garage
    {
        private static Garage? _instance;

        private List<Job> jobs = new List<Job>();
        private List<Car> cars = new List<Car>();
        private List<Customer> customers = new List<Customer>();

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

        public void AddJob(JobType type, string description, int price, Car car, Customer customer, string employeeId)
        {
            if (!cars.Any(item => item.Id == car.Id))
            {
                cars.Add(car);
            }

            if (!customers.Any(item => item.Id == customer.Id))
            {
                customers.Add(customer);
            }

            Job newJob = new Job(type, description, price, car.Id, customer.Id, employeeId);

            jobs.Add(newJob);
        }
    }
}
