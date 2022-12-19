using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<List<Tire>> tires = new List<List<Tire>>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string[] input = Console.ReadLine().Split(",");

            while (String.Join(" ", input) != "No more tires")
            {
                List<Tire> temp = new List<Tire>();
                for (int i = 0; i < input.Length; i+= 2)
                {
                    temp.Add(new Tire(int.Parse(input[i]), double.Parse(input[i + 1])));
                }
                tires.Add(temp);
                input = Console.ReadLine().Split();
            }

            while (String.Join(" ", input) != "Engines Done")
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    engines.Add(new Engine(int.Parse(input[i]), double.Parse(input[i + 1])));
                }
                input = Console.ReadLine().Split();
            }

            while (String.Join(" ", input) != "Show special")
            {
                cars.Add(new Car(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4]), engines[int.Parse(input[5])], tires[int.Parse(input[6])].ToArray()));
            }

            foreach (var car in cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.ToList().ForEach(x => x.Pressure)
            {

            }
        }
    }
}
