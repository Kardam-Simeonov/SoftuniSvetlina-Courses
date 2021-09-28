using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                    break;
                
                int quantity = int.Parse(Console.ReadLine());

                if (resourceQuantity.ContainsKey(resource))
                    resourceQuantity[resource] += quantity;
                else
                    resourceQuantity.Add(resource, quantity);
            }

            foreach (var resource in resourceQuantity)
                Console.WriteLine($"{resource.Key} -> {resource.Value}");

            
        }
    }
}
