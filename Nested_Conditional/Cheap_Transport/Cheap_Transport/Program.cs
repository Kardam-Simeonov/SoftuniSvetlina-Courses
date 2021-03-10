using System;

namespace Cheap_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double priceTaxi = 0;
            double priceBus = 0;
            double priceTrain = 0;


            if (time == "day")
            {
                priceTaxi = 0.79;
                priceTaxi = (priceTaxi * kilometers) + 0.70;
            }
            else if (time == "night")
            {
                priceTaxi = 0.90;
                priceTaxi = (priceTaxi * kilometers) + 0.70;
            }


            if (kilometers >= 20)
            {
                priceBus = kilometers * 0.09;
            }



            if (kilometers >= 100)
            {
                priceTrain = kilometers * 0.06;
            }





            if (kilometers < 20)
                Console.WriteLine($"{priceTaxi:f2}");

            else if (kilometers >= 20 && kilometers < 100)
            {
                if (priceTaxi < priceBus)
                    Console.WriteLine($"{priceTaxi:f2}");
                else if (priceBus < priceTaxi)
                    Console.WriteLine($"{priceBus:f2}");
            }
            else if (kilometers >=100)
                Console.WriteLine($"{priceTrain:f2}");





        }
    }
}
