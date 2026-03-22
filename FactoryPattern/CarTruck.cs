namespace FactoryPattern;

public class CarTruck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("This is a passenger vehicle.");
    }
}