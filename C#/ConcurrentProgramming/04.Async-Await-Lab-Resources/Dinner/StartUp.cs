using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Dinner
{
    class StartUp
    {
        static void Main()
        {
            Meat meat = GrillMeatAsync();
            Vegetables vegetables = GrillVegetablesAsync();

            MakeFruitSalad();
        }
        private static Meat GrillMeatAsync()
        {
           // Make the GrillMeatAsync() method work asynchronously
            Console.WriteLine($"Putting the meat on the grill.");
            Task.Delay(3000);
            Console.WriteLine($"Flipping the meat.");
            Task.Delay(3000);
            Console.WriteLine("The meat is ready.");
            return new Meat();
        }
        private static Vegetables GrillVegetablesAsync()
        {
            // Make the GrillVegetablesAsync() method work asynchronously
            Console.WriteLine($"Putting the vegetables on the grill.");
            Task.Delay(1500);
            Console.WriteLine($"Flipping the vegetables.");
            Task.Delay(1500);
            Console.WriteLine("The vegetables are ready.");
            return new Vegetables();
        }
        private static FruitSalad MakeFruitSalad()
        {
            Console.WriteLine($"Fruit cutting.");
            Thread.Sleep(500);
            Console.WriteLine($"Mixing the fruit and adding yogurt.");
            Thread.Sleep(100);
            Console.WriteLine($"Crushing and adding nuts.");
            Thread.Sleep(200);
            Console.WriteLine($"Adding honey.");
            Thread.Sleep(50);
            return new FruitSalad();
        }

    }
}
