using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PropertyFactory
    {
        public static IBluePrint PropertyType(int levelCount)
        {
            switch (levelCount)
            {
                case 1:
                    return new ApartmentBuilding();
                case 2:
                    return new House();
                case 3:
                    return new Condo();
                default:
                    return new ApartmentBuilding();
            }
        }
    }
}
