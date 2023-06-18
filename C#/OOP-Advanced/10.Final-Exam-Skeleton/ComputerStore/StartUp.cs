using ComputerStore.InterfacesAndClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerStore
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var laptops = new List<Laptop>();
                var input = Console.ReadLine();

                while (input != "Buy")
                {
                    string[] inputParts = input.Split();
                    string command = inputParts[0];

                    if (command == "AddLaptop")
                    {
                        var laptopType = inputParts[1];
                        int id = int.Parse(inputParts[2]);
                        string model = inputParts[3];
                        decimal price = decimal.Parse(inputParts[4]);

                        if (laptopType == "TraditionalLaptop")
                        {
                            laptops.Add(new TraditionalLaptop(id, model, price));
                        }
                        else if (laptopType == "HybridLaptop")
                        {
                            laptops.Add(new HybridLaptop(id, model, price));
                        }
                    }
                    else if (command == "AddHardware")
                    {
                        int laptopId = int.Parse(inputParts[1]);
                        int laptopIndex = laptops.FindIndex(l => l.Id == laptopId);

                        if (laptopIndex != -1)
                        {
                            int hardwarePartId = int.Parse(inputParts[2]);
                            string model = inputParts[3];
                            decimal price = decimal.Parse(inputParts[4]);
                            double overallPerformance = double.Parse(inputParts[5]);
                            int generation = int.Parse(inputParts[6]);

                            laptops[laptopIndex].AddHardware(new Hardware(hardwarePartId, model, price, overallPerformance, generation));
                        }
                    }

                    input = Console.ReadLine();
                }

                foreach (var laptop in laptops)
                {
                    Console.WriteLine(laptop);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
