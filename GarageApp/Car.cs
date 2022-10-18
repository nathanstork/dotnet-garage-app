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
        public string Id
        {
            get;
        }
        public string Plate
        {
            get;
        }
        public string Model
        {
            get;
        }
        public CarColor Color
        {
            get;
        }
        public int Customer
        {
            get;
        }

        private List<int> jobs = new List<int>();

        internal Car(string plate, string model, CarColor color, int job, int cust)
        {
            Id = IdGenerator.GetInstance().GetId();
            Plate = plate;
            Model = model;
            Color = color;
            Customer = cust;
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
