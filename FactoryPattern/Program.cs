namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var preferredVehicle = VehicleFactory.GetVehicle();
            preferredVehicle.Drive();
            Console.ReadLine();
        }
    }
}
