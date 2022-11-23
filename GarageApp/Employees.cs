using GarageApp.Contracts;
using GarageApp.Users;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GarageApp
{
    [Serializable]
    public class Employees
    {
        private static Employees? _instance;

        public dynamic? CurrentUser;

        private List<Mechanic> Mechanics = new List<Mechanic>();
        private List<Manager> Managers = new List<Manager>();

        private readonly string SaveFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/save.bin";

        private Employees()
        {
            // Get mechanics and managers form local file, if it exists
            if (File.Exists(SaveFilePath))
            {
                ValueTuple<List<Mechanic>, List<Manager>> data = LoadData();
                Mechanics = data.Item1;
                Managers = data.Item2;
                Console.WriteLine(data.Item1[0].Garage.GetJobs());
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

            // Admin credentials
            if (user == "admin" & pass == "password")
            {
                CurrentUser = new Manager(user, pass, "Admin", "Unknown", Mechanics);
            }

            if (CurrentUser == null) throw new Exception("Incorrect credentials. Please try again.");
        }

        internal void LogOut()
        {
            CurrentUser = null;
        }

        // BinaryFormatter is obsolete: https://aka.ms/binaryformatter
        private ValueTuple<List<Mechanic>, List<Manager>> LoadData()
        {
            using (Stream stream = File.Open(SaveFilePath, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (ValueTuple<List<Mechanic>, List<Manager>>) binaryFormatter.Deserialize(stream);
            }
        }

        // BinaryFormatter is obsolete: https://aka.ms/binaryformatter
        internal void SaveData()
        {
            Console.WriteLine("Saving data...");
            using (Stream stream = File.Open(SaveFilePath, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, (Mechanics, Managers));
            }
            Console.WriteLine("Done! Bye now.");
        }
    }
}
