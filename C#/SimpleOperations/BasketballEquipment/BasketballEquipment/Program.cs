using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearTax = double.Parse(Console.ReadLine());

            double basketballSneakers = yearTax - (yearTax / 100) * 40;
            double basketballUniform = basketballSneakers - (basketballSneakers / 100) * 20;
            double basketballBall = basketballUniform * 1 / 4;
            double basketballAccessories = basketballBall * 1 / 5;

            double tax = yearTax + basketballSneakers + basketballUniform + basketballBall + basketballAccessories;
            Console.WriteLine($"{tax:f2}");


        }
    }
}
