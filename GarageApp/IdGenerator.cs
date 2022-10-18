using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    internal class IdGenerator
    {
        private static IdGenerator? _instance;

        internal static IdGenerator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new IdGenerator();
            }
            return _instance;
        }

        public string GetId()
        {
            string uuid = Guid.NewGuid().ToString();
            return uuid;
        }
    }
}
