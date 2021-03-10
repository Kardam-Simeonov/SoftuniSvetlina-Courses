using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string firstUnit = Console.ReadLine().ToLower();
            string secondUnit = Console.ReadLine().ToLower();

            if (firstUnit == "km")
            {
                num = num / 0.001;
            }
            else if (firstUnit == "cm")
            {
                num = num / 100;
            }
            else if (firstUnit == "mm")
            {
                num = num / 1000;
            }
            else if (firstUnit == "mi")
            {
                num = num / 0.000621371192;
            }
            else if (firstUnit == "in")
            {
                num = num / 39.3700787;
            }
            else if (firstUnit == "ft")
            {
                num = num / 3.2808399;
            }
            else if (firstUnit == "yd")
            {
                num = num / 1.0936133;
            }

            if (secondUnit == "km")
            {
                num = num * 0.001;
            }
            else if (secondUnit == "cm")
            {
                num = num * 100;
            }
            else if (secondUnit == "mm")
            {
                num = num * 1000;
            }
            else if (secondUnit == "mi")
            {
                num = num * 0.000621371192;
            }
            else if (secondUnit == "in")
            {
                num = num * 39.3700787;
            }
            else if (secondUnit == "ft")
            {
                num = num * 3.2808399;
            }
            else if (secondUnit == "yd")
            {
                num = num * 1.0936133;
            }
            Console.WriteLine($"{num:f8}");




        }
    }
}
