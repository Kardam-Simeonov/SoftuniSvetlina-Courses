using System;
using System.Collections.Generic;
using System.Linq;

namespace Formula1Drivers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drivers = new List<Driver>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                drivers.Add(new Driver(input[0] + " " + input[1], int.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4]))); 
            }

            var bestDriver = drivers.OrderBy(d => d.TotalTime).FirstOrDefault();
            Console.WriteLine($"DriverName: {bestDriver.Name}");
            Console.WriteLine($"  DriverAge: {bestDriver.Age}");
            Console.WriteLine($"    Time: {bestDriver.TotalTime}");
            Console.WriteLine($"    Speed: {bestDriver.Speed}");
        }
    }
}
