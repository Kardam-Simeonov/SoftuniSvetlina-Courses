using System;

namespace Zoo_Magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            double price_dog = 2.50;
            double price_other = 4;
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());

            double total = dogs * price_dog + others * price_other;
            Console.WriteLine($"{total:f2} lv");



        }
    }
}
