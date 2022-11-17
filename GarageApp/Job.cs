namespace GarageApp
{
    public enum JobType
    {
        Small,
        Medium,
        Large
    }

    internal class Job
    {
        public JobType Type
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public string Car
        {
            get;
        }
        public string Employee
        {
            get;
            set;
        }
        public string Customer
        {
            get;
        }
        public bool Finished
        {
            get;
            set;
        }

        internal Job(JobType type, string description, int price, string carId, string customerId, string employeeId)
        {
            Type = type;
            Description = description;
            Price = price;
            Car = carId;
            Customer = customerId;
            Employee = employeeId;
        }
    }
}
