using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            HashSet<string> parkedCars = new HashSet<string>();

            while (input != "END")
            {
                string[] command = input.Split(", ");
                if (command[0] == "IN")
                    parkedCars.Add(command[1]);
                else
                    parkedCars.Remove(command[1]);

                input = Console.ReadLine();
            }

            if (parkedCars.Count == 0)
                Console.WriteLine("Parking Lot is Empty");
            else
                foreach (string car in parkedCars)
                    Console.WriteLine(car);
        }
    }
}
