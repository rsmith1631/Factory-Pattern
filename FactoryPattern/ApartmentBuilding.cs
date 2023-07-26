using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ApartmentBuilding : IBluePrint
    {
        public string Stories { get; set; }
        public bool Garage { get; set; }
        public string CityArea { get; set; }

        public void Build()
        {
            ConsoleLogger.ConstructionInfo();
            Console.WriteLine("This is a great option! This 8 story building offer single level apartments with great views!");
        }
    }
}
