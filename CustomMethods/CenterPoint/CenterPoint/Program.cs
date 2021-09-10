using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }

        static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            //double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            //double secondPoint = Math.Abs(x2) + Math.Abs(y2);

            if (firstPoint < secondPoint)
                Console.WriteLine($"({x1}, {y1})");
            
            else 
                Console.WriteLine($"({x2}, {y2})");

        }
    }
}
