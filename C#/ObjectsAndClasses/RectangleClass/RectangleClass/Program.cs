using System;

namespace RectangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();

            Rectangle rect = new Rectangle(width, height, color);

            Console.WriteLine($"Rect({width}, {height}, {color}) has area {rect.CalculateArea(width, height)}.");
        }
    }

}
