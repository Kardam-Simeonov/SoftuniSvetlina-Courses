using System;
using System.Net.NetworkInformation;
using System.Reflection;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            double ticketNum = double.Parse(Console.ReadLine());
            string optionalPhoto = Console.ReadLine();

            double price = 0;
            double optionalPhotoPrice = 40;

            if (stage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        price += 55.50;
                        break;
                    case "Premium":
                        price += 105.20;
                        break;
                    case "VIP":
                        price += 55.50;
                        break;
                }
            }
            else if (stage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        price += 75.88;
                        break;
                    case "Premium":
                        price += 125.22;
                        break;
                    case "VIP":
                        price += 300.40;
                        break;
                }
            }
            else if (stage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        price += 110.50;
                        break;
                    case "Premium":
                        price += 160.66;
                        break;
                    case "VIP":
                        price += 400;
                        break;
                }
            }

            price *= ticketNum;

            if (price > 4000)
            {
                optionalPhotoPrice = 0;
                price -= price / 100 * 25;
            }
            else if (price > 2500)
            {
                price -= price / 100 * 10;
            }
         
            if (optionalPhoto == "Y")
                price += optionalPhotoPrice * ticketNum;
            

            Console.WriteLine($"{price:f2}");
        }
    }
}
