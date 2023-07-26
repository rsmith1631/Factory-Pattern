using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class House : IBluePrint
    {
        public string Stories { get; set; }
        public bool Garage { get; set; }
        public string CityArea { get; set; }

        public void Build()
        {
            Console.WriteLine("Perfect choice! You chose a home. Our homes our 2 levels with great sq footage!");
        }
    }
}
