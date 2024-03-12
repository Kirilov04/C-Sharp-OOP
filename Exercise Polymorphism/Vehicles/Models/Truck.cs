namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FuelConsumateModifier = 1.6;
        private const double TruckerFactor = 0.95;
        public Truck(double fuelQuantity, double fuelConsumatePerKm) 
            : base(fuelQuantity, fuelConsumatePerKm + FuelConsumateModifier)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(TruckerFactor *  fuelAmount);
        }
    }
}
