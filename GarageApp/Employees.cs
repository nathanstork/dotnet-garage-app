using GarageApp.Contracts;
using GarageApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    internal class Employees
    {
        private static Employees? _instance;

        public User CurrentUser;

        private List<Mechanic> mechanics = new List<Mechanic>();
        private List<Manager> managers = new List<Manager>();

        private Employees()
        {
            // TEST USERS
            mechanics.Add(new Mechanic("hrooij", "12345", "Hans de Rooij", "Mallelaan 52 Eindhoven", new MontlyContract(2000, 32)));
            mechanics.Add(new Mechanic("mvloon", "password", "Michiel van Loon", "Eriksenstraat 11 Geldrop", new WeeklyContract(500, 8)));
            mechanics.Add(new Mechanic("berta", "arend", "Bert Arend", "Kadettenplein 733 Veldhoven", new MontlyContract(2100, 36)));

            managers.Add(new Manager("admin", "password", "Admin", "unknown"));

            // TODO: Get mechanics and managers form local file
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
                    CurrentUser = mechanic;
                }
            });

            managers.ForEach(manager =>
            {
                if (manager.Username == user && manager.Password == pass)
                {
                    CurrentUser = manager;
                }
            });

            if (CurrentUser == null) throw new Exception("Incorrect credentials. Please try again.");
        }
    }
}
