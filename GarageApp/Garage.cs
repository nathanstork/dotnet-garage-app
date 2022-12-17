namespace GarageApp
{
    [Serializable]
    internal class Garage
    {
        private static Garage? _instance;

        internal List<Job> Jobs = new List<Job>();

        private Garage()
        {
            // Example jobs
            /*Jobs.Add(new Job(
                "Test description",
                "23/11/2022",
                300,
                new Car("EB-HO-23", "Golf", "Volkswagen", CarColor.Grey),
                new Customer("Tom van Ack", "Frieschestraat 31 Helmond", "tvack@hotmail.nl", "+31 0679035561")
            ));
            Jobs.Add(new Job(
                "Test description 2",
                "24/11/2022",
                450,
                new Car("01-BHK-4", "Polo", "Volkswagen", CarColor.Navy),
                new Customer("Pim de Jonge", "Gamerstraat 4 Valkenswaard", "pdejonge@gmail.nl", "+31 0636851288")
            ));
            Jobs.Add(new Job(
                "Test description 3",
                "25/11/2022",
                125,
                new Car("8-DJZ-49", "A7", "Audi", CarColor.Black),
                new Customer("Luke Cornelissen", "Emmasingel 11 Eindhoven", "email@gmail.be", "+31 0623775123")
            ));*/
        }

        internal static Garage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Garage();
            }
            return _instance;
        }
    }
}
