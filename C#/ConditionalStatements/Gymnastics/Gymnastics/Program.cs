using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string equipment = Console.ReadLine();
            double grade = 0;

            if (country == "Russia")
            {
                switch (equipment)
                {
                    case "ribbon":
                        grade = 9.100 + 9.400;
                        break;
                    case "hoop":
                        grade = 9.300 + 9.800;
                        break;
                    case "rope":
                        grade = 9.600 + 9.000;
                        break;
                    default:
                        break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (equipment)
                {
                    case "ribbon":
                        grade = 9.600 + 9.400;
                        break;
                    case "hoop":
                        grade = 9.550 + 9.750;
                        break;
                    case "rope":
                        grade = 9.500 + 9.400;
                        break;
                    default:
                        break;
                }
            }
            else if (country == "Italy")
            {
                switch (equipment)
                {
                    case "ribbon":
                        grade = 9.200 + 9.500;
                        break;
                    case "hoop":
                        grade = 9.450 + 9.350;
                        break;
                    case "rope":
                        grade = 9.700 + 9.150;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"The team of {country} get {grade:f3} on {equipment}.");
            Console.WriteLine($"{((20 - grade)/ 20 * 100):f2}%");

        }
    }
}
