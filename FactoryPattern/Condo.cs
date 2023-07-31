using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Condo : IBluePrint
    {
        public string Stories { get; set; } = "3";
        public bool Garage { get; set; } = true;
        public string CityArea { get; set; } = "Glendale";

        public void Build()
        {
            ConsoleLogger.ConstructionInfo();

            Console.WriteLine("You chose the condo option! Our condos has amazing space with 3 levels. This is a great choice!");
        }
    }
}
