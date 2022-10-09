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
        public int id 
        {
            get;
        }
        public JobType type
        {
            get;
            set;
        }
        public string description
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }
        public int car
        {
            get;
        }
        public int employee
        {
            get;
            set;
        }
        public int customer
        {
            get;
        }
        public bool finished
        {
            get;
            set;
        }

        internal Job(int id, JobType type, string desc, int price, int car, int customer, int employee)
        {
            this.id = id;
            this.type = type;
            this.description = desc;
            this.price = price;
            this.car = car;
            this.customer = customer;
            this.employee = employee;
        }
    }
}
