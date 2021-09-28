using System;
using System.Collections.Generic;

namespace OrdersDICTIONARYSTYLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = Int32.Parse(Console.ReadLine());

            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            productsPrice.Add("coffee", 1.50);
            productsPrice.Add("water", 1.00);
            productsPrice.Add("coke", 1.40);
            productsPrice.Add("snacks", 2.00);

            Console.WriteLine($"{CalculateFinalPrice(productsPrice, product, quantity):f2}");
        }

        private static double CalculateFinalPrice(Dictionary<string, double> productsPrice,
                                                  string productName,
                                                  int amount)
        {
            return productsPrice[productName] * amount;
        }
    }
}
