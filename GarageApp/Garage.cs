namespace GarageApp
{
    internal class Garage
    {
        private static Garage? _instance;

        private List<Job> Jobs = new List<Job>();
        private List<Car> Cars = new List<Car>();
        private List<Customer> Customers = new List<Customer>();

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
            /*if (!Cars.Any(item => item.Id == car.Id))
            {
                Cars.Add(car);
            }

            if (!Customers.Any(item => item.Id == customer.Id))
            {
                Customers.Add(customer);
            }

            Job newJob = new(type, description, price, car.Id, customer.Id, employeeId);

            Jobs.Add(newJob);*/
        }
    }
}
