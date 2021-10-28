using System;

namespace Crops
{
    class Program
    {
        static void Main(string[] args)
        {
            double gardenSpace = double.Parse(Console.ReadLine());
            double grapesPermeter = double.Parse(Console.ReadLine());
            double neededLitres = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double grapesKilo = grapesPermeter * (gardenSpace * 0.40);
            double litres = grapesKilo / 2.5;

            if (litres > neededLitres)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litres)} liters.");
                Console.WriteLine($"{Math.Ceiling(litres - neededLitres)} liters left -> {Math.Ceiling((litres - neededLitres)/workers)} liters per person.");
            }
            else if (litres < neededLitres)
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitres - litres)} liters wine needed.");
        }
    }
}
