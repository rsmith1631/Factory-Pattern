using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            Console.Write("Enter the amount of tires for your preferred vehicle: ");
            var userTires = Console.ReadLine();
            
            switch (userTires)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
