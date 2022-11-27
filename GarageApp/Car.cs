namespace GarageApp
{
    internal enum CarColor
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

    [Serializable]
    internal class Car
    {
        internal string Plate
        {
            get;
        }
        internal string Brand
        {
            get;
        }
        internal string Model
        {
            get;
        }
        internal CarColor Color
        {
            get;
        }

        internal Car(string plate, string model, string brand, CarColor color)
        {
            Plate = plate;
            Model = model;
            Brand = brand;
            Color = color;
        }
    }
}
