using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuel
    {
        private double _fuelQuantity;
        private double _fuelConsumatePerKm;

        public Vehicle(double fuelQuantity, double fuelConsumatePerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumatePerKm = fuelConsumatePerKm;
        }

        public double FuelConsumatePerKm
        {
            get => _fuelConsumatePerKm;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Comsunption must be positive number ");
                }
                _fuelConsumatePerKm = value;
            }
        }
        public double FuelQuantity
        {
            get => _fuelQuantity;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be positive number ");
                }
                _fuelQuantity = value;
            }

        }

        public void Drive(double distance)
        {
            var totalConsumateOnTravel = distance * FuelConsumatePerKm;

            if (totalConsumateOnTravel > FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} need refueling");
            }
            FuelQuantity -= totalConsumateOnTravel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            FuelQuantity += fuelAmount;
        }
    }
}
