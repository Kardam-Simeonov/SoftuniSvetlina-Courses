using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> foodShops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "Revision")
            {
                string shopName = input[0];
                string productName = input[1];
                double productPrice = double.Parse(input[2]);

                if (foodShops.ContainsKey(shopName))
                    foodShops[shopName].Add(productName, productPrice);
                else
                    foodShops.Add(shopName, new Dictionary<string, double> { { productName, productPrice } });

                input = Console.ReadLine().Split(", ");
            }

            foreach (var shop in foodShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:f1}");
            }

        }
    }
}
