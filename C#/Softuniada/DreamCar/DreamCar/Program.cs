using System;

namespace DreamCar
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            double savings = 0;

            for (int i = 1; i <= t; i++)
            {
                savings += n;
                n += x;
            }

            if (savings - m * t >= y)
                Console.WriteLine("Have a nice ride!");
            else
                Console.WriteLine("Work harder!");
        }
    }
}
