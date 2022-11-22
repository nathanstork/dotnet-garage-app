﻿namespace GarageApp
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
            set;
        }
        internal int Price
        {
            get;
            set;
        }
        internal Car Car
        {
            get;
        }
        internal Customer Customer
        {
            get;
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
    }
}
