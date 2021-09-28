using System;
using System.Collections.Generic;
using System.Linq;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "buy")
            {
                string productName = input[0];
                double price = double.Parse(input[1]);
                int cap = int.Parse(input[2]);

                if (products.ContainsKey(productName))
                {
                    double currentPrice = products[productName].First().Key;
                    int currentCap = products[productName][price];

                    products[productName].Remove(currentPrice);
                    products[productName].Add(price, currentCap + cap);
                }

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new Dictionary<double, int>());
                }

                if (!products[productName].ContainsKey(price))
                {
                    products[productName].Add(price, 0);
                }

                products[productName][price] += cap;


                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Key} {product.Value.First().Key * product.Value.First().Value}");
                }
            }
        }
    }
}
