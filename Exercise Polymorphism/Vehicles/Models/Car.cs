namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double FuelConsumateModifier = 0.9;
        public Car(double fuelQuantity, double fuelConsumatePerKm) 
            : base(fuelQuantity, fuelConsumatePerKm + fuelConsumatePerKm)
        {

        }
    }
}
