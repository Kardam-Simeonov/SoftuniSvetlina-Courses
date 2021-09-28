using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
