namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            var vehicleType = Console.ReadLine();
            int NumberOfTires = int.Parse(vehicleType);
            var vehicle = VehicleFactory.BuildVehicle(NumberOfTires); 
            
            vehicle.Drive();
        }
    }
}
