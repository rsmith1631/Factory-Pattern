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

        }
    }
}
