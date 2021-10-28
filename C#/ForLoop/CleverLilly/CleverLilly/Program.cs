using System;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            double birthdays = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toyMoney = double.Parse(Console.ReadLine());

            double cashMoney = 0;

            double money = 0;
            double oddbirthdays = 0;


            for (int i = 1; i < birthdays + 1; i++)
            {
                if (i % 2 == 0)
                {
                    cashMoney += 10;
                    money += cashMoney;
                }

                else if (i % 2 != 0)
                {
                    money += toyMoney;
                    if (i != birthdays)
                        oddbirthdays += 1;                 //dava problemi pri nechetnoto
                }

            }
            money -= oddbirthdays;

            if (money >= price)
                Console.WriteLine($"Yes! {(money - price):f2}");
            else
                Console.WriteLine($"No! {(Math.Abs(price - money)):f2}");

            

            

        }
    }
}
