using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double cupSide = double.Parse(Console.ReadLine());

            double area = (lenght * 100) * (width * 100);
            double cupArea = (cupSide * 100) * (cupSide * 100);
            double benchArea = area / 10;

            double totalArea = area - (cupArea + benchArea);

            double totalDancers = totalArea / 7040;

            Console.WriteLine(Math.Floor(totalDancers));



        }
    }
}
