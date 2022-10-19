using GarageApp.Utils;

namespace GarageApp.Tempname
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
            set;
        }
        public string Model
        {
            get;
        }
        public CarColor Color
        {
            get;
            set;
        }
        public string Customer
        {
            get;
        }

        private List<string> Jobs = new List<string>();

        internal Car(string plate, string model, CarColor color, string customerId, string jobId)
        {
            Id = IdGenerator.GetInstance().GetId();
            Plate = plate;
            Model = model;
            Color = color;
            Customer = customerId;
            Jobs.Add(jobId);
        }

        public List<string> getJobs()
        {
            return Jobs;
        }

        public void AddJob(string jobId)
        {
            Jobs.Add(jobId);

            // TODO: If jobId is already in list, throw exception
        }

        public void RemoveJob(string jobId)
        {
            Jobs.Remove(jobId);

            //TODO: If item is not in list, throw exception
        }
    }
}
