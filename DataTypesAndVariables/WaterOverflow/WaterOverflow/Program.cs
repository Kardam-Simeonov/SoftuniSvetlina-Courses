using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalWater = 0;

            for (int i = 1; i <= n; i++)
            {
                int amount = int.Parse(Console.ReadLine());

                if (totalWater + amount > 255)
                    Console.WriteLine("Insufficient capacity!");
                else
                    totalWater += amount;
            }

            Console.WriteLine(totalWater);
        }
    }
}
