using System;
using System.Linq.Expressions;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculatePrice(product, quantity).ToString("f2"));
        }

        static double CalculatePrice(string product, int quantity)
        {

            switch (product)
            {
                case "coffee": return quantity * 1.50; 
                case "water": return quantity * 1.00;
                case "coke": return quantity * 1.40;
                case "snacks": return quantity * 2.00;
                default: return 0;
            }

    
        }
    }
}