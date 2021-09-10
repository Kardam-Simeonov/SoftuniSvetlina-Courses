using System;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double racketpairPrice = double.Parse(Console.ReadLine());
            double racketNum = double.Parse(Console.ReadLine());
            double shoeNum = double.Parse(Console.ReadLine());

            double shoepairPrice = racketpairPrice / 6;

            double racketPrice = racketNum * racketpairPrice;
            double shoePrice = shoeNum * shoepairPrice;
            double otherPrice = ((racketPrice + shoePrice) / 100) * 20;
            double totalPrice = racketPrice + shoePrice + otherPrice;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPrice * 7 / 8)}");

        }
    }
}
