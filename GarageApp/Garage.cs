namespace GarageApp
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

        public void AddJob(JobType type, string description, int price, Car car, Customer customer, int employeeId)
        {
            if (!cars.Any(item => item.id == car.id))
            {
                cars.Add(car);
            }

            if (!customers.Any(item => item.id == customer.id))
            {
                customers.Add(customer);
            }

            Job newJob = new Job(0, type, description, price, car.id, customer.id, employeeId);

            jobs.Add(newJob);
        }
    }
}
