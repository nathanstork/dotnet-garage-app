using GarageApp.Contracts;
using GarageApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    [Serializable]
    public class Employees
    {
        private string Data_Filename = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/users.bin";

        private static Employees? _instance;

        public dynamic CurrentUser;

        private List<Mechanic> mechanics = new List<Mechanic>();
        private List<Manager> managers = new List<Manager>();

        private Employees()
        {
            // Example users
            /*mechanics.Add(new Mechanic("hrooij", "12345", "Hans de Rooij", "Mallelaan 52 Eindhoven", new MontlyContract(2000, 32)));
            mechanics.Add(new Mechanic("mvloon", "password", "Michiel van Loon", "Eriksenstraat 11 Geldrop", new WeeklyContract(500, 8)));
            mechanics.Add(new Mechanic("berta", "arend", "Bert Arend", "Kadettenplein 733 Veldhoven", new MontlyContract(2100, 36)));

            managers.Add(new Manager("admin", "password", "Admin", "unknown", mechanics));*/

            // Get mechanics and managers form local file
            if (File.Exists(Data_Filename))
            {
                ValueTuple<List<Mechanic>, List<Manager>> data = LoadData();
                mechanics = data.Item1;
                managers = data.Item2;
            } else
            {
                // TODO: Throw warning window
            }

            // TODO: Save data to file before application is closed
        }

        internal static Employees GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Employees();
            }
            return _instance;
        }

        public void Login(string user, string pass)
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

            if (CurrentUser == null) throw new Exception("Incorrect credentials. Please try again.");
        }

        private ValueTuple<List<Mechanic>, List<Manager>> LoadData()
        {
            // BinaryFormatter is obsolete: https://aka.ms/binaryformatter
            using (Stream stream = File.Open(Data_Filename, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (ValueTuple<List<Mechanic>, List<Manager>>) binaryFormatter.Deserialize(stream);
            }
        }

        public void SaveData()
        {
            using (Stream stream = File.Open(Data_Filename, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, (mechanics, managers));
            }
        }
    }
}
