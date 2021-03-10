using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double highestVolume = double.MinValue;
            string highestModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * (double)height;

                if (volume > highestVolume)
                {
                    highestVolume = volume;
                    highestModel = model;
                }
            }

            Console.WriteLine(highestModel);
        }
    }
}
