using System.Collections;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var house = new House();
            house.Garage = true;
            house.CityArea = "Los Feliz";
            house.Stories = "Most homes are 2 stories!";
            Console.WriteLine($"Will there be a garage?: {house.Garage}");
            Console.WriteLine($"Community location: {house.CityArea}");
            Console.WriteLine($"How many floors do these homes have?: {house.Stories}");
            Console.WriteLine("-------------------------------------------------");

            var condo = new Condo();
            condo.Garage = true;
            condo.CityArea = "Glendale";
            condo.Stories = "All of our condos are 3 stories!";
            Console.WriteLine($"Will there be a garage?: {condo.Garage}");
            Console.WriteLine($"Community location: {condo.CityArea}");
            Console.WriteLine($"How many floors will these condos have?: {condo.Stories}");
            Console.WriteLine("-------------------------------------------------");

            var apartments = new ApartmentBuilding();
            apartments.Garage = true;
            apartments.CityArea = "Downtown";
            apartments.Stories = "This apartment complex will be 8 stories!";
            Console.WriteLine($"Will each unit have a garage space to rent?: {apartments.Garage}");
            Console.WriteLine($"Community location: {apartments.CityArea}");
            Console.WriteLine($"How many stories will this building have?: {apartments.Stories}");
            Console.WriteLine("-------------------------------------------------");

            var blueprints = new IEnumerable[] { $"{house}, {condo}, {apartments}" };


            foreach ( var blueprint in blueprints )
            {
                Console.Write("Home community opening date: ");
                house.Build();
                Console.Write("Condos opening date: ");
                condo.Build();
                Console.Write("Apartment complex opening date: ");
                apartments.Build();
                Console.WriteLine("");
            }
        }
    }
}
