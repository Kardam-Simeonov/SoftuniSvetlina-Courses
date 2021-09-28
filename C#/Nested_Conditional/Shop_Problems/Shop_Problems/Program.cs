using System;

namespace Shop_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableKilo = double.Parse(Console.ReadLine());
            double fruitKilo = double.Parse(Console.ReadLine());

            double totalVegetable = vegetablePrice * vegetableKilo;
            double totalFruit = fruitPrice * fruitKilo;

            double total = (totalVegetable / 1.94) + (totalFruit / 1.94);

            Console.WriteLine($"{total:f2}");
        }
    }
}
