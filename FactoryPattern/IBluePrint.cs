using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IBluePrint
    {
        public string Stories { get; set; }
        public bool Garage { get; set; }
        public string CityArea { get; set; }
        public void Build();

    }
}
