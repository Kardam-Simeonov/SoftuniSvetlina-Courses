using System;

namespace Ozeleniavane
{
    class Program
    {
        static void Main(string[] args)
        {
            int squares = int.Parse(Console.ReadLine());
            double price = squares * 7.61;
            double discount = price * 0.18;
            double final_price = price - discount;

            Console.WriteLine($"The final price is: {final_price:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");

        }

    }
}
