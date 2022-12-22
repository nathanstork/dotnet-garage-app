using GarageApp.Contracts;
using GarageApp.Users;
using System.Runtime.Serialization.Formatters.Binary;

namespace GarageApp
{
    [Serializable]
    public class Employees
    {
        private static Employees? _instance;

        internal dynamic? CurrentUser;

        internal List<Mechanic> Mechanics = new List<Mechanic>();
        internal List<Manager> Managers = new List<Manager>();

        internal readonly string SaveFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/data.bin";

        private Employees()
        {
            // Example users
            /*Mechanics.Add(new Mechanic("hrooij", "12345", "Hans de Rooij", "Mallelaan 52 Eindhoven", new MonthlyContract(2000, 32)));
            Mechanics.Add(new Mechanic("mvloon", "password", "Michiel van Loon", "Eriksenstraat 11 Valkenswaard", new WeeklyContract(500, 8)));
            Mechanics.Add(new Mechanic("berta", "arend", "Bert Arend", "Kadettenplein 733 Veldhoven", new MonthlyContract(2100, 36)));

            Managers.Add(new Manager("nicholas", "pass67", "Nicholas Brecht", "Utrechtseweg 6 Son en Breugel", new MonthlyContract(3200, 40), Mechanics));*/

            // Get mechanics and managers form local file, if it exists
            if (File.Exists(SaveFilePath))
            {
                ValueTuple<List<Mechanic>, List<Manager>> data = LoadData();
                Mechanics = data.Item1;
                Managers = data.Item2;
            }
            else
            {
                // Always add admin user
                Managers.Add(new Manager("admin", "password", "Admin", "Unknown", new MonthlyContract(0, 0) , Mechanics));
            }
        }

        internal static Employees GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Employees();
            }
            return _instance;
        }

        internal void LogIn(string user, string pass)
        {
            if (user == null || user == "")
            {
                throw new Exception("Invalid username");
            }
            if (pass == null || pass == "")
            {
                throw new Exception("Invalid password");
            }

            Mechanics.ForEach(mechanic =>
            {
                if (mechanic.Username == user && mechanic.Password == pass)
                {
                    CurrentUser = mechanic as Mechanic;
                }
            });

            Managers.ForEach(manager =>
            {
                if (manager.Username == user && manager.Password == pass)
                {
                    CurrentUser = manager as Manager;
                }
            });

            if (CurrentUser == null) throw new Exception("Incorrect credentials. Please try again.");
        }

        internal void LogOut()
        {
            CurrentUser = null;
            SaveData();
        }

        private ValueTuple<List<Mechanic>, List<Manager>> LoadData()
        {
            using (Stream stream = File.Open(SaveFilePath, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (ValueTuple<List<Mechanic>, List<Manager>>) binaryFormatter.Deserialize(stream);
            }
        }

        internal void SaveData()
        {
            using (Stream stream = File.Open(SaveFilePath, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, (Mechanics, Managers));
            }
        }
    }
}
