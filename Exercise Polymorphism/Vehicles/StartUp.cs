﻿using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            var carData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carData[1]),
                double.Parse(carData[2]));

            var truckData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

            int command = int.Parse(Console.ReadLine());
            for (int i = 0; i < command; i++)
            {
                try
                {
                    var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (data[0] == "Drive")
                    {
                        switch (data[1])
                        {
                            case "Car":
                                car.Drive(double.Parse(data[2]));
                                break;
                            case "Truck":
                                truck.Drive(double.Parse(data[2]));
                                break;
                        }
                    }
                    else if (data[0] == "Refuel")
                    {
                        switch (data[1])
                        {
                            case "Car":
                                car.Refuel(double.Parse(data[2]));
                                break;
                            case "Truck":
                                truck.Refuel(double.Parse(data[2]));
                                break;
                        }
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
