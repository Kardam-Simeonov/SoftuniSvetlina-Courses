using System;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double moneyPerson = (cakes * 45) + (waffles * 5.80) + (pancakes * 3.20);
            double moneyPeople = people * moneyPerson;
            double money = days * moneyPeople;
            double total = money - (money / 8);

            Console.WriteLine($"{total:f2}");


        }
    }
}
