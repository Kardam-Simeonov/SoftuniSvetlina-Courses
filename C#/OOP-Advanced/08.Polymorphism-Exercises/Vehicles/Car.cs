using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += 0.9;
        }

        public override bool Drive(double distance)
        {
            if (!base.Drive(distance))
            {
                Console.WriteLine("Car needs refueling");
                return false;
            }

            Console.WriteLine($"Car travelled {distance} km");
            return true;
        }
    }
}
