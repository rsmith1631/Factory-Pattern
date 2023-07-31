using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ApartmentBuilding : IBluePrint
    {
        public string Stories { get; set; } = "8";
        public bool Garage { get; set; } = true;
        public string CityArea { get; set; } = "Downtown";

        public void Build()
        {
            ConsoleLogger.ConstructionInfo();
            Console.WriteLine("This is a great option! This 8 story building offer single level apartments with great views!");
        }
    }
}
