using System;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());

                double area = a * a;

                Console.WriteLine($"{area:F3}");

            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double area = a * b;

                Console.WriteLine($"{area:F3}");

            }
            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double area = (a * h) / 2;

                Console.WriteLine($"{area:F3}");

            }
            else if (type == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                

                double area = (r * r) * Math.PI;

                Console.WriteLine($"{area:F3}");

            }


        }
    }
}
