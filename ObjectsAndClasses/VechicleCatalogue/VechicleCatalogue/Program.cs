using System;
using System.Collections.Generic;
using System.Linq;

namespace VechicleCatalogue
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                    break;

                Vehicle userVehicle = new Vehicle(input[0], input[1], input[2], int.Parse(input[3]));
                catalogue.Add(userVehicle);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close The Catalogue")
                    break;

                foreach (var vehicle in catalogue.Where(x => x.Model == input))
                {
                    Console.WriteLine($"Type = {vehicle.Type}\nModel = {vehicle.Model}\nColor = {vehicle.Color}\nHorsePower = {vehicle.HorsePower}");
                }

                //catalogue.Where(x => x.Model == input).ToList().ForEach(x => Console.WriteLine($"Type = {x.Type}\nModel = {x.Model}\nColor = {x.Color}\nHorsePower = {x.HorsePower}"));
            }

            double carSum = 0;
            catalogue.Where(x => x.Type == "car").ToList().ForEach(x => carSum += x.HorsePower);
            double averageCarHorsePower = carSum / catalogue.Where(x => x.Type == "car").Count();

            double truckSum = 0;
            catalogue.Where(x => x.Type == "truck").ToList().ForEach(x => truckSum += x.HorsePower);
            double averageTruckHorsePower = truckSum / catalogue.Where(x => x.Type == "truck").Count();

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:F2}.");
        }
    }
}
