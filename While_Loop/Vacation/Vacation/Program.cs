using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            double spendingDays = 0;
            double days = 0;

            while (true)
            {
                string action = Console.ReadLine();

                if (action == "spend")
                {
                    spendingDays++;
                    days++;
                    if (spendingDays == 5)
                        break;

                    double amount = double.Parse(Console.ReadLine());
                    if (money - amount < 0)
                        money = 0;
                    else
                        money -= amount;
                }
                else if (action == "save")
                {
                    spendingDays = 0;
                    days++;

                    double amount = double.Parse(Console.ReadLine());
                    money += amount;

                    if (money >= neededMoney)
                        break;
                }
            }

            if (spendingDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else if (money >= neededMoney)
                Console.WriteLine($"You saved the money for {days} days.");



        }
    }
}
