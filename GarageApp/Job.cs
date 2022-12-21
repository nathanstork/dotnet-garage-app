namespace GarageApp
{
    internal enum JobStatus
    {
        Unassigned,
        Assigned,
        WorkInProgress,
        OnHold,
        Completed,
        UnableToComplete
    }

    [Serializable]
    internal class Job
    {
        internal JobStatus Status
        {
            get;
            set;
        }
        internal string Description
        {
            get;
            set;
        }
        internal string Date
        {
            get;
        }
        internal int Price
        {
            get;
        }
        internal Car Car
        {
            get;
        }
        internal Customer Customer
        {
            get;
        }

        internal string Notes
        {
            get;
            set;
        }

        internal int Costs
        {
            get;
            set;
        }

        internal int Hours
        {
            get;
            set;
        }

        internal int LabourCosts
        {
            get;
            set;
        }

        internal string CompletedBy
        {
            get;
            set;
        }

        internal Job(string description, string date, int price, Car car, Customer customer)
        {
            Status = JobStatus.Unassigned;
            Description = description;
            Date = date;
            Price = price;
            Car = car;
            Customer = customer;
        }

        // Override display member with Description property
        public override string ToString()
        {
            return Date + " - " + Description;
        }
    }
}
