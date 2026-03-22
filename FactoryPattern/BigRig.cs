namespace FactoryPattern;

public class BigRig : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("This is a vehicle for transporting good across the country");
    }
}