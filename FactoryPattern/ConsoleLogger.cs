using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void ConstructionInfo()
        {
            Console.WriteLine("Run your credit check.");
            Thread.Sleep(1000);
            Console.WriteLine("Submit your application!");
            Thread.Sleep(1000);
        }
    }
}
