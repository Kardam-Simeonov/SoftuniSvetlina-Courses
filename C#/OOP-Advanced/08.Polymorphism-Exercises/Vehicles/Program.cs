using System;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Car car = new Car(double.Parse(input[1]), double.Parse(input[2]));

            input = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(input[1]), double.Parse(input[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "Drive":
                        if (input[1] == "Car")
                            car.Drive(double.Parse(input[2]));
                        else if (input[1] == "Truck")
                            truck.Drive(double.Parse(input[2]));
                        break;
                    case "Refuel":
                        if (input[1] == "Car")
                            car.Refuel(double.Parse(input[2]));
                        else if (input[1] == "Truck")
                            truck.Refuel(double.Parse(input[2]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
