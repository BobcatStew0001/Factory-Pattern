namespace FactoryPattern;

public interface VehicleFactory
{
    public static IVehicle BuildVehicle(int vehicleType)
    {
        switch (vehicleType)
        {
            case 4:
                return new CarTruck(); 
            case 2:
                return new Motorcycle(); 
            case >= 18:
                return new BigRig(); 
            default:
                return new CarTruck(); 
        }
    }
}