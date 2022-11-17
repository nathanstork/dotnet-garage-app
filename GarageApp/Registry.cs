using GarageApp.Contracts;
using GarageApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{

    internal class Registry
    {
        private static Registry? _instance;

        private List<Mechanic> mechanics = new List<Mechanic>();
        private List<Manager> managers = new List<Manager>();

        private Registry()
        {
            /*mechanics.Add(new Mechanic("Hans de Rooij", "Mallelaan 52 Eindhoven", new MontlyContract(2000, 32)));
            mechanics.Add(new Mechanic("Michiel van Loon", "Eriksenstraat 11 Geldrop", new WeeklyContract(500, 8)));
            mechanics.Add(new Mechanic("Bert Arend", "Kadettenplein 733 Veldhoven", new MontlyContract(2100, 36)));

            managers.Add(new Manager("Admin", "", "admin", "password"));*/

            // TODO: Get mechanics and managers form local file
        }

        internal static Registry GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Registry();
            }
            return _instance;
        }

        internal List<Mechanic> GetMechanics()
        {
            return mechanics;
        }

        internal List<Manager> GetManagers()
        {
            return managers;
        }

        internal void HireMechanic(Mechanic mechanic)
        {
            mechanics.Add(mechanic);
        }

        internal void FireMechanic(string id)
        {
           /* Mechanic user = mechanics.FirstOrDefault(mechanic => mechanic.Id == id);
            if (user != null)
            {
                mechanics.Remove(user);
            }*/
        }
    }
}
