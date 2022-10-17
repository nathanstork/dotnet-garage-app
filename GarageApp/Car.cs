namespace GarageApp
{
    public enum CarColor
    {
        White,
        Yellow,
        Orange,
        Red,
        Pink,
        Purple,
        Cyan,
        Navy,
        Lime,
        Forest,
        Brown,
        Grey,
        Black
    }

    internal class Car
    {
        public int id
        {
            get;
        }
        public string plate
        {
            get;
        }
        public string model
        {
            get;
        }
        public CarColor color
        {
            get;
        }
        public int customer
        {
            get;
        }

        private List<int> jobs = new List<int>();

        internal Car(int id, string plate, string model, CarColor color, int job, int cust)
        {
            this.id = id;
            this.plate = plate;
            this.model = model;
            this.color = color;
            customer = cust;
            jobs.Add(job);
        }

        public List<int> getJobs()
        {
            return jobs;
        }

        public void AddJob(int jobId)
        {
            jobs.Add(jobId);

            // TODO: If jobId is already in list, throw exception
        }

        public void RemoveJob(int jobId)
        {
            jobs.Remove(jobId);

            //TODO: If item is not in list, throw exception
        }
    }
}
