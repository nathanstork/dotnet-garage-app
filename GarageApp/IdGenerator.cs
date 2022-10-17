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

        private List<int> generatedIds = new List<int>();

        private IdGenerator()
        {
            // TODO: Get generated id's from save files
        }

        internal static IdGenerator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new IdGenerator();
            }
            return _instance;
        }

        public int GetId()
        {
            Random random = new Random();

            int countLength = generatedIds.Count.ToString().Length;
            if (countLength < 4)
            {
                countLength = 4;
            }
            int min = int.Parse("1" + new string('0', countLength - 1));
            int max = int.Parse("1" + new string('0', countLength));

            while (true)
            {
                int attempt = random.Next(min, max);
                if (!generatedIds.Contains(attempt))
                {
                    generatedIds.Add(attempt);
                    return attempt;
                }
            }
        }
    }
}
