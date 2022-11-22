using GarageApp.Users;
using System.Runtime.Serialization.Formatters.Binary;

namespace GarageApp
{
    [Serializable]
    public class Employees
    {
        private static Employees? _instance;

        public dynamic CurrentUser;

        private List<Mechanic> mechanics = new List<Mechanic>();
        private List<Manager> managers = new List<Manager>();

        private readonly string dataFileName = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/users.bin";

        private Employees()
        {
            // Get mechanics and managers form local file, if it exists
            if (File.Exists(dataFileName))
            {
                ValueTuple<List<Mechanic>, List<Manager>> data = LoadData();
                mechanics = data.Item1;
                managers = data.Item2;
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

        internal void Login(string user, string pass)
        {
            if (user == null || user == "")
            {
                throw new Exception("Invalid username");
            }
            if (pass == null || pass == "")
            {
                throw new Exception("Invalid password");
            }

            mechanics.ForEach(mechanic =>
            {
                if (mechanic.Username == user && mechanic.Password == pass)
                {
                    CurrentUser = mechanic as Mechanic;
                }
            });

            managers.ForEach(manager =>
            {
                if (manager.Username == user && manager.Password == pass)
                {
                    CurrentUser = manager as Manager;
                }
            });

            // Admin credentials
            if (user == "admin" & pass == "password")
            {
                CurrentUser = new Manager(user, pass, "Admin", "Unknown", mechanics);
            }

            if (CurrentUser == null) throw new Exception("Incorrect credentials. Please try again.");
        }

        // BinaryFormatter is obsolete: https://aka.ms/binaryformatter
        private ValueTuple<List<Mechanic>, List<Manager>> LoadData()
        {
            using (Stream stream = File.Open(dataFileName, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (ValueTuple<List<Mechanic>, List<Manager>>) binaryFormatter.Deserialize(stream);
            }
        }

        // BinaryFormatter is obsolete: https://aka.ms/binaryformatter
        internal void SaveData()
        {
            Console.WriteLine("Saving data...");
            using (Stream stream = File.Open(dataFileName, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, (mechanics, managers));
            }
            Console.WriteLine("Done! Bye now.");
        }
    }
}
