using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class House : IBluePrint
    {
        public string Stories { get; set; } = "2";
        public bool Garage { get; set; } = true;
        public string CityArea { get; set; } = "Los Feliz";

        public void Build()
        {
            ConsoleLogger.ConstructionInfo();

            Console.WriteLine("Perfect choice! You chose a home. Our homes are 2 levels with great sq footage!");
        }
    }
}
