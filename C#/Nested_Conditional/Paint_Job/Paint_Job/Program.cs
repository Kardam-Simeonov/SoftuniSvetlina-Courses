using System;

namespace Paint_Job
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontWall = (a * a) - (2 * 1.2);
            double backWall = a * a;

            double sideWalls = 2 * ((a * b) - (1.5 * 1.5));

            double roof = 2 * (a * b);
            double roofWalls = (a * h);\

            double redPaint = (roof + roofWalls) / 4.3;
            double whitePaint = (frontWall + backWall + sideWalls) / 3.4;

            Console.WriteLine($"{whitePaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
