using System.Collections;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int levelCount;
            bool userInput = false;
            do
            {
                Console.WriteLine("How many floors are you looking for in regards to your living space?");

                userInput = int.TryParse(Console.ReadLine(), out levelCount);
            } while (userInput == false);

            var property = PropertyFactory.PropertyType(levelCount);
            property.Build();
            Console.WriteLine();
            Console.WriteLine();

            var house = new House();
          
            
            var condo = new Condo();
            

            var apartments = new ApartmentBuilding();
         


            var blueprints = new IEnumerable[] { $"{house}, {condo}, {apartments}" };


            foreach ( var blueprint in blueprints )
            {
                Console.Write("Home community opening date: ");
                Console.WriteLine("Our home community will open October 2023.");
                Console.WriteLine("");
                Console.Write("Condos opening date: ");
                Console.WriteLine("Construction with this site beginned May 2023. Estimated available dates are for June 2024.");
                Console.WriteLine("");
                Console.Write("Apartment complex opening date: ");
                Console.WriteLine("Our amazing apartment building will open early 2025.");
                Console.WriteLine(""); 

            
            }
        }
    }
}
