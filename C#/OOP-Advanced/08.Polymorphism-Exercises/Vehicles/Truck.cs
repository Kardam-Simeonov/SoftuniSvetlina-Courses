using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += 1.6;
        }

        public override bool Drive(double distance)
        {
            if (!base.Drive(distance))
            {
                Console.WriteLine("Truck needs refueling");
                return false;
            }

            Console.WriteLine($"Truck travelled {distance} km");
            return true;
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * 0.95);
        }
    }
}
