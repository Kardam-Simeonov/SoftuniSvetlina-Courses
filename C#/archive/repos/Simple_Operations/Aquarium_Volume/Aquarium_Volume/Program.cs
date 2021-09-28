using System;

namespace Aquarium_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int Volume = height * lenght * width;
            double Decimeters = Volume * 0.001;
            double Attributes = percent * 0.01;
            double result = Decimeters * (1 - Attributes);

            Console.WriteLine($"{result:f3}");




        }
    }
}
